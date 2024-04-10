using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
    class chargerDB : GeneralDB
    {
        public chargerDB() : base("Charges") { }

        protected List<charger> list = new List<charger>();

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new charger(dr));
            }
        }
        public List<charger> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }

        public void AddNew(charger c)
        {
            c.dr = table.NewRow();
            c.FillDataRow();
            this.Add(c.dr);
        }
        public charger Find(int code)
        {
            return this.GetList().Find(x => x.Chargerkod == code );
        }
        public void UpdateRow(charger c)
        {
            c.FillDataRow();
            this.Update();
        }
        public void DeleteRow(int code)
        {
            charger area = this.Find(code);
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
            return this.GetList().Max(x => x.Chargerkod) + 1;
        }
    }
}
