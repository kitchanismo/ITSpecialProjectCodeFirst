namespace ITSpecialProject.Views.Accounts
{
    partial class AccountCardView
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
            this.pnlFlag = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEdit = new ITSpecialProject.Components.FlatButton();
            this.btnDelete = new ITSpecialProject.Components.FlatButton();
            this.pbAccountImage = new ITSpecialProject.Components.FlatPictureBox();
            this.pnlFiller = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccountImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFlag
            // 
            this.pnlFlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.pnlFlag.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFlag.Location = new System.Drawing.Point(0, 0);
            this.pnlFlag.Name = "pnlFlag";
            this.pnlFlag.Size = new System.Drawing.Size(5, 100);
            this.pnlFlag.TabIndex = 4;
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.lblUserName.Location = new System.Drawing.Point(105, 0);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Padding = new System.Windows.Forms.Padding(2);
            this.lblUserName.Size = new System.Drawing.Size(295, 30);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Username";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(105, 30);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(2);
            this.lblName.Size = new System.Drawing.Size(295, 25);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnEdit.BackColorOnDefault = System.Drawing.Color.Transparent;
            this.btnEdit.BackColorOnHover = System.Drawing.Color.Transparent;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.EllipseOnClick = 0;
            this.btnEdit.EllipseOnDefault = 0;
            this.btnEdit.EllipseOnHover = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.ForeColorOnClick = System.Drawing.Color.White;
            this.btnEdit.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnEdit.ForeColorOnHover = System.Drawing.Color.White;
            this.btnEdit.Image = global::ITSpecialProject.Properties.Resources.EditColor_24;
            this.btnEdit.Location = new System.Drawing.Point(310, 55);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 45);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.TabStop = false;
            this.btnEdit.ToolTip = "";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDelete.BackColorOnDefault = System.Drawing.Color.Transparent;
            this.btnDelete.BackColorOnHover = System.Drawing.Color.Transparent;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.EllipseOnClick = 0;
            this.btnDelete.EllipseOnDefault = 0;
            this.btnDelete.EllipseOnHover = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ForeColorOnClick = System.Drawing.Color.White;
            this.btnDelete.ForeColorOnDefault = System.Drawing.Color.White;
            this.btnDelete.ForeColorOnHover = System.Drawing.Color.White;
            this.btnDelete.Image = global::ITSpecialProject.Properties.Resources.DeleteColor_24;
            this.btnDelete.Location = new System.Drawing.Point(355, 55);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 45);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.TabStop = false;
            this.btnDelete.ToolTip = "";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // pbAccountImage
            // 
            this.pbAccountImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.pbAccountImage.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.pbAccountImage.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.pbAccountImage.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.pbAccountImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbAccountImage.EllipseOnClick = 0;
            this.pbAccountImage.EllipseOnDefault = 0;
            this.pbAccountImage.EllipseOnHover = 0;
            this.pbAccountImage.Image = global::ITSpecialProject.Properties.Resources.Account_100;
            this.pbAccountImage.Location = new System.Drawing.Point(5, 0);
            this.pbAccountImage.Margin = new System.Windows.Forms.Padding(5);
            this.pbAccountImage.Name = "pbAccountImage";
            this.pbAccountImage.Padding = new System.Windows.Forms.Padding(5);
            this.pbAccountImage.Size = new System.Drawing.Size(100, 100);
            this.pbAccountImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAccountImage.TabIndex = 5;
            this.pbAccountImage.TabStop = false;
            this.pbAccountImage.ToolTip = "";
            // 
            // pnlFiller
            // 
            this.pnlFiller.BackColor = System.Drawing.Color.Transparent;
            this.pnlFiller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiller.Location = new System.Drawing.Point(105, 55);
            this.pnlFiller.Name = "pnlFiller";
            this.pnlFiller.Size = new System.Drawing.Size(205, 45);
            this.pnlFiller.TabIndex = 11;
            // 
            // AccountCardView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.pnlFiller);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pbAccountImage);
            this.Controls.Add(this.pnlFlag);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Name = "AccountCardView";
            this.Size = new System.Drawing.Size(400, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pbAccountImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFlag;
        private Components.FlatPictureBox pbAccountImage;
        private Components.FlatButton btnEdit;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblName;
        private Components.FlatButton btnDelete;
        private System.Windows.Forms.Panel pnlFiller;
    }
}
