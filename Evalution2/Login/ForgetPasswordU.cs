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
            newPasswordTB.Text = null;         
            confirmPasswordTB.Text = null;
          
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
            else if ("" == usernameTB.Text || newPasswordTB.Text == "" || confirmPasswordTB.Text == "" || usernameTB.IsPlaceholder || newPasswordTB.IsPlaceholder || confirmPasswordTB.IsPlaceholder)
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

            
            leftP.Width = Width / 2;
            signPageP.Height = leftP.Height - 20;
            userImageP.Height = (int)((signPageP.Height / 7) * 1.5);
            userImagePB.Height = userImageP.Height / 2 + userImageP.Height / 4;
            usernameP.Height = (int)((signPageP.Height / 7) * 1.2);
            newpasswordP.Height = (int)((signPageP.Height / 7) * 1.2);
            confirmpasswordP.Height = (int)((signPageP.Height / 7) * 1.2);
            submitBtnP.Height = (signPageP.Height / 7);
            linkP.Height = (int)((signPageP.Height / 7)*0.6);
            loginLinkLabel.Location = new Point(linkP.Width / 2 - loginLinkLabel.Width / 2 - 10, 5);
            submitBtn.Location = new Point(submitBtnP.Width / 2 - submitBtn.Width / 2 - 10, submitBtnP.Height / 2 - submitBtn.Height / 2); 
            userImagePB.Location = new Point(userImageP.Width / 2 - userImagePB.Width / 2 - 10, 8);
            userImagePB.Location = new Point(userImageP.Width / 2 - userImagePB.Width / 2 - 10, 8);
            usernameTB.Location = new Point(usernameP.Width / 2 - usernameTB.Width / 2 - 10, usernameP.Height / 2 - usernameTB.Height / 2);
            newPasswordTB.Location = new Point(newpasswordP.Width / 2 - newPasswordTB.Width / 2 - 10, newpasswordP.Height / 2 - newPasswordTB.Height / 2);
            signPageP.Location = new Point(leftP.Width / 2 - signPageP.Width / 2, 1);
            userImagePB.Location = new Point(userImageP.Width / 2 - userImagePB.Width / 2-10, 8);
            rightP.Width = Width / 4;
            leftP.Width = Width/4;
            centerP.Location = new Point(centerP.Width / 2 - centerP.Width / 2 + (centerP.Width - centerP.Width) / 2, 10);
        }
        private void PasswordShowCBCheckedChanged(object sender, EventArgs e)
        {
            if (PasswordShowCB.Checked == true)
            {
                newPasswordTB.UseSystemPasswordChar = false;
                confirmPasswordTB.UseSystemPasswordChar = false;
            }
            else
            {
                newPasswordTB.UseSystemPasswordChar = true;
                confirmPasswordTB.UseSystemPasswordChar = true;
            }
        }

        private void ForgetPasswordU_Load(object sender, EventArgs e)
        {

        }
    }
}
