namespace CoffeeShopManagement.gui
{
    partial class SellInvoiceSearching
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCustomerCode = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radProdcutCode = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvSellOrder = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Sell Invoice";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(499, 32);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.radCustomerCode);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radProdcutCode);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(-8, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // radCustomerCode
            // 
            this.radCustomerCode.AutoSize = true;
            this.radCustomerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCustomerCode.Location = new System.Drawing.Point(553, 65);
            this.radCustomerCode.Name = "radCustomerCode";
            this.radCustomerCode.Size = new System.Drawing.Size(128, 22);
            this.radCustomerCode.TabIndex = 5;
            this.radCustomerCode.TabStop = true;
            this.radCustomerCode.Text = "CustomerCode";
            this.radCustomerCode.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(382, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 22);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Date";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radProdcutCode
            // 
            this.radProdcutCode.AutoSize = true;
            this.radProdcutCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radProdcutCode.Location = new System.Drawing.Point(146, 65);
            this.radProdcutCode.Name = "radProdcutCode";
            this.radProdcutCode.Size = new System.Drawing.Size(114, 22);
            this.radProdcutCode.TabIndex = 3;
            this.radProdcutCode.TabStop = true;
            this.radProdcutCode.Text = "ProductCode";
            this.radProdcutCode.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvSellOrder
            // 
            this.dgvSellOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSellOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellOrder.Location = new System.Drawing.Point(-1, 182);
            this.dgvSellOrder.Name = "dgvSellOrder";
            this.dgvSellOrder.Size = new System.Drawing.Size(803, 360);
            this.dgvSellOrder.TabIndex = 3;
            // 
            // SellInvoiceSearching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.dgvSellOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "SellInvoiceSearching";
            this.Text = "SellInvoiceSearching";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radProdcutCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radCustomerCode;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dgvSellOrder;
    }
}