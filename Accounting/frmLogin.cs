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
using ValidationComponents;

namespace Accounting
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public bool IsEdit = false;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {

                using (UnitOfWork db = new UnitOfWork())
                {
                    if (IsEdit)
                    {
                        var login = db.LoginRepository.Get().First();
                        login.UserName = txtUserName.Text;
                        login.Password = txtPassword.Text;
                        db.Save();
                        Application.Restart();
                    }
                    else
                    {
                        if (db.LoginRepository.Get(l => l.UserName == txtUserName.Text && l.Password == txtPassword.Text).Any())
                        {
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("رمز یا کلمه ی عبور اشتباه است");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if(IsEdit)
            {
                this.Text = "تنظیمات ورود";
                btnLogin.Text = "ذخیره";
                using(UnitOfWork db = new UnitOfWork())
                {
                    var login = db.LoginRepository.Get().First();

                    txtPassword.Text = login.Password;
                    txtUserName.Text = login.UserName;
                }    
            }
        }
    }
}
