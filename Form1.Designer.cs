namespace Starbuko
{
    partial class Form1
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblChange = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmountTendered = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAllTransactionsReport = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(53)))), ((int)(((byte)(44)))));
            this.panelTop.Controls.Add(this.btnAllTransactionsReport);
            this.panelTop.Controls.Add(this.btnNewProduct);
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Controls.Add(this.btnNewTransaction);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1800, 123);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewProduct.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProduct.ForeColor = System.Drawing.Color.White;
            this.btnNewProduct.Location = new System.Drawing.Point(1459, 31);
            this.btnNewProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(62, 62);
            this.btnNewProduct.TabIndex = 6;
            this.btnNewProduct.Text = "+";
            this.btnNewProduct.UseVisualStyleBackColor = false;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Gray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1623, 31);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(62, 62);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "❮❮";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(406, 44);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(108, 30);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(74)))));
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(302, 786);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(264, 62);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "🛒";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnNewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTransaction.ForeColor = System.Drawing.Color.White;
            this.btnNewTransaction.Location = new System.Drawing.Point(1704, 31);
            this.btnNewTransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(62, 62);
            this.btnNewTransaction.TabIndex = 1;
            this.btnNewTransaction.Text = "✕";
            this.btnNewTransaction.UseVisualStyleBackColor = false;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 31);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Starbuko";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(53)))), ((int)(((byte)(44)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 123);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1200, 927);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panelRight
            // 
            this.panelRight.AutoScroll = true;
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(53)))), ((int)(((byte)(44)))));
            this.panelRight.Controls.Add(this.lblChange);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.txtAmountTendered);
            this.panelRight.Controls.Add(this.btnCheckout);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.lblTotalAmount);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.dataGridView1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1200, 123);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(600, 927);
            this.panelRight.TabIndex = 2;
            // 
            // lblChange
            // 
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.Orange;
            this.lblChange.Location = new System.Drawing.Point(424, 719);
            this.lblChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(146, 46);
            this.lblChange.TabIndex = 6;
            this.lblChange.Text = "₱0.00";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblChange.Click += new System.EventHandler(this.lblChange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 729);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Change:";
            // 
            // txtAmountTendered
            // 
            this.txtAmountTendered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountTendered.Location = new System.Drawing.Point(302, 667);
            this.txtAmountTendered.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmountTendered.Name = "txtAmountTendered";
            this.txtAmountTendered.Size = new System.Drawing.Size(264, 35);
            this.txtAmountTendered.TabIndex = 4;
            this.txtAmountTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountTendered.TextChanged += new System.EventHandler(this.txtAmountTendered_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 670);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount Tendered:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmount.Location = new System.Drawing.Point(139, 601);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(431, 46);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "₱0.00";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 612);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(30, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(540, 544);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAllTransactionsReport
            // 
            this.btnAllTransactionsReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAllTransactionsReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(74)))));
            this.btnAllTransactionsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllTransactionsReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllTransactionsReport.ForeColor = System.Drawing.Color.White;
            this.btnAllTransactionsReport.Location = new System.Drawing.Point(1539, 31);
            this.btnAllTransactionsReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAllTransactionsReport.Name = "btnAllTransactionsReport";
            this.btnAllTransactionsReport.Size = new System.Drawing.Size(62, 62);
            this.btnAllTransactionsReport.TabIndex = 7;
            this.btnAllTransactionsReport.Text = "🧾";
            this.btnAllTransactionsReport.UseVisualStyleBackColor = false;
            this.btnAllTransactionsReport.Click += new System.EventHandler(this.btnAllTransactionsReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(53)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1800, 1050);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Starbuko - Coffee Ordering System";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmountTendered;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNewTransaction;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Button btnAllTransactionsReport;
    }
}

