using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MyFlight.BLL;
using MyFlight.DAL;
using MyFlight.GUI;

namespace MyFlight.BLL
{
    public class City
    {
        DataRow dr;
        int cityId;
        string cityName;
        public City(DataRow dr)
        {
            this.dr = dr;
            cityId = Convert.ToInt16(dr["CityID"]);
            cityName = dr["CityName"].ToString();
        }
        public void FillDataRow()
        {

            Dr["CityID"] = cityId;
            Dr["CityName"] = cityName;
        }

        public override string ToString()
        {
            return this.cityName;
        }

        public City()
        {
        }

        public DataRow Dr { get => dr; set => dr = value; }
        public int CityId { get => cityId; set => cityId = value; }
        public string CityName { get => cityName; set => cityName = value; }
    }
}

