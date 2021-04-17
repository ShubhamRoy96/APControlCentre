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
            this.tbLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.grpCPU = new System.Windows.Forms.GroupBox();
            this.grpGPU = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chrtCPU = new LiveCharts.WinForms.CartesianChart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chrtGPU = new LiveCharts.WinForms.CartesianChart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCPUName = new System.Windows.Forms.Label();
            this.lblCpuUsage = new System.Windows.Forms.Label();
            this.lblCPUTemp = new System.Windows.Forms.Label();
            this.lblActualCPUName = new System.Windows.Forms.Label();
            this.lblActualCPUUsage = new System.Windows.Forms.Label();
            this.lblActCPUTemp = new System.Windows.Forms.Label();
            this.tbGPUDtlsLayoutPnl = new System.Windows.Forms.TableLayoutPanel();
            this.lblGPUName = new System.Windows.Forms.Label();
            this.lblGPUUsage = new System.Windows.Forms.Label();
            this.lblGPUTemp = new System.Windows.Forms.Label();
            this.lblActGPUName = new System.Windows.Forms.Label();
            this.lblActGPUUsage = new System.Windows.Forms.Label();
            this.lblActGPUTemp = new System.Windows.Forms.Label();
            this.tbLayoutPanel.SuspendLayout();
            this.grpCPU.SuspendLayout();
            this.grpGPU.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tbGPUDtlsLayoutPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLayoutPanel
            // 
            this.tbLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLayoutPanel.ColumnCount = 2;
            this.tbLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayoutPanel.Controls.Add(this.grpGPU, 1, 0);
            this.tbLayoutPanel.Controls.Add(this.grpCPU, 0, 0);
            this.tbLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tbLayoutPanel.Name = "tbLayoutPanel";
            this.tbLayoutPanel.RowCount = 1;
            this.tbLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayoutPanel.Size = new System.Drawing.Size(652, 446);
            this.tbLayoutPanel.TabIndex = 0;
            // 
            // grpCPU
            // 
            this.grpCPU.Controls.Add(this.tableLayoutPanel1);
            this.grpCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCPU.Font = new System.Drawing.Font("Overpass", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCPU.Location = new System.Drawing.Point(3, 3);
            this.grpCPU.Name = "grpCPU";
            this.grpCPU.Size = new System.Drawing.Size(320, 440);
            this.grpCPU.TabIndex = 5;
            this.grpCPU.TabStop = false;
            this.grpCPU.Text = "CPU";
            // 
            // grpGPU
            // 
            this.grpGPU.Controls.Add(this.tableLayoutPanel2);
            this.grpGPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGPU.Font = new System.Drawing.Font("Overpass", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGPU.Location = new System.Drawing.Point(329, 3);
            this.grpGPU.Name = "grpGPU";
            this.grpGPU.Size = new System.Drawing.Size(320, 440);
            this.grpGPU.TabIndex = 6;
            this.grpGPU.TabStop = false;
            this.grpGPU.Text = "GPU";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.chrtCPU, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(314, 417);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chrtCPU
            // 
            this.chrtCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtCPU.Location = new System.Drawing.Point(3, 3);
            this.chrtCPU.Name = "chrtCPU";
            this.chrtCPU.Size = new System.Drawing.Size(308, 202);
            this.chrtCPU.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tbGPUDtlsLayoutPnl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.chrtGPU, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(314, 417);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // chrtGPU
            // 
            this.chrtGPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtGPU.Location = new System.Drawing.Point(3, 3);
            this.chrtGPU.Name = "chrtGPU";
            this.chrtGPU.Size = new System.Drawing.Size(308, 202);
            this.chrtGPU.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.44156F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.55844F));
            this.tableLayoutPanel3.Controls.Add(this.lblCPUName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblCpuUsage, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblCPUTemp, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblActualCPUName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblActualCPUUsage, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblActCPUTemp, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 211);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(308, 203);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lblCPUName
            // 
            this.lblCPUName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCPUName.AutoSize = true;
            this.lblCPUName.Location = new System.Drawing.Point(3, 10);
            this.lblCPUName.Name = "lblCPUName";
            this.lblCPUName.Size = new System.Drawing.Size(55, 20);
            this.lblCPUName.TabIndex = 0;
            this.lblCPUName.Text = "Name : ";
            // 
            // lblCpuUsage
            // 
            this.lblCpuUsage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCpuUsage.AutoSize = true;
            this.lblCpuUsage.Location = new System.Drawing.Point(3, 50);
            this.lblCpuUsage.Name = "lblCpuUsage";
            this.lblCpuUsage.Size = new System.Drawing.Size(55, 20);
            this.lblCpuUsage.TabIndex = 1;
            this.lblCpuUsage.Text = "Usage :";
            // 
            // lblCPUTemp
            // 
            this.lblCPUTemp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCPUTemp.AutoSize = true;
            this.lblCPUTemp.Location = new System.Drawing.Point(3, 90);
            this.lblCPUTemp.Name = "lblCPUTemp";
            this.lblCPUTemp.Size = new System.Drawing.Size(96, 20);
            this.lblCPUTemp.TabIndex = 2;
            this.lblCPUTemp.Text = "Temperature :";
            // 
            // lblActualCPUName
            // 
            this.lblActualCPUName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblActualCPUName.AutoSize = true;
            this.lblActualCPUName.Location = new System.Drawing.Point(106, 10);
            this.lblActualCPUName.Name = "lblActualCPUName";
            this.lblActualCPUName.Size = new System.Drawing.Size(0, 20);
            this.lblActualCPUName.TabIndex = 3;
            this.lblActualCPUName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActualCPUUsage
            // 
            this.lblActualCPUUsage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblActualCPUUsage.AutoSize = true;
            this.lblActualCPUUsage.Location = new System.Drawing.Point(106, 50);
            this.lblActualCPUUsage.Name = "lblActualCPUUsage";
            this.lblActualCPUUsage.Size = new System.Drawing.Size(0, 20);
            this.lblActualCPUUsage.TabIndex = 4;
            this.lblActualCPUUsage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActCPUTemp
            // 
            this.lblActCPUTemp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblActCPUTemp.AutoSize = true;
            this.lblActCPUTemp.Location = new System.Drawing.Point(106, 90);
            this.lblActCPUTemp.Name = "lblActCPUTemp";
            this.lblActCPUTemp.Size = new System.Drawing.Size(0, 20);
            this.lblActCPUTemp.TabIndex = 5;
            this.lblActCPUTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbGPUDtlsLayoutPnl
            // 
            this.tbGPUDtlsLayoutPnl.ColumnCount = 2;
            this.tbGPUDtlsLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.44156F));
            this.tbGPUDtlsLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.55844F));
            this.tbGPUDtlsLayoutPnl.Controls.Add(this.lblGPUName, 0, 0);
            this.tbGPUDtlsLayoutPnl.Controls.Add(this.lblGPUUsage, 0, 1);
            this.tbGPUDtlsLayoutPnl.Controls.Add(this.lblGPUTemp, 0, 2);
            this.tbGPUDtlsLayoutPnl.Controls.Add(this.lblActGPUName, 1, 0);
            this.tbGPUDtlsLayoutPnl.Controls.Add(this.lblActGPUUsage, 1, 1);
            this.tbGPUDtlsLayoutPnl.Controls.Add(this.lblActGPUTemp, 1, 2);
            this.tbGPUDtlsLayoutPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGPUDtlsLayoutPnl.Location = new System.Drawing.Point(3, 211);
            this.tbGPUDtlsLayoutPnl.Name = "tbGPUDtlsLayoutPnl";
            this.tbGPUDtlsLayoutPnl.RowCount = 5;
            this.tbGPUDtlsLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbGPUDtlsLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbGPUDtlsLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbGPUDtlsLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbGPUDtlsLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbGPUDtlsLayoutPnl.Size = new System.Drawing.Size(308, 203);
            this.tbGPUDtlsLayoutPnl.TabIndex = 5;
            // 
            // lblGPUName
            // 
            this.lblGPUName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGPUName.AutoSize = true;
            this.lblGPUName.Location = new System.Drawing.Point(3, 10);
            this.lblGPUName.Name = "lblGPUName";
            this.lblGPUName.Size = new System.Drawing.Size(55, 20);
            this.lblGPUName.TabIndex = 0;
            this.lblGPUName.Text = "Name : ";
            // 
            // lblGPUUsage
            // 
            this.lblGPUUsage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGPUUsage.AutoSize = true;
            this.lblGPUUsage.Location = new System.Drawing.Point(3, 50);
            this.lblGPUUsage.Name = "lblGPUUsage";
            this.lblGPUUsage.Size = new System.Drawing.Size(55, 20);
            this.lblGPUUsage.TabIndex = 1;
            this.lblGPUUsage.Text = "Usage :";
            // 
            // lblGPUTemp
            // 
            this.lblGPUTemp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGPUTemp.AutoSize = true;
            this.lblGPUTemp.Location = new System.Drawing.Point(3, 90);
            this.lblGPUTemp.Name = "lblGPUTemp";
            this.lblGPUTemp.Size = new System.Drawing.Size(96, 20);
            this.lblGPUTemp.TabIndex = 2;
            this.lblGPUTemp.Text = "Temperature :";
            // 
            // lblActGPUName
            // 
            this.lblActGPUName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblActGPUName.AutoSize = true;
            this.lblActGPUName.Location = new System.Drawing.Point(106, 10);
            this.lblActGPUName.Name = "lblActGPUName";
            this.lblActGPUName.Size = new System.Drawing.Size(0, 20);
            this.lblActGPUName.TabIndex = 3;
            this.lblActGPUName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActGPUUsage
            // 
            this.lblActGPUUsage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblActGPUUsage.AutoSize = true;
            this.lblActGPUUsage.Location = new System.Drawing.Point(106, 50);
            this.lblActGPUUsage.Name = "lblActGPUUsage";
            this.lblActGPUUsage.Size = new System.Drawing.Size(0, 20);
            this.lblActGPUUsage.TabIndex = 4;
            this.lblActGPUUsage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActGPUTemp
            // 
            this.lblActGPUTemp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblActGPUTemp.AutoSize = true;
            this.lblActGPUTemp.Location = new System.Drawing.Point(106, 90);
            this.lblActGPUTemp.Name = "lblActGPUTemp";
            this.lblActGPUTemp.Size = new System.Drawing.Size(0, 20);
            this.lblActGPUTemp.TabIndex = 5;
            this.lblActGPUTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbLayoutPanel);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(652, 446);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.VisibleChanged += new System.EventHandler(this.Dashboard_Activated);
            this.Enter += new System.EventHandler(this.Dashboard_Activated);
            this.tbLayoutPanel.ResumeLayout(false);
            this.grpCPU.ResumeLayout(false);
            this.grpGPU.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tbGPUDtlsLayoutPnl.ResumeLayout(false);
            this.tbGPUDtlsLayoutPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbLayoutPanel;
        private System.Windows.Forms.GroupBox grpGPU;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private LiveCharts.WinForms.CartesianChart chrtGPU;
        private System.Windows.Forms.GroupBox grpCPU;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LiveCharts.WinForms.CartesianChart chrtCPU;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblCPUName;
        private System.Windows.Forms.Label lblCpuUsage;
        private System.Windows.Forms.Label lblCPUTemp;
        private System.Windows.Forms.Label lblActualCPUName;
        private System.Windows.Forms.Label lblActualCPUUsage;
        private System.Windows.Forms.Label lblActCPUTemp;
        private System.Windows.Forms.TableLayoutPanel tbGPUDtlsLayoutPnl;
        private System.Windows.Forms.Label lblGPUName;
        private System.Windows.Forms.Label lblGPUUsage;
        private System.Windows.Forms.Label lblGPUTemp;
        private System.Windows.Forms.Label lblActGPUName;
        private System.Windows.Forms.Label lblActGPUUsage;
        private System.Windows.Forms.Label lblActGPUTemp;
    }
}
