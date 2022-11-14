using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Vereinsmanager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDataFiles();

            //var text = Encryption.DoEncryption("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<verein>\r\n  <maxID>12</maxID>\r\n  <A-Jugend>\r\n    <player>\r\n      <id>0</id>\r\n      <Firstname>Janick</Firstname>\r\n      <Lastname>Kaltenmark</Lastname>\r\n      <Birthday>31.10.2000</Birthday>\r\n      <Adress>Hechinger Straße 120</Adress>\r\n      <City>72108 Dettingen</City>\r\n      <Telephone>01774674641</Telephone>\r\n      <Email>janick3110@gmail.com</Email>\r\n      <Active>true</Active>\r\n    </player>\r\n    <player>\r\n      <id>1</id>\r\n      <Firstname>Christin</Firstname>\r\n      <Lastname>Krauß</Lastname>\r\n      <Birthday>30.01.2001</Birthday>\r\n      <Adress>Tannenäcker 12</Adress>\r\n      <City>72108 Rottenburg</City>\r\n      <Telephone>016230012001</Telephone>\r\n      <Email>krauss.christin@gmail.com</Email>\r\n      <Active>true</Active>\r\n    </player>\r\n    <player>\r\n      <id>11</id>\r\n      <Firstname>Karin</Firstname>\r\n      <Lastname>Raiser</Lastname>\r\n      <Birthday>31.10.2000</Birthday>\r\n      <Adress>Hechinger Straße 120</Adress>\r\n      <City>72108 Dettingen</City>\r\n      <Telephone>01774674641</Telephone>\r\n      <Email>janick3110@gmail.com</Email>\r\n      <Active>False</Active>\r\n    </player>\r\n  </A-Jugend>\r\n  <B-Jugend>\r\n  </B-Jugend>\r\n  <C-Jugend>\r\n  </C-Jugend>\r\n  <D-Jugend>\r\n  </D-Jugend>\r\n  <E-Jugend>\r\n  </E-Jugend>\r\n  <F-Jugend>\r\n  </F-Jugend>\r\n  <Bambini>\r\n    <player>\r\n      <id>2</id>\r\n      <Firstname>Mausi</Firstname>\r\n      <Lastname>Maus</Lastname>\r\n      <Birthday>30.01.2001</Birthday>\r\n      <Adress>Käsestraße 1</Adress>\r\n      <City>12345 Käsestadt</City>\r\n      <Telephone>1234567890</Telephone>\r\n      <Email>mausi@bebsi.de</Email>\r\n      <Active>true</Active>\r\n    </player>\r\n  </Bambini>\r\n  <Archiv>\r\n    <player>\r\n      <id>8</id>\r\n      <Firstname>Mausi</Firstname>\r\n      <Lastname>Maus</Lastname>\r\n      <Birthday>30.01.2001</Birthday>\r\n      <Adress>Käsestraße 1</Adress>\r\n      <City>12345 Käsestadt</City>\r\n      <Telephone>1234567890</Telephone>\r\n      <Email>mausi@bebsi.de</Email>\r\n      <Active>True</Active>\r\n    </player>\r\n    <player>\r\n      <id>9</id>\r\n      <Firstname>Christin</Firstname>\r\n      <Lastname>Krauß</Lastname>\r\n      <Birthday>30.01.2001</Birthday>\r\n      <Adress>Tannenäcker 12</Adress>\r\n      <City>72108 Rottenburg</City>\r\n      <Telephone>016230012001</Telephone>\r\n      <Email>krauss.christin@gmail.com</Email>\r\n      <Active>True</Active>\r\n    </player>\r\n    <player>\r\n      <id>10</id>\r\n      <Firstname>Janick</Firstname>\r\n      <Lastname>Kaltenmark</Lastname>\r\n      <Birthday>31.10.2000</Birthday>\r\n      <Adress>Hechinger Straße 120</Adress>\r\n      <City>72108 Dettingen</City>\r\n      <Telephone>01774674641</Telephone>\r\n      <Email>janick3110@gmail.com</Email>\r\n      <Active>False</Active>\r\n    </player>\r\n  </Archiv>\r\n</verein>");
            //Encryption.DoDecryption("2FF881FF5011213130604060905080602061206120615020004070605011213130604060906120704020102041205151315140707");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var childForm = new Spielermodul();
            childForm.Show();
        }

        private void LoadDataFiles()
        {
            string path = Path.Combine(Environment.CurrentDirectory, @".Data\");
            if (!Directory.Exists(path))
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }


            if (!File.Exists(path + "spielerliste.dat"))
            {
                File.Create(path + "spielerliste.dat");
            }
        }
    }
}
