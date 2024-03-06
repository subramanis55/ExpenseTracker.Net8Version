namespace Evalution2
{
    partial class ChartViewU
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
            this.chart = new Evalution2.ChartU();
            this.categoryAddP = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.White;
            this.chart.ChartBarColor = System.Drawing.Color.White;
            this.chart.Dock = System.Windows.Forms.DockStyle.Left;
            this.chart.Location = new System.Drawing.Point(5, 5);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(179, 165);
            this.chart.TabIndex = 0;
            this.chart.Text = "chartU1";
            this.chart.TotalValueOfItem = 0;
            this.chart.ValuesList = null;
            // 
            // categoryAddP
            // 
            this.categoryAddP.BackColor = System.Drawing.Color.White;
            this.categoryAddP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryAddP.Location = new System.Drawing.Point(10, 0);
            this.categoryAddP.Name = "categoryAddP";
            this.categoryAddP.Size = new System.Drawing.Size(289, 165);
            this.categoryAddP.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.categoryAddP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(184, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel1.Size = new System.Drawing.Size(309, 165);
            this.panel1.TabIndex = 2;
            // 
            // ChartViewU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart);
            this.Name = "ChartViewU";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(498, 175);
            this.Load += new System.EventHandler(this.ChartViewU_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ChartU chart;
        private System.Windows.Forms.Panel categoryAddP;
        private System.Windows.Forms.Panel panel1;
    }
}
