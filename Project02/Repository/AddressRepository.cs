using Project02.Entity;
using System;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace Project02.Repository
{
    public class AddressRepository
    {
        private string connectionString;

        public AddressRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["database1"].ConnectionString;
        }
        public void Insert(Address address)
        {
            string query = "insert into address (streetname, streetnumber, postalcode, city, province, idemployee) values " +
                "(@streetname, @streetnumber, @postalcode, @city, @province, @idemployee)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, address);
            }
        }

    }
}
