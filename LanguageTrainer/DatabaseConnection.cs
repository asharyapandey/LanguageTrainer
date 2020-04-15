using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageTrainer
{
    class DatabaseConnection
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-M36C1JG;Initial Catalog=LanguageTrainer;Integrated Security=True");
        // SqlConnection cn = new SqlConnection(myconnString);
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public bool manipulate(string query)
        {//this method is for insert, update and delete. 
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public DataTable retrieve(string query)
        {//this method is for retriving the data 
            try
            {
                DataSet ds = new DataSet();
                da = new SqlDataAdapter(query, cn);
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
