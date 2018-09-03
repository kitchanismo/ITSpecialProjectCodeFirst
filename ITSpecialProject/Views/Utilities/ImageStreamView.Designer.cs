namespace ITSpecialProject.Views.Utilities
{
    partial class ImageStreamView
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
            this.components = new System.ComponentModel.Container();
            this.pbFrame = new System.Windows.Forms.PictureBox();
            this.tmrDecode = new System.Windows.Forms.Timer(this.components);
            this.cbDevices = new ITSpecialProject.Components.FlatComboBox();
            this.btnClose = new ITSpecialProject.Components.FlatButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnScan = new ITSpecialProject.Components.FlatButton();
            this.btnCapture = new ITSpecialProject.Components.FlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrame)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFrame
            // 
            this.pbFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pbFrame.Location = new System.Drawing.Point(5, 5);
            this.pbFrame.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pbFrame.Name = "pbFrame";
            this.pbFrame.Size = new System.Drawing.Size(590, 352);
            this.pbFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFrame.TabIndex = 0;
            this.pbFrame.TabStop = false;
            // 
            // tmrDecode
            // 
            this.tmrDecode.Interval = 1000;
            this.tmrDecode.Tick += new System.EventHandler(this.TmrDecode_Tick);
            // 
            // cbDevices
            // 
            this.cbDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbDevices.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.cbDevices.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbDevices.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.cbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDevices.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.cbDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cbDevices.ForeColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cbDevices.ForeColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cbDevices.ForeColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cbDevices.FormattingEnabled = true;
            this.cbDevices.Location = new System.Drawing.Point(5, 362);
            this.cbDevices.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.cbDevices.Name = "cbDevices";
            this.cbDevices.Size = new System.Drawing.Size(590, 28);
            this.cbDevices.TabIndex = 1;
            this.cbDevices.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnClose.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnClose.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.EllipseOnClick = 0;
            this.btnClose.EllipseOnDefault = 0;
            this.btnClose.EllipseOnHover = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ForeColorOnClick = System.Drawing.Color.White;
            this.btnClose.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnClose.ForeColorOnHover = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(490, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 100);
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "close";
            this.btnClose.ToolTip = "close.";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Controls.Add(this.btnScan);
            this.flowLayoutPanel1.Controls.Add(this.btnCapture);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 395);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(590, 100);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnScan.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.btnScan.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnScan.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
            this.btnScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScan.EllipseOnClick = 0;
            this.btnScan.EllipseOnDefault = 0;
            this.btnScan.EllipseOnHover = 0;
            this.btnScan.FlatAppearance.BorderSize = 0;
            this.btnScan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.btnScan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnScan.ForeColor = System.Drawing.Color.White;
            this.btnScan.ForeColorOnClick = System.Drawing.Color.White;
            this.btnScan.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnScan.ForeColorOnHover = System.Drawing.Color.White;
            this.btnScan.Location = new System.Drawing.Point(385, 0);
            this.btnScan.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(100, 100);
            this.btnScan.TabIndex = 4;
            this.btnScan.TabStop = false;
            this.btnScan.Text = "start\r\nscanning";
            this.btnScan.ToolTip = "scan";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnCapture.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.btnCapture.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnCapture.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
            this.btnCapture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapture.EllipseOnClick = 0;
            this.btnCapture.EllipseOnDefault = 0;
            this.btnCapture.EllipseOnHover = 0;
            this.btnCapture.FlatAppearance.BorderSize = 0;
            this.btnCapture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.btnCapture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapture.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnCapture.ForeColor = System.Drawing.Color.White;
            this.btnCapture.ForeColorOnClick = System.Drawing.Color.White;
            this.btnCapture.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnCapture.ForeColorOnHover = System.Drawing.Color.White;
            this.btnCapture.Location = new System.Drawing.Point(280, 0);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(100, 100);
            this.btnCapture.TabIndex = 5;
            this.btnCapture.TabStop = false;
            this.btnCapture.Text = "capture";
            this.btnCapture.ToolTip = "scan";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Visible = false;
            this.btnCapture.Click += new System.EventHandler(this.BtnCapture_Click);
            // 
            // ImageStreamView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cbDevices);
            this.Controls.Add(this.pbFrame);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageStreamView";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.pbFrame)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFrame;
        private Components.FlatComboBox cbDevices;
        private System.Windows.Forms.Timer tmrDecode;
        private Components.FlatButton btnClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Components.FlatButton btnScan;
        private Components.FlatButton btnCapture;
    }
}