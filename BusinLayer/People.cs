using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;
namespace BusinLayer
{

    public class People
    {
        private string FName, SName, TName, LaName ,NationalNo,Address,Phone,Email,ImagePath;
        private byte gendor;
        private DateTime DateOfBirth;
        private int NationalCountryId,_Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public People(string FName, string SName, string TName, string LaName,
            string NationalNo, string Address, string Phone, string Email,string ImagePath,byte gendor
            ,DateTime DateOfBirth,int NationalCountryId)
        {
            this.FName=FName; this.SName = SName; this.TName=TName; this.LaName=LaName;
            this.NationalNo=NationalNo; this.Address=Address;
            this.Phone=Phone; this.Email=Email; this.ImagePath=ImagePath;
            this.gendor=gendor;this.DateOfBirth=DateOfBirth;this.NationalCountryId=NationalCountryId;
        }

        public static int AddPerson(People p1)
        {
            return DealWithPeoples.AddPerson(
               p1.FName,
               p1.SName,
               p1.TName,
               p1.LaName,
               p1.NationalNo,
               p1.Address,
               p1.Phone,
               p1.Email,
               p1.ImagePath,
               p1.gendor,
               p1.DateOfBirth,
               p1.NationalCountryId);
        }

        public static bool EditPerson(People p1)
        {
            return DealWithPeoples.EditPerson(p1.Id,
               p1.FName,
               p1.SName,
               p1.TName,
               p1.LaName,
               p1.NationalNo,
               p1.Address,
               p1.Phone,
               p1.Email,
               p1.ImagePath,
               p1.gendor,
               p1.DateOfBirth,
               p1.NationalCountryId);
        }
        public static DataTable GetAllPeoples()
        {
            return DealWithPeoples.getPeoples();
        }

        
        public static DataTable GetPerson(int Id)
        {
            return DealWithPeoples.getPerson(Id);
        }

        public static DataTable SearchPeople(string Col, string search)
        {
            string Query = @" 
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
                             ON c.CountryId = p.NotionalityCountryId";
            return Settings.Search(Col, search,Query);
        }
        public static bool RemovePerson(String Id)
        {
            return DealWithPeoples.DeletePerson(Id);
        }

        //public static int PeoplesNumber()
        //{
        //    return DealWithPeoples.PeoplesNumber();
        //}

        //public static int PeoplesSearchNumber(string Col, string search)
        //{
        //    return DealWithPeoples.PeoplesSearchNumber(Col,search);
        //}

        public static DataTable GetCountries()
        {
            return DealWithPeoples.GetCountries();
        }

        public static DataTable GetPeopleColumns()
        {
            return Settings.GetColumns("People");
        }

        public static bool IsNationalNoExist(object value)
        {
            return Settings.IsExist("People", "NotionalNO", value);
        }

        public static bool CheckIfPersonIsUser(string PersonId)
        {
            return DealWithPeoples.CheckIfPersonIsUser(PersonId);
        }

        public static bool CheckIfPersonExist(string PersonId)
        {
            return Settings.IsExist("People", "PersonId", PersonId);
        }

        public static int ReturnPersonId(string NotionalNo)
        {
            return DealWithPeoples.ReturnPersonId(NotionalNo);
        }
        public static int GetPersonIdUsingDriverId(int DriverId)
        {
            return DealWithPeoples.GetPersonIdUsingDriverId(DriverId);
        }
       
        public static string ReturnNationalNo(int PersonId)
        {
            return DealWithPeoples.ReturnNationalNo(PersonId);
        }
    }
}
