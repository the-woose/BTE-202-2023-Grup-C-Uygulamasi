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
            int rastgeleSayi = rastgele.Next(0, 12);
            //string konuDosyasi = File.ReadAllText("../../../Assets/konular.json");
            string konuDosyasi = File.ReadAllText("./Assets/konular.json");
            List<Konular> konular = JsonConvert.DeserializeObject<List<Konular>>(konuDosyasi);
            textSoru.Text = konular[rastgeleSayi].cisim.ToString();
            textCevap.Text = konular[rastgeleSayi].tanim.ToString();
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
