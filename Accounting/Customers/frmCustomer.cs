using Accounting.Customers;
using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

            BindGrid();
        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomers.AutoGenerateColumns = false;
                dgvCustomers.DataSource = db.CustomerRepository.GetAllCustomers();
                txtFilter.Clear();
            }
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomers.DataSource = db.CustomerRepository.GetCustomerByFilter(txtFilter.Text);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if(dgvCustomers.SelectedRows != null)
            {
                using(UnitOfWork db = new UnitOfWork())
                {
                    string name = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                    if (RtlMessageBox.Show($"آیا از حذف شخص {name} مطمعن هستید؟","هشدار",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int customerId = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
                        db.CustomerRepository.DeleteCustomerById(customerId);
                        db.Save();
                        BindGrid();
                    }

                }
            }
            else
            {
                RtlMessageBox.Show("یک خانه انتخاب کنید","راهنمای حذف",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddOrEditCustomer frmAdd = new frmAddOrEditCustomer();
            
            if(frmAdd.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if(dgvCustomers.CurrentRow != null)
            {
                frmAddOrEditCustomer frmAddOrEdit = new frmAddOrEditCustomer();
                int cutomerId = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());

                frmAddOrEdit.customerId = cutomerId;
                if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }

                //using (UnitOfWork db = new UnitOfWork())
                //{
                //    db.CustomerRepository.UpdateCustomer(db.CustomerRepository.GetCustomerById(cutomerId));
                //    db.Save();
                //    BindGrid();
                //}
            }

            else
            {
                RtlMessageBox.Show("یک خانه انتخاب کنید", "راهنمای حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
