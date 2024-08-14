using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CommerceApp
{
    public partial class ReportsForm : Form
    {
        private List<Sale> salesList = new List<Sale>();  // This should be shared from SalesManagementForm

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void btnGenerateSalesReport_Click(object sender, EventArgs e)
        {
            var dailySales = salesList.Where(s => s.SaleDate.Date == DateTime.Today).ToList();
            // Display or export the report
        }
    }
}
