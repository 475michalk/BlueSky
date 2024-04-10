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
    public partial class showcustomer : Form
    {
        passenger p;
        passengerDB tblpassengers;
        invetation i,var;
        invetationDB tblinvation;
        int a;
        invetation y;
        payment card;
        paymentDB tblpayment;
        
        public showcustomer()
        {
            InitializeComponent();
            tblpassengers = new passengerDB();
            tblinvation = new invetationDB();
            tblpayment = new paymentDB();
            i = new invetation();
            panel1.Visible = false;
            dataGridView1.DataSource = tblinvation.GetList().Select(x => new { קוד_הזמנה = x.Kodorder, קוד_הזמנה_פעילה = x.Kodactivityflight, תאריך = x.DateToday, סכום_ההזמנה = x.Sumorder, }).ToList();
            dataGridView2.DataSource = tblpayment.GetList().Select(x => new { קוד_תשלום=x.Kodpayment, סכום=x.Summany, מספר_כרטיס=x.Mascard, תוקף=x.Dataofcard, שלוש_ספרות_בגב_הכרטיס=x.Threemas, תעודת_זהות=x.Tz }).ToList();

            var list = tblinvation.GetList().Select(x => new { x.Kodorder }).ToList();

            var list2 = tblpayment.GetList().Select(x => new { x.Kodpayment }).ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {



           invetation i = tblinvation.Find(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
             payment pp = tblpayment.Find(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            //dataGridView2.DataSource = tblpassengers.GetList().Where(x => x.Kodorder == (i.Kodorder)).Where(x => x.Kodorder == i.Kodorder).Select(x => new { x.Kodorder, x.Id, x.Firstname, x.Lastname, x.Dataofbirth, x.Numpassport, x.Numphone, x.Gmail, x.Country, x.City, x.Address, x.Numhome, x.Postalcode, x.PlaceF, x.Chargercode }).ToList();
            //      dataGridView1.DataSource = tblpayment.GetList().Where(x => x.Kodpayment == (i.Kodorder)).Where(x => x.Kodpayment == i.Kodorder).Select(x => new { x.Kodpayment, x.Mascard, x.Threemas, x.Dataofcard, x.Tz, x.Summany, }).ToList();
            dataGridView1.DataSource = tblpassengers.GetList().Where(x => x.Kodorder == (i.Kodorder)).Where(x => x.Kodorder == i.Kodorder).Select(x => new { x.Kodorder, x.Id, x.Firstname, x.Lastname, x.Dataofbirth, x.Numpassport, x.Numphone, x.Gmail, x.Country, x.City, x.Address, x.Numhome, x.Postalcode, x.PlaceF, x.Chargercode }).ToList();
            label1.Visible = false;
            label2.Visible = false;
            button2.Visible = false;
            textBox1.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            dataGridView1.DataSource = tblinvation.GetList().Select(x => new { קוד_הזמנה = x.Kodorder, קוד_הזמנה_פעילה = x.Kodactivityflight, תאריך = x.DateToday, סכום_ההזמנה = x.Sumorder, }).ToList();
            label2.Visible = true;
            button2.Visible = true;
            textBox1.Visible = true;

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            invetation p = tblinvation.Find(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));

            dataGridView1.DataSource = tblpassengers.GetList().Where(x => x.Kodorder == (i.Kodorder)).Where(x => x.Kodorder == i.Kodorder).Select(x => new { x.Kodorder, x.Id, x.Firstname, x.Lastname, x.Dataofbirth, x.Numpassport, x.Numphone, x.Gmail, x.Country, x.City, x.Address, x.Numhome, x.Postalcode, x.PlaceF, x.Chargercode }).ToList();
        }

        private void close_Click(object sender, EventArgs e)
        {

        }
        public bool CreateFields(passenger p)
        {
            bool FlagOK = true;
            try
            {
                if (textBox1.Text == "")
                    throw new Exception("שדה חובה");
                p.Id =(textBox1.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox1, ex.Message);
                FlagOK = false;
            }
            return FlagOK;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            passenger p = new passenger();
            if (CreateFields(p))
            {
                dataGridView1.DataSource = tblpassengers.GetList().Where(x => (textBox1.Text) == x.myid()).ToList();
                textBox1.Clear();
                label1.Visible = false;
                label2.Visible = false;
                button2.Visible = false;
                textBox1.Visible = false;
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            invetation i = tblinvation.Find(Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));
            payment pp = tblpayment.Find(Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));
            dataGridView2.DataSource = tblpassengers.GetList().Where(x => x.Kodorder == (i.Kodorder)).Where(x => x.Kodorder == i.Kodorder).Select(x => new { x.Kodorder, x.Id, x.Firstname, x.Lastname, x.Dataofbirth, x.Numpassport, x.Numphone, x.Gmail, x.Country, x.City, x.Address, x.Numhome, x.Postalcode, x.PlaceF, x.Chargercode }).ToList();
            //dataGridView1.DataSource = tblpayment.GetList().Where(x => x.Kodpayment == (i.Kodorder)).Where(x => x.Kodpayment == i.Kodorder).Select(x => new { x.Kodpayment, x.Mascard, x.Threemas, x.Dataofcard, x.Tz, x.Summany, }).ToList();
            label1.Visible = false;
            label2.Visible = false;
            button2.Visible = false;
            textBox1.Visible = false;

        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            invetation p = tblinvation.Find(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));

            dataGridView2.DataSource = tblpayment.GetList().Where(x => x.Kodpayment == (i.Kodorder)).Select(x => new { x.Kodpayment, x.Summany, x.Mascard, x.Dataofcard, x.Threemas, x.Tz }).ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // payment yp = tblpayment.Find(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            panel1.Visible = true;
            // invetation p = tblinvation.Find(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            //if (dataGridView1.SelectedRows.Count>0)
            
                i = tblinvation.Find(Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value));
            
            dataGridView2.DataSource = tblpayment.GetList().Where(x => (i.Kodorder) == x.Kodpayment).Select(x => new { קוד_תשלום = x.Kodpayment, סכום = x.Summany, מספר_כרטיס = x.Mascard, תוקף = x.Dataofcard, שלוש_ספרות_בגב_הכרטיס = x.Threemas, תעודת_זהות = x.Tz }).ToList();

        }
    }
}
