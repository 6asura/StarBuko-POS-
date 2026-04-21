namespace Starbuko
{
    partial class NewProductForm
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(57, 42);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(110, 20);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(57, 82);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(173, 39);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(220, 26);
            this.txtProductName.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(173, 79);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(220, 26);
            this.txtPrice.TabIndex = 3;
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Location = new System.Drawing.Point(57, 117);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(91, 20);
            this.lblImagePath.TabIndex = 4;
            this.lblImagePath.Text = "Image Path";
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(173, 114);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(220, 26);
            this.txtImagePath.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(74)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(74, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 49);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(200, 172);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 49);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.txtImagePath);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.lblImagePath);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 520);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Gray;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(399, 110);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(116, 32);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse 📁";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(53)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(578, 525);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrowse;
    }
}