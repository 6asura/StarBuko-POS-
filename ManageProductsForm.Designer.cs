namespace Starbuko
{
    partial class ManageProductsForm
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewProducts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 62;
            this.dataGridViewProducts.RowTemplate.Height = 28;
            this.dataGridViewProducts.Size = new System.Drawing.Size(800, 363);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(74)))));
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.Location = new System.Drawing.Point(249, 380);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(198, 49);
            this.btnEditProduct.TabIndex = 7;
            this.btnEditProduct.Text = "Edit Selected";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(480, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 49);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(74)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(23, 380);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(198, 49);
            this.btnAddProduct.TabIndex = 9;
            this.btnAddProduct.Text = "Add New";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // ManageProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "ManageProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddProduct;
    }
}