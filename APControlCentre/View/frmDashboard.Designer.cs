namespace APControlCentre.View
{
    partial class frmDashboard
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
            this.tbLayoutPnl = new System.Windows.Forms.TableLayoutPanel();
            this.chrtGPU = new LiveCharts.WinForms.CartesianChart();
            this.chrtCPU = new LiveCharts.WinForms.CartesianChart();
            this.tbLayoutPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLayoutPnl
            // 
            this.tbLayoutPnl.ColumnCount = 2;
            this.tbLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayoutPnl.Controls.Add(this.chrtGPU, 1, 0);
            this.tbLayoutPnl.Controls.Add(this.chrtCPU, 0, 0);
            this.tbLayoutPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayoutPnl.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tbLayoutPnl.Location = new System.Drawing.Point(0, 0);
            this.tbLayoutPnl.Name = "tbLayoutPnl";
            this.tbLayoutPnl.RowCount = 2;
            this.tbLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tbLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tbLayoutPnl.Size = new System.Drawing.Size(800, 450);
            this.tbLayoutPnl.TabIndex = 0;
            // 
            // chrtGPU
            // 
            this.chrtGPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtGPU.Location = new System.Drawing.Point(403, 3);
            this.chrtGPU.Name = "chrtGPU";
            this.chrtGPU.Size = new System.Drawing.Size(394, 193);
            this.chrtGPU.TabIndex = 1;
            // 
            // chrtCPU
            // 
            this.chrtCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtCPU.Location = new System.Drawing.Point(3, 3);
            this.chrtCPU.Name = "chrtCPU";
            this.chrtCPU.Size = new System.Drawing.Size(394, 193);
            this.chrtCPU.TabIndex = 0;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbLayoutPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.tbLayoutPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbLayoutPnl;
        private LiveCharts.WinForms.CartesianChart chrtGPU;
        private LiveCharts.WinForms.CartesianChart chrtCPU;
    }
}