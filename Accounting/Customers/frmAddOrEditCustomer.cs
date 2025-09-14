using Accounting.DataLayer.Context;
using Accounting.DataLayer;
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
using System.IO;
namespace Accounting.Customers
{
    public partial class frmAddOrEditCustomer : Form
    {
        public frmAddOrEditCustomer()
        {
            InitializeComponent();
        }

        public int customerId = 0;

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcCustomer.ImageLocation = openFile.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (BaseValidator.IsFormValid(this.components))
            {

                using(UnitOfWork db  = new UnitOfWork())
                {
                    Customer customer = new Customer();

                    string NameImage = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomer.ImageLocation);

                    string path = Application.StartupPath+"/Images/";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    pcCustomer.Image.Save(path+NameImage);

                    customer.FullName = txtName.Text;
                    customer.Email = txtEmail.Text;
                    customer.Address = txtAddress.Text;
                    customer.Mobile = txtMobile.Text;
                    customer.CustomerImage = NameImage;
                    customer.CustomerID = customerId;

                    if(customerId ==0)
                    {
                        
                        db.CustomerRepository.InsertCustomer(customer);
                        db.Save();
                    }

                    else
                    {
                        db.CustomerRepository.UpdateCustomer(customer);
                        db.Save();

                    }
                    DialogResult = DialogResult.OK;


                }


            }

        }

        private void frmAddOrEditCustomer_Load(object sender, EventArgs e)
        {
            if (customerId != 0)
            {
                this.Text = "ویرایش شخص";
                this.btnSave.Text = "ویرایش";
                using (UnitOfWork db = new UnitOfWork())
                {
                    Customer customer = db.CustomerRepository.GetCustomerById(customerId);

                    txtName.Text = customer.FullName;
                    txtMobile.Text = customer.Mobile;
                    txtEmail.Text = customer.Email;
                    txtAddress.Text = customer.Address;
                    pcCustomer.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;

                }
            }
        }

        private void pcCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
