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
    public partial class frmAddWord : Form
    {
        AddWordsBLL bll = new AddWordsBLL();
        public frmAddWord()
        {
            InitializeComponent();
        }
        private void frmAddWord_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        private void LoadDataGrid()//loads data in the dataGridview
        {
            DataTable dt = bll.RetriveWord();//method in BLL that retrives data
            dgvAddWords.DataSource = dt;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //validation
            if (string.IsNullOrEmpty(txtWord.Text))
            {
                lblError.Text = "Enter a Word.";
                return;
            }
            if (string.IsNullOrEmpty(txtTranslation.Text))
            {
                lblError.Text = "Enter the Translation.";
                return;
            }
            string wordSet;
            //passing values to BLL through setters
            bll._word = txtWord.Text;
            bll._translation = txtTranslation.Text;
            if (rdoEngA.Checked)
            {
                wordSet = "a";
            }
            else if (rdoEngB.Checked)
            {
                wordSet = "b";
            }
            else
            {
                lblError.Text = "Select a Word Set!!!!";
                return;
            }
            bll._wordSet = wordSet;
            //to insert and update according to texts in btnAdd
            if (btnAdd.Text == "Add")
            {
                bll.InsertWords();//method in BLL that insert word
            }
            else if (btnAdd.Text == "Update")
            {
                bll.UpdateWord();//method in BLL that updates word
            }
            LoadDataGrid();
            Clear();
        }
        private void Clear()
        {
            txtWord.Clear();
            txtTranslation.Clear();
            rdoEngA.Checked = false;
            rdoEngB.Checked = false;
        }
        int wordId;
        private void dgvAddWords_Click(object sender, EventArgs e)
        {
            int columnIndex = dgvAddWords.CurrentCell.ColumnIndex;
            wordId = int.Parse(dgvAddWords.CurrentRow.Cells["wordID"].Value.ToString());
            bll._wordID = wordId.ToString();
            DataTable dt;
            if (dgvAddWords.CurrentRow.Cells[columnIndex].Value.ToString() == "Edit")
            {
                dt = bll.RetriveWord(wordId);
                txtWord.Text = dt.Rows[0][1].ToString();
                txtTranslation.Text = dt.Rows[0][2].ToString();
                if (dt.Rows[0][3].ToString() == "a")
                {
                    rdoEngA.Checked = true;
                }
                else
                {
                    rdoEngB.Checked = true;
                }
                btnAdd.Text = "Update";
            }
            else if (dgvAddWords.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {//displaynf the interactive message box
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete the word?",
                    "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    bll.DeleteWord();
                }
            }
            LoadDataGrid();
        }
    }
}
