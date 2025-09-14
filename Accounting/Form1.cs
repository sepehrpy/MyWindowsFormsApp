using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.Accounting;
using Accounting.Business;
using Accounting.Utility.Converter;
using Accounting.ViewModels.Accounting;

namespace Accounting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Hide();
            frmLogin frmLogin = new frmLogin();
            if(frmLogin.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                lblDate.Text = DateTime.Now.ToShamsi();
                lblTime.Text = DateTime.Now.ToLongTimeString();
                Report();
            }
            else
            {
                Application.Exit();
            }


        }

        void Report()
        {
            ReportViewModel report = Accountt.ReportFormMain();
            lblRecive.Text = report.Recive.ToString("#,0");
            lblPay.Text = report.Pay.ToString("#,0");
            lblAccountBalance.Text = report.AccountBalance.ToString("#,0");
        }
        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            frmNewTransaction frmNewTransaction = new frmNewTransaction();
            frmNewTransaction.ShowDialog();
        }

        private void btnReportPay_Click(object sender, EventArgs e)
        {
            frmReport frmReportPay = new frmReport();

            frmReportPay.TypeID = 2;

            frmReportPay.ShowDialog();
        }

        private void btnReportRecive_Click(object sender, EventArgs e)
        {
            frmReport frmReportRecive = new frmReport();

            frmReportRecive.TypeID = 1;

            frmReportRecive.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.IsEdit = true;
            frmLogin.ShowDialog();
        }
    }
}
