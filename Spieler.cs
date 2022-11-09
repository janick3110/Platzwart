using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vereinsmanager
{
    public class Spieler
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

        public Spieler(string team, 
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
    }

}
