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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            lblFormBaslik = new RoundedButton();
            btnKucult = new RoundedButton();
            btnKapat = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ORGANELLER_Eslestir;
            pictureBox1.Location = new Point(31, 118);
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
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(343, 118);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 61);
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
            label1.Location = new Point(881, 139);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 12;
            label1.Text = "label1";
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(523, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(104, 61);
            panel1.TabIndex = 13;
            panel1.DragDrop += panel_DragDrop;
            panel1.DragEnter += picture_DragEnter;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.mito3;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(343, 199);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(124, 61);
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
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(523, 199);
            panel2.Name = "panel2";
            panel2.Size = new Size(104, 61);
            panel2.TabIndex = 14;
            panel2.DragDrop += panel_DragDrop;
            panel2.DragEnter += picture_DragEnter;
            // 
            // panel3
            // 
            panel3.AllowDrop = true;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Location = new Point(523, 275);
            panel3.Name = "panel3";
            panel3.Size = new Size(104, 61);
            panel3.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.AllowDrop = true;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Location = new Point(523, 355);
            panel4.Name = "panel4";
            panel4.Size = new Size(104, 61);
            panel4.TabIndex = 15;
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
            // FormEslestir
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 229, 174);
            ClientSize = new Size(1491, 798);
            Controls.Add(btnKucult);
            Controls.Add(btnKapat);
            Controls.Add(lblFormBaslik);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private RoundedButton lblFormBaslik;
        private RoundedButton btnKucult;
        private RoundedButton btnKapat;
    }
}