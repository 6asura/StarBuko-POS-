using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Starbuko
{
    public partial class ProductControl : UserControl
    {
        public Product Product { get; set; }
        public event EventHandler ProductClicked;

        private readonly Color normalBackColor = Color.FromArgb(3, 53, 44);
        private readonly Color hoverBackColor = Color.FromArgb(5, 70, 58);
        private readonly Color pressedBackColor = Color.FromArgb(8, 90, 75);

        public ProductControl()
        {
            InitializeComponent();

            this.BackColor = normalBackColor;
            this.BorderStyle = BorderStyle.FixedSingle;

            HookHoverEvents(this);
        }

        public ProductControl(Product product) : this()
        {
            Product = product;
            LoadProductData();
        }

        private void HookHoverEvents(Control parent)
        {
            parent.MouseEnter += ProductControl_MouseEnter;
            parent.MouseLeave += ProductControl_MouseLeave;
            parent.MouseDown += ProductControl_MouseDown;
            parent.MouseUp += ProductControl_MouseUp;

            foreach (Control child in parent.Controls)
            {
                HookHoverEvents(child);
            }
        }

        private void ProductControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = hoverBackColor;
            this.Cursor = Cursors.Hand;
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        private void ProductControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = normalBackColor;
            this.Cursor = Cursors.Default;
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        private void ProductControl_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = pressedBackColor;
        }

        private void ProductControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
                this.BackColor = hoverBackColor;
            else
                this.BackColor = normalBackColor;
        }

        private void LoadProductData()
        {
            if (Product == null)
                return;

            lblProductName.Text = Product.Name;
            lblPrice.Text = $"₱{Product.Price:F2}";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            try
            {
                string imagePath = ResolveImagePath(Product.ImagePath);

                if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
                {
                    LoadImageWithoutLocking(imagePath);
                }
                else
                {
                    ClearPicture();
                }
            }
            catch
            {
                ClearPicture();
            }
        }

        private string ResolveImagePath(string storedPath)
        {
            if (string.IsNullOrWhiteSpace(storedPath))
                return null;

            if (Path.IsPathRooted(storedPath) && File.Exists(storedPath))
                return storedPath;

            if (File.Exists(storedPath))
                return storedPath;

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            string outputPath = Path.Combine(baseDir, storedPath);
            if (File.Exists(outputPath))
                return outputPath;

            string projectRootPath = Path.GetFullPath(Path.Combine(baseDir, @"..\..\..\", storedPath));
            if (File.Exists(projectRootPath))
                return projectRootPath;

            return storedPath;
        }

        private void LoadImageWithoutLocking(string imagePath)
        {
            ClearPicture();

            using (var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            using (var tempImage = Image.FromStream(fs))
            {
                pictureBox1.Image = new Bitmap(tempImage);
            }
        }

        private void ClearPicture()
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
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