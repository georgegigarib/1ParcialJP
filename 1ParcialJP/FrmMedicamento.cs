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
    public partial class FrmMedicamento : Form
    {
        public FrmMedicamento()
        {
            InitializeComponent();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FrmMedicamento_Load(object sender, EventArgs e)
        {

            /* La funcion *llenarCBX* se encarga de llenar los comboBoxs que se encuentran en el diseño los cuales requieren opciones fuera de la base de datos,
             * hay que enviarle el NOMBRE del ComboBox, El de los TITULOS (el que se mostrara, como una mascara) y el ARRAY de los VALUES de esos titulos, 
             * como si fuesen un ID)*/

            String[] ArrayTitulos = { "Disponible", "Descontinuado", "No Disponible" };
            String[] ArrayValues = { "DISPONIBLE", "DESCONTINUADO", "NO DISPONIBLE" };
            Helper.llenarCBX(eSTADOComboBox, ArrayTitulos, ArrayValues);

            String[] ArrayTitulos1 = { "Descripcion", "Tipo de Farmaco", "Marca", "Ubicacion", "Dosis", "Estado", "Cantidad" };
            String[] ArrayValues1 = { "DESCRIPCION", "ID_TF", "ID_MARCA", "ID_UBBICACION", "DOSIS", "ESTADO", "CANTIDAD" };
            Helper.llenarCBX(selectsearch, ArrayTitulos1, ArrayValues1);

            /*Esta seccion se encarga de llenar los COMOBOX con registros de la base de datos,
              * 1- Se limpian los comobox 
              * 2- Se crea un objeto Datatable y uno SqlCommand
              * 3- se llena el objeto datatable con el Datatable que trae la funcion DoQueryReceiverLimpio cuando se le envia un SqlCommand con su respectivo QUERY
              * 4- Se hace un FOREACH para recorrer cada fila y llenar el combobox con los ITEMS
              * 5- se limpia el objeto Datatable para un proximo uso
             */

            try
            {
                //limpieza de CBX
                CBXUbicacion.Items.Clear();
                CBXMarca.Items.Clear();
                CBXtipoFarmaco.Items.Clear();

                DataTable dt = new DataTable();
                //COMBOBOX ubicacion
                dt = Helper.DoQueryReceiverLimpio(new SqlCommand("SELECT ID_UBICACION FROM UBICACION"));
                foreach (DataRow dr in dt.Rows)
                {
                    CBXUbicacion.Items.Add(dr["ID_UBICACION"].ToString());
                }

                //COMBOBOX marca
                dt.Clear();
                dt = Helper.DoQueryReceiverLimpio(new SqlCommand("SELECT DESCRIPCION FROM MARCA"));
                foreach (DataRow dr in dt.Rows)
                {
                    CBXMarca.Items.Add(dr["DESCRIPCION"].ToString());
                }

                //COMBOBOX tipo farmaco
                dt = Helper.DoQueryReceiverLimpio(new SqlCommand("SELECT DESCRIPCION FROM TIPO_FARMACO"));
                foreach (DataRow dr in dt.Rows)
                {
                    CBXtipoFarmaco.Items.Add(dr["DESCRIPCION"].ToString());
                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener las opciones" + er);
            }

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
            selectsearch.SelectedIndex = 0;
            try
            {
                mEDICAMENTODataGridView.DataSource = Helper.QueryTraerTabla("MEDICAMENTO");
                mEDICAMENTODataGridView.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener registros de la base de datos: " + er);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /* Al momento de agregar un registro llama a otro Form y utiliza el metodo abrirForm para esto, ubicado en el form FrmMenu, el cual resive el form deseado.
         */
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAMedicamento frmAM = new FrmAMedicamento();
            FrmMenu fmmenu = new FrmMenu();
            fmmenu.abrirForm(frmAM);
            this.Close();
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
                string sql = $"UPDATE MEDICAMENTO SET DESCRIPCION = @descripcion, ID_TF = @tipoF, " +
                    $"ESTADO= @estado, ID_UBBICACION = @ubicacion, DOSIS= @dosis, ID_MARCA = @marca, CANTIDAD = @cantidad " +
                    $"WHERE ID_MEDICAMENTO = @id";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@descripcion", dESCRIPCIONTextBox.Text);
                command.Parameters.AddWithValue("@tipoF", CBXtipoFarmaco.Text);
                command.Parameters.AddWithValue("@marca", CBXMarca.Text);
                command.Parameters.AddWithValue("@ubicacion", CBXUbicacion.Text);
                command.Parameters.AddWithValue("@dosis", dOSISTextBox.Text);
                command.Parameters.AddWithValue("@estado", eSTADOComboBox.SelectedValue.ToString());
                command.Parameters.AddWithValue("@cantidad", txtcantidad.Value);
                command.Parameters.AddWithValue("@id", iD_MEDICAMENTOTextBox.Text);
                Helper.DoQueryExecuterLimpio(command);
                MessageBox.Show("Registro guardado con exito");
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
                string sql = $"DELETE FROM MEDICAMENTO WHERE ID_MEDICAMENTO = '{iD_MEDICAMENTOTextBox.Text}'";
                SqlCommand command = new SqlCommand(sql);
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
            string sql;
            SqlCommand command;
            /*este switch comprueba que la opcion elegida sea la de cantidad y comprueba que se escriban numeros al momento
            * de buscar*/
            switch (selectsearch.SelectedIndex)
            {
                case 6:
                    if (int.TryParse(txtsearch.Text, out int result))
                    {
                        sql = $"SELECT * FROM MEDICAMENTO WHERE {selectsearch.SelectedValue.ToString()} <= @search";
                        command = new SqlCommand(sql);
                        command.Parameters.AddWithValue("@search", Int32.Parse(txtsearch.Text));
                        mEDICAMENTODataGridView.DataSource = Helper.DoQueryReceiverLimpio(command);
                        mEDICAMENTODataGridView.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Asegurese de solo escribir numeros.");
                    }
                    break;
                default:
                    //en caso de que no sea elegida la opcion de cantidad, hace esto...
                    sql = $"SELECT * FROM MEDICAMENTO WHERE {selectsearch.SelectedValue.ToString()} LIKE @search";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@search", "%" + txtsearch.Text + "%");
                    mEDICAMENTODataGridView.DataSource = Helper.DoQueryReceiverLimpio(command);
                    mEDICAMENTODataGridView.Refresh();
                    break;
            }
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
            help.Exportar("ID, DESCRIPCION, TIPO DE FARMACO, MARCA, UBICACION, DOSIS, ESTADO, CANTIDAD", mEDICAMENTODataGridView, 8);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*
         * Este apartado refleja el registro seleccionado en el DataGridView y lo muestra en los textbox del form.
         * El if (e.RowIndex >= 0)es para evitar que, al seleccionar los titulos de las tablas, no explote el programa
         *          lo que dice es, si el registro seleccionado es mayor que cero, entonces si se muestran los datos en los textbox
         */
        private void mEDICAMENTODataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                iD_MEDICAMENTOTextBox.Text = mEDICAMENTODataGridView[0, e.RowIndex].Value.ToString();
                dESCRIPCIONTextBox.Text = mEDICAMENTODataGridView[1, e.RowIndex].Value.ToString();
                CBXtipoFarmaco.Text = mEDICAMENTODataGridView[2, e.RowIndex].Value.ToString();
                CBXMarca.Text = mEDICAMENTODataGridView[3, e.RowIndex].Value.ToString();
                CBXUbicacion.Text = mEDICAMENTODataGridView[4, e.RowIndex].Value.ToString();
                dOSISTextBox.Text = mEDICAMENTODataGridView[5, e.RowIndex].Value.ToString();
                eSTADOComboBox.Text = mEDICAMENTODataGridView[6, e.RowIndex].Value.ToString();
                txtcantidad.Text = mEDICAMENTODataGridView[7, e.RowIndex].Value.ToString();
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
