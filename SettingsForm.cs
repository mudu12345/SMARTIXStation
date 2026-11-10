using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SettingsForm : Form
    {

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
        public SettingsForm()
        {
            InitializeComponent();

            btnChangePassword.Click += btnChangePassword_Click;
            btnClearSettings.Click += btnClearSettings_Click;

            txtOldPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string oldPassword = txtOldPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (username == "" || oldPassword == "" ||
                newPassword == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (username != LoginCredentials.GetUsername())
            {
                MessageBox.Show("Invalid username.");
                return;
            }

            if (oldPassword != LoginCredentials.GetPassword())
            {
                MessageBox.Show("Current password is incorrect.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New passwords do not match.");
                return;
            }

            if (newPassword.Length < 6)
            {
                MessageBox.Show("Password must contain at least 6 characters.");
                return;
            }

            LoginCredentials.SaveCredentials(username, newPassword);

            MessageBox.Show("Password changed successfully!");

            btnClearSettings_Click(sender, e);
        }

        private void btnClearSettings_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();

            txtUsername.Focus();
        }
    }
}
