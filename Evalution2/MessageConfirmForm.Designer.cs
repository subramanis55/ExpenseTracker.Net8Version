namespace Evalution2
{
    partial class MessageConfirmForm
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
            this.messageBoxTopP = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.messageLB = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.messageBoxTopP.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageBoxTopP
            // 
            this.messageBoxTopP.BackColor = System.Drawing.Color.Teal;
            this.messageBoxTopP.Controls.Add(this.closeBtn);
            this.messageBoxTopP.Dock = System.Windows.Forms.DockStyle.Top;
            this.messageBoxTopP.Location = new System.Drawing.Point(1, 1);
            this.messageBoxTopP.Name = "messageBoxTopP";
            this.messageBoxTopP.Padding = new System.Windows.Forms.Padding(2);
            this.messageBoxTopP.Size = new System.Drawing.Size(363, 37);
            this.messageBoxTopP.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.messageLB);
            this.panel2.Controls.Add(this.noBtn);
            this.panel2.Controls.Add(this.yesBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 140);
            this.panel2.TabIndex = 1;
            // 
            // yesBtn
            // 
            this.yesBtn.BackColor = System.Drawing.Color.Teal;
            this.yesBtn.FlatAppearance.BorderSize = 0;
            this.yesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesBtn.ForeColor = System.Drawing.Color.White;
            this.yesBtn.Location = new System.Drawing.Point(110, 93);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(60, 30);
            this.yesBtn.TabIndex = 1;
            this.yesBtn.Text = "Yes";
            this.yesBtn.UseVisualStyleBackColor = false;
            // 
            // noBtn
            // 
            this.noBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.noBtn.FlatAppearance.BorderSize = 0;
            this.noBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noBtn.ForeColor = System.Drawing.Color.Black;
            this.noBtn.Location = new System.Drawing.Point(192, 93);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(60, 30);
            this.noBtn.TabIndex = 2;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = false;
            // 
            // messageLB
            // 
            this.messageLB.AutoSize = true;
            this.messageLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLB.Location = new System.Drawing.Point(72, 29);
            this.messageLB.Name = "messageLB";
            this.messageLB.Size = new System.Drawing.Size(46, 18);
            this.messageLB.TabIndex = 3;
            this.messageLB.Text = "label1";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Crimson;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Image = global::Evalution2.Properties.Resources.icons8_cancel_25__1_;
            this.closeBtn.Location = new System.Drawing.Point(319, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(42, 33);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = false;
            // 
            // MessageConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(365, 179);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.messageBoxTopP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageConfirmForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageConfirmForm";
            this.messageBoxTopP.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel messageBoxTopP;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label messageLB;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Button yesBtn;
    }
}