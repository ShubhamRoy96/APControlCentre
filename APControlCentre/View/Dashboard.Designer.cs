namespace APControlCentre.View
{
    partial class Dashboard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chrtGPU = new LiveCharts.WinForms.CartesianChart();
            this.chrtCPU = new LiveCharts.WinForms.CartesianChart();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chrtGPU, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chrtCPU, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(652, 446);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chrtGPU
            // 
            this.chrtGPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtGPU.Location = new System.Drawing.Point(329, 3);
            this.chrtGPU.Name = "chrtGPU";
            this.chrtGPU.Size = new System.Drawing.Size(320, 306);
            this.chrtGPU.TabIndex = 2;
            // 
            // chrtCPU
            // 
            this.chrtCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtCPU.Location = new System.Drawing.Point(3, 3);
            this.chrtCPU.Name = "chrtCPU";
            this.chrtCPU.Size = new System.Drawing.Size(320, 306);
            this.chrtCPU.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(652, 446);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.VisibleChanged += new System.EventHandler(this.Dashboard_Activated);
            this.Enter += new System.EventHandler(this.Dashboard_Activated);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LiveCharts.WinForms.CartesianChart chrtGPU;
        private LiveCharts.WinForms.CartesianChart chrtCPU;
    }
}
