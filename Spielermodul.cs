using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using WindowsFormsApp1;
using System.Drawing.Text;

namespace Vereinsmanager
{
    public partial class Spielermodul : Form
    {
        private XMLParser xmlParser = new XMLParser();
        private CSV_Parser parser;

        private Dictionary<int, string> formValues = new Dictionary<int, string>();

        private Player currentSelectedPlayer;
        public Spielermodul()
        {
            InitializeComponent();
            new Storage();
            parser = new CSV_Parser(Storage.players);
        }

        #region Entry Points


        private void CreatePlayer(object sender, EventArgs e)
        {
            UpdateValues();
            parser.AddObject(formValues);
        }

        private void DeletePlayer(object sender, EventArgs e)
        {
            UpdateValues();
            parser.DeleteObject(formValues);
        }

        private void EditPlayer(object sender, EventArgs e)
        {
            parser.DeleteObject(formValues);
            UpdateValues();
            parser.AddObject(formValues);
        }

        private void ImportDFBnetEntries(object sender, EventArgs e)
        {

        }

        #endregion


        #region Utility

        private void UpdateValues()
        {
            formValues.Clear();

            formValues.Add(1, tbLastname.Text);
            formValues.Add(2, tbFirstname.Text);
            formValues.Add(3, dtpBirthday.Value.ToShortDateString());
            formValues.Add(4, cbTeam.SelectedItem.ToString());
            formValues.Add(5, tbStreet.Text);
            formValues.Add(6, nudHouseNumber.Value.ToString());
            formValues.Add(7, nudZipCode.Value.ToString());
            formValues.Add(8, tbCity.Text);
            formValues.Add(9, tbTelephone.Text);
            formValues.Add(10, tbMail.Text);
            formValues.Add(11, cbActive.Checked.ToString());
        }

        #endregion


        #region Old Stuff
        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            Player spieler = new Player(
                            cbTeam.SelectedItem.ToString(),
                            dtpBirthday.Value,
                            tbMail.Text,
                            tbTelephone.Text,
                            (nudZipCode.Value + " " + tbCity.Text),
                            (tbStreet.Text + " " + nudHouseNumber.Value),
                            tbLastname.Text,
                            tbFirstname.Text,
                            cbActive.Checked,
                            xmlParser.GetHighestID(Storage.players)
                ) ;

            xmlParser.SetHighestID(Storage.players);
            xmlParser.AddPlayer(Storage.players,spieler);
            UpdateUI(cbTeam.SelectedItem.ToString());
        }


        private void UpdateUI(string jugendBez)
        {
            List<Player> spieler = xmlParser.GetSpielers(Storage.players,jugendBez);

            dgvPlayers.Rows.Clear();
            foreach (var item in spieler)
            {
                var index = dgvPlayers.Rows.Add();

                dgvPlayers.Rows[index].Cells["Vorname"].Value = item.Firstname;
                dgvPlayers.Rows[index].Cells["Nachname"].Value = item.Lastname;            
                dgvPlayers.Rows[index].Cells["Strasse"].Value = item.Address;
                dgvPlayers.Rows[index].Cells["Ort"].Value = item.City;
                dgvPlayers.Rows[index].Cells["Telefonnummer"].Value = item.Telephone;
                dgvPlayers.Rows[index].Cells["Email"].Value = item.Email;
                dgvPlayers.Rows[index].Cells["Geburtstag"].Value = item.Birthday.ToShortDateString();
                dgvPlayers.Rows[index].Cells["Aktiv"].Value = item.IsActive;
            }          
        }

