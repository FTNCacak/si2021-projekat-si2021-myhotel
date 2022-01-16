using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ApartmentRepository
    {
        private string connectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=MyHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<Apartment> GetAllApartments()
        {
            List<Apartment> Apartments = new List<Apartment>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Apartment";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Apartment Apartment = new Apartment();
                    Apartment.Id = sqlDataReader.GetInt32(0);
                    Apartment.Adress = sqlDataReader.GetString(1);
                    Apartment.Type = sqlDataReader.GetString(2);
                    Apartment.Price = sqlDataReader.GetDecimal(3);

                    Apartments.Add(Apartment);
                }

                sqlConnection.Close();
            }

            return Apartments;
        }
        public int InsertApartment(Apartment Apartment)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = string.Format("INSERT INTO Apartment VALUES('{0}','{1}',{2})", Apartment.Adress, Apartment.Type, Apartment.Price);

                    return sqlCommand.ExecuteNonQuery();
                }

            }
        }


    }
}