
using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();

            btnSalesReport.Click += btnSalesReport_Click;
            btnInventoryReport.Click += btnInventoryReport_Click;
            btnLowStockReport.Click += btnLowStockReport_Click;
            btnOutOfStockReport.Click += btnOutOfStockReport_Click;
            btnRefreshReports.Click += btnRefreshReports_Click;

            LoadSalesReport();
        }

        private void LoadSalesReport()
        {
            dgvReports.Rows.Clear();

            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Sales.csv");

            if (!File.Exists(filePath))
            {
                lblTotalSales.Text = "Total Sales: 0";
                return;
            }

            decimal totalSales = 0;

            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] values = line.Split(',');

                if (values.Length != 6)
                    continue;

                dgvReports.Rows.Add(
                    values[0],
                    values[1],
                    values[2],
                    values[3],
                    values[4],
                    values[5]
                );

                if (decimal.TryParse(values[4], out decimal amount))
                    totalSales += amount;
            }

            lblTotalSales.Text =
                "Total Sales: " + totalSales.ToString("N2");
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            LoadSalesReport();
        }

        private void btnInventoryReport_Click(object sender, EventArgs e)
        {
            LoadInventoryReport(false);
        }

        private void btnLowStockReport_Click(object sender, EventArgs e)
        {
            LoadInventoryReport(true);
        }

        private void btnOutOfStockReport_Click(object sender, EventArgs e)
        {
            LoadOutOfStockReport();
        }

        private void LoadInventoryReport(bool lowStockOnly)
        {
            dgvReports.Rows.Clear();

            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Products.csv");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Products file not found!");
                return;
            }

            int count = 0;

            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] values = line.Split(',');

                if (values.Length != 6)
                    continue;

                if (!int.TryParse(values[4], out int quantity))
                    continue;

                if (lowStockOnly && (quantity <= 0 || quantity > 5))
                    continue;

                string status = quantity <= 0
                    ? "Out of Stock"
                    : quantity <= 5
                        ? "Low Stock"
                        : "In Stock";

                dgvReports.Rows.Add(
                    values[0],
                    values[1],
                    quantity,
                    values[3],
                    "",
                    status
                );

                count++;
            }

            lblTotalSales.Text = lowStockOnly
                ? "Low Stock Products: " + count
                : "Total Products: " + count;
        }

        private void LoadOutOfStockReport()
        {
            dgvReports.Rows.Clear();

            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Products.csv");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Products file not found!");
                return;
            }

            int count = 0;

            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] values = line.Split(',');

                if (values.Length != 6)
                    continue;

                if (!int.TryParse(values[4], out int quantity))
                    continue;

                if (quantity == 0)
                {
                    dgvReports.Rows.Add(
                        values[0],
                        values[1],
                        quantity,
                        values[3],
                        "",
                        "Out of Stock"
                    );

                    count++;
                }
            }

            lblTotalSales.Text = "Out of Stock Products: " + count;
        }

        private void btnRefreshReports_Click(object sender, EventArgs e)
        {
            LoadSalesReport();
            MessageBox.Show("Reports refreshed successfully!");
        }
    }
}
