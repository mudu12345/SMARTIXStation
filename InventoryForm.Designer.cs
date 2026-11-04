namespace WinFormsApp1
{
    partial class InventoryForm
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
            lblInventoryHeading = new Label();
            dgvInventory = new DataGridView();
            colInvProductID = new DataGridViewTextBoxColumn();
            colInvProductName = new DataGridViewTextBoxColumn();
            colInvCategory = new DataGridViewTextBoxColumn();
            colInvUnitPrice = new DataGridViewTextBoxColumn();
            colInvQuantity = new DataGridViewTextBoxColumn();
            colInvSupplier = new DataGridViewTextBoxColumn();
            btnRefreshInventory = new Button();
            lblInventorySummary = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // lblInventoryHeading
            // 
            lblInventoryHeading.AutoSize = true;
            lblInventoryHeading.BackColor = Color.FromArgb(0, 0, 192);
            lblInventoryHeading.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryHeading.ForeColor = Color.White;
            lblInventoryHeading.Location = new Point(30, 20);
            lblInventoryHeading.Name = "lblInventoryHeading";
            lblInventoryHeading.Size = new Size(399, 40);
            lblInventoryHeading.TabIndex = 0;
            lblInventoryHeading.Text = "INVENTORY MANAGEMENT";
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { colInvProductID, colInvProductName, colInvCategory, colInvUnitPrice, colInvQuantity, colInvSupplier });
            dgvInventory.Location = new Point(30, 82);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(725, 179);
            dgvInventory.TabIndex = 1;
            // 
            // colInvProductID
            // 
            colInvProductID.HeaderText = "Product ID";
            colInvProductID.Name = "colInvProductID";
            colInvProductID.ReadOnly = true;
            // 
            // colInvProductName
            // 
            colInvProductName.HeaderText = "Product Name";
            colInvProductName.Name = "colInvProductName";
            colInvProductName.ReadOnly = true;
            // 
            // colInvCategory
            // 
            colInvCategory.HeaderText = "Category";
            colInvCategory.Name = "colInvCategory";
            colInvCategory.ReadOnly = true;
            // 
            // colInvUnitPrice
            // 
            colInvUnitPrice.HeaderText = "Unit Price";
            colInvUnitPrice.Name = "colInvUnitPrice";
            colInvUnitPrice.ReadOnly = true;
            // 
            // colInvQuantity
            // 
            colInvQuantity.HeaderText = "Available Stock";
            colInvQuantity.Name = "colInvQuantity";
            colInvQuantity.ReadOnly = true;
            // 
            // colInvSupplier
            // 
            colInvSupplier.HeaderText = "Supplier";
            colInvSupplier.Name = "colInvSupplier";
            colInvSupplier.ReadOnly = true;
            // 
            // btnRefreshInventory
            // 
            btnRefreshInventory.BackColor = Color.Cyan;
            btnRefreshInventory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshInventory.ForeColor = Color.White;
            btnRefreshInventory.Location = new Point(101, 292);
            btnRefreshInventory.Name = "btnRefreshInventory";
            btnRefreshInventory.Size = new Size(150, 40);
            btnRefreshInventory.TabIndex = 2;
            btnRefreshInventory.Text = "Refresh Inventory";
            btnRefreshInventory.UseVisualStyleBackColor = false;
            // 
            // lblInventorySummary
            // 
            lblInventorySummary.AutoSize = true;
            lblInventorySummary.BackColor = Color.Blue;
            lblInventorySummary.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventorySummary.ForeColor = Color.White;
            lblInventorySummary.Location = new Point(428, 298);
            lblInventorySummary.Name = "lblInventorySummary";
            lblInventorySummary.Size = new Size(112, 17);
            lblInventorySummary.TabIndex = 3;
            lblInventorySummary.Text = "Total Products: 0";
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInventorySummary);
            Controls.Add(btnRefreshInventory);
            Controls.Add(dgvInventory);
            Controls.Add(lblInventoryHeading);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "InventoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\tSMARTIXStation - Inventory Management";
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInventoryHeading;
        private DataGridView dgvInventory;
        private DataGridViewTextBoxColumn colInvProductID;
        private DataGridViewTextBoxColumn colInvProductName;
        private DataGridViewTextBoxColumn colInvCategory;
        private DataGridViewTextBoxColumn colInvUnitPrice;
        private DataGridViewTextBoxColumn colInvQuantity;
        private DataGridViewTextBoxColumn colInvSupplier;
        private Button btnRefreshInventory;
        private Label lblInventorySummary;
    }
}