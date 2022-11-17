using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


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
            standardInput = "id, lastname, firstname, birthday, team, street, house number, zip code, city, telephone, email, active";
            SaveFile(standardInput);
        }

        public void AddObject(Dictionary<int,string> input)
        {
            string content = LoadFile();
            content += "\n" + StringConcatenator(input);
            SaveFile(content);
        }

        public void DeleteObject(Dictionary<int, string> values)
        {
            List<string> content = LoadFile().Split((char)10).ToList();
            var searchString = CreateRegexSearchString(values);

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

        public List<string> GetObject(Dictionary<int, string> values)
        {
            List<string> content = LoadFile().Split((char)10).ToList();
            var searchString = CreateRegexSearchString(values);

            foreach (string line in content)
            {
                if (Regex.IsMatch(line, searchString))
                {
                    return line.Split(new char[] { ';' }).ToList();
                }

            }
            return null;
        }

        public void EditObject(List<string> oldValues, Dictionary<int, string> values)
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

        private string StringConcatenator(Dictionary<int,string> content)
        {
            string output = "";
            foreach (var item in content)
            {
                var input = item + ",";
                output += input;
            }

            return output;
        }

        private string CreateRegexSearchString(Dictionary<int, string> values)
        {
            string regex = "";

            for (int i = 0; i < totalColumns; i++)
            {
                string value;

                if (values.ContainsKey(i))
                {
                    values.TryGetValue(i, out value);
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
