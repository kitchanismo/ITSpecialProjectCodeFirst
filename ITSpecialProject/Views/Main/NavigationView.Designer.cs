namespace ITSpecialProject.Views.Main
{
    partial class NavigationView
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
            this.flowNavigation = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowNavigation
            // 
            this.flowNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowNavigation.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowNavigation.Location = new System.Drawing.Point(0, 0);
            this.flowNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.flowNavigation.Name = "flowNavigation";
            this.flowNavigation.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.flowNavigation.Size = new System.Drawing.Size(200, 400);
            this.flowNavigation.TabIndex = 0;
            this.flowNavigation.WrapContents = false;
            // 
            // NavigationView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowNavigation);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NavigationView";
            this.Size = new System.Drawing.Size(200, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowNavigation;
    }
}
