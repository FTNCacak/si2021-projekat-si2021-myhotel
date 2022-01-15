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
                sqlCommand.CommandText = "SELECT * FROM Guests";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Guest guest = new Guest();
                    guest.Id = sqlDataReader.GetString(0);
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


    }
}