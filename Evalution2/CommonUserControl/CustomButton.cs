using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ExpenseTracker
{
    class CustomButton : Button
    {

        private int BorderSize = 0;
        private int BorderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;
        [Category("Custem Button Properties")]
        public int BorderSize1
        {
            get
            {
                return BorderSize;
            }

            set
            {
                BorderSize = value;
                this.Invalidate();
            }
        }
        [Category("Custem Button Properties")]
        public int BorderRadius1
        {
            get
            {
                return BorderRadius;
            }

            set
            {
                if (value <= this.Height)
                    BorderRadius = value;
                else
                    BorderRadius = this.Height;
                this.Invalidate();
            }
        }
        [Category("Custem Button Properties")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Custem Button Properties")]
        public Color BackgroudColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; this.Invalidate(); }
        }
        [Category("Custem Button Properties")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; this.Invalidate(); }
        }

        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (BorderRadius > this.Height)
            {
                BorderRadius1 = this.Height;
            }
        }

        public GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            base.OnPaint(pevent);
            RectangleF recSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF recBorder = new RectangleF(1, 1, this.Width - 0.8f, this.Height - 1);
            if (BorderRadius > 2)//Rounded button
            {
                using (GraphicsPath PathSurface = GetFigurePath(recSurface, BorderRadius))
                using (GraphicsPath PathBorder = GetFigurePath(recBorder, BorderRadius - 1f))
                using (Pen PenSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, BorderSize))
                {
                    penBorder.StartCap = LineCap.Round;
                    penBorder.EndCap = LineCap.Round;
                    PenSurface.StartCap = LineCap.Round;
                    PenSurface.EndCap = LineCap.Round;
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(PathSurface);
                    pevent.Graphics.DrawPath(PenSurface, PathSurface);
                    if (BorderSize >= 1)
                    {//Draw control border
                        pevent.Graphics.DrawPath(penBorder, PathBorder);
                    }
                }
            }
            else//Normal button
            {
                this.Region = new Region(recSurface);
                if (BorderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }

                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);

        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}




    



