using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
  public  class myflight
    {
        public DataRow dr;
        private string destinationFrom;
        private string destinationto;
        private int kodFlight;

        public string DestinationFrom { get => destinationFrom; set => destinationFrom = value; }
        public string Destinationto { get => destinationto; set => destinationto = value; }
        public int KodFlight { get => kodFlight; set => kodFlight = value; }

        public myflight() { }

        public myflight(DataRow dr)
        {
            this.dr = dr;
            destinationFrom = dr["DestinationFrom"].ToString();
            destinationto = dr["DestinationTo"].ToString();
            kodFlight = Convert.ToInt32(dr["KodFlight"].ToString());

        }
        public void FillDataRow()
        {
            dr["DestinationFrom"] = this.DestinationFrom;
            dr["DestinationTo"] = destinationto;
            dr["KodFlight"] = kodFlight;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
