using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinLayer
{
    public class User
    {
        private int _UserId;
        private int _PersonId;
        private byte _IsActive;
        private string _UserName;
        private string _Password;

        public User(int PersonId, int UserId, byte IsActive, string UserName, string Password)
        {
            this._PersonId = PersonId;
            this._IsActive = IsActive;
            this._UserName = UserName;
            this._Password = Password;
            this._UserId = UserId;
        }
        public User(int PersonId, byte IsActive, string UserName, string Password)
        {
            this._PersonId = PersonId;
            this._IsActive = IsActive;
            this._UserName = UserName;
            this._Password = Password;
            this._UserId = DealWithUsers.GetUserId(PersonId);
        }
        public User(int PersonId, byte IsActive, string UserName, int UserId)
        {
            this._PersonId = PersonId;
            this._IsActive = IsActive;
            this._UserName = UserName;
            this._UserId = UserId;
        }
        public int UserId
        {
            get { return _UserId; }
        }

        public int PersonId
        {
            get { return _PersonId; }
        }

        public byte IsActive
        {
            get { return _IsActive; }
        }

        public string UserName
        {
            get { return _UserName; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public static int AddUser(User u)
        {
            return DealWithUsers.AddUser(u.PersonId,u.IsActive,u.UserName,u.Password);
              
        }
        public static int CheckUser(string UserName, string Password)
        {
            return DealWithUsers.CheckUser(UserName, Password);
        }
        public static int ReturnUPersonId(string UserName, string Password)
        {
            return DealWithUsers.ReturnUPersonId(UserName, Password);
        }
        public static DataTable GetAllUsers()
        {
            return DealWithUsers.getUsers();
        }
        public static DataTable SearchUser(string Col, string search)
        {
            string Query = @" 
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
                             ON u.PersonId = p.PersonId";

                                 
            return Settings.Search(Col, search, Query);
        }

        public static bool DeleteUser(String Id)
        {
            return DealWithUsers.DeleteUser(Id);
        }

        public static bool EditUser(User user)
        {
            return DealWithUsers.EditUser(user.UserId, user.UserName, user.Password, user.IsActive);
        }

        public static bool EditUserPassword(User user)
        {
            return DealWithUsers.EditUserPassword(user.UserId,user.Password);
        }

        public static int ReturnUserId(int PersonId)
        {
            return DealWithUsers.ReturnUserID(PersonId);
        }

    }
}
