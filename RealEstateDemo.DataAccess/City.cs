using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDemo.DataAccess
{
    public class City
    {
        public City(string cityName)
        {
            CityName = cityName;
        }

        public int CityPK { get; set; }
        public string CityName { get; set; }
    }
}
