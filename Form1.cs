using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Starbuko
{
    public partial class Form1 : Form
    {
        private List<Product> products;
        private BindingList<LineItem> lineItems;
        private ProductRepository productRepository;
        private TransactionRepository transactionRepository;

        private User currentUser;
        private int currentUserId;

        public Form1(User loggedInUser)
        {
            InitializeComponent();

            currentUser = loggedInUser;
            currentUserId = loggedInUser.Id;

            productRepository = new ProductRepository();
            transactionRepository = new TransactionRepository();

            InitializeDataGrid();
            LoadProductsFromDatabase();
            ApplyUserRoleUI();
        }

        private void ApplyUserRoleUI()
        {
            lblWelcome.Text = $"Welcome, {currentUser.FullName} ({currentUser.Role})";

            if (currentUser.Role.ToLower() == "cashier")
            {
                btnNewProduct.Visible = false;
            }
            else if (currentUser.Role.ToLower() == "admin")
            {
                btnNewProduct.Visible = true;
            }
        }

        private void LoadProductsFromDatabase()
        {
            try
            {
                products = productRepository.GetAllActiveProducts();
                LoadProductControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load products from database.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
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
            var productControl = sender as ProductControl;
            if (productControl?.Product != null)
            {
                ShowCupSizeDialog(productControl.Product);
            }
        }

        private void ShowCupSizeDialog(Product product)
        {
            using (var sizeForm = new SizeSelectionForm())
            {
                var result = sizeForm.ShowDialog(this);

                if (result != DialogResult.OK)
                    return;

                string size = sizeForm.SelectedSize;

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

                AddOrUpdateLineItem(product.Id, productName, size, price);
            }
        }

        private void AddOrUpdateLineItem(int productId, string productName, string cupSize, decimal price)
        {
            var existingItem = lineItems.FirstOrDefault(li =>
                li.ProductId == productId &&
                li.CupSize == cupSize &&
                li.UnitPrice == price);

            if (existingItem != null)
            {
                existingItem.Quantity++;
                dataGridView1.Refresh();
            }
            else
            {
                lineItems.Add(new LineItem(productId, productName, cupSize, 1, price));
            }

            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal total = lineItems.Sum(li => li.TotalPrice);
            lblTotalAmount.Text = $"₱{total:F2}";
        }

        private void SaveCurrentTransaction()
        {
            if (lineItems.Count == 0)
            {
                MessageBox.Show("There are no items in the cart.",
                    "No Items",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtAmountTendered.Text, out decimal tendered))
            {
                MessageBox.Show("Please enter a valid amount tendered.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            decimal total = lineItems.Sum(li => li.TotalPrice);

            if (tendered < total)
            {
                MessageBox.Show("Amount tendered is not enough.",
                    "Insufficient Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            decimal change = tendered - total;

            try
            {
                List<LineItem> receiptItems = lineItems.ToList();

                int transactionId = transactionRepository.SaveTransaction(
                    currentUserId,
                    total,
                    tendered,
                    change,
                    receiptItems
                );

                string transactionDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string cashierName = currentUser.FullName;

                MessageBox.Show("Transaction saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                using (ReceiptReportForm receiptForm = new ReceiptReportForm(
                    transactionId,
                    transactionDate,
                    cashierName,
                    receiptItems))
                {
                    receiptForm.ShowDialog();
                }

                lineItems.Clear();
                txtAmountTendered.Clear();
                lblTotalAmount.Text = "₱0.00";
                lblChange.Text = "₱0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save transaction.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            SaveCurrentTransaction();
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            lineItems.Clear();
            txtAmountTendered.Clear();
            lblTotalAmount.Text = "₱0.00";
            lblChange.Text = "₱0.00";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Form1 newForm = new Form1(loginForm.LoggedInUser);
                    newForm.ShowDialog();
                }
                else
                {
                    Application.Exit();
                }
            }

            this.Close();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            using (ManageProductsForm form = new ManageProductsForm())
            {
                form.ShowDialog();
                LoadProductsFromDatabase();
            }
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void panelTop_Paint(object sender, PaintEventArgs e) { }
        private void lblChange_Click(object sender, EventArgs e) { }
        private void lblTitle_Click(object sender, EventArgs e) { }

        private void btnAllTransactionsReport_Click(object sender, EventArgs e)
        {
            AllTransactionsReportForm reportForm = new AllTransactionsReportForm();
            reportForm.ShowDialog();
        }
    }
}