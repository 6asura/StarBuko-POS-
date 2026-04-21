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
    public partial class SizeSelectionForm : Form
    {
        public string SelectedSize { get; private set; }

        public SizeSelectionForm()
        {
            InitializeComponent();
        }
        private void btnRegular_Click(object sender, EventArgs e)
        {
            SelectedSize = "Regular";
            DialogResult = DialogResult.OK;
        }
        private void btnGrande_Click(object sender, EventArgs e)
        {
            SelectedSize = "Grande";
            DialogResult = DialogResult.OK;
        }

        private void btnVenti_Click(object sender, EventArgs e)
        {
            SelectedSize = "Venti";
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
