using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public class CSV_Parser
    {
        private string pathToDocument;
        private int totalColumns = 11;

        #region Entry Points

        public CSV_Parser(string pathToDocument)
        {
            this.pathToDocument = pathToDocument;
        }


        public void ResetCSVFile(string standardInput)
        {
            standardInput = "id, lastname, firstname, birthday, street, house number, zip code, city, telephone, email, acive";
            SaveFile(standardInput);
        }

        public void AddObject(List<string> input)
        {
            string content = LoadFile();
            content += "\n" + StringConcatenator(input);
            SaveFile(content);
        }

        public void DeleteObject(List<string> values, List<int> columnIDs)
        {
            List<string> content = LoadFile().Split((char)10).ToList();
            var searchString = CreateRegexSearchString(values, columnIDs);

            string newFileContent = "";

            foreach(string line in content)
            {
                if (Regex.IsMatch(line,searchString))
                {
                    continue;
                }
                newFileContent += line + "\n";
            }

            SaveFile(newFileContent);

        }

        public List<string> GetObject(List<string> values, List<int> columnIDs)
        {
            List<string> content = LoadFile().Split((char)10).ToList();
            var searchString = CreateRegexSearchString(values, columnIDs);

            foreach (string line in content)
            {
                if (Regex.IsMatch(line, searchString))
                {
                    return line.Split(new char[] { ';' }).ToList();
                }

            }
            return null;
        }

        public void EditObject(List<string> oldValues, List<string> newValues, List<int> columnIDs)
        {
            string content = LoadFile();


            SaveFile(content);
        }
        #endregion

        #region Local Functions

        private string LoadFile()
        {
            return Encryption.DoDecryption(File.ReadAllText(pathToDocument, Encoding.UTF8));
        }

        private void SaveFile(string content)
        {
            File.WriteAllText(pathToDocument, Encryption.DoEncryption(content));
        }

        private string StringConcatenator(List<string> content)
        {
            string output = "";
            foreach (var item in content)
            {
                var input = item + ",";
                output += input;
            }

            return output;
        }

        private string CreateRegexSearchString(List<string> values, List<int> columnIDs)
        {
            string regex = "";
            int index = 0;
            for (int i = 0; i < totalColumns; i++)
            {
                string value;
                if (columnIDs.Contains(i))
                {
                    value = values[index] + ",";
                    index++;
                }
                else
                {
                    value = ".*,";
                }

                regex += value;
            }


            return regex;
        }

        #endregion

    }
}
