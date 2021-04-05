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
    public partial class FrmVisitas : Form
    {
        public FrmVisitas()
        {
            InitializeComponent();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FrmVisitas_Load(object sender, EventArgs e)
        {
            /* La funcion *llenarCBX* se encarga de llenar los comboBoxs que se encuentran en el diseño los cuales requieren opciones fuera de la base de datos,
             * hay que enviarle el NOMBRE del ComboBox, El de los TITULOS (el que se mostrara, como una mascara) y el ARRAY de los VALUES de esos titulos, 
             * como si fuesen un ID)*/
            String[] ArrayTitulos = { "ID", "Nombre del Medico", "Nombre del Paciente", "Sintomas", "Recomendaciones", "Medicamentos", "Estado", "Fecha" };
            String[] ArrayValues = { "ID_VISITA", "NOMBRE_MEDICO", "NOMBRE_PACIENTE", "SINTOMAS", "RECOMENDACIONES", "MEDICAMENTOS", "ESTADO", "FECHA" };
            Helper.llenarCBX(selectsearch, ArrayTitulos, ArrayValues);

            /*Esta seccion se encarga de llenar los COMOBOX con registros de la base de datos,
             * 1- Se limpian los comobox 
             * 2- Se crea un objeto Datatable y uno SqlCommand
             * 3- se llena el objeto datatable con el Datatable que trae la funcion DoQueryReceiverLimpio cuando se le envia un SqlCommand con su respectivo QUERY
             * 4- Se hace un FOREACH para recorrer cada fila y llenar el combobox con los ITEMS
             * 5- se limpia el objeto Datatable para un proximo uso
            */

            try
            {
                //COMBOOX nombre medico
                nOMBRE_MEDICOComboBox.Items.Clear();
                DataTable dt = new DataTable();
                dt = Helper.DoQueryReceiverLimpio(new SqlCommand($"SELECT NOMBRE FROM MEDICO"));
                foreach (DataRow dr in dt.Rows)
                {
                    nOMBRE_MEDICOComboBox.Items.Add(dr["NOMBRE"].ToString());
                }
                dt.Clear();

                //COMBOBOX nombre paciente
                CBXPACIENTE.Items.Clear();
                dt = Helper.DoQueryReceiverLimpio(new SqlCommand($"SELECT NOMBRE FROM PACIENTE"));
                foreach (DataRow dr in dt.Rows)
                {
                    CBXPACIENTE.Items.Add(dr["NOMBRE"].ToString());
                }
                dt.Clear();

                //COMBOBOX descripcion medicamento
                dt = Helper.DoQueryReceiverLimpio(new SqlCommand($"SELECT DESCRIPCION FROM MEDICAMENTO"));
                foreach (DataRow dr in dt.Rows)
                {
                    cbxMedicamento.Items.Add(dr["DESCRIPCION"].ToString());
                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener las opciones" + er);
            }
            //Al final de todo se refresca el grid
            finally
            {
                refrescargrid();
            }

            //Seteando el comboBox en la primera posicion
            selectsearch.SelectedIndex = 0;

            //Se quita el control box del windows form, Botones de minimizar, maximizar y cerrar
            this.ControlBox = false;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*Esta parte refresca el grid, el metodo QueryTraerTabla recibe un string con el nombre de la tabla deseada y utiliza el metodo DoQueryReceiverLimpio
          para realizar su funcion.  
         */
        public void refrescargrid()
        {
            try
            {
                vISITADataGridView.DataSource = Helper.QueryTraerTabla("VISITA");
                vISITADataGridView.Refresh();
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
            FrmAVisita fmAVisita = new FrmAVisita();
            FrmMenu menu = new FrmMenu();
            menu.abrirForm(fmAVisita);
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
                string sql = $"UPDATE VISITA SET NOMBRE_MEDICO = @nombremedico, NOMBRE_PACIENTE = @nombrepaciente, " +
                    $"FECHA= @fecha, HORA = @hora, SINTOMAS= @sintomas," +
                    $" MEDICAMENTOS= @medicamentos, CANTIDAD_VISITA= @cantidad, ESTADO= @estado, RECOMENDACIONES= @recomendaciones" +
                    $"WHERE ID_VISITA = @id";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@nombrebedico", nOMBRE_MEDICOComboBox.Text);
                command.Parameters.AddWithValue("@nombrepaciente", CBXPACIENTE.Text);
                command.Parameters.AddWithValue("@fecha", fECHADateTimePicker.Text);
                command.Parameters.AddWithValue("@hora", hORADateTimePicker.Text);
                command.Parameters.AddWithValue("@sintomas", sINTOMASTextBox.Text);
                command.Parameters.AddWithValue("@medicamentos", cbxMedicamento.Text);
                command.Parameters.AddWithValue("@cantidad", txtcantidadVisita.Value);
                command.Parameters.AddWithValue("@estado", eSTADOTextBox.Text);
                command.Parameters.AddWithValue("@recomendaciones", rECOMENDACIONESTextBox.Text);
                command.Parameters.AddWithValue("@id", iD_VISITATextBox.Text);
                Helper.DoQueryExecuterLimpio(command);
                MessageBox.Show("Registro Guardado con exito");
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
                string sql = $"DELETE FROM VISITA WHERE ID_VISITA = @id ";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@id", iD_VISITATextBox.Text);
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
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*
         * Este apartado se basa en lo estetico, cuando la opcion 8 es elegida (fecha) se oculta el textbox grande y el datepicker sale a la luz 
         * con un cambio de posicion. El boton de busqueda tambien cambia de posicion
         */
        private void selectsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsearch.Clear();
            if (selectsearch.SelectedIndex == 7)
            {
                txtfecha.Visible = true;
                txtfecha.Location = new Point(268, 183);
                btnsearch.Location = new Point(415, 161);
                txtsearch.Visible = false;
            }
            else
            {
                txtfecha.Visible = false;
                btnsearch.Location = new Point(695, 160);
                txtsearch.Visible = true;
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
        /* ******* en le caso del txtfecha se cambia el query a >= para buscar las fechas del dia especificado en adelante 
        */
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string sql;
            SqlCommand command = new SqlCommand();
            switch (selectsearch.SelectedIndex)
            {
                case 7:
                    sql = $"SELECT * FROM VISITA WHERE {selectsearch.SelectedValue.ToString()} >= @search";
                    command.Parameters.AddWithValue("@search", txtfecha.Text);
                    MessageBox.Show(txtfecha.Text);
                    break;
                default:
                    sql = $"SELECT * FROM VISITA WHERE {selectsearch.SelectedValue.ToString()} LIKE @search";
                    command.Parameters.AddWithValue("@search", "%" + txtsearch.Text + "%");
                    break;
            }
            command.CommandText = sql;
            vISITADataGridView.DataSource = Helper.DoQueryReceiverLimpio(command);
            vISITADataGridView.Refresh();
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
            help.Exportar("ID, NOMBRE PACIENTE, NOMBRE MEDICO, FECHA, HORA, SINTOMAS, MEDICAMENTO RECETADO, CANTIDAD, RECOMENDACIONES, ESTADO", vISITADataGridView, 10);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*
         * Este apartado refleja el registro seleccionado en el DataGridView y lo muestra en los textbox del form.
         * El if (e.RowIndex >= 0)es para evitar que, al seleccionar los titulos de las tablas, no explote el programa
         *          lo que dice es, si el registro seleccionado es mayor que cero, entonces si se muestran los datos en los textbox
         */
        private void vISITADataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                iD_VISITATextBox.Text = vISITADataGridView[0, e.RowIndex].Value.ToString();
                nOMBRE_MEDICOComboBox.Text = vISITADataGridView[1, e.RowIndex].Value.ToString();
                CBXPACIENTE.Text = vISITADataGridView[2, e.RowIndex].Value.ToString();
                fECHADateTimePicker.Text = vISITADataGridView[3, e.RowIndex].Value.ToString();
                hORADateTimePicker.Text = vISITADataGridView[4, e.RowIndex].Value.ToString();
                sINTOMASTextBox.Text = vISITADataGridView[5, e.RowIndex].Value.ToString();
                cbxMedicamento.Text = vISITADataGridView[6, e.RowIndex].Value.ToString();
                txtcantidadVisita.Text = vISITADataGridView[7, e.RowIndex].Value.ToString();
                rECOMENDACIONESTextBox.Text = vISITADataGridView[8, e.RowIndex].Value.ToString();
                eSTADOTextBox.Text = vISITADataGridView[9, e.RowIndex].Value.ToString();
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
