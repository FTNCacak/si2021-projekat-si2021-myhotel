using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ReservationRepository
    {
        private string connectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=MyHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Reservation> GetAllReservations()
        {
            List<Reservation> Reservations = new List<Reservation>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Reservation";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Reservation Reservation = new Reservation();
                    Reservation.Id = sqlDataReader.GetInt32(0);
                    Reservation.GuestId = sqlDataReader.GetInt32(1);
                    Reservation.ApartmentId = sqlDataReader.GetInt32(2);
                    Reservation.Payment = sqlDataReader.GetDecimal(3);
                    Reservation.BeginDate = sqlDataReader.GetDateTime(4);
                    Reservation.NumberOfDays = sqlDataReader.GetInt32(5);

                    Reservations.Add(Reservation);
                }

                sqlConnection.Close();
            }

            return Reservations;
        }

        public int InsertReservation(Reservation Reservation)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = string.Format("INSERT INTO Reservation VALUES({0},{1},{2},{3},{4})", Reservation.GuestId, Reservation.ApartmentId, Reservation.Payment, Reservation.BeginDate, Reservation.NumberOfDays);

                    return sqlCommand.ExecuteNonQuery();
                }

            }
        }

        public int DeleteReservation(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "DELETE FROM Reservation WHERE Id = " + id;

                return command.ExecuteNonQuery();
            }
        }
    }
}

