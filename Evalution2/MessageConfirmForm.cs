using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class MessageConfirmForm : Form
    {

        public EventHandler<bool> OnClickResult;
        public MessageConfirmForm()
        {
            InitializeComponent();
        }
        public MessageConfirmForm(string message)
        {
            InitializeComponent();
            messageLB.Text = message;
            this.Load += MessageConfirmFormLoad;
            closeBtn.Click += (sender, e) => { this.Dispose(); };
            messageLB.Resize += MessageLBResize;
        }

        private void MessageLBResize(object sender, EventArgs e)
        {
            messageLB.Location = new Point(this.Width / 2 - messageLB.Width / 2, messageLB.Location.Y);
        }

        private void MessageConfirmFormLoad(object sender, EventArgs e)
        {
            yesBtn.Click+= BtnClick;
            noBtn.Click += BtnClick;
            messageBoxTopP.MouseUp += MessageBoxTopPMouseUp;
            messageBoxTopP.MouseDown += MessageBoxTopPMouseDown;
            messageBoxTopP.MouseMove += MessageBoxTopPMouseMove;
            MessageLBResize(this, EventArgs.Empty);

        }
        private bool isUp = false;
        private Point prevPoint;
        private void MessageBoxTopPMouseMove(object sender, MouseEventArgs e)
        {
        if(isUp)
            {
                this.Location = new Point(Location.X+(Cursor.Position.X - prevPoint.X), Location.Y + (Cursor.Position.Y - prevPoint.Y));
                prevPoint = Cursor.Position;
            }
            
        }
        private void MessageBoxTopPMouseDown(object sender, MouseEventArgs e)
        {
            isUp = true;
            prevPoint = Cursor.Position;
        }

        private void MessageBoxTopPMouseUp(object sender, MouseEventArgs e)
        {
            isUp = false;
        }

        private void BtnClick(object sender, EventArgs e)
        {
        if(sender== yesBtn)
            OnClickResult?.Invoke(this,true);
        else{
              OnClickResult?.Invoke(this, false);
          }
        }

    }
}
