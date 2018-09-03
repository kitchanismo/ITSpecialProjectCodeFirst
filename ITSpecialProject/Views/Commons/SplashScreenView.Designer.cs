using ITSpecialProject.Views.Utilities;

namespace ITSpecialProject.Views.Commons
{
    partial class SplashScreenView
    {
        /// <summary>
        /// NoInput designer variable.
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblStatusMsg = new System.Windows.Forms.Label();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.preloader = new PreloaderView();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pbIcon);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(5, 5);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(490, 40);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.lblTitle.Location = new System.Drawing.Point(40, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Amigoo\'s Point of Sale v1.0.0";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbIcon
            // 
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbIcon.Image = global::ITSpecialProject.Properties.Resources.Amigoo_Logo_Circle;
            this.pbIcon.Location = new System.Drawing.Point(0, 0);
            this.pbIcon.Margin = new System.Windows.Forms.Padding(0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Padding = new System.Windows.Forms.Padding(2);
            this.pbIcon.Size = new System.Drawing.Size(40, 40);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // lblStatusMsg
            // 
            this.lblStatusMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatusMsg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblStatusMsg.Location = new System.Drawing.Point(5, 265);
            this.lblStatusMsg.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatusMsg.Name = "lblStatusMsg";
            this.lblStatusMsg.Size = new System.Drawing.Size(490, 30);
            this.lblStatusMsg.TabIndex = 1;
            this.lblStatusMsg.Text = "connecting...";
            this.lblStatusMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBorder.Location = new System.Drawing.Point(5, 260);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(490, 5);
            this.pnlBorder.TabIndex = 2;
            // 
            // preloader
            // 
            this.preloader.BackColor = System.Drawing.Color.Transparent;
            this.preloader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preloader.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.preloader.ForeColor = System.Drawing.Color.White;
            this.preloader.Location = new System.Drawing.Point(5, 45);
            this.preloader.Margin = new System.Windows.Forms.Padding(0);
            this.preloader.Name = "preloader";
            this.preloader.Size = new System.Drawing.Size(490, 215);
            this.preloader.TabIndex = 3;
            // 
            // SplashScreenView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.ControlBox = false;
            this.Controls.Add(this.preloader);
            this.Controls.Add(this.pnlBorder);
            this.Controls.Add(this.lblStatusMsg);
            this.Controls.Add(this.pnlHeader);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreenView";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblStatusMsg;
        private System.Windows.Forms.Panel pnlBorder;
        private PreloaderView preloader;
    }
}