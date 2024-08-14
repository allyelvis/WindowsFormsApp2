namespace windowsFormsApp
{
    partial class SalesManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SalesManagementForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "SalesManagementForm";
            this.Text = "SalesManagementForm";
            this.ResumeLayout(false);
        }
    }
}
