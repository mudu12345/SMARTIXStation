namespace WinFormsApp1
{
    partial class CustomersForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCustomerID = new TextBox();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            lblCustomersHeading = new Label();
            btnSaveCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnDeleteCustomer = new Button();
            btnClearCustomer = new Button();
            txtSearchCustomer = new TextBox();
            btnSearchCustomer = new Button();
            dgvCustomers = new DataGridView();
            colCustomerID = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colDateRegistered = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 90);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
            label1.TabIndex = 0;
            label1.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 140);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 1;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(448, 91);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(448, 134);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 190);
            label5.Name = "label5";
            label5.Size = new Size(57, 17);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(150, 90);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(217, 23);
            txtCustomerID.TabIndex = 5;
            
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(150, 134);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(217, 23);
            txtFullName.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(525, 84);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(205, 23);
            txtPhone.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(525, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(205, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(150, 190);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(217, 23);
            txtAddress.TabIndex = 9;
            // 
            // lblCustomersHeading
            // 
            lblCustomersHeading.AutoSize = true;
            lblCustomersHeading.BackColor = Color.DarkBlue;
            lblCustomersHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomersHeading.ForeColor = Color.White;
            lblCustomersHeading.Location = new Point(30, 20);
            lblCustomersHeading.Name = "lblCustomersHeading";
            lblCustomersHeading.Size = new Size(337, 32);
            lblCustomersHeading.TabIndex = 10;
            lblCustomersHeading.Text = "CUSTOMERS MANAGEMENT";
            // 
            // btnSaveCustomer
            // 
            btnSaveCustomer.BackColor = Color.DarkGreen;
            btnSaveCustomer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveCustomer.ForeColor = Color.White;
            btnSaveCustomer.Location = new Point(150, 245);
            btnSaveCustomer.Name = "btnSaveCustomer";
            btnSaveCustomer.Size = new Size(110, 40);
            btnSaveCustomer.TabIndex = 11;
            btnSaveCustomer.Text = "Save ";
            btnSaveCustomer.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.BackColor = Color.MidnightBlue;
            btnUpdateCustomer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateCustomer.Location = new Point(275, 245);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(110, 40);
            btnUpdateCustomer.TabIndex = 12;
            btnUpdateCustomer.Text = "Update";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.BackColor = Color.Purple;
            btnDeleteCustomer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteCustomer.Location = new Point(400, 245);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(110, 40);
            btnDeleteCustomer.TabIndex = 13;
            btnDeleteCustomer.Text = "Delete";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // btnClearCustomer
            // 
            btnClearCustomer.BackColor = Color.Cyan;
            btnClearCustomer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearCustomer.Location = new Point(525, 245);
            btnClearCustomer.Name = "btnClearCustomer";
            btnClearCustomer.Size = new Size(110, 40);
            btnClearCustomer.TabIndex = 14;
            btnClearCustomer.Text = "Clear";
            btnClearCustomer.UseVisualStyleBackColor = false;
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Location = new Point(485, 26);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(164, 23);
            txtSearchCustomer.TabIndex = 15;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearchCustomer.BackColor = Color.Blue;
            btnSearchCustomer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchCustomer.Location = new Point(655, 20);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(94, 32);
            btnSearchCustomer.TabIndex = 16;
            btnSearchCustomer.Text = "Search";
            btnSearchCustomer.UseVisualStyleBackColor = false;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { colCustomerID, colFullName, colPhone, colEmail, colAddress, colDateRegistered });
            dgvCustomers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvCustomers.Enabled = false;
            dgvCustomers.Location = new Point(30, 291);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(709, 200);
            dgvCustomers.TabIndex = 17;
            // 
            // colCustomerID
            // 
            colCustomerID.HeaderText = "Customer ID";
            colCustomerID.Name = "colCustomerID";
            colCustomerID.ReadOnly = true;
            // 
            // colFullName
            // 
            colFullName.HeaderText = "Full Name";
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Phone";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colAddress
            // 
            colAddress.HeaderText = "Address";
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            // 
            // colDateRegistered
            // 
            colDateRegistered.HeaderText = "Date Registered";
            colDateRegistered.Name = "colDateRegistered";
            colDateRegistered.ReadOnly = true;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 513);
            Controls.Add(dgvCustomers);
            Controls.Add(btnSearchCustomer);
            Controls.Add(txtSearchCustomer);
            Controls.Add(btnClearCustomer);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(btnSaveCustomer);
            Controls.Add(lblCustomersHeading);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Controls.Add(txtCustomerID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CustomersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SMARTIXStation - Customers Management";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCustomerID;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Label lblCustomersHeading;
        private Button btnSaveCustomer;
        private Button btnUpdateCustomer;
        private Button btnDeleteCustomer;
        private Button btnClearCustomer;
        private TextBox txtSearchCustomer;
        private Button btnSearchCustomer;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn colCustomerID;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colDateRegistered;
    }
}