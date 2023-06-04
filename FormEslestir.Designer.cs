namespace BTE_202___2023_Grup_C_Uygulaması
{
    partial class FormEslestir
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            lblFormBaslik = new RoundedButton();
            btnKucult = new RoundedButton();
            btnKapat = new RoundedButton();
            panel5 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.ORGANELLER_Eslestir;
            pictureBox1.Location = new Point(-98, 847);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 563);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.mito1;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(125, 784);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 70);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "mitokondri_01";
            pictureBox2.GiveFeedback += picture_GiveFeedback;
            pictureBox2.MouseDown += picture_MouseDown;
            pictureBox2.MouseMove += picture_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 124);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(526, 15);
            label1.TabIndex = 12;
            label1.Text = ".............................................................................................................................................................................";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(666, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(62, 53);
            panel1.TabIndex = 13;
            panel1.BackgroundImageChanged += panel1_BackgroundImageChanged;
            panel1.DragDrop += panel_DragDrop;
            panel1.DragEnter += picture_DragEnter;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.mito3;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(348, 674);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(180, 70);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "mitokondri_02";
            pictureBox4.GiveFeedback += picture_GiveFeedback;
            pictureBox4.MouseDown += picture_MouseDown;
            pictureBox4.MouseMove += picture_MouseMove;
            // 
            // panel2
            // 
            panel2.AllowDrop = true;
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(666, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(62, 53);
            panel2.TabIndex = 14;
            panel2.BackgroundImageChanged += panel2_BackgroundImageChanged;
            panel2.DragDrop += panel_DragDrop;
            panel2.DragEnter += picture_DragEnter;
            // 
            // lblFormBaslik
            // 
            lblFormBaslik.Anchor = AnchorStyles.Top;
            lblFormBaslik.BorderColor = Color.Empty;
            lblFormBaslik.BorderSize = 0;
            lblFormBaslik.ControlText = "\r\nÖzellikleri Eşleştir";
            lblFormBaslik.Enabled = false;
            lblFormBaslik.FillColor = Color.Green;
            lblFormBaslik.FlatAppearance.BorderSize = 0;
            lblFormBaslik.FlatStyle = FlatStyle.Flat;
            lblFormBaslik.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormBaslik.ForeColor = Color.White;
            lblFormBaslik.Location = new Point(523, -67);
            lblFormBaslik.Name = "lblFormBaslik";
            lblFormBaslik.Radius = 50;
            lblFormBaslik.Size = new Size(456, 148);
            lblFormBaslik.TabIndex = 27;
            lblFormBaslik.Text = "\r\nÖzellikleri Eşleştir";
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
            btnKucult.Location = new Point(1239, -46);
            btnKucult.Name = "btnKucult";
            btnKucult.Radius = 50;
            btnKucult.Size = new Size(100, 110);
            btnKucult.TabIndex = 29;
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
            btnKapat.Location = new Point(1358, -46);
            btnKapat.Name = "btnKapat";
            btnKapat.Radius = 50;
            btnKapat.Size = new Size(100, 110);
            btnKapat.TabIndex = 30;
            btnKapat.Text = "\r\nX";
            btnKapat.Click += btnExit_Click;
            // 
            // panel5
            // 
            panel5.AllowDrop = true;
            panel5.Anchor = AnchorStyles.Top;
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Location = new Point(666, 364);
            panel5.Name = "panel5";
            panel5.Size = new Size(62, 53);
            panel5.TabIndex = 13;
            panel5.BackgroundImageChanged += panel5_BackgroundImageChanged;
            panel5.DragDrop += panel_DragDrop;
            panel5.DragEnter += picture_DragEnter;
            // 
            // panel6
            // 
            panel6.AllowDrop = true;
            panel6.Anchor = AnchorStyles.Top;
            panel6.BackgroundImageLayout = ImageLayout.Zoom;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Location = new Point(666, 431);
            panel6.Name = "panel6";
            panel6.Size = new Size(62, 53);
            panel6.TabIndex = 14;
            panel6.BackgroundImageLayoutChanged += panel6_BackgroundImageLayoutChanged;
            panel6.DragDrop += panel_DragDrop;
            panel6.DragEnter += picture_DragEnter;
            // 
            // panel3
            // 
            panel3.AllowDrop = true;
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Location = new Point(666, 230);
            panel3.Name = "panel3";
            panel3.Size = new Size(62, 53);
            panel3.TabIndex = 13;
            panel3.BackgroundImageChanged += panel3_BackgroundImageChanged;
            panel3.DragDrop += panel_DragDrop;
            panel3.DragEnter += picture_DragEnter;
            // 
            // panel4
            // 
            panel4.AllowDrop = true;
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Location = new Point(666, 297);
            panel4.Name = "panel4";
            panel4.Size = new Size(62, 53);
            panel4.TabIndex = 13;
            panel4.BackgroundImageChanged += panel4_BackgroundImageChanged;
            panel4.DragDrop += panel_DragDrop;
            panel4.DragEnter += picture_DragEnter;
            // 
            // panel7
            // 
            panel7.AllowDrop = true;
            panel7.Anchor = AnchorStyles.Top;
            panel7.BackgroundImageLayout = ImageLayout.Zoom;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Location = new Point(666, 498);
            panel7.Name = "panel7";
            panel7.Size = new Size(62, 53);
            panel7.TabIndex = 14;
            panel7.BackgroundImageChanged += panel7_BackgroundImageChanged;
            panel7.DragDrop += panel_DragDrop;
            panel7.DragEnter += picture_DragEnter;
            // 
            // panel8
            // 
            panel8.AllowDrop = true;
            panel8.Anchor = AnchorStyles.Top;
            panel8.BackgroundImageLayout = ImageLayout.Zoom;
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Location = new Point(743, 96);
            panel8.Name = "panel8";
            panel8.Size = new Size(62, 53);
            panel8.TabIndex = 14;
            panel8.BackgroundImageChanged += panel8_BackgroundImageChanged;
            panel8.DragDrop += panel_DragDrop;
            panel8.DragEnter += picture_DragEnter;
            // 
            // panel9
            // 
            panel9.AllowDrop = true;
            panel9.Anchor = AnchorStyles.Top;
            panel9.BackgroundImageLayout = ImageLayout.Zoom;
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Location = new Point(743, 163);
            panel9.Name = "panel9";
            panel9.Size = new Size(62, 53);
            panel9.TabIndex = 13;
            panel9.BackgroundImageChanged += panel9_BackgroundImageChanged;
            panel9.DragDrop += panel_DragDrop;
            panel9.DragEnter += picture_DragEnter;
            // 
            // panel10
            // 
            panel10.AllowDrop = true;
            panel10.Anchor = AnchorStyles.Top;
            panel10.BackgroundImageLayout = ImageLayout.Zoom;
            panel10.BorderStyle = BorderStyle.Fixed3D;
            panel10.Location = new Point(743, 230);
            panel10.Name = "panel10";
            panel10.Size = new Size(62, 53);
            panel10.TabIndex = 13;
            panel10.BackgroundImageChanged += panel10_BackgroundImageChanged;
            panel10.DragDrop += panel_DragDrop;
            panel10.DragEnter += picture_DragEnter;
            // 
            // panel11
            // 
            panel11.AllowDrop = true;
            panel11.Anchor = AnchorStyles.Top;
            panel11.BackgroundImageLayout = ImageLayout.Zoom;
            panel11.BorderStyle = BorderStyle.Fixed3D;
            panel11.Location = new Point(743, 297);
            panel11.Name = "panel11";
            panel11.Size = new Size(62, 53);
            panel11.TabIndex = 13;
            panel11.BackgroundImageChanged += panel11_BackgroundImageChanged;
            panel11.DragDrop += panel_DragDrop;
            panel11.DragEnter += picture_DragEnter;
            // 
            // panel12
            // 
            panel12.AllowDrop = true;
            panel12.Anchor = AnchorStyles.Top;
            panel12.BackgroundImageLayout = ImageLayout.Zoom;
            panel12.BorderStyle = BorderStyle.Fixed3D;
            panel12.Location = new Point(743, 364);
            panel12.Name = "panel12";
            panel12.Size = new Size(62, 53);
            panel12.TabIndex = 13;
            panel12.BackgroundImageChanged += panel12_BackgroundImageChanged;
            panel12.DragDrop += panel_DragDrop;
            panel12.DragEnter += picture_DragEnter;
            // 
            // panel13
            // 
            panel13.AllowDrop = true;
            panel13.Anchor = AnchorStyles.Top;
            panel13.BackgroundImageLayout = ImageLayout.Zoom;
            panel13.BorderStyle = BorderStyle.Fixed3D;
            panel13.Location = new Point(743, 431);
            panel13.Name = "panel13";
            panel13.Size = new Size(62, 53);
            panel13.TabIndex = 14;
            panel13.BackgroundImageChanged += panel13_BackgroundImageChanged;
            panel13.DragDrop += panel_DragDrop;
            panel13.DragEnter += picture_DragEnter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 191);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(526, 15);
            label2.TabIndex = 12;
            label2.Text = ".............................................................................................................................................................................";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 258);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(526, 15);
            label3.TabIndex = 12;
            label3.Text = ".............................................................................................................................................................................";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 325);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(526, 15);
            label4.TabIndex = 12;
            label4.Text = ".............................................................................................................................................................................";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 392);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(526, 15);
            label5.TabIndex = 12;
            label5.Text = ".............................................................................................................................................................................";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 459);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(526, 15);
            label6.TabIndex = 12;
            label6.Text = ".............................................................................................................................................................................";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 526);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(526, 15);
            label7.TabIndex = 12;
            label7.Text = ".............................................................................................................................................................................";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(813, 134);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(526, 15);
            label8.TabIndex = 12;
            label8.Text = ".............................................................................................................................................................................";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Location = new Point(813, 201);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(526, 15);
            label9.TabIndex = 12;
            label9.Text = ".............................................................................................................................................................................";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(813, 268);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(526, 15);
            label10.TabIndex = 12;
            label10.Text = ".............................................................................................................................................................................";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Location = new Point(813, 335);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(526, 15);
            label11.TabIndex = 12;
            label11.Text = ".............................................................................................................................................................................";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Location = new Point(813, 469);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.No;
            label13.Size = new Size(526, 15);
            label13.TabIndex = 12;
            label13.Text = ".............................................................................................................................................................................";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Location = new Point(813, 402);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(526, 15);
            label12.TabIndex = 12;
            label12.Text = ".............................................................................................................................................................................";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormEslestir
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 229, 174);
            ClientSize = new Size(1491, 900);
            Controls.Add(btnKucult);
            Controls.Add(btnKapat);
            Controls.Add(lblFormBaslik);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel13);
            Controls.Add(panel2);
            Controls.Add(panel12);
            Controls.Add(panel4);
            Controls.Add(panel11);
            Controls.Add(panel5);
            Controls.Add(panel10);
            Controls.Add(panel3);
            Controls.Add(panel9);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(label12);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label13);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label11);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEslestir";
            Text = "FormEslestir";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Panel panel2;
        private RoundedButton lblFormBaslik;
        private RoundedButton btnKucult;
        private RoundedButton btnKapat;
        private Panel panel5;
        private Panel panel6;
        private Panel panel3;
        private Panel panel4;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label12;
    }
}