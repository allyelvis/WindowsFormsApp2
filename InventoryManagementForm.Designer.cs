namespace windowsFormsApp
{
    partial class InventoryManagementForm
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
            // InventoryManagementForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "InventoryManagementForm";
            this.Text = "InventoryManagementForm";
            this.ResumeLayout(false);
        }
    }
}
