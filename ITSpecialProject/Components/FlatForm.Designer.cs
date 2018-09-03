namespace ITSpecialProject.Components
{
    partial class FlatForm
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
        /// NoInput method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitleBar = new ITSpecialProject.Components.FlatPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMMC = new System.Windows.Forms.Panel();
            this.btnMinimize = new ITSpecialProject.Components.FlatButton();
            this.btnMaximize = new ITSpecialProject.Components.FlatButton();
            this.btnClose = new ITSpecialProject.Components.FlatButton();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pnlTitleBorder = new ITSpecialProject.Components.FlatPanel();
            this.pnlTitleBar.SuspendLayout();
            this.pnlMMC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitleBar.ColorAOnDefault = System.Drawing.Color.Transparent;
            this.pnlTitleBar.ColorBOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlTitleBar.ColorCOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlTitleBar.ColorToneOnDefault = ITSpecialProject.Commons.Enums.ColorCombination.SoloColor;
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.pnlMMC);
            this.pnlTitleBar.Controls.Add(this.pbIcon);
            this.pnlTitleBar.Controls.Add(this.pnlTitleBorder);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.EllipseOnDefault = 0;
            this.pnlTitleBar.GradientAngleOnDefault = 45;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1000, 55);
            this.pnlTitleBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblTitle.Location = new System.Drawing.Point(50, 5);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(830, 50);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMMC
            // 
            this.pnlMMC.BackColor = System.Drawing.Color.Transparent;
            this.pnlMMC.Controls.Add(this.btnMinimize);
            this.pnlMMC.Controls.Add(this.btnMaximize);
            this.pnlMMC.Controls.Add(this.btnClose);
            this.pnlMMC.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMMC.Location = new System.Drawing.Point(880, 5);
            this.pnlMMC.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMMC.Name = "pnlMMC";
            this.pnlMMC.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlMMC.Size = new System.Drawing.Size(120, 50);
            this.pnlMMC.TabIndex = 5;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinimize.BackColorOnDefault = System.Drawing.Color.Transparent;
            this.btnMinimize.BackColorOnHover = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.EllipseOnClick = 0;
            this.btnMinimize.EllipseOnDefault = 0;
            this.btnMinimize.EllipseOnHover = 0;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Webdings", 11.25F);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.ForeColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.btnMinimize.ForeColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.ForeColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.Location = new System.Drawing.Point(0, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "0";
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.ToolTip = "minimize.";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMaximize.BackColorOnDefault = System.Drawing.Color.Transparent;
            this.btnMaximize.BackColorOnHover = System.Drawing.Color.Transparent;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.EllipseOnClick = 0;
            this.btnMaximize.EllipseOnDefault = 0;
            this.btnMaximize.EllipseOnHover = 0;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Webdings", 11.25F);
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximize.ForeColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.btnMaximize.ForeColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximize.ForeColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnMaximize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaximize.Location = new System.Drawing.Point(40, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(40, 40);
            this.btnMaximize.TabIndex = 7;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Text = "1";
            this.btnMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaximize.ToolTip = "maximize.";
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.BackColorOnDefault = System.Drawing.Color.Transparent;
            this.btnClose.BackColorOnHover = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.EllipseOnClick = 0;
            this.btnClose.EllipseOnDefault = 0;
            this.btnClose.EllipseOnHover = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Webdings", 11.25F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.ForeColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClose.ForeColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.ForeColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(80, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "r";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.ToolTip = "close.";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbIcon.Location = new System.Drawing.Point(0, 5);
            this.pbIcon.Margin = new System.Windows.Forms.Padding(0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Padding = new System.Windows.Forms.Padding(5);
            this.pbIcon.Size = new System.Drawing.Size(50, 50);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 3;
            this.pbIcon.TabStop = false;
            // 
            // pnlTitleBorder
            // 
            this.pnlTitleBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.pnlTitleBorder.ColorAOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.pnlTitleBorder.ColorBOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlTitleBorder.ColorCOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlTitleBorder.ColorToneOnDefault = ITSpecialProject.Commons.Enums.ColorCombination.SoloColor;
            this.pnlTitleBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBorder.EllipseOnDefault = 0;
            this.pnlTitleBorder.GradientAngleOnDefault = 45;
            this.pnlTitleBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBorder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitleBorder.Name = "pnlTitleBorder";
            this.pnlTitleBorder.Size = new System.Drawing.Size(1000, 5);
            this.pnlTitleBorder.TabIndex = 1;
            // 
            // FlatForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTitleBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlatForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlMMC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public FlatPanel pnlTitleBar;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.PictureBox pbIcon;
        public FlatButton btnMinimize;
        public FlatButton btnMaximize;
        public FlatButton btnClose;
        public FlatPanel pnlTitleBorder;
        public System.Windows.Forms.Panel pnlMMC;
    }
}