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
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.DarkTurquoise;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMin.ForeColor = Color.White;
            btnMin.Location = new Point(934, 14);
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
            btnExit.Location = new Point(994, 14);
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
            lblBaslik.Size = new Size(1058, 76);
            lblBaslik.TabIndex = 7;
            lblBaslik.Text = "Özellikleri Eşleştir";
            lblBaslik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ORGANELLER_Eslestir;
            pictureBox1.Location = new Point(41, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 563);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Green;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(934, 594);
            button1.Margin = new Padding(5);
            button1.MaximumSize = new Size(50, 50);
            button1.MinimumSize = new Size(50, 50);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 9;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Green;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(994, 594);
            button2.Margin = new Padding(5);
            button2.MaximumSize = new Size(50, 50);
            button2.MinimumSize = new Size(50, 50);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 10;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ORGANELLER___Kutu;
            pictureBox2.Location = new Point(210, 79);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 559);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(371, 92);
            label1.Name = "label1";
            label1.Size = new Size(1310, 32);
            label1.TabIndex = 12;
            label1.Text = "Örnek özellik yazısı. Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore.";
            // 
            // FormEslestir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 658);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMin;
        private Button btnExit;
        private Label lblBaslik;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private Label label1;
    }
}