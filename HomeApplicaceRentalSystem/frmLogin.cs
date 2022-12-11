using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeApplicaceRentalSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            HomeApplicaceRentalSystemDbEntities db = new HomeApplicaceRentalSystemDbEntities();

            if (txtUserName.Text != string.Empty || txtPassword.Text != string.Empty)
            {
                var user = db.tblUsers.FirstOrDefault(x => x.UserName.Equals(txtUserName.Text));

                if (user != null)
                {
                    if (user.Password.Equals(txtPassword.Text))
                    {
                        this.Hide();
                        UserClass.Id = user.Id;
                        UserClass.UserName = user.UserName;
                        UserClass.UserType = user.UserType;
                        frmAdmin frmAdminMenu = new frmAdmin();

                        frmAdminMenu.Show();

                    }
                    else
                    {
                        lblMessage.Text = "User Name Or Password Incorrect";
                    }
                }
                else
                {
                    lblMessage.Text = "User Does Not Exist, Please Sign Up";
                }
            }
            else
            {
                lblMessage.Text = "Please enter User Name and Password";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cBoxViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxViewPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar= false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar= true;
            }

        }

        private void lbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmSignUp signUp = new frmSignUp();
            signUp.Show();
        }
    }
}
