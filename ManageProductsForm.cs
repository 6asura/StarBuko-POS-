using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Starbuko
{
    public partial class ManageProductsForm : Form
    {
        private ProductRepository productRepository;
        private List<Product> products;

        public ManageProductsForm()
        {
            InitializeComponent();
            productRepository = new ProductRepository();
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                products = productRepository.GetAllProducts();

                dataGridViewProducts.DataSource = null;
                dataGridViewProducts.DataSource = products;

                dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewProducts.MultiSelect = false;
                dataGridViewProducts.ReadOnly = true;
                dataGridViewProducts.AllowUserToAddRows = false;

                if (dataGridViewProducts.Columns["ImagePath"] != null)
                    dataGridViewProducts.Columns["ImagePath"].HeaderText = "Image Path";

                if (dataGridViewProducts.Columns["IsActive"] != null)
                    dataGridViewProducts.Columns["IsActive"].HeaderText = "Active";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load products.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Product selectedProduct = dataGridViewProducts.CurrentRow.DataBoundItem as Product;

            if (selectedProduct == null)
            {
                MessageBox.Show("Invalid product selection.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            using (NewProductForm editForm = new NewProductForm(selectedProduct))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (NewProductForm addForm = new NewProductForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }
    }
}