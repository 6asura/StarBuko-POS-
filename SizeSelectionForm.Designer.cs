namespace Starbuko
{
    partial class SizeSelectionForm
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
            this.btnRegular = new System.Windows.Forms.Button();
            this.btnGrande = new System.Windows.Forms.Button();
            this.btnVenti = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegular
            // 
            this.btnRegular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(74)))));
            this.btnRegular.FlatAppearance.BorderSize = 0;
            this.btnRegular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnRegular.ForeColor = System.Drawing.Color.White;
            this.btnRegular.Location = new System.Drawing.Point(27, 19);
            this.btnRegular.Name = "btnRegular";
            this.btnRegular.Size = new System.Drawing.Size(148, 56);
            this.btnRegular.TabIndex = 0;
            this.btnRegular.Text = "Regular";
            this.btnRegular.UseVisualStyleBackColor = false;
            this.btnRegular.Click += new System.EventHandler(this.btnRegular_Click);
            // 
            // btnGrande
            // 
            this.btnGrande.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGrande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(74)))));
            this.btnGrande.FlatAppearance.BorderSize = 0;
            this.btnGrande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnGrande.ForeColor = System.Drawing.Color.White;
            this.btnGrande.Location = new System.Drawing.Point(27, 81);
            this.btnGrande.Name = "btnGrande";
            this.btnGrande.Size = new System.Drawing.Size(148, 56);
            this.btnGrande.TabIndex = 1;
            this.btnGrande.Text = "Grande [+20]";
            this.btnGrande.UseVisualStyleBackColor = false;
            this.btnGrande.Click += new System.EventHandler(this.btnGrande_Click);
            // 
            // btnVenti
            // 
            this.btnVenti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(74)))));
            this.btnVenti.FlatAppearance.BorderSize = 0;
            this.btnVenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnVenti.ForeColor = System.Drawing.Color.White;
            this.btnVenti.Location = new System.Drawing.Point(27, 143);
            this.btnVenti.Name = "btnVenti";
            this.btnVenti.Size = new System.Drawing.Size(148, 56);
            this.btnVenti.TabIndex = 2;
            this.btnVenti.Text = "Venti [+30]";
            this.btnVenti.UseVisualStyleBackColor = false;
            this.btnVenti.Click += new System.EventHandler(this.btnVenti_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnVenti);
            this.panel1.Controls.Add(this.btnRegular);
            this.panel1.Controls.Add(this.btnGrande);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 268);
            this.panel1.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(0, 212);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(202, 56);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SizeSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(53)))), ((int)(((byte)(44)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(202, 268);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SizeSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Cup Size";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegular;
        private System.Windows.Forms.Button btnGrande;
        private System.Windows.Forms.Button btnVenti;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
    }
}