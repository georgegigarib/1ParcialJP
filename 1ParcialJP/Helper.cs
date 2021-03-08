using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace _1ParcialJP
{
   public class Helper
    {
        
        public static SqlDataAdapter DoQueryReceiver(string query)
        {

            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                con = new SqlConnection("Data Source=GEORGEDESK\\SQLEXPRESS;Initial Catalog=PARCIALJP;Integrated Security=True");
                con.Open();
                //query
                da = new SqlDataAdapter(query, con);
            }

            catch (Exception er)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + er);
            }

            finally
            {
                con.Close();
            }
            return da;
        }

        public static void DoQueryExecuter(string query)
        {

            SqlConnection con = new SqlConnection();
            try
            {
                con = new SqlConnection("Data Source=GEORGEDESK\\SQLEXPRESS;Initial Catalog=PARCIALJP;Integrated Security=True");
                con.Open();
                //query

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

            }

            catch (Exception er)
            {

                MessageBox.Show("Error al conectar con la base de datos: " + er);

            }
            finally
            {
                con.Close();
            }
            


        }
        

    }
}
