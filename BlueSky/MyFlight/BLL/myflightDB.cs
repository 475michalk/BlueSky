using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
    class myflightDB : GeneralDB
    {
        public myflightDB() : base("MyFlights") { }

        protected List<myflight> list = new List<myflight>();

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new myflight(dr));
            }
        }
        public List<myflight> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }

        public void AddNew(myflight c)
        {
            c.dr = table.NewRow();
            c.FillDataRow();
            this.Add(c.dr);
        }
        public myflight Find(int code)
        {
            return this.GetList().Find(x => x.KodFlight == code);
        }
        public void UpdateRow(myflight c)
        {
            c.FillDataRow();
            this.Update();
        }
        public void DeleteRow(int code)
        {
            myflight area = this.Find(code);
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
            return this.GetList().Max(x => x.KodFlight) + 1;
        }
    }
}
