using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
    class paymentDB : GeneralDB
    {
        public paymentDB() : base("Payments") { }

        protected List<payment> list = new List<payment>();

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new payment(dr));
            }
        }
        public List<payment> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }

        public void AddNew(payment c)
        {
            c.dr = table.NewRow();
            c.FillDataRow();
            this.Add(c.dr);
        }
        public void AddNew2(payment c,payment d)
        {
            c.dr = table.NewRow();
            c.FillDataRow();
            this.Add(c.dr);
            d.dr = table.NewRow();
            d.FillDataRow();
            this.Add(d.dr);
        }
        public payment Find(int code)
        {
            return this.GetList().Find(x => x.Kodpayment == code);
        }
        public void UpdateRow(payment c)
        {
            c.FillDataRow();
            this.Update();
        }
        public void DeleteRow(int code)
        {
            payment area = this.Find(code);
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
            return this.GetList().Max(x => x.Kodpayment) + 1;
        }
    }
}
