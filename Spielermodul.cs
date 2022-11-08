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
                            (tbZipCode.Text + " " + tbStreet.Text),
                            (tbStreet.Text + " " + tbSHouseNumber.Text),
                            tbLastname.Text,
                            tbFirstname.Text
                );


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
            }          
        }

        private void cbJugendSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateUI(cbJugendSelector.SelectedItem.ToString());
        }

        private void dgvPlayers_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
 }

