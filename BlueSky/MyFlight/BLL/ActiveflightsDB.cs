using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
   
        class ActiveflightsDB : GeneralDB
        {
            public ActiveflightsDB() : base("Activeflights") { }

            protected List<Activeflights> list = new List<Activeflights>();

            private void DataTableToList()
            {
                foreach (DataRow dr in table.Rows)
                {
                    list.Add(new Activeflights(dr));
                }
        }
        public List<Activeflights> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }

        public void AddNew(Activeflights c)
        {
            c.dr = table.NewRow();
            c.FillDataRow();
            this.Add(c.dr);
        }
        public Activeflights Find(int code)
        {
            return this.GetList().Find(x => x.kodactivityflight1 == code);
        }
        public void UpdateRow(Activeflights c)
        {
            c.FillDataRow();
            this.Update();
        }
        public void DeleteRow(int code)
        {
            Activeflights area = this.Find(code);
            if (area != null)
            {
                area.dr.Delete();
                this.Update();
            }
        }
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.kodactivityflight1) + 1;
        }
    }

}
