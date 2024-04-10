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
using MyFlight.DAL;
using MyFlight.GUI;

namespace MyFlight.GUI
{
    public partial class everyflight : Form
    {
        activityflight a;        ActiveflightsDB tblactivty;
        public everyflight()
        {
            InitializeComponent();
            tblactivty = new ActiveflightsDB();
          dataGridView1.DataSource = tblactivty.GetList().Select(x => new {קוד_טיסות_פעילות = x.kodactivityflight1, מספר_טיסה = x.flightNum1, קוד_טיסה = x.kodFlight1, תאריך = x.dateToday1, מספר_מקומות_בטיסה = x.availability1, סטטוס = x.status1 }).ToList();
        }

        private void btn_newflight_Click(object sender, EventArgs e)
        {
            GUI.newflight c = new GUI.newflight();
            c.Show();
            this.Close();
        }
    }
}
