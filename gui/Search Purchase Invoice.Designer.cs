namespace CoffeeShopManagement.gui
{
    partial class Search_Purchase_Invoice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radStaffCode = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radMaterial = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvPurchaseOrder = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Purchase Invoice";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.radStaffCode);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radMaterial);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // radStaffCode
            // 
            this.radStaffCode.AutoSize = true;
            this.radStaffCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radStaffCode.Location = new System.Drawing.Point(553, 65);
            this.radStaffCode.Name = "radStaffCode";
            this.radStaffCode.Size = new System.Drawing.Size(92, 22);
            this.radStaffCode.TabIndex = 5;
            this.radStaffCode.TabStop = true;
            this.radStaffCode.Text = "StaffCode";
            this.radStaffCode.UseVisualStyleBackColor = true;
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
            // radMaterial
            // 
            this.radMaterial.AutoSize = true;
            this.radMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaterial.Location = new System.Drawing.Point(146, 65);
            this.radMaterial.Name = "radMaterial";
            this.radMaterial.Size = new System.Drawing.Size(114, 22);
            this.radMaterial.TabIndex = 3;
            this.radMaterial.TabStop = true;
            this.radMaterial.Text = "ProductCode";
            this.radMaterial.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(499, 32);
            this.textBox1.TabIndex = 1;
            // 
            // dgvPurchaseOrder
            // 
            this.dgvPurchaseOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrder.Location = new System.Drawing.Point(0, 166);
            this.dgvPurchaseOrder.Name = "dgvPurchaseOrder";
            this.dgvPurchaseOrder.Size = new System.Drawing.Size(803, 352);
            this.dgvPurchaseOrder.TabIndex = 4;
            // 
            // Search_Purchase_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.dgvPurchaseOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Search_Purchase_Invoice";
            this.Text = "Search_Purchase_Invoice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radStaffCode;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radMaterial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvPurchaseOrder;
    }
}