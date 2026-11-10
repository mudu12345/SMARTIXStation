
using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class InventoryForm : Form
    {
        private string productsFilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "Products.csv");

        public InventoryForm()
        {
            InitializeComponent();

            btnRefreshInventory.Click += btnRefreshInventory_Click;
            btnSearchInventory.Click += btnSearchInventory_Click;

            LoadInventory("");
        }

        private void LoadInventory(string searchText)
        {
            dgvInventory.Rows.Clear();

            if (!File.Exists(productsFilePath))
            {
                lblInventorySummary.Text = "Total Products: 0";
                return;
            }

            int totalProducts = 0;

            foreach (string line in File.ReadAllLines(productsFilePath))
            {
                string[] values = line.Split(',');

                if (values.Length != 6)
                    continue;

                string productID = values[0];
                string productName = values[1];
                string category = values[2];
                string unitPrice = values[3];
                string quantityText = values[4];
                string supplier = values[5];

                if (!productID.Contains(searchText,
                        StringComparison.OrdinalIgnoreCase) &&
                    !productName.Contains(searchText,
                        StringComparison.OrdinalIgnoreCase) &&
                    !category.Contains(searchText,
                        StringComparison.OrdinalIgnoreCase) &&
                    !supplier.Contains(searchText,
                        StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                if (!int.TryParse(quantityText, out int quantity))
                    continue;

                string status;

                if (quantity <= 0)
                    status = "Out of Stock";
                else if (quantity <= 5)
                    status = "Low Stock";
                else
                    status = "In Stock";

                dgvInventory.Rows.Add(
                    productID,
                    productName,
                    category,
                    unitPrice,
                    quantity,
                    supplier,
                    status
                );

                totalProducts++;
            }

            lblInventorySummary.Text =
                "Total Products: " + totalProducts;
        }

        private void btnSearchInventory_Click(object sender, EventArgs e)
        {
            LoadInventory(txtSearchInventory.Text.Trim());
        }

        private void btnRefreshInventory_Click(object sender, EventArgs e)
        {
            txtSearchInventory.Clear();
            LoadInventory("");

            MessageBox.Show("Inventory refreshed successfully!");
        }
    }
}
