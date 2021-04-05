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
    public partial class FrmAVisita : Form
    {
        public FrmAVisita()
        {
            InitializeComponent();
        }

        private void FrmAVisita_Load(object sender, EventArgs e)
        {


            //Se quita el control box del windows form, Botones de minimizar, maximizar y cerrar
            this.ControlBox = false;

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
                SqlCommand command = new SqlCommand();
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

            //seteo de primera opcion al medicamento
            cbxMedicamento.SelectedIndex = 0;

            //seteo de fecha maxima del dateTimePicker
            fECHADateTimePicker.MaxDate = DateTime.Now;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnGguardar_Click(object sender, EventArgs e)
        {
            /*
             * Antes de guardar el registro, se compara la cantidad recetada con el stock del medicamento, si es mayor al stock no ejecuta el query de guardado
             * 
             * 1- se crea el string con el query
             * 2- se envia el string a la funcion soloFila el cual devuelve un solo registro en tipo string, que luego se convierte a entero con el Int32.Parse
             * 3- se comparan las cantidades
             */
            string query = $"select CANTIDAD from MEDICAMENTO where DESCRIPCION = '{cbxMedicamento.Text}'";
            if (Int32.Parse(Helper.soloFila(query)) >= txtcantidadVisita.Value)
            {
                /*update a valor cantidad de medicamento
                 * 
                 * se resta la cantidad de medicamento recetados a la cantidad en stock
                 * 1- Se crea un string el cual tendra el query con distintos @parametros que seran cambiados mas adelante
                 * 2- se crea un SqlCommand con el string creado
                 * 3- se reemplazan los parametros con los textos de los textbox.
                 * 4- se envia el comando al metodo DoQueryExecuterLimpio para ser ejecutado
                */
                string sql = $"update MEDICAMENTO set CANTIDAD = CANTIDAD - @cantidad where DESCRIPCION = @medicamentos ";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@medicamentos", cbxMedicamento.Text);
                command.Parameters.AddWithValue("@cantidad", txtcantidadVisita.Value);
                Helper.DoQueryExecuterLimpio(command);

                /*
                 * Este apartado realiza el  guardado del registro.
                 * 1- Se crea un string el cual tendra el query con distintos @parametros que seran cambiados mas adelante
                 * 2- se crea un SqlCommand con el string creado
                 * 3- se reemplazan los parametros con los textos de los textbox.
                 * 4- se envia el comando al metodo DoQueryExecuterLimpio para ser ejecutado
                 * 5- se cierra el form para volver a su antecesor
                 */
                try
                {
                    sql = $"INSERT INTO VISITA VALUES (@nombremedico, @nombrepaciente, @fecha, @hora" +
                       $", @sintomas, @medicamentos, @cantidad, @estado, @recomendaciones)";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@nombremedico", nOMBRE_MEDICOComboBox.Text);
                    command.Parameters.AddWithValue("@nombrepaciente", CBXPACIENTE.Text);
                    command.Parameters.AddWithValue("@fecha", fECHADateTimePicker.Text);
                    command.Parameters.AddWithValue("@hora", hORADateTimePicker.Text);
                    command.Parameters.AddWithValue("@sintomas", sINTOMASTextBox.Text);
                    command.Parameters.AddWithValue("@medicamentos", cbxMedicamento.Text);
                    command.Parameters.AddWithValue("@cantidad", txtcantidadVisita.Value);
                    command.Parameters.AddWithValue("@estado", eSTADOTextBox.Text);
                    command.Parameters.AddWithValue("@recomendaciones", rECOMENDACIONESTextBox.Text);
                    Helper.DoQueryExecuterLimpio(command);
                    MessageBox.Show("Registro guardado con exito");
                    this.Close();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error al guardar registro: " + er);
                }

            }
            else
            {
                MessageBox.Show("La cantidad introducida excede el stock.");
            }

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /* Al momento de cerrar el form llama a su form antecesor y utiliza el metodo abrirForm para esto, ubicado en el form FrmMenu, el cual resive el form deseado.
         */
        private void FrmAVisita_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmVisitas fmvisitas = new FrmVisitas();
            FrmMenu menu = new FrmMenu();
            menu.abrirForm(fmvisitas);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //cierra el form
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
