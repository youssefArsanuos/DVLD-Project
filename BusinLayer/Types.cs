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
    public class Types
    {
        public static DataTable getApplicationTypes()
        {
            return DealWithTypes.getApplicationTypes();
        }

        public static bool EditApplicationType(int ApplicationTypeId, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            return DealWithTypes.EditApplicationType(ApplicationTypeId, ApplicationTypeTitle, ApplicationFees);
        }

        public static DataTable getTestTypes()
        {
            return DealWithTypes.getTestTypes();
        }

        public static bool EditTestType(int TestTypeId, string TestTypeTitle, decimal TestFees, string TestTypeDescription)
        {
            return DealWithTypes.EditTestType(TestTypeId, TestTypeTitle, TestFees, TestTypeDescription);
        }

    }
}
