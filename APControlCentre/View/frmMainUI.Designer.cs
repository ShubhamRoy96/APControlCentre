﻿namespace APControlCentre.View
{
    partial class frmMainUI
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
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pctAbout = new System.Windows.Forms.PictureBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pctSettings = new System.Windows.Forms.PictureBox();
            this.lblSettings = new System.Windows.Forms.Label();
            this.pctDashboard = new System.Windows.Forms.PictureBox();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.grpContainer = new System.Windows.Forms.GroupBox();
            this.btnMaximise = new System.Windows.Forms.Button();
            this.btnMinimise = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlNav.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlNav.Controls.Add(this.pctAbout);
            this.pnlNav.Controls.Add(this.lblAbout);
            this.pnlNav.Controls.Add(this.pctSettings);
            this.pnlNav.Controls.Add(this.lblSettings);
            this.pnlNav.Controls.Add(this.pctDashboard);
            this.pnlNav.Controls.Add(this.lblDashboard);
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(168, 602);
            this.pnlNav.TabIndex = 0;
            // 
            // pctAbout
            // 
            this.pctAbout.BackColor = System.Drawing.Color.Transparent;
            this.pctAbout.Image = global::APControlCentre.Properties.Resources.icoAbout_small_Alt;
            this.pctAbout.Location = new System.Drawing.Point(4, 202);
            this.pctAbout.Name = "pctAbout";
            this.pctAbout.Size = new System.Drawing.Size(42, 40);
            this.pctAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctAbout.TabIndex = 6;
            this.pctAbout.TabStop = false;
            // 
            // lblAbout
            // 
            this.lblAbout.BackColor = System.Drawing.Color.Transparent;
            this.lblAbout.Font = new System.Drawing.Font("Overpass", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.White;
            this.lblAbout.Location = new System.Drawing.Point(0, 199);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblAbout.Size = new System.Drawing.Size(168, 50);
            this.lblAbout.TabIndex = 2;
            this.lblAbout.Text = "ABOUT";
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAbout.Click += new System.EventHandler(this.BtnPage_Click);
            // 
            // pctSettings
            // 
            this.pctSettings.BackColor = System.Drawing.Color.Transparent;
            this.pctSettings.Image = global::APControlCentre.Properties.Resources.icoSettings_small_Alt;
            this.pctSettings.Location = new System.Drawing.Point(4, 153);
            this.pctSettings.Name = "pctSettings";
            this.pctSettings.Size = new System.Drawing.Size(42, 40);
            this.pctSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctSettings.TabIndex = 4;
            this.pctSettings.TabStop = false;
            // 
            // lblSettings
            // 
            this.lblSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblSettings.Font = new System.Drawing.Font("Overpass", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.White;
            this.lblSettings.Location = new System.Drawing.Point(0, 149);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblSettings.Size = new System.Drawing.Size(168, 50);
            this.lblSettings.TabIndex = 1;
            this.lblSettings.Text = "SETTINGS";
            this.lblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSettings.Click += new System.EventHandler(this.BtnPage_Click);
            // 
            // pctDashboard
            // 
            this.pctDashboard.BackColor = System.Drawing.Color.GhostWhite;
            this.pctDashboard.Image = global::APControlCentre.Properties.Resources.icoDashboard;
            this.pctDashboard.Location = new System.Drawing.Point(4, 101);
            this.pctDashboard.Name = "pctDashboard";
            this.pctDashboard.Size = new System.Drawing.Size(42, 46);
            this.pctDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctDashboard.TabIndex = 3;
            this.pctDashboard.TabStop = false;
            // 
            // lblDashboard
            // 
            this.lblDashboard.BackColor = System.Drawing.Color.GhostWhite;
            this.lblDashboard.Font = new System.Drawing.Font("Overpass ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.Black;
            this.lblDashboard.Location = new System.Drawing.Point(0, 100);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblDashboard.Size = new System.Drawing.Size(168, 50);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "DASHBOARD";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDashboard.Click += new System.EventHandler(this.BtnPage_Click);
            // 
            // grpContainer
            // 
            this.grpContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpContainer.BackColor = System.Drawing.Color.Transparent;
            this.grpContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpContainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpContainer.Location = new System.Drawing.Point(168, 32);
            this.grpContainer.Name = "grpContainer";
            this.grpContainer.Size = new System.Drawing.Size(834, 602);
            this.grpContainer.TabIndex = 1;
            this.grpContainer.TabStop = false;
            // 
            // btnMaximise
            // 
            this.btnMaximise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximise.BackColor = System.Drawing.Color.GhostWhite;
            this.btnMaximise.BackgroundImage = global::APControlCentre.Properties.Resources.icoMaxmise;
            this.btnMaximise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximise.FlatAppearance.BorderSize = 0;
            this.btnMaximise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximise.ForeColor = System.Drawing.Color.Black;
            this.btnMaximise.Location = new System.Drawing.Point(929, 0);
            this.btnMaximise.Name = "btnMaximise";
            this.btnMaximise.Size = new System.Drawing.Size(39, 35);
            this.btnMaximise.TabIndex = 2;
            this.btnMaximise.TabStop = false;
            this.btnMaximise.UseVisualStyleBackColor = true;
            this.btnMaximise.Click += new System.EventHandler(this.btnMaximise_Click);
            // 
            // btnMinimise
            // 
            this.btnMinimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimise.BackColor = System.Drawing.Color.GhostWhite;
            this.btnMinimise.BackgroundImage = global::APControlCentre.Properties.Resources.icoMinimise;
            this.btnMinimise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimise.FlatAppearance.BorderSize = 0;
            this.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimise.ForeColor = System.Drawing.Color.Black;
            this.btnMinimise.Location = new System.Drawing.Point(896, 0);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(39, 35);
            this.btnMinimise.TabIndex = 0;
            this.btnMinimise.TabStop = false;
            this.btnMinimise.UseVisualStyleBackColor = true;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.GhostWhite;
            this.btnExit.BackgroundImage = global::APControlCentre.Properties.Resources.icoCancel;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(963, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 35);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // frmMainUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.btnMaximise);
            this.Controls.Add(this.grpContainer);
            this.Controls.Add(this.btnMinimise);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmMainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainUI_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMainUI_Resize);
            this.pnlNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDashboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimise;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.PictureBox pctDashboard;
        private System.Windows.Forms.PictureBox pctSettings;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.PictureBox pctAbout;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.GroupBox grpContainer;
        private System.Windows.Forms.Button btnMaximise;
    }
}

