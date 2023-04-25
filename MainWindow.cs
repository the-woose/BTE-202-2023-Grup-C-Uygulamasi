namespace BTE_202___2023_Grup_C_Uygulaması
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHucre_Click(object sender, EventArgs e)
        {

        }
        private void btnQuiz_Click(object sender, EventArgs e)
        {
            FormQuiz frm1 = new FormQuiz();
            frm1.Show();
        }

        private void btnSurukle_Click(object sender, EventArgs e)
        {

        }

        private void btnEslestir_Click(object sender, EventArgs e)
        {
            FormEslestir frm3 = new FormEslestir();
            //FormQuiz frm1 = new FormQuiz();
            frm3.Show();
        }
    }
}