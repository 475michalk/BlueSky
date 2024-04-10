using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
    class orderchargerDB : GeneralDB
    {
        public orderchargerDB() : base("ordercharger") { }

        protected List<ordercharger> list = new List<ordercharger>();

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new ordercharger(dr));
            }
        }
        public List<ordercharger> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }

        public void AddNew(ordercharger c)
        {
            c.dr = table.NewRow();
            c.FillDataRow();
            this.Add(c.dr);
        }
        public ordercharger Find(int code,int c)
        {
            return this.GetList().Find(x => x.Kodorder == code && x.Chargerkod == c);
        }
        public void UpdateRow(ordercharger c)
        {
            c.FillDataRow();
            this.Update();
        }
        public void DeleteRow(int code,int c)
        {
            ordercharger area = this.Find(code,c);
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
            return this.GetList().Max(x => x.Kodorder) + 1;
        }
    }
}
