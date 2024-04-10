﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFlight.BLL;

namespace MyFlight.GUI
{
    public partial class pri : Form
    {
        public passenger[] arr1;
        public  flighthours f1;
        public  flighthours f2;
        public BLL.Activeflights a1;
        public BLL.Activeflights a2;
        printing p;
        int q;

        public pri(passenger [] arr,int co,int q)
        {
            InitializeComponent();
            arr1 = arr;
            printDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDocument1.PrinterSettings.PrintFileName = "קופון הדפסה";
            printDocument1.DocumentName = "קופון הדפסה";
            invetationDB tblinv = new invetationDB();
            invetation inv1 = tblinv.Find(co);
            invetation inv2 = tblinv.Find(co+1);
            flighthoursDB tblf = new flighthoursDB();
            BLL.ActiveflightsDB tblaf = new ActiveflightsDB();
            a1 = tblaf.Find(inv1.Kodactivityflight);

            a2 = tblaf.Find(inv2.Kodactivityflight);
             f1 = tblf.Find(tblaf.Find(inv1.Kodactivityflight).kodFlight1, tblaf.Find(inv1.Kodactivityflight).flightNum1);
             f2 = tblf.Find(tblaf.Find(inv2.Kodactivityflight).kodFlight1, tblaf.Find(inv2.Kodactivityflight).flightNum1);
             p = new printing();
            this.q = q;
            panel4.Controls.Add(p);
            for (int i = 1; i <= q; i++)
            {
               comboBox1.Items.Add(i);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel4.Visible = true;
            p.pppppp();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(panel4.Width, panel4.Height);
            panel4.DrawToBitmap(bitmap, new Rectangle(new Point(0, 0), bitmap.Size));
            e.Graphics.DrawImage(bitmap, 50, 100);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p.jjj();
            printDocument1.Print();
            printDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDocument1.PrinterSettings.PrintFileName = "קופון הדפסה";
            printDocument1.DocumentName = "קופון הדפסה";
            p.jjj1();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel4.Visible = true;
            p.pppppp();
        }
    }
}
