using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace lab3._1
{
    
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> sourceImage;
        private VideoCapture capture;
        Filter_c fl = new Filter_c();
        private int stage = 0;
        private bool web = false;
        private int n1, n2, n3, n4, n5, n6;
        private int vframe = 0;
        public Form1()
        {
            InitializeComponent();
            n1 = tr1.Value;
            n2 = tr2.Value;
            n3 = trackBar1.Value;
            n4 = trackBar2.Value;
            n5 = trackBar3.Value;
            n6 = trackBar4.Value;
        }

        private void loadbutton_Click_1(object sender, EventArgs e)
        {
            stage = 0;
            if (web == true)
            {
                web = false;
                vtimer.Enabled = false;
                capture.Stop();
            }
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;*.png";
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                sourceImage = new Image<Bgr, byte>(fileName).Resize(640, 480, Inter.Linear);
            }
            if (sourceImage != null)
            {
                IMG1.Image = sourceImage;
                IMG2.Image = sourceImage;
                ptimer.Enabled = true;
            }
        }

        private void vloadbutton_Click(object sender, EventArgs e)
        {
            stage = 0;
            ptimer.Enabled = false;
            if (web == true)
            {
                web = false;
                capture.Stop();
            }
            web = true;
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "(*.mp4)|*.mp4";
            var result = openFileDialog2.ShowDialog();
            vframe = 0;
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog2.FileName;
                capture = new VideoCapture(fileName);
                vtimer.Enabled = true;
            }
        }

        private void filterbutton_Click(object sender, EventArgs e)
        {
            stage = 1;
        }

        private void filter2_Click(object sender, EventArgs e)
        {
            stage = 2;
        }

        private void carfilter_Click(object sender, EventArgs e)
        {
            stage = 3;
        }

        private void tr1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(tr1.Value);
            n1 = tr1.Value;
        }

        private void tr2_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(tr2.Value);
            n2 = tr2.Value;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(trackBar1.Value);
            n3 = trackBar1.Value;
        }

        private void foff_Click(object sender, EventArgs e)
        {
            stage = 0;
            if(sourceImage != null)
            {
                IMG2.Image = sourceImage.Resize(640, 480, Inter.Linear);
            }
        }

        private void vtimer_Tick(object sender, EventArgs e)
        {
            var frame = capture.QueryFrame();
            Image<Bgr, byte> image = frame.ToImage<Bgr, byte>();
            IMG1.Image = image;
            switch(stage)
            {
                case 0:
                    IMG2.Image = image;
                    break;
                case 1:
                    IMG2.Image = fl.filtergray(image);
                    break;
                case 2:
                    IMG2.Image = fl.filterlinear(image, n1, n2);
                    break;
                case 3:
                    IMG2.Image = fl.filtercartoony(image, n1, n2, n3, n4, n5, n6);
                    break;
            }

            vframe++;

            if (vframe >= capture.GetCaptureProperty(CapProp.FrameCount))
            {
                vtimer.Enabled = false;
            }
        }

        private void ptimer_Tick(object sender, EventArgs e)
        {
            switch (stage)
            {
                case 0:
                    IMG2.Image = sourceImage.Resize(640, 480, Inter.Linear);
                    break;
                case 1:
                    IMG2.Image = fl.filtergray(sourceImage).Resize(640, 480, Inter.Linear);
                    break;
                case 2:
                    IMG2.Image = fl.filterlinear(sourceImage, n1, n2).Resize(640, 480, Inter.Linear);
                    break;
                case 3:
                    IMG2.Image = IMG2.Image = fl.filtercartoony(sourceImage, n1, n2, n3, n4, n5, n6).Resize(640, 480, Inter.Linear);
                    break;
            }
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(trackBar2.Value);
            n4 = trackBar2.Value;
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(trackBar3.Value);
            n5 = trackBar3.Value;
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = Convert.ToString(trackBar4.Value);
            n6 = trackBar4.Value;
        }

        private void wcbutton_Click(object sender, EventArgs e)
        {
            ptimer.Enabled = false;
            if(web == true)
            {
                capture.Stop();
            }    
            vtimer.Enabled = false;
            sourceImage = null;
            IMG1.Image = null;
            IMG2.Image = null;
            stage = 0;
            web = true;
            capture = new VideoCapture();
            capture.ImageGrabbed += ProcessFrame;
            capture.Start();
        }
        private void ProcessFrame(object sender, EventArgs e)
        {
            var frame = new Mat();
            capture.Retrieve(frame);
            Image<Bgr, byte> image = frame.ToImage<Bgr, byte>();
            IMG1.Image = image;
            switch (stage)
            {
                case 0:
                    IMG2.Image = image;
                    break;
                case 1:
                    IMG2.Image = fl.filtergray(image);
                    break;
                case 2:
                    IMG2.Image = fl.filterlinear(image, n1, n2);
                    break;
                case 3:
                    IMG2.Image = fl.filtercartoony(image, n1, n2, n3, n4, n5, n6);
                    break;
            }
        }
    }
}
