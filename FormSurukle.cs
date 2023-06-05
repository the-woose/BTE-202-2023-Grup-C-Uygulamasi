using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTE_202___2023_Grup_C_Uygulaması
{
    public partial class FormSurukle : Form
    {
        string draggedTag = string.Empty;
        string droppedTag = string.Empty;
        private int xPos;
        private int yPos;

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x20;
        //        return cp;
        //    }
        //}
        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    // Do Nothing
        //}

        public FormSurukle()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox p = sender as PictureBox;
            Bitmap bmp = new Bitmap(52, 52);
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
                draggedTag = p.Tag.ToString();
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
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void panel_DragDro(object sender, DragEventArgs e)
        {
            droppedTag = draggedTag;
            if (draggedTag == "Cekirdek")
            {
                pictureCekird1.Visible = true;
                pictureCekird1.BackColor = Color.Transparent;
            }
            if (draggedTag == "Mitokondri")
            {
                pictureMitoB1.Visible = true;
            }
            if (draggedTag == "Endoplazmik")
            {
                pictureGolgiB1.Visible = true;
                pictureGolgiB1.BackColor = Color.Transparent;
                pictureGolgiB2.Visible = true;
                pictureGolgiB2.BackColor = Color.Transparent;
            }
            if (draggedTag == "Koful")
            {
                pictureKoful1.Visible = true;
            }
            if (draggedTag == "Golgi")
            {
                pictureGlgB1.Visible = true;
            }
            //Panel p2 = sender as Panel;
            //if ((e.Data.GetDataPresent(DataFormats.Bitmap)))
            //{
            //label1.Text = "Sürüklenen cisim = " + droppedTag;
            //}
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            droppedTag = draggedTag;
            if (draggedTag == "Cekirdek")
            {
                pictureCekird2.Visible = true;
                pictureCekird2.BackColor = Color.Transparent;
            }
            if (draggedTag == "Mitokondri")
            {
                pictureMitoH1.Visible = true;
                pictureMitoH2.Visible = true;
                pictureMitoH3.Visible = true;
            }
            if (draggedTag == "Endoplazmik")
            {
                pictureGolgiH1.Visible = true;
            }
            if (draggedTag == "Lizozom")
            {
                pictureLizo1.Visible = true;
                pictureLizo2.Visible = true;
                pictureLizo3.Visible = true;
                pictureLizo4.Visible = true;
            }
            if (draggedTag == "Golgi")
            {
                pictureGlgH1.Visible = true;
            }
        }
    }
}