        private void cbJugendSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateUI(cbJugendSelector.SelectedItem.ToString());
        }

        private void dgvPlayers_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvPlayers.CurrentCell.RowIndex;
            List<Player> spieler = xmlParser.GetSpielers(Storage.players, cbJugendSelector.SelectedItem.ToString());

            if (spieler.Count < 1)
            {
                return;
            }
            if (index >= spieler.Count)
            {
                index = spieler.Count - 1;
            }
           

            

            currentSelectedPlayer = spieler[index];

            tbCity.Text = currentSelectedPlayer.City;
            tbFirstname.Text = currentSelectedPlayer.Firstname;
            tbLastname.Text = currentSelectedPlayer.Lastname;
            tbMail.Text = currentSelectedPlayer.Email;
            tbTelephone.Text = currentSelectedPlayer.Telephone;
            tbStreet.Text = currentSelectedPlayer.Address.Remove(currentSelectedPlayer.Address.LastIndexOf(" "));
            int.TryParse(currentSelectedPlayer.Address.Substring(currentSelectedPlayer.Address.LastIndexOf(" ")), out int houseNumber);
            nudHouseNumber.Value = houseNumber;
            tbCity.Text = currentSelectedPlayer.City.Substring(currentSelectedPlayer.City.IndexOf(" ") + 1, currentSelectedPlayer.City.Length - currentSelectedPlayer.City.IndexOf(" ") - 1);
            int.TryParse(currentSelectedPlayer.City.Substring(0, currentSelectedPlayer.City.IndexOf(" ")), out int zipCode);
            nudZipCode.Value = zipCode;
            cbActive.Checked = currentSelectedPlayer.IsActive;
            dtpBirthday.Value = currentSelectedPlayer.Birthday;
            cbTeam.SelectedItem = cbJugendSelector.SelectedItem;
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            xmlParser.DeleteNode(Storage.players, cbTeam.SelectedItem.ToString(), currentSelectedPlayer);
            UpdateUI(cbTeam.SelectedItem.ToString());
        }

        private void btnEditPlayer_Click(object sender, EventArgs e)
        {
            Player spieler = new Player(
                            cbTeam.SelectedItem.ToString(),
                            dtpBirthday.Value,
                            tbMail.Text,
                            tbTelephone.Text,
                            (nudZipCode.Value + " " + tbCity.Text),
                            (tbStreet.Text + " " + nudHouseNumber.Value),
                            tbLastname.Text,
                            tbFirstname.Text,
                            cbActive.Checked,
                            currentSelectedPlayer.Id
                );

            xmlParser.DeleteNode(Storage.players, cbJugendSelector.SelectedItem.ToString(), currentSelectedPlayer);
            xmlParser.AddPlayer(Storage.players, spieler);
            UpdateUI(cbTeam.SelectedItem.ToString());
        }

        private void btnAutoImport_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\Documents";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        List<string> firstname = new List<string>();
                        List<string> lastname = new List<string>();
                        List<string> team = new List<string>();
                        List<DateTime> birthday = new List<DateTime>();
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(';');

                            if (values.Length < 3 || line.Contains("Passnr."))
                            {
                                continue;
                            }

                            firstname.Add(values[2]);
                            lastname.Add(values[1]);
                            team.Add(values[3]);
                            birthday.Add(DateTime.Parse(values[4]));
                        }
                        Console.Write("Ended analysis");

                        for (int i = 0; i < 20; i++)
                        {
                            Player spieler = new Player(
                                GetTeam(team[i]),
                                birthday[i],
                                "-",
                                "-",
                                "1 -",
                                "- 1",
                                lastname[i],
                                firstname[i],
                                true,
                                xmlParser.GetHighestID(Storage.players));

                            /* if (xmlParser.CheckIfObjectExists(Storage.players, spieler) > -1)
                            {
                                var playerXML = xmlParser.GetSpielers(Storage.players);
                            }
                            else
                            {

                            }*/
                            xmlParser.AddPlayer(Storage.players, spieler);

                        }
                        



                    }
                }
            }

        }

        private string GetTeam(string DFBnetName)
        {
            if (DFBnetName.Contains("G-Junior"))
            {
                return "Bambini";
            }
            else if (DFBnetName.Contains("F-Junior"))
            {
                return "F-Jugend";
            }
            else if (DFBnetName.Contains("E-Junior"))
            {
                return "E-Junioren";
            } 
            else if (DFBnetName.Contains("D-Junior"))
            {
                return "D-Junioren";
            } 
            else if (DFBnetName.Contains("C-Junior"))
            {
                return "C-Junioren";
            }
            else if (DFBnetName.Contains("B-Junior"))
            {
                return "B-Junioren";
            }
            else if (DFBnetName.Contains("A-Junior"))
            {
                return "A-Junioren";
            }
            else
            {
                return "Archiv";
            }
        }
    }

    #endregion
}

