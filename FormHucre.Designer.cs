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
            lblBaslik = new Label();
            btnExit = new Button();
            btnMin = new Button();
            textSoru = new TextBox();
            textCevap = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.Dock = DockStyle.Top;
            lblBaslik.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblBaslik.Location = new Point(0, 0);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(1486, 76);
            lblBaslik.TabIndex = 9;
            lblBaslik.Text = "Hayvan ve Bitki Hücreleri";
            lblBaslik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1422, 14);
            btnExit.Margin = new Padding(5);
            btnExit.MaximumSize = new Size(50, 50);
            btnExit.MinimumSize = new Size(50, 50);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 11;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.DarkTurquoise;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMin.ForeColor = Color.White;
            btnMin.Location = new Point(1362, 14);
            btnMin.Margin = new Padding(5);
            btnMin.MaximumSize = new Size(50, 50);
            btnMin.MinimumSize = new Size(50, 50);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(50, 50);
            btnMin.TabIndex = 12;
            btnMin.Text = "__";
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // textSoru
            // 
            textSoru.Location = new Point(32, 265);
            textSoru.Multiline = true;
            textSoru.Name = "textSoru";
            textSoru.Size = new Size(415, 133);
            textSoru.TabIndex = 13;
            textSoru.Text = "Soru";
            // 
            // textCevap
            // 
            textCevap.Location = new Point(32, 404);
            textCevap.Multiline = true;
            textCevap.Name = "textCevap";
            textCevap.Size = new Size(415, 110);
            textCevap.TabIndex = 13;
            textCevap.Text = "Cevap";
            // 
            // button1
            // 
            button1.Location = new Point(32, 216);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "SoruGetir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormHucre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 801);
            Controls.Add(button1);
            Controls.Add(textCevap);
            Controls.Add(textSoru);
            Controls.Add(btnExit);
            Controls.Add(btnMin);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHucre";
            Text = "FormHucre";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Button btnExit;
        private Button btnMin;
        private TextBox textSoru;
        private TextBox textCevap;
        private Button button1;
    }
}