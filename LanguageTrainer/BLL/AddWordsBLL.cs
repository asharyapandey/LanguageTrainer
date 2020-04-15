using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace LanguageTrainer.BLL
{
    public class AddWordsBLL
    {
        DatabaseConnection dbConn = new DatabaseConnection();
        private string wordID, word, translation, wordSet;
        //setterrs
        public string _wordID { set => wordID = value; }  
        public string _word { set => word = value; }
        public string _translation { set => translation = value; }
        public string _wordSet { set => wordSet = value; }
        //methods
        public bool InsertWords()
        {
            try
            {
                string query = "insert into tblWords(word,translation,wordSet) values('" +
                    word + "',N'" +
                    translation + "','" +
                    wordSet + "');";
                dbConn.manipulate(query);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public void UpdateWord()
        {
            try
            {
                string query = "update tblWords set word='" + word +
                    "',translation=N'" + translation + "' where wordID=" + wordID;
                dbConn.manipulate(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void DeleteWord()
        {
            try
            {
                string query = "delete from tblWords where wordID=" + wordID;
                dbConn.manipulate(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public DataTable RetriveWord()
        {
            try
            {
                string query = "select * from tblWords order by wordID desc;";
                DataTable dt = dbConn.retrieve(query);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public DataTable RetriveWord(int wordId)
        {
            try
            {
                string query = "select * from tblWords where wordID=" + wordId;
                DataTable dt = dbConn.retrieve(query);
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
