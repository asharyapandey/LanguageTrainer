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
    public partial class frmChooseOpponent : Form
    {
        ChooseOpponentBLL bll = new ChooseOpponentBLL();
        RadioButton radio;
        string player2, player1, wordSet;
        public frmChooseOpponent(string _player1)
        {
            player1 = _player1;
            InitializeComponent();
        }
        private void frmChooseOpponent_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void LoadForm()
        {
            int x = 20, y = 30;
            DataTable dt = bll.RetriveUsers();
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string newPlayer = dt.Rows[i][3].ToString();
                if (player1 != newPlayer)
                {
                    radio = new RadioButton();
                    radio.Location = new Point(x, y);
                    radio.Size = new Size(200, 40);
                    radio.Text = newPlayer;
                    radio.ForeColor = Color.White;
                    grpChoose.Controls.Add(radio);
                    y += 50;
                }
                
            }

        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frmd = new frmDashboard(player1);
            frmd.ShowDialog();
            this.Close();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            WordSet();
            foreach (RadioButton rdo in grpChoose.Controls)
            {
                if(rdo.Checked)
                {
                    player2 = rdo.Text;
                    this.Hide();
                    frmGame frmG = new frmGame(player1, player2, wordSet);
                    frmG.ShowDialog();
                    this.Close();
                }
            }
            
        }
        private void WordSet()
        {
            if (rdoEng2.Checked)
            {
                wordSet = "b";
            }
            else if (rdoEng1.Checked)
            {
                wordSet = "a";
            }
            else
            {
                lblError.Text = "Choose A Word Set.";
                return;
            }
        }
    }
}
