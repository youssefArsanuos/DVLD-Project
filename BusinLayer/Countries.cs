using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;

namespace BusinLayer
{
    public class Countries
    {
        public static int SelectCountryId(string countryName)
        {
            return DealWithCountries.SelectCountryId(countryName);
            
        }
    }
}
