namespace BTE_202___2023_Grup_C_Uygulaması
{
    partial class FormHucre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHucre));
            textSoru = new TextBox();
            textCevap = new TextBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnKucult = new RoundedButton();
            btnKapat = new RoundedButton();
            lblFormBaslik = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textSoru
            // 
            textSoru.Location = new Point(558, 139);
            textSoru.MaximumSize = new Size(415, 133);
            textSoru.Multiline = true;
            textSoru.Name = "textSoru";
            textSoru.Size = new Size(330, 133);
            textSoru.TabIndex = 13;
            textSoru.Text = "Cisim";
            // 
            // textCevap
            // 
            textCevap.Location = new Point(558, 278);
            textCevap.MaximumSize = new Size(415, 133);
            textCevap.Multiline = true;
            textCevap.Name = "textCevap";
            textCevap.Size = new Size(330, 123);
            textCevap.TabIndex = 13;
            textCevap.Text = "Tanım";
            // 
            // button1
            // 
            button1.Location = new Point(568, 97);
            button1.MaximumSize = new Size(75, 23);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "TanımGetir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(896, 126);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(578, 607);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(476, 625);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
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
            btnKucult.Location = new Point(1233, -46);
            btnKucult.Name = "btnKucult";
            btnKucult.Radius = 50;
            btnKucult.Size = new Size(100, 110);
            btnKucult.TabIndex = 32;
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
            btnKapat.Location = new Point(1352, -46);
            btnKapat.Name = "btnKapat";
            btnKapat.Radius = 50;
            btnKapat.Size = new Size(100, 110);
            btnKapat.TabIndex = 33;
            btnKapat.Text = "\r\nX";
            btnKapat.Click += btnExit_Click;
            // 
            // lblFormBaslik
            // 
            lblFormBaslik.Anchor = AnchorStyles.Top;
            lblFormBaslik.BorderColor = Color.Empty;
            lblFormBaslik.BorderSize = 0;
            lblFormBaslik.ControlText = "\r\nHayvan ve Bitki Hücreleri";
            lblFormBaslik.Enabled = false;
            lblFormBaslik.FillColor = Color.PaleVioletRed;
            lblFormBaslik.FlatAppearance.BorderSize = 0;
            lblFormBaslik.FlatStyle = FlatStyle.Flat;
            lblFormBaslik.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormBaslik.ForeColor = Color.White;
            lblFormBaslik.Location = new Point(441, -70);
            lblFormBaslik.Name = "lblFormBaslik";
            lblFormBaslik.Radius = 50;
            lblFormBaslik.Size = new Size(584, 148);
            lblFormBaslik.TabIndex = 31;
            lblFormBaslik.Text = "\r\nHayvan ve Bitki Hücreleri";
            // 
            // FormHucre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 237, 219);
            ClientSize = new Size(1486, 801);
            Controls.Add(btnKucult);
            Controls.Add(btnKapat);
            Controls.Add(lblFormBaslik);
            Controls.Add(button1);
            Controls.Add(textCevap);
            Controls.Add(textSoru);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHucre";
            Text = "FormHucre";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textSoru;
        private TextBox textCevap;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private RoundedButton btnKucult;
        private RoundedButton btnKapat;
        private RoundedButton lblFormBaslik;
    }
}