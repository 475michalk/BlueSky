using System;
using System.Windows.Forms;
using System.Data;
using MyFlight.BLL;
using MyFlight.DAL;
using MyFlight.GUI;
using System.Linq;

namespace MyFlight.GUI
{
    public partial class custemer_first : Form
    {
        public custemer_first()
        {
            
            InitializeComponent();
           
            dtp_went.MinDate = DateTime.Now;
        }
     
        private void dtp_went_ValueChanged(object sender, EventArgs e)
        {
            dtp_went.CustomFormat = "dd/MM/yyyy";
            dtp_return.MinDate = dtp_went.Value;
        }

        private void dtp_return_ValueChanged(object sender, EventArgs e)
        {
            dtp_return.CustomFormat = "dd/MM/yyyy";
        }
       
            private void btn_activity_Click(object sender, EventArgs e)
        {

            flighthours hh,ll ;
            Activeflights b;
            flighthoursDB tblflight = new flighthoursDB();
            ActiveflightsDB tblacti = new ActiveflightsDB();
            hh = tblflight.GetList().FirstOrDefault(x => x.Airportfrom == from.Text && x.Airportto == to.Text && x.Dayofweek == (dtp_went.Value.DayOfWeek).ToString());
            ll = tblflight.GetList().FirstOrDefault(x => x.Airportto == from.Text && x.Airportfrom == to.Text && x.Dayofweek == (dtp_return.Value.DayOfWeek).ToString());
            if (hh == null || ll == null)
            {
                MessageBox.Show("אין טיסות פעילות בפרטים שהזנת", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            }

            if ((dtp_went.Value.Date == DateTime.Today.Date))
            {
                var l = tblflight.GetList().Where(x => x.Airportfrom == from.SelectedItem && x.Airportto == to.SelectedItem && x.Dayofweek == (dtp_went.Value.DayOfWeek).ToString() && (Convert.ToDateTime(x.Timeofdeparture).Hour < DateTime.Now.Hour)).ToList();//Convert.ToInt32(x.זמן_המראה.Substring(0,2))>DateTime.Now.Hour).ToList();
                //var lu = tblflight.GetList().Where(x => x.Airportfrom == to.SelectedItem && x.Airportto == from.SelectedItem && x.Dayofweek == (dtp_went.Value.DayOfWeek).ToString() && (Convert.ToDateTime(x.Timeofdeparture).Hour < DateTime.Now.Hour)).ToList();//Convert.ToInt32(x.זמן_המראה.Substring(0,2))>DateTime.Now.Hour).ToList();
                if (l.Count== 0) //|| lu.Count == 0)
                {
                    MessageBox.Show("אין טיסות פעילות בפרטים שהזנת", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    if (hh != null && ll != null)
                    {

                        invetation a = new invetation();
                        GUI.activityflight p = new GUI.activityflight(from.Text, to.Text, dtp_went.Value, dtp_return.Value, Convert.ToInt32(numd_man.Value), Convert.ToInt32(numd_boy.Value));
                        p.rt(this);
                        p.Show();
                        panel1.Visible = true;
                    }
                }
            }
            else
            {
                if (hh != null && ll != null)
                {

                    invetation a = new invetation();
                    GUI.activityflight p = new GUI.activityflight(from.Text, to.Text, dtp_went.Value, dtp_return.Value, Convert.ToInt32(numd_man.Value), Convert.ToInt32(numd_boy.Value));
                    p.rt(this);
                    p.Show();
                    panel1.Visible = true;
                }
                else
                {
                    MessageBox.Show("אין טיסות פעילות בפרטים שהזנת", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                }
            }

        }

        private void btn_travler_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void rad_one_Click_1(object sender, EventArgs e)
        {
           // to.Visible = false;
            dtp_return.Enabled = false;
        }

        private void rad_two_Click(object sender, EventArgs e)
        {
            to.Visible = true;
            dtp_return.Enabled = true;
        }

        private void rad_one_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad_two_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void custemer_first_Load(object sender, EventArgs e)
        {

        }
    }
}
