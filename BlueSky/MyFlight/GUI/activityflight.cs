using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFlight.BLL;

namespace MyFlight.GUI
{


    public partial class activityflight : Form
    {
        Activeflights t1, t2;
        flighthoursDB tblhour;
        flighthours a,bb;
        flighthours a1;
        invetationDB tblinvation;
        costDB tblcost;
        ActiveflightsDB tblactive;
        public passenger[] arr = new passenger[10];
        public int traveler, childtravler, c = 1, b, h;
        public double gg;
        DateTime fv, ff,p;
        string cr, fr;


        public activityflight(string fr, string cr, DateTime d, DateTime p, int traveler, int childtravler)
        {

            tblactive = new ActiveflightsDB();
            tblhour = new flighthoursDB();
            tblcost = new costDB();
            a = new flighthours();
            bb = new flighthours();
            a1 = new flighthours();
            InitializeComponent();
            this.cr = cr;
            this.fr = fr;
            this.p = p;
            fv = d;
            ff = p;
            this.traveler = traveler;
            this.childtravler = childtravler;
            b = traveler + childtravler;
            tblinvation = new invetationDB();
            gg = Convert.ToInt32((a.Cost) + (a1.Cost));
            if (fv.Date == DateTime.Today.Date)
            {
                dataGridView1.DataSource = tblhour.GetList().Select(x => new { מספר_טיסה = x.Numflight, קוד_טיסה = x.Kodflight, יום_בשבוע = x.Dayofweek, זמן_המראה = x.Timeofdeparture, זמן_נחיתה = x.Landingtime, משדה_תעופה = x.Airportfrom, לשדה_תעופה = x.Airportto, }).Where(x => x.משדה_תעופה == fr && x.לשדה_תעופה == cr && x.יום_בשבוע == (d.DayOfWeek.ToString()) && (Convert.ToDateTime(x.זמן_המראה).Hour > DateTime.Now.Hour)).ToList();//Convert.ToInt32(x.זמן_המראה.Substring(0,2))>DateTime.Now.Hour).ToList();
                dataGridView2.DataSource = tblhour.GetList().Select(x => new { מספר_טיסה = x.Numflight, קוד_טיסה = x.Kodflight, יום_בשבוע = x.Dayofweek, זמן_המראה = x.Timeofdeparture, זמן_נחיתה = x.Landingtime, משדה_תעופה = x.Airportfrom, לשדה_תעופה = x.Airportto, }).Where(x => x.משדה_תעופה == cr && x.לשדה_תעופה == fr && x.יום_בשבוע == (p.DayOfWeek.ToString())).ToList();
                dataGridView3.DataSource = tblhour.GetList().Select(x => new { מספר_טיסה = x.Numflight, קוד_טיסה = x.Kodflight, יום_בשבוע = x.Dayofweek, זמן_המראה = x.Timeofdeparture, זמן_נחיתה = x.Landingtime, משדה_תעופה = x.Airportfrom, לשדה_תעופה = x.Airportto, }).Where(x => x.משדה_תעופה == fr && x.לשדה_תעופה == cr && x.יום_בשבוע == (d.DayOfWeek.ToString())).ToList();

            }
            else
            {

                dataGridView1.DataSource = tblhour.GetList().Select(x => new { מספר_טיסה = x.Numflight, קוד_טיסה = x.Kodflight, יום_בשבוע = x.Dayofweek, זמן_המראה = x.Timeofdeparture, זמן_נחיתה = x.Landingtime, משדה_תעופה = x.Airportfrom, לשדה_תעופה = x.Airportto, }).Where(x => x.משדה_תעופה == fr && x.לשדה_תעופה == cr && x.יום_בשבוע == (d.DayOfWeek.ToString())).ToList();
                dataGridView2.DataSource = tblhour.GetList().Select(x => new { מספר_טיסה = x.Numflight, קוד_טיסה = x.Kodflight, יום_בשבוע = x.Dayofweek, זמן_המראה = x.Timeofdeparture, זמן_נחיתה = x.Landingtime, משדה_תעופה = x.Airportfrom, לשדה_תעופה = x.Airportto, }).Where(x => x.משדה_תעופה == cr && x.לשדה_תעופה == fr && x.יום_בשבוע == (p.DayOfWeek.ToString())).ToList();
                dataGridView3.DataSource = tblhour.GetList().Select(x => new { מספר_טיסה = x.Numflight, קוד_טיסה = x.Kodflight, יום_בשבוע = x.Dayofweek, זמן_המראה = x.Timeofdeparture, זמן_נחיתה = x.Landingtime, משדה_תעופה = x.Airportfrom, לשדה_תעופה = x.Airportto, }).Where(x => x.משדה_תעופה == fr && x.לשדה_תעופה == cr && x.יום_בשבוע == (d.DayOfWeek.ToString())).ToList();
            }
            a = tblhour.GetList().FirstOrDefault(x => x.Airportfrom == fr && x.Airportto == cr && x.Dayofweek == (d.DayOfWeek.ToString()));
            if ((dataGridView1.Rows.Count == 0))
            {
                DialogResult r = MessageBox.Show("אין טיסות פעילות בפרטים שהזנת", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                
                    this.Hide();
               
                
            }
                if (a != null)
                {
                    h = a.Kodflight;

                }
            if (a == null)

            {
                DialogResult r = MessageBox.Show("אין טיסות פעילות בפרטים שהזנת", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);


            }

                panel1.Visible = true;
                UserControl1 uc = new UserControl1();
                UserControl1 f = new UserControl1();
                panel3.Controls.Add(uc);
                uc.Dock = DockStyle.Right;

                label6.Text = "נוסע" + c + "/" + b;
                //  label38.Text =label38.Text +(f.txt_first.Text);
            
        }
        
        public bool CreateFields(invetation a)
        {

            bool FlagOK = true;
            a.Kodorder = tblinvation.GetNextKey();
            a.DateToday = DateTime.Today;
            a.Kodactivityflight = t1.kodactivityflight1;

            a.Sumorder = Convert.ToInt32(gg);


            return FlagOK;
        }
        public bool CreateFields2(invetation a)
        {

            bool FlagOK = true;
            a.Kodorder = tblinvation.GetNextKey();
            a.DateToday = DateTime.Now;
            a.Kodactivityflight = t2.kodactivityflight1;

            a.Sumorder = Convert.ToInt32(gg);


            return FlagOK;
        }
        public bool CreateFields3(Activeflights t)
        {

            bool FlagOK = true;
            t.kodactivityflight1 = tblactive.GetNextKey();
            t.flightNum1 = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            t.kodFlight1 = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
            t.dateToday1 = fv;
            t.availability1 = 150;
            t.status1 = true;
            return FlagOK;
        }
        public bool CreateFields4(Activeflights t)
        {

            bool FlagOK = true;
            t.kodactivityflight1 = tblactive.GetNextKey();
            t.flightNum1 = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            t.kodFlight1 = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[1].Value);
            t.dateToday1 = ff;
            t.availability1 = 150;
            t.status1 = true;
            return FlagOK;
        }
        public activityflight()
        {
        }

