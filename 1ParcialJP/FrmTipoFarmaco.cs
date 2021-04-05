using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace _1ParcialJP
{
    public partial class FrmTipoFarmaco : Form
    {
        public FrmTipoFarmaco()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FrmTipoFarmaco_Load(object sender, EventArgs e)
        {
            /* La funcion *llenarCBX* se encarga de llenar los comboBoxs que se encuentran en el diseño los cuales requieren opciones fuera de la base de datos,
             * hay que enviarle el NOMBRE del ComboBox, El de los TITULOS (el que se mostrara, como una mascara) y el ARRAY de los VALUES de esos titulos, 
             * como si fuesen un ID)*/

            String[] ArrayTitulos = { "Disponible", "No Disponible", "Descontinuado", "En Prueba" };
            String[] ArrayValues = { "DISPONIBLE", "NO DISPNIBLE", "DESCONTINUADO", "EN PRUEBA" };
            Helper.llenarCBX(eSTADOComboBox, ArrayTitulos, ArrayValues);

            String[] ArrayTitulos1 = { "ID", "Descripcion", "Estado" };
            String[] ArrayValues1 = { "ID_TF", "DESCRIPCION", "ESTADO" };
            Helper.llenarCBX(selectsearch, ArrayTitulos1, ArrayValues1);


            //Seteando el comboBox en la primera posicion
            selectsearch.SelectedIndex = 0;

            //Se quita el control box del windows form, Botones de minimizar, maximizar y cerrar
            this.ControlBox = false;

            refrescargrid();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*Esta parte refresca el grid, el metodo QueryTraerTabla recibe un string con el nombre de la tabla deseada y utiliza el metodo DoQueryReceiverLimpio
          para realizar su funcion.  
         */
        public void refrescargrid()
        {
            try
            {
                tIPO_FARMACODataGridView.DataSource = Helper.QueryTraerTabla("TIPO_FARMACO");
                tIPO_FARMACODataGridView.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener registros de la base de datos: " + er);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* Al momento de agregar un registro llama a otro Form y utiliza el metodo abrirForm para esto, ubicado en el form FrmMenu, el cual resive el form deseado.
         */
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmATF fmATF = new FrmATF();
            FrmMenu menu = new FrmMenu();
            menu.abrirForm(fmATF);
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*
         * Este apartado realiza un update de registro.
         * 1- Se crea un string el cual tendra el query con distintos @parametros que seran cambiados mas adelante
         * 2- se crea un SqlCommand con el string creado
         * 3- se reemplazan los parametros con los textos de los textbox.
         * 4- se envia el comando al metodo DoQueryExecuterLimpio para ser ejecutado
         * 5- se refresca el grid para ver el registro nuevo
         */
        private void btnGguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"UPDATE TIPO_FARMACO SET ESTADO = @estado, DESCRIPCION = @descripcion WHERE ID_TF = @id ";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@descripcion", dESCRIPCIONTextBox.Text);
                command.Parameters.AddWithValue("@estado", eSTADOComboBox.SelectedValue.ToString());
                command.Parameters.AddWithValue("@id", iD_TFTextBox.Text);
                Helper.DoQueryExecuterLimpio(command);
                MessageBox.Show("Registro Guardado con exito");
                refrescargrid();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Eliminar registro: " + er);
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*
         * Este apartado elimina un registro, de la misma forma que el apartado de guardar.
         * 1- Se crea un string el cual tendra el query con el parametro @id que sera cambiado mas adelante
         * 2- se crea un SqlCommand con el string creado
         * 3- se reemplazan los parametros con los textos de los textbox.
         * 4- se envia el comando al metodo DoQueryExecuterLimpio para ser ejecutado
         * 5- se refresca el grid para ver el registro nuevo
         */

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM TIPO_FARMACO WHERE ID_TF = @id ";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@id", iD_TFTextBox.Text);
                Helper.DoQueryExecuterLimpio(command);
                MessageBox.Show("Registro Eliminado con exito");
                refrescargrid();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Eliminar registro: " + er);
            }

        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*
         * Este apartado busca registros con parametros escritos en el txtsearch, y sigue los siguientes pasos
         * 1- Se crea un string el cual tendra el query con el parametro @search que sera cambiado mas adelante
         * 2- se crea un SqlCommand con el string creado
         * 3- se reemplazan los parametros con los textos de los textbox.
         * 4- se le da un nuevo valor al DataSource del DataGridView enviando el comando al metodo DoQueryReceiverLimpio para ser ejecutado y recivir el nuevo DataTable
         * 5- por ultimo se da refresh al DataGridView
         * 
         * ******* en le caso del txtfecha se cambia el query a >= para buscar las fechas del dia especificado en adelante 
         */
        private void button2_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM TIPO_FARMACO WHERE {selectsearch.SelectedValue.ToString()} LIKE @search";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@search", "%" + txtsearch.Text + "%");
            tIPO_FARMACODataGridView.DataSource = Helper.DoQueryReceiverLimpio(command);
            tIPO_FARMACODataGridView.Refresh();

        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* Esta funcion exporta los datos que estan en el grid al momento de presionarlo, la funcion recibe 3 parametros:
         * 1- Un string con todos los campos 
         * 2- El DataGridView del form
         * 3- La cantidad de campos enviados
        */
        private void btnExportar_Click(object sender, EventArgs e)
        {
            Helper help = new Helper();
            help.Exportar("ID, DESCRIPCION, ESTADO", tIPO_FARMACODataGridView, 3);
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*
         * Este apartado refleja el registro seleccionado en el DataGridView y lo muestra en los textbox del form.
         * El if (e.RowIndex >= 0)es para evitar que, al seleccionar los titulos de las tablas, no explote el programa
         *          lo que dice es, si el registro seleccionado es mayor que cero, entonces si se muestran los datos en los textbox
         */
        private void tIPO_FARMACODataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                iD_TFTextBox.Text = tIPO_FARMACODataGridView[0, e.RowIndex].Value.ToString();
                dESCRIPCIONTextBox.Text = tIPO_FARMACODataGridView[1, e.RowIndex].Value.ToString();
                eSTADOComboBox.Text = tIPO_FARMACODataGridView[2, e.RowIndex].Value.ToString();
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //cierra el form
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
