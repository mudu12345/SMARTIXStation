using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();

            btnSaveProduct.Click += btnSaveProduct_Click;
            btnClearProduct.Click += btnClearProduct_Click;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            btnSearchProduct.Click += btnSearchProduct_Click;

            LoadProductsFromFile();
        }

            private int productID = 1;
        private string filePath = Path.Combine(
    Application.StartupPath,
    "Products.csv"
);
        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Trim() == "" ||
                txtCategory.Text.Trim() == "" ||
                txtUnitPrice.Text.Trim() == "" ||
                txtQuantity.Text.Trim() == "" ||
                txtSupplier.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all product fields.");
                return;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) ||
                !int.TryParse(txtQuantity.Text, out int quantity) ||
                price < 0 || quantity < 0)
            {
                MessageBox.Show("Enter a valid price and quantity.");
                return;
            }

            dgvProducts.Rows.Add(
                productID++,
                txtProductName.Text.Trim(),
                txtCategory.Text.Trim(),
                price,
                quantity,
                txtSupplier.Text.Trim()
            );
            SaveProductsToFile();

            MessageBox.Show("Product saved successfully!");

            ClearProductFields(); 
        }
            private void LoadProductsFromFile()
        {
            if (!File.Exists(filePath))
                return;

            dgvProducts.Rows.Clear();

            int highestID = 0;

            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] data = line.Split(',');

                if (data.Length == 6)
                {
                    dgvProducts.Rows.Add(
                        data[0],
                        data[1],
                        data[2],
                        data[3],
                        data[4],
                        data[5]
                    );

                    if (int.TryParse(data[0], out int id) && id > highestID)
                        highestID = id;
                }
            }

            productID = highestID + 1;
        }
        
            private void btnClearProduct_Click(object sender, EventArgs e)
        {
            ClearProductFields();
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                dgvProducts.Rows.RemoveAt(
                    dgvProducts.SelectedRows[0].Index
                );
                SaveProductsToFile();
                MessageBox.Show("Product deleted successfully!");
            }
        }
            private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            DataGridViewRow row = dgvProducts.SelectedRows[0];

            if (txtProductName.Text.Trim() == "" ||
                txtCategory.Text.Trim() == "" ||
                txtUnitPrice.Text.Trim() == "" ||
                txtQuantity.Text.Trim() == "" ||
                txtSupplier.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all product fields.");
                return;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) ||
                !int.TryParse(txtQuantity.Text, out int quantity) ||
                price < 0 || quantity < 0)
            {
                MessageBox.Show("Enter a valid price and quantity.");
                return;
            }

            row.Cells[1].Value = txtProductName.Text.Trim();
            row.Cells[2].Value = txtCategory.Text.Trim();
            row.Cells[3].Value = price;
            row.Cells[4].Value = quantity;
            row.Cells[5].Value = txtSupplier.Text.Trim();

            SaveProductsToFile();

            MessageBox.Show("Product updated successfully!");

            ClearProductFields();
        }
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchProduct.Text.Trim();

            if (searchText == "")
            {
                MessageBox.Show("Please enter a product name or category.");
                return;
            }

            bool found = false;

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.Cells[1].Value != null &&
                    row.Cells[1].Value.ToString().Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    row.Cells[2].Value != null &&
                    row.Cells[2].Value.ToString().Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    dgvProducts.FirstDisplayedScrollingRowIndex = row.Index;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Product not found.");
            }
        }
        private void SaveProductsToFile()
{
    using (StreamWriter writer = new StreamWriter(filePath))
    {
        foreach (DataGridViewRow row in dgvProducts.Rows)
        {
            if (!row.IsNewRow)
            {
                writer.WriteLine(
                    $"{row.Cells[0].Value},{row.Cells[1].Value},{row.Cells[2].Value},{row.Cells[3].Value},{row.Cells[4].Value},{row.Cells[5].Value}"
                );
            }
        }
    }
}
        private void ClearProductFields()
        {
            txtProductName.Clear();
            txtCategory.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            txtSupplier.Clear();

            txtProductName.Focus();
        }
    }
 }
        
       
