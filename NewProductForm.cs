using System;
using System.IO;
using System.Windows.Forms;

namespace Starbuko
{
    public partial class NewProductForm : Form
    {
        private ProductRepository productRepository;
        private Product editingProduct;

        public NewProductForm()
        {
            InitializeComponent();
            productRepository = new ProductRepository();
            editingProduct = null;
        }

        public NewProductForm(Product productToEdit)
        {
            InitializeComponent();
            productRepository = new ProductRepository();
            editingProduct = productToEdit;

            LoadProductForEditing();
        }

        private void LoadProductForEditing()
        {
            if (editingProduct == null)
                return;

            txtProductName.Text = editingProduct.Name;
            txtPrice.Text = editingProduct.Price.ToString("F2");
            txtImagePath.Text = editingProduct.ImagePath;
            btnSave.Text = "Update";
            this.Text = "Edit Product";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text.Trim();
            string priceText = txtPrice.Text.Trim();
            string imagePath = txtImagePath.Text.Trim();

            if (string.IsNullOrWhiteSpace(productName) ||
                string.IsNullOrWhiteSpace(priceText) ||
                string.IsNullOrWhiteSpace(imagePath))
            {
                MessageBox.Show("Please fill in all fields.",
                    "Missing Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Please enter a valid price.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (editingProduct == null)
                {
                    Product newProduct = new Product
                    {
                        Name = productName,
                        Price = price,
                        ImagePath = imagePath,
                        IsActive = true
                    };

                    productRepository.AddProduct(newProduct);

                    MessageBox.Show("Product added successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    editingProduct.Name = productName;
                    editingProduct.Price = price;
                    editingProduct.ImagePath = imagePath;
                    editingProduct.IsActive = true;

                    productRepository.UpdateProduct(editingProduct);

                    MessageBox.Show("Product updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save product.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Product Image";
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string selectedFile = ofd.FileName;
                        string fileName = Path.GetFileName(selectedFile);

                        string baseDir = AppDomain.CurrentDomain.BaseDirectory;

                        string projectImageFolder = Path.GetFullPath(
                            Path.Combine(baseDir, @"..\..\..\StarbukoImages")
                        );

                        string outputImageFolder = Path.Combine(baseDir, "StarbukoImages");

                        if (!Directory.Exists(projectImageFolder))
                            Directory.CreateDirectory(projectImageFolder);

                        if (!Directory.Exists(outputImageFolder))
                            Directory.CreateDirectory(outputImageFolder);

                        string projectDestinationPath = Path.Combine(projectImageFolder, fileName);
                        string outputDestinationPath = Path.Combine(outputImageFolder, fileName);

                        File.Copy(selectedFile, projectDestinationPath, true);
                        File.Copy(selectedFile, outputDestinationPath, true);

                        txtImagePath.Text = @"StarbukoImages\" + fileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error copying image:\n\n" + ex.Message,
                            "Image Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}