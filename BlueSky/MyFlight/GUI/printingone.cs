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
    public partial class printingone : UserControl
    {
        passengerDB tblp;
        UserControl1 uc;
        passenger p;
        public printingone()
        {
            InitializeComponent();

            pictureBox19.SendToBack();
        }
            public void pppppp()
            {
                passengerDB tblp = new passengerDB();
                passenger p = new passenger();
                p = tblp.Find((this.ParentForm as prione).arr1[Convert.ToInt32((this.ParentForm as prione).comboBox1.SelectedItem) - 1].Id, (this.ParentForm as prione).arr1[Convert.ToInt32((this.ParentForm as prione).comboBox1.SelectedItem) - 1].Kodorder);
                //שם הלוך
                label53.Text = (this.ParentForm as prione).arr1[Convert.ToInt32((this.ParentForm as prione).comboBox1.SelectedItem) - 1].Firstname + " " + (this.ParentForm as prione).arr1[Convert.ToInt32((this.ParentForm as prione).comboBox1.SelectedItem) - 1].Lastname;
                label54.Text = (this.ParentForm as prione).arr1[Convert.ToInt32((this.ParentForm as prione).comboBox1.SelectedItem) - 1].Firstname + " " + (this.ParentForm as prione).arr1[Convert.ToInt32((this.ParentForm as prione).comboBox1.SelectedItem) - 1].Lastname;
                    //מושב הלוך
               label57.Text = p.PlaceF.ToString();
                 label59.Text = p.PlaceF.ToString(); 
            
                //מאיפה לאן הלוך
                label51.Text = (this.ParentForm as prione).f1.Airportfrom;
                label52.Text = (this.ParentForm as prione).f1.Airportto;
                  //מס טיסה הלוך
                label58.Text = (this.ParentForm as prione).f1.Numflight.ToString();
                label56.Text = (this.ParentForm as prione).f1.Numflight.ToString();
                //תאריך ושעה הלוך
                label60.Text = (this.ParentForm as prione).f1.Timeofdeparture.ToString();
                label55.Text = (this.ParentForm as prione).a1.dateToday1.Date.ToString();
                label61.Text = (this.ParentForm as prione).a1.dateToday1.Date.ToString();
            }
        
            public void jjj()
            {

                pictureBox19.BringToFront();
            }
            public void jjj1()
            {

                pictureBox19.SendToBack();
            }
        }
    }
