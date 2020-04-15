using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace LanguageTrainer.BLL
{
    public class GameBLL
    {
        DatabaseConnection DBconn = new DatabaseConnection();
        private string engWord, translatedWord, p1Score, p2Score, p1Time, p2Time, player1;
        private string player2, player1ID, player2ID, totalTime, winner, gameID, wordSet;
        private string successRate1, successRate2;
        //setters
        public string _engWord { set => engWord = value; }
        public string _translatedWord { set => translatedWord = value; }
        public string _p1Score { set => p1Score = value; }
        public string _p2Score { set => p2Score = value; }
        public string _p1Time { set => p1Time = value; }
        public string _p2Time { set => p2Time = value; }
        public string _player1 { set => player1 = value; }
        public string _player2 { set => player2 = value; }
        public string _totalTime { set => totalTime = value; }
        public string _winner { set => winner = value; }
        public string _wordSet { set => wordSet = value; }
        public string _successRate1 { set => successRate1 = value; }
        public string _successRate2 { set => successRate2 = value; }

        public DataTable RetriveWords()
        {
            try
            {
                string query = "select TOP 26 word,translation from tblWords where wordSet='" +
                wordSet + "'";
                DataTable dt = DBconn.retrieve(query);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            
        }
        public DataTable CheckWord()
        {
            try
            {
                string query = "select wordID from tblWords where word='" + engWord +
                "' and translation=N'" + translatedWord + "';";
                DataTable dt = DBconn.retrieve(query);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            
        }
        public void RetrivePlayer1ID()
        {
            try
            {
                string query = "select userID from tblUsers where fName='" + player1 + "'";
                DataTable dt = DBconn.retrieve(query);
                player1ID = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }  
        }
        public void RetrivePlayer2ID()
        {
            try
            {
                string query = "select userID from tblUsers where fName='" + player2 + "'";
                DataTable dt = DBconn.retrieve(query);
                player2ID = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }  
        }
        public void RetriveGameID()
        {
            try
            {
                string query = "select gameID from tblGame order by gameID desc;";
                DataTable dt = DBconn.retrieve(query);
                gameID = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void InsertStat()
        {
            RetrivePlayer1ID();
            RetrivePlayer2ID();
            RetriveGameID();
            string time = "00:" + p1Time, time2 = "00:" + p2Time;
            try
            {
                string query = "insert into tblPlayerStats (score,sucessrate,timeRequired,playerID, gameID) values(" +
                    p1Score + "," +
                    successRate1 + ",'" +
                    time + "'," +
                    player1ID + "," +
                    gameID + ")";
                DBconn.manipulate(query);
                query = "insert into tblPlayerStats (score,sucessrate,timeRequired,playerID, gameID) values(" +
                    p2Score + "," +
                    successRate2 + ",'" +
                    time2 + "'," +
                    player2ID + "," +
                    gameID + ")";
                DBconn.manipulate(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void InsertGameInfo()
        {
            string time = "00:" + p1Time;
            try
            {
                string query = "insert into tblGame(player1, player2, gameDate, gameTime, playedTime, winner) values('" +
                    player1 + "','" +
                    player2 + "','" +
                    DateTime.Today.ToShortDateString() + "','" +
                    DateTime.Today.ToShortTimeString() + "','" +
                    totalTime + "','" +
                    winner + "');";

                DBconn.manipulate(query);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public DataTable RetriveStat1()
        {
            try
            {
                string query = "select score,timeRequired from tblPlayerStats where playerID=" + player1ID +
                    " order by gameID desc;";
                DataTable dt = DBconn.retrieve(query);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public DataTable RetriveStat2()
        {
            try
            {
                string query = "select score,timeRequired from tblPlayerStats where playerID=" + player2ID +
                    " order by gameID desc;";
                DataTable dt = DBconn.retrieve(query);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public DataTable RetriveMax()
        {
            try
            {
                string query = "select max(score) from tblPlayerStats;";
                DataTable dt = DBconn.retrieve(query);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public DataTable RetriveGameInfo()
        {
            try
            {
                string query = "select player1, player2, winner from tblGame order by gameID desc;";
                DataTable dt = DBconn.retrieve(query);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
