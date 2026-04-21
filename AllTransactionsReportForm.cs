using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace Starbuko
{
    public partial class AllTransactionsReportForm : Form
    {
        private ReportViewer reportViewer1;
        private TransactionRepository transactionRepository;

        public AllTransactionsReportForm()
        {
            InitializeComponent();
            transactionRepository = new TransactionRepository();
        }

        private void AllTransactionsReportForm_Load(object sender, EventArgs e)
        {
            var transactions = transactionRepository.GetAllTransactions();

            reportViewer1.LocalReport.ReportPath = "AllTransactionsReport.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("DataSet1", transactions);
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }

        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(658, 532);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.AllTransactionsReportForm_Load);
            // 
            // AllTransactionsReportForm
            // 
            this.ClientSize = new System.Drawing.Size(658, 532);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AllTransactionsReportForm";
            this.Load += new System.EventHandler(this.AllTransactionsReportForm_Load_1);
            this.ResumeLayout(false);

        }

        private void AllTransactionsReportForm_Load_1(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}