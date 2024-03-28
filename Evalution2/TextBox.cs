
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

namespace ExpenseTracker
{
    public partial class TextBoxU : UserControl
    {
        private Font placeholderTextCenterFont = new Font(FontFamily.GenericSansSerif, 11);
        private Font placeholderTextTopFont = new Font(FontFamily.GenericSansSerif, 9,FontStyle.Bold);
        private Color placeholderLabelAtTopColor = Color.FromArgb(65, 125, 225);
        private Color placeholderLabelAtCenterColor = Color.FromArgb(130, 130, 130);
        private Timer timer=new Timer();
        private bool isPlaceholder;
        private bool isEnterMouse;
        private int borderRadius = 7;
       
        public Color PlaceholderLabelAtTopColor
        {
            get
            {
                return placeholderLabelAtTopColor;
            }
            set
            {
                placeholderLabelAtTopColor = value;
            }
        }
        public Color PlaceholderLabelAtCenterColor
        {
            get
            {
                return placeholderLabelAtCenterColor;
                
            }
            set
            {
                placeholderLabelAtCenterColor = value;
                label.ForeColor = value;
                Invalidate();
            }

        }
        public Font PlaceholderFont{
        
        set{
                label.Font = value;
        }
        get{
                return label.Font;
            }
        }
        public Font TextBoxFont
        {

            set
            {
                textBox.Font = value;
            }
            get
            {
                return textBox.Font;
            }
        }
        public bool Multiline
        {
            get
            {
                return textBox.Multiline;
               
            }
            set
            {
                textBox.Multiline = value;
                TextBoxUResize(this, EventArgs.Empty);
            }
        }
        public DockStyle TextBoxDock
        {
            get
            {
                return textBox.Dock;
            }
            set
            {
                 textBox.Dock=value;
            }
        }
        public override string Text
        {
            get
            {
                return textBox.Text;
            }
            set
            {
                textBox.Text = value;
            }
        }
        public bool UseSystemPasswordChar
        {
            get
            {
               return  textBox.UseSystemPasswordChar;

            }
            set
            {
                textBox.UseSystemPasswordChar = value;
                if(value)
                {
                    textBox.Multiline = false;
                    textBox.Dock = DockStyle.None;
                    TextBoxUResize(this, EventArgs.Empty);
                }
                else
                {
                    textBox.Multiline = true;
                    textBox.Dock = DockStyle.Fill;
                }

            }
        }
        public char PasswordChar
        {
            get
            {
                return textBox.PasswordChar;
            }
            set
            {
                textBox.PasswordChar = value;
            }
        }
        public string TextBoxtext
        {
            get
            {
                return textBox.Text;
                
            }
            set
            {
                textBox.Text = value;
                
            }
        }
        public string PlaceholderText
        {
            get
            {
                return label.Text;
            }
            set
            {

                label.Text = value;
            }
        }
        public Color ForeColor
        {
            get
            {
                return textBox.ForeColor;
            }
            set
            {
               
                textBox.ForeColor = value;
            }

        }
        public Font Font
        {
            get
            {
                return textBox.Font;

            }
            set
            {
                 textBox.Font= value;
            }
        }

        public Font PlaceholderTextCenterFont
        {
            get
            {
                return placeholderTextCenterFont;
                
            }

            set
            {
                placeholderTextCenterFont = value;
                if(isPlaceholder)
                label.Font = value;
            }
        }

        public Font PlaceholderTextTopFont
        {
            get
            {
                return placeholderTextTopFont;
            }

            set
            {
                placeholderTextTopFont = value;
                if (!isPlaceholder)
                    label.Font = value;
            }
        }

        public int BorderRadius
        {
            get
            {
                return borderRadius;
               
            }

            set
            {
                borderRadius = value;
                Invalidate();
            }
        }

        public bool IsPlaceholder
        {
            get
            {
                return isPlaceholder;
            }

            set
            {
                isPlaceholder = value;
            }
        }

