using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Data_Layer.Settings;

namespace Data_Layer
{
    public class DealWithTypes
    {
        public static DataTable getApplicationTypes()
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT * FROM ApplicationTypes;";
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

      

        public static bool EditApplicationType(int ApplicationTypeId, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            bool done = false;

            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = @"UPDATE ApplicationTypes
                             SET ApplicationTypeTitle = @ApplicationTypeTitle,
                                 ApplicationFees = @ApplicationFees
                             WHERE ApplicationTypeId = @ApplicationTypeId";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationTypeId", ApplicationTypeId);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0) done = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return done;
        }

        public static DataTable getTestTypes()
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT * FROM TestTypes;";
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

        public static bool EditTestType(int TestTypeId, string TestTypeTitle, decimal TestTypeFees, string TestTypeDescription)
        {
            bool done = false;

            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = @"UPDATE TestTypes
                             SET TestTypeTitle = @TestTypeTitle,
                                 TestTypeFees = @TestTypeFees,
                                 TestTypeDescription = @TestTypeDescription
                             WHERE TestTypeId = @TestTypeId";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeId", TestTypeId);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0) done = true;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return done;
        }
    }
}
