using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
    class invetationDB : GeneralDB
    {
        public invetationDB() : base("Invitation") { }

        protected List<invetation> list = new List<invetation>();

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new invetation(dr));
            }
        }
        public List<invetation> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }

        public void AddNew(invetation c)
        {
            c.dr = table.NewRow();
            c.FillDataRow();
            this.Add(c.dr);
        }
        public invetation Find(int code)
        {
            return this.GetList().Find(x => x.Kodorder == code);
        }
        public void UpdateRow(invetation c)
        {
            c.FillDataRow();
            this.Update();
        }
        public void DeleteRow(int code)
        {
            invetation area = this.Find(code);
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
