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
    public partial class frmAddPlayer : Form
    {
        SignupBLL bll = new SignupBLL();
        public frmAddPlayer()
        {
            InitializeComponent();
        }
        private void LoadDataGrid()//loads data in the dataGridview
        {
            DataTable dt = bll.RetriveUsers();//method in BLL that retrives data
            dgvAdd.DataSource = dt;
        }
        private void frmAddPlayer_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }
        int userId;
        private void dgvAdd_Click(object sender, EventArgs e)//to edit and delete data 
        {
            int columnIndex = dgvAdd.CurrentCell.ColumnIndex;
            userId = int.Parse(dgvAdd.CurrentRow.Cells["IDuser"].Value.ToString());
            bll._userID = userId.ToString();
            DataTable dt;
            if (dgvAdd.CurrentRow.Cells[columnIndex].Value.ToString() == "Edit")
            {
                dt = bll.RetriveUsers(userId);
                txtUsername.Text = dt.Rows[0][1].ToString();
                txtFirstName.Text = dt.Rows[0][3].ToString();
                txtLastName.Text = dt.Rows[0][4].ToString();

                btnAdd.Text = "Update";
            }
            else if (dgvAdd.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete User?",
                    "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    bll.DeleteUsers();
                }

            }
            LoadDataGrid();
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void chbShowPassword2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword2.Checked)
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                lblError.Text = "Enter First Name.";
                return;
            }
            DataTable dt = bll.RetriveUsers();
            //passing values to BLL through setters
            bll._fName = txtFirstName.Text;
            bll._lName = txtLastName.Text;
            bll._username = txtUsername.Text;
            if (txtPassword.Text == txtConfirmPassword.Text)//conforming password
            {
                bll._password = txtPassword.Text;
            }
            else
            {
                lblError.Text = "Passwords aren't matching.Please Check!!!!";
                return;
            }
            //to insert and update according to texts in btnAdd
            if (btnAdd.Text == "Add")
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (txtUsername.Text == dt.Rows[i][1].ToString())
                    {
                        lblError.Text = "****Username Already Taken!!! Choose Another One!!****";
                        return;
                    }
                }
                bll.InsertUsers();//method in BLL that insert users
            }
            else if (btnAdd.Text == "Update")
            {
                bll.UpdateUsers();//method in BLL that updates users
            }
            LoadDataGrid();
            Clear();
        }
        private void Clear()
        {
            txtConfirmPassword.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
