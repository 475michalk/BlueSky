using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
   public class payment
    {
        public DataRow dr;
        private int kodpayment;
        
        private int summany;
        private string mascard;
        private string dataofcard;
        private string threemas;
        private string tz;

        public int Kodpayment { get => kodpayment; set => kodpayment = value; }
        
        public int Summany { get => summany; set => summany = value; }
        public string Mascard
        {
            get => mascard;
            set
            {
                if (!Validation.checkVisa(value.ToString()))
                    throw new Exception("הקש מספר אשראי תקין");
                mascard = value;
            }
        }
        public string Dataofcard { get => dataofcard; set => dataofcard = value; }
        public string Threemas {
            get => threemas;
            set
            {
                if (!Validation.IsNum(value.ToString()))
                    throw new Exception("הקש ספרות בלבד");
                threemas = (value);
            }
        }
        public string Tz
        {
            get => tz;
            set
            {
                if (!Validation.CheckId(value.ToString()))
                    throw new Exception("הקש ת.ז. תקינה");
                tz = (value);
            }
        }

        public payment() { }

        public payment(DataRow dr)
        {
            this.dr = dr;
            kodpayment = Convert.ToInt32(dr["KodPayment"].ToString());
           
           summany = Convert.ToInt32(dr["SumMany"].ToString());
           mascard = (dr["masCard"].ToString());
            dataofcard = (dr["dateOfCard"].ToString());
           threemas = (dr["threemas"].ToString());
            tz = (dr["tz"].ToString());

        }
        public void FillDataRow()
        {
            dr["KodPayment"] = this.kodpayment;
            
            dr["SumMany"] =summany;
            dr["masCard"] = mascard;
            dr["dateOfCard"] =dataofcard;
            dr["threemas"] = threemas;
            dr["tz"] = tz;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
