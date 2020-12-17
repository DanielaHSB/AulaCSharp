using Project02.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeController employeeController = new EmployeeController();
            //employeeController.InsertEmployee();

            AddressController addressController = new AddressController();
            //addressController.InsertAddress();

            //employeeController.SelectAllEmployees();

            addressController.SelectAllAddress();

            Console.ReadKey();


            
        }
    }
}
