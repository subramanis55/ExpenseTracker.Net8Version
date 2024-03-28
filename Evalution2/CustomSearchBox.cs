using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class CustomSearchBox : UserControl
    {
        public event EventHandler Textchanged;     

        private bool isUnderLine = false;
        private int borderSize = 3;
        private Color borderColor = Color.Black;

        public Font Font
        {
            get { return textBox.Font; }
            set { textBox.Font = value; }
        }
        public string PlaceholderText
        {
            get { return textBox.PlaceHolderText; }
            set
            {
                textBox.PlaceHolderText = value;
                Invalidate();
            }
        }
        public bool IsUnderLine
        {
            get { return isUnderLine; }
            set
            {
                isUnderLine = value;
                Invalidate();
            }
        }
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                //// if(borderSize<value)
                // Padding = new Padding(borderSize + 3);
                borderSize = value;
                Invalidate();
            }
        }
        //public bool IsSearchIconVisible{
        //  get{
        //       return  searchIconPB.Visible;
        //  }
        //  set{
        //        searchIconPB.Visible = value;
        //  }
        //}
        public CustomSearchBox()
        {
            InitializeComponent();
            Load += CustomSearchBoxLoad;
            textBox.GotFocus += TextBoxGotFocus;
            textBox.LostFocus +=TextBoxLostFocus;
            textBox.TextChanged += TextBoxTextChanged;
        }

        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            Textchanged?.Invoke(this, e);
        }

        private void TextBoxLostFocus(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void TextBoxGotFocus(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void CustomSearchBoxLoad(object sender, EventArgs e)
        {
            textBox.ForeColor = Color.FromArgb(97,97,97);
        }

      

        public GraphicsPath GetPath(Rectangle rec)
        {
            GraphicsPath g = new GraphicsPath();
            g.StartFigure();
            /* g.AddArc(rec.X, rec.Height - borderRadius * 2, rec.Height- borderRadius *2, rec.Height - borderRadius *2, 90, 180);
            g.AddArc(rec.Width - borderRadius*2, rec.Y, rec.Height - borderRadius *2, rec.Height - borderRadius *2, 270, 180);*/
            g.AddArc(rec.X, rec.Y, 12, 12, 180, 90);
            g.AddArc(rec.Width - 12 - 3, rec.Y, 12, 12, 270, 90);
            g.AddArc(rec.Width - 12 - 3, rec.Height - 12 - 3, 12, 12, 0, 90);
            g.AddArc(rec.X, rec.Height - 12 - 3, 12, 12, 90, 90);
            g.CloseFigure();
            return g;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
    
                base.DoubleBuffered = true;
                base.OnPaint(e);
                GraphicsPath path = GetPath(ClientRectangle);
                this.Region = new Region(path);
                var eg = e.Graphics;
                eg.SmoothingMode = SmoothingMode.AntiAlias;
            //  using (SolidBrush brush = new SolidBrush(BackColor))
            // {
            //eg.FillPath(brush, path);
            // }
            if (textBox.Focused)
            {
                if (isUnderLine == false)
                {

                    using (Pen Drawpen = new Pen(BorderColor, BorderSize))
                    {
                        eg.DrawPath(Drawpen, path);
                    }
                }
                else
                {
                    using (Pen Drawpen = new Pen(BorderColor, BorderSize))
                    {
                        eg.DrawLine(Drawpen, new Point(1, Height - BorderSize), new Point(Width - 1, Height - BorderSize));
                    }
                }
            }
            else{
                if (isUnderLine == false)
                {

                    using (Pen Drawpen = new Pen(Color.Gray, BorderSize))
                    {
                        eg.DrawPath(Drawpen, path);
                    }
                }
                else
                {
                    using (Pen Drawpen = new Pen(Color.Gray, BorderSize))
                    {
                        eg.DrawLine(Drawpen, new Point(1, Height - BorderSize), new Point(Width - 1, Height - BorderSize));
                    }
                }
            }    
        }

        private void SearchBoxEnter(object sender, EventArgs e)
        {
           BorderSize = 6;
        }
    }
}
