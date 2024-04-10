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
  public  class Activeflights
    {
        public DataRow dr;
        private int kodactivityflight;
        private int flightNum;
        private int kodFlight;
        private DateTime dateToday;
        private int availability;
        private bool status;


        public int kodactivityflight1 { get => kodactivityflight; set => kodactivityflight = value; }
        public int flightNum1 { get => flightNum; set => flightNum = value; }
        public int kodFlight1 { get => kodFlight; set => kodFlight = value; }
        public DateTime dateToday1 { get => dateToday; set => dateToday = value; }
        public int availability1 { get => availability; set => availability = value; }
        public bool status1 { get => status; set => status = value; }

        public Activeflights() { }

        public Activeflights(DataRow dr)
        {
            this.dr = dr;
            kodactivityflight = Convert.ToInt32(dr["KodActivityFlight"].ToString());
            flightNum = Convert.ToInt32(dr["FlightNum"].ToString());
            kodFlight = Convert.ToInt32(dr["KodFlight"].ToString());
            dateToday = Convert.ToDateTime(dr["DateToday"]);
            availability = Convert.ToInt32(dr["Availability"].ToString());
            status = Convert.ToBoolean(dr["Status"]);
        }
        public void FillDataRow()
        {
            dr["KodActivityFlight"] = this.kodactivityflight;
            dr["FlightNum"] = flightNum;
            dr["KodFlight"] =kodFlight;
            dr["DateToday"] = dateToday;
            dr["Availability"] = availability;
            dr["Status"] = status;

        }

        public override string ToString()
        {
            return base.ToString();
        }
        public flighthours thiaflight()
        {
            flighthoursDB tblc = new flighthoursDB();
            return tblc.Find(this.kodFlight, this.flightNum);
        }
    }
   
}
