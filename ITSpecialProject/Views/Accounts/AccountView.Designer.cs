namespace ITSpecialProject.Views.Accounts
{
    partial class AccountView
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

        #region Component Designer generated code

        /// <summary> 
        /// InputRequired method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flpAccountDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.pbAccount = new ITSpecialProject.Components.FlatPictureBox();
            this.lnkUpload = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new ITSpecialProject.Components.FlatTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new ITSpecialProject.Components.FlatTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new ITSpecialProject.Components.FlatTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserPass = new ITSpecialProject.Components.FlatTextBox();
            this.btnUpdateAccountDetails = new ITSpecialProject.Components.FlatButton();
            this.tlpAccountTab = new System.Windows.Forms.TableLayoutPanel();
            this.btnAccountActivities = new ITSpecialProject.Components.FlatButton();
            this.btnAccountAccess = new ITSpecialProject.Components.FlatButton();
            this.tcAccounts = new MaterialSkin.Controls.MaterialTabControl();
            this.tpAccountDetails = new System.Windows.Forms.TabPage();
            this.tpAccountAccess = new System.Windows.Forms.TabPage();
            this.tblUserAccess = new ITSpecialProject.Components.FlatTable();
            this.getModuleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessibleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addRecordDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.editRecordDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deleteRecordDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.generateReportDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsAccountAccess = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateAccountAccess = new ITSpecialProject.Components.FlatButton();
            this.tpAccountActivities = new System.Windows.Forms.TabPage();
            this.btnAccountDetails = new ITSpecialProject.Components.FlatButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeactivateAccount = new ITSpecialProject.Components.FlatButton();
            this.btnNewAccount = new ITSpecialProject.Components.FlatButton();
            this.pnlAccountList = new System.Windows.Forms.Panel();
            this.flpAccounts = new System.Windows.Forms.FlowLayoutPanel();
            this.pgAccount = new ITSpecialProject.Views.Utilities.PaginatorView();
            this.tlpFlagTab = new System.Windows.Forms.TableLayoutPanel();
            this.btnInactive = new ITSpecialProject.Components.FlatButton();
            this.btnActive = new ITSpecialProject.Components.FlatButton();
            this.txtSearch = new ITSpecialProject.Components.FlatTextBox();
            this.epAccountForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbEditMode = new ITSpecialProject.Components.FlatCheckBox();
            this.flpAccountDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount)).BeginInit();
            this.tlpAccountTab.SuspendLayout();
            this.tcAccounts.SuspendLayout();
            this.tpAccountDetails.SuspendLayout();
            this.tpAccountAccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccountAccess)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlAccountList.SuspendLayout();
            this.tlpFlagTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epAccountForm)).BeginInit();
            this.SuspendLayout();
            // 
            // flpAccountDetails
            // 
            this.flpAccountDetails.AutoScroll = true;
            this.flpAccountDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.flpAccountDetails.Controls.Add(this.pbAccount);
            this.flpAccountDetails.Controls.Add(this.lnkUpload);
            this.flpAccountDetails.Controls.Add(this.label1);
            this.flpAccountDetails.Controls.Add(this.txtFirstName);
            this.flpAccountDetails.Controls.Add(this.label2);
            this.flpAccountDetails.Controls.Add(this.txtLastName);
            this.flpAccountDetails.Controls.Add(this.label3);
            this.flpAccountDetails.Controls.Add(this.txtUserName);
            this.flpAccountDetails.Controls.Add(this.label4);
            this.flpAccountDetails.Controls.Add(this.txtUserPass);
            this.flpAccountDetails.Controls.Add(this.btnUpdateAccountDetails);
            this.flpAccountDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpAccountDetails.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAccountDetails.Location = new System.Drawing.Point(236, 0);
            this.flpAccountDetails.Margin = new System.Windows.Forms.Padding(0);
            this.flpAccountDetails.Name = "flpAccountDetails";
            this.flpAccountDetails.Padding = new System.Windows.Forms.Padding(25);
            this.flpAccountDetails.Size = new System.Drawing.Size(300, 431);
            this.flpAccountDetails.TabIndex = 2;
            this.flpAccountDetails.WrapContents = false;
            // 
            // pbAccount
            // 
            this.pbAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.pbAccount.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.pbAccount.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.pbAccount.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.pbAccount.EllipseOnClick = 0;
            this.pbAccount.EllipseOnDefault = 0;
            this.pbAccount.EllipseOnHover = 0;
            this.pbAccount.Image = global::ITSpecialProject.Properties.Resources.Account_100;
            this.pbAccount.Location = new System.Drawing.Point(100, 25);
            this.pbAccount.Margin = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.pbAccount.Name = "pbAccount";
            this.pbAccount.Padding = new System.Windows.Forms.Padding(5);
            this.pbAccount.Size = new System.Drawing.Size(100, 100);
            this.pbAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAccount.TabIndex = 1;
            this.pbAccount.TabStop = false;
            this.pbAccount.ToolTip = "";
            // 
            // lnkUpload
            // 
            this.lnkUpload.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.lnkUpload.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.lnkUpload.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkUpload.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.lnkUpload.Location = new System.Drawing.Point(100, 125);
            this.lnkUpload.Margin = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.lnkUpload.Name = "lnkUpload";
            this.lnkUpload.Size = new System.Drawing.Size(100, 25);
            this.lnkUpload.TabIndex = 2;
            this.lnkUpload.TabStop = true;
            this.lnkUpload.Text = "upload";
            this.lnkUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkUpload.Visible = false;
            this.lnkUpload.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtFirstName.BackColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtFirstName.BackColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtFirstName.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtFirstName.FontOnLeave = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtFirstName.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtFirstName.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtFirstName.InputValidation = ITSpecialProject.Components.FlatTextBox.Validation.Alphabet;
            this.txtFirstName.Location = new System.Drawing.Point(25, 192);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceHolder = null;
            this.txtFirstName.ShortcutsEnabled = false;
            this.txtFirstName.Size = new System.Drawing.Size(250, 27);
            this.txtFirstName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtLastName.BackColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtLastName.BackColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtLastName.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtLastName.FontOnLeave = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtLastName.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtLastName.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtLastName.InputValidation = ITSpecialProject.Components.FlatTextBox.Validation.Alphabet;
            this.txtLastName.Location = new System.Drawing.Point(25, 241);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceHolder = null;
            this.txtLastName.ShortcutsEnabled = false;
            this.txtLastName.Size = new System.Drawing.Size(250, 27);
            this.txtLastName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username:";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUserName.BackColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUserName.BackColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtUserName.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtUserName.FontOnLeave = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUserName.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUserName.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUserName.InputValidation = ITSpecialProject.Components.FlatTextBox.Validation.AlphabetNoSpace;
            this.txtUserName.Location = new System.Drawing.Point(25, 310);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtUserName.MaxLength = 30;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceHolder = null;
            this.txtUserName.ShortcutsEnabled = false;
            this.txtUserName.Size = new System.Drawing.Size(250, 27);
            this.txtUserName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            // 
            // txtUserPass
            // 
            this.txtUserPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUserPass.BackColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUserPass.BackColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUserPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
            this.txtUserPass.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtUserPass.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtUserPass.FontOnLeave = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtUserPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUserPass.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUserPass.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtUserPass.InputValidation = ITSpecialProject.Components.FlatTextBox.Validation.AlphaNumericNoSpace;
            this.txtUserPass.Location = new System.Drawing.Point(25, 359);
            this.txtUserPass.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.txtUserPass.MaxLength = 30;
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '•';
            this.txtUserPass.PlaceHolder = null;
            this.txtUserPass.ShortcutsEnabled = false;
            this.txtUserPass.Size = new System.Drawing.Size(250, 27);
            this.txtUserPass.TabIndex = 10;
            // 
            // btnUpdateAccountDetails
            // 
            this.btnUpdateAccountDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnUpdateAccountDetails.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnUpdateAccountDetails.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnUpdateAccountDetails.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnUpdateAccountDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAccountDetails.EllipseOnClick = 0;
            this.btnUpdateAccountDetails.EllipseOnDefault = 0;
            this.btnUpdateAccountDetails.EllipseOnHover = 0;
            this.btnUpdateAccountDetails.FlatAppearance.BorderSize = 0;
            this.btnUpdateAccountDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnUpdateAccountDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnUpdateAccountDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAccountDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnUpdateAccountDetails.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAccountDetails.ForeColorOnClick = System.Drawing.Color.White;
            this.btnUpdateAccountDetails.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnUpdateAccountDetails.ForeColorOnHover = System.Drawing.Color.White;
            this.btnUpdateAccountDetails.Location = new System.Drawing.Point(25, 411);
            this.btnUpdateAccountDetails.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btnUpdateAccountDetails.Name = "btnUpdateAccountDetails";
            this.btnUpdateAccountDetails.Size = new System.Drawing.Size(250, 50);
            this.btnUpdateAccountDetails.TabIndex = 11;
            this.btnUpdateAccountDetails.TabStop = false;
            this.btnUpdateAccountDetails.Text = "save changes";
            this.btnUpdateAccountDetails.ToolTip = "";
            this.btnUpdateAccountDetails.UseVisualStyleBackColor = false;
            this.btnUpdateAccountDetails.Visible = false;
            this.btnUpdateAccountDetails.Click += new System.EventHandler(this.BtnUpdateAccountDetails_Click);
            // 
            // tlpAccountTab
            // 
            this.tlpAccountTab.ColumnCount = 3;
            this.tlpAccountTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpAccountTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpAccountTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpAccountTab.Controls.Add(this.btnAccountActivities, 2, 0);
            this.tlpAccountTab.Controls.Add(this.btnAccountAccess, 1, 0);
            this.tlpAccountTab.Controls.Add(this.tcAccounts, 0, 1);
            this.tlpAccountTab.Controls.Add(this.btnAccountDetails, 0, 0);
            this.tlpAccountTab.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tlpAccountTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAccountTab.Location = new System.Drawing.Point(450, 30);
            this.tlpAccountTab.Name = "tlpAccountTab";
            this.tlpAccountTab.RowCount = 3;
            this.tlpAccountTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAccountTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAccountTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAccountTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAccountTab.Size = new System.Drawing.Size(550, 570);
            this.tlpAccountTab.TabIndex = 3;
            // 
            // btnAccountActivities
            // 
            this.btnAccountActivities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnAccountActivities.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnAccountActivities.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnAccountActivities.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnAccountActivities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccountActivities.EllipseOnClick = 0;
            this.btnAccountActivities.EllipseOnDefault = 0;
            this.btnAccountActivities.EllipseOnHover = 0;
            this.btnAccountActivities.FlatAppearance.BorderSize = 0;
            this.btnAccountActivities.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnAccountActivities.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnAccountActivities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountActivities.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnAccountActivities.ForeColor = System.Drawing.Color.White;
            this.btnAccountActivities.ForeColorOnClick = System.Drawing.Color.White;
            this.btnAccountActivities.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnAccountActivities.ForeColorOnHover = System.Drawing.Color.White;
            this.btnAccountActivities.Location = new System.Drawing.Point(367, 2);
            this.btnAccountActivities.Margin = new System.Windows.Forms.Padding(1, 2, 0, 2);
            this.btnAccountActivities.Name = "btnAccountActivities";
            this.btnAccountActivities.Size = new System.Drawing.Size(183, 46);
            this.btnAccountActivities.TabIndex = 3;
            this.btnAccountActivities.TabStop = false;
            this.btnAccountActivities.Text = "account activities";
            this.btnAccountActivities.ToolTip = "";
            this.btnAccountActivities.UseVisualStyleBackColor = false;
            this.btnAccountActivities.Click += new System.EventHandler(this.BtnAccountActivities_Click);
            // 
            // btnAccountAccess
            // 
            this.btnAccountAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnAccountAccess.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnAccountAccess.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnAccountAccess.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnAccountAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccountAccess.EllipseOnClick = 0;
            this.btnAccountAccess.EllipseOnDefault = 0;
            this.btnAccountAccess.EllipseOnHover = 0;
            this.btnAccountAccess.FlatAppearance.BorderSize = 0;
            this.btnAccountAccess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnAccountAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnAccountAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountAccess.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnAccountAccess.ForeColor = System.Drawing.Color.White;
            this.btnAccountAccess.ForeColorOnClick = System.Drawing.Color.White;
            this.btnAccountAccess.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnAccountAccess.ForeColorOnHover = System.Drawing.Color.White;
            this.btnAccountAccess.Location = new System.Drawing.Point(184, 2);
            this.btnAccountAccess.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAccountAccess.Name = "btnAccountAccess";
            this.btnAccountAccess.Size = new System.Drawing.Size(181, 46);
            this.btnAccountAccess.TabIndex = 2;
            this.btnAccountAccess.TabStop = false;
            this.btnAccountAccess.Text = "account access";
            this.btnAccountAccess.ToolTip = "";
            this.btnAccountAccess.UseVisualStyleBackColor = false;
            this.btnAccountAccess.Click += new System.EventHandler(this.BtnAccountAccess_Click);
            // 
            // tcAccounts
            // 
            this.tlpAccountTab.SetColumnSpan(this.tcAccounts, 3);
            this.tcAccounts.Controls.Add(this.tpAccountDetails);
            this.tcAccounts.Controls.Add(this.tpAccountAccess);
            this.tcAccounts.Controls.Add(this.tpAccountActivities);
            this.tcAccounts.Depth = 0;
            this.tcAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAccounts.Location = new System.Drawing.Point(3, 53);
            this.tcAccounts.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcAccounts.Name = "tcAccounts";
            this.tcAccounts.SelectedIndex = 0;
            this.tcAccounts.Size = new System.Drawing.Size(544, 464);
            this.tcAccounts.TabIndex = 0;
            // 
            // tpAccountDetails
            // 
            this.tpAccountDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpAccountDetails.Controls.Add(this.flpAccountDetails);
            this.tpAccountDetails.Location = new System.Drawing.Point(4, 29);
            this.tpAccountDetails.Margin = new System.Windows.Forms.Padding(0);
            this.tpAccountDetails.Name = "tpAccountDetails";
            this.tpAccountDetails.Size = new System.Drawing.Size(536, 431);
            this.tpAccountDetails.TabIndex = 0;
            this.tpAccountDetails.Text = "Account Details";
            // 
            // tpAccountAccess
            // 
            this.tpAccountAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpAccountAccess.Controls.Add(this.tblUserAccess);
            this.tpAccountAccess.Controls.Add(this.panel1);
            this.tpAccountAccess.Location = new System.Drawing.Point(4, 29);
            this.tpAccountAccess.Margin = new System.Windows.Forms.Padding(0);
            this.tpAccountAccess.Name = "tpAccountAccess";
            this.tpAccountAccess.Size = new System.Drawing.Size(536, 431);
            this.tpAccountAccess.TabIndex = 1;
            this.tpAccountAccess.Text = "Account Access";
            // 
            // tblUserAccess
            // 
            this.tblUserAccess.AllowUserToAddRows = false;
            this.tblUserAccess.AllowUserToDeleteRows = false;
            this.tblUserAccess.AllowUserToResizeColumns = false;
            this.tblUserAccess.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.tblUserAccess.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblUserAccess.AutoGenerateColumns = false;
            this.tblUserAccess.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblUserAccess.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tblUserAccess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblUserAccess.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tblUserAccess.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblUserAccess.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblUserAccess.ColumnHeadersHeight = 30;
            this.tblUserAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblUserAccess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.getModuleNameDataGridViewTextBoxColumn,
            this.accessibleDataGridViewCheckBoxColumn,
            this.addRecordDataGridViewCheckBoxColumn,
            this.editRecordDataGridViewCheckBoxColumn,
            this.deleteRecordDataGridViewCheckBoxColumn,
            this.generateReportDataGridViewCheckBoxColumn});
            this.tblUserAccess.DataSource = this.bsAccountAccess;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblUserAccess.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblUserAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblUserAccess.EllipseOnDefault = 0;
            this.tblUserAccess.EnableHeadersVisualStyles = false;
            this.tblUserAccess.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.tblUserAccess.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.tblUserAccess.Location = new System.Drawing.Point(0, 0);
            this.tblUserAccess.Margin = new System.Windows.Forms.Padding(0);
            this.tblUserAccess.MultiSelect = false;
            this.tblUserAccess.Name = "tblUserAccess";
            this.tblUserAccess.ReadOnly = true;
            this.tblUserAccess.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblUserAccess.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tblUserAccess.RowHeadersVisible = false;
            this.tblUserAccess.RowHeadersWidth = 10;
            this.tblUserAccess.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblUserAccess.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tblUserAccess.RowTemplate.Height = 40;
            this.tblUserAccess.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tblUserAccess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblUserAccess.ShowCellErrors = false;
            this.tblUserAccess.ShowCellToolTips = false;
            this.tblUserAccess.ShowEditingIcon = false;
            this.tblUserAccess.ShowRowErrors = false;
            this.tblUserAccess.Size = new System.Drawing.Size(536, 371);
            this.tblUserAccess.TabIndex = 7;
            // 
            // getModuleNameDataGridViewTextBoxColumn
            // 
            this.getModuleNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.getModuleNameDataGridViewTextBoxColumn.DataPropertyName = "GetModuleName";
            this.getModuleNameDataGridViewTextBoxColumn.HeaderText = "Module";
            this.getModuleNameDataGridViewTextBoxColumn.Name = "getModuleNameDataGridViewTextBoxColumn";
            this.getModuleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accessibleDataGridViewCheckBoxColumn
            // 
            this.accessibleDataGridViewCheckBoxColumn.DataPropertyName = "Accessible";
            this.accessibleDataGridViewCheckBoxColumn.HeaderText = "Access";
            this.accessibleDataGridViewCheckBoxColumn.Name = "accessibleDataGridViewCheckBoxColumn";
            this.accessibleDataGridViewCheckBoxColumn.ReadOnly = true;
            this.accessibleDataGridViewCheckBoxColumn.Width = 70;
            // 
            // addRecordDataGridViewCheckBoxColumn
            // 
            this.addRecordDataGridViewCheckBoxColumn.DataPropertyName = "AddRecord";
            this.addRecordDataGridViewCheckBoxColumn.HeaderText = "Add";
            this.addRecordDataGridViewCheckBoxColumn.Name = "addRecordDataGridViewCheckBoxColumn";
            this.addRecordDataGridViewCheckBoxColumn.ReadOnly = true;
            this.addRecordDataGridViewCheckBoxColumn.Width = 70;
            // 
            // editRecordDataGridViewCheckBoxColumn
            // 
            this.editRecordDataGridViewCheckBoxColumn.DataPropertyName = "EditRecord";
            this.editRecordDataGridViewCheckBoxColumn.HeaderText = "Edit";
            this.editRecordDataGridViewCheckBoxColumn.Name = "editRecordDataGridViewCheckBoxColumn";
            this.editRecordDataGridViewCheckBoxColumn.ReadOnly = true;
            this.editRecordDataGridViewCheckBoxColumn.Width = 70;
            // 
            // deleteRecordDataGridViewCheckBoxColumn
            // 
            this.deleteRecordDataGridViewCheckBoxColumn.DataPropertyName = "DeleteRecord";
            this.deleteRecordDataGridViewCheckBoxColumn.HeaderText = "Delete";
            this.deleteRecordDataGridViewCheckBoxColumn.Name = "deleteRecordDataGridViewCheckBoxColumn";
            this.deleteRecordDataGridViewCheckBoxColumn.ReadOnly = true;
            this.deleteRecordDataGridViewCheckBoxColumn.Width = 70;
            // 
            // generateReportDataGridViewCheckBoxColumn
            // 
            this.generateReportDataGridViewCheckBoxColumn.DataPropertyName = "GenerateReport";
            this.generateReportDataGridViewCheckBoxColumn.HeaderText = "Report";
            this.generateReportDataGridViewCheckBoxColumn.Name = "generateReportDataGridViewCheckBoxColumn";
            this.generateReportDataGridViewCheckBoxColumn.ReadOnly = true;
            this.generateReportDataGridViewCheckBoxColumn.Width = 70;
            // 
            // bsAccountAccess
            // 
            this.bsAccountAccess.DataSource = typeof(DataLayer.Core.Model.AccountAccess);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateAccountAccess);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 371);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(536, 60);
            this.panel1.TabIndex = 8;
            // 
            // btnUpdateAccountAccess
            // 
            this.btnUpdateAccountAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnUpdateAccountAccess.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnUpdateAccountAccess.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnUpdateAccountAccess.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnUpdateAccountAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAccountAccess.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUpdateAccountAccess.EllipseOnClick = 0;
            this.btnUpdateAccountAccess.EllipseOnDefault = 0;
            this.btnUpdateAccountAccess.EllipseOnHover = 0;
            this.btnUpdateAccountAccess.FlatAppearance.BorderSize = 0;
            this.btnUpdateAccountAccess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnUpdateAccountAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnUpdateAccountAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAccountAccess.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnUpdateAccountAccess.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAccountAccess.ForeColorOnClick = System.Drawing.Color.White;
            this.btnUpdateAccountAccess.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnUpdateAccountAccess.ForeColorOnHover = System.Drawing.Color.White;
            this.btnUpdateAccountAccess.Location = new System.Drawing.Point(281, 5);
            this.btnUpdateAccountAccess.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdateAccountAccess.Name = "btnUpdateAccountAccess";
            this.btnUpdateAccountAccess.Size = new System.Drawing.Size(250, 50);
            this.btnUpdateAccountAccess.TabIndex = 12;
            this.btnUpdateAccountAccess.TabStop = false;
            this.btnUpdateAccountAccess.Text = "save changes";
            this.btnUpdateAccountAccess.ToolTip = "";
            this.btnUpdateAccountAccess.UseVisualStyleBackColor = false;
            this.btnUpdateAccountAccess.Visible = false;
            this.btnUpdateAccountAccess.Click += new System.EventHandler(this.BtnUpdateAccountAccess_Click);
            // 
            // tpAccountActivities
            // 
            this.tpAccountActivities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpAccountActivities.Location = new System.Drawing.Point(4, 22);
            this.tpAccountActivities.Margin = new System.Windows.Forms.Padding(0);
            this.tpAccountActivities.Name = "tpAccountActivities";
            this.tpAccountActivities.Size = new System.Drawing.Size(536, 438);
            this.tpAccountActivities.TabIndex = 2;
            this.tpAccountActivities.Text = "Account Activities";
            // 
            // btnAccountDetails
            // 
            this.btnAccountDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnAccountDetails.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnAccountDetails.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnAccountDetails.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnAccountDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccountDetails.EllipseOnClick = 0;
            this.btnAccountDetails.EllipseOnDefault = 0;
            this.btnAccountDetails.EllipseOnHover = 0;
            this.btnAccountDetails.FlatAppearance.BorderSize = 0;
            this.btnAccountDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnAccountDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnAccountDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnAccountDetails.ForeColor = System.Drawing.Color.White;
            this.btnAccountDetails.ForeColorOnClick = System.Drawing.Color.White;
            this.btnAccountDetails.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnAccountDetails.ForeColorOnHover = System.Drawing.Color.White;
            this.btnAccountDetails.Location = new System.Drawing.Point(0, 2);
            this.btnAccountDetails.Margin = new System.Windows.Forms.Padding(0, 2, 1, 2);
            this.btnAccountDetails.Name = "btnAccountDetails";
            this.btnAccountDetails.Size = new System.Drawing.Size(182, 46);
            this.btnAccountDetails.TabIndex = 1;
            this.btnAccountDetails.TabStop = false;
            this.btnAccountDetails.Text = "account details";
            this.btnAccountDetails.ToolTip = "";
            this.btnAccountDetails.UseVisualStyleBackColor = false;
            this.btnAccountDetails.Click += new System.EventHandler(this.BtnAccountDetails_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tlpAccountTab.SetColumnSpan(this.tableLayoutPanel1, 3);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.Controls.Add(this.btnDeactivateAccount, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNewAccount, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 520);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 50);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnDeactivateAccount
            // 
            this.btnDeactivateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeactivateAccount.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeactivateAccount.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeactivateAccount.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeactivateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeactivateAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeactivateAccount.EllipseOnClick = 0;
            this.btnDeactivateAccount.EllipseOnDefault = 0;
            this.btnDeactivateAccount.EllipseOnHover = 0;
            this.btnDeactivateAccount.FlatAppearance.BorderSize = 0;
            this.btnDeactivateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeactivateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeactivateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeactivateAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnDeactivateAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeactivateAccount.ForeColorOnClick = System.Drawing.Color.White;
            this.btnDeactivateAccount.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnDeactivateAccount.ForeColorOnHover = System.Drawing.Color.White;
            this.btnDeactivateAccount.Location = new System.Drawing.Point(367, 1);
            this.btnDeactivateAccount.Margin = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.btnDeactivateAccount.Name = "btnDeactivateAccount";
            this.btnDeactivateAccount.Size = new System.Drawing.Size(182, 47);
            this.btnDeactivateAccount.TabIndex = 18;
            this.btnDeactivateAccount.TabStop = false;
            this.btnDeactivateAccount.Text = "deactivate account";
            this.btnDeactivateAccount.ToolTip = "";
            this.btnDeactivateAccount.UseVisualStyleBackColor = false;
            this.btnDeactivateAccount.Click += new System.EventHandler(this.BtnDeactivateAccount_Click);
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnNewAccount.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnNewAccount.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnNewAccount.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnNewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewAccount.EllipseOnClick = 0;
            this.btnNewAccount.EllipseOnDefault = 0;
            this.btnNewAccount.EllipseOnHover = 0;
            this.btnNewAccount.FlatAppearance.BorderSize = 0;
            this.btnNewAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnNewAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnNewAccount.ForeColor = System.Drawing.Color.White;
            this.btnNewAccount.ForeColorOnClick = System.Drawing.Color.White;
            this.btnNewAccount.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnNewAccount.ForeColorOnHover = System.Drawing.Color.White;
            this.btnNewAccount.Location = new System.Drawing.Point(184, 1);
            this.btnNewAccount.Margin = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(181, 47);
            this.btnNewAccount.TabIndex = 17;
            this.btnNewAccount.TabStop = false;
            this.btnNewAccount.Text = "new account";
            this.btnNewAccount.ToolTip = "";
            this.btnNewAccount.UseVisualStyleBackColor = false;
            this.btnNewAccount.Click += new System.EventHandler(this.BtnNewAccount_Click);
            // 
            // pnlAccountList
            // 
            this.pnlAccountList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.pnlAccountList.Controls.Add(this.flpAccounts);
            this.pnlAccountList.Controls.Add(this.pgAccount);
            this.pnlAccountList.Controls.Add(this.tlpFlagTab);
            this.pnlAccountList.Controls.Add(this.txtSearch);
            this.pnlAccountList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccountList.Location = new System.Drawing.Point(0, 0);
            this.pnlAccountList.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAccountList.Name = "pnlAccountList";
            this.pnlAccountList.Padding = new System.Windows.Forms.Padding(5);
            this.pnlAccountList.Size = new System.Drawing.Size(450, 600);
            this.pnlAccountList.TabIndex = 4;
            // 
            // flpAccounts
            // 
            this.flpAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpAccounts.AutoScroll = true;
            this.flpAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.flpAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAccounts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAccounts.Location = new System.Drawing.Point(5, 92);
            this.flpAccounts.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.flpAccounts.Name = "flpAccounts";
            this.flpAccounts.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.flpAccounts.Size = new System.Drawing.Size(440, 451);
            this.flpAccounts.TabIndex = 8;
            this.flpAccounts.WrapContents = false;
            // 
            // pgAccount
            // 
            this.pgAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.pgAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgAccount.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.pgAccount.ForeColor = System.Drawing.Color.White;
            this.pgAccount.HasRecordCount = false;
            this.pgAccount.HasRefresh = true;
            this.pgAccount.Location = new System.Drawing.Point(5, 545);
            this.pgAccount.Margin = new System.Windows.Forms.Padding(0);
            this.pgAccount.Name = "pgAccount";
            this.pgAccount.Size = new System.Drawing.Size(440, 50);
            this.pgAccount.TabIndex = 7;
            this.pgAccount.PageNavigationButtonClicked += new System.EventHandler(this.PgAccount_PageNavigationButtonClicked);
            this.pgAccount.RefreshButtonClicked += new System.EventHandler(this.PgAccount_RefreshButtonClicked);
            // 
            // tlpFlagTab
            // 
            this.tlpFlagTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpFlagTab.ColumnCount = 2;
            this.tlpFlagTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFlagTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFlagTab.Controls.Add(this.btnInactive, 1, 0);
            this.tlpFlagTab.Controls.Add(this.btnActive, 0, 0);
            this.tlpFlagTab.Location = new System.Drawing.Point(5, 40);
            this.tlpFlagTab.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tlpFlagTab.Name = "tlpFlagTab";
            this.tlpFlagTab.RowCount = 1;
            this.tlpFlagTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFlagTab.Size = new System.Drawing.Size(440, 50);
            this.tlpFlagTab.TabIndex = 3;
            // 
            // btnInactive
            // 
            this.btnInactive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnInactive.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnInactive.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnInactive.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnInactive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInactive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInactive.EllipseOnClick = 0;
            this.btnInactive.EllipseOnDefault = 0;
            this.btnInactive.EllipseOnHover = 0;
            this.btnInactive.FlatAppearance.BorderSize = 0;
            this.btnInactive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnInactive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInactive.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnInactive.ForeColor = System.Drawing.Color.White;
            this.btnInactive.ForeColorOnClick = System.Drawing.Color.White;
            this.btnInactive.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnInactive.ForeColorOnHover = System.Drawing.Color.White;
            this.btnInactive.Location = new System.Drawing.Point(221, 0);
            this.btnInactive.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnInactive.Name = "btnInactive";
            this.btnInactive.Size = new System.Drawing.Size(219, 50);
            this.btnInactive.TabIndex = 1;
            this.btnInactive.TabStop = false;
            this.btnInactive.Text = "inactive";
            this.btnInactive.ToolTip = "";
            this.btnInactive.UseVisualStyleBackColor = false;
            this.btnInactive.Click += new System.EventHandler(this.BtnInactive_Click);
            // 
            // btnActive
            // 
            this.btnActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnActive.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnActive.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnActive.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActive.EllipseOnClick = 0;
            this.btnActive.EllipseOnDefault = 0;
            this.btnActive.EllipseOnHover = 0;
            this.btnActive.FlatAppearance.BorderSize = 0;
            this.btnActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnActive.ForeColor = System.Drawing.Color.White;
            this.btnActive.ForeColorOnClick = System.Drawing.Color.White;
            this.btnActive.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnActive.ForeColorOnHover = System.Drawing.Color.White;
            this.btnActive.Location = new System.Drawing.Point(0, 0);
            this.btnActive.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(219, 50);
            this.btnActive.TabIndex = 0;
            this.btnActive.TabStop = false;
            this.btnActive.Text = "active";
            this.btnActive.ToolTip = "";
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.BtnActive_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtSearch.BackColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtSearch.BackColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.FontOnEnter = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.txtSearch.FontOnLeave = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSearch.ForeColorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSearch.ForeColorOnLeave = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSearch.InputValidation = ITSpecialProject.Components.FlatTextBox.Validation.Alphabet;
            this.txtSearch.Location = new System.Drawing.Point(5, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.MaxLength = 100;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceHolder = "search name...";
            this.txtSearch.Size = new System.Drawing.Size(440, 33);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // epAccountForm
            // 
            this.epAccountForm.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epAccountForm.ContainerControl = this;
            // 
            // cbEditMode
            // 
            this.cbEditMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbEditMode.BackColorOnCheck = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.cbEditMode.BackColorOnUncheck = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbEditMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEditMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbEditMode.EllipseOnCheck = 0;
            this.cbEditMode.EllipseOnUncheck = 0;
            this.cbEditMode.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.cbEditMode.FontOnCheck = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.cbEditMode.FontOnUncheck = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.cbEditMode.ForeColor = System.Drawing.Color.White;
            this.cbEditMode.ForeColorOnCheck = System.Drawing.Color.White;
            this.cbEditMode.ForeColorOnUncheck = System.Drawing.Color.White;
            this.cbEditMode.Location = new System.Drawing.Point(450, 0);
            this.cbEditMode.Name = "cbEditMode";
            this.cbEditMode.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cbEditMode.Size = new System.Drawing.Size(550, 30);
            this.cbEditMode.TabIndex = 1;
            this.cbEditMode.Text = "edit mode: OFF";
            this.cbEditMode.UseVisualStyleBackColor = false;
            // 
            // AccountView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tlpAccountTab);
            this.Controls.Add(this.cbEditMode);
            this.Controls.Add(this.pnlAccountList);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AccountView";
            this.Size = new System.Drawing.Size(1000, 600);
            this.flpAccountDetails.ResumeLayout(false);
            this.flpAccountDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount)).EndInit();
            this.tlpAccountTab.ResumeLayout(false);
            this.tcAccounts.ResumeLayout(false);
            this.tpAccountDetails.ResumeLayout(false);
            this.tpAccountAccess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblUserAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccountAccess)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlAccountList.ResumeLayout(false);
            this.pnlAccountList.PerformLayout();
            this.tlpFlagTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epAccountForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.FlatCheckBox cbEditMode;
        private System.Windows.Forms.FlowLayoutPanel flpAccountDetails;
        private Components.FlatPictureBox pbAccount;
        private System.Windows.Forms.LinkLabel lnkUpload;
        private System.Windows.Forms.Label label1;
        private Components.FlatTextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private Components.FlatTextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private Components.FlatTextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private Components.FlatTextBox txtUserPass;
        private System.Windows.Forms.BindingSource bsAccountAccess;
        private System.Windows.Forms.TableLayoutPanel tlpAccountTab;
        private Components.FlatButton btnAccountActivities;
        private Components.FlatButton btnAccountAccess;
        private MaterialSkin.Controls.MaterialTabControl tcAccounts;
        private System.Windows.Forms.TabPage tpAccountDetails;
        private System.Windows.Forms.TabPage tpAccountAccess;
        private Components.FlatTable tblUserAccess;
        private System.Windows.Forms.TabPage tpAccountActivities;
        private Components.FlatButton btnAccountDetails;
        private System.Windows.Forms.Panel pnlAccountList;
        private Components.FlatTextBox txtSearch;
        private System.Windows.Forms.TableLayoutPanel tlpFlagTab;
        private Components.FlatButton btnInactive;
        private Components.FlatButton btnActive;
        private Utilities.PaginatorView pgAccount;
        private System.Windows.Forms.FlowLayoutPanel flpAccounts;
        private Components.FlatButton btnUpdateAccountDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn getModuleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn accessibleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addRecordDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn editRecordDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deleteRecordDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn generateReportDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private Components.FlatButton btnUpdateAccountAccess;
        private System.Windows.Forms.ErrorProvider epAccountForm;
        private Components.FlatButton btnDeactivateAccount;
        private Components.FlatButton btnNewAccount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
