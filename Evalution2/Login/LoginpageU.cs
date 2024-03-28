using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace ExpenseTracker
{
    public partial class LoginpageU : UserControl
    {
        public event EventHandler OnForgetPasswordLinkLabelClick;
        public event EventHandler OnSignUpLinkLabelClick;
        public event EventHandler OnLoginBtnClick;
       
        public LoginpageU()
        {
            InitializeComponent();
            this.Resize += LoginpageUResize;
            forgetPasswordLinkLabel.Click += ForgetPasswordLinkLabelClick;
            signUpLinkLabel.Click += SignUpLinkLabelClick;
            loginBtn.Click += LoginBtnClick;
            LoginpageUResize(this, EventArgs.Empty);
        }
       
        private void LoginBtnClick(object sender, EventArgs e)
        {
            DataTable dt = ExpenseManager.LoginInformationSource();
           DataRow row= dt.Rows[0];
            if (""+dt.Rows[0][0] == usernameTB.Text && "" +dt.Rows[0][1] == passwordTB.Text)
            {
                OnLoginBtnClick.Invoke(this, EventArgs.Empty);
            }
            else if(""== usernameTB.Text|| passwordTB.Text == "" || usernameTB.IsPlaceholder || passwordTB.IsPlaceholder)
            {
                Form1.notificationThrowManager.CreateNotification("Enter the Username or Password", NotificationType.Information);
           
            }
            else
            {
                Form1.notificationThrowManager.CreateNotification("Username or Password Invalid",NotificationType.Error);
                passwordTB.Text = "";
                usernameTB.Text = "";
              
            }

        }

        private void SignUpLinkLabelClick(object sender, EventArgs e)
        {
            OnSignUpLinkLabelClick?.Invoke(this, EventArgs.Empty);

        }
        
        private void ForgetPasswordLinkLabelClick(object sender, EventArgs e)
        {
            OnForgetPasswordLinkLabelClick?.Invoke(this, EventArgs.Empty);
        }

        private void LoginpageUResize(object sender, EventArgs e)
        {
            loginLeftSidePB.Width = Width / 2;
            leftP.Width = Width / 2;
            loginPageP.Height = leftP.Height - 20;                    
            
            userImageP.Height = (loginPageP.Height / 7) * 2;
            userImagePB.Height = userImageP.Height / 2+ userImageP.Height / 4;
            usernameP.Height = (int)((loginPageP.Height / 7)*1.2);
            passwordP.Height= (int)((loginPageP.Height / 7) *1.2); 
            loginBtnP.Height = (loginPageP.Height / 7) ;
            forgetpasswordP.Height= (loginPageP.Height / 7)/2 ;
            signPageP.Height= (loginPageP.Height / 7) /2;
            usernameTB.Location = new Point(usernameP.Width / 2 - usernameTB.Width / 2 - 10, usernameP.Height / 2 - usernameTB.Height / 2);
            passwordTB.Location = new Point(passwordP.Width / 2 - passwordTB.Width / 2 - 10, passwordP.Height / 2 - passwordTB.Height / 2);
            forgetPasswordLinkLabel.Location = new Point(forgetpasswordP.Width / 2 - forgetPasswordLinkLabel.Width / 2-10, 8);
           signUpLinkLabel.Location = new Point(signPageP.Width / 2 - signUpLinkLabel.Width / 2-10,  5);
            loginBtn.Location = new Point(loginBtnP.Width / 2 - loginBtn.Width / 2-10, loginBtnP.Height / 2 - loginBtn.Height / 2);
            userImagePB.Location = new Point(userImageP.Width / 2 - userImagePB.Width / 2-10, 8);                          
           
            loginPageP.Location = new Point(leftP.Width / 2 - loginPageP.Width / 2 , 1);
        }

        private void leftP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginPageP_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
