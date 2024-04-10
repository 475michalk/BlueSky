using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFlight.BLL;

namespace MyFlight.GUI
{
    public partial class printing : UserControl
    {
        passengerDB tblp;
        UserControl1 uc;
        passenger p;
        public printing()
        {
            InitializeComponent();

            pictureBox1.SendToBack();
            pictureBox19.SendToBack();

        }
        public void pppppp()
        {
            passengerDB tblp = new passengerDB();
            passenger p = new passenger();
            p = tblp.Find((this.ParentForm as pri).arr1[Convert.ToInt32((this.ParentForm as pri).comboBox1.SelectedItem) -1].Id, (this.ParentForm as pri).arr1[Convert.ToInt32((this.ParentForm as pri).comboBox1.SelectedItem) -1].Kodorder + 1);
            //שם הלוך
            label53.Text = (this.ParentForm as pri).arr1[Convert.ToInt32((this.ParentForm as pri).comboBox1.SelectedItem) -1].Firstname + " " + (this.ParentForm as pri).arr1[Convert.ToInt32((this.ParentForm as pri).comboBox1.SelectedItem) -1].Lastname;
            label54.Text = (this.ParentForm as pri).arr1[Convert.ToInt32((this.ParentForm as pri).comboBox1.SelectedItem) -1].Firstname + " " + (this.ParentForm as pri).arr1[Convert.ToInt32((this.ParentForm as pri).comboBox1.SelectedItem) -1].Lastname;
            //שם חזור
            label8.Text = (this.ParentForm as pri).arr1[Convert.ToInt32((this.ParentForm as pri).comboBox1.SelectedItem) -1].Firstname + " " + (this.ParentForm as pri).arr1[Convert.ToInt32((this.ParentForm as pri).comboBox1.SelectedItem) -1].Lastname;
            label9.Text = (this.ParentForm as pri).arr1[Convert.ToInt32((this.ParentForm as pri).comboBox1.SelectedItem) -1].Firstname + " " + (this.ParentForm as pri).arr1[Convert.ToInt32((this.ParentForm as pri).comboBox1.SelectedItem) -1].Lastname;
            //מושב הלוך
            label57.Text = p.PlaceF.ToString();
            label59.Text = p.PlaceF.ToString(); 
            //מושב חזור  
            label5.Text = p.PlaceF.ToString();
            label3.Text = p.PlaceF.ToString();
            //מאיפה לאן הלוך
            label51.Text = (this.ParentForm as pri).f1.Airportfrom;
            label52.Text = (this.ParentForm as pri).f1.Airportto;
            //מאיפה לאן חזור
            label10.Text = (this.ParentForm as pri).f1.Airportfrom;
            label11.Text = (this.ParentForm as pri).f1.Airportto;
            //מס טיסה הלוך
            label58.Text = (this.ParentForm as pri).f1.Numflight.ToString();
            label56.Text = (this.ParentForm as pri).f1.Numflight.ToString();
            //מס טיסה חזור
            label4.Text = (this.ParentForm as pri).f2.Numflight.ToString();
            label6.Text = (this.ParentForm as pri).f2.Numflight.ToString();
            //תאריך ושעה הלוך
            label60.Text = (this.ParentForm as pri).f1.Timeofdeparture.ToString();
            label55.Text = (this.ParentForm as pri).a1.dateToday1.Date.ToString();
            label61.Text = (this.ParentForm as pri).a1.dateToday1.Date.ToString();
            //תאריך ושעה חזור
            label1.Text = (this.ParentForm as pri).f2.Timeofdeparture.ToString();
            label2.Text = (this.ParentForm as pri).a2.dateToday1.Date.Date.ToString();
            label7.Text = (this.ParentForm as pri).a2.dateToday1.Date.Date.ToString();
        }
        public void jjj()
        {
            pictureBox1.BringToFront();
            pictureBox19.BringToFront();
        }
        public void jjj1()
        {
            pictureBox1.SendToBack();
            pictureBox19.SendToBack();
        }
    }
}
