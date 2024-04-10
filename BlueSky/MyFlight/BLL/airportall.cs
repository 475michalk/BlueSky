using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
   public class airportall
    {
        public DataRow dr;
        private int kodc;
        private string namecountry;
        private string country;

        public int Kodc { get => kodc; set => kodc = value; }
        public string Namecountry { get => namecountry; set => namecountry = value; }
        public string Country { get => country; set => country = value; }

        public airportall() { }

        public airportall(DataRow dr)
        {
            this.dr = dr;
            kodc = Convert.ToInt32(dr["KodC"].ToString());
            namecountry = dr["NameCountry"].ToString();
            country = dr["Country"].ToString();
      
        }
        public void FillDataRow()
        {
            dr["KodC"] = this.kodc;
            dr["NameCountry"] = namecountry;
            dr["Country"] =country;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
