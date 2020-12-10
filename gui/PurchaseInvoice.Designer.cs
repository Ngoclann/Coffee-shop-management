namespace CoffeeShopManagement.gui
{
    partial class PurchaseInvoice
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
            this.cbxStaff = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPurchaseItems = new System.Windows.Forms.DataGridView();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseItems)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxStaff
            // 
            this.cbxStaff.FormattingEnabled = true;
            this.cbxStaff.Location = new System.Drawing.Point(91, 30);
            this.cbxStaff.Name = "cbxStaff";
            this.cbxStaff.Size = new System.Drawing.Size(124, 21);
            this.cbxStaff.TabIndex = 0;
            this.cbxStaff.SelectedIndexChanged += new System.EventHandler(this.cbxStaff_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff";
            // 
            // dgvPurchaseItems
            // 
            this.dgvPurchaseItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPurchaseItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseItems.Location = new System.Drawing.Point(0, 57);
            this.dgvPurchaseItems.Name = "dgvPurchaseItems";
            this.dgvPurchaseItems.Size = new System.Drawing.Size(644, 351);
            this.dgvPurchaseItems.TabIndex = 2;
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(221, 28);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(92, 23);
            this.btnGetAll.TabIndex = 3;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(50, 417);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 41);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(245, 417);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 41);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(426, 417);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 41);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // PurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(646, 464);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.dgvPurchaseItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxStaff);
            this.Name = "PurchaseInvoice";
            this.Text = "PurchaseInvoice";
            this.Load += new System.EventHandler(this.PurchaseInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPurchaseItems;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}