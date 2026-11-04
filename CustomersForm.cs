
using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CustomersForm : Form
    {
        private int customerID = 1;

        private string filePath = Path.Combine(
     AppDomain.CurrentDomain.BaseDirectory, "Customers.csv");

        public CustomersForm()
        {
            InitializeComponent();

            btnSaveCustomer.Click += btnSaveCustomer_Click;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            btnClearCustomer.Click += btnClearCustomer_Click;
            btnSearchCustomer.Click += btnSearchCustomer_Click;

            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;

            LoadCustomersFromFile();
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text.Trim() == "" ||
                txtPhone.Text.Trim() == "" ||
                txtEmail.Text.Trim() == "" ||
                txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all customer details.");
                return;
            }

            dgvCustomers.Rows.Add(
                customerID,
                txtFullName.Text,
                txtPhone.Text,
                txtEmail.Text,
                txtAddress.Text,
                DateTime.Now.ToString("dd/MM/yyyy")
            );

            customerID++;

            SaveCustomersToFile();
            ClearFields();

            MessageBox.Show("Customer registered successfully!");
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer.");
                return;
            }

            DataGridViewRow row = dgvCustomers.SelectedRows[0];

            row.Cells[1].Value = txtFullName.Text;
            row.Cells[2].Value = txtPhone.Text;
            row.Cells[3].Value = txtEmail.Text;
            row.Cells[4].Value = txtAddress.Text;

            SaveCustomersToFile();
            ClearFields();

            MessageBox.Show("Customer updated successfully!");
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this customer?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dgvCustomers.Rows.RemoveAt(
                    dgvCustomers.SelectedRows[0].Index);

                SaveCustomersToFile();
                ClearFields();
            }
        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string search = txtSearchCustomer.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgvCustomers.Rows)
            {
                row.Selected =
                    row.Cells[1].Value.ToString().ToLower().Contains(search) ||
                    row.Cells[2].Value.ToString().ToLower().Contains(search);

                if (row.Selected)
                {
                    dgvCustomers.CurrentCell = row.Cells[1];
                    return;
                }
            }

            MessageBox.Show("Customer not found.");
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCustomers.SelectedRows[0];

                txtCustomerID.Text = row.Cells[0].Value?.ToString() ?? "";
                txtFullName.Text = row.Cells[1].Value?.ToString() ?? "";
                txtPhone.Text = row.Cells[2].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells[3].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells[4].Value?.ToString() ?? "";
            }
        }

        private void ClearFields()
        {
            txtCustomerID.Clear();
            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtSearchCustomer.Clear();
            dgvCustomers.ClearSelection();
        }

        private void SaveCustomersToFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (DataGridViewRow row in dgvCustomers.Rows)
                {
                    string[] values = new string[6];

                    for (int i = 0; i < 6; i++)
                    {
                        values[i] = row.Cells[i].Value?.ToString() ?? "";
                    }

                    writer.WriteLine(string.Join(",", values));
                }
            }
        }

        private void LoadCustomersFromFile()
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Customers file not found:\n" + filePath);
                return;
            }

            dgvCustomers.Rows.Clear();

            int loadedCount = 0;

            try
            {
                foreach (string line in File.ReadAllLines(filePath))
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] values = line.Split(',');

                    if (values.Length == 6)
                    {
                        dgvCustomers.Rows.Add(values);
                        loadedCount++;

                        if (int.TryParse(values[0], out int id) &&
                            id >= customerID)
                        {
                            customerID = id + 1;
                        }
                    }
                }

                MessageBox.Show(
                    "Customers loaded successfully: " + loadedCount);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loading error: " + ex.Message);
            }
        }
    }
}
