using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BTE_202___2023_Grup_C_Uygulaması
{
    public partial class FormEslestir : Form
    {
        MainWindow mainInstance;
        string konuDosyasi = File.ReadAllText("./Assets/konular.json");
        string draggedTag = string.Empty;
        string droppedTag = string.Empty;
        private int xPos;
        private int yPos;
        public FormEslestir()
        {
            InitializeComponent();
            List<Konular> konular = JsonConvert.DeserializeObject<List<Konular>>(konuDosyasi);
            label1.Text = konular[0].tanim.ToString();
            label2.Text = konular[1].tanim.ToString();
            label3.Text = konular[2].tanim.ToString();
            label4.Text = konular[3].tanim.ToString();
            label5.Text = konular[4].tanim.ToString();
            label6.Text = konular[5].tanim.ToString();
            label7.Text = konular[6].tanim.ToString();
            label8.Text = konular[7].tanim.ToString();
            label9.Text = konular[8].tanim.ToString();
            label10.Text = konular[9].tanim.ToString();
            label11.Text = konular[10].tanim.ToString();
            label12.Text = konular[11].tanim.ToString();
            label13.Text = konular[12].tanim.ToString();
            //label16.Text = konular[15].cisim.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        class Konular
        {
            public int itemID { get; set; }
            public string cisim { get; set; }
            public string tanim { get; set; }
        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox p = sender as PictureBox;
            Bitmap bmp = new Bitmap(52, 52);
            draggedTag = p.Tag.ToString();
            p.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
            if (e.Button == MouseButtons.Left)
            {
                p.DoDragDrop(p.BackgroundImage, DragDropEffects.All);
            }
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                //draggedTag = p.Tag.ToString();
                if (e.Button == MouseButtons.Left)
                {
                    p.Top += (e.Y - yPos);
                    p.Left += (e.X - xPos);
                }
            }
        }

        private void picture_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            PictureBox p = sender as PictureBox;
            Bitmap bmp = new Bitmap(150, 150);
            p.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
            bmp.MakeTransparent(BackColor);
            e.UseDefaultCursors = false;
            Cursor cur = new Cursor(bmp.GetHicon());
            Cursor.Current = cur;
            //draggedTag = p.Tag.ToString();
        }

        private void picture_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            Panel p2 = sender as Panel;
            droppedTag = draggedTag;
            if ((e.Data.GetDataPresent(DataFormats.Bitmap)))
            {
                p2.BackgroundImage = (Bitmap)(e.Data.GetData(DataFormats.Bitmap));
                p2.Tag = droppedTag;
                //label1.Text = "Sürüklenen cisim = " + p2.Tag;
            }
        }

        private void panel1_BackgroundImageChanged(object sender, EventArgs e)
        {
            //label1.Text = "Sürüklenen cisim = " + panel1.Tag;
            if (droppedTag == pictureBox4.Tag.ToString())
            {
                label1.Text = "A OK!";
            }
        }

        private void panel2_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (droppedTag == pictureBox2.Tag.ToString())
            {
                label2.Text = "A OK!";
            }
        }

        private void panel3_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (droppedTag == pictureBox2.Tag.ToString())
            {
                label3.Text = "A OK!";
            }
        }

        private void panel4_BackgroundImageChanged(object sender, EventArgs e)
        {
            //if (droppedTag == pictureBox2.Tag.ToString())
            //{
            //    label4.Text = "A OK!";
            //}
        }

        private void panel5_BackgroundImageChanged(object sender, EventArgs e)
        {
            //if (droppedTag == pictureBox2.Tag.ToString())
            //{
            //    label5.Text = "A OK!";
            //}
        }

        private void panel6_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {
            //if (droppedTag == pictureBox2.Tag.ToString())
            //{
            //    label6.Text = "A OK!";
            //}
        }

        private void panel7_BackgroundImageChanged(object sender, EventArgs e)
        {
            //if (droppedTag == pictureBox2.Tag.ToString())
            //{
            //    label7.Text = "A OK!";
            //}
        }

        private void panel8_BackgroundImageChanged(object sender, EventArgs e)
        {
            //if (droppedTag == pictureBox2.Tag.ToString())
            //{
            //    label8.Text = "A OK!";
            //}
        }

        private void panel9_BackgroundImageChanged(object sender, EventArgs e)
        {
            //if (droppedTag == pictureBox2.Tag.ToString())
            //{
            //    label9.Text = "A OK!";
            //}
        }

        private void panel10_BackgroundImageChanged(object sender, EventArgs e)
        {
            //if (droppedTag == pictureBox2.Tag.ToString())
            //{
            //    label10.Text = "A OK!";
            //}
        }

        private void panel11_BackgroundImageChanged(object sender, EventArgs e)
        {
            //if (droppedTag == pictureBox2.Tag.ToString())
            //{
            //    label11.Text = "A OK!";
            //}
        }

        private void panel12_BackgroundImageChanged(object sender, EventArgs e)
        {
            //if (droppedTag == pictureBox2.Tag.ToString())
            //{
            //    label12.Text = "A OK!";
            //}
        }

        private void panel13_BackgroundImageChanged(object sender, EventArgs e)
        {
            //if (droppedTag == pictureBox2.Tag.ToString())
            //{
            //    label13.Text = "A OK!";
            //}
        }
    }
}
