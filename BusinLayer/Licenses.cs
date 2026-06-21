using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinLayer
{
    public class Licenses
    {
        public int LicenseId { get; set; }

        private int ApplicationID;
        private int DriverID;
        private int LicenseClass;
        private int ValidityYears;
        private string Notes;
        private decimal PaidFees;
        private bool IsActive;
        private byte IssueReason;
        private int CreatedByUserID;
        private bool IsInterNational;
        public Licenses(int applicationID, int driverID, int licenseClass, int validityYears, string notes, decimal paidFees,
                                 bool isActive, byte issueReason, int createdByUserID, bool isInterNational)
        {
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClass = licenseClass;
            ValidityYears = validityYears;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
            IsInterNational = isInterNational;
        }
        public static DataTable GetRequiredDataForAddNewLicense(int LDLAId)
        {
            return DealWithLicenses.GetRequiredDataForAddNewLicense(LDLAId);
        }
        public static int AddNewLicense(Licenses license)
        {
            return DealWithLicenses.AddNewLicense(license.ApplicationID, license.DriverID, license.LicenseClass, license.ValidityYears,
                                                                              license.Notes, license.PaidFees, license.IsActive, license.IssueReason, license.CreatedByUserID);
        }
        public static int AddNewLicense(Licenses license,DateTime date)
        {
            return DealWithLicenses.AddNewLicense(license.ApplicationID, license.DriverID, license.LicenseClass, license.ValidityYears,
                                                                              license.Notes, license.PaidFees, license.IsActive, license.IssueReason, license.CreatedByUserID,date);
        }
        public static int DetainLicense(string LicenseId, string reatedByUserId, string FineFees)
        {
            return DealWithLicenses.DetainLicense(LicenseId, reatedByUserId, FineFees);
        }
        public static int AddNewInternationlLicense(Licenses license,int localLicenseId)
        {
            return DealWithLicenses.AddNewInternationalLicense(license.ApplicationID, license.ValidityYears,license.PaidFees, license.IsActive,  license.CreatedByUserID,  localLicenseId);
        }
        public static DataTable GetLicenseInfo(int LDLAId)
        {
            return DealWithLicenses.GetLicenseInfo(LDLAId);
        }
        public static DataTable GetInterNationalLicenseInfo(int LicenseId)
        {
            return DealWithLicenses.GetInterNationalLicenseInfo(LicenseId);
        }
        public bool IsLicenseExist(string LicecseId)
        {
            return Settings.IsExist("Licenses", "LicenseId", LicecseId);
        }
        public static bool CheckExistActiveLicense(int PersonId, int LicenseClassId)
        {
            return DealWithLicenses.CheckExistActiveLicense(PersonId, LicenseClassId);
        }
        public static DataTable GetPersonLocalLicenseHistory(string NotionalNo)
        {
            return DealWithLicenses.GetPersonLicenseHistory(NotionalNo);
        }
        public static DataTable GetPersonInternationalLicenseHistory(string NotionalNo)
        {
            return DealWithLicenses.GetPersonInternationalLicenseHistory(NotionalNo);
        }
        public static bool IsLicenseExist( object value)
        {
            return Settings.IsExist("Licenses", "LicenseId", value);
        }
        public static bool CheckIfLicenseInClass3(string LicenseId)
        {
            return DealWithLicenses.CheckIfLicenseInClass3(LicenseId);
        }
        public static bool CheckIfPersonHasAnActiverInternationalLicense(string LicenseId)
        {
            return DealWithLicenses.CheckIfPersonHasAnActiverInternationalLicense(LicenseId);
        }
        public static bool IsUserHaveAnotherActiveLicense(string LicenseId)
        {
            return DealWithLicenses.IsUserHaveAnotherActiveLicense(LicenseId);
        }
        public static bool IsLicenseActive(string LicenseId)
        {
            return DealWithLicenses.IsLicenseActive(LicenseId); 
        }
        public static bool IsLicenseDetained(string LicenseId)
        {
            return DealWithLicenses.IsLicenseDetained(LicenseId);
        }
        public static DataTable GetLicenseInfoWithLicenseId(string LicenseId)
        {
            return DealWithLicenses.GetLicenseInfoWithLicenseId(LicenseId);
        }
        public static DataTable GetDetainedLicenseInfo(string LicenseId)
        {
            return DealWithLicenses.GetDetainedLicenseInfo(LicenseId);
        }
        public static DataTable GetAllLicenseInfo(string LicenseId)
        {
            return DealWithLicenses.GetAllLicenseInfo(LicenseId);
        }
        public static DataTable getInternationalLicensesRecords()
        {
            return DealWithLicenses.getInternationalLicensesRecords();
        }
        public static DateTime GetLicenseExpirationDate(int LicenseId)
        {
            return DealWithLicenses.GetLicenseExpirationDate(LicenseId);
        }
        public static DataTable GetLicenseClassInformation(string ClassName)
        {
            return DealWithLicenses.GetLicenseClassInformation(ClassName);
        }
        public static void DeactivateOldLicense(string LicenseId)
        {
            DealWithLicenses.DeactivateOldLicense(LicenseId);
        }
        public static void ReleasedLicense(string LicenseId, int ReleasedByUserId, int ReleaseApplicationId)
        {
             DealWithLicenses.ReleasedLicense(LicenseId, ReleasedByUserId, ReleaseApplicationId);
        }
        public static DataTable GetDetainedLicenses()
        {
            return DealWithLicenses.GetDetainedLicenses();
        }
        public static int GetLDLAID(int LicenseId)
        {
            return DealWithLicenses.GetLDLAID(LicenseId);
        }
    }
}
