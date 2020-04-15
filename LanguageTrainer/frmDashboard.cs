using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageTrainer
{
    public partial class frmDashboard : Form
    {
        string playersName;
        public frmDashboard(string _playersName)
        {
            playersName = _playersName;
            InitializeComponent();
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {

            lblWelcome.Text = "Welcome " + playersName;
        }

        private void btnaAddPlayers_Click(object sender, EventArgs e)
        {
            frmAddPlayer frms = new frmAddPlayer();
            frms.ShowDialog();
        }
        private void btnAddWords_Click(object sender, EventArgs e)
        {
            frmAddWord frma = new frmAddWord();
            frma.ShowDialog();
        }
        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChooseOpponent frmC = new frmChooseOpponent(playersName);
            frmC.ShowDialog();
            this.Hide();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
