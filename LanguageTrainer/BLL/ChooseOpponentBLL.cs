using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageTrainer.BLL
{
    public class ChooseOpponentBLL
    {
        DatabaseConnection dbConn = new DatabaseConnection();
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
    }
}
