namespace ITSpecialProject.Views.Utilities
{
    partial class PaginatorView
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
        /// NoInput method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpPaginator = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPaginatorR = new System.Windows.Forms.Panel();
            this.btnRefresh = new ITSpecialProject.Components.FlatButton();
            this.lblLastPage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLastPage = new ITSpecialProject.Components.FlatButton();
            this.btnNextPage = new ITSpecialProject.Components.FlatButton();
            this.btnFirstPage = new ITSpecialProject.Components.FlatButton();
            this.btnPreviousPage = new ITSpecialProject.Components.FlatButton();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.pnlPaginatorL = new System.Windows.Forms.Panel();
            this.cbRecords = new ITSpecialProject.Components.FlatComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpPaginator.SuspendLayout();
            this.pnlPaginatorR.SuspendLayout();
            this.pnlPaginatorL.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPaginator
            // 
            this.tlpPaginator.BackColor = System.Drawing.Color.Transparent;
            this.tlpPaginator.ColumnCount = 9;
            this.tlpPaginator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPaginator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPaginator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPaginator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPaginator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpPaginator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPaginator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPaginator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPaginator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPaginator.Controls.Add(this.pnlPaginatorR, 8, 0);
            this.tlpPaginator.Controls.Add(this.lblLastPage, 5, 0);
            this.tlpPaginator.Controls.Add(this.label2, 4, 0);
            this.tlpPaginator.Controls.Add(this.btnLastPage, 7, 0);
            this.tlpPaginator.Controls.Add(this.btnNextPage, 6, 0);
            this.tlpPaginator.Controls.Add(this.btnFirstPage, 1, 0);
            this.tlpPaginator.Controls.Add(this.btnPreviousPage, 2, 0);
            this.tlpPaginator.Controls.Add(this.lblCurrentPage, 3, 0);
            this.tlpPaginator.Controls.Add(this.pnlPaginatorL, 0, 0);
            this.tlpPaginator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaginator.Location = new System.Drawing.Point(0, 0);
            this.tlpPaginator.Name = "tlpPaginator";
            this.tlpPaginator.RowCount = 1;
            this.tlpPaginator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPaginator.Size = new System.Drawing.Size(600, 50);
            this.tlpPaginator.TabIndex = 14;
            // 
            // pnlPaginatorR
            // 
            this.pnlPaginatorR.Controls.Add(this.btnRefresh);
            this.pnlPaginatorR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaginatorR.Location = new System.Drawing.Point(452, 0);
            this.pnlPaginatorR.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPaginatorR.Name = "pnlPaginatorR";
            this.pnlPaginatorR.Size = new System.Drawing.Size(148, 50);
            this.pnlPaginatorR.TabIndex = 8;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.btnRefresh.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(15)))));
            this.btnRefresh.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.btnRefresh.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(15)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.EllipseOnClick = 0;
            this.btnRefresh.EllipseOnDefault = 0;
            this.btnRefresh.EllipseOnHover = 0;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(15)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(15)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.ForeColorOnClick = System.Drawing.Color.White;
            this.btnRefresh.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnRefresh.ForeColorOnHover = System.Drawing.Color.White;
            this.btnRefresh.Image = global::ITSpecialProject.Properties.Resources.RefreshLight_32;
            this.btnRefresh.Location = new System.Drawing.Point(98, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(50, 50);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.ToolTip = "";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblLastPage
            // 
            this.lblLastPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastPage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastPage.Location = new System.Drawing.Point(312, 0);
            this.lblLastPage.Margin = new System.Windows.Forms.Padding(0);
            this.lblLastPage.Name = "lblLastPage";
            this.lblLastPage.Size = new System.Drawing.Size(40, 50);
            this.lblLastPage.TabIndex = 5;
            this.lblLastPage.Text = "1";
            this.lblLastPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(155)))), ((int)(((byte)(20)))));
            this.btnLastPage.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnLastPage.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(155)))), ((int)(((byte)(20)))));
            this.btnLastPage.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnLastPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLastPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLastPage.EllipseOnClick = 0;
            this.btnLastPage.EllipseOnDefault = 0;
            this.btnLastPage.EllipseOnHover = 0;
            this.btnLastPage.FlatAppearance.BorderSize = 0;
            this.btnLastPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnLastPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPage.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnLastPage.ForeColor = System.Drawing.Color.White;
            this.btnLastPage.ForeColorOnClick = System.Drawing.Color.White;
            this.btnLastPage.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnLastPage.ForeColorOnHover = System.Drawing.Color.White;
            this.btnLastPage.Location = new System.Drawing.Point(402, 0);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(50, 50);
            this.btnLastPage.TabIndex = 3;
            this.btnLastPage.TabStop = false;
            this.btnLastPage.Text = "8";
            this.btnLastPage.ToolTip = "";
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.BtnLastPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnNextPage.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnNextPage.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnNextPage.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextPage.EllipseOnClick = 0;
            this.btnNextPage.EllipseOnDefault = 0;
            this.btnNextPage.EllipseOnHover = 0;
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnNextPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.ForeColorOnClick = System.Drawing.Color.White;
            this.btnNextPage.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnNextPage.ForeColorOnHover = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(352, 0);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(50, 50);
            this.btnNextPage.TabIndex = 3;
            this.btnNextPage.TabStop = false;
            this.btnNextPage.Text = "4";
            this.btnNextPage.ToolTip = "";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(155)))), ((int)(((byte)(20)))));
            this.btnFirstPage.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnFirstPage.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(155)))), ((int)(((byte)(20)))));
            this.btnFirstPage.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnFirstPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirstPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFirstPage.EllipseOnClick = 0;
            this.btnFirstPage.EllipseOnDefault = 0;
            this.btnFirstPage.EllipseOnHover = 0;
            this.btnFirstPage.FlatAppearance.BorderSize = 0;
            this.btnFirstPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnFirstPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPage.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnFirstPage.ForeColor = System.Drawing.Color.White;
            this.btnFirstPage.ForeColorOnClick = System.Drawing.Color.White;
            this.btnFirstPage.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnFirstPage.ForeColorOnHover = System.Drawing.Color.White;
            this.btnFirstPage.Location = new System.Drawing.Point(147, 0);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(50, 50);
            this.btnFirstPage.TabIndex = 0;
            this.btnFirstPage.TabStop = false;
            this.btnFirstPage.Text = "7";
            this.btnFirstPage.ToolTip = "";
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.BtnFirstPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnPreviousPage.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnPreviousPage.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnPreviousPage.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnPreviousPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviousPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPreviousPage.EllipseOnClick = 0;
            this.btnPreviousPage.EllipseOnDefault = 0;
            this.btnPreviousPage.EllipseOnHover = 0;
            this.btnPreviousPage.FlatAppearance.BorderSize = 0;
            this.btnPreviousPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnPreviousPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPage.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPreviousPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviousPage.ForeColorOnClick = System.Drawing.Color.White;
            this.btnPreviousPage.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnPreviousPage.ForeColorOnHover = System.Drawing.Color.White;
            this.btnPreviousPage.Location = new System.Drawing.Point(197, 0);
            this.btnPreviousPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(50, 50);
            this.btnPreviousPage.TabIndex = 1;
            this.btnPreviousPage.TabStop = false;
            this.btnPreviousPage.Text = "3";
            this.btnPreviousPage.ToolTip = "";
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            this.btnPreviousPage.Click += new System.EventHandler(this.BtnPreviousPage_Click);
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentPage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPage.Location = new System.Drawing.Point(247, 0);
            this.lblCurrentPage.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(40, 50);
            this.lblCurrentPage.TabIndex = 4;
            this.lblCurrentPage.Text = "1";
            this.lblCurrentPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPaginatorL
            // 
            this.pnlPaginatorL.Controls.Add(this.cbRecords);
            this.pnlPaginatorL.Controls.Add(this.label1);
            this.pnlPaginatorL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaginatorL.Location = new System.Drawing.Point(0, 0);
            this.pnlPaginatorL.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPaginatorL.Name = "pnlPaginatorL";
            this.pnlPaginatorL.Size = new System.Drawing.Size(147, 50);
            this.pnlPaginatorL.TabIndex = 6;
            // 
            // cbRecords
            // 
            this.cbRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.cbRecords.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(15)))));
            this.cbRecords.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.cbRecords.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(50)))), ((int)(((byte)(15)))));
            this.cbRecords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.cbRecords.ForeColor = System.Drawing.Color.White;
            this.cbRecords.ForeColorOnClick = System.Drawing.Color.White;
            this.cbRecords.ForeColorOnDefault = System.Drawing.Color.White;
            this.cbRecords.ForeColorOnHover = System.Drawing.Color.White;
            this.cbRecords.FormattingEnabled = true;
            this.cbRecords.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "50"});
            this.cbRecords.Location = new System.Drawing.Point(3, 19);
            this.cbRecords.Name = "cbRecords";
            this.cbRecords.Size = new System.Drawing.Size(75, 28);
            this.cbRecords.TabIndex = 1;
            this.cbRecords.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "record count:";
            // 
            // PaginatorView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlpPaginator);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PaginatorView";
            this.Size = new System.Drawing.Size(600, 50);
            this.tlpPaginator.ResumeLayout(false);
            this.pnlPaginatorR.ResumeLayout(false);
            this.pnlPaginatorL.ResumeLayout(false);
            this.pnlPaginatorL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPaginator;
        private System.Windows.Forms.Panel pnlPaginatorR;
        private Components.FlatButton btnRefresh;
        private System.Windows.Forms.Label lblLastPage;
        private System.Windows.Forms.Label label2;
        private Components.FlatButton btnLastPage;
        private Components.FlatButton btnNextPage;
        private Components.FlatButton btnFirstPage;
        private Components.FlatButton btnPreviousPage;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Panel pnlPaginatorL;
        private Components.FlatComboBox cbRecords;
        private System.Windows.Forms.Label label1;
    }
}
