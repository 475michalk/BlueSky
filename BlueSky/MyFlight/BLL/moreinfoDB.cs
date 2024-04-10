using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
    class moreinfoDB : GeneralDB
    {
        public moreinfoDB() : base("moreinfo") { }

        protected List<moreinfo> list = new List<moreinfo>();

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new moreinfo(dr));
            }
        }
        public List<moreinfo> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }

        public void AddNew(moreinfo c)
        {
            c.dr = table.NewRow();
            c.FillDataRow();
            this.Add(c.dr);
        }
        public moreinfo Find(int code)
        {
            return this.GetList().Find(x => x.KodFlight == code);
        }
        public void UpdateRow(moreinfo c)
        {
            c.FillDataRow();
            this.Update();
        }
        public void DeleteRow(int code)
        {
            moreinfo area = this.Find(code);
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
