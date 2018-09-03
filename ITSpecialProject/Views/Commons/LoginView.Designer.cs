namespace ITSpecialProject.Views.Commons
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.pnlLogin = new ITSpecialProject.Components.FlatPanel();
            this.tlpCredentials = new System.Windows.Forms.TableLayoutPanel();
            this.btnQrLogin = new ITSpecialProject.Components.FlatButton();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pbAbout = new ITSpecialProject.Components.FlatPictureBox();
            this.pbConfiguration = new ITSpecialProject.Components.FlatPictureBox();
            this.pbRefresh = new ITSpecialProject.Components.FlatPictureBox();
            this.pbConnection = new ITSpecialProject.Components.FlatPictureBox();
            this.txtUserPass = new ITSpecialProject.Components.FlatTextBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.txtUserName = new ITSpecialProject.Components.FlatTextBox();
            this.btnLogin = new ITSpecialProject.Components.FlatButton();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new ITSpecialProject.Components.FlatButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            this.tlpCredentials.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfiguration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogin.BackgroundImage")));
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogin.ColorAOnDefault = System.Drawing.Color.WhiteSmoke;
            this.pnlLogin.ColorBOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.pnlLogin.ColorCOnDefault = System.Drawing.Color.Transparent;
            this.pnlLogin.ColorToneOnDefault = ITSpecialProject.Commons.Enums.ColorCombination.DualColor;
            this.pnlLogin.Controls.Add(this.tlpCredentials);
            this.pnlLogin.Controls.Add(this.pnlHeader);
            this.pnlLogin.Controls.Add(this.pbLogo);
            this.pnlLogin.EllipseOnDefault = 0;
            this.pnlLogin.GradientAngleOnDefault = 0;
            this.pnlLogin.Location = new System.Drawing.Point(50, 50);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(700, 500);
            this.pnlLogin.TabIndex = 0;
            // 
            // tlpCredentials
            // 
            this.tlpCredentials.BackColor = System.Drawing.Color.Transparent;
            this.tlpCredentials.ColumnCount = 1;
            this.tlpCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCredentials.Controls.Add(this.btnQrLogin, 0, 4);
            this.tlpCredentials.Controls.Add(this.pnlFooter, 0, 5);
            this.tlpCredentials.Controls.Add(this.txtUserPass, 0, 2);
            this.tlpCredentials.Controls.Add(this.pbIcon, 0, 0);
            this.tlpCredentials.Controls.Add(this.txtUserName, 0, 1);
            this.tlpCredentials.Controls.Add(this.btnLogin, 0, 3);
            this.tlpCredentials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCredentials.Location = new System.Drawing.Point(350, 30);
            this.tlpCredentials.Name = "tlpCredentials";
            this.tlpCredentials.RowCount = 6;
            this.tlpCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCredentials.Size = new System.Drawing.Size(350, 470);
            this.tlpCredentials.TabIndex = 5;
            // 
            // btnQrLogin
            // 
            this.btnQrLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnQrLogin.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.btnQrLogin.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnQrLogin.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.btnQrLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQrLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQrLogin.EllipseOnClick = 0;
            this.btnQrLogin.EllipseOnDefault = 0;
            this.btnQrLogin.EllipseOnHover = 0;
            this.btnQrLogin.FlatAppearance.BorderSize = 0;
            this.btnQrLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.btnQrLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.btnQrLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQrLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnQrLogin.ForeColor = System.Drawing.Color.White;
            this.btnQrLogin.ForeColorOnClick = System.Drawing.Color.White;
            this.btnQrLogin.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnQrLogin.ForeColorOnHover = System.Drawing.Color.White;
            this.btnQrLogin.Location = new System.Drawing.Point(25, 315);
            this.btnQrLogin.Margin = new System.Windows.Forms.Padding(25, 0, 25, 10);
            this.btnQrLogin.Name = "btnQrLogin";
            this.btnQrLogin.Size = new System.Drawing.Size(300, 45);
            this.btnQrLogin.TabIndex = 18;
            this.btnQrLogin.TabStop = false;
            this.btnQrLogin.Text = "QR login";
            this.btnQrLogin.ToolTip = "login in using qr code.";
            this.btnQrLogin.UseVisualStyleBackColor = false;
            this.btnQrLogin.Click += new System.EventHandler(this.BtnQrLogin_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.Controls.Add(this.pbAbout);
            this.pnlFooter.Controls.Add(this.pbConfiguration);
            this.pnlFooter.Controls.Add(this.pbRefresh);
            this.pnlFooter.Controls.Add(this.pbConnection);
            this.pnlFooter.Location = new System.Drawing.Point(0, 370);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(25);
            this.pnlFooter.Size = new System.Drawing.Size(350, 100);
            this.pnlFooter.TabIndex = 16;
            // 
            // pbAbout
            // 
            this.pbAbout.BackColor = System.Drawing.Color.Transparent;
            this.pbAbout.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbAbout.BackColorOnDefault = System.Drawing.Color.Transparent;
            this.pbAbout.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pbAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAbout.EllipseOnClick = 40;
            this.pbAbout.EllipseOnDefault = 40;
            this.pbAbout.EllipseOnHover = 40;
            this.pbAbout.Image = global::ITSpecialProject.Properties.Resources.Help_32;
            this.pbAbout.Location = new System.Drawing.Point(240, 35);
            this.pbAbout.Margin = new System.Windows.Forms.Padding(0);
            this.pbAbout.Name = "pbAbout";
            this.pbAbout.Padding = new System.Windows.Forms.Padding(5);
            this.pbAbout.Size = new System.Drawing.Size(40, 40);
            this.pbAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAbout.TabIndex = 3;
            this.pbAbout.TabStop = false;
            this.pbAbout.ToolTip = "about.";
            this.pbAbout.Click += new System.EventHandler(this.PbAbout_Click);
            // 
            // pbConfiguration
            // 
            this.pbConfiguration.BackColor = System.Drawing.Color.Transparent;
            this.pbConfiguration.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbConfiguration.BackColorOnDefault = System.Drawing.Color.Transparent;
            this.pbConfiguration.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pbConfiguration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConfiguration.EllipseOnClick = 40;
            this.pbConfiguration.EllipseOnDefault = 40;
            this.pbConfiguration.EllipseOnHover = 40;
            this.pbConfiguration.Image = global::ITSpecialProject.Properties.Resources.Maintenance_48;
            this.pbConfiguration.Location = new System.Drawing.Point(285, 35);
            this.pbConfiguration.Margin = new System.Windows.Forms.Padding(0);
            this.pbConfiguration.Name = "pbConfiguration";
            this.pbConfiguration.Padding = new System.Windows.Forms.Padding(5);
            this.pbConfiguration.Size = new System.Drawing.Size(40, 40);
            this.pbConfiguration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbConfiguration.TabIndex = 2;
            this.pbConfiguration.TabStop = false;
            this.pbConfiguration.ToolTip = "configuration.";
            this.pbConfiguration.Click += new System.EventHandler(this.PbConfiguration_Click);
            // 
            // pbRefresh
            // 
            this.pbRefresh.BackColor = System.Drawing.Color.Transparent;
            this.pbRefresh.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbRefresh.BackColorOnDefault = System.Drawing.Color.Transparent;
            this.pbRefresh.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefresh.EllipseOnClick = 40;
            this.pbRefresh.EllipseOnDefault = 40;
            this.pbRefresh.EllipseOnHover = 40;
            this.pbRefresh.Image = global::ITSpecialProject.Properties.Resources.Refresh_32;
            this.pbRefresh.Location = new System.Drawing.Point(70, 35);
            this.pbRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Padding = new System.Windows.Forms.Padding(5);
            this.pbRefresh.Size = new System.Drawing.Size(40, 40);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbRefresh.TabIndex = 1;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.ToolTip = "refresh.";
            this.pbRefresh.Click += new System.EventHandler(this.PbRefresh_Click);
            // 
            // pbConnection
            // 
            this.pbConnection.BackColor = System.Drawing.Color.Transparent;
            this.pbConnection.BackColorOnClick = System.Drawing.Color.Transparent;
            this.pbConnection.BackColorOnDefault = System.Drawing.Color.Transparent;
            this.pbConnection.BackColorOnHover = System.Drawing.Color.Transparent;
            this.pbConnection.EllipseOnClick = 40;
            this.pbConnection.EllipseOnDefault = 40;
            this.pbConnection.EllipseOnHover = 40;
            this.pbConnection.Image = global::ITSpecialProject.Properties.Resources.Connected_32;
            this.pbConnection.Location = new System.Drawing.Point(25, 35);
            this.pbConnection.Margin = new System.Windows.Forms.Padding(0);
            this.pbConnection.Name = "pbConnection";
            this.pbConnection.Padding = new System.Windows.Forms.Padding(5);
            this.pbConnection.Size = new System.Drawing.Size(40, 40);
            this.pbConnection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbConnection.TabIndex = 0;
            this.pbConnection.TabStop = false;
            this.pbConnection.ToolTip = "connection state.";
            // 
            // txtUserPass
            // 
            this.txtUserPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUserPass.BackColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUserPass.BackColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUserPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtUserPass.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtUserPass.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtUserPass.FontOnLeave = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtUserPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUserPass.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.txtUserPass.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUserPass.InputValidation = ITSpecialProject.Components.FlatTextBox.Validation.None;
            this.txtUserPass.Location = new System.Drawing.Point(25, 205);
            this.txtUserPass.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.txtUserPass.MaxLength = 30;
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '•';
            this.txtUserPass.PlaceHolder = "Password";
            this.txtUserPass.ShortcutsEnabled = false;
            this.txtUserPass.Size = new System.Drawing.Size(300, 27);
            this.txtUserPass.TabIndex = 2;
            this.txtUserPass.TabStop = false;
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::ITSpecialProject.Properties.Resources.Amigoo_Logo_Circle;
            this.pbIcon.Location = new System.Drawing.Point(125, 15);
            this.pbIcon.Margin = new System.Windows.Forms.Padding(125, 15, 125, 15);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(100, 100);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUserName.BackColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUserName.BackColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtUserName.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtUserName.FontOnLeave = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUserName.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.txtUserName.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUserName.InputValidation = ITSpecialProject.Components.FlatTextBox.Validation.None;
            this.txtUserName.Location = new System.Drawing.Point(25, 150);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.txtUserName.MaxLength = 30;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceHolder = "Username";
            this.txtUserName.ShortcutsEnabled = false;
            this.txtUserName.Size = new System.Drawing.Size(300, 27);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.btnLogin.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(15)))));
            this.btnLogin.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.btnLogin.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(15)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.EllipseOnClick = 0;
            this.btnLogin.EllipseOnDefault = 0;
            this.btnLogin.EllipseOnHover = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(15)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(15)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.ForeColorOnClick = System.Drawing.Color.White;
            this.btnLogin.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnLogin.ForeColorOnHover = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(25, 260);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(25, 0, 25, 10);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 45);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "login";
            this.btnLogin.ToolTip = "login using credentials.";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(350, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(350, 30);
            this.pnlHeader.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(320, 30);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Login";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ForeColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClose.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnClose.ForeColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(320, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "r";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.ToolTip = "close.";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Image = global::ITSpecialProject.Properties.Resources.Amigoo_Banner_Orig;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(350, 500);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // LoginView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::ITSpecialProject.Properties.Resources.Amigoo_BG_Blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLogin);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlLogin.ResumeLayout(false);
            this.tlpCredentials.ResumeLayout(false);
            this.tlpCredentials.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfiguration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.FlatPanel pnlLogin;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Components.FlatButton btnClose;
        private System.Windows.Forms.TableLayoutPanel tlpCredentials;
        private Components.FlatTextBox txtUserPass;
        private System.Windows.Forms.PictureBox pbIcon;
        private Components.FlatTextBox txtUserName;
        private System.Windows.Forms.Panel pnlFooter;
        private Components.FlatPictureBox pbAbout;
        private Components.FlatPictureBox pbConfiguration;
        private Components.FlatPictureBox pbRefresh;
        private Components.FlatPictureBox pbConnection;
        private Components.FlatButton btnQrLogin;
        private Components.FlatButton btnLogin;
    }
}