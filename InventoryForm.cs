using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class InventoryForm : Form
    {
        private string productsFilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "Products.csv");

        public InventoryForm()
        {
            InitializeComponent();

            btnRefreshInventory.Click += btnRefreshInventory_Click;

            LoadInventory();
        }

        private void LoadInventory()
        {
            dgvInventory.Rows.Clear();

            if (!File.Exists(productsFilePath))
            {
                MessageBox.Show("Products file not found.");
                return;
            }

            int totalProducts = 0;

            foreach (string line in File.ReadAllLines(productsFilePath))
            {
                string[] values = line.Split(',');

                if (values.Length == 6)
                {
                    dgvInventory.Rows.Add(values);
                    totalProducts++;
                }
            }

            lblInventorySummary.Text =
                "Total Products: " + totalProducts;
        }

        private void btnRefreshInventory_Click(object sender, EventArgs e)
        {
            LoadInventory();

            MessageBox.Show("Inventory refreshed successfully!");
        }
    }
}