using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01
{
    public class ClientRepository
    {
        private string connectionString;

        public ClientRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["banco"].ConnectionString;
        }

        public void Insert(Client client)
        {
            string query = "insert into client (name,email) values (@name, @email)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", client.Name);
                command.Parameters.AddWithValue("@email", client.Email);
                command.ExecuteNonQuery();
            }
        }

        public List<Client> SelectAll()
        {
            string query = "select * from client";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();
                List<Client> lista = new List<Client>();
                while (reader.Read())
                {
                    Client client = new Client();
                    client.IdClient = Convert.ToInt32(reader["id"]);
                    client.Name = Convert.ToString(reader["name"]);
                    client.Email = Convert.ToString(reader["email"]);

                    lista.Add(client);
                }
                return lista;

            }
        }
        public Client SelectClientById(int id)
        {
            string query = "select * from client where id=@id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Client client = new Client();
                    client.IdClient = Convert.ToInt32(reader["id"]);
                    client.Name = Convert.ToString(reader["name"]);
                    client.Email = Convert.ToString(reader["email"]);
                    return client;
                }
                return null;
            }
        }

    }
}
