using System;
using System.Windows.Forms;

namespace CommerceApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            var productForm = new ProductManagementForm();
            productForm.ShowDialog();
        }

        private void btnSalesManagement_Click(object sender, EventArgs e)
        {
            var salesForm = new SalesManagementForm();
            salesForm.ShowDialog();
        }

        private void btnInventoryManagement_Click(object sender, EventArgs e)
        {
            var inventoryForm = new InventoryManagementForm();
            inventoryForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }
    }
}
