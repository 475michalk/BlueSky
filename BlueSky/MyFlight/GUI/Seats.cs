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
    public partial class Seats : Form
    {
        orderchargerDB tblorder;
        int moneButton = 0;
        passengerDB tblpassengers;
        paymentDB tblpayment;
        flighthoursDB tblpass = new flighthoursDB();
        flighthours tb = new flighthours();
        activityflight a;
        invetation inv;
        passengerDB l;
        invetation inv2;
        ordercharger od;
        invetationDB tblinvetion = new invetationDB();
        int i = 0;
        passenger pa;
        int q,c=1,co,f=0;
        bool flagNew = true;
        flighthoursDB tblactive = new flighthoursDB();
        double r;
        string h, ll ,name;
       public passenger[] arr1;
        List<passenger> lstpass;
        List<passenger> lstpass2;
        public Seats(string k, string p, passenger[] arr, int b, double gg, int code)
        {
            co = code;
            name = "checkBox";
            InitializeComponent();
            
            q = b;


            arr1 = arr;
            ordercharger tblorder = new ordercharger();
            tblpayment = new paymentDB();
            l = new passengerDB();
            inv = tblinvetion.Find(code);
            inv2 = tblinvetion.Find(code + 1);
            
            //label53.Text = tblpassengers.GetList().Where(x => x.Kodorder == co).Select(x => x.Firstname + " " + x.Lastname.ToString().ToList();
            tblpassengers = new passengerDB();
            
            var listSeatd= tblpassengers.GetList().Where(x =>x.Kodorder!=code && x.ThisInvetation().Kodactivityflight == inv.Kodactivityflight);
            foreach (var item in listSeatd)
            {
                name += item.PlaceF.ToString();
                ((CheckBox)groupBox3.Controls[name]).Checked = true;
                ((CheckBox)groupBox3.Controls[name]).Enabled = false;        
                ((CheckBox)groupBox3.Controls[name]).BackColor = Color.DarkOrange;

                name = "checkBox";
            }
            
            button1.Text = "המשך התשלום בסה'כ" + " " + gg;
            r = gg;
            h = k;
            ll = p;
            int width, height;
            width = this.Size.Width;
            height = this.Size.Height;
            
            width /= 15;
            height /= 15;
            Button b1=new Button();
            b1.Size = new Size(width, height);
            
             lstpass = tblpassengers.GetList().Where(x => x.Kodorder == inv.Kodorder).ToList();
           lstpass2 = tblpassengers.GetList().Where(x => x.Kodorder == inv.Kodorder+1).ToList();
            for (int j = 0; j < b; j++)
            {
                //חזור
                if (lstpass2.Count > 0)
                {
                    b1 = new Button();
                    b1.Text = "אשר מושב לנוסע" + " " + arr1[j].Firstname + " " + "לחזור";
                    b1.BackColor = Color.DarkOrange;
                    b1.Size = new Size(width, height);
                    panel1.Controls.Add(b1);
                    b1.Dock = DockStyle.Top;
                    b1.Click += B1_Click;

                    b1.Tag = lstpass2[j];
                    b1.Enabled = false;
                }
                //הלוך
                if (lstpass.Count > 0)
                {
                    b1 = new Button();
                    b1.Text = "אשר מושב לנוסע" + " " + arr1[j].Firstname + " " + "הלוך";
                    b1.BackColor = Color.DarkOrange;
                    b1.Size = new Size(width, height);
                    panel1.Controls.Add(b1);
                    b1.Dock = DockStyle.Top;
                    b1.Click += B1_Click;
                    b1.Tag = lstpass[j];
                    b1.Enabled = false;
                }
            }
           if(lstpass2.Count > 0)
            moneButton = q*2-1;
            else
            {
                moneButton = q - 1;
            }
            panel1.Controls[moneButton].Enabled = true;
            cb = new CheckBox();
            cb.Name = "aaaaaaaaaa";
            tblpass = new flighthoursDB();
            tb = new flighthours();
            UserControl1 us = new UserControl1();

            activityflight a = new activityflight();
            // button1.Text = k;
            groupBox3.Visible = true;
            button2.Text = " המשך לתשלום בסך:" + " " + gg;
            flagNew = false;
            od=new ordercharger();
            pa = new passenger();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            f++;
            flagNew = true;
            if (namePlace != "")
            {
                namePlace = cb.Name.Substring(8);
                ((passenger)(sender as Button).Tag).PlaceF = Convert.ToInt32(namePlace);
                tblpassengers.UpdateRow(((passenger)(sender as Button).Tag));
                namePlace = "";
                panel1.Controls[moneButton].Enabled = false;
                moneButton--;
                if(moneButton>=0)
                panel1.Controls[moneButton].Enabled = true;
                else
                groupBox3.Visible = true;
                if (moneButton % 2 == 0)
                {
                    var listSeatd = tblpassengers.GetList().Where(x => x.Kodorder != co && x.ThisInvetation().Kodactivityflight == inv.Kodactivityflight + 1);
                    foreach (var item in groupBox3.Controls)
                    {
                        if (item  is CheckBox)
                        {
                           ((CheckBox)item).Enabled = true;
                            ((CheckBox)item).Checked= false;
                        }
 
                        
                    }
                        
                  
                    foreach (var item in listSeatd)
                    {
                        if (item.PlaceF != 0)
                        {
                            name += item.PlaceF.ToString();
                            ((CheckBox)groupBox3.Controls[name]).Checked = true;
                            ((CheckBox)groupBox3.Controls[name]).Enabled = false; 
                            ((CheckBox)groupBox3.Controls[name]).BackColor = Color.DarkOrange;
                            name = "checkBox";
                           

                        }
                    }
                }
                else
                {
                    var listSeatd = tblpassengers.GetList().Where(x => x.Kodorder != co && x.ThisInvetation().Kodactivityflight == inv.Kodactivityflight );
                    foreach (var item in groupBox3.Controls)
                    {
                        if (item is CheckBox)
                        {
                            ((CheckBox)item).Enabled = true;
                            ((CheckBox)item).Checked = false;
                        }


                    }
                    foreach (var item in listSeatd)
                    {
                        if ((item.PlaceF != 0)||(moneButton==-1))
                        {
                            name += item.PlaceF.ToString();
                            ((CheckBox)groupBox3.Controls[name]).Checked = true;
                            ((CheckBox)groupBox3.Controls[name]).Enabled = false;
                            ((CheckBox)groupBox3.Controls[name]).BackColor = Color.DarkOrange;
                            name = "checkBox";
                            
                        }
                    }
                }

            }
            else
                MessageBox.Show("בחר מושב");
            flagNew = false;
        }

        string namePlace = "";
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            namePlace = cb.Name.Substring(8);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (moneButton % 2 == 0||moneButton<0)
            { 
                if (f == q*2)
               {
                panel2.Visible = true;

                label47.Text = " " + arr1[i].Firstname;
                }
            
               
            else
            {
                if (moneButton % 2 != 0)
                {
                    panel2.Visible = true;

                    label47.Text = " " + arr1[i].Firstname;
                }
                else
                {
                    MessageBox.Show("בחר מושב");
                }
            }
}
                
        }
        CheckBox cb;
        bool flagCheck = true;

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!flagNew)
            {
                if (!cb.Equals((sender as CheckBox)))
                {
                    cb.Checked = false;
                    cb = (sender as CheckBox);
                    namePlace = cb.Name.Substring(8);
                }
            }

        }

        private void changeChecked()
        {
            foreach (Control item in groupBox3.Controls)
            {
                if (item is CheckBox)
                {
                    if ((item as CheckBox).Enabled)
                        (item as CheckBox).Checked = false;
                }
            }
            flagCheck = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            if (radioButton1.Checked)
            {
                DialogResult we = MessageBox.Show("האם להוסיף גודל מטען זה להזמנתך?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                 if (we == DialogResult.Yes)
                {
                lstpass[i].Chargercode = 1;
                        pa = tblpassengers.Find(arr1[i].Id, arr1[i].Kodorder + 1);

                    if (pa != null)
                    {
                pa.Chargercode =1;
                    }

                }
            }
            if (radioButton2.Checked)
            {
                DialogResult we = MessageBox.Show("האם להוסיף גודל מטען זה להזמנתך?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (we == DialogResult.Yes)
                {
                    lstpass[i].Chargercode = 2;
                        pa = tblpassengers.Find(arr1[i].Id, arr1[i].Kodorder + 1);

                    if (pa != null)
                    {
                        pa.Chargercode = 2;
                    }
                }
            }
            if(radioButton3.Checked)
            {


                DialogResult we = MessageBox.Show("האם להוסיף גודל מטען זה להזמנתך?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (we == DialogResult.Yes)
                {
                    {
                        lstpass[i].Chargercode = 3;
                        pa = tblpassengers.Find(arr1[i].Id, arr1[i].Kodorder + 1);
                      
                        if (pa!= null)
                        {
                          pa.Chargercode = 3;
                        }
                    }
                }
            }
            else
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                {
                    MessageBox.Show("בחר גודל מטען");
                    return;
                }
            }
            tblpassengers.UpdateRow(lstpass[i]);
            if (pa != null)
            {
                tblpassengers.UpdateRow(pa);
            }
            i++;
            if (i<q)
                {
                    label47.Text = " " + arr1[i].Firstname;


                }
            else
            {
               panel3.Visible = true;
            }
           
            {

            }

     
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                r = r + 35;
            }
            else
            {
                r = r - 35;
            }
            button1.Text = "המשך התשלום בסה'כ" + " " + r;



        }



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                r = r + 22;
            }
            else
            {
                r = r - 22;
            }
            button1.Text = "המשך התשלום בסה'כ" + " " + r;

        }
        public bool CreateFields2(payment P)
        {
            bool FlagOK = true;


            try
            {
                if (textBox1.Text == "")
                    throw new Exception("שדה חובה");
                P.Mascard = (textBox1.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox1, ex.Message);
                FlagOK = false;
            }
            try
            {
                if (maskedTextBox1.Text == "  /")
                    throw new Exception("שדה חובה");
                P.Dataofcard =(maskedTextBox1.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(maskedTextBox1, ex.Message);
                FlagOK = false;
            }
            try
            {
                if (textBox8.Text == "")
                    throw new Exception("שדה חובה");
                P.Threemas = (textBox8.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox8, ex.Message);
                FlagOK = false;
            }
            try
            {
                if (textBox9.Text == "")
                    throw new Exception("שדה חובה");
                P.Tz = (textBox9.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox9, ex.Message);
                FlagOK = false;
            }
            P.Kodpayment = inv.Kodorder;
            P.Summany =Convert.ToInt32( r);
            return FlagOK;
        }
        public bool CreateFields(passenger a)
        {
            bool FlagOK = true;

            
            try
            {
                if (textBox3.Text == "")
                    throw new Exception("שדה חובה");
                a.Address = (textBox3.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox3, ex.Message);
                FlagOK = false;
            }
            try
            {
                if (textBox4.Text == "")
                    throw new Exception("שדה חובה");
                a.Numhome = Convert.ToInt32(textBox4.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox4, ex.Message);
                FlagOK = false;
            }
            try
            {
                if (textBox7.Text == "")
                    throw new Exception("שדה חובה");
                a.Postalcode = Convert.ToInt32(textBox7.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox7, ex.Message);
                FlagOK = false;
            }
            try
            {
                if (textBox5.Text == "")
                    throw new Exception("שדה חובה");
                a.Numphone = (textBox5.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox5, ex.Message);
                FlagOK = false;
            }
            try
            {
                if (textBox6.Text == "")
                    throw new Exception("שדה חובה");
                a.Gmail = (textBox6.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox6, ex.Message);
                FlagOK = false;
            }
            try
            {
                if (comboBox2.SelectedIndex <0)
                    throw new Exception("שדה חובה");
                a.Country = comboBox2.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(comboBox2, ex.Message);
                FlagOK = false;
            }
            try
            {
                if (comboBox1.Text =="")
                    throw new Exception("שדה חובה");
                a.City = comboBox1.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(comboBox1, ex.Message);
                FlagOK = false;
            }
            //a.Kodorder= inv.Kodorder;
           

            return FlagOK;
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void btn_nameseat_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bitmap, new Rectangle(new Point(0, 0), bitmap.Size));
            e.Graphics.DrawImage(bitmap, 50, 100);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {

        }
        public void  errorProvider1Clear()
        {
            string s = (textBox3.Text).ToString();
            errorProvider1.Clear();
            string s2 = (textBox4.Text).ToString();
            errorProvider1.Clear();
            string s5 = (textBox5.Text).ToString();
            errorProvider1.Clear();
            string s6 = (textBox6.Text).ToString();
            errorProvider1.Clear();
            string s7 = (textBox7.Text).ToString();
            errorProvider1.Clear();
        }
        public void errorProvider2Clear()//
        {
            string s = (textBox1.Text).ToString();
            errorProvider1.Clear();
            string s9 = (textBox9.Text).ToString();
            errorProvider1.Clear();
            string s5 = (maskedTextBox1.Text).ToString();
           
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string s = (textBox8.Text).ToString();
            errorProvider1.Clear();
            for (int i = 0; i < 3; i++)
            {
                if ((s.Length != 3) || (s[i] < '0' || s[i] > '9'))
                    errorProvider1.SetError(textBox8, "עליך להקיש 3 ספרות");
                else
                    errorProvider1.Clear();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tblpayment = new paymentDB();
            payment P = new payment();
            if (Convert.ToInt32(maskedTextBox1.Text.Substring(0, 2)) > 12 || Convert.ToInt32(maskedTextBox1.Text.Substring(0, 2)) < 0)
            {
                errorProvider1.SetError(maskedTextBox1, " החודש בתוקף לא תקין");
                return;
            }
            if (Convert.ToInt32(maskedTextBox1.Text.Substring(3, 4)) < 2022)
            {
                errorProvider1.SetError(maskedTextBox1, " השנה בתוקף לא תקין");
                return;
            }
           
            if (CreateFields2(P))
            {
                DialogResult r = MessageBox.Show("האם לשמור פרטים אלו?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    tblpayment.AddNew(P);
                    ClearTxt2();

                    if (lstpass2.Count >0)
                    {
                        pri p = new pri(arr1, co, q);
                        p.Show();
                        this.Close();
                    }
                    else
                    {
                        if (lstpass2.Count == 0)
                        {
                            prione p2 = new prione(arr1,co,q);
                              p2.Show();
                               this.Close();
                        }
                    }
                    




                }
            }
        }
        private void ClearTxt()
        {
            textBox7.Text = "";
            textBox6.Text = "";
             textBox5.Text= "";
            textBox4.Text = "";
            textBox3.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
        private void ClearTxt2()
        {
            textBox1.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            maskedTextBox1.Text = "";
        }

            private void button3_Click_1(object sender, EventArgs e)
            {
            bool flagOk = true;
            List<passenger> lstP = tblpassengers.GetList().Where(x => x.Kodorder == inv.Kodorder|| x.Kodorder == inv.Kodorder+1).ToList();
            errorProvider1Clear();

            //||x.Kodorder==inv.Kodorder+1
            foreach (passenger passenger in lstP)
            {
                if (!CreateFields(passenger))
                    flagOk = false;
            }
                if (flagOk)
                {
                    DialogResult r = MessageBox.Show("האם לשמור פרטים אלו?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        groupBox8.Visible = true;
                      foreach (passenger passenger in lstP)
                     {
                        l.UpdateRow(passenger);
                        //tblpassengers.UpdateRow(passenger);
                        ClearTxt();
                        errorProvider1Clear();
                     }
                    
                    }
                }
            }
        }
    }

