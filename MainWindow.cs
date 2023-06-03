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

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            FormQuiz frm1 = new FormQuiz();
            frm1.Show();
        }

        private void btnSurukle_Click(object sender, EventArgs e)
        {
            FormSurukle frm2 = new FormSurukle();
            frm2.Show();
        }

        private void btnEslestir_Click(object sender, EventArgs e)
        {
            FormEslestir frm3 = new FormEslestir();
            frm3.Show();
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            var roundedbutton = sender as RoundedButton;
            if (roundedbutton != null)
            {
                roundedbutton.ForeColor = Color.Turquoise;
                roundedbutton.FillColor = Color.White;
            }
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            var roundedbutton = sender as RoundedButton;
            if (roundedbutton != null)
            {
                roundedbutton.ForeColor = Color.White;
                roundedbutton.FillColor = Color.Turquoise;
            }
        }
    }
}