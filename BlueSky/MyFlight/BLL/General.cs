using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MyFlight.DAL;

namespace MyFlight.BLL
{
    
        public abstract class GeneralDB
        {
            protected DataTable table;

            public GeneralDB(string tableName)
            {
                dalproject.GetInstance().AddTable(tableName);
                table = dalproject.GetInstance().GetTable(tableName);
            }
            public int Size()
            {
                return table.Rows.Count;
            }
            public bool IsEmpty()
            {
                return table.Rows.Count == 0;
            }
            public virtual void Save()
            {
                dalproject.GetInstance().Update(table.TableName);
            }
            public void Add(DataRow dr)
            {
                table.Rows.Add(dr);
                this.Save();
            }

            public DataTable GetTable()
            {
                return this.table;
            }
            public void Update()
            {
                dalproject.GetInstance().Update(table.TableName);
            }

        }
    }

