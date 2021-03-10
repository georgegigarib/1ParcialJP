using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace _1ParcialJP
{
   public class Helper
    {
        
        public static DataTable DoQueryReceiver(string query)
        {

            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                con = new SqlConnection("Data Source=GEORGEDESK\\SQLEXPRESS;Initial Catalog=PARCIALJP;Integrated Security=True");
                con.Open();
                //query
                da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }

            catch (Exception er)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + er);
            }

            finally
            {
                con.Close();
            }
            return dt;
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

        public static string GetSha3Hash(string texto)
        {
            try
            {
                using (SHA512 sha512Hash = SHA512.Create())
                {
                    byte[] sourceBytes = Encoding.UTF8.GetBytes(texto);
                    byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
                    string hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                    return hash;
                }
            }
            catch
            {
                return "";
            }
        }
        public static void soloFila(string query)
        {

            SqlConnection con = new SqlConnection();
            con = new SqlConnection("Data Source=GEORGEDESK\\SQLEXPRESS;Initial Catalog=PARCIALJP;Integrated Security=True");
            con.Open();
            try
            {
                
                SqlCommand elcomando = con.CreateCommand();
                elcomando.CommandText = query;
                SqlDataReader reader = elcomando.ExecuteReader();
                reader.Read();
                //seteando variable en session
                Program.tipo = reader[0].ToString();
            }
            catch(Exception er)
            {
                MessageBox.Show("no" + er);
            }
            finally
            {
                con.Close();
            }

           


        }
        public static void DoQueryExecuterLimpio(SqlCommand query)
        {

            SqlConnection con = new SqlConnection();
            try
            {
                con = new SqlConnection("Data Source=GEORGEDESK\\SQLEXPRESS;Initial Catalog=PARCIALJP;Integrated Security=True");
                con.Open();
                //query

                query.Connection = con;
                query.ExecuteNonQuery();

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
        public static DataTable DoQueryReceiverLimpio(SqlCommand query)
        {

            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                con = new SqlConnection("Data Source=GEORGEDESK\\SQLEXPRESS;Initial Catalog=PARCIALJP;Integrated Security=True");
                con.Open();
                query.Connection = con;
                //query
                da.SelectCommand = query;
                da.Fill(dt);
            }

            catch (Exception er)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + er);
            }

            finally
            {
                con.Close();
            }
            return dt;
        }

    }
}
