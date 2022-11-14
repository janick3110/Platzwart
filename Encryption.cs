using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsFormsApp1
{
    public class Encryption
    {
        private static int chunkSize = 8;
        private static int keySize = 1024;

        private static char[,] encryptor = new char[16,16];

        #region Entry Points
        public static string DoEncryption(string text)
        {
            GenerateEncryptor();
            return Encrypt(text);

        }

        public static string DoDecryption(string text)
        {
            GenerateEncryptor();
            var settings = ReadSettings(text);
            text = text.Substring(text.LastIndexOf("FF") + GetDigits(settings[2]) + 2);
            var chunks = GenerateDecryptionChunks(text, settings[0], settings[1]);
            string decrypted = Decrypt(chunks, settings[1], settings[2]);
            Console.Write(decrypted);
            return decrypted;   
        }
        #endregion

        #region Encryption

        private static string CreateKey()
        {
            string key = "";
            Random random = new Random();

            for (int i = 0; i < keySize; i++)
            {
                key += (random.Next(0, 14)).ToString("00");
            }

            return key;
        }

        private static string Encrypt(string text)
        {
            double chunks = text.Length / (double)chunkSize;
            int differenceInCharacters = (int)((1 - (chunks - Math.Truncate(chunks))) * chunkSize);
            text = AddRatTail(text, differenceInCharacters);

            chunks = ((text.Length)) / (double)chunkSize;

            string encryptedText = GenerateHeader(differenceInCharacters);

            for (int i = 0; i < chunks; i++)
            {
                var segment = text.Substring(i * chunkSize, chunkSize);
                var key = CreateKey();
                MoveRowsAndColumns(key);
                encryptedText += key + EncryptStringSegment(segment);
            }
            Console.WriteLine(encryptedText);
            return encryptedText;
        }

        private static string AddRatTail(string text, int length)
        {
            var r = new Random();
            for (int i = 0; i < length; i++)
            {
                text += (char)r.Next(0, 255);
            }

            return text;
        }


        private static string GenerateHeader(int ratTail)
        {
            int counter;

            int ratTailDigits = GetDigits(ratTail);

            if (keySize > chunkSize)
            {
                counter = GetDigits(keySize);
            }
            else
            {
                counter = GetDigits(chunkSize);
            }
            string format = "";

            for (int i = 0; i < counter; i++)
            {
                format += "0";
            }

            string header = (counter * 2).ToString() +
                "FF" +
                chunkSize.ToString(format) +
                keySize.ToString(format) +
                (ratTailDigits).ToString()
                + "FF" + ratTail;

            return header;
        }

        private static string EncryptStringSegment(string segment)
        {
            string encrypted = "";
            for (int i = 0; i < segment.Length; i++)
            {
                encrypted += GetCoordinates(segment[i]);
            }

            return encrypted;
        }

        private static string GetCoordinates(char c)
        {
            for (int x = 0; x < encryptor.GetLength(0); x++)
            {
                for (int y = 0; y < encryptor.GetLength(1); y++)
                {
                    if (c == encryptor[x, y])
                    {
                        return x.ToString("00") + y.ToString("00");

                    }
                }
            }
            return "0000";
        }

        #endregion


        #region Decryption

        private static int[] ReadSettings(string encryptedText)
        {
            int[] settings = new int[3];

            int readKeySize = 0;
            int readChunkSize = 0;

            int.TryParse(encryptedText.Substring(0, encryptedText.IndexOf("FF")), out int digits);
            var shortText = encryptedText.Substring(encryptedText.IndexOf("FF") + 2);
            int.TryParse(shortText.Substring(0, digits / 2), out readChunkSize);
            int.TryParse(shortText.Substring(digits / 2, digits / 2), out readKeySize);

            shortText = encryptedText.Substring(encryptedText.IndexOf("FF") + 2 + digits);
            int.TryParse(shortText.Substring(0, shortText.IndexOf("FF")), out digits);
            shortText = shortText.Substring(0, encryptedText.LastIndexOf("FF"));
            int.TryParse(shortText.Substring(shortText.IndexOf("FF") + 2, digits), out int readRatTail);

            settings[0] = readChunkSize;
            settings[1] = readKeySize;
            settings[2] = readRatTail;

            return settings;

        }

        private static string Decrypt(List<string> chunks, int keySize, int ratTail)
        {
            string decryptedText = "";

            for (int i = 0; i < chunks.Count; i++)
            {
                MoveRowsAndColumns(chunks[i].Substring(0, keySize * 2));
                decryptedText += DecryptWithMatrix(chunks[i].Substring(keySize * 2));

            }
            decryptedText = decryptedText.Substring(0, decryptedText.Length - ratTail);
            return decryptedText;
        }

        private static string DecryptWithMatrix(string encryptedText)
        {
            string result = "";

            for (int i = 0; i < encryptedText.Length; i += 4)
            {
                int.TryParse(encryptedText.Substring(i, 2), out int x);
                int.TryParse(encryptedText.Substring(i + 2, 2), out int y);

                result += encryptor[x, y];

            }

            return result;

        }

        private static List<string> GenerateDecryptionChunks(string text, int sizeOfChunk, int sizeOfKey)
        {
            List<string> chunks = new List<string>();

            for (int i = 0; i < text.Length; i += sizeOfChunk * 4 + sizeOfKey * 2)
            {
                chunks.Add(text.Substring(i, sizeOfKey * 2 + sizeOfChunk * 4));
            }

            return chunks;
        }


        #endregion

        #region Utility
        private static void GenerateEncryptor()
        {
            //prepare encryptor
            int counter = 0;
            for (int x = 0; x < encryptor.GetLength(0); x++)
            {
                for (int y = 0; y < encryptor.GetLength(1); y++)
                {
                    encryptor[x, y] = (char)counter;
                    counter++;
                }
            }
        }

        private static int GetDigits(int n)
        {
            return n == 0L ? 1 : (n > 0L ? 1 : 2) + (int)Math.Log10(Math.Abs((double)n));
        }

        private static void MoveRowsAndColumns(string key)
        {
            var pairs = GenerateSplittingCoordinates(key);



            for (int i = 0; i < pairs.Count; i++)
            {
                if (i % 2 == 0)
                {
                    for (int x = 0; x < encryptor.GetLength(0); x++)
                    {
                        var temp = encryptor[x, pairs[i]];
                        encryptor[x, pairs[i]] = encryptor[x, pairs[i] + 1];
                        encryptor[x, pairs[i] + 1] = temp;
                    }
                }
                else
                {
                    for (int y = 0; y < encryptor.GetLength(1); y++)
                    {
                        var temp = encryptor[pairs[i], y];
                        encryptor[pairs[i], y] = encryptor[pairs[i] + 1, y];
                        encryptor[pairs[i] + 1, y] = temp;
                    }
                }

            }
            Console.WriteLine(pairs);

        }

        static List<int> GenerateSplittingCoordinates(string key)
        {
            List<int> coordinates = new List<int>();

            for (int i = 0; i < key.Length; i += 2)
            {
                var segment = key.Substring(i, 2);
                int.TryParse(segment, out int coordinate);
                coordinates.Add(coordinate);
            }

            return coordinates;
        }


        private static void Output(int i)
        {
            Console.WriteLine("#####OUTPUT AFTER " + i + " ITERATIONS#####");
            for (int x = 0; x < encryptor.GetLength(0); x++)
            {
                string line = "";
                for (int y = 0; y < encryptor.GetLength(1); y++)
                {
                    line += encryptor[x, y] + " ";
                }
                Console.WriteLine(line);
            }
        }
        #endregion

    }
}
