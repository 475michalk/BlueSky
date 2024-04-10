using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
    class airportallDB : GeneralDB
    {
        public airportallDB() : base("airportall") { }

        protected List<airportall> list = new List<airportall>();

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new airportall(dr));
            }
        }
        public List<airportall> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }

        public void AddNew(airportall c)
        {
            c.dr = table.NewRow();
            c.FillDataRow();
            this.Add(c.dr);
        }
        public airportall Find(int code)
        {
            return this.GetList().Find(x => x.Kodc == code);
        }
        public void UpdateRow(airportall c)
        {
            c.FillDataRow();
            this.Update();
        }
        public void DeleteRow(int code)
        {
            airportall area = this.Find(code);
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
            return this.GetList().Max(x => x.Kodc) + 1;
        }
    }
}