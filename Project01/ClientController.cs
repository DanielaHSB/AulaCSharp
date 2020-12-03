using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01
{
    public class ClientController
    {
        ClientRepository repository = new ClientRepository();
        public void InsertClient()
        {
            Client client = new Client();
            Console.WriteLine("What is your name?");
            client.Name = Console.ReadLine();
            Console.WriteLine("What is your email?");
            client.Email = Console.ReadLine();
            repository.Insert(client);
            Console.WriteLine("Saved sucessfully.");
        }

        public void SelectAllClients()
        {
            List<Client> list = repository.SelectAll();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("ID: " + list[i].IdClient);
                Console.WriteLine("Name: " + list[i].Name);
                Console.WriteLine("Email: " + list[i].Email);
            }
        }

        public void SelectClientById()
        {
            Console.WriteLine("What is the Client's ID?");
            int id = int.Parse(Console.ReadLine());
            Client client = repository.SelectById(id);
            Console.WriteLine("ID: " + client.IdClient);
            Console.WriteLine("Name: " + client.Name);
            Console.WriteLine("Email: " + client.Email);
        }

        public void DeleteClient()
        {
            Console.WriteLine("What is the Client's ID?");
            int id = int.Parse(Console.ReadLine());
            repository.Delete(id);
            Console.WriteLine("Deleted sucessfully.");
        }

        public void UpdateClient()
        {
            Client client = new Client();
            Console.WriteLine("What is the Client's ID?");
            client.IdClient = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the Client's name?");
            client.Name = Console.ReadLine();
            Console.WriteLine("What is the Client's email?");
            client.Email = Console.ReadLine();
            repository.Update(client);
            Console.WriteLine("Updated sucessfully.");
        }
    }
}
