using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
   
    public partial class LoginForm : Form
    {
        private LoginpageU loginPageU=new LoginpageU() { Dock=DockStyle.Fill};
        private SignPageU signPageU=new SignPageU() { Dock=DockStyle.Fill };
        private ForgetPasswordU forgetPasswordU=new ForgetPasswordU() { Dock=DockStyle.Fill };
        public LoginForm()
        {
            InitializeComponent();
            
            loginPageU.OnForgetPasswordLinkLabelClick += LoginpageUOnForgetPasswordLinkLabelClick;
            loginPageU.OnLoginBtnClick += LoginpageUOnLoginBtnClick;
            loginPageU.OnSignUpLinkLabelClick += LoginpageUOnSignUpLinkLabelClick;
            signPageU.OnLoginLinkClick += SignPageUOnLoginLinkClick;
            signPageU.OnSignUpBtnClick += SignPageUOnSignUpBtnClick;
            mainP.Controls.Add(loginPageU);
            loginBackgorundMovingU1.OnMoveEnd += LoginBackgorundMovingU1_OnMoveEnd;
            forgetPasswordU.OnLoginLinkClick += ForgetPasswordUOnLoginLinkClick;
            forgetPasswordU.OnSubmitBtnClick += ForgetPasswordUOnSubmitBtnClick;
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.SetProperty | BindingFlags.Instance, null, mainP, new object[] { true });

    }

        private void ForgetPasswordUOnSubmitBtnClick(object sender, EventArgs e)
        {
            loginBackgorundMovingU1.Visible = true;
            mainP.Controls.Remove(forgetPasswordU);
            loginBackgorundMovingU1.Direction = MoveDirection.MiddleRight;
        }

        private void ForgetPasswordUOnLoginLinkClick(object sender, EventArgs e)
        {
            loginBackgorundMovingU1.Visible = true;
            mainP.Controls.Remove(forgetPasswordU);
            loginBackgorundMovingU1.Direction = MoveDirection.MiddleRight;
        }

        private void LoginBackgorundMovingU1_OnMoveEnd(object sender, EventArgs e)
        {
           if(loginBackgorundMovingU1.Direction == MoveDirection.Left)
            {
                loginBackgorundMovingU1.Visible = false;
                mainP.Controls.Add(signPageU);
            }
           else if (loginBackgorundMovingU1.Direction == MoveDirection.Right)
            {
                loginBackgorundMovingU1.Visible = false;
                mainP.Controls.Add(loginPageU);
            }
           else if(loginBackgorundMovingU1.Direction == MoveDirection.Middle)
            {
                loginBackgorundMovingU1.Visible = false;
                mainP.Controls.Add(forgetPasswordU);
            }
           else if(loginBackgorundMovingU1.Direction == MoveDirection.MiddleRight)
            {
                loginBackgorundMovingU1.Visible = false;
                mainP.Controls.Add(loginPageU);
            }
        }

        private void SignPageUOnSignUpBtnClick(object sender, EventArgs e)
        {
            loginBackgorundMovingU1.Visible = true;
            mainP.Controls.Remove(signPageU);
            loginBackgorundMovingU1.Direction = MoveDirection.Right;
        }

        private void SignPageUOnLoginLinkClick(object sender, EventArgs e)
        {
            loginBackgorundMovingU1.Visible = true;
            mainP.Controls.Remove(signPageU);
            loginBackgorundMovingU1.Direction = MoveDirection.Right;
        }

        private void LoginpageUOnSignUpLinkLabelClick(object sender, EventArgs e)
        {
            loginBackgorundMovingU1.Visible = true;
            mainP.Controls.Remove(loginPageU);
            loginBackgorundMovingU1.Direction = MoveDirection.Left;
        }

        private void LoginpageUOnLoginBtnClick(object sender, EventArgs e)
        {
            
                Form1 form1 = new Form1();
                form1.Show();
            this.Hide();
           // this.Close();
            
           
        }

        private void LoginpageUOnForgetPasswordLinkLabelClick(object sender, EventArgs e)
        {
            loginBackgorundMovingU1.Visible = true;
            mainP.Controls.Remove(loginPageU);
            loginBackgorundMovingU1.Direction = MoveDirection.Middle;
        }
    }
}
