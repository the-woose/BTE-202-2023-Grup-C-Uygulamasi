namespace BTE_202___2023_Grup_C_Uygulaması
{
    partial class FormQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMin = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            lblSoruBaslik = new Label();
            panel1 = new Panel();
            labelCevap = new Label();
            textSoru = new TextBox();
            button2 = new Button();
            buttonKontrol = new Button();
            button1 = new Button();
            lblCvp5 = new RadioButton();
            lblCvp4 = new RadioButton();
            lblCvp3 = new RadioButton();
            lblCvp2 = new RadioButton();
            lblCvp1 = new RadioButton();
            textSoruContainer = new RoundedButton();
            panel2 = new Panel();
            btnKucult = new RoundedButton();
            btnKapat = new RoundedButton();
            lblFormBaslik = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.DarkTurquoise;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMin.ForeColor = Color.White;
            btnMin.Location = new Point(1290, 14);
            btnMin.Margin = new Padding(5);
            btnMin.MaximumSize = new Size(50, 50);
            btnMin.MinimumSize = new Size(50, 50);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(50, 50);
            btnMin.TabIndex = 4;
            btnMin.Text = "__";
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1350, 14);
            btnExit.Margin = new Padding(5);
            btnExit.MaximumSize = new Size(50, 50);
            btnExit.MinimumSize = new Size(50, 50);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 3;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.quiz;
            pictureBox1.Location = new Point(510, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblSoruBaslik
            // 
            lblSoruBaslik.AutoSize = true;
            lblSoruBaslik.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoruBaslik.ForeColor = Color.Red;
            lblSoruBaslik.Location = new Point(13, 13);
            lblSoruBaslik.Name = "lblSoruBaslik";
            lblSoruBaslik.Size = new Size(97, 37);
            lblSoruBaslik.TabIndex = 11;
            lblSoruBaslik.Text = "SORU:";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelCevap);
            panel1.Controls.Add(textSoru);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(buttonKontrol);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblCvp5);
            panel1.Controls.Add(lblCvp4);
            panel1.Controls.Add(lblCvp3);
            panel1.Controls.Add(lblCvp2);
            panel1.Controls.Add(lblCvp1);
            panel1.Controls.Add(lblSoruBaslik);
            panel1.Controls.Add(textSoruContainer);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 309);
            panel1.Name = "panel1";
            panel1.Size = new Size(1414, 540);
            panel1.TabIndex = 12;
            // 
            // labelCevap
            // 
            labelCevap.Anchor = AnchorStyles.Top;
            labelCevap.AutoSize = true;
            labelCevap.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelCevap.Location = new Point(633, 197);
            labelCevap.Name = "labelCevap";
            labelCevap.Size = new Size(0, 30);
            labelCevap.TabIndex = 16;
            labelCevap.TextAlign = ContentAlignment.TopCenter;
            // 
            // textSoru
            // 
            textSoru.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textSoru.BorderStyle = BorderStyle.None;
            textSoru.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textSoru.Location = new Point(128, 13);
            textSoru.Multiline = true;
            textSoru.Name = "textSoru";
            textSoru.Size = new Size(1156, 232);
            textSoru.TabIndex = 15;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Green;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1350, 476);
            button2.Margin = new Padding(5);
            button2.MaximumSize = new Size(50, 50);
            button2.MinimumSize = new Size(50, 50);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 14;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = false;
            button2.Click += sonraki_Soru;
            // 
            // buttonKontrol
            // 
            buttonKontrol.Anchor = AnchorStyles.Bottom;
            buttonKontrol.BackColor = Color.Green;
            buttonKontrol.FlatAppearance.BorderSize = 0;
            buttonKontrol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonKontrol.ForeColor = Color.White;
            buttonKontrol.Location = new Point(680, 476);
            buttonKontrol.Margin = new Padding(5);
            buttonKontrol.MaximumSize = new Size(75, 50);
            buttonKontrol.MinimumSize = new Size(75, 50);
            buttonKontrol.Name = "buttonKontrol";
            buttonKontrol.Size = new Size(75, 50);
            buttonKontrol.TabIndex = 13;
            buttonKontrol.Text = "Kontrol Et";
            buttonKontrol.UseVisualStyleBackColor = false;
            buttonKontrol.Click += btnKontrol;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Green;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1290, 476);
            button1.Margin = new Padding(5);
            button1.MaximumSize = new Size(50, 50);
            button1.MinimumSize = new Size(50, 50);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 13;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = false;
            button1.Click += onceki_Soru;
            // 
            // lblCvp5
            // 
            lblCvp5.AutoSize = true;
            lblCvp5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCvp5.Location = new Point(33, 419);
            lblCvp5.Name = "lblCvp5";
            lblCvp5.Size = new Size(44, 36);
            lblCvp5.TabIndex = 12;
            lblCvp5.TabStop = true;
            lblCvp5.Text = "E";
            lblCvp5.UseVisualStyleBackColor = true;
            // 
            // lblCvp4
            // 
            lblCvp4.AutoSize = true;
            lblCvp4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCvp4.Location = new Point(33, 377);
            lblCvp4.Name = "lblCvp4";
            lblCvp4.Size = new Size(49, 36);
            lblCvp4.TabIndex = 12;
            lblCvp4.TabStop = true;
            lblCvp4.Text = "D";
            lblCvp4.UseVisualStyleBackColor = true;
            // 
            // lblCvp3
            // 
            lblCvp3.AutoSize = true;
            lblCvp3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCvp3.Location = new Point(33, 335);
            lblCvp3.Name = "lblCvp3";
            lblCvp3.Size = new Size(47, 36);
            lblCvp3.TabIndex = 12;
            lblCvp3.TabStop = true;
            lblCvp3.Text = "C";
            lblCvp3.UseVisualStyleBackColor = true;
            // 
            // lblCvp2
            // 
            lblCvp2.AutoSize = true;
            lblCvp2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCvp2.Location = new Point(33, 293);
            lblCvp2.Name = "lblCvp2";
            lblCvp2.Size = new Size(46, 36);
            lblCvp2.TabIndex = 12;
            lblCvp2.TabStop = true;
            lblCvp2.Text = "B";
            lblCvp2.UseVisualStyleBackColor = true;
            // 
            // lblCvp1
            // 
            lblCvp1.AutoSize = true;
            lblCvp1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCvp1.Location = new Point(33, 251);
            lblCvp1.Name = "lblCvp1";
            lblCvp1.Size = new Size(47, 36);
            lblCvp1.TabIndex = 12;
            lblCvp1.TabStop = true;
            lblCvp1.Text = "A";
            lblCvp1.UseVisualStyleBackColor = true;
            // 
            // textSoruContainer
            // 
            textSoruContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textSoruContainer.BorderColor = Color.Empty;
            textSoruContainer.BorderSize = 0;
            textSoruContainer.ControlText = "";
            textSoruContainer.Enabled = false;
            textSoruContainer.FillColor = Color.White;
            textSoruContainer.FlatAppearance.BorderSize = 0;
            textSoruContainer.FlatStyle = FlatStyle.Flat;
            textSoruContainer.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            textSoruContainer.ForeColor = Color.White;
            textSoruContainer.Location = new Point(116, 3);
            textSoruContainer.Name = "textSoruContainer";
            textSoruContainer.Radius = 50;
            textSoruContainer.Size = new Size(1178, 253);
            textSoruContainer.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnKucult);
            panel2.Controls.Add(btnKapat);
            panel2.Controls.Add(lblFormBaslik);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1414, 309);
            panel2.TabIndex = 13;
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
            btnKucult.Location = new Point(1160, -46);
            btnKucult.Name = "btnKucult";
            btnKucult.Radius = 50;
            btnKucult.Size = new Size(100, 110);
            btnKucult.TabIndex = 27;
            btnKucult.Text = "\r\n-";
            btnKucult.Click += btnMin_Click;
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
            btnKapat.Location = new Point(1279, -46);
            btnKapat.Name = "btnKapat";
            btnKapat.Radius = 50;
            btnKapat.Size = new Size(100, 110);
            btnKapat.TabIndex = 28;
            btnKapat.Text = "\r\nX";
            btnKapat.Click += btnExit_Click;
            // 
            // lblFormBaslik
            // 
            lblFormBaslik.Anchor = AnchorStyles.Top;
            lblFormBaslik.BorderColor = Color.Empty;
            lblFormBaslik.BorderSize = 0;
            lblFormBaslik.ControlText = "\r\nQuiz";
            lblFormBaslik.Enabled = false;
            lblFormBaslik.FillColor = Color.Indigo;
            lblFormBaslik.FlatAppearance.BorderSize = 0;
            lblFormBaslik.FlatStyle = FlatStyle.Flat;
            lblFormBaslik.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormBaslik.ForeColor = Color.White;
            lblFormBaslik.Location = new Point(479, -70);
            lblFormBaslik.Name = "lblFormBaslik";
            lblFormBaslik.Radius = 50;
            lblFormBaslik.Size = new Size(456, 148);
            lblFormBaslik.TabIndex = 26;
            lblFormBaslik.Text = "\r\nQuiz";
            // 
            // FormQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(130, 148, 196);
            ClientSize = new Size(1414, 849);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnMin);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormQuiz";
            Text = "FormQuiz";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnMin;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Label lblSoruBaslik;
        private Panel panel1;
        private RadioButton lblCvp1;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private RadioButton lblCvp5;
        private RadioButton lblCvp4;
        private RadioButton lblCvp3;
        private RadioButton lblCvp2;
        private TextBox textSoru;
        private Button buttonKontrol;
        private Label labelCevap;
        private RoundedButton lblFormBaslik;
        private RoundedButton btnKucult;
        private RoundedButton btnKapat;
        private RoundedButton textSoruContainer;
    }
}