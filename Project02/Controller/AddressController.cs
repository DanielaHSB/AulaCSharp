using Project02.Entity;
using Project02.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02.Controller
{
    public class AddressController
    {
        AddressRepository repository = new AddressRepository();

        public void InsertAddress()
        {
            Address address = new Address();
            Console.WriteLine("What is the street name?");
            address.StreetName = Console.ReadLine();
            Console.WriteLine("What is the street number?");
            address.StreetNumber = Console.ReadLine();
            Console.WriteLine("What is the postal code?");
            address.PostalCode = Console.ReadLine();
            Console.WriteLine("What is the city?");
            address.City = Console.ReadLine();
            Console.WriteLine("What is the province?");
            address.Province = Console.ReadLine();
            Console.WriteLine("What is the employee id?");
            address.IdEmployee = int.Parse(Console.ReadLine());
            repository.Insert(address);
            Console.WriteLine("Sucessfully saved.");
        }
        public void SelectAllAddress()
        {
            List<Address> list = repository.SelectAll();

/*            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Street Name: " + list[i].StreetName);

            }*/
            
            foreach (Address a in list)
            {
                Console.WriteLine("ID Address: " + a.IdAddress);
                Console.WriteLine("Street Name: " + a.StreetName);
                Console.WriteLine("Street Number: " + a.StreetNumber);
                Console.WriteLine("Postal Code: " + a.PostalCode);
                Console.WriteLine("City: " + a.City);
                Console.WriteLine("******************");
            }
        }

        public void SelectAddressById()
        {
            Console.WriteLine("What is the address ID?");
            int id = int.Parse(Console.ReadLine());
            Address a = repository.SelectById(id);
            Console.WriteLine("ID Address: " + a.IdAddress);
            Console.WriteLine("Street Name: " + a.StreetName);
            Console.WriteLine("Street Number: " + a.StreetNumber);
            Console.WriteLine("Postal Code: " + a.PostalCode);
            Console.WriteLine("City: " + a.City);
            Console.WriteLine("******************");
        }
    }


}
