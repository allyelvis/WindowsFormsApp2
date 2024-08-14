using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CommerceApp
{
    public partial class SalesManagementForm : Form
    {
        private List<Sale> salesList = new List<Sale>();
        private List<Product> productList = new List<Product>();  // This should be shared from ProductManagementForm

        public SalesManagementForm()
        {
            InitializeComponent();
            // Initialize the ComboBox with available products
            comboBoxProducts.DataSource = productList;
            comboBoxProducts.DisplayMember = "Name";
            comboBoxProducts.ValueMember = "Id";
        }

        private void btnMakeSale_Click(object sender, EventArgs e)
        {
            var selectedProduct = (Product)comboBoxProducts.SelectedItem;
            int quantity = int.Parse(txtQuantity.Text);
            if (selectedProduct.Stock >= quantity)
            {
                var sale = new Sale
                {
                    SaleId = salesList.Count + 1,
                    ProductId = selectedProduct.Id,
                    Quantity = quantity,
                    TotalPrice = quantity * selectedProduct.Price,
                    SaleDate = DateTime.Now
                };
                salesList.Add(sale);
                selectedProduct.Stock -= quantity;
                RefreshSalesGrid();
            }
            else
            {
                MessageBox.Show("Not enough stock.");
            }
        }

        private void RefreshSalesGrid()
        {
            dataGridViewSales.DataSource = null;
            dataGridViewSales.DataSource = salesList;
        }
    }
}
