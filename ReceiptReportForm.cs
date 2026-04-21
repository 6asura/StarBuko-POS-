using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Starbuko
{
    public partial class ReceiptReportForm : Form
    {
        private int transactionId;
        private string transactionDate;
        private string cashierName;
        private List<LineItem> items;

        public ReceiptReportForm(int transactionId, string transactionDate, string cashierName, List<LineItem> items)
        {
            InitializeComponent();

            this.transactionId = transactionId;
            this.transactionDate = transactionDate;
            this.cashierName = cashierName;
            this.items = items;
        }

        private void ReceiptReportForm_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = "ReceiptReport.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("DataSet1", items);
            reportViewer1.LocalReport.DataSources.Add(rds);

            ReportParameter[] parameters = new ReportParameter[]
            {
                new ReportParameter("TransactionID", transactionId.ToString()),
                new ReportParameter("TransactionDate", transactionDate),
                new ReportParameter("CashierName", cashierName)
            };

            reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.RefreshReport();
        }
    }
}