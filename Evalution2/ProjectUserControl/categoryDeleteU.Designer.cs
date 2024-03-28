namespace ExpenseTracker
{
    partial class CategoryDeleteU
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
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.removeBtn = new System.Windows.Forms.Button();
            this.panel18.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel20.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Transparent;
            this.panel18.Controls.Add(this.panel5);
            this.panel18.Controls.Add(this.panel20);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Name = "panel18";
            this.panel18.Padding = new System.Windows.Forms.Padding(5);
            this.panel18.Size = new System.Drawing.Size(264, 120);
            this.panel18.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.categoryCB);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(157, 110);
            this.panel5.TabIndex = 8;
            // 
            // categoryCB
            // 
            this.categoryCB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.categoryCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCB.ForeColor = System.Drawing.Color.Black;
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(5, 77);
            this.categoryCB.MaxDropDownItems = 12;
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(147, 28);
            this.categoryCB.TabIndex = 7;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.Transparent;
            this.panel20.Controls.Add(this.removeBtn);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel20.Location = new System.Drawing.Point(162, 5);
            this.panel20.Name = "panel20";
            this.panel20.Padding = new System.Windows.Forms.Padding(5);
            this.panel20.Size = new System.Drawing.Size(97, 110);
            this.panel20.TabIndex = 9;
            // 
            // removeBtn
            // 
            this.removeBtn.AutoEllipsis = true;
            this.removeBtn.BackColor = System.Drawing.Color.Crimson;
            this.removeBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(5, 76);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(87, 29);
            this.removeBtn.TabIndex = 8;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            // 
            // CategoryDeleteU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel18);
            this.Name = "CategoryDeleteU";
            this.Size = new System.Drawing.Size(264, 120);
            this.panel18.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button removeBtn;
    }
}
