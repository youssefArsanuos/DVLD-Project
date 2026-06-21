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
    public class DealWithCountries
    {
        public static int SelectCountryId(string CountriyName)
        {
            int CountryId = -1;

            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT CountryId FROM Countries WHERE CountryName=@CountriyName;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@CountriyName", CountriyName);
               
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    CountryId = Convert.ToInt32(result);
                }
            }

            return CountryId;
        }
    }
}
