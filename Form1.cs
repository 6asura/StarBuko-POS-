using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbuko
{
    public partial class Form1 : Form
    {
        private List<Product> products;
        private BindingList<LineItem> lineItems;

        public Form1()
        {
            InitializeComponent();
            InitializeProducts();
            InitializeDataGrid();
            LoadProductControls();
        }

        private void InitializeProducts()
        {
            products = new List<Product>
            {
                new Product("Creamy Pure Matcha Latte", 180.00m, "StarbukoImages\\matcha_latte.jpeg"),
                new Product("XOXO Frappuccino", 150.00m, "StarbukoImages\\xoxo_frappucino.jpeg"),
                new Product("Strawberry Açaí with Lemonade", 160.00m, "StarbukoImages\\strawberry_acai_lemonade.jpeg"),
                new Product("Pink Drink with Strawberry Açaí", 165.00m, "StarbukoImages\\pink_drink.jpeg"),
                new Product("Dragon Drink with Mango Dragonfruit", 170.00m, "StarbukoImages\\dragon_drink.jpeg"),
                new Product("Strawberries Cream Frappuccino", 175.00m, "StarbukoImages\\strawberries_cream_frappuccino.jpg"),
                new Product("Chocolate Chip Cream Frappuccino", 180.00m, "StarbukoImages\\chocolate_chip_frappuccino.jpg"),
                new Product("Dark Caramel Coffee Frappuccino", 170.00m, "StarbukoImages\\dark_caramel_frappucino.jpg")
            };
        }

        private void InitializeDataGrid()
        {
            lineItems = new BindingList<LineItem>();
            dataGridView1.DataSource = lineItems;

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void LoadProductControls()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var product in products)
            {
                ProductControl productControl = new ProductControl(product);
                productControl.ProductClicked += ProductControl_ProductClicked;
                flowLayoutPanel1.Controls.Add(productControl);
            }
        }

        private void ProductControl_ProductClicked(object sender, EventArgs e)
        {
            ProductControl productControl = sender as ProductControl;
            if (productControl != null && productControl.Product != null)
            {
                ShowCupSizeDialog(productControl.Product);
            }
        }

        private void ShowCupSizeDialog(Product product)
        {
            string size = ShowSizeSelectionPopup();

            // If user cancelled, don't add the item
            if (size == null)
                return;

            string productName = product.Name;
            decimal price = product.Price;

            if (size == "Grande")
            {
                productName = $"{product.Name} (Grande)";
                price += 20.00m;
            }
            else if (size == "Venti")
            {
                productName = $"{product.Name} (Venti)";
                price += 30.00m;
            }
            // else Regular - keep original name and price

            AddOrUpdateLineItem(productName, price);
        }

        public string ShowSizeSelectionPopup()
        {
            var result = MessageBox.Show(
                "Choose Cup Size:\n" +
                "Yes for Grande (+20), " +
                "No for Venti (+30), " +
                "Cancel for Regular",
                "Select Cup Size",
                MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
                return "Grande";
            if (result == DialogResult.No)
                return "Venti";
            if (result == DialogResult.Cancel)
                return "Regular";

            return null;
        }

        private void AddOrUpdateLineItem(string productName, decimal price)
        {
            var existingItem = lineItems.FirstOrDefault(li => li.ProductName == productName && li.UnitPrice == price);

            if (existingItem != null)
            {
                existingItem.Quantity++;
                dataGridView1.Refresh();
            }
            else
            {
                lineItems.Add(new LineItem(productName, 1, price));
            }

            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal total = lineItems.Sum(li => li.TotalPrice);
            lblTotalAmount.Text = $"₱{total:F2}";
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            lineItems.Clear();
            txtAmountTendered.Clear();
            lblTotalAmount.Text = "₱0.00";
            lblChange.Text = "₱0.00";
        }

        private void txtAmountTendered_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmountTendered.Text, out decimal tendered))
            {
                if (decimal.TryParse(lblTotalAmount.Text.Replace("₱", ""), out decimal total))
                {
                    decimal change = tendered - total;
                    lblChange.Text = $"₱{change:F2}";
                }
            }
            else
            {
                lblChange.Text = "₱0.00";
            }
        }
    }
}
