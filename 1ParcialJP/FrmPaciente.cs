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
    public partial class FrmPaciente : Form
    {
        public FrmPaciente()
        {
            InitializeComponent();
        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {

            /* La funcion *llenarCBX* se encarga de llenar los comboBoxs que se encuentran en el diseño los cuales requieren opciones fuera de la base de datos,
            * hay que enviarle el NOMBRE del ComboBox, El de los TITULOS (el que se mostrara, como una mascara) y el ARRAY de los VALUES de esos titulos, 
            * como si fuesen un ID)*/
            String[] ArrayTitulos = { "Saludable", "Estable", "Grave" };
            String[] ArrayValues = { "SALUDABLE", "ESTABLE", "GRAVE" };
            Helper.llenarCBX(eSTADOComboBox, ArrayTitulos, ArrayValues);

            String[] ArrayTitulos1 = { "Activo", "Inactivo" };
            String[] ArrayValues1 = { "ACTIVO", "INACTIVO" };
            Helper.llenarCBX(tIPO_PACIENTEComboBox, ArrayTitulos1, ArrayValues1);

            String[] ArrayTitulos2 = { "Nombre", "Cedula", "Numero de Carnet", "Tipo de Paciente", "Estado" };
            String[] ArrayValues2 = { "NOMBRE", "CEDULA", "NUM_CARNET", "TIPO_PACIENTE", "ESTADO" };
            Helper.llenarCBX(selectsearch, ArrayTitulos2, ArrayValues2);

            //Seteando el comboBox en la primera posicion
            selectsearch.SelectedIndex = 0;

            //Se quita el control box del windows form, Botones de minimizar, maximizar y cerrar
            this.ControlBox = false;

            refrescargrid();

        }        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*Esta parte refresca el grid, el metodo QueryTraerTabla recibe un string con el nombre de la tabla deseada y utiliza el metodo DoQueryReceiverLimpio
          para realizar su funcion.  
         */
        public void refrescargrid()
        {
            try
            {
                pACIENTEDataGridView.DataSource = Helper.QueryTraerTabla("PACIENTE");
                pACIENTEDataGridView.Refresh();
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
            FrmAPaciente frmAPaciente = new FrmAPaciente();
            FrmMenu menu = new FrmMenu();
            menu.abrirForm(frmAPaciente);
        }

        private void btnGguardar_Click(object sender, EventArgs e)
        {
            //en esta parte se valida la cedula primero, se envia un string al a funcion validaCedula
            // y esta devuelve un booleano, si es verdadero, continua con la funcion
            string cedula = cEDULATextBox.Text;
            if (ValidacionCedula.validaCedula(cedula))
            {
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                /*
                 * Este apartado realiza un update de registro.
                 * 1- Se crea un string el cual tendra el query con distintos @parametros que seran cambiados mas adelante
                 * 2- se crea un SqlCommand con el string creado
                 * 3- se reemplazan los parametros con los textos de los textbox.
                 * 4- se envia el comando al metodo DoQueryExecuterLimpio para ser ejecutado
                 * 5- se refresca el grid para ver el registro nuevo
                 */
                try
                {
                    string sql = $"UPDATE PACIENTE SET NOMBRE = @nombre , CEDULA = @cedula , " +
                        $"ESTADO = @estado , NUM_CARNET = @carnet , TIPO_PACIENTE= @tipo " +
                        $"WHERE ID_PACIENTE = @id ";
                    SqlCommand command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@nombre", nOMBRETextBox.Text);
                    command.Parameters.AddWithValue("@cedula", cEDULATextBox.Text);
                    command.Parameters.AddWithValue("@carnet", nUM_CARNETTextBox.Text);
                    command.Parameters.AddWithValue("@tipo", tIPO_PACIENTEComboBox.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@estado", eSTADOComboBox.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@id", iD_PACIENTETextBox.Text);
                    Helper.DoQueryExecuterLimpio(command);
                    MessageBox.Show("Registro Guardado con exito");
                    refrescargrid();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error al Eliminar registro: " + er);
                }
            }
            else
            {
                MessageBox.Show("Cedula Incorrecta");
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
                string sql = $"DELETE FROM PACIENTE WHERE ID_PACIENTE = @id";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@id", iD_PACIENTETextBox.Text);
                Helper.DoQueryExecuterLimpio(command);
                MessageBox.Show("Registro Eliminado con exito");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Eliminar registro: " + er);
            }
            finally
            {
                refrescargrid();
            }
        }

        private void pACIENTEDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                iD_PACIENTETextBox.Text = pACIENTEDataGridView[0, e.RowIndex].Value.ToString();
                nOMBRETextBox.Text = pACIENTEDataGridView[1, e.RowIndex].Value.ToString();
                cEDULATextBox.Text = pACIENTEDataGridView[2, e.RowIndex].Value.ToString();
                nUM_CARNETTextBox.Text = pACIENTEDataGridView[3, e.RowIndex].Value.ToString();
                tIPO_PACIENTEComboBox.Text = pACIENTEDataGridView[4, e.RowIndex].Value.ToString();
                eSTADOComboBox.Text = pACIENTEDataGridView[5, e.RowIndex].Value.ToString();
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
         */
        private void button2_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM PACIENTE WHERE {selectsearch.SelectedValue.ToString()} LIKE @search";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@search", "%" + txtsearch.Text + "%");
            pACIENTEDataGridView.DataSource = Helper.DoQueryReceiverLimpio(command);
            pACIENTEDataGridView.Refresh();
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
            help.Exportar("ID, NOMBRE, CEDULA, CARNET, TIPO DE PACIENTE, ESTADO", pACIENTEDataGridView, 6);
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //cierra el form
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
