using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ExpenseTracker
{
    public partial class ForgetPasswordU : UserControl
    {
        public event EventHandler OnLoginLinkClick;
        public event EventHandler OnSubmitBtnClick;
        public ForgetPasswordU()
        {
            InitializeComponent();
            this.Resize += ForgetPasswordUResize;
            submitBtn.Click += SubmitBtnClick;
            loginLinkLabel.Click += LoginLinkLabelClick;
            PasswordShowCB.CheckedChanged += PasswordShowCBCheckedChanged;

        }

        private void LoginLinkLabelClick(object sender, EventArgs e)
        {
            OnLoginLinkClick?.Invoke(this, e);
        }
        private void textBoxClear()
        {
            usernameTB.Text = null;
            usernameTB.OnLostFocusMethod();
            
            newPasswordTB.Text = null;
            newPasswordTB.OnLostFocusMethod();
            confirmPasswordTB.Text = null;
            confirmPasswordTB.OnLostFocusMethod();
        }

        private void SubmitBtnClick(object sender, EventArgs e)
        {
            DataTable dt = ExpenseManager.LoginInformationSource();
            if (confirmPasswordTB.Text != newPasswordTB.Text)
            {
                Form1.notificationThrowManager.CreateNotification("Password Miss Match",NotificationType.Error);
                textBoxClear();

            }
            else if (dt.Rows[0][0].ToString() != usernameTB.Text)
            {
                Form1.notificationThrowManager.CreateNotification("Username Invalid", NotificationType.Error);
                textBoxClear();
            }
            else if ("" == usernameTB.Text || newPasswordTB.Text == "" || confirmPasswordTB.Text == "" || usernameTB.isPlaceholder || newPasswordTB.isPlaceholder || confirmPasswordTB.isPlaceholder)
            {
                Form1.notificationThrowManager.CreateNotification("Enter the Username and Password", NotificationType.Information);
            }
            else
            {
                ExpenseManager.LoginPasswordChange(usernameTB.Text, newPasswordTB.Text);
                Form1.notificationThrowManager.CreateNotification("Password Changed", NotificationType.Success);
                OnSubmitBtnClick?.Invoke(sender, e);
            }
           

        }

        private void ForgetPasswordUResize(object sender, EventArgs e)
        {
          
            loginLinkLabel.Location = new Point(linkP.Width / 2 - loginLinkLabel.Width / 2, linkP.Height - loginLinkLabel.Height - 8);
            submitBtn.Location = new Point(submitBtnP.Width / 2 - submitBtn.Width / 2, submitBtnP.Height - submitBtn.Height - 8);
            userImagePB.Location = new Point(userImageP.Width / 2 - userImagePB.Width / 2-10, 8);
            rightP.Width = Width / 4;
            leftP.Width = Width/4;
            centerP.Location = new Point(centerP.Width / 2 - centerP.Width / 2 + (centerP.Width - centerP.Width) / 2, 10);
        }
        private void PasswordShowCBCheckedChanged(object sender, EventArgs e)
        {
            if (PasswordShowCB.Checked == true)
            {
               
                    newPasswordTB.PasswordChar= '\0';
              
                confirmPasswordTB.PasswordChar = '\0';
            }
            else
            {
                if (newPasswordTB.Text != newPasswordTB.PlaceHolderText&&newPasswordTB.PlaceHolderColor!=newPasswordTB.ForeColor)
                    newPasswordTB.PasswordChar = '*';
                if (confirmPasswordTB.Text != confirmPasswordTB.PlaceHolderText && confirmPasswordTB.PlaceHolderColor != confirmPasswordTB.ForeColor)
                    confirmPasswordTB.PasswordChar = '*';
            }
        }

        private void ForgetPasswordU_Load(object sender, EventArgs e)
        {

        }
    }
}
