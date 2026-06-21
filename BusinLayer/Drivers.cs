using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace BusinLayer
{
    public class Drivers
    {
        private int _DriverId;
        private int _PersonId;
        private int _CreatedByUserId;
        private DateTime _CreatedDate;
        public int DriverId
        {
            get { return _DriverId; }
        }
        public int PersonId
        {
            get { return _PersonId; }
        }
        public int CreatedByUserId
        {
            get { return _CreatedByUserId; }
        }
        public DateTime CreatedDate
        {
            get { return _CreatedDate; }
        }

        public Drivers(int PersonId,int CreatedByUserId)
        {
            _PersonId = PersonId;
            _CreatedByUserId = CreatedByUserId;
        }

        public static int AddDriver(Drivers driver)
        {
            return DealWithDrivers.AddDriver(driver._PersonId, driver._CreatedByUserId);
        }
        public static int GetDriverIdUsingPersonId(int PersonId)
        {
            return DealWithDrivers.GetDriverIdUsingPersonId(PersonId);
        }
        public static DataTable GetAllDrivers()
        {
            return DealWithDrivers.GetAllDrivers();
        }
    }
}
