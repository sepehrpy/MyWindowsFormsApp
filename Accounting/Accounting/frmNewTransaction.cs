using Accounting.DataLayer;
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Context;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;
using Accounting.Accounting;
using Accounting.ViewModels.Customers;
using System.Security.Principal;

namespace Accounting
{
    public partial class frmNewTransaction : Form
    {
        public int accountID = 0 ;
        DateTime datetime ;
        public frmNewTransaction()
        {
            InitializeComponent();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

            using (UnitOfWork db = new UnitOfWork())
            {
                dgCustomers.DataSource = db.CustomerRepository.GetNameCustomers(txtFilter.Text);
            }
        }

        private void frmNewTransaction_Load(object sender, EventArgs e)
        {
            if (accountID == 0)
            {
                dgCustomers.AutoGenerateColumns = false;
                using (UnitOfWork db = new UnitOfWork())
                {
                    dgCustomers.DataSource = db.CustomerRepository.GetNameCustomers();
                }
            }
            else
            {
                this.Text = "ویرایش گزارشات";
                btnSave.Text = "ویرایش";
                dgCustomers.AutoGenerateColumns = false;


                using (UnitOfWork db = new UnitOfWork())
                {
                    var Account = db.AccountingRepository.GetById(accountID);


                    txtName.Text = db.CustomerRepository.GetCustomerNameById(Account.CustomerRef);
                    txtAmount.Value = int.Parse(Account.Amount.ToString());
                    txtDiscription.Text = Account.Discription.ToString();

                    datetime = Account.DateTitle;
                    
                    if(Account.TypeRef==1)
                    {
                        rbReceive.Checked = true;
                    }
                    else
                    {
                        rbPay.Checked = true;
                    }
                    
                }
                
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgCustomers.CurrentCell.Value.ToString();

        }

        private void rbReceive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {

                if(rbPay.Checked || rbReceive.Checked)
                {
                    using(UnitOfWork db = new UnitOfWork())
                    {

                        SelfAccount sf = new SelfAccount()
                        {
                            
                            CustomerRef = db.CustomerRepository.GetIdByName(txtName.Text),
                            TypeRef = (rbPay.Checked) ? 2 : 1,
                            Amount = int.Parse(txtAmount.Text),
                            Discription = txtDiscription.Text

                        };

                        if (accountID ==0)
                        {
                            sf.DateTitle = DateTime.Now;
                            sf.IsUpdate = false;

                            db.AccountingRepository.Insert(sf);

                        }
                        else
                        {
                            //var datetime = db.AccountingRepository.GetById(accountID).DateTitle;

                            sf.DateTitle = datetime;

                            sf.EditDate = DateTime.Now;
                            
                            sf.ID = accountID;
                            sf.IsUpdate=true;
                            db.AccountingRepository.Update(sf);

                        }

                        db.Save();

                        DialogResult = DialogResult.OK;


                    };

                }
                else
                {
                    RtlMessageBox.Show("لطفا نوع تراکنش را مشخص کنید","توجه");
                }

            }
        }
    }
}
