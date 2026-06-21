using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BusinLayer
{
    public class Applications
    {
        int ApplicantPersonId; int CreatedByUserId; int ApplicationTypeId;
        DateTime ApplicationDate; byte ApplicationStatus; DateTime LastStatusDate;
        decimal PaidFees; int LicenseClassIs;
        public Applications(int ApplicantPersonId, int CreatedByUserId, int ApplicationTypeId,
             DateTime ApplicationDate, byte ApplicationStatus, DateTime LastStatusDate,
             decimal PaidFees,int LicenseClassIs)
        {
            this.ApplicantPersonId = ApplicantPersonId;
            this.CreatedByUserId = CreatedByUserId;
            this.ApplicationTypeId = ApplicationTypeId;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.LicenseClassIs = LicenseClassIs;
        }

        public static DataTable GetLicenseClasses()
        {
            return DealWithApplications.GetLicenseClasses();
        }
        public static DataTable GetApplicationAndI_LInfo(int ApplicationId)
        {
            return DealWithApplications.GetApplicationAndI_LInfo(ApplicationId);
        }
        public static bool CheckIfApplicationExist(int PersonId, int AppTypeId, int LicenseClassId)
        {
            return DealWithApplications.CheckIfApplicationExist(PersonId, AppTypeId, LicenseClassId);
        }
        public static int GetApplicationTypeId(string ApplicationTypeTitle)
        {
            return DealWithApplications.GetApplicationTypeId(ApplicationTypeTitle);
        }
        public static int GetLicenseClassId(string className)
        {
            return DealWithApplications.GetLicenseClassId(className);
        }
        public static decimal GetNewLocalDrivingLicenseFees()
        {
            return DealWithApplications.GetApplicationTypeFees("New Local Driving License");
        }
        public static decimal GetRenewDrivingLicenseFees()
        {
            return DealWithApplications.GetApplicationTypeFees("Renew Driving License");
        }
        public static decimal GetReplaceLostLicenseFees()
        {
            return DealWithApplications.GetApplicationTypeFees("Replacement for Lost License");
        }
        public static decimal GetReplaceDamagedLicenseFees()
        {
            return DealWithApplications.GetApplicationTypeFees("Replacement for Damaged License");
        }
        public static decimal GetRealesedDetainedLicenseFees()
        {
            return DealWithApplications.GetApplicationTypeFees("Release Detained Driving License");
        }
        public static decimal GetInterNationalLicenseFees()
        {
            return DealWithApplications.GetApplicationTypeFees("Issue International License");
        }
        public static decimal GetRetakeTestFees()
        {
            return DealWithApplications.GetApplicationTypeFees("Retake Test");
        }
        public static int AddApplicatoin(Applications App)
        {
            return DealWithApplications.AddApplicatoin( App.ApplicantPersonId,App.CreatedByUserId,
                                                       App.ApplicationTypeId,App.ApplicationDate,
                                                       App.ApplicationStatus,App.LastStatusDate,
                                                       App.PaidFees,App.LicenseClassIs);
        }

        public static int[] AddNewApplicatoin(Applications App)
        {
            return DealWithApplications.AddNewApplicatoin(App.ApplicantPersonId, App.CreatedByUserId,
                                                       App.ApplicationTypeId, App.ApplicationDate,
                                                       App.ApplicationStatus, App.LastStatusDate,
                                                       App.PaidFees, App.LicenseClassIs);
        }
        public static int AddRealeseDetainedLicenseApplicatoin(Applications App)
        { 
            return DealWithApplications.AddRealeseDetainedLicenseApplicatoin(App.ApplicantPersonId, App.CreatedByUserId,
                                                       App.ApplicationTypeId, App.ApplicationDate,
                                                       App.ApplicationStatus, App.LastStatusDate,
                                                       App.PaidFees);
        }
        public static DataTable GetApplicationRecords()
        {
            return DealWithApplications.getApplicationRecords();
        }
        public static DataTable SearchApplication(string Col, string search)
        {
            return DealWithApplications.SearchApplication(Col, search); 
        }

        public static bool DeleteApplication(String Id)
        {
            return DealWithApplications.DeleteLocalDrivingLicenseApplications(Id);
        }
        public static bool CancelApplication(String Id)
        {
            return DealWithApplications.CancelApplication(Id);
        }

        public static bool CompletelApplication(string Id)
        {
            return DealWithApplications.CompletelApplication(Id);
        }
        public static DataTable getApplicationDetails(String ApplicationId)
        {
            return DealWithApplications.getApplicationDetails(ApplicationId);
        }
        public static DataTable getApplicationDetailsForCard(String ApplicationId)
        {
            return DealWithApplications .getApplicationDetailsForCard(ApplicationId);
        }

        public static bool CheckIfApplicationIsLocked(int TestAppointmentId)
        {
            return DealWithApplications.CheckIfApplicationIsLocked(TestAppointmentId);
        }

        

            //public static int GetApplicationIdUsingLocalLicenseId(int LocalDrivingLicenseApplicationId)
            //{
            //    return DealWithApplications.GetApplicationIdUsingLocalLicenseId(LocalDrivingLicenseApplicationId);
            //}
        }
}
