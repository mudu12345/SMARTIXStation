namespace WinFormsApp1
{
    partial class ProductsForm
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
            lblProductsHeading = new Label();
            lblProductsSubtitle = new Label();
            lblProductName = new Label();
            lblCategory = new Label();
            lblUnitPrice = new Label();
            lblQuantity = new Label();
            lblSupplier = new Label();
            txtProductName = new TextBox();
            txtCategory = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            txtSupplier = new TextBox();
            btnSaveProduct = new Button();
            btnUpdateProduct = new Button();
            btnDeleteProduct = new Button();
            btnClearProduct = new Button();
            dgvProducts = new DataGridView();
            colProductID = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colSupplier = new DataGridViewTextBoxColumn();
            lblSearchProduct = new Label();
            txtSearchProduct = new TextBox();
            btnSearchProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // lblProductsHeading
            // 
            lblProductsHeading.AutoSize = true;
            lblProductsHeading.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductsHeading.ForeColor = Color.MidnightBlue;
            lblProductsHeading.Location = new Point(35, 25);
            lblProductsHeading.Name = "lblProductsHeading";
            lblProductsHeading.Size = new Size(387, 40);
            lblProductsHeading.TabIndex = 0;
            lblProductsHeading.Text = "PRODUCTS MANAGEMENT";
            // 
            // lblProductsSubtitle
            // 
            lblProductsSubtitle.AutoSize = true;
            lblProductsSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductsSubtitle.ForeColor = Color.DimGray;
            lblProductsSubtitle.Location = new Point(38, 75);
            lblProductsSubtitle.Name = "lblProductsSubtitle";
            lblProductsSubtitle.Size = new Size(334, 17);
            lblProductsSubtitle.TabIndex = 1;
            lblProductsSubtitle.Text = "Manage your stationery products and stock information";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblProductName.ForeColor = Color.DimGray;
            lblProductName.Location = new Point(35, 130);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(96, 17);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Product Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblCategory.ForeColor = Color.DimGray;
            lblCategory.Location = new Point(420, 130);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(64, 17);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblUnitPrice.ForeColor = Color.DimGray;
            lblUnitPrice.Location = new Point(35, 190);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(105, 17);
            lblUnitPrice.TabIndex = 4;
            lblUnitPrice.Text = "Unit Price (KSh)";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblQuantity.ForeColor = Color.DimGray;
            lblQuantity.Location = new Point(420, 190);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(62, 17);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Quantity";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblSupplier.ForeColor = Color.DimGray;
            lblSupplier.Location = new Point(35, 250);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(59, 17);
            lblSupplier.TabIndex = 6;
            lblSupplier.Text = "Supplier";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtProductName.Location = new Point(160, 125);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(200, 23);
            txtProductName.TabIndex = 7;
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCategory.Location = new Point(545, 125);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(200, 23);
            txtCategory.TabIndex = 8;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtUnitPrice.Location = new Point(160, 185);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(200, 23);
            txtUnitPrice.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtQuantity.Location = new Point(545, 185);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 23);
            txtQuantity.TabIndex = 10;
            // 
            // txtSupplier
            // 
            txtSupplier.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtSupplier.Location = new Point(160, 245);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(200, 23);
            txtSupplier.TabIndex = 11;
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.BackColor = Color.DarkGreen;
            btnSaveProduct.FlatStyle = FlatStyle.Flat;
            btnSaveProduct.ForeColor = Color.White;
            btnSaveProduct.Location = new Point(160, 310);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(130, 40);
            btnSaveProduct.TabIndex = 12;
            btnSaveProduct.Text = "SAVE PRODUCT";
            btnSaveProduct.UseVisualStyleBackColor = false;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.BackColor = Color.SteelBlue;
            btnUpdateProduct.FlatStyle = FlatStyle.Flat;
            btnUpdateProduct.ForeColor = Color.White;
            btnUpdateProduct.Location = new Point(305, 310);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(110, 40);
            btnUpdateProduct.TabIndex = 13;
            btnUpdateProduct.Text = "UPDATE";
            btnUpdateProduct.UseVisualStyleBackColor = false;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.Firebrick;
            btnDeleteProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteProduct.ForeColor = Color.White;
            btnDeleteProduct.Location = new Point(430, 310);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(110, 40);
            btnDeleteProduct.TabIndex = 14;
            btnDeleteProduct.Text = "DELETE";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnClearProduct
            // 
            btnClearProduct.BackColor = Color.LightSlateGray;
            btnClearProduct.FlatStyle = FlatStyle.Flat;
            btnClearProduct.ForeColor = Color.Black;
            btnClearProduct.Location = new Point(555, 310);
            btnClearProduct.Name = "btnClearProduct";
            btnClearProduct.Size = new Size(110, 40);
            btnClearProduct.TabIndex = 15;
            btnClearProduct.Text = "CLEAR";
            btnClearProduct.UseVisualStyleBackColor = false;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colProductID, colProductName, colCategory, colUnitPrice, colQuantity, colSupplier });
            dgvProducts.Location = new Point(35, 356);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(750, 150);
            dgvProducts.TabIndex = 16;
            // 
            // colProductID
            // 
            colProductID.HeaderText = "Product ID";
            colProductID.Name = "colProductID";
            colProductID.ReadOnly = true;
            // 
            // colProductName
            // 
            colProductName.HeaderText = "Product Name";
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            colUnitPrice.HeaderText = "Unit Price (KSh)";
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colSupplier
            // 
            colSupplier.HeaderText = "Supplier";
            colSupplier.Name = "colSupplier";
            colSupplier.ReadOnly = true;
            // 
            // lblSearchProduct
            // 
            lblSearchProduct.AutoSize = true;
            lblSearchProduct.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchProduct.ForeColor = Color.DimGray;
            lblSearchProduct.Location = new Point(469, 48);
            lblSearchProduct.Name = "lblSearchProduct";
            lblSearchProduct.Size = new Size(104, 17);
            lblSearchProduct.TabIndex = 17;
            lblSearchProduct.Text = "Search Product:";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new Point(592, 42);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(196, 23);
            txtSearchProduct.TabIndex = 18;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.BackColor = Color.MidnightBlue;
            btnSearchProduct.FlatStyle = FlatStyle.Flat;
            btnSearchProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchProduct.ForeColor = Color.White;
            btnSearchProduct.Location = new Point(565, 75);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(100, 35);
            btnSearchProduct.TabIndex = 19;
            btnSearchProduct.Text = "SEARCH";
            btnSearchProduct.UseVisualStyleBackColor = false;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 512);
            Controls.Add(btnSearchProduct);
            Controls.Add(txtSearchProduct);
            Controls.Add(lblSearchProduct);
            Controls.Add(dgvProducts);
            Controls.Add(btnClearProduct);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnUpdateProduct);
            Controls.Add(btnSaveProduct);
            Controls.Add(txtSupplier);
            Controls.Add(txtQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtCategory);
            Controls.Add(txtProductName);
            Controls.Add(lblSupplier);
            Controls.Add(lblQuantity);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblCategory);
            Controls.Add(lblProductName);
            Controls.Add(lblProductsSubtitle);
            Controls.Add(lblProductsHeading);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProductsForm";
            Text = "SMARTIXStation - Products Management";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductsHeading;
        private Label lblProductsSubtitle;
        private Label lblProductName;
        private Label lblCategory;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private Label lblSupplier;
        private TextBox txtProductName;
        private TextBox txtCategory;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private TextBox txtSupplier;
        private Button btnSaveProduct;
        private Button btnUpdateProduct;
        private Button btnDeleteProduct;
        private Button btnClearProduct;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colProductID;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colSupplier;
        private Label lblSearchProduct;
        private TextBox txtSearchProduct;
        private Button btnSearchProduct;
    }
}