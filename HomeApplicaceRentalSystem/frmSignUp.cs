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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        HomeApplicaceRentalSystemDbEntities db = new HomeApplicaceRentalSystemDbEntities();
        tblUser userDb = new tblUser();

        private void linkLabelBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin userLogin = new frmLogin();
            userLogin.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != string.Empty && txtPassword.Text != string.Empty && txtConfirmPassword.Text != string.Empty)
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    if (txtPassword.Text.Length >= 8 && txtPassword.Text.Length <= 16 )
                    {
                        userDb.UserName = txtUserName.Text;
                        userDb.Password = txtPassword.Text;
                        userDb.UserType = "Customer";
                        db.tblUsers.Add(userDb);
                        db.SaveChanges();
                        lblMessage.Text = "Sign Up Successful";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblMessage.Text = "The Password must 8 to 16 charecter";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                   
                }
                else
                {
                    lblMessage.Text = "Password Not Same";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblMessage.Text = "Fill up text Box";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsNumber(ch) && !char.IsLetter(ch) && ch != 1 && ch != 49)
            {
                e.Handled = true;
                MessageBox.Show("Only accept Number or letter.");
            }
        }
    }
}
