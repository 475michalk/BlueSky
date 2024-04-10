using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
  public  class moreinfo
    {
        public DataRow dr;
        private int kodFlight;
        private int dayofweek;
        private int numberofflights;

        public int KodFlight { get => kodFlight; set => kodFlight = value; }
        public int Dayofweek { get => dayofweek; set => dayofweek = value; }
        public int Numberofflights { get => numberofflights; set => numberofflights = value; }

        public moreinfo() { }

        public moreinfo(DataRow dr)
        {
            this.dr = dr;
            kodFlight = Convert.ToInt32(dr["KodFlight"].ToString());
           dayofweek = Convert.ToInt32(dr["DayofWeek"].ToString());
            numberofflights = Convert.ToInt32(dr["Numberofflights"].ToString());

        }
        public void FillDataRow()
        {
            dr["KodFlight"] = this.kodFlight;
            dr["DayofWeek"] =dayofweek;
            dr["Numberofflights"] = numberofflights;

        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
