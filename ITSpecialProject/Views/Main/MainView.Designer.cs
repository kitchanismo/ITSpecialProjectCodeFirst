namespace ITSpecialProject.Views.Main
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.pnlNavigation = new ITSpecialProject.Components.FlatNavigationPanel();
            this.btnPos = new ITSpecialProject.Components.FlatButton();
            this.btnHelp = new ITSpecialProject.Components.FlatButton();
            this.btnSettings = new ITSpecialProject.Components.FlatButton();
            this.btnReports = new ITSpecialProject.Components.FlatButton();
            this.btnManage = new ITSpecialProject.Components.FlatButton();
            this.btnHome = new ITSpecialProject.Components.FlatButton();
            this.pnlFooter = new ITSpecialProject.Components.FlatPanel();
            this.btnProfile = new ITSpecialProject.Components.FlatButton();
            this.btnLock = new ITSpecialProject.Components.FlatButton();
            this.btnLogout = new ITSpecialProject.Components.FlatButton();
            this.btnExit = new ITSpecialProject.Components.FlatButton();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.pnlSubNavigation = new ITSpecialProject.Views.Main.NavigationView();
            this.lblModuleTitle = new System.Windows.Forms.Label();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.pnlMMC.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.pnlTitleBar.ColorAOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.pnlTitleBar.Size = new System.Drawing.Size(1200, 55);
            // 
            // lblTitle
            // 
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Size = new System.Drawing.Size(1030, 50);
            this.lblTitle.Text = "Amigoo\'s Steakhouse";
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::ITSpecialProject.Properties.Resources.Amigoo_Logo_Circle;
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.ForeColorOnDefault = System.Drawing.Color.White;
            // 
            // btnMaximize
            // 
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.ForeColorOnDefault = System.Drawing.Color.White;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ForeColorOnDefault = System.Drawing.Color.White;
            // 
            // pnlTitleBorder
            // 
            this.pnlTitleBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.pnlTitleBorder.ColorAOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.pnlTitleBorder.Size = new System.Drawing.Size(1200, 5);
            // 
            // pnlMMC
            // 
            this.pnlMMC.Location = new System.Drawing.Point(1080, 5);
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlNavigation.Controls.Add(this.btnPos);
            this.pnlNavigation.Controls.Add(this.btnHelp);
            this.pnlNavigation.Controls.Add(this.btnSettings);
            this.pnlNavigation.Controls.Add(this.btnReports);
            this.pnlNavigation.Controls.Add(this.btnManage);
            this.pnlNavigation.Controls.Add(this.btnHome);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 55);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnlNavigation.SelectorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.pnlNavigation.Size = new System.Drawing.Size(105, 600);
            this.pnlNavigation.TabIndex = 1;
            // 
            // btnPos
            // 
            this.btnPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(15)))));
            this.btnPos.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnPos.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(15)))));
            this.btnPos.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPos.EllipseOnClick = 0;
            this.btnPos.EllipseOnDefault = 0;
            this.btnPos.EllipseOnHover = 0;
            this.btnPos.FlatAppearance.BorderSize = 0;
            this.btnPos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnPos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPos.ForeColor = System.Drawing.Color.White;
            this.btnPos.ForeColorOnClick = System.Drawing.Color.White;
            this.btnPos.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnPos.ForeColorOnHover = System.Drawing.Color.White;
            this.btnPos.Image = global::ITSpecialProject.Properties.Resources.POS_32;
            this.btnPos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPos.Location = new System.Drawing.Point(0, 500);
            this.btnPos.Margin = new System.Windows.Forms.Padding(0);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(100, 100);
            this.btnPos.TabIndex = 8;
            this.btnPos.TabStop = false;
            this.btnPos.Text = "POS";
            this.btnPos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPos.ToolTip = "";
            this.btnPos.UseVisualStyleBackColor = false;
            this.btnPos.Click += new System.EventHandler(this.BtnPos_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(60)))), ((int)(((byte)(25)))));
            this.btnHelp.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnHelp.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(60)))), ((int)(((byte)(25)))));
            this.btnHelp.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.EllipseOnClick = 0;
            this.btnHelp.EllipseOnDefault = 0;
            this.btnHelp.EllipseOnHover = 0;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.ForeColorOnClick = System.Drawing.Color.White;
            this.btnHelp.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnHelp.ForeColorOnHover = System.Drawing.Color.White;
            this.btnHelp.Image = global::ITSpecialProject.Properties.Resources.Support_32;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelp.Location = new System.Drawing.Point(0, 400);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 100);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "support";
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHelp.ToolTip = "";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(70)))), ((int)(((byte)(35)))));
            this.btnSettings.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnSettings.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(70)))), ((int)(((byte)(35)))));
            this.btnSettings.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.EllipseOnClick = 0;
            this.btnSettings.EllipseOnDefault = 0;
            this.btnSettings.EllipseOnHover = 0;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.ForeColorOnClick = System.Drawing.Color.White;
            this.btnSettings.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnSettings.ForeColorOnHover = System.Drawing.Color.White;
            this.btnSettings.Image = global::ITSpecialProject.Properties.Resources.Settings_32;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.Location = new System.Drawing.Point(0, 300);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(100, 100);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.TabStop = false;
            this.btnSettings.Text = "settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSettings.ToolTip = "";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.btnReports.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnReports.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.btnReports.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.EllipseOnClick = 0;
            this.btnReports.EllipseOnDefault = 0;
            this.btnReports.EllipseOnHover = 0;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.ForeColorOnClick = System.Drawing.Color.White;
            this.btnReports.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnReports.ForeColorOnHover = System.Drawing.Color.White;
            this.btnReports.Image = global::ITSpecialProject.Properties.Resources.Reports_32;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.Location = new System.Drawing.Point(0, 200);
            this.btnReports.Margin = new System.Windows.Forms.Padding(0);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(100, 100);
            this.btnReports.TabIndex = 5;
            this.btnReports.TabStop = false;
            this.btnReports.Text = "reports";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReports.ToolTip = "";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(90)))), ((int)(((byte)(55)))));
            this.btnManage.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnManage.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(90)))), ((int)(((byte)(55)))));
            this.btnManage.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManage.EllipseOnClick = 0;
            this.btnManage.EllipseOnDefault = 0;
            this.btnManage.EllipseOnHover = 0;
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.White;
            this.btnManage.ForeColorOnClick = System.Drawing.Color.White;
            this.btnManage.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnManage.ForeColorOnHover = System.Drawing.Color.White;
            this.btnManage.Image = global::ITSpecialProject.Properties.Resources.Manage_32;
            this.btnManage.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManage.Location = new System.Drawing.Point(0, 100);
            this.btnManage.Margin = new System.Windows.Forms.Padding(0);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(100, 100);
            this.btnManage.TabIndex = 4;
            this.btnManage.TabStop = false;
            this.btnManage.Text = "manage";
            this.btnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnManage.ToolTip = "";
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.BtnManage_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(65)))));
            this.btnHome.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnHome.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(65)))));
            this.btnHome.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.EllipseOnClick = 0;
            this.btnHome.EllipseOnDefault = 0;
            this.btnHome.EllipseOnHover = 0;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.ForeColorOnClick = System.Drawing.Color.White;
            this.btnHome.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnHome.ForeColorOnHover = System.Drawing.Color.White;
            this.btnHome.Image = global::ITSpecialProject.Properties.Resources.Home_32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 100);
            this.btnHome.TabIndex = 3;
            this.btnHome.TabStop = false;
            this.btnHome.Text = "home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.ToolTip = "";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.pnlFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFooter.BackgroundImage")));
            this.pnlFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFooter.ColorAOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.pnlFooter.ColorBOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.pnlFooter.ColorCOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlFooter.ColorToneOnDefault = ITSpecialProject.Commons.Enums.ColorCombination.DualColor;
            this.pnlFooter.Controls.Add(this.btnProfile);
            this.pnlFooter.Controls.Add(this.btnLock);
            this.pnlFooter.Controls.Add(this.btnLogout);
            this.pnlFooter.Controls.Add(this.btnExit);
            this.pnlFooter.Controls.Add(this.lblDateTime);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.EllipseOnDefault = 0;
            this.pnlFooter.GradientAngleOnDefault = 0;
            this.pnlFooter.Location = new System.Drawing.Point(0, 655);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1200, 45);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProfile.BackColorOnDefault = System.Drawing.Color.Transparent;
            this.btnProfile.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProfile.EllipseOnClick = 0;
            this.btnProfile.EllipseOnDefault = 0;
            this.btnProfile.EllipseOnHover = 0;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.ForeColorOnClick = System.Drawing.Color.White;
            this.btnProfile.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnProfile.ForeColorOnHover = System.Drawing.Color.White;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(135, 0);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(500, 45);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "Juan Dela Cruz";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.ToolTip = "click to manage your account.";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.Color.Transparent;
            this.btnLock.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLock.BackColorOnDefault = System.Drawing.Color.Transparent;
            this.btnLock.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLock.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLock.EllipseOnClick = 0;
            this.btnLock.EllipseOnDefault = 0;
            this.btnLock.EllipseOnHover = 0;
            this.btnLock.FlatAppearance.BorderSize = 0;
            this.btnLock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLock.ForeColor = System.Drawing.Color.White;
            this.btnLock.ForeColorOnClick = System.Drawing.Color.White;
            this.btnLock.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnLock.ForeColorOnHover = System.Drawing.Color.White;
            this.btnLock.Image = global::ITSpecialProject.Properties.Resources.Lock_32;
            this.btnLock.Location = new System.Drawing.Point(90, 0);
            this.btnLock.Margin = new System.Windows.Forms.Padding(0);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(45, 45);
            this.btnLock.TabIndex = 8;
            this.btnLock.TabStop = false;
            this.btnLock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLock.ToolTip = "";
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.BtnLock_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.BackColorOnDefault = System.Drawing.Color.Transparent;
            this.btnLogout.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLogout.EllipseOnClick = 0;
            this.btnLogout.EllipseOnDefault = 0;
            this.btnLogout.EllipseOnHover = 0;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.ForeColorOnClick = System.Drawing.Color.White;
            this.btnLogout.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnLogout.ForeColorOnHover = System.Drawing.Color.White;
            this.btnLogout.Image = global::ITSpecialProject.Properties.Resources.Logout_32;
            this.btnLogout.Location = new System.Drawing.Point(45, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(45, 45);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.TabStop = false;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogout.ToolTip = "";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnExit.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnExit.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnExit.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExit.EllipseOnClick = 0;
            this.btnExit.EllipseOnDefault = 0;
            this.btnExit.EllipseOnHover = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ForeColorOnClick = System.Drawing.Color.White;
            this.btnExit.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnExit.ForeColorOnHover = System.Drawing.Color.White;
            this.btnExit.Image = global::ITSpecialProject.Properties.Resources.Exit_32;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 45);
            this.btnExit.TabIndex = 6;
            this.btnExit.TabStop = false;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.ToolTip = "";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDateTime.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.lblDateTime.Location = new System.Drawing.Point(800, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(400, 45);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "JAN 01 • 12:00 AM";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(305, 85);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(895, 570);
            this.pnlBody.TabIndex = 3;
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Enabled = true;
            this.tmrDateTime.Interval = 60000;
            this.tmrDateTime.Tick += new System.EventHandler(this.TmrDateTime_Tick);
            // 
            // pnlSubNavigation
            // 
            this.pnlSubNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pnlSubNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSubNavigation.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.pnlSubNavigation.ForeColor = System.Drawing.Color.White;
            this.pnlSubNavigation.Location = new System.Drawing.Point(105, 55);
            this.pnlSubNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSubNavigation.Name = "pnlSubNavigation";
            this.pnlSubNavigation.Size = new System.Drawing.Size(200, 600);
            this.pnlSubNavigation.TabIndex = 4;
            // 
            // lblModuleTitle
            // 
            this.lblModuleTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.lblModuleTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblModuleTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.lblModuleTitle.ForeColor = System.Drawing.Color.White;
            this.lblModuleTitle.Location = new System.Drawing.Point(305, 55);
            this.lblModuleTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblModuleTitle.Name = "lblModuleTitle";
            this.lblModuleTitle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblModuleTitle.Size = new System.Drawing.Size(895, 30);
            this.lblModuleTitle.TabIndex = 5;
            this.lblModuleTitle.Text = "Title";
            this.lblModuleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.ColorAOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ColorBOnDefault = System.Drawing.Color.White;
            this.ColorCOnDefault = System.Drawing.Color.White;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.lblModuleTitle);
            this.Controls.Add(this.pnlSubNavigation);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlFooter);
            this.GradientAngleOnDefault = 270;
            this.HasClose = true;
            this.HasIcon = true;
            this.HasMaximize = true;
            this.HasMinimize = true;
            this.HasTitleBar = true;
            this.HasTitleBorder = true;
            this.Name = "MainView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.pnlTitleBar, 0);
            this.Controls.SetChildIndex(this.pnlNavigation, 0);
            this.Controls.SetChildIndex(this.pnlSubNavigation, 0);
            this.Controls.SetChildIndex(this.lblModuleTitle, 0);
            this.Controls.SetChildIndex(this.pnlBody, 0);
            this.pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.pnlMMC.ResumeLayout(false);
            this.pnlNavigation.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.FlatNavigationPanel pnlNavigation;
        private Components.FlatButton btnPos;
        private Components.FlatButton btnHelp;
        private Components.FlatButton btnSettings;
        private Components.FlatButton btnReports;
        private Components.FlatButton btnManage;
        private Components.FlatButton btnHome;
        private Components.FlatPanel pnlFooter;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblDateTime;
        private Components.FlatButton btnProfile;
        private Components.FlatButton btnLock;
        private Components.FlatButton btnLogout;
        private Components.FlatButton btnExit;
        private System.Windows.Forms.Timer tmrDateTime;
        private NavigationView pnlSubNavigation;
        private System.Windows.Forms.Label lblModuleTitle;
    }
}