namespace ITSpecialProject.Views.Utilities
{
    partial class PreloaderView
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
            this.components = new System.ComponentModel.Container();
            this.tmrPreloader = new System.Windows.Forms.Timer(this.components);
            this.pbPreloader1 = new System.Windows.Forms.PictureBox();
            this.pbPreloader2 = new System.Windows.Forms.PictureBox();
            this.pbPreloader3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreloader1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreloader2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreloader3)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrPreloader
            // 
            this.tmrPreloader.Interval = 125;
            this.tmrPreloader.Tick += new System.EventHandler(this.TmrPreloader_Tick);
            // 
            // pbPreloader1
            // 
            this.pbPreloader1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPreloader1.Image = global::ITSpecialProject.Properties.Resources.Preloader_64;
            this.pbPreloader1.Location = new System.Drawing.Point(0, 0);
            this.pbPreloader1.Margin = new System.Windows.Forms.Padding(0);
            this.pbPreloader1.Name = "pbPreloader1";
            this.pbPreloader1.Size = new System.Drawing.Size(100, 100);
            this.pbPreloader1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPreloader1.TabIndex = 0;
            this.pbPreloader1.TabStop = false;
            // 
            // pbPreloader2
            // 
            this.pbPreloader2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPreloader2.Image = global::ITSpecialProject.Properties.Resources.Preloader_64;
            this.pbPreloader2.Location = new System.Drawing.Point(100, 0);
            this.pbPreloader2.Margin = new System.Windows.Forms.Padding(0);
            this.pbPreloader2.Name = "pbPreloader2";
            this.pbPreloader2.Size = new System.Drawing.Size(100, 100);
            this.pbPreloader2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPreloader2.TabIndex = 1;
            this.pbPreloader2.TabStop = false;
            // 
            // pbPreloader3
            // 
            this.pbPreloader3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPreloader3.Image = global::ITSpecialProject.Properties.Resources.Preloader_64;
            this.pbPreloader3.Location = new System.Drawing.Point(200, 0);
            this.pbPreloader3.Margin = new System.Windows.Forms.Padding(0);
            this.pbPreloader3.Name = "pbPreloader3";
            this.pbPreloader3.Size = new System.Drawing.Size(100, 100);
            this.pbPreloader3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPreloader3.TabIndex = 2;
            this.pbPreloader3.TabStop = false;
            // 
            // PreloaderView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.pbPreloader3);
            this.Controls.Add(this.pbPreloader2);
            this.Controls.Add(this.pbPreloader1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PreloaderView";
            this.Size = new System.Drawing.Size(300, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreloader1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreloader2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreloader3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrPreloader;
        private System.Windows.Forms.PictureBox pbPreloader1;
        private System.Windows.Forms.PictureBox pbPreloader2;
        private System.Windows.Forms.PictureBox pbPreloader3;
    }
}
