using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class OwnerRepository
    {
        private string connectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=MyHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public List<Owner> GetAllOwners()
        {
            List<Owner> Owners = new List<Owner>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Owner";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Owner Owner = new Owner();
                    Owner.Id = sqlDataReader.GetInt32(0);
                    Owner.FirstName = sqlDataReader.GetString(1);
                    Owner.LastName = sqlDataReader.GetString(2);
                    Owner.PhoneNumber = sqlDataReader.GetString(3);
                    Owner.Email = sqlDataReader.GetString(4);

                    Owners.Add(Owner);
                }

                sqlConnection.Close();
            }

            return Owners;
        }
        public int InsertOwner(Owner owner)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = string.Format("INSERT INTO Owner VALUES('{0}','{1}','{2}','{3}')", owner.FirstName, owner.LastName, owner.PhoneNumber, owner.Email);

                    return sqlCommand.ExecuteNonQuery();
                }

            }
        }


    }
}