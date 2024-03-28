namespace ExpenseTracker
{
    partial class LoginBackgorundMovingU
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
            this.pictureBox = new ExpenseTracker.CustomPanel();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.AllBorderRadius = 40;
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderColor = System.Drawing.Color.Transparent;
            this.pictureBox.BorderMarginSize = 0;
            this.pictureBox.BottomLeftRadius = 40;
            this.pictureBox.BottomRight = 40;
            this.pictureBox.Location = new System.Drawing.Point(294, 20);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(452, 329);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TopLeftRadius = 40;
            this.pictureBox.TopRightRadius = 40;
            // 
            // LoginBackgorundMovingU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.pictureBox);
            this.DoubleBuffered = true;
            this.Name = "LoginBackgorundMovingU";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(825, 374);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel pictureBox;
    }
}
