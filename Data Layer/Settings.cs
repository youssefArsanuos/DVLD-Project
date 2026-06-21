using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class Settings
    {
        public class settings
        {
            public static string connectionString = "Server=.;DataBase=DVLD;User Id=sa;Password=turtle;";
        }
        public static DataTable GetColumns(string table)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT COLUMN_NAME
                             FROM INFORMATION_SCHEMA.COLUMNS
                             WHERE TABLE_NAME = @table;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@table", table);
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

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static DataTable Search(string Col, string search, string Query)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(settings.connectionString);

            string condition;

            if (Col == "FullName")
            {
                condition = "(p.FirstName + ' ' + p.SecondName + ' ' + p.ThirdName + ' ' + p.LastName) LIKE @search";
            }
            else if (Col == "IsActive")
            {
                int val = search.ToLower() == "yes" ? 1 : 0;
                condition = $"{Col} = {val}";
            }
            else
            {
                condition = $"{Col} LIKE @search";
            }

            string query = $"SELECT {Query} WHERE {condition}";

            SqlCommand command = new SqlCommand(query, connection);

            if (Col != "IsActive")
                command.Parameters.AddWithValue("@search", "%" + search + "%");

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
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool IsExist(string table, string col, object value)
        {
            bool exists = false;
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = $"SELECT 1 FROM {table} WHERE {col} = @Value";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Value", value);

                connection.Open();
                exists = command.ExecuteScalar() != null;
            }
            return exists;
        }


    }
}
