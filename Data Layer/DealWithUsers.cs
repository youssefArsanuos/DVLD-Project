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
    public class DealWithUsers
    {

        public static DataTable getUsers()
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT 
                                 u.UserId,
                                 u.PersonId,
                                 u.UserName,
                                 p.FirstName,
                                 p.SecondName, 
                                 p.ThirdName, 
                                 p.LastName,
                                 u.IsActive
                             FROM Users u
                             INNER JOIN People p
                             ON u.PersonId = p.PersonId;";
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
        public static int CheckUser(string UserName, string UPassword)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT IsActive 
                                 FROM Users 
                                 WHERE UserName = @UserName AND UPassword = @UPassword";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@UPassword", UPassword);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return -1; 

                return Convert.ToInt32(result); 
            }
        }
        public static int ReturnUPersonId(string UserName, string UPassword)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT PersonId 
                                 FROM Users 
                                 WHERE UserName = @UserName AND UPassword = @UPassword";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@UPassword", UPassword);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return -1;

                return Convert.ToInt32(result);
            }
        }

        public static int AddUser(int PersonId, byte IsActive, string UserName, string Password)
        {
            int newId = -1;

            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"INSERT INTO Users (PersonId, IsActive,UserName, UPassword)
                                 VALUES (@PersonId,@IsActive,@UserName,@Password);
                                         SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@PersonId", PersonId);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    newId = Convert.ToInt32(result);
                }
            }

            return newId;
        }

        public static bool DeleteUser(String Id)
        {
            bool done = false;
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"Delete From Users Where UserId=@Id";
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

        public static int GetUserId(int PersonId)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT UserId
                                 FROM Users 
                                 JOIN People ON Users.PersonId = People.PersonId
                                 Where Users.PersonId=@PersonId;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@PersonId", PersonId);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return -1;

                return Convert.ToInt32(result);
            }
        }

        public static bool EditUser(int UserId,string UserName, string Password, byte IsActive)
        {
            bool done = false;

            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = @"UPDATE Users
                             SET UserName = @UserName,
                                 UPassword = @Password,
                                 IsActive = @IsActive
                             WHERE UserId = @UserId";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@UserId", UserId);

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

        public static bool EditUserPassword(int UserId,string Password)
        {
            bool done = false;

            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = @"UPDATE Users
                             SET UPassword = @Password
                             WHERE UserId = @UserId";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@UserId", UserId);

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

        public static int ReturnUserID(int PersonId)
        {
            int newId = -1;

            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT UserId FROM Users WHERE PersonId = @PersonId;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@PersonId", PersonId);


                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    newId = Convert.ToInt32(result);
                }
            }

            return newId;
        }

    }

}
