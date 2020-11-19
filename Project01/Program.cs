using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("Jose", "jose@abc.ca");
            Client client2 = new Client("Joao", "joao@abc.ca");
            Client client3 = new Client("Mariana", "mari@abc.ca");
            ClientRepository repository = new ClientRepository();
 /*           repository.Insert(client1);
            repository.Insert(client2);
            repository.Insert(client3);*/
            Console.WriteLine("Cliente cadastrado com sucesso");
            /*            List<Client> listClients = repository.SelectAll();*/
            /*            foreach(Client c in listClients)
                        {
                            Console.WriteLine("Name: " + c.Name);
                            Console.WriteLine("Email: " + c.Email);
                        }*/
            /*            for(int i=0; i<listClients.Count; i++)
                        {
                            Console.WriteLine("Name: " + listClients[i].Name);
                            Console.WriteLine("Email: " + listClients[i].Email);
                        }*/
            Console.WriteLine("Digite ID: ");
            int id = int.Parse(Console.ReadLine());
            Client client = repository.SelectClientById(id);
            Console.WriteLine("Cliente: " + client.Name);
            Console.ReadKey();
        }
    }
}
