using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01
{
    public class Client
    {
        private int idClient;
        private string name;
        private string email;

        public int IdClient { get => idClient; set => idClient = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }

        public Client(string name, string email)
        {
            this.Name = name;
            this.Email = email;

        }

        public Client()
        {

        }


    }
}
