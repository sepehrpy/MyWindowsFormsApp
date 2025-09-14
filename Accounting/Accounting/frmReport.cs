using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.Utility.Converter;
using Accounting.ViewModels.Customers;
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

namespace Accounting.Accounting
{
    public partial class frmReport : Form
    {
        public int TypeID = 0;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            using(UnitOfWork db = new UnitOfWork())
            {
                List<ListCustomerViewModel> list = new List<ListCustomerViewModel>();
                list.Add(new  ListCustomerViewModel()
                    {
                        CustomerID = 0,
                        FullName = "انتخاب کنید"
                    });
                list.AddRange(db.CustomerRepository.GetNameCustomers());
                cbCustomer.DataSource = list;
                cbCustomer.DisplayMember = "FullName";
                cbCustomer.ValueMember = "CustomerID";

            }
            this.Text = (TypeID==1) ? "گزارش های دریافتی" : "گزارش های پرداختی";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        void Filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<SelfAccount> result = new List<SelfAccount>();
                DateTime? startDate;
                DateTime? endDate;

                if ((int)cbCustomer.SelectedValue != 0)
                {
                    int customerId = int.Parse(cbCustomer.SelectedValue.ToString());
                    result.AddRange(db.AccountingRepository.Get(a => a.TypeRef == TypeID && a.CustomerRef == customerId));
                }
                else
                {
                    result.AddRange(db.AccountingRepository.Get(a => a.TypeRef == TypeID));
                }

                if (txtFromDate.Text != "    /  /")
                {
                    startDate = Convert.ToDateTime(txtFromDate.Text);
                    startDate = DateConvertor.ToMiladi(startDate.Value);
                    result = result.Where(a=> a.DateTitle >= startDate).ToList();
                }
                if(txtToDate.Text != "    /  /")
                {
                    endDate = Convert.ToDateTime(txtToDate.Text);
                    endDate = DateConvertor.ToMiladi(endDate.Value);
                    result = result.Where(a => a.DateTitle <= endDate).ToList();

                }




                dgvReport.Rows.Clear();
                foreach (var report in result)
                {
                    string customerName = db.CustomerRepository.GetCustomerNameById(report.CustomerRef);

                    dgvReport.Rows.Add(report.ID, customerName ,report.Amount ,report.DateTitle.ToShamsi() , report.Discription);
                }

               
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvReport.CurrentRow != null)
            {
                int Id = int.Parse(dgvReport.CurrentRow.Cells[0].Value.ToString());

                if (RtlMessageBox.Show("آیا از حذف خود مطمعن هستید ؟","هشدار",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.AccountingRepository.DeleteById(Id);
                        db.Save();
                        Filter();
                    }
                }
                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvReport.CurrentRow != null)
            {
                frmNewTransaction frmNewTransaction = new frmNewTransaction();
                int Id = int.Parse(dgvReport.CurrentRow.Cells[0].Value.ToString());
                frmNewTransaction.accountID = Id;

                if (frmNewTransaction.ShowDialog() == DialogResult.OK)
                {
                    Filter();

                }
            }
       
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           DataTable dt = new DataTable();
            dt.Columns.Add("Customer");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Date");
            dt.Columns.Add("Discription");

            foreach(DataGridViewRow item in dgvReport.Rows)
            {
                dt.Rows.Add
                    (
                        item.Cells[1].Value.ToString(),
                        item.Cells[2].Value.ToString(),
                        item.Cells[3].Value.ToString(),
                        item.Cells[4].Value.ToString()
                        //item.Cells[4].Value.ToString()
                    );
            }

            string path = Application.StartupPath +"/Report.mrt";
            Directory.CreateDirectory(path);

            stiReport1.Load(Application.StartupPath +"/Report.mrt");
            stiReport1.RegData("DT",dt);
            stiReport1.Show();

        }
    }
}
