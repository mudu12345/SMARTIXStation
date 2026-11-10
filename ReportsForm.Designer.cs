namespace WinFormsApp1
{
    partial class ReportsForm
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
            lblReportsHeading = new Label();
            btnSalesReport = new Button();
            btnInventoryReport = new Button();
            btnLowStockReport = new Button();
            btnOutOfStockReport = new Button();
            btnRefreshReports = new Button();
            dgvReports = new DataGridView();
            lblTotalSales = new Label();
            colReportSaleID = new DataGridViewTextBoxColumn();
            colReportProduct = new DataGridViewTextBoxColumn();
            colReportQuantity = new DataGridViewTextBoxColumn();
            colReportPrice = new DataGridViewTextBoxColumn();
            colReportTotal = new DataGridViewTextBoxColumn();
            colReportDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // lblReportsHeading
            // 
            lblReportsHeading.AutoSize = true;
            lblReportsHeading.BackColor = Color.FromArgb(0, 0, 192);
            lblReportsHeading.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportsHeading.ForeColor = Color.White;
            lblReportsHeading.Location = new Point(30, 20);
            lblReportsHeading.Name = "lblReportsHeading";
            lblReportsHeading.Size = new Size(360, 40);
            lblReportsHeading.TabIndex = 0;
            lblReportsHeading.Text = "REPORTS MANAGEMENT";
            // 
            // btnSalesReport
            // 
            btnSalesReport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalesReport.ForeColor = SystemColors.HotTrack;
            btnSalesReport.Location = new Point(25, 90);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(187, 45);
            btnSalesReport.TabIndex = 1;
            btnSalesReport.Text = "Sales Report";
            btnSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnInventoryReport
            // 
            btnInventoryReport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventoryReport.ForeColor = SystemColors.HotTrack;
            btnInventoryReport.Location = new Point(246, 90);
            btnInventoryReport.Name = "btnInventoryReport";
            btnInventoryReport.Size = new Size(174, 45);
            btnInventoryReport.TabIndex = 2;
            btnInventoryReport.Text = "Inventory Report";
            btnInventoryReport.UseVisualStyleBackColor = true;
            // 
            // btnLowStockReport
            // 
            btnLowStockReport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLowStockReport.ForeColor = SystemColors.HotTrack;
            btnLowStockReport.Location = new Point(442, 90);
            btnLowStockReport.Name = "btnLowStockReport";
            btnLowStockReport.Size = new Size(170, 45);
            btnLowStockReport.TabIndex = 3;
            btnLowStockReport.Text = "\tLow Stock Report";
            btnLowStockReport.UseVisualStyleBackColor = true;
            btnLowStockReport.Click += btnLowStockReport_Click;
            // 
            // btnOutOfStockReport
            // 
            btnOutOfStockReport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOutOfStockReport.ForeColor = SystemColors.HotTrack;
            btnOutOfStockReport.Location = new Point(30, 154);
            btnOutOfStockReport.Name = "btnOutOfStockReport";
            btnOutOfStockReport.RightToLeft = RightToLeft.Yes;
            btnOutOfStockReport.Size = new Size(182, 45);
            btnOutOfStockReport.TabIndex = 4;
            btnOutOfStockReport.Text = "Out of Stock Report";
            btnOutOfStockReport.UseVisualStyleBackColor = true;
            btnOutOfStockReport.Click += btnOutOfStockReport_Click;
            // 
            // btnRefreshReports
            // 
            btnRefreshReports.BackColor = Color.FromArgb(128, 128, 255);
            btnRefreshReports.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshReports.ForeColor = Color.White;
            btnRefreshReports.Location = new Point(246, 154);
            btnRefreshReports.Name = "btnRefreshReports";
            btnRefreshReports.Size = new Size(366, 45);
            btnRefreshReports.TabIndex = 5;
            btnRefreshReports.Text = "\tRefresh Reports";
            btnRefreshReports.UseVisualStyleBackColor = false;
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.BackgroundColor = Color.White;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Columns.AddRange(new DataGridViewColumn[] { colReportSaleID, colReportProduct, colReportQuantity, colReportPrice, colReportTotal, colReportDate });
            dgvReports.Location = new Point(12, 262);
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.Size = new Size(755, 176);
            dgvReports.TabIndex = 6;
          
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSales.Location = new Point(25, 222);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(140, 30);
            lblTotalSales.TabIndex = 7;
            lblTotalSales.Text = "Total Sales: 0";
            // 
            // colReportSaleID
            // 
            colReportSaleID.HeaderText = "Sale ID";
            colReportSaleID.Name = "colReportSaleID";
            colReportSaleID.ReadOnly = true;
            // 
            // colReportProduct
            // 
            colReportProduct.HeaderText = "Product Name";
            colReportProduct.Name = "colReportProduct";
            colReportProduct.ReadOnly = true;
            // 
            // colReportQuantity
            // 
            colReportQuantity.HeaderText = "Quantity";
            colReportQuantity.Name = "colReportQuantity";
            colReportQuantity.ReadOnly = true;
            // 
            // colReportPrice
            // 
            colReportPrice.HeaderText = "Unit Price";
            colReportPrice.Name = "colReportPrice";
            colReportPrice.ReadOnly = true;
            // 
            // colReportTotal
            // 
            colReportTotal.HeaderText = "Total Amount";
            colReportTotal.Name = "colReportTotal";
            colReportTotal.ReadOnly = true;
            // 
            // colReportDate
            // 
            colReportDate.HeaderText = "Sale Date";
            colReportDate.Name = "colReportDate";
            colReportDate.ReadOnly = true;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 450);
            Controls.Add(lblTotalSales);
            Controls.Add(dgvReports);
            Controls.Add(btnRefreshReports);
            Controls.Add(btnOutOfStockReport);
            Controls.Add(btnLowStockReport);
            Controls.Add(btnInventoryReport);
            Controls.Add(btnSalesReport);
            Controls.Add(lblReportsHeading);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\tSMARTIXStation - Reports Management";
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReportsHeading;
        private Button btnSalesReport;
        private Button btnInventoryReport;
        private Button btnLowStockReport;
        private Button btnOutOfStockReport;
        private Button btnRefreshReports;
        private DataGridView dgvReports;
        private Label lblTotalSales;
        private DataGridViewTextBoxColumn colReportSaleID;
        private DataGridViewTextBoxColumn colReportProduct;
        private DataGridViewTextBoxColumn colReportQuantity;
        private DataGridViewTextBoxColumn colReportPrice;
        private DataGridViewTextBoxColumn colReportTotal;
        private DataGridViewTextBoxColumn colReportDate;
    }
}