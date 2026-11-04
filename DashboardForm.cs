using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            btnCustomers.Click += btnCustomers_Click;
        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomersForm customers = new CustomersForm();
            customers.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAppName_Click(object sender, EventArgs e)
        {

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesForm sales = new SalesForm();
            sales.ShowDialog();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlStockCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvRecentActivities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRecentActivities_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLongout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();

            this.Close();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Products button clicked!");

            ProductsForm products = new ProductsForm();
            products.ShowDialog();
        }
    }
}
