using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data_Layer.Settings;

namespace Data_Layer
{
    public class DealWithLicenses
    {
        public static DataTable GetRequiredDataForAddNewLicense(int LDLAId)
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT 
                                       A.ApplicationID,
                                           LDLA.LicenseClassID,
                                           LC.DefaultValidityLength,
                                           LC.ClassFees, 
                                           A.ApplicationTypeID,
                                           A.CreatedByUserId
                                       FROM LocalDrivingLicenseApplications LDLA
                                       INNER JOIN Applications A
                                           ON LDLA.ApplicationID = A.ApplicationID
                                       INNER JOIN LicenseClasses LC
                                           ON LDLA.LicenseClassID = LC.LicenseClassID
                                       WHERE LDLA.LocalDrivingLicenseApplicationID = @LDLAId;";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAId", LDLAId);
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
        public static DataTable GetLicenseInfo(int LDLAId)
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT  P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName AS FullName,
                                                      LC.ClassName,L.LicenseId,P.NotionalNo,P.Gendor,L.IssueDate,APPT.ApplicationTypeTitle AS IssueReason,L.Notes,
                                                      L.IsActive,P.DateOfBirth,D.DriverId,L.ExpirationDate,DL.IsReleased,P.ImagePath
                                       FROM Licenses L
                                       LEFT JOIN DetainedLicenses DL ON L.LicenseId=DL.LicenseId
                                       LEFT JOIN LicenseClasses LC ON L.LicenseCalssId=LC.LicenseClassId
                                       LEFT JOIN Drivers D ON D.DriverId=L.DriverId 
                                       LEFT JOIN Applications A ON L.ApplicationId=A.ApplicationId
                                       LEFT JOIN LocalDrivingLicenseApplications LDLA ON A.ApplicationId=LDLA.ApplicationId
                                       LEFT JOIN ApplicationTypes APPT ON APPT.ApplicationTypeId =A.ApplicationTypeId
                                       LEFT JOIN People P ON P.PersonId=A.ApplicantPersonId
                                       WHERE LDLA.LocalDrivingLicenseApplicationId=@LDLAId;";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAId", LDLAId);
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
        public static DataTable GetInterNationalLicenseInfo(int LicenseId)
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName AS FullName,
                                                     IL.LicenseId AS Int_LicenseId,L.LicenseId ,P.NotionalNo,P.Gendor,IL.IssueDate,
                                                     IL.ExpirationDate,IL.ApplicationId ,IL.IsActive,P.DateOfBirth,D.DriverId,P.ImagePath
                                       FROM InternationalLicenses IL
                                       LEFT JOIN  Licenses L ON L.LicenseId = IL.LocalLicenseId
                                       LEFT JOIN Drivers D ON D.DriverId = L.DriverId
                                       LEFT JOIN People P ON P.PersonId = D.PersonId
                                       WHERE IL.LicenseId=@LicenseId ";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseId", LicenseId);
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
        public static DataTable GetLicenseInfoWithLicenseId(string LicenseId)
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT  P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName AS FullName,
                                                      LC.ClassName,L.LicenseId,P.PersonId,P.NotionalNo,P.Gendor,L.IssueDate,APPT.ApplicationTypeTitle AS IssueReason,L.Notes,
                                                      L.IsActive,A.CreatedByUserId,P.DateOfBirth,D.DriverId,L.ExpirationDate,DL.IsReleased,P.ImagePath
                                                      ,LC.DefaultValidityLength As ValidityYears,LC.ClassFees
                                       FROM Licenses L
                                       LEFT JOIN DetainedLicenses DL ON L.LicenseId=DL.LicenseId
                                       LEFT JOIN LicenseClasses LC ON L.LicenseCalssId=LC.LicenseClassId
                                       LEFT JOIN Drivers D ON D.DriverId=L.DriverId 
                                       LEFT JOIN Applications A ON L.ApplicationId=A.ApplicationId
                                       LEFT JOIN LocalDrivingLicenseApplications LDLA ON A.ApplicationId=LDLA.ApplicationId
                                       LEFT JOIN ApplicationTypes APPT ON APPT.ApplicationTypeId =A.ApplicationTypeId
                                       LEFT JOIN People P ON P.PersonId=A.ApplicantPersonId
                                       WHERE L.LicenseId=@LicenseId;";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseId", LicenseId);
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
        public static DataTable GetDetainedLicenseInfo(string LicenseId)
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT DetainId,LicenseId,DetainDate,FineFees FROM DetainedLicenses
                                       WHERE LicenseId=@LicenseId;";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseId", LicenseId);
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
        public static DataTable GetAllLicenseInfo(string LicenseId)
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT  *
                                       FROM Licenses 
                                       WHERE LicenseId=@LicenseId;";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseId", LicenseId);
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
        public static DataTable GetPersonLicenseHistory(string NotionalNo)
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT L.LicenseId,L.ApplicationId,LC.ClassName,
                                                     L.IssueDate,L.ExpirationDate ,L.IsActive
                                       FROM Licenses L
                                       LEFT JOIN DRIVERS D ON L.DriverId =D.DriverId 
                                       LEFT JOIN People P ON P.PersonId = D.PersonId
                                       LEFT JOIN LicenseClasses LC ON LC.LicenseClassId=L.LicenseCalssId 
                                       WHERE P.NotionalNo= @NotionalNo;";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NotionalNo", NotionalNo);
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
        public static DataTable GetPersonInternationalLicenseHistory(string NotionalNo)
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT IL.LicenseId,IL.ApplicationId,
                                                     IL.IssueDate,IL.ExpirationDate ,IL.IsActive,IL.LocalLicenseId
                                       FROM InternationalLicenses IL
                                       LEFT JOIN Licenses L ON IL.LocalLicenseId=L.LicenseId
                                       LEFT JOIN DRIVERS D ON L.DriverId =D.DriverId 
                                       LEFT JOIN People P ON P.PersonId = D.PersonId 
                                       WHERE P.NotionalNo= @NotionalNo;";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NotionalNo", NotionalNo);
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

        public static DataTable GetLicenseClassInformation(string ClassName)
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT LicenseClassId,ClassFees,DefaultValidityLength
                                       FROM LicenseClasses
                                       WHERE ClassName=@ClassName;";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassName", ClassName);
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
        private static DataTable GetOldLicenseInformations(string LicenseId)
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"select DriverId,LicenseCalssId 
                                       From licenses
                                       Where LicenseId=@LicenseId;";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseId", LicenseId);
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
        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass, int ValidityYears, string Notes,
                                                           decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = @"INSERT INTO Licenses(ApplicationID,DriverID,LicenseCalssId,IssueDate, ExpirationDate,
                                                                               Notes,PaidFees,IsActive,IssueReason,CreatedByUserID)
                    VALUES(@ApplicationID, @DriverID,@LicenseClass,GETDATE(),DATEADD(YEAR, @ValidityYears, GETDATE()),
                                  @Notes,@PaidFees,@IsActive,@IssueReason,@CreatedByUserID);
                    SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@ValidityYears", ValidityYears);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return LicenseID;
        }
        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass, int ValidityYears, string Notes,
                                                          decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID, DateTime date)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = @"INSERT INTO Licenses(ApplicationID,DriverID,LicenseCalssId,IssueDate, ExpirationDate,
                                                                               Notes,PaidFees,IsActive,IssueReason,CreatedByUserID)
                    VALUES(@ApplicationID, @DriverID,@LicenseClass,@date,DATEADD(YEAR, @ValidityYears, GETDATE()),
                                  @Notes,@PaidFees,@IsActive,@IssueReason,@CreatedByUserID);
                    SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@ValidityYears", ValidityYears);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@date", date);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return LicenseID;
        }
        public static int DetainLicense(string LicenseId, string reatedByUserId, string FineFees)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = @"INSERT INTO DetainedLicenses(LicenseId,reatedByUserId,DetainDate,FineFees,IsReleased)
                                       VALUES (@LicenseId,@reatedByUserId,GETDATE(),@FineFees,0);
                                        SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseId", LicenseId);
            command.Parameters.AddWithValue("@reatedByUserId", reatedByUserId);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return LicenseID;
        }
        public static int GetLDLAID(int LicenseId)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = @"select LocalDrivingLicenseApplicationId from Licenses
                                            left join Applications on licenses.ApplicationId=Applications.ApplicationId
                                            left join LocalDrivingLicenseApplications on Applications.ApplicationId=LocalDrivingLicenseApplications.ApplicationId
                                            where LicenseId=@LicenseId";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseId", LicenseId);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return LicenseID;
        }
        public static int AddNewInternationalLicense(int ApplicationID, int ValidityYears,
                                                                                decimal PaidFees, bool IsActive, int CreatedByUserID, int localLicenseId)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(settings.connectionString);

            string query = @"INSERT INTO InternationalLicenses(ApplicationID,IssueDate, ExpirationDate,PaidFees,IsActive,CreatedByUserID,localLicenseId)
                                       VALUES(@ApplicationID,GETDATE(),DATEADD(YEAR, @ValidityYears, GETDATE()),
                                                      @PaidFees,@IsActive,@CreatedByUserID,@localLiceseId);
                                        SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ValidityYears", ValidityYears);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@localLiceseId", localLicenseId);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return LicenseID;
        }

        public static DataTable getInternationalLicensesRecords()
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT IL.LicenseId,IL.ApplicationId,L.DriverId,IL.LocalLicenseId,IL.IssueDate,IL.ExpirationDate,IL.IsActive 
                                       FROM InternationalLicenses IL
                                       LEFT JOIN Licenses L ON L.LicenseId=IL.LocalLicenseId;";
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
        public static bool CheckExistActiveLicense(int PersonId, int LicenseClassId)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT 1 FROM Licenses L
                                            JOIN LicenseClasses LC ON L.LicenseCalssId=LC.LicenseClassId
                                            JOIN Drivers D ON L.DriverId=D.DriverId
                                            JOIN People P ON D.PersonId=P.PersonId
                                            WHERE LC.LicenseClassId=@LicenseClassId AND P.PersonId=@PersonId AND L.IsActive =1;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@PersonId", PersonId);
                command.Parameters.AddWithValue("@LicenseClassId", LicenseClassId);
                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return false;

                return true;
            }

        }

        public static bool CheckIfLicenseInClass3(string LicenseId)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT 1 FROM Licenses
                                           WHERE LicenseCalssId=3 AND LicenseId=@LicenseId;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@LicenseId", LicenseId);
                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return false;

                return true;
            }
        }

        public static bool IsUserHaveAnotherActiveLicense(string LicenseId)
        {
            DataTable dt = GetOldLicenseInformations(LicenseId);
            DataRow row = dt.Rows[0];

            string DriverId = (row["DriverId"].ToString());
            string LicenseClassId = row["LicenseCalssId"].ToString();
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT 1 FROM Licenses
                                           WHERE DriverId=@DriverId AND LicenseCalssId=@LicenseClassId AND IsActive=1;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@DriverId", DriverId);
                command.Parameters.AddWithValue("@LicenseClassId", LicenseClassId);
                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return false;

                return true;
            }
        }
        public static bool IsLicenseActive(string LicenseId)
        {

            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT 1 FROM Licenses
                                           WHERE LicenseId=@LicenseId AND IsActive=1;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@LicenseId", LicenseId);
                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return false;

                return true;
            }
        }
        public static bool IsLicenseDetained(string LicenseId)
        {

            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT 1
                                           FROM DetainedLicenses
                                           WHERE IsReleased =0 AND LicenseId=@LicenseId;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@LicenseId", LicenseId);
                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return false;

                return true;
            }
        }
        public static void DeactivateOldLicense(string LicenseId)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"UPDATE Licenses
                         SET IsActive = 0
                         WHERE LicenseId = @LicenseId;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@LicenseId", LicenseId);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public static DataTable GetDetainedLicenses()
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT DL.DetainId,DL.LicenseId,DL.DetainDate,
                                                     DL.IsReleased,DL.FineFees,DL.ReleaseDate,P.NotionalNo,
                                                     P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName AS FullName,
                                                     P.PersonId,
                                                     DL.ReleaseApplicationId
                                     FROM DetainedLicenses DL
                                     LEFT JOIN Licenses L ON DL.LicenseId=L.LicenseId
                                     LEFT JOIN Drivers D ON D.DriverId=L.DriverId
                                     LEFT JOIN People P ON P.PersonId=D.PersonId ;";
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
    
    
        public static void ReleasedLicense(string LicenseId,int ReleasedByUserId,int ReleaseApplicationId)
        {
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"UPDATE DetainedLicenses
                                           SET 
                                               ReleasedByUserId = @ReleasedByUserId,
                                               ReleaseApplicationId = @ReleaseApplicationId,
                                               IsReleased = 1,
                                               ReleaseDate = GETDATE()
                                           WHERE 
                                               LicenseId=@LicenseId;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@LicenseId", LicenseId);
                command.Parameters.AddWithValue("@ReleasedByUserId", ReleasedByUserId);
                command.Parameters.AddWithValue("@ReleaseApplicationId", ReleaseApplicationId);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
        public static bool CheckIfPersonHasAnActiverInternationalLicense(string LicenseId)
        {
           // int PersonId = ReturnPersonIdUsingLicenseId(LicenseId);
            using (SqlConnection connection = new SqlConnection(settings.connectionString))
            {
                string query = @"SELECT 1 FROM Licenses L
                                           JOIN InternationalLicenses IL ON IL.LocalLicenseId=L.LicenseId
                                           WHERE L.LicenseId=@LicenseId AND IL.IsActive=1;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@LicenseId", LicenseId);
                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null)
                    return false;

                return true;
            }
        }
        public static DateTime GetLicenseExpirationDate(int LicenseId)
        {
            SqlConnection connection = new SqlConnection(settings.connectionString);
            string query = @"SELECT ExpirationDate
                     FROM Licenses
                     WHERE LicenseId=@LicenseId";

            DateTime ExpirationDate = DateTime.MinValue;

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseId", LicenseId);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    ExpirationDate = Convert.ToDateTime(result);
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return ExpirationDate;
        }
        private static int ReturnPersonIdUsingLicenseId(string LicenseId)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(settings.connectionString);
                                                
            string query = @"SELECT P.PersonId FROM Licenses L
                                        JOIN Drivers D ON D.DriverId=L.DriverId
                                        JOIN People P ON P.PersonId = D.PersonId
                                        WHERE L.LicenseId=@LicenseId;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseId", LicenseId);
      
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return LicenseID;
        }
    }
}
