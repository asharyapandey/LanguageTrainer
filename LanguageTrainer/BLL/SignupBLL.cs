using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace LanguageTrainer.BLL
{
    public class SignupBLL
    {
        DatabaseConnection dbConn = new DatabaseConnection();
        private string username, password, fName, lName, userID;
        //setterrs
        public string _username { set => username = value; }
        public string _password { set => password = value; }
        public string _fName { set => fName = value; }
        public string _lName { set => lName = value; }
        public string _userID { set => userID = value; }
        //methods
        public bool InsertUsers()
        {
            try
            {
                string query = "insert into tblUsers(username,password,fName,lName) values('" +
                    username + "','" +
                    password + "','" +
                    fName + "','" +
                    lName + "');";
                dbConn.manipulate(query);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public void UpdateUsers()
        {
            try
            {
                string query = "update tblUsers set username='" + username +
                    "',fName='" + fName +
                    "',lName='" + lName + "' where userID=" + userID;
                dbConn.manipulate(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void DeleteUsers()
        {
            try
            {
                string query = "delete from tblUsers where userID=" + userID;
                dbConn.manipulate(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public DataTable RetriveUsers()
        {
            try
            {
                string query = "select * from tblUsers order by userID desc;";
                DataTable dt = dbConn.retrieve(query);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public DataTable RetriveUsers( int userId)
        {
            try
            {
                string query = "select * from tblUsers where userId="+ userId;
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
