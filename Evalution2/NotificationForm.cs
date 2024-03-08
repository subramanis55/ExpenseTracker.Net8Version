using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ExpenseTracker
{
    public partial class NotificationForm : Form
    {
        Dictionary<NotificationType, Image> IconList = new Dictionary<NotificationType, Image>();
        static private int borderRadius = 1;
        private NotificationType notifyType;
        Timer timer = new Timer();
        public event EventHandler OnEnd;
        public Color IncreasePanelColor
        {
            get
            {
                return IncreaseingP.BackColor;
            }
            set
            {
                IncreaseingP.BackColor = value;
            }
        }
        public Color NotificationFormTopPanelColor
        {
            get
            {
                return NotificationFormTopP.BackColor;
            }
            set
            {
                NotificationFormTopP.BackColor = value;
            }
        }
        public string MessageText
        {
            set
            {

                MessageLB.Text = value;
            }
            get
            {
                return MessageLB.Text;
            }
        }
        public string NotificationTypeText
        {
            set
            {
                NotificationTypeLB.Text = value;
            }
            get
            {
                return NotificationTypeLB.Text;
            }
        }
       static public int BorderRadius
        {
            set
            {
                if (value < 1)
                {
                    borderRadius = 1;
                }
                else
                {
                    borderRadius = value;
                }              
            }
            get
            {
                return borderRadius;
            }
        }
        public NotificationType NotifyType
        {
            get
            {
                return notifyType;
            }

            set
            {
                notifyType = value;

            }
        }

        public NotificationForm()
        {
            InitializeComponent();
            Invalidate();

        }
        public NotificationForm(string message, NotificationType type)
        {
            InitializeComponent();
            Invalidate();
            MessageLB.TextChanged += MessageLBTextChanged;
            CancelBtn.Click += CancelBtnOnClick;
            MessageText = message;
            NotifyType = type;
            
           
         
        }

        private void MessageLBTextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            var g = CreateGraphics();
            SizeF a = g.MeasureString(control.Text, control.Font);
            MessageLB.Size = new Size((int)a.Width + 3,(int) a.Height + 3);
        }

        public void StringFormatChange(string str, int width, Font font)
        {
            int lineCharCount;
            Graphics g = CreateGraphics();
            string temp = "";
            string formatedstring = "";
            for (lineCharCount = 0; lineCharCount < str.Length; lineCharCount++)
            {
                if (g.MeasureString(temp, font).Width < width)
                {
                    temp = temp + str[lineCharCount];
                    lineCharCount++;

                }
                else
                    break;
            }
            string[] s = str.Split(' ');
            for(int i=0;i<s.Length;){
                if ((temp.Length+ s[i].Length+1)<= lineCharCount)                    //+1 for bracket
                {             
                    temp = temp + " " + s[i];
                }                
                else{
                if(s[i].Length>lineCharCount){
                        temp = temp+" "+ s[i].Substring(0, lineCharCount - temp.Length - 1);
                        s[i] = s[i].Substring(lineCharCount - temp.Length - 1);                                                           //-1 for bracket
                }
                    formatedstring=formatedstring+ "\n" + temp;
                    temp="";
                }   
                if(temp!=""){
                    formatedstring = formatedstring + "\n" + temp;
                }
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            IconList.Add(NotificationType.Success, Properties.Resources.SuccessIcon);
            IconList.Add(NotificationType.Information, Properties.Resources.InformationIcon);
            IconList.Add(NotificationType.Error, Properties.Resources.ErrorIcon);
            IconList.Add(NotificationType.Warning, Properties.Resources.WarningIcon);
            NotificationTypeSet();
            timer.Interval = 20;
            timer.Tick += IncreatePanelAnimation;
            timer.Start();
            this.Invalidate();
        }

        private void IncreatePanelAnimation(object sender, EventArgs args)
        {
            if (IncreaseingP.Width > Width)
            {
                if (this.Opacity > 0.01)
                    this.Opacity -= 0.02;
                else
                {
                    timer.Stop();
                    OnEnd?.Invoke(this, args);
                }
            }
            else
            {
                IncreaseingP.Width = IncreaseingP.Width + 2;
                
                    this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();

            var rect = this.ClientRectangle;
            var radius = BorderRadius;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            //path.StartFigure();
            //path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            //path.AddArc(ClientRectangle.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            //path.AddArc(ClientRectangle.Width - borderRadius, ClientRectangle.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            //path.AddArc(0, ClientRectangle.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            //path.CloseFigure();

            this.Region = new Region(path);
        }
        public void NotificationTypeSet()
        {
            switch (notifyType)
            {
                case NotificationType.Success:
                    NotificationFormTopPanelColor = Color.FromArgb(105, 195, 59);
                    NotificationTypeText = "Success";
                    IncreaseingP.BackColor = Color.FromArgb(105, 195, 59);
                    IconPB.Image = IconList[NotificationType.Success];
                    break;
                case NotificationType.Error:
                    NotificationFormTopPanelColor = Color.FromArgb(255, 87, 57);
                    NotificationTypeText = "Error";
                    IncreasePanelColor = Color.FromArgb(255, 87, 57);
                    IconPB.Image = IconList[NotificationType.Error];
                    break;
                case NotificationType.Information:
                    NotificationFormTopPanelColor = Color.FromArgb(75, 155, 255);
                    NotificationTypeText = "Information";
                    IncreasePanelColor = Color.FromArgb(75, 155, 255);
                    IconPB.Image = IconList[NotificationType.Information];
                    break;
                case NotificationType.Warning:
                    NotificationFormTopPanelColor = Color.FromArgb(255, 204, 0);
                    NotificationTypeText = "Warning";
                    IncreasePanelColor = Color.FromArgb(255, 204, 0);
                    IconPB.Image = IconList[NotificationType.Warning];
                    break;
                default:
                    NotificationTypeText = "Information";
                    IconP.Visible = false;
                    break;
            }
        }

        private void CancelBtnOnClick(object sender, EventArgs args)
        {
            Control control = (Control)sender;
            OnEnd?.Invoke(this, args);
        }
    }
}
