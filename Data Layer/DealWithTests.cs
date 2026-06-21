using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Data_Layer.Settings;

namespace Data_Layer
{
    public class DealWithTests
    {
        public static bool CheckIfPersonPassTest(int LDLAId, string TestTypeTitle)
        {
            bool done = false;
            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = @"SELECT 1 
                                        FROM TestAppointments TA
                                        JOIN Tests T
                                          ON TA.TestAppointmentId = T.TestAppointmentId
                                        JOIN TestTypes TT
                                          ON TA.TestTypeId = TT.TestTypeId
                                        JOIN LocalDrivingLicenseApplications L
                                          ON L.LocalDrivingLicenseApplicationId = TA.LocalDrivingLicenseApplicationId
                                        JOIN Applications A
                                          ON A.ApplicationId = L.ApplicationId
                                        JOIN People P
                                          ON A.ApplicantPersonId = P.PersonId
                                        WHERE TA.LocalDrivingLicenseApplicationId = @LDLAId
                                                 AND TT.TestTypeTitle = @TestTypeTitle
                                                  AND T.TestResult = 1";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAId", LDLAId);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);

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
        public static bool CheckIfPersonFailTest(int LDLAId, string TestTypeTitle)
        {
            bool done = false;
            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = @"SELECT 1 
                                        FROM TestAppointments TA
                                        JOIN Tests T
                                          ON TA.TestAppointmentId = T.TestAppointmentId
                                        JOIN TestTypes TT
                                          ON TA.TestTypeId = TT.TestTypeId
                                        JOIN LocalDrivingLicenseApplications L
                                          ON L.LocalDrivingLicenseApplicationId = TA.LocalDrivingLicenseApplicationId
                                        JOIN Applications A
                                          ON A.ApplicationId = L.ApplicationId
                                        JOIN People P
                                          ON A.ApplicantPersonId = P.PersonId
                                        WHERE TA.LocalDrivingLicenseApplicationId = @LDLAId
                                                 AND TT.TestTypeTitle = @TestTypeTitle
                                                  AND T.TestResult = 0";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAId", LDLAId);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);

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


        public static int GetTestTypeId(string TestTypeTitle)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT TestTypeId
                                           FROM TestTypes
                                           WHERE TestTypeTitle=@TestTypeTitle;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return -1;

                return Convert.ToInt32(result);
            }
        }
        public static int GetTestTypeFees(string TestTypeTitle)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT TestTypeFees
                                           FROM TestTypes
                                           WHERE TestTypeTitle=@TestTypeTitle;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return -1;

                return Convert.ToInt32(result);
            }
        }
            
        public static int GetTrialsNumber(int PersonId,string TestTypeTitle,int LocalDrivingLicenseApplicationId)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT COUNT(T.TestId) AS Trials
                                            FROM Applications A
                                            LEFT JOIN People P
                                               ON A.ApplicantPersonId = P.PersonId                     
                                            LEFT JOIN LocalDrivingLicenseApplications LDLA
                                               ON LDLA.ApplicationId = A.ApplicationId
                                            LEFT JOIN TestAppointments TA
                                               ON TA.LocalDrivingLicenseApplicationId = LDLA.LocalDrivingLicenseApplicationId
                                            LEFT JOIN Tests T 
                                               ON T.TestAppointmentId = TA.TestAppointmentId
                                            LEFT JOIN TestTypes TT 
                                               ON TA.TestTypeId=TT.TestTypeId
                                           WHERE P.PersonId=@PersonId AND TT.TestTypeTitle=@TestTypeTitle AND LDLA.LocalDrivingLicenseApplicationId=@LocalDrivingLicenseApplicationId;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationId", LocalDrivingLicenseApplicationId);
                command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
                command.Parameters.AddWithValue("@PersonId", PersonId);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return -1;

                return Convert.ToInt32(result);
            }
        }

        public static bool CheckIfPersonPassAllTests ( string LocalDrivingLicenseApplicationId)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT 1 FROM LocalDrivingLicenseApplications LDLA
                                            LEFT JOIN TestAppointments TA ON LDLA.LocalDrivingLicenseApplicationId=TA.LocalDrivingLicenseApplicationId
                                            LEFT JOIN Tests T ON T.TestAppointmentId=TA.TestAppointmentId
                                            LEFT JOIN TestTypes TT ON TT.TestTypeId = TA.TestTypeId
                                            WHERE LDLA.LocalDrivingLicenseApplicationId = @LocalDrivingLicenseApplicationId AND TT.TestTypeTitle='Street Test' AND T.TestResult=1;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationId", LocalDrivingLicenseApplicationId);


                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return false;

                return true;
            }
        }

        public static int AddTestAppointment(int TestTypeId,int LocalDrivingLicenseApplicationId,
                                                                     int CreatedByUserId, int PaidFees,bool IsLocked,int RetakeTestApplication)
        {
            int newId = -1;

            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"INSERT INTO TestAppointments(TestTypeId,LocalDrivingLicenseApplicationId,
                                                                                                  AppoinmentDate,CreatedByUserId,PaidFees,IsLocked,RetakeTestApplication)
                                           VALUES(@TestTypeId,@LocalDrivingLicenseApplicationId,GETDATE(),
                                                          @CreatedByUserId,@PaidFees,
                                                          @IsLocked,@RetakeTestApplication);
                                          SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@TestTypeId", TestTypeId);
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationId", LocalDrivingLicenseApplicationId);
                command.Parameters.AddWithValue("@CreatedByUserId", CreatedByUserId);
                command.Parameters.AddWithValue("@IsLocked", IsLocked);
                command.Parameters.AddWithValue("@PaidFees", PaidFees);
                if (RetakeTestApplication > 0)
                {
                    command.Parameters.AddWithValue("@RetakeTestApplication", RetakeTestApplication);
                }
                else
                {
                    command.Parameters.AddWithValue("@RetakeTestApplication", DBNull.Value);
                }

                    connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    newId = Convert.ToInt32(result);
                }
            }

            return newId;
        }

        public static DataTable getAppointmentRecords(string LDLAId,string TestTypeTitle)
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT TestAppointmentId,PaidFees,AppoinmentDate,IsLocked
                                       FROM TestAppointments
                                       LEFT JOIN TestTypes ON TestTypes.TestTypeId=TestAppointments.TestTypeId
                                       WHERE LocalDrivingLicenseApplicationId=@LDLAId AND TestTypeTitle =@TestTypeTitle;";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAId", LDLAId);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
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

        public static int CheckActiveAppointment(int LDLAId,string TestTypeTitle)
        {
            int AppointmentCount = -1;

            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT  count(*) FROM TestAppointments
                                            LEFT JOIN TestTypes ON TestAppointments.TestTypeId=TestTypes.TestTypeId 
                                            WHERE IsLocked=0 AND LocalDrivingLicenseApplicationId = @LDLAId AND TestTypeTitle=@TestTypeTitle;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
                command.Parameters.AddWithValue("@LDLAId", LDLAId);
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    AppointmentCount = Convert.ToInt32(result);
                }
            }

            return AppointmentCount;
        }
        public static bool UpdateAppointmentDate(int TestAppointmentId, DateTime AppoinmentDate)
        {
            bool done = false;

            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = @"UPDATE TestAppointments
                                       SET AppoinmentDate = @AppoinmentDate
                                       WHERE TestAppointmentId = @TestAppointmentId;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppoinmentDate", AppoinmentDate);
            command.Parameters.AddWithValue("@TestAppointmentId", TestAppointmentId);

            try
            {
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
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

        public static bool AddTest(int TestAppointmentId, bool TestResult,string Notes, int CreatedByUserId)
        {

            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"INSERT INTO Tests(TestAppointmentId,TestResult,Notes,CreatedByUserId)
                                           VALUES(@TestAppointmentId,@TestResult,@Notes,@CreatedByUserId);
                                           SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@TestAppointmentId", TestAppointmentId);
                command.Parameters.AddWithValue("@TestResult", TestResult);
                command.Parameters.AddWithValue("@CreatedByUserId", CreatedByUserId);
                command.Parameters.AddWithValue("@Notes", Notes);

                connection.Open();

                object result = command.ExecuteScalar();
   
                if (result == null||!LockAppointment(TestAppointmentId))
                {
                    return false;
                }
                return true;
            }

        }
        public static bool LockAppointment(int TestAppointmentId)
        {
            bool done = false;

            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = @"UPDATE TestAppointments
                                       SET IsLocked =1
                                       WHERE TestAppointmentId=@TestAppointmentId;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentId", TestAppointmentId);

            try
            {
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
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

        public static bool CheckIfPersonFailInTest(int TestAppointmentId)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT 1 FROM TestAppointments
                                           LEFT JOIN Tests ON Tests.TestAppointmentId=TestAppointments.TestAppointmentId
                                           WHERE TestResult=0 AND Tests.TestAppointmentId=@TestAppointmentId;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@TestAppointmentId", TestAppointmentId);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return false;

                return true;
            }
        }

        public static bool CheckIfApplicationInRetakeMode(int TestAppointmentId)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT 1 FROM TestAppointments
                                           WHERE TestAppointmentId = @TestAppointmentId AND RetakeTestApplication IS NOT NULL;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@TestAppointmentId", TestAppointmentId);


                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return false;

                return true;
            }
        }

    }
}

