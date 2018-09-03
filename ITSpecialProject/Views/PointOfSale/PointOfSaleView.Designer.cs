namespace ITSpecialProject.Views.PointOfSale
{
    partial class PointOfSaleView
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
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.flowInvoice = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInvoiceFooter = new System.Windows.Forms.Panel();
            this.btnPay = new ITSpecialProject.Components.FlatButton();
            this.tlpPayments = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.flowMenus = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pgMenu = new ITSpecialProject.Views.Utilities.PaginatorView();
            this.ucFilterView = new ITSpecialProject.Views.PointOfSale.FilterView();
            this.ucMenuCategory = new ITSpecialProject.Views.PointOfSale.MenuCategoryView();
            this.pnlInvoice.SuspendLayout();
            this.pnlInvoiceFooter.SuspendLayout();
            this.tlpPayments.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.flowMenus.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.pnlInvoice.Controls.Add(this.flowInvoice);
            this.pnlInvoice.Controls.Add(this.label1);
            this.pnlInvoice.Controls.Add(this.pnlInvoiceFooter);
            this.pnlInvoice.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInvoice.Location = new System.Drawing.Point(0, 0);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(325, 600);
            this.pnlInvoice.TabIndex = 5;
            // 
            // flowInvoice
            // 
            this.flowInvoice.AutoScroll = true;
            this.flowInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowInvoice.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowInvoice.Location = new System.Drawing.Point(0, 30);
            this.flowInvoice.Margin = new System.Windows.Forms.Padding(0);
            this.flowInvoice.Name = "flowInvoice";
            this.flowInvoice.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.flowInvoice.Size = new System.Drawing.Size(325, 420);
            this.flowInvoice.TabIndex = 2;
            this.flowInvoice.WrapContents = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInvoiceFooter
            // 
            this.pnlInvoiceFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.pnlInvoiceFooter.Controls.Add(this.btnPay);
            this.pnlInvoiceFooter.Controls.Add(this.tlpPayments);
            this.pnlInvoiceFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInvoiceFooter.Location = new System.Drawing.Point(0, 450);
            this.pnlInvoiceFooter.Name = "pnlInvoiceFooter";
            this.pnlInvoiceFooter.Size = new System.Drawing.Size(325, 150);
            this.pnlInvoiceFooter.TabIndex = 0;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnPay.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnPay.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.btnPay.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPay.EllipseOnClick = 0;
            this.btnPay.EllipseOnDefault = 0;
            this.btnPay.EllipseOnHover = 0;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.ForeColorOnClick = System.Drawing.Color.White;
            this.btnPay.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnPay.ForeColorOnHover = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(0, 75);
            this.btnPay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(325, 75);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "PAY\r\nP 0.00";
            this.btnPay.ToolTip = "";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // tlpPayments
            // 
            this.tlpPayments.ColumnCount = 2;
            this.tlpPayments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPayments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPayments.Controls.Add(this.panel2, 0, 0);
            this.tlpPayments.Controls.Add(this.panel3, 1, 0);
            this.tlpPayments.Controls.Add(this.panel4, 1, 1);
            this.tlpPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPayments.Location = new System.Drawing.Point(0, 0);
            this.tlpPayments.Name = "tlpPayments";
            this.tlpPayments.RowCount = 2;
            this.tlpPayments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPayments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPayments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPayments.Size = new System.Drawing.Size(325, 75);
            this.tlpPayments.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblSubTotal);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 35);
            this.panel2.TabIndex = 1;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubTotal.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(0, 15);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(162, 21);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "0.00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "sub total:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lblDiscount);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(162, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 35);
            this.panel3.TabIndex = 2;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiscount.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(0, 15);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(163, 21);
            this.lblDiscount.TabIndex = 1;
            this.lblDiscount.Text = "0%";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "discount:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lblNetAmount);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(162, 37);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 35);
            this.panel4.TabIndex = 3;
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNetAmount.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.lblNetAmount.Location = new System.Drawing.Point(0, 15);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.Size = new System.Drawing.Size(163, 21);
            this.lblNetAmount.TabIndex = 1;
            this.lblNetAmount.Text = "0.00";
            this.lblNetAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "net amount:";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBody.Controls.Add(this.flowMenus);
            this.pnlBody.Controls.Add(this.pgMenu);
            this.pnlBody.Controls.Add(this.ucFilterView);
            this.pnlBody.Controls.Add(this.ucMenuCategory);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(325, 0);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBody.Size = new System.Drawing.Size(675, 600);
            this.pnlBody.TabIndex = 6;
            // 
            // flowMenus
            // 
            this.flowMenus.AutoScroll = true;
            this.flowMenus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowMenus.Controls.Add(this.panel1);
            this.flowMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMenus.Location = new System.Drawing.Point(5, 105);
            this.flowMenus.Margin = new System.Windows.Forms.Padding(0);
            this.flowMenus.Name = "flowMenus";
            this.flowMenus.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.flowMenus.Size = new System.Drawing.Size(665, 440);
            this.flowMenus.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 35);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "0.00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "sub total:";
            // 
            // pgMenu
            // 
            this.pgMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.pgMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.pgMenu.ForeColor = System.Drawing.Color.White;
            this.pgMenu.HasRecordCount = true;
            this.pgMenu.HasRefresh = true;
            this.pgMenu.Location = new System.Drawing.Point(5, 545);
            this.pgMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pgMenu.Name = "pgMenu";
            this.pgMenu.Size = new System.Drawing.Size(665, 50);
            this.pgMenu.TabIndex = 18;
            // 
            // ucFilterView
            // 
            this.ucFilterView.BackColor = System.Drawing.Color.Transparent;
            this.ucFilterView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucFilterView.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ucFilterView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucFilterView.Location = new System.Drawing.Point(5, 60);
            this.ucFilterView.Margin = new System.Windows.Forms.Padding(0);
            this.ucFilterView.Name = "ucFilterView";
            this.ucFilterView.Size = new System.Drawing.Size(665, 45);
            this.ucFilterView.TabIndex = 12;
            // 
            // ucMenuCategory
            // 
            this.ucMenuCategory.BackColor = System.Drawing.Color.Transparent;
            this.ucMenuCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucMenuCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenuCategory.ForeColor = System.Drawing.Color.White;
            this.ucMenuCategory.Location = new System.Drawing.Point(5, 5);
            this.ucMenuCategory.Margin = new System.Windows.Forms.Padding(0);
            this.ucMenuCategory.Name = "ucMenuCategory";
            this.ucMenuCategory.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.ucMenuCategory.Size = new System.Drawing.Size(665, 55);
            this.ucMenuCategory.TabIndex = 11;
            // 
            // PointOfSaleView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlInvoice);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PointOfSaleView";
            this.Size = new System.Drawing.Size(1000, 600);
            this.pnlInvoice.ResumeLayout(false);
            this.pnlInvoiceFooter.ResumeLayout(false);
            this.tlpPayments.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.flowMenus.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.Panel pnlBody;
        private MenuCategoryView ucMenuCategory;
        private FilterView ucFilterView;
        private System.Windows.Forms.FlowLayoutPanel flowMenus;
        private Utilities.PaginatorView pgMenu;
        private System.Windows.Forms.FlowLayoutPanel flowInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlInvoiceFooter;
        private Components.FlatButton btnPay;
        private System.Windows.Forms.TableLayoutPanel tlpPayments;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
