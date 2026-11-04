
using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SalesForm : Form
    {
        private string productsFilePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "Products.csv");
        private string salesFilePath = Path.Combine(
    AppDomain.CurrentDomain.BaseDirectory, "Sales.csv");
        public SalesForm()
        {
            InitializeComponent();
            btnCompleteSale.Click += btnCompleteSale_Click;

            btnCalculateTotal.Click += btnCalculateTotal_Click;
            btnClearSale.Click += btnClearSale_Click;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;

            txtSalePrice.ReadOnly = true;
            txtTotalAmount.ReadOnly = true;

            LoadProducts();
            LoadSalesFromFile();
        }

        private class ProductItem
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        private void LoadProducts()
        {
            cmbProduct.Items.Clear();

            if (!File.Exists(productsFilePath))
            {
                MessageBox.Show("Products file not found.");
                return;
            }

            foreach (string line in File.ReadAllLines(productsFilePath))
            {
                string[] values = line.Split(',');

                if (values.Length == 6 &&
                    decimal.TryParse(values[3], out decimal price) &&
                    int.TryParse(values[4], out int quantity))
                {
                    cmbProduct.Items.Add(new ProductItem
                    {
                        Name = values[1],
                        Price = price,
                        Quantity = quantity
                    });
                }
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem is ProductItem product)
            {
                txtSalePrice.Text = product.Price.ToString("0.00");
                CalculateTotal();
            }
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            if (cmbProduct.SelectedItem is not ProductItem product)
                return;

            if (!int.TryParse(txtSaleQuantity.Text, out int quantity) ||
                quantity <= 0)
            {
                txtTotalAmount.Clear();
                return;
            }

            decimal total = product.Price * quantity;

            txtTotalAmount.Text = total.ToString("0.00");
        }

        private void btnClearSale_Click(object sender, EventArgs e)
        {
            cmbProduct.SelectedIndex = -1;
            txtSaleQuantity.Clear();
            txtSalePrice.Clear();
            txtTotalAmount.Clear();
            txtSaleCustomer.Clear();
        }
         private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem is not ProductItem product)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSaleCustomer.Text))
            {
                MessageBox.Show("Please enter customer name.");
                return;
            }

            if (!int.TryParse(txtSaleQuantity.Text, out int quantity) ||
                quantity <= 0)
            {
                MessageBox.Show("Enter a valid quantity.");
                return;
            }

            if (quantity > product.Quantity)
            {
                MessageBox.Show("Insufficient stock!");
                return;
            }

            decimal total = product.Price * quantity;
            string saleID = (dgvSales.Rows.Count + 1).ToString();

            dgvSales.Rows.Add(
                saleID,
                product.Name,
                quantity,
                product.Price,
                total,
                DateTime.Now.ToString("dd/MM/yyyy HH:mm")

            );
            SaveSalesToFile();

            MessageBox.Show("Sale completed successfully!");

            btnClearSale_Click(sender, e);
         }
        private void SaveSalesToFile()
        {
            using (StreamWriter writer = new StreamWriter(salesFilePath, false))
            {
                foreach (DataGridViewRow row in dgvSales.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string[] values =
                        {
                    row.Cells[0].Value?.ToString() ?? "",
                    row.Cells[1].Value?.ToString() ?? "",
                    row.Cells[2].Value?.ToString() ?? "",
                    row.Cells[3].Value?.ToString() ?? "",
                    row.Cells[4].Value?.ToString() ?? "",
                    row.Cells[5].Value?.ToString() ?? ""
                };

                        writer.WriteLine(string.Join(",", values));
                    }
                }
            }
        }
        private void LoadSalesFromFile()
        {
            if (!File.Exists(salesFilePath))
                return;

            dgvSales.Rows.Clear();

            foreach (string line in File.ReadAllLines(salesFilePath))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] values = line.Split(',');

                if (values.Length == 6)
                {
                    dgvSales.Rows.Add(values);
                }
            }
        }
    }
 }

