namespace CoffeeShopManagement.gui
{
    partial class SearchProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.radCode = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radCategory = new System.Windows.Forms.RadioButton();
            this.radName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEARCH PRODUCT";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(21, 101);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(222, 28);
            this.txtSearch.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(0, 170);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(774, 280);
            this.dgvProduct.TabIndex = 3;
            // 
            // radCode
            // 
            this.radCode.AutoSize = true;
            this.radCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCode.Location = new System.Drawing.Point(3, 16);
            this.radCode.Name = "radCode";
            this.radCode.Size = new System.Drawing.Size(65, 24);
            this.radCode.TabIndex = 4;
            this.radCode.TabStop = true;
            this.radCode.Text = "Code";
            this.radCode.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radCategory);
            this.panel1.Controls.Add(this.radName);
            this.panel1.Controls.Add(this.radCode);
            this.panel1.Location = new System.Drawing.Point(438, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 54);
            this.panel1.TabIndex = 5;
            // 
            // radCategory
            // 
            this.radCategory.AutoSize = true;
            this.radCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCategory.Location = new System.Drawing.Point(189, 16);
            this.radCategory.Name = "radCategory";
            this.radCategory.Size = new System.Drawing.Size(91, 24);
            this.radCategory.TabIndex = 6;
            this.radCategory.TabStop = true;
            this.radCategory.Text = "Category";
            this.radCategory.UseVisualStyleBackColor = true;
            // 
            // radName
            // 
            this.radName.AutoSize = true;
            this.radName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radName.Location = new System.Drawing.Point(95, 16);
            this.radName.Name = "radName";
            this.radName.Size = new System.Drawing.Size(69, 24);
            this.radName.TabIndex = 5;
            this.radName.TabStop = true;
            this.radName.Text = "Name";
            this.radName.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(21, 135);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 29);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(157, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 29);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "SearchProduct";
            this.Text = "SearchProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.RadioButton radCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radCategory;
        private System.Windows.Forms.RadioButton radName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
    }
}