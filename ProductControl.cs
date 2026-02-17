using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbuko
{
    public partial class ProductControl : UserControl
    {
        public Product Product { get; set; }
        public event EventHandler ProductClicked;

        public ProductControl()
        {
            InitializeComponent();
        }

        public ProductControl(Product product) : this()
        {
            Product = product;
            LoadProductData();
        }

        private void LoadProductData()
        {
            if (Product != null)
            {
                lblProductName.Text = Product.Name;
                lblPrice.Text = $"₱{Product.Price:F2}";

                try
                {
                    string imagePath = Product.ImagePath;

                    // Try relative path from current directory
                    if (!File.Exists(imagePath))
                    {
                        // Try from application base directory
                        string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                        imagePath = Path.Combine(baseDir, Product.ImagePath);
                    }

                    if (File.Exists(imagePath))
                    {
                        pictureBox1.Image = Image.FromFile(imagePath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        // For debugging - show that image wasn't found
                        pictureBox1.BackColor = Color.DarkRed;
                    }
                }
                catch (Exception ex)
                {
                    // If image loading fails, show red background
                    pictureBox1.BackColor = Color.DarkRed;
                    MessageBox.Show($"Error loading image: {ex.Message}\nPath: {Product.ImagePath}", "Image Load Error");
                }
            }
        }

        private void ProductControl_Click(object sender, EventArgs e)
        {
            ProductClicked?.Invoke(this, EventArgs.Empty);
        }

        private void lblProductName_Click(object sender, EventArgs e)
        {
            ProductControl_Click(sender, e);
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            ProductControl_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProductControl_Click(sender, e);
        }
    }
}
