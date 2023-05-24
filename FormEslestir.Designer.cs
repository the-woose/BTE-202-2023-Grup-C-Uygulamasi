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
            btnMin = new Button();
            btnExit = new Button();
            lblBaslik = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.DarkTurquoise;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMin.ForeColor = Color.White;
            btnMin.Location = new Point(1367, 14);
            btnMin.Margin = new Padding(5);
            btnMin.MaximumSize = new Size(50, 50);
            btnMin.MinimumSize = new Size(50, 50);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(50, 50);
            btnMin.TabIndex = 6;
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
            btnExit.Location = new Point(1427, 14);
            btnExit.Margin = new Padding(5);
            btnExit.MaximumSize = new Size(50, 50);
            btnExit.MinimumSize = new Size(50, 50);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 5;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblBaslik
            // 
            lblBaslik.Dock = DockStyle.Top;
            lblBaslik.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblBaslik.Location = new Point(0, 0);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(1491, 76);
            lblBaslik.TabIndex = 7;
            lblBaslik.Text = "Özellikleri Eşleştir";
            lblBaslik.TextAlign = ContentAlignment.MiddleCenter;
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
            pictureBox2.Location = new Point(353, 138);
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
            label1.Location = new Point(762, 151);
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
            panel1.Location = new Point(583, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(135, 99);
            panel1.TabIndex = 13;
            panel1.DragDrop += panel_DragDrop;
            panel1.DragEnter += picture_DragEnter;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.mito3;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(353, 219);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(124, 61);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "mitokondri_02";
            pictureBox4.GiveFeedback += picture_GiveFeedback;
            pictureBox4.MouseDown += picture_MouseDown;
            pictureBox4.MouseMove += picture_MouseMove;
            // 
            // FormEslestir
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1491, 798);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnMin);
            Controls.Add(lblBaslik);
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

        private Button btnMin;
        private Button btnExit;
        private Label lblBaslik;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private PictureBox pictureBox4;
    }
}