using Project02.Entity;
using System;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using System.Linq;

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
        public void Update(Address address)
        {
            string query = "update address set streetname = @streetname, streetnumber = @streetnumber" +
                ", postalcode = @postalcode, city = @city, province = @province, idemployee = @idemployee" +
                " where IdAddress = @idaddress";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, address);
            }
        }
        public void Delete(int id)
        {
            string query = "delete from address where IdAddress = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, new {IdAddress = id});
            }
        }
        public List<Address> SelectAll()
        {
            string query = "select * from address";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<Address>(query).ToList();
            }
        }
        public Address SelectById(int id)
        {
            string query = "select * from address where IdAddress=@id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                return connection.QuerySingleOrDefault<Address>(query, new { IdAddress = id });
            }
        }

    }
}
