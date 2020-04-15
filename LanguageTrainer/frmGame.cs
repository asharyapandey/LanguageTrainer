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
    public partial class frmGame : Form
    {
        Button btnEng, btnTranslation, btnEngClicked, btnTranslationClicked;
        Panel pnlEndGame;
        string player1, player2, wordSet, engWord, nepWord, winner;
        GameBLL bll = new GameBLL();
        Random rand = new Random();
        bool disableTranslation = true,turn = true, disableEnglish = false;
        int points1 = 0, points2=0,successRateP1,successRateP2,btnClickedP1, btnClickedP2;
        int minutes = 0, time = 0, minutesP1 = 0, timeP1 = 0, minutesP2 = 0, timeP2 = 0;
        public frmGame(string _player1, string _player2, string _wordSet)
        {
            player1 = _player1;
            player2 = _player2;
            wordSet = _wordSet;
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            grpStat.Height = 100;
            int height = (this.Height - grpStat.Height - MenuStrip.Height) / 2;
            grpWord.Height = height;
            grpTranslation.Height = height;
            bll._wordSet = wordSet;
            LoadEnglishButtons();
            LoadTranslatedButtons();
            lblPlayer1.Text = player1;
            lblPlayer2.Text = player2;
            timer.Start();
            timer.Interval = 1000;
            Turn();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time += 1;

            if (time >= 60)
            {
                minutes += 1;
                time = 0;
            }
            lblTime.Text = (minutes).ToString() + ":" + (time).ToString();
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGame frmG = new frmGame(player1, player2, wordSet);
            frmG.ShowDialog();
            this.Close();
        }

        private void timerPlayer1_Tick(object sender, EventArgs e)
        {
            timeP1 += 1;

            if (timeP1 >= 60)
            {
                minutesP1 += 1;
                timeP1 = 0;
            }
            lblTimeP1.Text = (minutesP1).ToString() + ":" + (timeP1).ToString();

        }

        private void timerPlayer2_Tick(object sender, EventArgs e)
        {
            timeP2 += 1;

            if (timeP2 >= 60)
            {
                minutesP2 += 1;
                timeP2 = 0;
            }
            lblTimeP2.Text = (minutesP2).ToString() + ":" + (timeP2).ToString();
        }

        
        private void LoadEnglishButtons()
        {
            List<int> num = Random();
            DataTable dtWords = bll.RetriveWords();
            int x = 20, y = 20;
            for (int i = 0; i < dtWords.Rows.Count; i++)
            {
                btnEng = new Button();
                btnEng.Location = new Point(x, y);
                btnEng.Size = new Size(130, 60);
                btnEng.Name = dtWords.Rows[num[i]][0].ToString();
                btnEng.Text = "Word";
                btnEng.BackColor = Color.White;
                btnEng.ForeColor = Color.Black;
                grpWord.Controls.Add(btnEng);
                btnEng.Click += new EventHandler(btnEng_Click);
                x += 170;
                if (x > grpWord.Width - 120)
                {
                    y += 100;
                    x = 20;
                }
            }
        }
        private void btnEng_Click(object sender, EventArgs e)
        {
            if (!disableEnglish)
            {
                btnEngClicked = sender as Button;
                btnEngClicked.Text = btnEngClicked.Name;
                engWord = btnEngClicked.Name;
                disableTranslation = false;
                disableEnglish = true;
            }
            else
            {
                MessageBox.Show("Select The Translation!!"," Info");
                return;
            } 
        }
        private void LoadTranslatedButtons()
        {
            List<int> num = Random();
            DataTable dtWords = bll.RetriveWords();
            int x = 20, y = 20;
            for (int i = 0; i < dtWords.Rows.Count; i++)
            {
                btnTranslation = new Button();
                btnTranslation.Location = new Point(x, y);
                btnTranslation.Size = new Size(130, 60);
                btnTranslation.Name = dtWords.Rows[num[i]][1].ToString();
                //btnTranslation.Text ="Translation";
                btnTranslation.Text = btnTranslation.Name;
                btnTranslation.BackColor = Color.White;
                btnTranslation.ForeColor = Color.Black;
                grpTranslation.Controls.Add(btnTranslation);
                btnTranslation.Click += new EventHandler(btnTranslation_Click);
                x += 170;
                if (x > grpTranslation.Width - 120)
                {
                    y += 100;
                    x = 20;
                }

            }
        }
        private void btnTranslation_Click(object sender, EventArgs e)
        {
            btnTranslationClicked = sender as Button;
            if (disableTranslation)
            {
                MessageBox.Show("Select A English Word!!"," Info");
                return;
            }
            else if (!disableTranslation)
            {
                btnTranslationClicked.Text = btnTranslationClicked.Name;
                nepWord = btnTranslationClicked.Name;
                disableTranslation = true;
                Timer timerFlip = new Timer()//timer to wait for a second before the button flips
                {
                    Enabled = true,
                    Interval = 1000
                };
                timerFlip.Tick += (s, h) =>
                {
                    CheckAnswer();
                    timerFlip.Dispose();
                };
            }
            disableEnglish = false;
        }
        
        private void CheckAnswer()
        {
            bll._engWord = engWord;
            bll._translatedWord = nepWord;
            DataTable dtCheck = bll.CheckWord();
            if (dtCheck.Rows.Count > 0)
            {
                if (turn)
                {
                    points1 = points1 + 1;
                    lblPoints1.Text = points1.ToString();
                    turn = false;
                }
                else if (!turn)
                {
                    points2 = points2 + 1;
                    lblPoints2.Text = points2.ToString();
                    turn = true;
                }
                CheckGame();
                Turn();
                btnEngClicked.Visible = false;
                btnTranslationClicked.Visible = false;
            }
            else
            {
                if (turn)
                {
                    turn = false;
                }
                else if (!turn)
                {
                    turn = true;
                }
                Turn();
                btnTranslationClicked.Text = "Translation";
                btnEngClicked.Text = "Word";
                
            }
        }
        private void CheckGame()//checks to end the game
        {
            if (int.Parse(lblPoints1.Text) + int.Parse(lblPoints2.Text) == 26)
            {
                if (int.Parse(lblPoints1.Text) > int.Parse(lblPoints2.Text))
                {
                    winner = lblPlayer1.Text;
                }
                else if (int.Parse(lblPoints1.Text) < int.Parse(lblPoints2.Text))
                {
                    winner = lblPlayer2.Text;
                }
                else
                {
                    winner = "Tied";
                }
                InsertToDB();
                GameStat();
            }
        }
        private void Turn()//players turn
        {
            if (turn)
            {
                lblPlayer2.BackColor = Color.White;
                lblPlayer1.BackColor = Color.Gray;
                timerPlayer2.Stop();
                timerPlayer1.Start();
                timerPlayer1.Interval = 1000;
                btnClickedP1++;
            }
            else if(!turn)
            {
                lblPlayer1.BackColor = Color.White;
                lblPlayer2.BackColor = Color.Gray;
                timerPlayer1.Stop();
                timerPlayer2.Start();
                timerPlayer2.Interval = 1000;
                btnClickedP2++;
            }
        }
        private void InsertToDB()
        {
            SuccessRate();
            bll._p1Score = lblPoints1.Text;
            bll._p1Time = lblTimeP1.Text;
            bll._player1 = lblPlayer1.Text;
            bll._p2Score = lblPoints2.Text;
            bll._p2Time = lblTimeP2.Text;
            bll._player2 = lblPlayer2.Text;
            bll._totalTime = lblTime.Text;
            bll._successRate1 = successRateP1.ToString();
            bll._successRate2 = successRateP2.ToString();
            bll._winner = winner;
            bll.InsertGameInfo();
            bll.InsertStat();
        }
        private void SuccessRate()
        {
            successRateP2 = int.Parse(lblPoints2.Text) / btnClickedP2 * 100;
            successRateP1 = int.Parse(lblPoints1.Text) / btnClickedP1 * 100;
        }
        private List<int> Random()//to generete random numbers
        {
            Random rand = new Random();
            List<int> random = new List<int>();
            do
            {
                int a = rand.Next(0, 26);
                if (!random.Contains(a))
                {
                    random.Add(a);
                }
            } while (random.Count < 26);
            return random;
        }
        private void GameStat()//to show game stats in a panel after the game ends
        {
            this.Controls.Clear();
            DataTable dtPlayer1 = bll.RetriveStat1(), dtPlayer2 = bll.RetriveStat2();
            DataTable dtHighScore = bll.RetriveMax(), dtGame = bll.RetriveGameInfo() ;
            int scoreP1 = int.Parse(dtPlayer1.Rows[0][0].ToString());
            int scoreP2 = int.Parse(dtPlayer2.Rows[0][0].ToString());
            int highScore = int.Parse(dtHighScore.Rows[0][0].ToString());
            string time1 = dtPlayer1.Rows[0][1].ToString(), time2 = dtPlayer2.Rows[0][1].ToString();
            string player1 = dtGame.Rows[0][0].ToString(), player2 = dtGame.Rows[0][1].ToString();
            string winner = dtGame.Rows[0][2].ToString();
            //
            pnlEndGame = new Panel();
            pnlEndGame.Location = new System.Drawing.Point(526,200);
            pnlEndGame.Name = "pnlEndGame";
            pnlEndGame.Size = new System.Drawing.Size(520, 387);
            pnlEndGame.BackColor = Color.DarkGray;
            pnlEndGame.TabIndex = 0;
            this.Controls.Add(pnlEndGame);
            //
            Label lblHighScore = new Label();
            lblHighScore.Location = new Point(20, 20);
            lblHighScore.Size = new Size(400, 30);
            lblHighScore.ForeColor = Color.White;
            pnlEndGame.Controls.Add(lblHighScore);
            if(scoreP1 > highScore)
            {
                lblHighScore.Text = $"Congratulations!!! {player1} achieved a new high score";
            }
            else if(scoreP2 > highScore)
            {
                lblHighScore.Text = $"Congratulations!!! {player2} achieved a new high score";
            }
            //
            Label lblWinner = new Label();
            lblWinner.Location = new Point(20, 60);
            lblWinner.Size = new Size(200, 30);
            lblWinner.ForeColor = Color.White;
            pnlEndGame.Controls.Add(lblWinner);
            lblWinner.Text = $"{winner } Wins";
            //
            Label lblPlayer1Time = new Label();
            lblPlayer1Time.Location = new Point(20, 100);
            lblPlayer1Time.Size = new Size(200, 30);
            lblPlayer1Time.ForeColor = Color.White;
            lblPlayer1Time.Text = $"{player1}'s Time: {time1}";
            pnlEndGame.Controls.Add(lblPlayer1Time);
            //
            Label lblPlayer1Score = new Label();
            lblPlayer1Score.Location = new Point(20, 150);
            lblPlayer1Score.Size = new Size(200, 30);
            lblPlayer1Score.ForeColor = Color.White;
            lblPlayer1Score.Text = $"{player1}'s Score: {scoreP1} ";
            pnlEndGame.Controls.Add(lblPlayer1Score);
            //
            Label lblPlayer2Time = new Label();
            lblPlayer2Time.Location = new Point(20, 200);
            lblPlayer2Time.Size = new Size(200, 30);
            lblPlayer2Time.ForeColor = Color.White;
            lblPlayer2Time.Text = $"{player2}'s Time: {time2}";
            pnlEndGame.Controls.Add(lblPlayer2Time);
            //
            //
            Label lblPlayer2Score = new Label();
            lblPlayer2Score.Location = new Point(20, 250);
            lblPlayer2Score.Size = new Size(200, 30);
            lblPlayer2Score.ForeColor = Color.White;
            lblPlayer2Score.Text = $"{player2}'s Score: {scoreP2}";
            pnlEndGame.Controls.Add(lblPlayer2Score);
            //
            Button btnPlayAgain = new Button();
            btnPlayAgain.Size = new Size(100, 50);
            btnPlayAgain.Location = new Point(20, 300);
            btnPlayAgain.Text = "Play Again";
            btnPlayAgain.BackColor = Color.White;
            pnlEndGame.Controls.Add(btnPlayAgain);
            btnPlayAgain.Click += new EventHandler(btnPlayAgain_Click);
            //
            Button btnDashboard = new Button();
            btnDashboard.Size = new Size(100, 50);
            btnDashboard.Location = new Point(200, 300);
            btnDashboard.Text = "Dashboard";
            btnDashboard.BackColor = Color.White;
            pnlEndGame.Controls.Add(btnDashboard);
            btnDashboard.Click += new EventHandler(btnDashboard_Click);
            //
            Button btnClose = new Button();
            btnClose.Size = new Size(100, 50);
            btnClose.Location = new Point(300, 300);
            btnClose.Text = "Close";
            btnClose.BackColor = Color.White;
            pnlEndGame.Controls.Add(btnClose);
            btnClose.Click += new EventHandler(btnClose_Click);
        }
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGame frmg = new frmGame(player1, player2, wordSet);
            frmg.ShowDialog();
            this.Close();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frmD = new frmDashboard(lblPlayer1.Text);
            frmD.ShowDialog();
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
