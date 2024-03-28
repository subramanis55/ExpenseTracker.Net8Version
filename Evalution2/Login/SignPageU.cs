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
    public partial class SignPageU : UserControl
    {
       
        public event EventHandler OnSignUpBtnClick;
        public event EventHandler OnLoginLinkClick;
        public SignPageU()
        {
            InitializeComponent();
            PasswordShowCB.CheckedChanged += PasswordShowCBCheckedChanged;
            signUpBtn.Click += SignBtnClick;
            loginLinkLabel.Click += LoginLinkLabelClick;
            Resize += SignPageUResize;
            SignPageUResize(this,EventArgs.Empty);
            
        }

        private void SignPageUResize(object sender, EventArgs e)
        {

            signLeftSidePB.Width = Width / 2;
            leftP.Width = Width / 2;
            signPageP.Height = leftP.Height - 20;
            userImageP.Height = (int)((signPageP.Height / 7) * 1.2);
            userImagePB.Height = userImageP.Height / 2 + userImageP.Height / 4;
            usernameP.Height = (int)((signPageP.Height / 7) * 1.2);
            newpasswordP.Height = (int)((signPageP.Height / 7) * 1.2);
            confirmpasswordP.Height = (int)((signPageP.Height / 7) * 1.2);
            signBtnP.Height = (signPageP.Height / 7);
            linkP.Height = (signPageP.Height / 7);
            loginLinkLabel.Location = new Point(linkP.Width / 2 - loginLinkLabel.Width / 2 - 10, 5);
            signUpBtn.Location = new Point(signBtnP.Width / 2 - signUpBtn.Width / 2 - 10, 8);
            userImagePB.Location = new Point(userImageP.Width / 2 - userImagePB.Width / 2 - 10, 8);
            usernameTB.Location = new Point(usernameP.Width / 2 - usernameTB.Width / 2 - 10, usernameP.Height / 2 - usernameTB.Height / 2);
            newPasswordTB.Location = new Point(newpasswordP.Width / 2 - newPasswordTB.Width / 2 - 10, newpasswordP.Height / 2 - newPasswordTB.Height / 2);
            confirmPasswordTB.Location = new Point(confirmpasswordP.Width / 2 - confirmPasswordTB.Width / 2 - 10, confirmpasswordP.Height / 2 - confirmPasswordTB.Height / 2);
            signPageP.Location = new Point(leftP.Width / 2 - signPageP.Width / 2, 1);
        }

        private void LoginLinkLabelClick(object sender, EventArgs e)
        {
            OnLoginLinkClick?.Invoke(this, EventArgs.Empty);

        }
       
        private void SignBtnClick(object sender, EventArgs e)
        {
            DataTable dt = ExpenseManager.LoginInformationSource();
            if (confirmPasswordTB.Text != newPasswordTB.Text)
            {
                Form1.notificationThrowManager.CreateNotification("Password Miss Match", NotificationType.Error);
           

            }
            else if (dt.Rows[0][0].ToString() != usernameTB.Text)
            {
                Form1.notificationThrowManager.CreateNotification("Username Invalid", NotificationType.Error);
             
            }
            else if ("" == usernameTB.Text || newPasswordTB.Text == "" || confirmPasswordTB.Text == "" || usernameTB.IsPlaceholder || newPasswordTB.IsPlaceholder || confirmPasswordTB.IsPlaceholder)
            {
                Form1.notificationThrowManager.CreateNotification("Enter the Username and Password", NotificationType.Information);
             
            }
            else
            {
                ExpenseManager.LoginDetailChange(usernameTB.Text, newPasswordTB.Text);
                Form1.notificationThrowManager.CreateNotification("Sign Successful", NotificationType.Success);
                OnSignUpBtnClick?.Invoke(sender, e);
            }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
