using DataLayer.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataLayer
{
    public class GuestRepository
    {
        private string connectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=MyHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Guest> GetAllGuests()
        {
            List<Guest> guests = new List<Guest>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Guest";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Guest guest = new Guest();
                    guest.Id = sqlDataReader.GetInt32(0);
                    guest.FirstName = sqlDataReader.GetString(1);
                    guest.LastName = sqlDataReader.GetString(2);
                    guest.PhoneNumber = sqlDataReader.GetString(3);
                    guest.Email = sqlDataReader.GetString(4);

                    guests.Add(guest);
                }

                sqlConnection.Close();
            }

            return guests;
        }
        public int InsertGuest(Guest guest)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = string.Format("INSERT INTO Guest VALUES('{0}','{1}','{2}','{3}')",guest.FirstName,guest.LastName,guest.PhoneNumber,guest.Email);

                    return sqlCommand.ExecuteNonQuery();
                }
                
            }
        }


    }
}