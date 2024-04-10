using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace MyFlight.BLL
{
 public   class invetation
    {
        public DataRow dr;
        private int kodorder;
        private DateTime dateToday;
        private int kodactivityflight;
        
        private int sumorder;

        public int Kodorder { get => kodorder; set => kodorder = value; }
        public DateTime DateToday { get => dateToday; set => dateToday = value; }
        public int Kodactivityflight { get => kodactivityflight; set => kodactivityflight = value; }
        
        public int Sumorder { get => sumorder; set => sumorder = value; }

        public invetation() { }

        public invetation(DataRow dr)
        {
            this.dr = dr;
            kodorder = Convert.ToInt32(dr["KodOrder"].ToString());
            dateToday= Convert.ToDateTime(dr["DateToday"].ToString());
            kodactivityflight = Convert.ToInt32(dr["KodActivityFlight"].ToString());
            
            sumorder = Convert.ToInt32(dr["SumOrder"].ToString());

        }
        public void FillDataRow()
        {
            dr["KodOrder"] = this.kodorder;
            dr["DateToday"] = dateToday;
            dr["KodActivityFlight"] = kodactivityflight;
            
            dr["SumOrder"] = sumorder;


        }

        public override string ToString()
        {
            return base.ToString();
        }
        public Activeflights Thisactive()
        {
            ActiveflightsDB tblc = new ActiveflightsDB();
            return tblc.Find(this.Kodactivityflight);
        }
    }
}
