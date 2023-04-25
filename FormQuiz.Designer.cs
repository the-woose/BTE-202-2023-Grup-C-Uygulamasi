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
            lblBaslik = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            radioButton1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.DarkTurquoise;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMin.ForeColor = Color.White;
            btnMin.Location = new Point(958, 14);
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
            btnExit.Location = new Point(1018, 14);
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
            // lblBaslik
            // 
            lblBaslik.Dock = DockStyle.Top;
            lblBaslik.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblBaslik.Location = new Point(0, 0);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(1082, 80);
            lblBaslik.TabIndex = 8;
            lblBaslik.Text = "Quiz";
            lblBaslik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Image20230424222529;
            pictureBox1.Location = new Point(400, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(116, 17);
            label1.Name = "label1";
            label1.Size = new Size(731, 32);
            label1.TabIndex = 10;
            label1.Text = "Hayvan hücresi hakkında aşağıda verilenlerden hangileri doğrudur?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(13, 13);
            label2.Name = "label2";
            label2.Size = new Size(97, 37);
            label2.TabIndex = 11;
            label2.Text = "SORU:";
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 458);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 304);
            panel1.TabIndex = 12;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(57, 70);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(171, 36);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // FormQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 762);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnMin);
            Controls.Add(btnExit);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormQuiz";
            Text = "FormQuiz";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMin;
        private Button btnExit;
        private Label lblBaslik;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private RadioButton radioButton1;
    }
}