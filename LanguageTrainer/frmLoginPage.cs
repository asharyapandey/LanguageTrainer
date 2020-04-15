using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LanguageTrainer.BLL;

namespace LanguageTrainer
{
    public partial class frmLoginPage : Form
    {
        LoginBLL bll = new LoginBLL();
        DataTable dt;
        public frmLoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //validation
            if(string.IsNullOrEmpty(txtUsername.Text))
            {
                lblError.Text = "****Enter a Username****";
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblError.Text = "****Enter a Password****";
            }
            //passing values to BLL through BLL
            bll._username = txtUsername.Text;
            bll._password = txtPassword.Text;

            dt = bll.CheckLogin();
            if (dt.Rows.Count > 0)//if the datatable has more rows than 0 then login will be successfull
            {
                string playersName = dt.Rows[0][0].ToString();
                this.Hide();
                frmDashboard frmD = new frmDashboard(playersName);//Gets players FullName
                frmD.ShowDialog();//opens dashboard
                this.Close();
            }
            else
            {
                lblError.Text = "****Username or Password Incorrect****";
            }
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLoginPage_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void lnkSingup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddPlayer frms = new frmAddPlayer();
            frms.ShowDialog();
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)//to show hidden password
        {
            if(chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
