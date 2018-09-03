namespace ITSpecialProject.Views.PointOfSale
{
    partial class ItemCardView
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
        /// NoInput method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.pnlIsAvailable = new System.Windows.Forms.Panel();
            this.pbItemImage = new ITSpecialProject.Components.FlatPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(165)))), ((int)(((byte)(30)))));
            this.lblItemName.Location = new System.Drawing.Point(85, 0);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Padding = new System.Windows.Forms.Padding(2);
            this.lblItemName.Size = new System.Drawing.Size(215, 50);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Lorem Ipsum";
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblItemPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblItemPrice.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice.ForeColor = System.Drawing.Color.White;
            this.lblItemPrice.Location = new System.Drawing.Point(85, 50);
            this.lblItemPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(215, 30);
            this.lblItemPrice.TabIndex = 2;
            this.lblItemPrice.Text = "0.00";
            this.lblItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlIsAvailable
            // 
            this.pnlIsAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.pnlIsAvailable.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIsAvailable.Location = new System.Drawing.Point(0, 0);
            this.pnlIsAvailable.Name = "pnlIsAvailable";
            this.pnlIsAvailable.Size = new System.Drawing.Size(5, 80);
            this.pnlIsAvailable.TabIndex = 3;
            // 
            // pbItemImage
            // 
            this.pbItemImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.pbItemImage.BackColorOnClick = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.pbItemImage.BackColorOnDefault = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.pbItemImage.BackColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.pbItemImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbItemImage.EllipseOnClick = 0;
            this.pbItemImage.EllipseOnDefault = 0;
            this.pbItemImage.EllipseOnHover = 0;
            this.pbItemImage.Image = global::ITSpecialProject.Properties.Resources.Default_100;
            this.pbItemImage.Location = new System.Drawing.Point(5, 0);
            this.pbItemImage.Margin = new System.Windows.Forms.Padding(5);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(80, 80);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbItemImage.TabIndex = 0;
            this.pbItemImage.TabStop = false;
            this.pbItemImage.ToolTip = "";
            // 
            // ItemCardView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.pbItemImage);
            this.Controls.Add(this.pnlIsAvailable);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Name = "ItemCardView";
            this.Size = new System.Drawing.Size(300, 80);
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.FlatPictureBox pbItemImage;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Panel pnlIsAvailable;
    }
}
