using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data_Layer.Settings;

namespace BusinLayer
{
    public class Tests
    {
        public static bool CheckIfPersonPassTest(int LDLAId, string TestTypeTitle)
        {
            return DealWithTests.CheckIfPersonPassTest(LDLAId, TestTypeTitle); 
        }
        public static bool CheckIfPersonFailTest(int LDLAId, string TestTypeTitle)
        {
            return DealWithTests.CheckIfPersonFailTest(LDLAId, TestTypeTitle);
        }
        public static int GetTestTypeId(string TestTypeTitle)
        {
            return DealWithTests.GetTestTypeId(TestTypeTitle);
        }
        public static int GetTestTypeFees(string TestTypeTitle)
        {
            return DealWithTests .GetTestTypeFees(TestTypeTitle);
        }
        public static int GetTrialsNumber(int PersonId, string TestTypeTitle,int LocalDrivingLicenseApplicationId)
        {
            return DealWithTests.GetTrialsNumber(PersonId, TestTypeTitle,LocalDrivingLicenseApplicationId);
        }
        public static int AddTestAppointment(int TestTypeId, int LocalDrivingLicenseApplicationId,
                                                                    int CreatedByUserId, int PaidFees, bool IsLocked,int RetakeTestApplication)
        {
            {
                return DealWithTests.AddTestAppointment(TestTypeId, LocalDrivingLicenseApplicationId, CreatedByUserId, PaidFees, IsLocked, RetakeTestApplication);
            }
        }
        public static DataTable getAppointmentRecords(string LDLAId,string TestTypeTitle)
        {
            return DealWithTests.getAppointmentRecords(LDLAId, TestTypeTitle);
        }
        public static int CheckActiveAppointment(int LDLAId, string TestTypeTitle)
        {
            return DealWithTests.CheckActiveAppointment(LDLAId, TestTypeTitle);
        }
        public static bool UpdateAppointmentDate(int TestAppointmentId, DateTime AppoinmentDate)
        {
            return DealWithTests.UpdateAppointmentDate(TestAppointmentId, AppoinmentDate);
        }
        public static bool AddTest(int TestAppointmentId, bool TestResult, string Notes, int CreatedByUserId)
        {
            return DealWithTests.AddTest(TestAppointmentId, TestResult, Notes, CreatedByUserId);
        }
        public static bool CheckIfPersonFailInTest(int TestAppointmentId)
        {
            return DealWithTests.CheckIfPersonFailInTest(TestAppointmentId);
        }

        public static bool CheckIfPersonPassAllTests(string LocalDrivingLicenseApplicationId)
        {
            return DealWithTests.CheckIfPersonPassAllTests(LocalDrivingLicenseApplicationId);
        }
        public static bool CheckIfApplicationInRetakeMode(int TestAppointmentId)
        {
            return DealWithTests.CheckIfApplicationInRetakeMode(TestAppointmentId);
        }
    }
}
