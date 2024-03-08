namespace ExpenseTracker
{
    partial class NotificationForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NotificationFormTopP = new System.Windows.Forms.Panel();
            this.NotificationTypeLB = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CancelBtn = new ExpenseTracker.CustomButton();
            this.MainP = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.MessageLB = new System.Windows.Forms.Label();
            this.IconP = new System.Windows.Forms.Panel();
            this.IconPB = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.IncreaseingP = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NotificationFormTopP.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MainP.SuspendLayout();
            this.panel6.SuspendLayout();
            this.IconP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPB)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotificationFormTopP
            // 
            this.NotificationFormTopP.BackColor = System.Drawing.Color.Teal;
            this.NotificationFormTopP.Controls.Add(this.NotificationTypeLB);
            this.NotificationFormTopP.Controls.Add(this.panel2);
            this.NotificationFormTopP.Dock = System.Windows.Forms.DockStyle.Top;
            this.NotificationFormTopP.Location = new System.Drawing.Point(0, 0);
            this.NotificationFormTopP.Name = "NotificationFormTopP";
            this.NotificationFormTopP.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.NotificationFormTopP.Size = new System.Drawing.Size(402, 37);
            this.NotificationFormTopP.TabIndex = 0;
            // 
            // NotificationTypeLB
            // 
            this.NotificationTypeLB.AutoSize = true;
            this.NotificationTypeLB.Dock = System.Windows.Forms.DockStyle.Left;
            this.NotificationTypeLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationTypeLB.ForeColor = System.Drawing.Color.White;
            this.NotificationTypeLB.Location = new System.Drawing.Point(10, 2);
            this.NotificationTypeLB.Name = "NotificationTypeLB";
            this.NotificationTypeLB.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.NotificationTypeLB.Size = new System.Drawing.Size(59, 30);
            this.NotificationTypeLB.TabIndex = 2;
            this.NotificationTypeLB.Text = "label3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.CancelBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(365, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 33);
            this.panel2.TabIndex = 1;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(57)))));
            this.CancelBtn.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(57)))));
            this.CancelBtn.BorderColor = System.Drawing.Color.Transparent;
            this.CancelBtn.BorderRadius1 = 1;
            this.CancelBtn.BorderSize1 = 0;
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Image = global::ExpenseTracker.Properties.Resources.icons8_cancel_30;
            this.CancelBtn.Location = new System.Drawing.Point(0, 0);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.CancelBtn.Size = new System.Drawing.Size(35, 33);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.TextColor = System.Drawing.Color.White;
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // MainP
            // 
            this.MainP.Controls.Add(this.panel6);
            this.MainP.Controls.Add(this.IconP);
            this.MainP.Controls.Add(this.NotificationFormTopP);
            this.MainP.Controls.Add(this.panel4);
            this.MainP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainP.Location = new System.Drawing.Point(0, 0);
            this.MainP.Name = "MainP";
            this.MainP.Size = new System.Drawing.Size(402, 135);
            this.MainP.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.MessageLB);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(110, 37);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10, 25, 0, 0);
            this.panel6.Size = new System.Drawing.Size(292, 89);
            this.panel6.TabIndex = 5;
            // 
            // MessageLB
            // 
            this.MessageLB.AutoSize = true;
            this.MessageLB.Dock = System.Windows.Forms.DockStyle.Left;
            this.MessageLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLB.Location = new System.Drawing.Point(10, 25);
            this.MessageLB.Name = "MessageLB";
            this.MessageLB.Size = new System.Drawing.Size(60, 24);
            this.MessageLB.TabIndex = 4;
            this.MessageLB.Text = "label1";
            // 
            // IconP
            // 
            this.IconP.Controls.Add(this.IconPB);
            this.IconP.Dock = System.Windows.Forms.DockStyle.Left;
            this.IconP.Location = new System.Drawing.Point(0, 37);
            this.IconP.Name = "IconP";
            this.IconP.Size = new System.Drawing.Size(110, 89);
            this.IconP.TabIndex = 3;
            // 
            // IconPB
            // 
            this.IconPB.Location = new System.Drawing.Point(25, 17);
            this.IconPB.Name = "IconPB";
            this.IconPB.Size = new System.Drawing.Size(54, 45);
            this.IconPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPB.TabIndex = 0;
            this.IconPB.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.IncreaseingP);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 9);
            this.panel4.TabIndex = 2;
            // 
            // IncreaseingP
            // 
            this.IncreaseingP.BackColor = System.Drawing.Color.DarkCyan;
            this.IncreaseingP.Dock = System.Windows.Forms.DockStyle.Left;
            this.IncreaseingP.Location = new System.Drawing.Point(0, 0);
            this.IncreaseingP.Name = "IncreaseingP";
            this.IncreaseingP.Size = new System.Drawing.Size(21, 9);
            this.IncreaseingP.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(104, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(20, 25, 0, 0);
            this.panel5.Size = new System.Drawing.Size(312, 105);
            this.panel5.TabIndex = 2;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 135);
            this.Controls.Add(this.MainP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NotificationForm";
            this.TopMost = true;
            this.NotificationFormTopP.ResumeLayout(false);
            this.NotificationFormTopP.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.MainP.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.IconP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconPB)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NotificationFormTopP;
        private CustomButton CancelBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label NotificationTypeLB;
      
        private System.Windows.Forms.Panel MainP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label MessageLB;
        private System.Windows.Forms.Panel IconP;
        private System.Windows.Forms.PictureBox IconPB;
        private System.Windows.Forms.Panel IncreaseingP;
    }
}