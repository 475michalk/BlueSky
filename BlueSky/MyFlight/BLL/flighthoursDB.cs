using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
    class flighthoursDB : GeneralDB
    {
        public flighthoursDB() : base("flighthours") { }

        protected List<flighthours> list = new List<flighthours>();

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new flighthours(dr));
            }
        }
        public List<flighthours> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }

        public void AddNew(flighthours c)
        {
            c.dr = table.NewRow();
            c.FillDataRow();
            this.Add(c.dr);
        }
        public flighthours Find(int code,int c)
        {
            return this.GetList().Find(x => x.Kodflight==code && x.Numflight == c);
        }
        public void UpdateRow(flighthours c)
        {
            c.FillDataRow();
            this.Update();
        }
        public void DeleteRow(int code,int c)
        {
            flighthours area = this.Find(code,c);
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
            return this.GetList().Max(x => x.Numflight) + 1;
        }
    }
}
