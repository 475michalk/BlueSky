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

namespace MyFlight.GUI
{
    public partial class timeflight : Form
    {
        flighthours p = new flighthours();
        ActiveflightsDB tblactive;
        activityflight a;
        costDB tblcost;
        flighthoursDB tblhour;
        myflight af;
        bool FlagAdd = false;
        bool FlagUpData = false;

        public timeflight(myflight a)
        {
            //  a = new activityflight();
            tblhour = new flighthoursDB();
            tblcost = new costDB();
            af = new myflight();
            InitializeComponent();
            af = a;
            txt_from.Text = af.DestinationFrom;
            txt_to.Text = af.Destinationto;
        }
        private void NotPossible()
        {
            FlagAdd = false;
            FlagUpData = false;
        }
        private void ClearTxt()
        {
            cmb_day.Text = "";
            txt_timeon.Text = "";
            txt_timeoff.Text = "";
            txt_numberhour.Text = "";
            txt_from.Text = "";
            txt_to.Text = "";
            textBox1.Text = "";
           // nameCity.SelectedIndex = -1;

        }
        public bool CreateFields(flighthours p)
        {
            bool FlagOK = true;
            try
            {
                if (cmb_day.Text == "")
                    throw new Exception("שדה חובה");
                p.Dayofweek = (cmb_day.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmb_day, "שדה חובה");
                FlagOK = false;
            }


            try
            {
                if (txt_timeon.Text == "")
                    throw new Exception("שדה חובה");
                p.Timeofdeparture = (txt_timeon.Text).ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_timeon, "שדה חובה");
                FlagOK = false;
            }

            try
            {
                if (txt_timeoff.Text == "")
                    throw new Exception("שדה חובה");
                p.Landingtime = (txt_timeoff.Text).ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_timeoff, "שדה חובה");
                FlagOK = false;
            }

            try
            {
                if (txt_numberhour.Text == "")
                    throw new Exception("שדה חובה");
             
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_numberhour, "שדה חובה");
                FlagOK = false;
            }
            try
            {
                if (textBox1.Text == "")
                    throw new Exception("שדה חובה");
                p.Cost = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox1, "שדה חובה");
                FlagOK = false;
            }
            p.Kodflight = af.KodFlight;
            p.Numflight = tblhour.GetNextKey();
            p.Airportfrom = af.DestinationFrom;
            p.Airportto = af.Destinationto;
            
            return FlagOK;
        }

        private void btn_enternew_Click(object sender, EventArgs e)
        {
            FlagAdd = true;
            if (FlagAdd)
            {
               

                if (CreateFields(p))
                {
                    DialogResult r = MessageBox.Show("האם להוסיף טיסה זו?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        
                       tblhour.AddNew(p);
                        NotPossible();
                        ClearTxt();
                    }
                }
            }
            if (FlagUpData)
            {
                if (CreateFields(p))
                {
                    DialogResult r = MessageBox.Show("האם לעדכן יעד זה?", "אישור עידכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblhour.UpdateRow(p);
                        NotPossible();
                    }
                }
            }
            Close();

        }

        private void txt_from_TextChanged(object sender, EventArgs e)
        {

        }

        private void timeflight_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_timeoff_TextChanged(object sender, EventArgs e)
        {

        }
 
       
    }
}
