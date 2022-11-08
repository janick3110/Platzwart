using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Vereinsmanager
{
    public class XMLParser
    {
        public void AddPlayer(string pathToDocument, Spieler player)
        {
            XmlDocument doc = new XmlDocument();

            

            doc.Load(pathToDocument);

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

            //Add the node to the document.
            spieler.AppendChild(firstname);
            spieler.AppendChild(lastname);
            spieler.AppendChild(birthday);
            spieler.AppendChild(address);
            spieler.AppendChild(city);
            spieler.AppendChild(telephone);
            spieler.AppendChild(email);


            doc.Save(pathToDocument);
        }


        public List<Spieler> GetSpielers(string pathToDocument, string jugendBez)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(pathToDocument);


            List<Spieler> spieler = new List<Spieler>();

            XmlElement root = doc.DocumentElement;
            string path = "//" + jugendBez + "/player";
            XmlNodeList aktuelleSpieler = root.SelectNodes(path);

            foreach (XmlNode player in aktuelleSpieler)
            {
                XmlNodeList attributes = player.ChildNodes;
                Spieler spielendePerson = new Spieler(
                    jugendBez,
                    Convert.ToDateTime(attributes[2].InnerText),
                    attributes[6].InnerText,
                    attributes[5].InnerText,
                    attributes[4].InnerText,
                    attributes[3].InnerText,
                    attributes[1].InnerText,
                    attributes[0].InnerText
                    );
                spieler.Add(spielendePerson);
            }



            return spieler;
        }
    }
}
