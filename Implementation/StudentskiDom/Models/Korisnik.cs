using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiDom.Models
{
    public class Korisnik
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Korisnik()
        {
            Username = "";
            Password = "";
        }

        public Korisnik(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
