namespace ExpenseTracker
{
    partial class LoginpageU
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginLeftSidePB = new System.Windows.Forms.PictureBox();
            this.leftP = new ExpenseTracker.CustomPanel();
            this.loginPageP = new ExpenseTracker.CustomPanel();
            this.signPageP = new System.Windows.Forms.Panel();
            this.signUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.forgetpasswordP = new System.Windows.Forms.Panel();
            this.forgetPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginBtnP = new System.Windows.Forms.Panel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordP = new System.Windows.Forms.Panel();
            this.usernameP = new System.Windows.Forms.Panel();
            this.usernameTB = new ExpenseTracker.TextBoxU();
            this.userImageP = new System.Windows.Forms.Panel();
            this.userImagePB = new System.Windows.Forms.PictureBox();
            this.passwordTB = new ExpenseTracker.TextBoxU();
            ((System.ComponentModel.ISupportInitialize)(this.loginLeftSidePB)).BeginInit();
            this.leftP.SuspendLayout();
            this.loginPageP.SuspendLayout();
            this.signPageP.SuspendLayout();
            this.forgetpasswordP.SuspendLayout();
            this.loginBtnP.SuspendLayout();
            this.passwordP.SuspendLayout();
            this.usernameP.SuspendLayout();
            this.userImageP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLeftSidePB
            // 
            this.loginLeftSidePB.BackColor = System.Drawing.Color.Teal;
            this.loginLeftSidePB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginLeftSidePB.Location = new System.Drawing.Point(10, 10);
            this.loginLeftSidePB.Name = "loginLeftSidePB";
            this.loginLeftSidePB.Size = new System.Drawing.Size(837, 469);
            this.loginLeftSidePB.TabIndex = 0;
            this.loginLeftSidePB.TabStop = false;
            // 
            // leftP
            // 
            this.leftP.AllBorderRadius = 60;
            this.leftP.BackColor = System.Drawing.Color.White;
            this.leftP.BorderColor = System.Drawing.Color.Transparent;
            this.leftP.BorderMarginSize = 0;
            this.leftP.BottomLeftRadius = 60;
            this.leftP.BottomRight = 60;
            this.leftP.Controls.Add(this.loginPageP);
            this.leftP.Dock = System.Windows.Forms.DockStyle.Right;
            this.leftP.Location = new System.Drawing.Point(436, 10);
            this.leftP.Name = "leftP";
            this.leftP.Size = new System.Drawing.Size(411, 469);
            this.leftP.TabIndex = 2;
            this.leftP.TopLeftRadius = 60;
            this.leftP.TopRightRadius = 60;
            this.leftP.Paint += new System.Windows.Forms.PaintEventHandler(this.leftP_Paint);
            // 
            // loginPageP
            // 
            this.loginPageP.AllBorderRadius = 1;
            this.loginPageP.BackColor = System.Drawing.Color.White;
            this.loginPageP.BorderColor = System.Drawing.Color.Transparent;
            this.loginPageP.BorderMarginSize = 0;
            this.loginPageP.BottomLeftRadius = 1;
            this.loginPageP.BottomRight = 1;
            this.loginPageP.Controls.Add(this.signPageP);
            this.loginPageP.Controls.Add(this.forgetpasswordP);
            this.loginPageP.Controls.Add(this.loginBtnP);
            this.loginPageP.Controls.Add(this.passwordP);
            this.loginPageP.Controls.Add(this.usernameP);
            this.loginPageP.Controls.Add(this.userImageP);
            this.loginPageP.Location = new System.Drawing.Point(19, 22);
            this.loginPageP.Name = "loginPageP";
            this.loginPageP.Size = new System.Drawing.Size(342, 434);
            this.loginPageP.TabIndex = 0;
            this.loginPageP.TopLeftRadius = 1;
            this.loginPageP.TopRightRadius = 1;
            this.loginPageP.Resize += new System.EventHandler(this.LoginpageUResize);
            // 
            // signPageP
            // 
            this.signPageP.Controls.Add(this.signUpLinkLabel);
            this.signPageP.Dock = System.Windows.Forms.DockStyle.Top;
            this.signPageP.Location = new System.Drawing.Point(0, 377);
            this.signPageP.Name = "signPageP";
            this.signPageP.Size = new System.Drawing.Size(342, 50);
            this.signPageP.TabIndex = 7;
            // 
            // signUpLinkLabel
            // 
            this.signUpLinkLabel.AutoSize = true;
            this.signUpLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLinkLabel.Location = new System.Drawing.Point(150, 17);
            this.signUpLinkLabel.Name = "signUpLinkLabel";
            this.signUpLinkLabel.Size = new System.Drawing.Size(69, 22);
            this.signUpLinkLabel.TabIndex = 5;
            this.signUpLinkLabel.TabStop = true;
            this.signUpLinkLabel.Text = "SignUp";
            this.signUpLinkLabel.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // forgetpasswordP
            // 
            this.forgetpasswordP.Controls.Add(this.forgetPasswordLinkLabel);
            this.forgetpasswordP.Dock = System.Windows.Forms.DockStyle.Top;
            this.forgetpasswordP.Location = new System.Drawing.Point(0, 330);
            this.forgetpasswordP.Name = "forgetpasswordP";
            this.forgetpasswordP.Size = new System.Drawing.Size(342, 47);
            this.forgetpasswordP.TabIndex = 6;
            // 
            // forgetPasswordLinkLabel
            // 
            this.forgetPasswordLinkLabel.AutoSize = true;
            this.forgetPasswordLinkLabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetPasswordLinkLabel.Location = new System.Drawing.Point(115, 14);
            this.forgetPasswordLinkLabel.Name = "forgetPasswordLinkLabel";
            this.forgetPasswordLinkLabel.Size = new System.Drawing.Size(148, 23);
            this.forgetPasswordLinkLabel.TabIndex = 4;
            this.forgetPasswordLinkLabel.TabStop = true;
            this.forgetPasswordLinkLabel.Text = "Forget Password ?";
            this.forgetPasswordLinkLabel.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // loginBtnP
            // 
            this.loginBtnP.Controls.Add(this.loginBtn);
            this.loginBtnP.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginBtnP.Location = new System.Drawing.Point(0, 242);
            this.loginBtnP.MinimumSize = new System.Drawing.Size(0, 77);
            this.loginBtnP.Name = "loginBtnP";
            this.loginBtnP.Size = new System.Drawing.Size(342, 88);
            this.loginBtnP.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Teal;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(89, 32);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(150, 35);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            // 
            // passwordP
            // 
            this.passwordP.Controls.Add(this.passwordTB);
            this.passwordP.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordP.Location = new System.Drawing.Point(0, 166);
            this.passwordP.Name = "passwordP";
            this.passwordP.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.passwordP.Size = new System.Drawing.Size(342, 76);
            this.passwordP.TabIndex = 2;
            // 
            // usernameP
            // 
            this.usernameP.Controls.Add(this.usernameTB);
            this.usernameP.Dock = System.Windows.Forms.DockStyle.Top;
            this.usernameP.Location = new System.Drawing.Point(0, 90);
            this.usernameP.Name = "usernameP";
            this.usernameP.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.usernameP.Size = new System.Drawing.Size(342, 76);
            this.usernameP.TabIndex = 1;
            // 
            // usernameTB
            // 
            this.usernameTB.BackColor = System.Drawing.Color.White;
            this.usernameTB.BorderRadius = 1;
            this.usernameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTB.IsPlaceholder = true;
            this.usernameTB.Location = new System.Drawing.Point(30, 10);
            this.usernameTB.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTB.Multiline = false;
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Padding = new System.Windows.Forms.Padding(18, 20, 8, 6);
            this.usernameTB.PasswordChar = '\0';
            this.usernameTB.PlaceholderFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.usernameTB.PlaceholderLabelAtCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.usernameTB.PlaceholderLabelAtTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(225)))));
            this.usernameTB.PlaceholderText = "Username";
            this.usernameTB.PlaceholderTextCenterFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.usernameTB.PlaceholderTextTopFont = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTB.Size = new System.Drawing.Size(282, 54);
            this.usernameTB.TabIndex = 0;
            this.usernameTB.TabStop = false;
            this.usernameTB.TextBoxDock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTB.TextBoxFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTB.TextBoxtext = "";
            this.usernameTB.UseSystemPasswordChar = false;
            // 
            // userImageP
            // 
            this.userImageP.Controls.Add(this.userImagePB);
            this.userImageP.Dock = System.Windows.Forms.DockStyle.Top;
            this.userImageP.Location = new System.Drawing.Point(0, 0);
            this.userImageP.Name = "userImageP";
            this.userImageP.Size = new System.Drawing.Size(342, 90);
            this.userImageP.TabIndex = 0;
            // 
            // userImagePB
            // 
            this.userImagePB.Image = global::ExpenseTracker.Properties.Resources.user;
            this.userImagePB.Location = new System.Drawing.Point(146, 3);
            this.userImagePB.Name = "userImagePB";
            this.userImagePB.Size = new System.Drawing.Size(60, 51);
            this.userImagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImagePB.TabIndex = 0;
            this.userImagePB.TabStop = false;
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.White;
            this.passwordTB.BorderRadius = 1;
            this.passwordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTB.IsPlaceholder = true;
            this.passwordTB.Location = new System.Drawing.Point(30, 11);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTB.Multiline = false;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Padding = new System.Windows.Forms.Padding(18, 20, 8, 6);
            this.passwordTB.PasswordChar = '●';
            this.passwordTB.PlaceholderFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.passwordTB.PlaceholderLabelAtCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.passwordTB.PlaceholderLabelAtTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(225)))));
            this.passwordTB.PlaceholderText = "Password";
            this.passwordTB.PlaceholderTextCenterFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.passwordTB.PlaceholderTextTopFont = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Size = new System.Drawing.Size(282, 54);
            this.passwordTB.TabIndex = 1;
            this.passwordTB.TabStop = false;
            this.passwordTB.TextBoxDock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTB.TextBoxFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.TextBoxtext = "";
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // LoginpageU
            // 
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.leftP);
            this.Controls.Add(this.loginLeftSidePB);
            this.Name = "LoginpageU";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(857, 489);
            ((System.ComponentModel.ISupportInitialize)(this.loginLeftSidePB)).EndInit();
            this.leftP.ResumeLayout(false);
            this.loginPageP.ResumeLayout(false);
            this.signPageP.ResumeLayout(false);
            this.signPageP.PerformLayout();
            this.forgetpasswordP.ResumeLayout(false);
            this.forgetpasswordP.PerformLayout();
            this.loginBtnP.ResumeLayout(false);
            this.passwordP.ResumeLayout(false);
            this.usernameP.ResumeLayout(false);
            this.userImageP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userImagePB)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.PictureBox loginLeftSidePB;
        private CustomPanel loginPageP;
        private System.Windows.Forms.Panel usernameP;
        private System.Windows.Forms.Panel userImageP;
        private System.Windows.Forms.Panel loginBtnP;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel passwordP;
        private System.Windows.Forms.LinkLabel signUpLinkLabel;
        private System.Windows.Forms.LinkLabel forgetPasswordLinkLabel;
        private System.Windows.Forms.PictureBox userImagePB;
        private CustomPanel leftP;
        private System.Windows.Forms.Panel signPageP;
        private System.Windows.Forms.Panel forgetpasswordP;
        private TextBoxU usernameTB;
        private TextBoxU passwordTB;
    }
}
