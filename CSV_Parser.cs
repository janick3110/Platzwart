using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CSV_Parser
    {
        private string pathToDocument;

        public CSV_Parser(string pathToDocument)
        {
            this.pathToDocument = pathToDocument;
        }

        public void ResetCSVFile()
        {
            string standardInput = "id, lastname, firstname, birthday, street, house number, zip code, city, telephone, email, acive";
            standardInput = Encryption.DoEncryption(standardInput);
            File.WriteAllText(pathToDocument, standardInput);
        }

        public void AddObject(List<string> input)
        {

        }

        public void DeleteObject(List<string> values, List<int> columnIDs)
        {

        }

        public List<string> GetObject(List<string> values, List<int> columnIDs)
        {
            return null;
        }

        public void EditObject(List<string> oldValues, List<string> newValues, List<int> columnIDs)
        {

        }
    }
}
