using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;
namespace MyFlight.GUI
{
    public partial class my_open : Form
    {
        public my_open()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void my_Load(object sender, EventArgs e)
        {
          

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            GUI.Home n = new GUI.Home();
            n.Show();
            timer1.Enabled = false;
            this.Hide();
        }

        private void my_open_Load(object sender, EventArgs e)
        {
             timer1.Enabled = true;
        }
    }


public class GifImage
    {
        private Image gifImage;
        private FrameDimension dimension;
        private int frameCount;
        private int currentFrame = -1;
        private bool reverse;
        private int step = 1;

        public GifImage(string path)
        {
            gifImage = Image.FromFile(path);
            //initialize
            dimension = new FrameDimension(gifImage.FrameDimensionsList[0]);
            //gets the GUID
            //total frames in the animation
            frameCount = gifImage.GetFrameCount(dimension);
        }

        public bool ReverseAtEnd
        {
            //whether the gif should play backwards when it reaches the end
            get { return reverse; }
            set { reverse = value; }
        }

        public Image GetNextFrame()
        {

            currentFrame += step;

            //if the animation reaches a boundary...
            if (currentFrame >= frameCount || currentFrame < 0)
            {
                if (reverse)
                {
                    step *= -1;
                    //...reverse the count
                    //apply it
                    currentFrame += step;
                }
                else
                {
                    currentFrame = 0;
                    //...or start over
                }
            }
            return GetFrame(currentFrame);
        }

        public Image GetFrame(int index)
        {
            gifImage.SelectActiveFrame(dimension, index);
            //find the frame
            return (Image)gifImage.Clone();
            //return a copy of it
        }
    }
}

