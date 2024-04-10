using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
public    class ordercharger
    {
        public DataRow dr;
        private int kodorder;
        private int chargerkod;
        private int amount;

        public int Kodorder { get => kodorder; set => kodorder = value; }
        public int Chargerkod { get => chargerkod; set => chargerkod = value; }
        public int Amount { get => amount; set => amount = value; }

        public ordercharger() { }

        public ordercharger(DataRow dr)
        {
            this.dr = dr;
            kodorder = Convert.ToInt32(dr["KodOrder"].ToString());
            chargerkod =Convert.ToInt32( dr["ChargeCode"].ToString());
            amount = Convert.ToInt32(dr["Amount"].ToString());

        }
        public void FillDataRow()
        {
            dr["KodOrder"] = this.kodorder;
            dr["ChargeCode"] = chargerkod;
            dr["Amount"] = amount;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
