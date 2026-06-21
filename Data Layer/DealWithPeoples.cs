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
    public class DealWithPeoples
    {
        public static DataTable getPeoples ()
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT 
                             p.PersonId,
                             p.NotionalNo AS NationalNo,
                             p.FirstName,
                             p.SecondName,
                             p.ThirdName,
                             p.LastName,
                             p.DateOfBirth,
                             CASE 
                             WHEN p.Gendor = 0 THEN 'Male'
                             WHEN p.Gendor = 1 THEN 'Female'
                             END AS Gendor,
                             p.Address,
                             p.Phone,
                             p.Email,
                             c.CountryName
                             FROM People p
                             INNER JOIN Countries c
                             ON c.CountryId = p.NotionalityCountryId;";
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

        

        public static DataTable getPerson(int Id)
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT 
                             p.FirstName,
                             p.SecondName,
                             p.ThirdName,
                             p.LastName,
                             p.NotionalNo AS NationalNo,
                             p.DateOfBirth,
                             p.Gendor,
                             p.Phone,
                             p.Email,
                             p.Address,
                             c.CountryName,
                             p.ImagePath
                             FROM People p
                             INNER JOIN Countries c
                             ON c.CountryId = p.NotionalityCountryId
                             where PersonId=@Id;";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", Id);
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
        public static bool DeletePerson(String Id)
        {
            bool done = false;
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"Delete From People Where PersonId=@Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", Id);

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0) { done = true; }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return done;
        }

        //public static int PeoplesNumber()
        //{
        //    SqlConnection connection = new SqlConnection(settings.connectionString);
        //    string query = @"SELECT count(*)
        //                     FROM People";
        //    SqlCommand command = new SqlCommand(query, connection);

        //    try
        //    {
        //        connection.Open();
        //        object result = command.ExecuteScalar();
        //        if (result != null && result != DBNull.Value)
        //        {
        //            return (int)result;
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return 0;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return 0;
        //}

        //public static int PeoplesSearchNumber(string Col, string search)
        //{
        //    SqlConnection connection = new SqlConnection(settings.connectionString);
        //    string query = @"SELECT count(*)
        //                     FROM People
        //                     where @Col like '%@search%'";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@Col", Col);
        //    command.Parameters.AddWithValue("@search", search);
        //    try
        //    {
        //        connection.Open();
        //        object result = command.ExecuteScalar();
        //        if (result != null && result != DBNull.Value)
        //        {
        //            return (int)result;
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return 0;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return 0;
        //}

        public static DataTable GetCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"select countryName from Countries";

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

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static int AddPerson(string FName, string SName, string TName, string LaName,
                                    string NationalNo, string Address, string Phone,
                                    string Email, string ImagePath, byte gendor,
                                    DateTime DateOfBirth, int NationalCountryId)
        {
            int newId = -1;

            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"INSERT INTO People (NotionalNo, FirstName,
                                                     SecondName, ThirdName, LastName, DateOfBirth,
                                                     Gendor, Address, Phone, Email, NotionalityCountryID,
                                                     ImagePath)
                                 VALUES (@NationalNo,@FName,@SName,@TName,@LaName,@DateOfBirth,
                                         @gendor,@Address,@Phone,@Email,@NationalCountryId,@ImagePath);
                                         SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@NationalNo", NationalNo);
                command.Parameters.AddWithValue("@FName", FName);
                command.Parameters.AddWithValue("@SName", SName);
                command.Parameters.AddWithValue("@TName", TName);
                command.Parameters.AddWithValue("@LaName", LaName);
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                command.Parameters.AddWithValue("@gendor", gendor);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Phone", Phone);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@NationalCountryId", NationalCountryId);

                if (string.IsNullOrEmpty(ImagePath))
                    command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@ImagePath", ImagePath);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    newId = Convert.ToInt32(result);
                }
            }

            return newId;
        }

        public static bool EditPerson(int Id, string FName, string SName, string TName, string LaName,
                              string NationalNo, string Address, string Phone,
                              string Email, string ImagePath, byte gendor,
                              DateTime DateOfBirth, int NationalCountryId)
        {
            bool done = false;

            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = @"UPDATE People
                     SET NotionalNo = @NationalNo,
                         FirstName = @FName,
                         SecondName = @SName,
                         ThirdName = @TName,
                         LastName = @LaName,
                         DateOfBirth = @DateOfBirth,
                         Gendor = @gendor,
                         Address = @Address,
                         Phone = @Phone,
                         Email = @Email,
                         NotionalityCountryID = @NationalCountryId,
                         ImagePath = @ImagePath
                     WHERE PersonId = @Id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@FName", FName);
            command.Parameters.AddWithValue("@SName", SName);
            command.Parameters.AddWithValue("@TName", TName);
            command.Parameters.AddWithValue("@LaName", LaName);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@gendor", gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalCountryId", NationalCountryId);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);

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

        public static bool CheckIfPersonIsUser(string PersonId)
        {
            bool done = false;
            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = @"SELECT 1
                     FROM Users u
                     WHERE u.PersonId = @PersonId";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonId", PersonId);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    done = true;
                }
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
        public static int ReturnPersonId(string NotionalNo)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT PersonId
                                            FROM People
                                            WHERE NotionalNo=@NotionalNo;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@NotionalNo", NotionalNo);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return -1;

                return Convert.ToInt32(result);
            }

        }
        public static string ReturnNationalNo(int PersonId)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT No tionalNo
                         FROM People
                         WHERE PersonId=@PersonId;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@PersonId", PersonId);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return "";

                return result.ToString();
            }
        }

        public static int GetPersonIdUsingDriverId(int DriverId)
        {
            int AppointmentCount = -1;

            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT PersonId
                                           FROM Drivers
                                           WHERE DriverId=@DriverId;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@DriverId", DriverId);
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    AppointmentCount = Convert.ToInt32(result);
                }
            }

            return AppointmentCount;
        }
       
    }
}
