using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;

namespace _1ParcialJP
{
   public class Helper
    {
        
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
        public static string soloFila(string query)
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
                return reader[0].ToString();
            }
            catch(Exception er)
            {
                MessageBox.Show("no" + er);
            }
            finally
            {

                con.Close();
            }
            return "U";
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
        public static DataTable QueryTraerTabla(string tabla)
        {
            SqlCommand command = new SqlCommand($"SELECT * FROM {tabla}");
            DataTable dt = DoQueryReceiverLimpio(command);
            return dt;
        }
        public static void llenarCBX(ComboBox cbx, String[] ArrayTitulos, String[] ArrayValues)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("IdCombo");
            dt.Columns.Add("NombreCombo");
            for (int i = 0; i < ArrayTitulos.Length; i++)
            {
                DataRow fila = dt.NewRow();
                fila["IdCombo"] = ArrayValues[i].ToString();
                fila["NombreCombo"] = ArrayTitulos[i].ToString();
                dt.Rows.Add(fila);
            }
            cbx.DataSource = dt;
            cbx.DisplayMember = "NombreCombo";
            cbx.ValueMember = "IdCombo";
        }

        //funciones para exportar
        string filePath = @"C:\prueba\marca.csv";
        private void writeFileLine(string pLine)
        {
            using (System.IO.StreamWriter w = File.AppendText(filePath))
            {
                w.WriteLine(pLine);
            }
        }
        private void writeFileHeader(string pLine)
        {
            using (System.IO.StreamWriter w = File.CreateText(filePath))
            {
                w.WriteLine(pLine);
            }
        }
        public void Exportar(string header, DataGridView elgrid, int columnas)
        {
            writeFileHeader(header);

            string linea = "";
            foreach (DataGridViewRow rows in elgrid.Rows)
            {
                linea = "";
                for (int i = 0; i < columnas; i++)
                {
                    linea += rows.Cells[i].Value.ToString() + ",";
                }
                writeFileLine(linea);
            }
            Process.Start(filePath);
        }
    }
}
