using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFlight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GUI.Home n = new GUI.Home();
            n.Show();
            timeropen.Enabled = false;
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeropen.Enabled = true;
            
        }

    }
}
