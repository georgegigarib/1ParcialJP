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
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// esta funcion convierte en hash el texto recibido
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
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //esta funcion devuelve un solo campo de un registro, esta recibe un string con el query deseado
        public static string soloFila(string query)
        {
            //se abre la conexion
            SqlConnection con = new SqlConnection();

            try
            {

                con = new SqlConnection("Data Source=GEORGEDESK\\SQLEXPRESS;Initial Catalog=PARCIALJP;Integrated Security=True");
                con.Open();
                //se crea el comando
                SqlCommand elcomando = con.CreateCommand();
                elcomando.CommandText = query;
                //se ejecuta el comando
                SqlDataReader reader = elcomando.ExecuteReader();
                // se lee el DataReader y se retorna el primer campo
                reader.Read();
                return reader[0].ToString();
            }
            catch(Exception er)
            {
                MessageBox.Show("no" + er);
            }
            finally
            {
                //cierre de conexion
                con.Close();
            }
            return null;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Esta funcion realiza un query sin retornar nada, recibe un SqlCommand con el query ya incrustado
        public static void DoQueryExecuterLimpio(SqlCommand query)
        {

            SqlConnection con = new SqlConnection();
            try
            {
                //se abre la conexion
                con = new SqlConnection("Data Source=GEORGEDESK\\SQLEXPRESS;Initial Catalog=PARCIALJP;Integrated Security=True");
                con.Open();
                //se agrega la conexion al comando
                query.Connection = con;
                //se ejecuta el comando
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
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Esta funcion realiza un query retornando un objeto DataTable, recibe un SqlCommand con el query ya incrustado
        public static DataTable DoQueryReceiverLimpio(SqlCommand query)
        {

            SqlConnection con = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                //se abre la conexion
                con = new SqlConnection("Data Source=GEORGEDESK\\SQLEXPRESS;Initial Catalog=PARCIALJP;Integrated Security=True");
                con.Open();
                //se agrega la conexion al comando
                query.Connection = con;
                //se agrega el comando seleccionado al objeto DataAdapter
                da.SelectCommand = query;
                //se llena el objeto Datatable
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
            //se retorna el objeto DataTable
            return dt;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Esta funcion es como un shortcut, se utiliza en los RefrescarGrid de los forms, para agilizar las cosas
        //Recibe un string con el nombre de la tabla y ejecuta un comando con la funcion DoQueryReceiverLimpio y retorna un objeto DataTable
        public static DataTable QueryTraerTabla(string tabla)
        {
            SqlCommand command = new SqlCommand($"SELECT * FROM {tabla}");
            DataTable dt = DoQueryReceiverLimpio(command);
            return dt;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*Esta funcion  llena de DisplayMembers y ValueMembers al combobox recibido
         * Esta funcion recibe 3 parametros
         * 1- el combobox que desea llenarse
         * 2- el array con los titulos que se mostraran
         * 3- el array con los valores que pasaran "por debajo"
         */
        public static void llenarCBX(ComboBox cbx, String[] ArrayTitulos, String[] ArrayValues)
        {
            //se crea un DataTable con dos columnas, IdCombo y NombreCombo
            DataTable dt = new DataTable();
            dt.Columns.Add("IdCombo");
            dt.Columns.Add("NombreCombo");

            //Se ejecuta un for con la cantidad de titulos que se envien en el array
            for (int i = 0; i < ArrayTitulos.Length; i++)
            {
                //se crea una nueva fila
                DataRow fila = dt.NewRow();
                //se agrega el idCombo y NombreCombo convertidos en string a dicha fila del DataTable
                fila["IdCombo"] = ArrayValues[i].ToString();
                fila["NombreCombo"] = ArrayTitulos[i].ToString();
                //por ultimo, se agrega la fila
                dt.Rows.Add(fila);
            }
            //para concluir se asigna el datasource al Combobox Recibido, y se asigna las columnas para los Values y los DisplayMembers
            cbx.DataSource = dt;
            cbx.DisplayMember = "NombreCombo";
            cbx.ValueMember = "IdCombo";
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////// <Exportar>////////////////////////////////////////////////////////////////////////
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
        ///////////////////////////////
        /*Esta funcion exporta en formato CSV (Excel) un  data grid recibido, esta funcion recibe 3 parametros:
         * 1-Un string con todos los titulos 
         * 2-El data grid view que se exportará
         * 3- el numero de columnas que tendra el archivo
         */
        public void Exportar(string header, DataGridView elgrid, int columnas)
        {
            //se asigna el separador de las comas
            writeFileHeader("sep=,");
            //se asignan los titulos
            writeFileHeader(header);

            string linea = "";

            //por cada fila en el DataGrid recibido....
            foreach (DataGridViewRow rows in elgrid.Rows)
            {
                //limpia la linea
                linea = "";
                //realiza este for, el cual parará en el numero de columnas  recibido
                for (int i = 0; i < columnas; i++)
                {
                    //linea será igual al VALOR que tenga la CELDA de la FILA que se esta contando (en el foreach (rows))
                    linea += rows.Cells[i].Value.ToString() + ",";
                }
                //por ultimo escribe la linea
                writeFileLine(linea);
            }
            //para concluir, crea el archivo y abrelo
            Process.Start(filePath);
        }
    }
    ////////////////////////////////////////////////////////////// <Exportar>////////////////////////////////////////////////////////////////////////

}
