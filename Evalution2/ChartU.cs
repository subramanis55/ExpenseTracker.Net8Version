using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evalution2
{
    class ChartU : Control
    {
        private int numberOfItem;
        private int totalValueOfItem;
        private List<int> valuesList;
        private bool isPossible = false;
        private Color chartBarColor = Color.White;
        public List<Color> Colors = new List<Color>
{
   Color.FromArgb(0, 0, 255),           // Blue
    Color.FromArgb(255, 0, 0),          // Red
    Color.Green,          // tGreen
     Color.FromArgb(127, 0, 255),        // Violet
   Color.FromArgb(255, 255, 0),        // Gold
    Color.FromArgb(255, 140, 0),       // DarkOrange
    Color.FromArgb(0, 255, 255),        // Aqua
    Color.FromArgb(255, 255, 0),        // Yellow
     Color.FromArgb(0, 139, 139),        // DarkCyan
    Color.FromArgb(0, 0, 128),          // Navy
   Color.FromArgb(173, 255, 47),       // YellowGreen
     Color.FromArgb(255, 192, 203),      // Pink
     Color.FromArgb(255, 0, 255),        // Fuchsia
    Color.FromArgb(255, 165, 0),        // LightOrange
    Color.FromArgb(0, 255, 0),          // Lime
    Color.FromArgb(0, 255, 255),        // Cyan
    Color.FromArgb(255, 0, 255),        // Magenta
    Color.FromArgb(255, 165, 0),        // Orange 
    Color.FromArgb(127, 255, 0),        // Chartreuse
    Color.FromArgb(0, 255, 127),        // SpringGreen
    Color.FromArgb(255, 192, 203),      // LightPink 
    Color.FromArgb(255, 255, 224),      // LightYellow
    Color.FromArgb(173, 255, 47),       // GreenYellow
    Color.FromArgb(0, 250, 154),        // MediumSpringGreen
    Color.FromArgb(0, 255, 255),        // MediumAquamarine
    Color.FromArgb(0, 206, 209),        // DarkTurquoise
    Color.FromArgb(95, 158, 160),       // CadetBlue  
    Color.FromArgb(25, 25, 112),        // MidnightBlue
    Color.FromArgb(139, 0, 139),        // DarkMagenta
    Color.FromArgb(128, 0, 0),          // Maroon
   
};
        public int TotalValueOfItem
        {
            get
            {
                return totalValueOfItem;
            }
            set
            {
                totalValueOfItem = value;
                Invalidate();
            }
        }

        public Color ChartBarColor
        {
            get
            {
                return chartBarColor;
            }

            set
            {
                chartBarColor = value;
            }
        }

        public List<int> ValuesList
        {
            get
            {
                return valuesList;
            }
            set
            {
                valuesList = value;
                int total = 0;
                if (valuesList != null)
                {
                    for (int i = 0; i < valuesList.Count; i++)
                    {
                        total += valuesList[i];
                    }
                    if (valuesList.Count <= Colors.Count)
                    {
                        isPossible = true;
                    }
                    Invalidate();
                }

            }
        }

        public ChartU(List<int> values)
        {
            ValuesList = values;
        }
        public ChartU()
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            float deg = 0;
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.FillEllipse(new SolidBrush(ChartBarColor), ClientRectangle);

            Rectangle rect = new Rectangle(ClientRectangle.X + 2, ClientRectangle.Y + 2, ClientRectangle.Width - 2, ClientRectangle.Height - 2);
            if (isPossible && valuesList != null)
            {
                for (int i = 0; i < valuesList.Count && i < Colors.Count; i++)
                {
                    using (SolidBrush b = new SolidBrush(Colors[i]))
                    {
                        if (totalValueOfItem != 0)
                        {
                            float currDeg = ((float)valuesList[i] / (float)totalValueOfItem) * (float)360;
                            g.FillPie(b, rect, deg, currDeg);
                            //  g.DrawPie(new Pen(Color.White,1), ClientRectangle, deg, currDeg);
                            deg = deg + currDeg;
                        }

                    }
                }
               // g.DrawEllipse(new Pen(Color., 2), new Rectangle(ClientRectangle.X + 2, ClientRectangle.Y + 2, ClientRectangle.Width - 2, ClientRectangle.Height - 2));
            }
        }
    }
}
