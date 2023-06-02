namespace BTE_202___2023_Grup_C_Uygulaması
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnKucult = new RoundedButton();
            btnKapat = new RoundedButton();
            btnEslestir = new RoundedButton();
            btnSurukle = new RoundedButton();
            btnHucre = new RoundedButton();
            lblUygulamaAdi = new RoundedButton();
            btnQuiz = new RoundedButton();
            SuspendLayout();
            // 
            // btnKucult
            // 
            btnKucult.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKucult.BorderColor = Color.DarkTurquoise;
            btnKucult.BorderSize = 4;
            btnKucult.ControlText = "\r\n-";
            btnKucult.FillColor = Color.White;
            btnKucult.FlatAppearance.BorderSize = 0;
            btnKucult.FlatStyle = FlatStyle.Flat;
            btnKucult.Font = new Font("Fira Code SemiBold", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            btnKucult.ForeColor = Color.DarkTurquoise;
            btnKucult.Location = new Point(564, -46);
            btnKucult.Name = "btnKucult";
            btnKucult.Radius = 50;
            btnKucult.Size = new Size(100, 110);
            btnKucult.TabIndex = 22;
            btnKucult.Text = "\r\n-";
            btnKucult.UseVisualStyleBackColor = false;
            btnKucult.Click += btnKucult_Click;
            // 
            // btnKapat
            // 
            btnKapat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKapat.BorderColor = Color.Red;
            btnKapat.BorderSize = 4;
            btnKapat.ControlText = "\r\nX";
            btnKapat.FillColor = Color.White;
            btnKapat.FlatAppearance.BorderSize = 0;
            btnKapat.FlatStyle = FlatStyle.Flat;
            btnKapat.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnKapat.ForeColor = Color.Red;
            btnKapat.Location = new Point(683, -46);
            btnKapat.Name = "btnKapat";
            btnKapat.Radius = 50;
            btnKapat.Size = new Size(100, 110);
            btnKapat.TabIndex = 23;
            btnKapat.Text = "\r\nX";
            btnKapat.Click += btnKapat_Click;
            // 
            // btnEslestir
            // 
            btnEslestir.BorderColor = Color.Empty;
            btnEslestir.BorderSize = 0;
            btnEslestir.ControlText = "Eşleştir";
            btnEslestir.FillColor = Color.Turquoise;
            btnEslestir.FlatAppearance.BorderSize = 0;
            btnEslestir.FlatStyle = FlatStyle.Flat;
            btnEslestir.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnEslestir.ForeColor = Color.White;
            btnEslestir.Location = new Point(180, 233);
            btnEslestir.Name = "btnEslestir";
            btnEslestir.Radius = 50;
            btnEslestir.Size = new Size(178, 63);
            btnEslestir.TabIndex = 24;
            btnEslestir.Text = "Eşleştir";
            btnEslestir.Click += btnEslestir_Click;
            btnEslestir.MouseLeave += btnEslestir_MouseLeave;
            btnEslestir.MouseHover += btnEslestir_MouseHover;
            // 
            // btnSurukle
            // 
            btnSurukle.BorderColor = Color.Empty;
            btnSurukle.BorderSize = 0;
            btnSurukle.ControlText = "Sürükle-Bırak";
            btnSurukle.FillColor = Color.Turquoise;
            btnSurukle.FlatAppearance.BorderSize = 0;
            btnSurukle.FlatStyle = FlatStyle.Flat;
            btnSurukle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnSurukle.ForeColor = Color.White;
            btnSurukle.Location = new Point(450, 233);
            btnSurukle.Name = "btnSurukle";
            btnSurukle.Radius = 50;
            btnSurukle.Size = new Size(178, 63);
            btnSurukle.TabIndex = 24;
            btnSurukle.Text = "Sürükle-Bırak";
            btnSurukle.Click += btnSurukle_Click;
            btnSurukle.MouseLeave += btnSurukle_MouseLeave;
            btnSurukle.MouseHover += btnSurukle_MouseHover;
            // 
            // btnHucre
            // 
            btnHucre.BorderColor = Color.Empty;
            btnHucre.BorderSize = 0;
            btnHucre.ControlText = "Hücreler";
            btnHucre.FillColor = Color.Turquoise;
            btnHucre.FlatAppearance.BorderSize = 0;
            btnHucre.FlatStyle = FlatStyle.Flat;
            btnHucre.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnHucre.ForeColor = Color.White;
            btnHucre.Location = new Point(450, 325);
            btnHucre.Name = "btnHucre";
            btnHucre.Radius = 50;
            btnHucre.Size = new Size(178, 63);
            btnHucre.TabIndex = 24;
            btnHucre.Text = "Hücreler";
            btnHucre.Click += btnHucre_Click;
            btnHucre.MouseLeave += btnHucre_MouseLeave;
            btnHucre.MouseHover += btnHucre_MouseHover;
            // 
            // lblUygulamaAdi
            // 
            lblUygulamaAdi.BorderColor = Color.Empty;
            lblUygulamaAdi.BorderSize = 0;
            lblUygulamaAdi.ControlText = "Uygulama Adı";
            lblUygulamaAdi.Enabled = false;
            lblUygulamaAdi.FillColor = Color.Turquoise;
            lblUygulamaAdi.FlatAppearance.BorderSize = 0;
            lblUygulamaAdi.FlatStyle = FlatStyle.Flat;
            lblUygulamaAdi.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblUygulamaAdi.ForeColor = Color.White;
            lblUygulamaAdi.Location = new Point(212, 91);
            lblUygulamaAdi.Name = "lblUygulamaAdi";
            lblUygulamaAdi.Radius = 50;
            lblUygulamaAdi.Size = new Size(394, 98);
            lblUygulamaAdi.TabIndex = 24;
            lblUygulamaAdi.Text = "Uygulama Adı";
            lblUygulamaAdi.Click += btnHucre_Click;
            // 
            // btnQuiz
            // 
            btnQuiz.BorderColor = Color.Empty;
            btnQuiz.BorderSize = 0;
            btnQuiz.ControlText = "Quiz";
            btnQuiz.FillColor = Color.Turquoise;
            btnQuiz.FlatAppearance.BorderSize = 0;
            btnQuiz.FlatStyle = FlatStyle.Flat;
            btnQuiz.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuiz.ForeColor = Color.White;
            btnQuiz.Location = new Point(180, 325);
            btnQuiz.Name = "btnQuiz";
            btnQuiz.Radius = 50;
            btnQuiz.Size = new Size(178, 63);
            btnQuiz.TabIndex = 24;
            btnQuiz.Text = "Quiz";
            btnQuiz.Click += btnQuiz_Click;
            btnQuiz.MouseLeave += btnQuiz_MouseLeave;
            btnQuiz.MouseHover += btnQuiz_MouseHover;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUygulamaAdi);
            Controls.Add(btnHucre);
            Controls.Add(btnSurukle);
            Controls.Add(btnQuiz);
            Controls.Add(btnEslestir);
            Controls.Add(btnKucult);
            Controls.Add(btnKapat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            ResumeLayout(false);
        }

        #endregion
        private RoundedButton btnKucult;
        private RoundedButton btnKapat;
        private RoundedButton btnEslestir;
        private RoundedButton btnSurukle;
        private RoundedButton btnHucre;
        private RoundedButton lblUygulamaAdi;
        private RoundedButton btnQuiz;
    }
}