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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDataFiles();


            
            
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


            if (!File.Exists(path + "spielerliste.xml"))
            {
                File.Create(path + "spielerliste.xml");
            }
        }
    }
}
