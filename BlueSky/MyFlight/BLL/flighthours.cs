using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
   public class flighthours
    {
        public DataRow dr;
        private int numflight;
        private int kodflight;
        private string dayofweek;
        private string timeofdeparture;
        private string landingtime;
        private string airportfrom;
        private string airportto;
        private double cost;

        public int Numflight { get => numflight; set => numflight = value; }
        public int Kodflight { get => kodflight; set => kodflight = value; }
        public string Dayofweek { get => dayofweek; set => dayofweek = value; }
        public string Timeofdeparture { get => timeofdeparture; set => timeofdeparture = value; }
        public string Landingtime { get => landingtime; set => landingtime = value; }
        public string Airportfrom { get => airportfrom; set => airportfrom = value; }
        public string Airportto { get => airportto; set => airportto = value; }
        public double Cost { get => cost; set => cost = value; }

        public flighthours() { }

        public flighthours(DataRow dr)
        {
            this.dr = dr;
            kodflight = Convert.ToInt32(dr["KodFlight"].ToString());
            numflight = Convert.ToInt32(dr["FlightNum"].ToString());
            dayofweek = dr["DayofWeek"].ToString();
            timeofdeparture =(dr["Timeofdeparture"]).ToString();
            landingtime =(dr["landingtime"]).ToString();
            airportfrom = dr["AirportFrom"].ToString();
            airportto = dr["AirportTo"].ToString();
            cost = Convert.ToDouble(dr["cost"]);

        }
        public void FillDataRow()
        {
            dr["KodFlight"] = this.kodflight;
            dr["FlightNum"] = numflight;
            dr["DayofWeek"] = dayofweek;
            dr["Timeofdeparture"] =timeofdeparture;
            dr["landingtime"] = landingtime;
            dr["AirportFrom"] = airportfrom;
            dr["AirportTo"] = airportto;
            dr["cost"] = cost;


        }

        public override string ToString()
        {
            return base.ToString();
        }
       
    }
}
