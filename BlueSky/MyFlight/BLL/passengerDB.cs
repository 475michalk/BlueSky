using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyFlight.BLL
{
    class passengerDB : GeneralDB
    {
        public passengerDB() : base("PassengersIN") { }

        protected List<passenger> list = new List<passenger>();

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new passenger(dr));
            }
        }

        public List<passenger> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }

        public void AddNew(passenger c)
        {
            c.dr = table.NewRow();
            c.FillDataRow(            c.GetPlaceF());
            this.Add(c.dr);
        }
        public passenger Find(string code ,int codeord)
        {
            return this.GetList().Find(x => x.Id == code&&x.Kodorder==codeord);
        }
        public void UpdateRow(passenger c)
        {
           
            c.FillDataRow(           
            c.GetPlaceF());
            this.Update();
        }
        public void UpdateRow9(passenger c,passenger d)
        {
            d.FillDataRow(            d.GetPlaceF());
            this.Update();
            c.FillDataRow(            c.GetPlaceF());
            this.Update();
        }
        public void DeleteRow(string code,int codeord)
        {
            passenger area = this.Find(code,codeord);
            if (area != null)
            {
                area.dr.Delete();
                this.Update();
            }
        }
        public string GetNextKey()
        {
            if (this.Size() == 0)
                return "1";
            return this.GetList().Max(x => x.Id) + 1;
        }
    }
}
