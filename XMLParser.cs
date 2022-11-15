using System;

using System.Collections.Generic;
using System.IO;

using System.Text;

using System.Xml;
using System.Xml.Linq;
using WindowsFormsApp1;
using System.Collections;
using System.Linq;


namespace Vereinsmanager
{
    public class XMLParser
    {
        public void AddPlayer(string pathToDocument, Spieler player)
        {

            XmlDocument doc = LoadDocument(pathToDocument);

            XmlElement root = doc.DocumentElement;
            string path = "//" + player.Team;
            XmlNode jugend = root.SelectSingleNode(path);
            XmlNode spieler = doc.CreateElement("player");
            jugend.AppendChild(spieler);

            //XmlNode jugend = doc.SelectSingleNode(path);
            
            XmlElement firstname = doc.CreateElement("Firstname");
            firstname.InnerText = player.Firstname;
            XmlElement lastname = doc.CreateElement("Lastname");
            lastname.InnerText = player.Lastname;
            XmlElement birthday = doc.CreateElement("Birthday");
            birthday.InnerText = player.Birthday.ToShortDateString();
            XmlElement telephone = doc.CreateElement("Telephone");
            telephone.InnerText = player.Telephone.ToString();
                
            XmlElement email = doc.CreateElement("Email");
            email.InnerText = player.Email.ToString();
            XmlElement address = doc.CreateElement("Adress");
            address.InnerText = player.Address.ToString();
            XmlElement city = doc.CreateElement("City");
            city.InnerText = player.City.ToString();
            XmlElement activeStatus = doc.CreateElement("Active");
            activeStatus.InnerText = player.IsActive.ToString();

            XmlElement id = doc.CreateElement("id");
            id.InnerText = player.Id.ToString();    
            //Add the node to the document.
            spieler.AppendChild(id);
            spieler.AppendChild(firstname);
            spieler.AppendChild(lastname);
            spieler.AppendChild(birthday);
            spieler.AppendChild(address);
            spieler.AppendChild(city);
            spieler.AppendChild(telephone);
            spieler.AppendChild(email);
            spieler.AppendChild(activeStatus);

            SaveDocument(pathToDocument, doc.InnerXml);
        }


        public List<Spieler> GetSpielers(string pathToDocument, string jugendBez)
        {
            XmlDocument doc = LoadDocument(pathToDocument);


            List<Spieler> spieler = new List<Spieler>();

            XmlElement root = doc.DocumentElement;
            string path = "//" + jugendBez + "/player";
            XmlNodeList aktuelleSpieler = root.SelectNodes(path);

            foreach (XmlNode player in aktuelleSpieler)
            {
                XmlNodeList attributes = player.ChildNodes;
                int.TryParse(attributes[0].InnerText, out int id);
                Spieler spielendePerson = new Spieler(
                    jugendBez,
                    Convert.ToDateTime(attributes[3].InnerText),
                    attributes[7].InnerText,
                    attributes[6].InnerText,
                    attributes[5].InnerText,
                    attributes[4].InnerText,
                    attributes[2].InnerText,
                    attributes[1].InnerText,
                    attributes[8].InnerText.Equals("True"),
                    id
                    ) ;
                spieler.Add(spielendePerson);
            }



            return spieler;
        }

        public void DeleteNode(string path, string jugendBez, Spieler spielerZuLoeschen)
        {
            XmlDocument doc = LoadDocument(path);
            string nodePath = "//" + jugendBez + "/player";
            XmlNodeList nodes = doc.SelectNodes(nodePath);

            foreach (XmlNode node in nodes)
            {
                if (node["id"].InnerText == spielerZuLoeschen.Id.ToString())
                {
                    node.ParentNode.RemoveChild(node);
                    SaveDocument(path, doc.InnerXml);
                    return;
                }
            }

            /*for (int i = nodes.Count - 1; i >= 0; i--)
            {
                nodes[i].ParentNode.RemoveChild(nodes[i]);
            }*/
            SaveDocument(path, doc.InnerXml);

            


        }


        public int GetHighestID(string pathToDocument)
        {
            XmlDocument doc = LoadDocument(pathToDocument);

            XmlElement root = doc.DocumentElement;
            string path = "//" + "maxID";
            XmlNode xmlNode = root.SelectSingleNode(path);

            int.TryParse(xmlNode.InnerText, out int id);
            return id;
        }


        public void SetHighestID(string pathToDocument)
        {
            XmlDocument doc = LoadDocument(pathToDocument);

            XmlElement root = doc.DocumentElement;
            string path = "//" + "maxID";
            XmlNode xmlNode = root.SelectSingleNode(path);

            xmlNode.InnerText = (GetHighestID(pathToDocument) + 1).ToString();

            SaveDocument(pathToDocument, doc.InnerXml);
        }

        public XmlDocument LoadDocument(string pathToDocument)
        {
            string text = File.ReadAllText(pathToDocument, Encoding.UTF8);
            text = Encryption.DoDecryption(text);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(text);
            return doc;
        }

        public void SaveDocument(string pathToDocument, string content)
        {
            content = Encryption.DoEncryption(content);
            File.WriteAllText(pathToDocument, content);

        }
    }
}
