using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using WindowsFormsApp2.Data;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            var productForm = _serviceProvider.GetRequiredService<Forms.ProductManagementForm>();
            productForm.ShowDialog();
        }

        private void btnSalesManagement_Click(object sender, EventArgs e)
        {
            var salesForm = _serviceProvider.GetRequiredService<Forms.SalesManagementForm>();
            salesForm.ShowDialog();
        }
    }
}
