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

    }


}
