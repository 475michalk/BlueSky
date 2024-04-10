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
    public partial class newflight : Form
    {
        myflight a;
        myflightDB tblmyflight;
        bool FlagAdd = true;
        bool FlagUpData = false;
       
        public newflight()
        {
            InitializeComponent();
            tblmyflight = new myflightDB();
            dataGridView1.DataSource = tblmyflight.GetList().Select(x => new { קוד_טיסות_פעילות = x.KodFlight, משדה_תעופה = x.DestinationFrom, לשדה_תעופה = x.Destinationto, }).ToList();
        }

        private void NotPossible()
        {
            FlagAdd = false;
        }
        private void Possible()
        {
            FlagAdd = true;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            myflight a = new myflight();
            if (FlagAdd)
            {

                if (CreateFields(a))
                {
                    DialogResult r = MessageBox.Show("האם להוסיף לקוח זה?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblmyflight.AddNew(a);
                        NotPossible();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = tblmyflight.GetList().Select(x => new { קוד_טיסות_פעילות = x.KodFlight, משדה_תעופה = x.DestinationFrom, לשדה_תעופה = x.Destinationto, }).ToList();
                        ClearTxt();
                    }
                }
            }

        }

        private bool CreateFields(myflight c)
        {
            bool FlagOK = true;
            c.KodFlight = tblmyflight.GetNextKey();
            try
            {
                if (cmb_from.Text == "")
                    throw new Exception("שדה חובה");
                c.DestinationFrom = cmb_from.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmb_from, "שדה חובה");
                FlagOK = false;
            }
            try
            {
                if (cmb_to.Text == "")
                    throw new Exception("שדה חובה");
                c.Destinationto = cmb_to.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmb_to, "שדה חובה");
                FlagOK = false;
            }
            return FlagOK;
        }

        private void ClearTxt()
        {
            cmb_from = null;
            cmb_to = null;
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int KodFlight = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                a = tblmyflight.Find(KodFlight);
                DialogResult r = MessageBox.Show("אתה בטוח שברצונך למחוק לקוח זה ?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {

                    ClearTxt();

                    String st = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    tblmyflight.DeleteRow(KodFlight);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = tblmyflight.GetList().Select(x => new { קוד_טיסות_פעילות = x.KodFlight, משדה_תעופה = x.DestinationFrom, לשדה_תעופה = x.Destinationto, }).ToList();
                    ClearTxt();
                   
                }

            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int KodFlight = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            a = tblmyflight.Find(KodFlight);
            GUI.timeflight c = new GUI.timeflight(a);
            c.Show();
        }

        private void newflight_Load(object sender, EventArgs e)
        {

        }

        private void cmb_from_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

