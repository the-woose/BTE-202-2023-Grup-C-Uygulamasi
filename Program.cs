using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Security.Permissions;
using System.Windows.Forms.Design;

namespace BTE_202___2023_Grup_C_Uygulaması
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }
    }

    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(System.ComponentModel.Design.IDesigner))]
    public class RoundedButton : Button
    {
        private int nRadius = 20;

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [Description("Text for User Control"), Category("Data")]
        public string ControlText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public int Radius
        {
            get { return nRadius; }
            set { nRadius = value; }
        }



        private System.Drawing.Color borderColor = System.Drawing.Color.Red;

        public System.Drawing.Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; }
        }

        private System.Drawing.Color fillColor = System.Drawing.Color.White;

        public System.Drawing.Color FillColor
        {
            get { return fillColor; }
            set { fillColor = value; }
        }

        private System.Drawing.Color oldFillColor;

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            oldFillColor = FillColor;
            FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            FillColor = oldFillColor;
            this.Invalidate();
        }

        private int nBorderSize = 2;

        public int BorderSize
        {
            get { return nBorderSize; }
            set { nBorderSize = value; }
        }

        public RoundedButton()
        {
        }

        public RoundedButton(int nRadius = 20, Color? fillColor = null, Color? borderColor = null, int borderSize = 4)
            : this()
        {
            Radius = nRadius;
            FillColor = fillColor ?? Color.White;
            BorderColor = borderColor ?? Color.Red;
            BorderSize = borderSize;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;



            nRadius = Math.Min(nRadius, Height - BorderSize * 2);
            Rectangle rect = new Rectangle(BorderSize, BorderSize, Width - BorderSize * 2, Height - BorderSize * 2);
            using (GraphicsPath gp = CreatePath(rect, nRadius, false))
            {
                Pen pen = new Pen(BorderColor, BorderSize);
                pen.LineJoin = LineJoin.Round;
                e.Graphics.FillPath(new SolidBrush(FillColor), gp);
                e.Graphics.DrawPath(pen, gp);
            }

            Size textSize = TextRenderer.MeasureText(this.ControlText, this.Font);
            var nWidth = ((this.Width - textSize.Width) / 2);
            var nHeight = ((this.Height - textSize.Height) / 2);
            Point drawPoint = new Point(nWidth, nHeight);
            Rectangle normalRect = new Rectangle(drawPoint, textSize);
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, normalRect, ForeColor);
        }

        public static GraphicsPath CreatePath(Rectangle rect, int nRadius, bool bOutline)
        {
            int nShift = bOutline ? 1 : 0;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X + nShift, rect.Y, nRadius, nRadius, 180f, 90f);
            path.AddArc((rect.Right - nRadius) - nShift, rect.Y, nRadius, nRadius, 270f, 90f);
            path.AddArc((rect.Right - nRadius) - nShift, (rect.Bottom - nRadius) - nShift, nRadius, nRadius, 0f, 90f);
            path.AddArc(rect.X + nShift, (rect.Bottom - nRadius) - nShift, nRadius, nRadius, 90f, 90f);
            path.CloseFigure();
            return path;
        }
    }
}