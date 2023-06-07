using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace BTE_202___2023_Grup_C_Uygulaması
{
    public partial class FormHucre : Form
    {
        private System.Windows.Forms.Timer zoomInTimer;
        private System.Windows.Forms.Timer zoomOutTimer;
        private int zoomLevel = 1;
        private int zoomstate = 0;
        private int selection = 0;
        private const int ZoomIncrement = 35;
        private const int MaxZoomLevel = 14;
        public FormHucre()
        {
            InitializeComponent();
            zoomInTimer = new System.Windows.Forms.Timer();
            zoomInTimer.Interval = 50; // Change the interval to control zoom speed
            zoomInTimer.Tick += ZoomInTimer_Tick;
            zoomOutTimer = new System.Windows.Forms.Timer();
            zoomOutTimer.Interval = 50; // Change the interval to control zoom speed
            zoomOutTimer.Tick += ZoomOutTimer_Tick;
        }

        private void ZoomInTimer_Tick(object sender, EventArgs e)
        {
            if (zoomLevel < MaxZoomLevel && zoomLevel >= 1)
            {
                ZoomPictureBox(1);
                zoomstate = 1;
            }
            else
            {
                zoomInTimer.Stop();
                zoomLevel = 1;
            }
        }

        private void ZoomOutTimer_Tick(object sender, EventArgs e)
        {
            if (zoomLevel > 1 && zoomLevel <= MaxZoomLevel)
            {
                ZoomPictureBox(2);
                zoomstate = 0;
            }
            else
            {
                zoomOutTimer.Stop();
                zoomLevel = MaxZoomLevel;
            }
        }

        private void ZoomPictureBox(int zoomInOutType)
        {
            if (zoomLevel < 1)
            {

            }
            else

            if (zoomInOutType == 1)
            {

                pictureBox2.Width += ZoomIncrement;
                pictureBox2.Height += ZoomIncrement;
                zoomLevel++;
                pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X - ZoomIncrement, pictureBox2.Location.Y - ZoomIncrement);

            }
            else if (zoomInOutType == 2)
            {
                pictureBox2.Width -= ZoomIncrement;
                pictureBox2.Height -= ZoomIncrement;
                zoomLevel--;
                pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X + ZoomIncrement, pictureBox2.Location.Y + ZoomIncrement);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            string konuDosyasi = File.ReadAllText("./Assets/konular.json");
            List<Konular> konular = JsonConvert.DeserializeObject<List<Konular>>(konuDosyasi);
            if (radioButton1.Checked)
            {
                textSoru.Text = konular[0].cisim.ToString();
                textCevap.Text = konular[0].tanim.ToString();
            }
            if (radioButton2.Checked)
            {
                textSoru.Text = konular[1].cisim.ToString();
                textCevap.Text = konular[1].tanim.ToString();
            }
            if (radioButton3.Checked)
            {
                textSoru.Text = konular[2].cisim.ToString();
                textCevap.Text = konular[2].tanim.ToString();
            }
            if (radioButton4.Checked)
            {
                textSoru.Text = konular[3].cisim.ToString();
                textCevap.Text = konular[3].tanim.ToString();
            }
            if (radioButton5.Checked)
            {
                textSoru.Text = konular[4].cisim.ToString();
                textCevap.Text = konular[4].tanim.ToString();
            }
            if (radioButton6.Checked)
            {
                textSoru.Text = konular[5].cisim.ToString();
                textCevap.Text = konular[5].tanim.ToString();
            }
            if (radioButton7.Checked)
            {
                textSoru.Text = konular[6].cisim.ToString();
                textCevap.Text = konular[6].tanim.ToString();
            }
            if (radioButton8.Checked)
            {
                textSoru.Text = konular[7].cisim.ToString();
                textCevap.Text = konular[7].tanim.ToString();
            }
            if (radioButton9.Checked)
            {
                textSoru.Text = konular[8].cisim.ToString();
                textCevap.Text = konular[8].tanim.ToString();
            }
            if (radioButton10.Checked)
            {
                textSoru.Text = konular[9].cisim.ToString();
                textCevap.Text = konular[9].tanim.ToString();
            }
            if (radioButton11.Checked)
            {
                textSoru.Text = konular[10].cisim.ToString();
                textCevap.Text = konular[10].tanim.ToString();
            }
            if (radioButton12.Checked)
            {
                textSoru.Text = konular[11].cisim.ToString();
                textCevap.Text = konular[11].tanim.ToString();
            }
            if (radioButton13.Checked)
            {
                textSoru.Text = konular[12].cisim.ToString();
                textCevap.Text = konular[12].tanim.ToString();
            }
        }



        class Konular
        {
            public int itemID { get; set; }
            public string cisim { get; set; }
            public string tanim { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selection = 2;
            if (zoomstate == 0)
            {
                zoomInTimer.Start();
                //zoomstate = 1;
            }
            //if (zoomLevel == MaxZoomLevel)
            //{
            //    zoomInTimer.Stop();
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (zoomstate == 1)
            {
                zoomOutTimer.Start();
            }
        }
    }
}
