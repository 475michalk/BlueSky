using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
  public  class charger
    {
        public DataRow dr;
       
        private int chargerkod;
        private double weight;
        private int expensve;

       
        public int Chargerkod { get => chargerkod; set => chargerkod = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Expensve { get => expensve; set => expensve = value; }

        public charger() { }

        public charger(DataRow dr)
        {
            this.dr = dr;
            
            chargerkod = Convert.ToInt32(dr["ChargeCode"].ToString());
            weight =Convert.ToInt32( dr["Weight"].ToString());
            expensve =Convert.ToInt32( dr["Expense"].ToString());

        }
        public void FillDataRow()
        {
           
            dr["ChargeCode"] = this.chargerkod;
            dr["Weight"] = weight;
            dr["Expense"] = expensve;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
