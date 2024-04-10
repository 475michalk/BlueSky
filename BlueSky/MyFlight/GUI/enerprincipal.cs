using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFlight.GUI
{
    public partial class enerprincipal : Form
    {

        public enerprincipal()
        {
            InitializeComponent();
        }

        private void btn_fly_Click(object sender, EventArgs e)
        {
            GUI.everyflight c = new GUI.everyflight();
            c.Show();
        }

        private void btn_cust_Click(object sender, EventArgs e)
        {
            GUI.showcustomer c = new GUI.showcustomer();
            c.Show();
        }
    }
}
