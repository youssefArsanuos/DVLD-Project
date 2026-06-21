using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data_Layer.Settings;

namespace Data_Layer
{
    public class DealWithDrivers
    {
        public static int AddDriver(int PersonId, int CreatedByUserId)
        {
            int newId = -1;
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"INSERT INTO Drivers(PersonId,CreatedByUserId,CreatedDate)
                                           VALUES (@PersonId,@CreatedByUserId,GETDATE());
                                           SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PersonId", PersonId);
                command.Parameters.AddWithValue("@CreatedByUserId", CreatedByUserId);
              
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    newId = Convert.ToInt32(result);
                }
            }
            return newId;
        }
        public static int GetDriverIdUsingPersonId(int PersonId)
        {
            int AppointmentCount = -1;

            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT DriverId
                                           FROM Drivers
                                           WHERE PersonId=@PersonId;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@PersonId", PersonId);
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    AppointmentCount = Convert.ToInt32(result);
                }
            }

            return AppointmentCount;
        }

        public static DataTable GetAllDrivers( )
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT D.DriverId,P.PersonId,P.NotionalNo,
                                                     P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName AS FullName,
                                                    D.CreatedDate,
                                                    COUNT(CASE WHEN L.IsActive = 1 THEN 1 END) AS ActiveLicenses

                                       FROM Drivers D 
                                       LEFT JOIN People P ON P.PersonId = D.PersonId
                                       LEFT JOIN Licenses L ON L.DriverId = D.DriverId

                                       GROUP BY D.DriverId,P.PersonId,P.NotionalNo,P.FirstName,
                                                         P.SecondName,P.ThirdName,P.LastName,D.CreatedDate;";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}
