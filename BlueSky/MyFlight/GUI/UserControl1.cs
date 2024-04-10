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
    public partial class UserControl1 : UserControl
    {
        passenger a;
        passengerDB tblpassengers;
        bool FlagAdd = true;
        bool FlagUpData = false;
        string k, pp;
        passenger[] arr = new passenger[10];
        int i = 0;
        public UserControl1()
        {
            InitializeComponent();
            a = new passenger();
            tblpassengers = new passengerDB();
            pp = a.Lastname;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }
        public bool CreateFields(passenger a)
        {
            bool FlagOK = true;
            try
            {
                if (txt_first.Text == "")
                    throw new Exception("שדה חובה");
                a.Firstname = (txt_first.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_first, ex.Message);
                FlagOK = false;
            }
            try
            {
                if (textBox2.Text == "")
                    throw new Exception("שדה חובה");
                a.Lastname = (textBox2.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox2, ex.Message);
                FlagOK = false;
            }
            try
            {
                if (maskedTextBox1.Text == "")
                    throw new Exception("שדה חובה");
                a.Dataofbirth = (maskedTextBox1.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(maskedTextBox1, ex.Message);
                FlagOK = false;
            }
            try
            {
                if (textBox4.Text == "")
                    throw new Exception("שדה חובה");
                a.Id = (textBox4.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox4, ex.Message);
                FlagOK = false;
            }
            try
            {
                if (textBox5.Text == "")
                    throw new Exception("שדה חובה");
                a.Numpassport = Convert.ToInt32(textBox5.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox5, ex.Message);
                FlagOK = false;
            }

            if (radioButton1.Checked == false && radioButton2.Checked == false)
                errorProvider1.SetError(panel1, "שדה חובה");
            a.Kodorder = (this.ParentForm as activityflight).a11.Kodorder;
            return FlagOK;
        }
        public bool CreateFields2(passenger a)
        {
            bool FlagOK = true;
            try
            {
                if (txt_first.Text == "")
                    throw new Exception("שדה חובה");
                a.Firstname = (txt_first.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_first, ex.Message);
                FlagOK = false;
            }
            try
            {
                if (textBox2.Text == "")
                    throw new Exception("שדה חובה");
                a.Lastname = (textBox2.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox2, ex.Message);
                FlagOK = false;
            }
            try
            {
                if (maskedTextBox1.Text == "")
                    throw new Exception("שדה חובה");
                a.Dataofbirth = (maskedTextBox1.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(maskedTextBox1, ex.Message);
                FlagOK = false;
            }
            try
            {
                if (textBox4.Text == "")
                    throw new Exception("שדה חובה");
                a.Id = (textBox4.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox4, ex.Message);
                FlagOK = false;
            }
            try
            {
                if (textBox5.Text == "")
                    throw new Exception("שדה חובה");
                a.Numpassport = Convert.ToInt32(textBox5.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox5, ex.Message);
                FlagOK = false;
            }

            if (radioButton1.Checked == false && radioButton2.Checked == false)
                errorProvider1.SetError(panel1, "שדה חובה");
            a.Kodorder = (this.ParentForm as activityflight).b1.Kodorder;
            return FlagOK;
        }

        private void ClearTxt()
        {
            txt_first.Text = "";
            textBox2.Text = "";
            maskedTextBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        int count = 0;

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string s = (textBox5.Text).ToString();
            errorProvider1.Clear();
            for (int i = 0; i < 8; i++)
            {
                if ((s.Length != 8) || (s[i] < '0' || s[i] > '8'))
                    errorProvider1.SetError(textBox5, "עליך להקיש 8 ספרות");
                else
                    errorProvider1.Clear();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        //    if (Convert.ToInt32(maskedTextBox1.Text.Substring(0, 2)) <= 31 || Convert.ToInt32(maskedTextBox1.Text.Substring(0, 2)) < 1)
        //    {
        //        errorProvider1.SetError(maskedTextBox1, " היום בתאריך לא תקין");
        //        return;
        //    }
        //    if (Convert.ToInt32(maskedTextBox1.Text.Substring(2, 4)) > 12 || Convert.ToInt32(maskedTextBox1.Text.Substring(2, 4)) < 0)
        //    {
        //        errorProvider1.SetError(maskedTextBox1, " החודש בתאריך לא תקין");
        //        return;
        //    }
        //    if (Convert.ToInt32(maskedTextBox1.Text.Substring(4, 8)) > 2022)
        //    {
        //        errorProvider1.SetError(maskedTextBox1, " השנה בתאריך לא תקין");
        //        return;
        //    }
        //    if (Convert.ToInt32(maskedTextBox1.Text.Substring(3, 4)) > 2022)
        //    {
        //        errorProvider1.SetError(maskedTextBox1, " השנה בתוקף לא תקין");
        //        return;
        //    }
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Convert.ToInt32(maskedTextBox1.Text.Substring(0, 2)) >= 31 || Convert.ToInt32(maskedTextBox1.Text.Substring(0, 2)) <= 1)
            {
                errorProvider1.SetError(maskedTextBox1, " היום בתאריך לא תקין");
                return;
            }

            string H = maskedTextBox1.Text.Substring(3, 2);
            if (Convert.ToInt32(maskedTextBox1.Text.Substring(3,2)) >= 13 || Convert.ToInt32(maskedTextBox1.Text.Substring(3,2)) <= 0)

            {
                errorProvider1.SetError(maskedTextBox1, " החודש בתאריך לא תקין");
                return;
            }
            string Y = maskedTextBox1.Text.Substring(6, 4);
            if (Convert.ToInt32(maskedTextBox1.Text.Substring(6, 4)) >= DateTime.Now.Year)
            {
                errorProvider1.SetError(maskedTextBox1, " השנה בתאריך לא תקין");
                return;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //count++;
            //Validation.localinvetation.Kodorder = 0;
            //Validation.localinvetation.DateToday =DateTime.Now;
            errorProvider1.Clear();
            
           string s = (textBox5.Text).ToString();
                errorProvider1.Clear();
               k = txt_first.Text;
            passenger a = new passenger();
            
            if (FlagAdd)
            {
                if ((this.ParentForm as activityflight).dataGridView2.Visible == true)
                {
                    if (CreateFields2(a))
                    {
                    
                       
                        DialogResult r = MessageBox.Show("האם לשמור נוסע זה?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                            arr[i] = a;
                            i++; 
                            tblpassengers.AddNew(a);
                            (this.ParentForm as activityflight).arr[(this.ParentForm as activityflight).c] = a;
                           
                            //ClearTxt();

                        }
                       
                        else
                        {
                            (this.ParentForm as activityflight).c++;
                            (this.ParentForm as activityflight).label6.Text = "נוסע" + (this.ParentForm as activityflight).c + "/" + (this.ParentForm as activityflight).b;

                        }
                    }
                    if (CreateFields(a))
                    {
                          tblpassengers.AddNew(a);
                        (this.ParentForm as activityflight).arr[(this.ParentForm as activityflight).c] = a;
                        
                        ClearTxt();


                        if ((this.ParentForm as activityflight).c == (this.ParentForm as activityflight).b)
                        {

                            GUI.Seats c = new GUI.Seats(k, pp, arr, (this.ParentForm as activityflight).b, (this.ParentForm as activityflight).gg, (this.ParentForm as activityflight).a11.Kodorder);
                            c.Show();
                            (this.ParentForm as activityflight).Close();


                        }
                        else
                        {
                            (this.ParentForm as activityflight).c++;
                            (this.ParentForm as activityflight).label6.Text = "נוסע" + (this.ParentForm as activityflight).c + "/" + (this.ParentForm as activityflight).b;

                        }
                    }

                }
                else
                {
                    if (CreateFields(a))
                    {
                        passenger[] arr = new passenger[10];
                        for (int i = 0; i < 10; i++)
                        {
                            arr[i] = a;
                        }
                        DialogResult r = MessageBox.Show("האם לשמור נוסע זה?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                             tblpassengers.AddNew(a);
                            (this.ParentForm as activityflight).arr[(this.ParentForm as activityflight).c] = a;
                           
                            ClearTxt();

                        }
                        if ((this.ParentForm as activityflight).c == (this.ParentForm as activityflight).b)
                        {

                            GUI.Seats c = new GUI.Seats(k, pp, arr, (this.ParentForm as activityflight).b, (this.ParentForm as activityflight).gg, a.Kodorder);
                            c.Show();
                            (this.ParentForm as activityflight).Close();
                            //Seats frm2 = new Seats();
                            //  frm2.label38.Text= "מושב לנוסע"+ "" + this. txt_first.Text;

                            // Seats label38.Text = "מושב לנוסע" + "" + txt_first.Text;
                            // (this.ParentForm as Seats).label38.Text="מושב ל"+(txt_first.Text);
                            //(this.ParentForm as activityflight).btn_nameseat.Text = "מושב ל"+ this.txt_first.Text;
                            //(this.ParentForm as activityflight).label38.Text = txt_first.Text;
                        }
                        else
                        {
                            (this.ParentForm as activityflight).c++;
                            (this.ParentForm as activityflight).label6.Text = "נוסע" + (this.ParentForm as activityflight).c + "/" + (this.ParentForm as activityflight).b;

                        }
                    }
                }
           
            }
            
            
        }
        
       
    }
}
