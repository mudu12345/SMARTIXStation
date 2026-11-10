namespace WinFormsApp1
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSettingsHeading = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblOldPassword = new Label();
            txtOldPassword = new TextBox();
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            btnChangePassword = new Button();
            btnClearSettings = new Button();
            SuspendLayout();
            // 
            // lblSettingsHeading
            // 
            lblSettingsHeading.AutoSize = true;
            lblSettingsHeading.BackColor = Color.FromArgb(0, 0, 192);
            lblSettingsHeading.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSettingsHeading.ForeColor = Color.White;
            lblSettingsHeading.Location = new Point(30, 20);
            lblSettingsHeading.Name = "lblSettingsHeading";
            lblSettingsHeading.Size = new Size(270, 40);
            lblSettingsHeading.TabIndex = 0;
            lblSettingsHeading.Text = "SYSTEM SETTINGS";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.DimGray;
            lblUsername.Location = new Point(50, 110);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(217, 107);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 23);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOldPassword.ForeColor = Color.DimGray;
            lblOldPassword.Location = new Point(50, 165);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(133, 20);
            lblOldPassword.TabIndex = 3;
            lblOldPassword.Text = "Current Password";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(220, 165);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(300, 23);
            txtOldPassword.TabIndex = 4;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPassword.ForeColor = Color.DimGray;
            lblNewPassword.Location = new Point(50, 220);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(112, 20);
            lblNewPassword.TabIndex = 5;
            lblNewPassword.Text = "New Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(220, 220);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(300, 23);
            txtNewPassword.TabIndex = 6;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = Color.DimGray;
            lblConfirmPassword.Location = new Point(50, 275);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(137, 20);
            lblConfirmPassword.TabIndex = 7;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(220, 275);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(300, 23);
            txtConfirmPassword.TabIndex = 8;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.DodgerBlue;
            btnChangePassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangePassword.ForeColor = Color.Black;
            btnChangePassword.Location = new Point(50, 340);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(350, 45);
            btnChangePassword.TabIndex = 9;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // btnClearSettings
            // 
            btnClearSettings.BackColor = Color.FromArgb(224, 224, 224);
            btnClearSettings.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearSettings.ForeColor = Color.Black;
            btnClearSettings.Location = new Point(420, 340);
            btnClearSettings.Name = "btnClearSettings";
            btnClearSettings.Size = new Size(100, 45);
            btnClearSettings.TabIndex = 10;
            btnClearSettings.Text = "Clear";
            btnClearSettings.UseVisualStyleBackColor = false;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClearSettings);
            Controls.Add(btnChangePassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(txtOldPassword);
            Controls.Add(lblOldPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblSettingsHeading);
            Name = "SettingsForm";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SMARTIXStation - Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSettingsHeading;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblOldPassword;
        private TextBox txtOldPassword;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Button btnChangePassword;
        private Button btnClearSettings;
    }
}