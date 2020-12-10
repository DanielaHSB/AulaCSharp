using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02.Entity
{
    public class Employee : Person
    {
        private int idEmployee;
        private double salary;
        private string position;
        private string department;
        private Address address;

        public double Salary { get => salary; set => salary = value; }
        public string Position { get => position; set => position = value; }
        public string Department { get => department; set => department = value; }
        public Address Address { get => address; set => address = value; }
        public int IdEmployee { get => idEmployee; set => idEmployee = value; }

        public Employee(string name, string email, double salary, string position, string department)
            : base (name, email)
        {
            this.salary = salary;
            this.position = position;
            this.department = department;
        }

        public Employee(double salary, string position, string department)
        {
            this.salary = salary;
            this.position = position;
            this.department = department;
        }
        public Employee()
        {
                
        }
    }
}
