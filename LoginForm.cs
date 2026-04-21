using System;
using System.Windows.Forms;

namespace Starbuko
{
    public partial class LoginForm : Form
    {
        private UserRepository userRepository;

        public User LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter both username and password.",
                    "Missing Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            User user = userRepository.Login(username, password);

            if (user != null)
            {
                LoggedInUser = user;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(
                    "Invalid username or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}