        public TextBoxU()
        {
            InitializeComponent();
            textBox.MouseEnter += TextBox1MouseEnter;
            this.Resize += TextBoxUResize;
            textBox.GotFocus += TextBoxUGotFocus;
            textBox.LostFocus += TextBoxULostFocus;
            label.Click += Label1Click;
            TextBoxUResize(this, EventArgs.Empty);
            isPlaceholder = true;
            timer.Interval = 15;
            timer.Tick += PlaceholderMove;
            this.Paint += TextBoxUPaint;
            Click+= Label1Click;
        }
       
        private GraphicsPath GetGraphicsPath(Rectangle rect)
        {
           
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, borderRadius, borderRadius, 180, 90);
            path.AddArc(rect.Width - borderRadius, rect.Y, borderRadius, borderRadius, 270, 90);
            path.AddArc(rect.Width - borderRadius, rect.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(rect.X, rect.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void TextBoxUPaint(object sender, PaintEventArgs e)
        { var g= e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Color borderColor;
            if (isPlaceholder)
                 borderColor = placeholderLabelAtCenterColor;
            else
                borderColor = placeholderLabelAtTopColor;
            
            using (Pen pen=new Pen(borderColor,2))
            {
                g.DrawPath(pen,GetGraphicsPath(new Rectangle(ClientRectangle.Location.X + 3, ClientRectangle.Location.Y + 2, ClientRectangle.Width - 6, ClientRectangle.Height - 4)));
            }
        }

        private void Label1Click(object sender, EventArgs e)
        {
            if (isPlaceholder)
            {
                TextBoxUGotFocus(this,EventArgs.Empty);
               textBox.Focus();
            }
        }

        private void TextBox1MouseEnter(object sender, EventArgs e)
        {
            isEnterMouse = true;
        }

        Point placeholderlocation;
        private void PlaceholderMove(object sender, EventArgs e)
        {
            if (isPlaceholder == true&& (label.Location.X>0&& label.Location.Y>-3))
            {
                label.Location=new Point(label.Location.X-1, label.Location.Y-2);
            }
            else if(isPlaceholder == false&& (label.Location.X < placeholderlocation.X && label.Location.Y< placeholderlocation.Y)){
                label.Location = new Point(label.Location.X +1, label.Location.Y +2);
            }
            else
            {
                isPlaceholder = !isPlaceholder;
                timer.Stop();
                Invalidate();
            }
        }

        private void TextBoxULostFocus(object sender, EventArgs e)
        {
            Point temp_Point = PointToClient(Cursor.Position);
         //   if (2 > temp_Point.X || temp_Point.X >= Width-2|| 2 >temp_Point.Y || temp_Point.Y>= Height-2)
          //  {
                if (textBox.Text==""|| textBox.Text == null)
                {
                label.ForeColor = placeholderLabelAtCenterColor;
                label.Font = placeholderTextCenterFont;
                    timer.Start();
                }
          //  }
           
        }

        private void TextBoxUGotFocus(object sender, EventArgs e)
        {
            if (isPlaceholder)
            {
                label.ForeColor = placeholderLabelAtTopColor;
                label.Font = placeholderTextTopFont;
                timer.Start();
            }
           
        }

        private void TextBoxUResize(object sender, EventArgs e)
        {
            if (!textBox.UseSystemPasswordChar)
                Padding = new Padding(18, 20, Padding.Right, Padding.Bottom);
            else
                Padding = new Padding(18, 15, Padding.Right, Padding.Bottom);


            textBox.Width= Width-Padding.Left-Padding.Right;
            textBox.Location= new Point(Padding.Left,Height/2-(textBox.Height/2));
            if (!textBox.UseSystemPasswordChar)
            {
                placeholderlocation = new Point(textBox.Location.X + (textBox.Location.Y + (textBox.Height / 2 - label.Height / 2)) , 1+ Height / 2 - label.Height / 2);              
            }
            else
            {
                placeholderlocation = new Point(textBox.Location.X + (textBox.Location.Y + (textBox.Height / 2 - label.Height / 2)) , 1+ Height / 2 - label.Height / 2);              
            }
            label.Location = placeholderlocation;
        }
    }
}
