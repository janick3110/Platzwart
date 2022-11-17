using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Vereinsmanager
{
    public class Player
    {
        private string firstname;
        private string lastname;
        private string address;
        private string city;
        private string telephone;
        private string email;
        private DateTime birthday;
        private string team;
        private bool isActive;
        private int id;

        public string Team { get => team; set => team = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Email { get => email; set => email = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string City { get => city; set => city = value; }
        public string Address { get => address; set => address = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public int Id { get => id; set => id = value; }

        public Player(string team, 
            DateTime birthday, 
            string email, string 
            telephone, string city,
            string address, 
            string lastname, 
            string firstname,
            bool isActive,
            int id)
        {
            Team = team;
            Birthday = birthday;
            Email = email;
            Telephone = telephone;
            City = city;
            Address = address;
            Lastname = lastname;
            Firstname = firstname;
            IsActive = isActive;
            Id = id;
        }

        public Dictionary<int, string> GetValues()
        {
            /*"id, lastname, firstname, birthday, team, street, house number, zip code, city, telephone, email, active"
            //            formValues.Add(1, tbLastname.Text);
            formValues.Add(2, tbFirstname.Text);
            formValues.Add(3, dtpBirthday.Value.ToShortDateString());
            formValues.Add(4, cbTeam.SelectedItem.ToString());
            formValues.Add(5, tbStreet.Text);
            formValues.Add(6, nudHouseNumber.Value.ToString());
            formValues.Add(7, nudZipCode.Value.ToString());
            formValues.Add(8, tbCity.Text);
            formValues.Add(9, tbTelephone.Text);
            formValues.Add(10, tbMail.Text);
            formValues.Add(11, cbActive.Checked.ToString()); ;
            */

            Dictionary<int,string> values = new Dictionary<int, string>();

            values.Add(0,id.ToString());
            values.Add(1, Lastname);
            values.Add(2, Firstname);
            values.Add(3, Birthday.ToShortDateString());
            values.Add(4,Team);
            try
            {
                values.Add(5, Address.Split(' ')[0]);
                values.Add(6, Address.Split(' ')[1]);
            }
            catch
            {
                values.Add(5, " ");
                values.Add(6, "1");
            }
            try
            {
                values.Add(7, City.Split(' ')[0]);
                values.Add(8, City.Split(' ')[1]);
            }
            catch
            {
                values.Add(7, "1");
                values.Add(8, " ");
            }
            
            values.Add(9, Telephone);
            values.Add(10, Email);
            values.Add(12, IsActive.ToString());

            return values;

        }
    }

}
