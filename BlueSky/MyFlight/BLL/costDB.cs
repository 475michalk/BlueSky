using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
    class costDB : GeneralDB
    {
        public costDB() : base("cost") { }

        protected List<cost> list = new List<cost>();

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new cost(dr));
            }
        }
        public List<cost> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }

        public void AddNew(cost c)
        {
            c.dr = table.NewRow();
            c.FillDataRow();
            this.Add(c.dr);
        }
        public cost Find(int code)
        {
            return this.GetList().Find(x => x.Kodflight == code && x.Numflight==code  );
        }
        public void UpdateRow(charger c)
        {
            c.FillDataRow();
            this.Update();
        }
        public void DeleteRow(int code)
        {
            cost area = this.Find(code);
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
            return this.GetList().Max(x => x.Kodflight) + 1;
        }
    }
}
