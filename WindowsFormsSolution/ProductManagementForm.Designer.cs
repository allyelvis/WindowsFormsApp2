namespace WindowsFormsApp2
{
    partial class ProductManagementForm
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
            // ProductManagementForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ProductManagementForm";
            this.Text = "ProductManagementForm";
            this.ResumeLayout(false);
        }
    }
}
