using Dapper;
using Project02.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02.Repository
{
    public class EmployeeRepository
    {
        private string connectionString;

        public EmployeeRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["database1"].ConnectionString;
        }

        public void Insert(Employee employee)
        {
            string query = "insert into employee (name, email, salary, position, department) values " +
                "(@name, @email, @salary, @position, @department)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, employee);
            }
        }

        public List<Employee> SelectAll()
        {
            string query = "select * from employee";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<Employee>(query).ToList();
            }
        }
    }
}
