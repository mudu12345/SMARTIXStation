namespace WinFormsApp1
{
    partial class DashboardForm
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
            pnlSidebar = new Panel();
            btnLongout = new Button();
            btnSettings = new Button();
            btnReports = new Button();
            btnInventory = new Button();
            btnSales = new Button();
            btnCustomers = new Button();
            btnProduct = new Button();
            btnDashboard = new Button();
            lblAppSubtitle = new Label();
            lblAppName = new Label();
            pnlMain = new Panel();
            statusStrip1 = new StatusStrip();
            lblSystemStatus = new ToolStripStatusLabel();
            dgvRecentActivities = new DataGridView();
            colActivityID = new DataGridViewTextBoxColumn();
            colActivity = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            lblRecentActivities = new Label();
            pnlStockCard = new Panel();
            lblStockCount = new Label();
            label1 = new Label();
            pnlSalesCard = new Panel();
            lblSalesCount = new Label();
            lblSalesTitle = new Label();
            pnlCustomersCard = new Panel();
            lblCustomersCount = new Label();
            lblCustomersTitle = new Label();
            pnlProductsCard = new Panel();
            lblProductsCount = new Label();
            lblProductsTitle = new Label();
            lblWelcome = new Label();
            lblDashboardTitle = new Label();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentActivities).BeginInit();
            pnlStockCard.SuspendLayout();
            pnlSalesCard.SuspendLayout();
            pnlCustomersCard.SuspendLayout();
            pnlProductsCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(0, 0, 192);
            pnlSidebar.Controls.Add(btnLongout);
            pnlSidebar.Controls.Add(btnSettings);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnInventory);
            pnlSidebar.Controls.Add(btnSales);
            pnlSidebar.Controls.Add(btnCustomers);
            pnlSidebar.Controls.Add(btnProduct);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblAppSubtitle);
            pnlSidebar.Controls.Add(lblAppName);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(205, 551);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLongout
            // 
            btnLongout.BackColor = Color.MediumSeaGreen;
            btnLongout.FlatStyle = FlatStyle.Flat;
            btnLongout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLongout.ForeColor = Color.White;
            btnLongout.Location = new Point(3, 506);
            btnLongout.Name = "btnLongout";
            btnLongout.Size = new Size(190, 45);
            btnLongout.TabIndex = 10;
            btnLongout.Text = "Longout";
            btnLongout.UseVisualStyleBackColor = false;
            btnLongout.Click += btnLongout_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(192, 192, 255);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(3, 389);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(190, 45);
            btnSettings.TabIndex = 9;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(192, 192, 255);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(3, 338);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(190, 45);
            btnReports.TabIndex = 8;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(192, 192, 255);
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(3, 287);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(190, 45);
            btnInventory.TabIndex = 7;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.FromArgb(192, 192, 255);
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(3, 236);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(190, 45);
            btnSales.TabIndex = 6;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.FromArgb(192, 192, 255);
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(3, 185);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(190, 45);
            btnCustomers.TabIndex = 5;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.FromArgb(192, 192, 255);
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = Color.White;
            btnProduct.Location = new Point(3, 134);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(190, 45);
            btnProduct.TabIndex = 4;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProducts_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(192, 192, 255);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(3, 83);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(190, 45);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblAppSubtitle
            // 
            lblAppSubtitle.AutoSize = true;
            lblAppSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppSubtitle.ForeColor = Color.White;
            lblAppSubtitle.Location = new Point(21, 49);
            lblAppSubtitle.Name = "lblAppSubtitle";
            lblAppSubtitle.Size = new Size(142, 15);
            lblAppSubtitle.TabIndex = 1;
            lblAppSubtitle.Text = "Stationery Management";
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(12, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(177, 30);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "SMARTIXStation";
            lblAppName.Click += lblAppName_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(statusStrip1);
            pnlMain.Controls.Add(dgvRecentActivities);
            pnlMain.Controls.Add(lblRecentActivities);
            pnlMain.Controls.Add(pnlStockCard);
            pnlMain.Controls.Add(pnlSalesCard);
            pnlMain.Controls.Add(pnlCustomersCard);
            pnlMain.Controls.Add(pnlProductsCard);
            pnlMain.Controls.Add(lblWelcome);
            pnlMain.Controls.Add(lblDashboardTitle);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(205, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(675, 551);
            pnlMain.TabIndex = 1;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblSystemStatus });
            statusStrip1.Location = new Point(0, 529);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(675, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblSystemStatus
            // 
            lblSystemStatus.ForeColor = Color.DarkGreen;
            lblSystemStatus.Name = "lblSystemStatus";
            lblSystemStatus.Size = new Size(91, 17);
            lblSystemStatus.Text = "SMARTIXStation";
            // 
            // dgvRecentActivities
            // 
            dgvRecentActivities.AllowUserToAddRows = false;
            dgvRecentActivities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentActivities.BackgroundColor = Color.White;
            dgvRecentActivities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentActivities.Columns.AddRange(new DataGridViewColumn[] { colActivityID, colActivity, colDate, colDescription });
            dgvRecentActivities.Location = new Point(6, 305);
            dgvRecentActivities.Name = "dgvRecentActivities";
            dgvRecentActivities.Size = new Size(657, 250);
            dgvRecentActivities.TabIndex = 7;
            dgvRecentActivities.CellContentClick += dgvRecentActivities_CellContentClick_1;
            // 
            // colActivityID
            // 
            colActivityID.HeaderText = "Activity ID";
            colActivityID.Name = "colActivityID";
            // 
            // colActivity
            // 
            colActivity.HeaderText = "Activity";
            colActivity.Name = "colActivity";
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            // 
            // colDescription
            // 
            colDescription.HeaderText = "Description";
            colDescription.Name = "colDescription";
            // 
            // lblRecentActivities
            // 
            lblRecentActivities.AutoSize = true;
            lblRecentActivities.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentActivities.ForeColor = Color.MidnightBlue;
            lblRecentActivities.Location = new Point(21, 272);
            lblRecentActivities.Name = "lblRecentActivities";
            lblRecentActivities.Size = new Size(175, 30);
            lblRecentActivities.TabIndex = 6;
            lblRecentActivities.Text = "Recent Activities";
            // 
            // pnlStockCard
            // 
            pnlStockCard.BackColor = Color.MistyRose;
            pnlStockCard.Controls.Add(lblStockCount);
            pnlStockCard.Controls.Add(label1);
            pnlStockCard.Location = new Point(438, 134);
            pnlStockCard.Name = "pnlStockCard";
            pnlStockCard.Size = new Size(150, 120);
            pnlStockCard.TabIndex = 5;
            // 
            // lblStockCount
            // 
            lblStockCount.AutoSize = true;
            lblStockCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockCount.ForeColor = Color.Firebrick;
            lblStockCount.Location = new Point(15, 55);
            lblStockCount.Name = "lblStockCount";
            lblStockCount.Size = new Size(38, 45);
            lblStockCount.TabIndex = 1;
            lblStockCount.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(125, 17);
            label1.TabIndex = 0;
            label1.Text = "LOW STOCK ITEMS";
            // 
            // pnlSalesCard
            // 
            pnlSalesCard.BackColor = Color.Lavender;
            pnlSalesCard.Controls.Add(lblSalesCount);
            pnlSalesCard.Controls.Add(lblSalesTitle);
            pnlSalesCard.ForeColor = Color.Lavender;
            pnlSalesCard.Location = new Point(304, 134);
            pnlSalesCard.Name = "pnlSalesCard";
            pnlSalesCard.Size = new Size(128, 120);
            pnlSalesCard.TabIndex = 4;
            // 
            // lblSalesCount
            // 
            lblSalesCount.AutoSize = true;
            lblSalesCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesCount.ForeColor = Color.Purple;
            lblSalesCount.Location = new Point(15, 55);
            lblSalesCount.Name = "lblSalesCount";
            lblSalesCount.Size = new Size(38, 45);
            lblSalesCount.TabIndex = 1;
            lblSalesCount.Text = "0";
            // 
            // lblSalesTitle
            // 
            lblSalesTitle.AutoSize = true;
            lblSalesTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesTitle.ForeColor = Color.DimGray;
            lblSalesTitle.Location = new Point(15, 20);
            lblSalesTitle.Name = "lblSalesTitle";
            lblSalesTitle.Size = new Size(89, 17);
            lblSalesTitle.TabIndex = 0;
            lblSalesTitle.Text = "TOTAL SALES";
            // 
            // pnlCustomersCard
            // 
            pnlCustomersCard.BackColor = Color.Honeydew;
            pnlCustomersCard.Controls.Add(lblCustomersCount);
            pnlCustomersCard.Controls.Add(lblCustomersTitle);
            pnlCustomersCard.ForeColor = Color.Honeydew;
            pnlCustomersCard.Location = new Point(152, 134);
            pnlCustomersCard.Name = "pnlCustomersCard";
            pnlCustomersCard.Size = new Size(146, 120);
            pnlCustomersCard.TabIndex = 3;
            // 
            // lblCustomersCount
            // 
            lblCustomersCount.AutoSize = true;
            lblCustomersCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomersCount.ForeColor = Color.DarkGreen;
            lblCustomersCount.Location = new Point(15, 55);
            lblCustomersCount.Name = "lblCustomersCount";
            lblCustomersCount.Size = new Size(38, 45);
            lblCustomersCount.TabIndex = 1;
            lblCustomersCount.Text = "0";
            // 
            // lblCustomersTitle
            // 
            lblCustomersTitle.AutoSize = true;
            lblCustomersTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomersTitle.ForeColor = Color.DimGray;
            lblCustomersTitle.Location = new Point(15, 20);
            lblCustomersTitle.Name = "lblCustomersTitle";
            lblCustomersTitle.Size = new Size(128, 17);
            lblCustomersTitle.TabIndex = 0;
            lblCustomersTitle.Text = "TOTAL CUSTOMERS";
            // 
            // pnlProductsCard
            // 
            pnlProductsCard.AutoSize = true;
            pnlProductsCard.Controls.Add(lblProductsCount);
            pnlProductsCard.Controls.Add(lblProductsTitle);
            pnlProductsCard.ForeColor = Color.AliceBlue;
            pnlProductsCard.Location = new Point(6, 134);
            pnlProductsCard.Name = "pnlProductsCard";
            pnlProductsCard.Size = new Size(140, 120);
            pnlProductsCard.TabIndex = 2;
            // 
            // lblProductsCount
            // 
            lblProductsCount.AutoSize = true;
            lblProductsCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductsCount.ForeColor = Color.MidnightBlue;
            lblProductsCount.Location = new Point(15, 55);
            lblProductsCount.Name = "lblProductsCount";
            lblProductsCount.Size = new Size(38, 45);
            lblProductsCount.TabIndex = 1;
            lblProductsCount.Text = "0";
            // 
            // lblProductsTitle
            // 
            lblProductsTitle.AutoSize = true;
            lblProductsTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductsTitle.ForeColor = Color.DimGray;
            lblProductsTitle.Location = new Point(15, 20);
            lblProductsTitle.Name = "lblProductsTitle";
            lblProductsTitle.Size = new Size(120, 17);
            lblProductsTitle.TabIndex = 0;
            lblProductsTitle.Text = "TOTAL PRODUCTS";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.DimGray;
            lblWelcome.Location = new Point(38, 80);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(351, 20);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome to SMARTIXStation Management System";
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardTitle.ForeColor = Color.FromArgb(128, 128, 255);
            lblDashboardTitle.Location = new Point(35, 30);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(304, 40);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "Dashboard Overview";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 551);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SMARTIXStation - Dashboard";
            WindowState = FormWindowState.Maximized;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentActivities).EndInit();
            pnlStockCard.ResumeLayout(false);
            pnlStockCard.PerformLayout();
            pnlSalesCard.ResumeLayout(false);
            pnlSalesCard.PerformLayout();
            pnlCustomersCard.ResumeLayout(false);
            pnlCustomersCard.PerformLayout();
            pnlProductsCard.ResumeLayout(false);
            pnlProductsCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblAppName;
        private Label lblAppSubtitle;
        private Button btnDashboard;
        private Button btnSales;
        private Button btnCustomers;
        private Button btnProduct;
        private Button btnInventory;
        private Button btnLongout;
        private Button btnSettings;
        private Button btnReports;
        private Panel pnlMain;
        private Label lblDashboardTitle;
        private Label lblWelcome;
        private Panel pnlProductsCard;
        private Label lblProductsTitle;
        private Panel pnlCustomersCard;
        private Label lblProductsCount;
        private Label lblCustomersCount;
        private Label lblCustomersTitle;
        private Panel pnlSalesCard;
        private Label lblSalesTitle;
        private Label lblSalesCount;
        private Panel pnlStockCard;
        private Label lblStockCount;
        private Label label1;
        private Label lblRecentActivities;
        private DataGridView dgvRecentActivities;
        private DataGridViewTextBoxColumn colActivityID;
        private DataGridViewTextBoxColumn colActivity;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colDescription;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblSystemStatus;
    }
}