using Project02.Entity;
using Project02.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02.Controller
{
    public class EmployeeController
    {
        EmployeeRepository repository = new EmployeeRepository();
        public void InsertEmployee()
        {
            Employee employee = new Employee();
            Console.WriteLine("What is your name?");
            employee.Name = Console.ReadLine();
            Console.WriteLine("What is your email?");
            employee.Email = Console.ReadLine();
            Console.WriteLine("What is your salary?");
            employee.Salary = double.Parse (Console.ReadLine());
            Console.WriteLine("What is your position?");
            employee.Position = Console.ReadLine();
            Console.WriteLine("What is your deparment?");
            employee.Department = Console.ReadLine();
            repository.Insert(employee);
            Console.WriteLine("Saved sucessfully.");
        }
        public void SelectAllEmployees()
        {
            Console.WriteLine("*Employee List*");
            List<Employee> list = repository.SelectAll();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("ID: " + list[i].IdEmployee);
                Console.WriteLine("Name: " + list[i].Name);
                Console.WriteLine("Email: " + list[i].Email);
                Console.WriteLine("Salary: " + list[i].Salary);
                Console.WriteLine("Position: " + list[i].Position);
                Console.WriteLine("Department: " + list[i].Department);
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
