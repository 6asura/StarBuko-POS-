using System;
using System.Windows.Forms;

namespace Starbuko
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Form1(loginForm.LoggedInUser));
                }
            }
        }
    }
}