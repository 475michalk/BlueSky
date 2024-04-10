using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MyFlight.BLL;
using MyFlight.DAL;
using MyFlight.GUI;


namespace MyFlight.BLL
{
    class CityDB : GeneralDB
    {
        public CityDB() : base("Cities") { }

        protected List<City> list = new List<City>();

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new City(dr));
            }
        }

        public List<City> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }

        public void AddNew(passenger c)
        {
            c.dr = table.NewRow();
            c.FillDataRow();
            this.Add(c.dr);
        }
        public City Find(int code)
        {
            return this.GetList().Find((x => x.CityId == code));
        }
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.CityId) + 1;
        }
    }
}
