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
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btnMin = new Button();
            btnHucre = new Button();
            btnQuiz = new Button();
            btnSurukle = new Button();
            btnEslestir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Menu;
            pictureBox1.InitialImage = Properties.Resources.Menu;
            pictureBox1.Location = new Point(35, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 355);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(736, 14);
            btnExit.Margin = new Padding(5);
            btnExit.MaximumSize = new Size(50, 50);
            btnExit.MinimumSize = new Size(50, 50);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 1;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.DarkTurquoise;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMin.ForeColor = Color.White;
            btnMin.Location = new Point(676, 14);
            btnMin.Margin = new Padding(5);
            btnMin.MaximumSize = new Size(50, 50);
            btnMin.MinimumSize = new Size(50, 50);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(50, 50);
            btnMin.TabIndex = 2;
            btnMin.Text = "__";
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnHucre
            // 
            btnHucre.Location = new Point(524, 110);
            btnHucre.Name = "btnHucre";
            btnHucre.Size = new Size(119, 41);
            btnHucre.TabIndex = 3;
            btnHucre.Text = "Hücreler";
            btnHucre.UseVisualStyleBackColor = true;
            btnHucre.Click += btnHucre_Click;
            // 
            // btnQuiz
            // 
            btnQuiz.Location = new Point(524, 167);
            btnQuiz.Name = "btnQuiz";
            btnQuiz.Size = new Size(119, 41);
            btnQuiz.TabIndex = 4;
            btnQuiz.Text = "Quiz";
            btnQuiz.UseVisualStyleBackColor = true;
            btnQuiz.Click += btnQuiz_Click;
            // 
            // btnSurukle
            // 
            btnSurukle.Location = new Point(524, 225);
            btnSurukle.Name = "btnSurukle";
            btnSurukle.Size = new Size(119, 41);
            btnSurukle.TabIndex = 5;
            btnSurukle.Text = "Sürükle-Bırak";
            btnSurukle.UseVisualStyleBackColor = true;
            btnSurukle.Click += btnSurukle_Click;
            // 
            // btnEslestir
            // 
            btnEslestir.Location = new Point(524, 283);
            btnEslestir.Name = "btnEslestir";
            btnEslestir.Size = new Size(119, 41);
            btnEslestir.TabIndex = 6;
            btnEslestir.Text = "Eşleştir";
            btnEslestir.UseVisualStyleBackColor = true;
            btnEslestir.Click += btnEslestir_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEslestir);
            Controls.Add(btnSurukle);
            Controls.Add(btnQuiz);
            Controls.Add(btnHucre);
            Controls.Add(btnMin);
            Controls.Add(btnExit);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnExit;
        private Button btnMin;
        private Button btnHucre;
        private Button btnQuiz;
        private Button btnSurukle;
        private Button btnEslestir;
    }
}