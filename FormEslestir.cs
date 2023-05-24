using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTE_202___2023_Grup_C_Uygulaması
{
    public partial class FormEslestir : Form
    {
        Bitmap buttonImage = Properties.Resources.cekirdek1;
        private int xPos;
        private int yPos;
        public FormEslestir()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //!!!!!!!!!!!!!!!!!
            //!!! DELETE ME !!!
            //!!!!!!!!!!!!!!!!!
            //
            //label1.Text = pictureBox2.BackgroundImage.GetType().ToString();
            var sendername = sender as PictureBox;
            label1.Text = sendername.BackgroundImage.ToString();
        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox p = sender as PictureBox;
            Bitmap bmp = new Bitmap(52, 52);
            p.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
            //buttonImage = bmp;
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
            Bitmap bmp = new Bitmap(52, 52);
            p.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
            bmp.MakeTransparent(BackColor);
            e.UseDefaultCursors = false;
            Cursor cur = new Cursor(bmp.GetHicon());
            Cursor.Current = cur;
        }

        private void picture_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
                label1.Text = "Copying!";
            }
            else
                e.Effect = DragDropEffects.None;
            label1.Text = "Nothing to copy";
        }

        private void pictureBox3_DragDrop(object sender, DragEventArgs e)
        {
            if ((e.Data.GetDataPresent(DataFormats.Bitmap)))
            {
                this.pictureBox3.BackgroundImage = (Bitmap)(e.Data.GetData(DataFormats.Bitmap));
            }
        }

        //private void pictureBox3_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        //{
        //    if ((e.Data.GetDataPresent(DataFormats.Bitmap)))
        //    {
        //        this.pictureBox3.BackgroundImage = (Bitmap)(e.Data.GetData(DataFormats.Bitmap));
        //    }
        //}

    }
}
