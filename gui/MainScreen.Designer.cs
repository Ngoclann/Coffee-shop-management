namespace CoffeeShopManagement.gui
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAcountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imputDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stafffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.providerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellInvoiceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestSellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestSellerInYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalAmountrInMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.imputDataToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAcountToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.accountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountToolStripMenuItem.Image")));
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // addAcountToolStripMenuItem
            // 
            this.addAcountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addAcountToolStripMenuItem.Image")));
            this.addAcountToolStripMenuItem.Name = "addAcountToolStripMenuItem";
            this.addAcountToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.addAcountToolStripMenuItem.Text = "Add Acount";
            this.addAcountToolStripMenuItem.Click += new System.EventHandler(this.addAcountToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // imputDataToolStripMenuItem
            // 
            this.imputDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stafffToolStripMenuItem,
            this.providerToolStripMenuItem,
            this.productToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.imputDataToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imputDataToolStripMenuItem.Image")));
            this.imputDataToolStripMenuItem.Name = "imputDataToolStripMenuItem";
            this.imputDataToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.imputDataToolStripMenuItem.Text = "Data";
            this.imputDataToolStripMenuItem.Click += new System.EventHandler(this.imputDataToolStripMenuItem_Click);
            // 
            // stafffToolStripMenuItem
            // 
            this.stafffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stafffToolStripMenuItem.Image")));
            this.stafffToolStripMenuItem.Name = "stafffToolStripMenuItem";
            this.stafffToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.stafffToolStripMenuItem.Text = "Staff";
            this.stafffToolStripMenuItem.Click += new System.EventHandler(this.stafffToolStripMenuItem_Click);
            // 
            // providerToolStripMenuItem
            // 
            this.providerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("providerToolStripMenuItem.Image")));
            this.providerToolStripMenuItem.Name = "providerToolStripMenuItem";
            this.providerToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.providerToolStripMenuItem.Text = "Provider-Material";
            this.providerToolStripMenuItem.Click += new System.EventHandler(this.providerToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productToolStripMenuItem.Image")));
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerToolStripMenuItem.Image")));
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click_1);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseInvoiceToolStripMenuItem,
            this.sellInvoiceToolStripMenuItem});
            this.orderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("orderToolStripMenuItem.Image")));
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.orderToolStripMenuItem.Text = "Invoice";
            // 
            // purchaseInvoiceToolStripMenuItem
            // 
            this.purchaseInvoiceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("purchaseInvoiceToolStripMenuItem.Image")));
            this.purchaseInvoiceToolStripMenuItem.Name = "purchaseInvoiceToolStripMenuItem";
            this.purchaseInvoiceToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.purchaseInvoiceToolStripMenuItem.Text = "Purchase Invoice";
            // 
            // sellInvoiceToolStripMenuItem
            // 
            this.sellInvoiceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sellInvoiceToolStripMenuItem.Image")));
            this.sellInvoiceToolStripMenuItem.Name = "sellInvoiceToolStripMenuItem";
            this.sellInvoiceToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.sellInvoiceToolStripMenuItem.Text = "Sell Invoice";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Checked = true;
            this.searchToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceToolStripMenuItem,
            this.sellInvoiceToolStripMenuItem1});
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("invoiceToolStripMenuItem.Image")));
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.invoiceToolStripMenuItem.Text = "Purchase Invoice";
            // 
            // sellInvoiceToolStripMenuItem1
            // 
            this.sellInvoiceToolStripMenuItem1.Name = "sellInvoiceToolStripMenuItem1";
            this.sellInvoiceToolStripMenuItem1.Size = new System.Drawing.Size(201, 26);
            this.sellInvoiceToolStripMenuItem1.Text = "Sell Invoice";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestSellerToolStripMenuItem,
            this.bestSellerInYearToolStripMenuItem,
            this.totalAmountrInMonthToolStripMenuItem,
            this.totalAmountToolStripMenuItem});
            this.statisticsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("statisticsToolStripMenuItem.Image")));
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // bestSellerToolStripMenuItem
            // 
            this.bestSellerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bestSellerToolStripMenuItem.Image")));
            this.bestSellerToolStripMenuItem.Name = "bestSellerToolStripMenuItem";
            this.bestSellerToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.bestSellerToolStripMenuItem.Text = "Best Seller In Month";
            // 
            // bestSellerInYearToolStripMenuItem
            // 
            this.bestSellerInYearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bestSellerInYearToolStripMenuItem.Image")));
            this.bestSellerInYearToolStripMenuItem.Name = "bestSellerInYearToolStripMenuItem";
            this.bestSellerInYearToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.bestSellerInYearToolStripMenuItem.Text = "Best Seller In Year";
            // 
            // totalAmountrInMonthToolStripMenuItem
            // 
            this.totalAmountrInMonthToolStripMenuItem.Name = "totalAmountrInMonthToolStripMenuItem";
            this.totalAmountrInMonthToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.totalAmountrInMonthToolStripMenuItem.Text = "Total Amount in Month";
            // 
            // totalAmountToolStripMenuItem
            // 
            this.totalAmountToolStripMenuItem.Name = "totalAmountToolStripMenuItem";
            this.totalAmountToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.totalAmountToolStripMenuItem.Text = "Total Amount in Year";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 714);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imputDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stafffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem providerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestSellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestSellerInYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAcountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellInvoiceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem totalAmountrInMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalAmountToolStripMenuItem;
    }
}