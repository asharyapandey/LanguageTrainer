using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LanguageTrainer.BLL
{
    public class LoginBLL
    {
        DatabaseConnection dbConn = new DatabaseConnection();
        private string username, password;
        //setters
        public string _username { set => username = value; }
        public string _password { set => password = value; }
        //methods
        public DataTable CheckLogin()
        {
            try
            {
                string query = "select fName, lName from tblUsers where username ='" + username + 
                    "'and password='" + password + "';";
                DataTable dt = dbConn.retrieve(query);
                return dt;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
