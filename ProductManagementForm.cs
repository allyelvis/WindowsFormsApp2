// Add EF Core usage to ProductManagementForm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 
{
    public partial class ProductManagementForm : Form
    {
        private AppDbContext dbContext = new AppDbContext();

        public ProductManagementForm()
        {
            InitializeComponent();
            RefreshProductGrid();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Name = txtProductName.Text,
                Price = decimal.Parse(txtPrice.Text),
                Stock = int.Parse(txtStock.Text)
            };
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            RefreshProductGrid();
        }

        private void RefreshProductGrid()
        {
            dataGridViewProducts.DataSource = dbContext.Products.ToList();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var selectedProduct = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;
                selectedProduct.Name = txtProductName.Text;
                selectedProduct.Price = decimal.Parse(txtPrice.Text);
                selectedProduct.Stock = int.Parse(txtStock.Text);
                dbContext.SaveChanges();
                RefreshProductGrid();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var selectedProduct = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;
                dbContext.Products.Remove(selectedProduct);
                dbContext.SaveChanges();
                RefreshProductGrid();
            }
        }
    }
}
