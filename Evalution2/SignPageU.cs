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

          
            loginLinkLabel.Location = new Point(linkP.Width / 2 - loginLinkLabel.Width / 2, linkP.Height - loginLinkLabel.Height - 8);
           
            userImagePB.Location = new Point(userImageP.Width / 2 - userImagePB.Width / 2-10, 8);
            loginLeftSidePB.Width = Width / 2;
            leftP.Width = Width / 2;
            signPageP.Location = new Point(leftP.Width / 2 - signPageP.Width / 2 + (leftP.Width - signPageP.Width) / 4, 10);
        }

        private void LoginLinkLabelClick(object sender, EventArgs e)
        {
            OnLoginLinkClick?.Invoke(this, EventArgs.Empty);

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
        private void SignBtnClick(object sender, EventArgs e)
        {
            DataTable dt = ExpenseManager.LoginInformationSource();
            if (confirmPasswordTB.Text != newPasswordTB.Text)
            {
                Form1.notificationThrowManager.CreateNotification("Password Miss Match", NotificationType.Error);
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
                ExpenseManager.LoginDetailChange(usernameTB.Text, newPasswordTB.Text);
                Form1.notificationThrowManager.CreateNotification("Sign Successful", NotificationType.Success);
                OnSignUpBtnClick?.Invoke(sender, e);
            }
        }
      
        private void PasswordShowCBCheckedChanged(object sender, EventArgs e)
        {
            if (PasswordShowCB.Checked == true)
            {

                newPasswordTB.PasswordChar = '\0';

                confirmPasswordTB.PasswordChar = '\0';
            }
            else
            {
                if (newPasswordTB.Text != newPasswordTB.PlaceHolderText && newPasswordTB.PlaceHolderColor != newPasswordTB.ForeColor)
                    newPasswordTB.PasswordChar = '*';
                if (confirmPasswordTB.Text != confirmPasswordTB.PlaceHolderText && confirmPasswordTB.PlaceHolderColor != confirmPasswordTB.ForeColor)
                    confirmPasswordTB.PasswordChar = '*';
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
