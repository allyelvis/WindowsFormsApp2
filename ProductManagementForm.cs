using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CommerceApp
{
    public partial class ProductManagementForm : Form
    {
        private List<Product> productList = new List<Product>();

        public ProductManagementForm()
        {
            InitializeComponent();
            RefreshProductGrid();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Id = productList.Count + 1,
                Name = txtProductName.Text,
                Price = decimal.Parse(txtPrice.Text),
                Stock = int.Parse(txtStock.Text)
            };
            productList.Add(product);
            RefreshProductGrid();
        }

        private void RefreshProductGrid()
        {
            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = productList;
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var selectedProduct = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;
                selectedProduct.Name = txtProductName.Text;
                selectedProduct.Price = decimal.Parse(txtPrice.Text);
                selectedProduct.Stock = int.Parse(txtStock.Text);
                RefreshProductGrid();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var selectedProduct = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;
                productList.Remove(selectedProduct);
                RefreshProductGrid();
            }
        }
    }
}
