using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;



namespace MyFlight.DAL
{

        public class dalproject
        {
            private static dalproject instance;
            private OleDbConnection con;
            private DataSet ds;
            private dalproject(string connectionString)
            {
                con = new OleDbConnection(connectionString);
                ds = new DataSet();
            }
            public static dalproject GetInstance()
            {
                if (instance == null)
                {
                    string path = System.IO.Directory.GetCurrentDirectory();
                    int x = path.IndexOf("\\bin");
                    path = path.Substring(0, x) + "\\Dal\\Project flight.accdb";
                    instance = new dalproject(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Persist Security Info=True");
                }
                return instance;
            }
            public void AddTable(string tabbleName)
            {
                if (!ds.Tables.Contains(tabbleName))
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from " + tabbleName, con);
                    adapter.Fill(ds, tabbleName);
                }
            }
            public DataTable GetTable(string tableName)
            {
                if (!ds.Tables.Contains(tableName))
                    AddTable(tableName);
                return ds.Tables[tableName];
            }
            public bool RemoveTable(string tableName)
            {
                bool suceed = true;
                try
                {
                    ds.Tables.Remove(tableName);
                }
                catch
                {
                    suceed = false;
                }
                return suceed;
            }
            public DataTable GetSelectTable(string sql)
            {
                DataTable dt = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
                adapter.Fill(dt);
                return dt;
            }
            public void Update(string tableName)
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from " + tableName, con);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                adapter.InsertCommand = builder.GetInsertCommand();
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.DeleteCommand = builder.GetDeleteCommand();
                adapter.Update(ds, tableName);
            }
            public void Update()
            {
                foreach (DataTable table in ds.Tables)
                {
                    Update(table.TableName);
                }
            }

        }
    }
