using System.Runtime.InteropServices;

namespace BTE_202___2023_Grup_C_Uygulaması
{
    public partial class MainWindow : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public MainWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHucre_Click(object sender, EventArgs e)
        {
            FormHucre frm0 = new FormHucre();
            frm0.Show();
        }
        private void btnHucre_MouseHover(object sender, EventArgs e)
        {
            btnHucre.FillColor = Color.White;
            btnHucre.ForeColor = Color.Turquoise;
        }

        private void btnHucre_MouseLeave(object sender, EventArgs e)
        {
            btnHucre.FillColor = Color.Turquoise;
            btnHucre.ForeColor = Color.White;
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            FormQuiz frm1 = new FormQuiz();
            frm1.Show();
        }
        private void btnQuiz_MouseHover(object sender, EventArgs e)
        {
            btnQuiz.FillColor = Color.White;
            btnQuiz.ForeColor = Color.Turquoise;
        }

        private void btnQuiz_MouseLeave(object sender, EventArgs e)
        {
            btnQuiz.FillColor = Color.Turquoise;
            btnQuiz.ForeColor = Color.White;
        }

        private void btnSurukle_Click(object sender, EventArgs e)
        {
            FormSurukle frm2 = new FormSurukle();
            frm2.Show();
        }
        private void btnSurukle_MouseHover(object sender, EventArgs e)
        {
            btnSurukle.FillColor = Color.White;
            btnSurukle.ForeColor = Color.Turquoise;
        }
        private void btnSurukle_MouseLeave(object sender, EventArgs e)
        {
            btnSurukle.FillColor = Color.Turquoise;
            btnSurukle.ForeColor = Color.White;
        }

        private void btnEslestir_Click(object sender, EventArgs e)
        {
            FormEslestir frm3 = new FormEslestir();
            frm3.Show();
        }
        private void btnEslestir_MouseHover(object sender, EventArgs e)
        {
            btnEslestir.FillColor = Color.White;
            btnEslestir.ForeColor = Color.Turquoise;
        }

        private void btnEslestir_MouseLeave(object sender, EventArgs e)
        {
            btnEslestir.FillColor = Color.Turquoise;
            btnEslestir.ForeColor = Color.White;
        }

    }
}