        public void rt(custemer_first cf)
        {
            if ((cf).rad_two.Checked)
            {
                dataGridView1.Visible = true;
                panel1.Visible = true;
                label3.Visible = true;
            }
            if ((cf).rad_one.Checked)
            {
                dataGridView2.Visible = false;
                panel2.Visible = false;
                label3.Visible = false;
            }

        }
        private void btn_choose_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;

        }

        private void btn_choose_MouseClick(object sender, MouseEventArgs e)
        {
            //  a = tblhour.Find(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value));
            //a1 = tblhour.Find(Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[1].Value));
            //btn_choose.Text= (Convert.ToDouble(a.Cost+a1.Cost)).ToString();

        }
        private void plus()
        {

        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mone++;
            t1 = tblactive.GetList().FirstOrDefault(x => x.flightNum1 == Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) && x.kodFlight1 == Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()) && x.dateToday1.Date == fv.Date);
            if (t1 != null && t1.availability1 < b)
                MessageBox.Show("אין מקום");
            else
            {
                a = tblhour.Find(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value), Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                btn_choose.Text = '\n' + " " + '\n' + "מחיר הטיסה בדולר";
                btn_choose.Text = ((btn_choose.Text + (Convert.ToDouble(a.Cost))).ToString());
                gg += a.Cost;
                if (fv.DayOfWeek == ff.DayOfWeek)
                {
                    dataGridView2.DataSource = tblhour.GetList().Select(x => new { מספר_טיסה = x.Numflight, קוד_טיסה = x.Kodflight, יום_בשבוע = x.Dayofweek, זמן_המראה = x.Timeofdeparture, זמן_נחיתה = x.Landingtime, משדה_תעופה = x.Airportfrom, לשדה_תעופה = x.Airportto, }).Where(x => x.משדה_תעופה == cr && x.לשדה_תעופה == fr && (x.יום_בשבוע == (p.DayOfWeek.ToString())) && ((Convert.ToDateTime(x.זמן_המראה) >= Convert.ToDateTime(a.Landingtime))) && (Convert.ToDateTime(x.זמן_המראה) >= Convert.ToDateTime(a.Landingtime).AddHours(3))).ToList();
                }
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mone++;
            t2 = tblactive.GetList().FirstOrDefault(x => x.flightNum1 == Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()) && x.kodFlight1 == Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[1].Value.ToString()) && x.dateToday1.Date == ff.Date);
            if (t2 != null && t2.availability1 < b)
                MessageBox.Show("אין מקום");
            else
            {
                a1 = tblhour.Find(Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[1].Value), Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));
                btn_choose.Text = " " + '\n' + "מחיר הטיסה בדולר";
                btn_choose.Text = "מחיר הטיסה בדולר" + '\n' + (Convert.ToDouble(((a.Cost) + (a1.Cost)).ToString())) + '\n' + "המשך"+" "+"לאחר הבחירה לא תוכל לבטל טיסה";
                gg += a1.Cost;
            }
            //+(Convert.ToDouble((btn_choose.Text))).ToString();
        }


        DataTable Getselectedrows(DataGridView dgv, DataGridView dgv1)
        {
            // dataGridView3.= 7; איך עושים מספר עמודות של coulms
            var dt = new DataTable();

            dt.Columns.Add("מספר_טיסה");
            dt.Columns.Add("קוד_טיסה");
            dt.Columns.Add("יום_בשבוע");
            dt.Columns.Add("זמן_המראה");
            dt.Columns.Add("זמן_נחיתה");
            dt.Columns.Add("משדה_תעופה");
            dt.Columns.Add("לשדה_תעופה");

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                //if (column.Visible)
                //{
                //    dt.Columns.Add();
                //}
            }

            foreach (DataGridViewColumn column in dgv1.Columns)
            {
                //if (column.Visible)
                //{
                //    dt.Columns.Add();
                //}
            }

            object[] cellval = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.Selected) continue;
                for (int i = 0; i < row.Cells.Count; i++)
                    cellval[i] = row.Cells[i].Value;

                dt.Rows.Add(cellval);
            }
            object[] cellval1 = new object[dgv1.Columns.Count];
            foreach (DataGridViewRow row in dgv1.Rows)
            {
                if (!row.Selected) continue;
                for (int i = 0; i < row.Cells.Count; i++)
                    cellval1[i] = row.Cells[i].Value;

                dt.Rows.Add(cellval1);
            }
            return dt;
        }

        private void btn_nameseat_TextChanged(object sender, EventArgs e)
        {


        }

        private void btn_nameseat_Click(object sender, EventArgs e)
        {
            //groupBox1.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }


        public invetation b1, a11;
        int mone = 0;
        private void btn_choose_Click_1(object sender, EventArgs e)
        {

            a11 = new invetation();
            b1 = new invetation();
            //t1 = new Activeflights();
            // t2 = new Activeflights();



            bool flagOkActivity = true;
            if (dataGridView2.Visible == true)
            {
                if (t1 == null)
                {
                    t1 = new Activeflights();
                    if (CreateFields3(t1))
                    {
                        tblactive.AddNew(t1);
                    }
                    else
                        flagOkActivity = false;
                }
                if (flagOkActivity)
                {
                    if (CreateFields(a11))
                    {
                        tblinvation.AddNew(a11);
                        t1.availability1 -= b;
                    }
                }

                flagOkActivity = true;
                if (t2 == null)
                {
                    t2 = new Activeflights();
                    if (CreateFields4(t2))
                    {
                        tblactive.AddNew(t2);
                    }
                    else
                        flagOkActivity = false;
                }
                if (flagOkActivity)
                {
                    if (CreateFields2(b1))
                    {
                        tblinvation.AddNew(b1);
                        t2.availability1 -= b;
                        tblactive.UpdateRow(t2);
                    }
                }
            }

            else
            {
                if (t1 == null)
                {
                    t1 = new Activeflights();
                    if (CreateFields3(t1))
                    {
                        tblactive.AddNew(t1);
                    }
                    else
                        flagOkActivity = false;
                }
                if (flagOkActivity)
                {
                    if (CreateFields(a11))
                    {
                        tblinvation.AddNew(a11);
                        t1.availability1 -= b;
                    }
                }
                tblactive.UpdateRow(t1);

            }
            if (dataGridView2.Visible == false && mone == 1)

            {

                dataGridView3.DataSource = tblhour.GetList().Where(x => x.Numflight == Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)&& ( x.Kodflight == Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value))).Select(x => new { מספר_טיסה = x.Numflight, קוד_טיסה = x.Kodflight, יום_בשבוע = x.Dayofweek, זמן_המראה = x.Timeofdeparture, זמן_נחיתה= x.Landingtime, מוצא = x.Airportfrom , יעד = x.Airportto, מחיר = x.Cost }).ToList();
                panel2.Visible = true;
            }
            else
            {
                if (mone == 2)
                {
                    
                    panel2.Visible = true;
                    custemer_first obj = (custemer_first)Application.OpenForms["custemer_first"];
                    obj.Close();
                    
                    dataGridView3.DataSource = Getselectedrows(dataGridView1, dataGridView2);
                }

                else
                {
                    MessageBox.Show("בחר טיסה");
                }
            }
        }
        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //   dataGridView3.DefaultCellStyle.SelectionBackColor.BackColor;
            //  datagridview.DefaultCellStyle.SelectionForeColorערך כמו.ForeColor
            //dataGridView3.DefaultCellStyle.SelectionBackColor backColor;

        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView3.ClearSelection();
        }

       
    }
}
