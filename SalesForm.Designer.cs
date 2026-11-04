namespace WinFormsApp1
{
    partial class SalesForm
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
            lblSalesHeading = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbProduct = new ComboBox();
            txtSaleQuantity = new TextBox();
            txtSalePrice = new TextBox();
            txtTotalAmount = new TextBox();
            txtSaleCustomer = new TextBox();
            btnCalculateTotal = new Button();
            btnCompleteSale = new Button();
            btnClearSale = new Button();
            dgvSales = new DataGridView();
            colSaleID = new DataGridViewTextBoxColumn();
            colSaleProduct = new DataGridViewTextBoxColumn();
            colSaleQuantity = new DataGridViewTextBoxColumn();
            colSalePrice = new DataGridViewTextBoxColumn();
            colSaleTotal = new DataGridViewTextBoxColumn();
            colSaleDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // lblSalesHeading
            // 
            lblSalesHeading.AutoSize = true;
            lblSalesHeading.BackColor = Color.FromArgb(0, 0, 192);
            lblSalesHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesHeading.ForeColor = Color.White;
            lblSalesHeading.Location = new Point(30, 20);
            lblSalesHeading.Name = "lblSalesHeading";
            lblSalesHeading.Size = new Size(264, 32);
            lblSalesHeading.TabIndex = 0;
            lblSalesHeading.Text = "SALES MANAGEMENT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(30, 90);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 1;
            label1.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(30, 140);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 2;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(431, 91);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 3;
            label3.Text = "Unit Price";
           
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(431, 140);
            label4.Name = "label4";
            label4.Size = new Size(93, 17);
            label4.TabIndex = 4;
            label4.Text = "Total Amount";
            
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(30, 190);
            label5.Name = "label5";
            label5.Size = new Size(107, 17);
            label5.TabIndex = 5;
            label5.Text = "Customer Name";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(150, 90);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(217, 23);
            cmbProduct.TabIndex = 6;
            // 
            // txtSaleQuantity
            // 
            txtSaleQuantity.Location = new Point(150, 140);
            txtSaleQuantity.Name = "txtSaleQuantity";
            txtSaleQuantity.Size = new Size(217, 23);
            txtSaleQuantity.TabIndex = 7;
            // 
            // txtSalePrice
            // 
            txtSalePrice.Location = new Point(571, 85);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(189, 23);
            txtSalePrice.TabIndex = 8;
            
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(571, 134);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(189, 23);
            txtTotalAmount.TabIndex = 9;
           
            // 
            // txtSaleCustomer
            // 
            txtSaleCustomer.Location = new Point(150, 190);
            txtSaleCustomer.Name = "txtSaleCustomer";
            txtSaleCustomer.Size = new Size(217, 23);
            txtSaleCustomer.TabIndex = 10;
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.BackColor = Color.DarkGreen;
            btnCalculateTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateTotal.ForeColor = Color.White;
            btnCalculateTotal.Location = new Point(150, 250);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new Size(130, 40);
            btnCalculateTotal.TabIndex = 11;
            btnCalculateTotal.Text = "Calculate Total";
            btnCalculateTotal.UseVisualStyleBackColor = false;
            // 
            // btnCompleteSale
            // 
            btnCompleteSale.BackColor = Color.DarkRed;
            btnCompleteSale.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompleteSale.ForeColor = Color.White;
            btnCompleteSale.Location = new Point(300, 250);
            btnCompleteSale.Name = "btnCompleteSale";
            btnCompleteSale.Size = new Size(130, 40);
            btnCompleteSale.TabIndex = 12;
            btnCompleteSale.Text = "Complete Sale";
            btnCompleteSale.UseVisualStyleBackColor = false;
            // 
            // btnClearSale
            // 
            btnClearSale.BackColor = Color.DarkMagenta;
            btnClearSale.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearSale.ForeColor = Color.White;
            btnClearSale.Location = new Point(450, 250);
            btnClearSale.Name = "btnClearSale";
            btnClearSale.Size = new Size(130, 40);
            btnClearSale.TabIndex = 13;
            btnClearSale.Text = "Clear";
            btnClearSale.UseVisualStyleBackColor = false;
            // 
            // dgvSales
            // 
            dgvSales.AllowUserToAddRows = false;
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Columns.AddRange(new DataGridViewColumn[] { colSaleID, colSaleProduct, colSaleQuantity, colSalePrice, colSaleTotal, colSaleDate });
            dgvSales.Location = new Point(30, 296);
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(730, 175);
            dgvSales.TabIndex = 14;
            // 
            // colSaleID
            // 
            colSaleID.HeaderText = "Sale ID";
            colSaleID.Name = "colSaleID";
            colSaleID.ReadOnly = true;
            // 
            // colSaleProduct
            // 
            colSaleProduct.HeaderText = "Product";
            colSaleProduct.Name = "colSaleProduct";
            colSaleProduct.ReadOnly = true;
            // 
            // colSaleQuantity
            // 
            colSaleQuantity.HeaderText = "Quantity";
            colSaleQuantity.Name = "colSaleQuantity";
            colSaleQuantity.ReadOnly = true;
            // 
            // colSalePrice
            // 
            colSalePrice.HeaderText = "Unit Price";
            colSalePrice.Name = "colSalePrice";
            colSalePrice.ReadOnly = true;
            // 
            // colSaleTotal
            // 
            colSaleTotal.HeaderText = "Total Amount";
            colSaleTotal.Name = "colSaleTotal";
            colSaleTotal.ReadOnly = true;
            // 
            // colSaleDate
            // 
            colSaleDate.HeaderText = "Sale Date";
            colSaleDate.Name = "colSaleDate";
            colSaleDate.ReadOnly = true;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 506);
            Controls.Add(dgvSales);
            Controls.Add(btnClearSale);
            Controls.Add(btnCompleteSale);
            Controls.Add(btnCalculateTotal);
            Controls.Add(txtSaleCustomer);
            Controls.Add(txtTotalAmount);
            Controls.Add(txtSalePrice);
            Controls.Add(txtSaleQuantity);
            Controls.Add(cmbProduct);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblSalesHeading);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SalesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SMARTIXStation - Sales Management";
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSalesHeading;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbProduct;
        private TextBox txtSaleQuantity;
        private TextBox txtSalePrice;
        private TextBox txtTotalAmount;
        private TextBox txtSaleCustomer;
        private Button btnCalculateTotal;
        private Button btnCompleteSale;
        private Button btnClearSale;
        private DataGridView dgvSales;
        private DataGridViewTextBoxColumn colSaleID;
        private DataGridViewTextBoxColumn colSaleProduct;
        private DataGridViewTextBoxColumn colSaleQuantity;
        private DataGridViewTextBoxColumn colSalePrice;
        private DataGridViewTextBoxColumn colSaleTotal;
        private DataGridViewTextBoxColumn colSaleDate;
    }
}