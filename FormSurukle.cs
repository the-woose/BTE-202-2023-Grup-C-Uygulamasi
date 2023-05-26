using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
        public FormSurukle()
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
            Panel p2 = sender as Panel;
            if ((e.Data.GetDataPresent(DataFormats.Bitmap)))
            {
                droppedTag = draggedTag;
                if (draggedTag == "Cekirdek")
                {
                    pictureCekird1.Visible = true;
                }
                if (draggedTag == "Mitokondri")
                {
                    pictureMito2.Visible = true;
                    pictureMito3.Visible = true;
                    pictureMito4.Visible = true;
                }
                //label1.Text = "Sürüklenen cisim = " + droppedTag;
            }
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            droppedTag = draggedTag;
            if (draggedTag == "Cekirdek")
            {
                pictureCekird2.Visible = true;
            }
            if (draggedTag == "Mitokondri")
            {
                pictureMito5.Visible = true;
                pictureMito6.Visible = true;
                pictureMito7.Visible = true;
            }
        }
    }
}
