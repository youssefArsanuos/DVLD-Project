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
    public class DealWithApplications
    {
        public static DataTable GetLicenseClasses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT LicenseClassId, ClassName FROM LicenseClasses";

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
        public static DataTable GetApplicationAndI_LInfo(int ApplicationId)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT A.ApplicationId,A.ApplicationDate,IL.IssueDate,
                                                     A.PaidFees,L.LicenseId,IL.ExpirationDate,
                                                     IL.CreatedByUserId,IL.LicenseId AS Int_LicenseId
                                        FROM Applications A
                                        LEFT JOIN InternationalLicenses IL ON A.ApplicationId=IL.ApplicationId
                                        LEFT JOIN Licenses L ON L.LicenseId=IL.LocalLicenseId
                                        WHERE A.ApplicationId=@ApplicationId;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationId", ApplicationId);
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

        public static bool CheckIfApplicationExist(int PersonId, int AppTypeId, int LicenseClassId)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT 1 
                                 FROM Applications 
                                 JOIN LocalDrivingLicenseApplications 
                                 ON Applications.ApplicationId=LocalDrivingLicenseApplications.ApplicationId
                                 WHERE ApplicantPersonId = @PersonId
                                 AND ApplicationTypeId = @AppTypeId
                                 AND LocalDrivingLicenseApplications.LicenseClassId = @LicenseClassId
                                 AND ApplicationStatus = 0;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@PersonId", PersonId);
                command.Parameters.AddWithValue("@AppTypeId", AppTypeId);
                command.Parameters.AddWithValue("@LicenseClassId", LicenseClassId);

                connection.Open();

                object result = command.ExecuteScalar();

                return result != null;
            }
        }


        public static int GetApplicationTypeId(string ApplicationTypeTitle)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT ApplicationTypeId 
                            FROM ApplicationTypes 
                            WHERE ApplicationTypeTitle = @ApplicationTypeTitle ;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return -1;

                return Convert.ToInt32(result);
            }
        }

        private static int GetApplicationId(string Id)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT ApplicationId 
                                           FROM LocalDrivingLicenseApplications 
                                           WHERE LocalDrivingLicenseApplicationId =  @Id ;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", Id);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return -1;

                return Convert.ToInt32(result);
            }
        }
        public static int GetLicenseClassId(string ClassName)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT LicenseClassId 
                                 FROM LicenseClasses 
                                 WHERE ClassName = @ClassName ;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ClassName", ClassName);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return -1;

                return Convert.ToInt32(result);
            }
        }
        public static decimal GetApplicationTypeFees(string ApplicationTypeTitle)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT ApplicationFees
                                 FROM ApplicationTypes
                                 WHERE ApplicationTypeTitle = @ApplicationTypeTitle;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return -1;

                return Convert.ToDecimal(result);
            }
        }


        private static int AddLocalDrivingLicenseApplications(int ApplicantPersonId,int LicenseClassId)
        {
            int newId = -1;
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"INSERT INTO LocalDrivingLicenseApplications(ApplicationId,LicenseClassId)
                                 VALUES(@ApplicantPersonId,@LicenseClassId);
                                 SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ApplicantPersonId", ApplicantPersonId);
                command.Parameters.AddWithValue("@LicenseClassId", LicenseClassId);
               
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    newId = Convert.ToInt32(result);
                }
            }
            return newId;
        }

        public static int AddApplicatoin(int ApplicantPersonId, int CreatedByUserId, int ApplicationTypeId,
                                    DateTime ApplicationDate, byte ApplicationStatus, DateTime LastStatusDate,
                                    decimal PaidFees, int LicenseClassId)
        {
            int newId = -1;
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"INSERT INTO Applications(ApplicantPersonId, CreatedByUserId,
                                                  ApplicationTypeId, ApplicationDate,
                                                  ApplicationStatus, LastStatusDate, PaidFees)
                         VALUES(@ApplicantPersonId, @CreatedByUserId, @ApplicationTypeId,
                                @ApplicationDate, @ApplicationStatus, @LastStatusDate,
                                @PaidFees);
                         SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ApplicantPersonId", ApplicantPersonId);
                command.Parameters.AddWithValue("@CreatedByUserId", CreatedByUserId);
                command.Parameters.AddWithValue("@ApplicationTypeId", ApplicationTypeId);
                command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
                command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                command.Parameters.AddWithValue("@PaidFees", PaidFees);


                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    newId = Convert.ToInt32(result);
                }
            }
            return AddLocalDrivingLicenseApplications(newId, LicenseClassId);
        }
        public static int AddRealeseDetainedLicenseApplicatoin(int ApplicantPersonId, int CreatedByUserId, int ApplicationTypeId,
                                    DateTime ApplicationDate, byte ApplicationStatus, DateTime LastStatusDate,
                                    decimal PaidFees)
        {
            int newId = -1;
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"INSERT INTO Applications(ApplicantPersonId, CreatedByUserId,
                                                  ApplicationTypeId, ApplicationDate,
                                                  ApplicationStatus, LastStatusDate, PaidFees)
                         VALUES(@ApplicantPersonId, @CreatedByUserId, 6,
                                @ApplicationDate, @ApplicationStatus, @LastStatusDate,
                                @PaidFees);
                         SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ApplicantPersonId", ApplicantPersonId);
                command.Parameters.AddWithValue("@CreatedByUserId", CreatedByUserId);
                command.Parameters.AddWithValue("@ApplicationTypeId", ApplicationTypeId);
                command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
                command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                command.Parameters.AddWithValue("@PaidFees", PaidFees);


                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    newId = Convert.ToInt32(result);
                }
            }
            return newId;
        }
        public static int[] AddNewApplicatoin(int ApplicantPersonId, int CreatedByUserId, int ApplicationTypeId,
                                    DateTime ApplicationDate, byte ApplicationStatus, DateTime LastStatusDate,
                                    decimal PaidFees, int LicenseClassId)
        {
            int newId = -1;
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"INSERT INTO Applications(ApplicantPersonId, CreatedByUserId,
                                          ApplicationTypeId, ApplicationDate,
                                          ApplicationStatus, LastStatusDate, PaidFees)
                 VALUES(@ApplicantPersonId, @CreatedByUserId, @ApplicationTypeId,
                        @ApplicationDate, @ApplicationStatus, @LastStatusDate,
                        @PaidFees);
                 SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ApplicantPersonId", ApplicantPersonId);
                command.Parameters.AddWithValue("@CreatedByUserId", CreatedByUserId);
                command.Parameters.AddWithValue("@ApplicationTypeId", ApplicationTypeId);
                command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
                command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                command.Parameters.AddWithValue("@PaidFees", PaidFees);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    newId = Convert.ToInt32(result);
            }

            int localId = AddLocalDrivingLicenseApplications(newId, LicenseClassId);

            return new int[] { newId, localId };
        }
        public static DataTable getApplicationRecords()
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT 
                                        L.LocalDrivingLicenseApplicationId,
                                            LC.ClassName,
                                            P.NotionalNo,
                                            P.FirstName,
                                            P.SecondName,
                                            A.ApplicationDate,
                                            CASE 
                                                WHEN A.ApplicationStatus = 0 THEN 'New'
                                                WHEN A.ApplicationStatus = 1 THEN 'Completed'
                                                WHEN A.ApplicationStatus = 2 THEN 'Cancelled'
                                            END AS ApplicationStatus,
                                            COUNT(T.TestId) AS TestsCount
                                        FROM LocalDrivingLicenseApplications L
                                        JOIN Applications A
                                            ON L.ApplicationId = A.ApplicationId
                                        JOIN People P
                                            ON A.ApplicantPersonId = P.PersonId
                                        JOIN LicenseClasses LC
                                            ON L.LicenseClassId = LC.LicenseClassId
                                        LEFT JOIN TestAppointments TA
                                            ON L.LocalDrivingLicenseApplicationId = TA.LocalDrivingLicenseApplicationId
                                        LEFT JOIN Tests T
                                            ON TA.TestAppointmentId = T.TestAppointmentId
                                        WHERE  ApplicationTypeId=1
                                        GROUP BY 
                                            L.LocalDrivingLicenseApplicationId,
                                            LC.ClassName,
                                            P.NotionalNo,
                                            P.FirstName,
                                            P.SecondName,
                                            A.ApplicationDate,
                                            A.ApplicationStatus;";
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
        public static DataTable getApplicationDetails(String ApplicationId)
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT 
                                             A.ApplicationId,
                                             A.ApplicationStatus,
                                             AT.ApplicationFees,
                                             AT.ApplicationTypeTitle,
                                             P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName AS FullName,
                                             P.PersonId,
                                             A.ApplicationDate,
                                             A.LastStatusDate,
                                             U.UserName,
                                             U.UserId,
                                             LDLA.LocalDrivingLicenseApplicationId,
                                             LC.ClassName,
                                             LC.LicenseClassId,
                                             COUNT(CASE WHEN T.TestResult = 1 THEN 1 END) AS PassedTests
                                   FROM Applications A
                                    LEFT JOIN People P
                                       ON A.ApplicantPersonId = P.PersonId
                                    LEFT JOIN ApplicationTypes AT
                                       ON AT.ApplicationTypeId = A.ApplicationTypeId
                                    LEFT JOIN Users U 
                                       ON U.UserId = A.CreatedByUserId
                                    LEFT JOIN LocalDrivingLicenseApplications LDLA
                                       ON LDLA.ApplicationId = A.ApplicationId
                                    LEFT JOIN TestAppointments TA
                                       ON TA.LocalDrivingLicenseApplicationId = LDLA.LocalDrivingLicenseApplicationId
                                    LEFT JOIN Tests T 
                                       ON T.TestAppointmentId = TA.TestAppointmentId
                                    LEFT JOIN LicenseClasses LC 
                                       ON LC.LicenseClassId = LDLA.LicenseClassId
                                   WHERE LDLA.LocalDrivingLicenseApplicationId = @ApplicationId AND ApplicationTypeId=1
                                   GROUP BY 
                                       A.ApplicationId,
                                       A.ApplicationStatus,
                                       AT.ApplicationFees,
                                       AT.ApplicationTypeTitle,
                                       P.FirstName,
                                       P.SecondName,
                                       P.ThirdName,
                                       P.LastName,
                                       P.PersonId,
                                       A.ApplicationDate,
                                   A.LastStatusDate,
                                       U.UserName,
                                       U.UserId,
                                       LDLA.LocalDrivingLicenseApplicationId,
                                       LC.ClassName,
                                        LC.LicenseClassId;";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationId", ApplicationId);
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
        public static DataTable getApplicationDetailsForCard(String ApplicationId)
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT 
                                             A.ApplicationId,
                                             A.ApplicationStatus,
                                             AT.ApplicationFees,
                                             AT.ApplicationTypeTitle,
                                             P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName AS FullName,
                                             P.PersonId,
                                             A.ApplicationDate,
                                             A.LastStatusDate,
                                             U.UserName,
                                             U.UserId,
                                             LDLA.LocalDrivingLicenseApplicationId,
                                             LC.ClassName,
                                             LC.LicenseClassId,
                                             COUNT(CASE WHEN T.TestResult = 1 THEN 1 END) AS PassedTests
                                   FROM Applications A
                                    LEFT JOIN People P
                                       ON A.ApplicantPersonId = P.PersonId
                                    LEFT JOIN ApplicationTypes AT
                                       ON AT.ApplicationTypeId = A.ApplicationTypeId
                                    LEFT JOIN Users U 
                                       ON U.UserId = A.CreatedByUserId
                                    LEFT JOIN LocalDrivingLicenseApplications LDLA
                                       ON LDLA.ApplicationId = A.ApplicationId
                                    LEFT JOIN TestAppointments TA
                                       ON TA.LocalDrivingLicenseApplicationId = LDLA.LocalDrivingLicenseApplicationId
                                    LEFT JOIN Tests T 
                                       ON T.TestAppointmentId = TA.TestAppointmentId
                                    LEFT JOIN LicenseClasses LC 
                                       ON LC.LicenseClassId = LDLA.LicenseClassId
                                   WHERE LDLA.LocalDrivingLicenseApplicationId = @ApplicationId 
                                   GROUP BY 
                                       A.ApplicationId,
                                       A.ApplicationStatus,
                                       AT.ApplicationFees,
                                       AT.ApplicationTypeTitle,
                                       P.FirstName,
                                       P.SecondName,
                                       P.ThirdName,
                                       P.LastName,
                                       P.PersonId,
                                       A.ApplicationDate,
                                   A.LastStatusDate,
                                       U.UserName,
                                       U.UserId,
                                       LDLA.LocalDrivingLicenseApplicationId,
                                       LC.ClassName,
                                       LC.LicenseClassId;";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationId", ApplicationId);
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
        public static DataTable SearchApplication(string Col, string search)
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = $@"SELECT 
        L.LocalDrivingLicenseApplicationId,
        LC.ClassName,
        P.NotionalNo,
        P.FirstName,
        P.SecondName,
        A.ApplicationDate,
        A.ApplicationStatus,
        COUNT(T.TestId) AS TestsCount

    FROM LocalDrivingLicenseApplications L
    JOIN Applications A
        ON L.ApplicationId = A.ApplicationId
    JOIN People P
        ON A.ApplicantPersonId = P.PersonId
    JOIN LicenseClasses LC
        ON L.LicenseClassId = LC.LicenseClassId
    LEFT JOIN TestAppointments TA
        ON L.LocalDrivingLicenseApplicationId = TA.LocalDrivingLicenseApplicationId
    LEFT JOIN Tests T
        ON TA.TestAppointmentId = T.TestAppointmentId

    WHERE {Col} LIKE @search

    GROUP BY 
        L.LocalDrivingLicenseApplicationId,
        LC.ClassName,
        P.NotionalNo,
        P.FirstName,
        P.SecondName,
        A.ApplicationDate,
        A.ApplicationStatus;";

            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@search", "%" + search + "%");

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

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

        public static bool DeleteLocalDrivingLicenseApplications(String Id)
        {
            if (DeleteApplication(GetApplicationId(Id)) == false)
            {
                return false;
            }
            bool done = false;
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"Delete From LocalDrivingLicenseApplications 
                                       Where LocalDrivingLicenseApplicationId=@Id;";
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

        public static bool DeleteApplication(int Id)
        {
            bool done = false;
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"Delete From Applications Where ApplicationId=@Id;";
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

        
        public static bool CancelApplication(string Id)
        {
            int ApplicationId = GetApplicationId(Id);

            if (ApplicationId == -1)
                return false;

            bool done = false;

            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = @"UPDATE Applications
                                       SET ApplicationStatus = 2,LastStatusDate = GETDATE()
                                       WHERE ApplicationId = @ApplicationId;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationId", ApplicationId);

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
        public static bool CompletelApplication(string Id)
        {
            int ApplicationId = GetApplicationId(Id);

            if (ApplicationId == -1)
                return false;

            bool done = false;

            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = @"UPDATE Applications
                                       SET ApplicationStatus = 1,LastStatusDate = GETDATE()
                                       WHERE ApplicationId = @ApplicationId;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationId", ApplicationId);

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
        public static bool CheckIfApplicationIsLocked(int TestAppointmentId)
        {
            bool done = false;
            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = @"SELECT 1 FROM TestAppointments
                                       WHERE TestAppointmentId=@TestAppointmentId AND IsLocked=1";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentId", TestAppointmentId);

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

        

        //public static int GetApplicationIdUsingLocalLicenseId(int LocalDrivingLicenseApplicationId)
        //{
        //    int ApplicationId = -1;
        //    using (SqlConnection connection = new SqlConnection(settings.connectionString))
        //    {
        //        string query = @"SELECT ApplicationId 
        //                                   From LocalDrivingLicenseApplications
        //                                   WHERE LocalDrivingLicenseApplicationId=@LocalDrivingLicenseApplicationId;";

        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationId", LocalDrivingLicenseApplicationId);


        //        connection.Open();
        //        object result = command.ExecuteScalar();
        //        if (result != null)
        //        {
        //            ApplicationId = Convert.ToInt32(result);
        //        }
        //    }
        //    return ApplicationId;
        //}
    }
}
