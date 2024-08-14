using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CommerceApp
{
    public partial class InventoryManagementForm : Form
    {
        private List<Product> productList = new List<Product>();  // This should be shared from ProductManagementForm

        public InventoryManagementForm()
        {
            InitializeComponent();
            RefreshInventoryGrid();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if (dataGridViewInventory.SelectedRows.Count > 0)
            {
                var selectedProduct = (Product)dataGridViewInventory.SelectedRows[0].DataBoundItem;
                int additionalStock = int.Parse(txtAdditionalStock.Text);
                selectedProduct.Stock += additionalStock;
                RefreshInventoryGrid();
            }
        }

        private void RefreshInventoryGrid()
        {
            dataGridViewInventory.DataSource = null;
            dataGridViewInventory.DataSource = productList;
        }
    }
}
