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

namespace Vereinsmanager
{
    public partial class Spielermodul : Form
    {
        private XMLParser xmlParser;
        private Storage storage;

        private Spieler currentSelectedPlayer;
        public Spielermodul()
        {
            InitializeComponent();
            xmlParser = new XMLParser();
            storage = new Storage();
            Console.WriteLine(xmlParser.ToString());
        }

        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            Spieler spieler = new Spieler(
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
            List<Spieler> spieler = xmlParser.GetSpielers(Storage.players,jugendBez);

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
            List<Spieler> spieler = xmlParser.GetSpielers(Storage.players, cbJugendSelector.SelectedItem.ToString());

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
            Spieler spieler = new Spieler(
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
    }
 }

