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
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            panel2 = new Panel();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton12 = new RadioButton();
            radioButton13 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textSoru
            // 
            textSoru.Anchor = AnchorStyles.Top;
            textSoru.Location = new Point(2, 239);
            textSoru.MaximumSize = new Size(415, 133);
            textSoru.Multiline = true;
            textSoru.Name = "textSoru";
            textSoru.Size = new Size(330, 35);
            textSoru.TabIndex = 13;
            textSoru.Text = "Cisim";
            // 
            // textCevap
            // 
            textCevap.Anchor = AnchorStyles.Top;
            textCevap.Location = new Point(0, 280);
            textCevap.MaximumSize = new Size(415, 133);
            textCevap.Multiline = true;
            textCevap.Name = "textCevap";
            textCevap.Size = new Size(330, 123);
            textCevap.TabIndex = 13;
            textCevap.Text = "Tanım";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(115, 210);
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
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(578, 607);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(476, 625);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // btnKucult
            // 
            btnKucult.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKucult.BackColor = Color.Transparent;
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
            btnKucult.UseVisualStyleBackColor = false;
            btnKucult.Click += btnMin_Click;
            // 
            // btnKapat
            // 
            btnKapat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKapat.BackColor = Color.Transparent;
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
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnExit_Click;
            // 
            // lblFormBaslik
            // 
            lblFormBaslik.Anchor = AnchorStyles.Top;
            lblFormBaslik.BackColor = Color.Transparent;
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
            lblFormBaslik.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Location = new Point(0, 409);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 34;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.Location = new Point(249, 409);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 34;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom;
            groupBox1.Controls.Add(radioButton13);
            groupBox1.Controls.Add(radioButton12);
            groupBox1.Controls.Add(radioButton11);
            groupBox1.Controls.Add(radioButton10);
            groupBox1.Controls.Add(radioButton9);
            groupBox1.Controls.Add(radioButton8);
            groupBox1.Controls.Add(radioButton7);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textSoru);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textCevap);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(546, 323);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 466);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Organeller";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(887, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 652);
            panel1.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(528, 652);
            panel2.TabIndex = 37;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 35;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 36;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 37;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 97);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(94, 19);
            radioButton4.TabIndex = 38;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 122);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(94, 19);
            radioButton5.TabIndex = 39;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(6, 147);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(94, 19);
            radioButton6.TabIndex = 40;
            radioButton6.TabStop = true;
            radioButton6.Text = "radioButton6";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(230, 22);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(94, 19);
            radioButton7.TabIndex = 41;
            radioButton7.TabStop = true;
            radioButton7.Text = "radioButton7";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(230, 47);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(94, 19);
            radioButton8.TabIndex = 42;
            radioButton8.TabStop = true;
            radioButton8.Text = "radioButton8";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(230, 72);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(94, 19);
            radioButton9.TabIndex = 43;
            radioButton9.TabStop = true;
            radioButton9.Text = "radioButton9";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(230, 97);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(100, 19);
            radioButton10.TabIndex = 44;
            radioButton10.TabStop = true;
            radioButton10.Text = "radioButton10";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(230, 122);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(100, 19);
            radioButton11.TabIndex = 45;
            radioButton11.TabStop = true;
            radioButton11.Text = "radioButton11";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Location = new Point(230, 147);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(100, 19);
            radioButton12.TabIndex = 46;
            radioButton12.TabStop = true;
            radioButton12.Text = "radioButton12";
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            radioButton13.AutoSize = true;
            radioButton13.Location = new Point(102, 175);
            radioButton13.Name = "radioButton13";
            radioButton13.Size = new Size(100, 19);
            radioButton13.TabIndex = 47;
            radioButton13.TabStop = true;
            radioButton13.Text = "radioButton13";
            radioButton13.UseVisualStyleBackColor = true;
            // 
            // FormHucre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 237, 219);
            ClientSize = new Size(1486, 801);
            Controls.Add(groupBox1);
            Controls.Add(btnKucult);
            Controls.Add(btnKapat);
            Controls.Add(lblFormBaslik);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHucre";
            Text = "FormHucre";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
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
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private Panel panel1;
        private Panel panel2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton13;
        private RadioButton radioButton12;
        private RadioButton radioButton11;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
    }
}