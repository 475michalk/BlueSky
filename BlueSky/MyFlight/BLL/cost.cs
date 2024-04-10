using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
 public   class cost
    {
        public DataRow dr;
        private int kodflight;
        private int numflight;
        private int travler;
        private int priceofone;
        private int pricefortwo;

        public int Kodflight { get => kodflight; set => kodflight = value; }
        public int Numflight { get => numflight; set => numflight = value; }
        public int Travler { get => travler; set => travler = value; }
        public int Priceofone { get => priceofone; set => priceofone = value; }
        public int Pricefortwo { get => pricefortwo; set => pricefortwo = value; }

        public cost() { }

        public cost(DataRow dr)
        {
            this.dr = dr;
            kodflight = Convert.ToInt32(dr["KodFlight"].ToString());
            numflight = Convert.ToInt32(dr["FlightNum"].ToString());
           travler = Convert.ToInt32(dr["Traveler"].ToString());
            priceofone = Convert.ToInt32(dr["Priceperone"].ToString());
            pricefortwo= Convert.ToInt32(dr["Pricefortwo"].ToString());

        }
        public void FillDataRow()
        {
            dr["KodFlight"] = this.kodflight;
            dr["FlightNum"] = numflight;
            dr["Traveler"] = travler;
            dr["Priceperone"] = priceofone;
            dr["Pricefortwo"] =pricefortwo;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
