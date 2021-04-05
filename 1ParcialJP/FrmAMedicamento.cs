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

    public partial class FrmAMedicamento : Form
    {

        public FrmAMedicamento()
        {
            InitializeComponent();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FrmAMedicamento_Load(object sender, EventArgs e)
        {

            /* La funcion *llenarCBX* se encarga de llenar los comboBoxs que se encuentran en el diseño los cuales requieren opciones fuera de la base de datos,
           * hay que enviarle el NOMBRE del ComboBox, El de los TITULOS (el que se mostrara, como una mascara) y el ARRAY de los VALUES de esos titulos, 
           * como si fuesen un ID)*/
            String[] ArrayTitulos = { "Disponible", "Descontinuado", "No Disponible" };
            String[] ArrayValues = { "DISPONIBLE", "DESCONTINUADO", "NO DISPONIBLE" };
            Helper.llenarCBX(eSTADOComboBox, ArrayTitulos, ArrayValues);

            /*Esta seccion se encarga de llenar los COMOBOX con registros de la base de datos,
             * 1- Se limpian los comobox 
             * 2- Se crea un objeto Datatable y uno SqlCommand
             * 3- se llena el objeto datatable con el Datatable que trae la funcion DoQueryReceiverLimpio cuando se le envia un SqlCommand con su respectivo QUERY
             * 4- Se hace un FOREACH para recorrer cada fila y llenar el combobox con los ITEMS
             * 5- se limpia el objeto Datatable para un proximo uso
            */
            try
            {
                CBXUbicacion.Items.Clear();
                CBXMarca.Items.Clear();
                CBXtipoFarmaco.Items.Clear();
                DataTable dt = new DataTable();
                //COMBOBOX ubicacion
                SqlCommand command = new SqlCommand();
                dt = Helper.DoQueryReceiverLimpio(new SqlCommand($"SELECT ID_UBICACION FROM UBICACION "));
                foreach (DataRow dr in dt.Rows)
                {
                    CBXUbicacion.Items.Add(dr["ID_UBICACION"].ToString());
                }
                //COMBOBOX marca
                dt.Clear();
                dt = Helper.DoQueryReceiverLimpio(new SqlCommand($"SELECT DESCRIPCION FROM MARCA "));


                foreach (DataRow dr in dt.Rows)
                {
                    CBXMarca.Items.Add(dr["DESCRIPCION"].ToString());
                }
                //COMBOBOX tipo farmaco
                dt = Helper.DoQueryReceiverLimpio(new SqlCommand($"SELECT DESCRIPCION FROM TIPO_FARMACO "));

                foreach (DataRow dr in dt.Rows)
                {
                    CBXtipoFarmaco.Items.Add(dr["DESCRIPCION"].ToString());
                }

                //seteo de primera opcion
                CBXUbicacion.SelectedIndex = 0;
                CBXMarca.SelectedIndex = 0;
                CBXtipoFarmaco.SelectedIndex = 0;
                eSTADOComboBox.SelectedIndex = 0;

                //Se quita el control box del windows form, Botones de minimizar, maximizar y cerrar
                this.ControlBox = false;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener las opciones" + er);
            }

        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*
                * Este apartado realiza el  guardado del registro.
                * 1- Se crea un string el cual tendra el query con distintos @parametros que seran cambiados mas adelante
                * 2- se crea un SqlCommand con el string creado
                * 3- se reemplazan los parametros con los textos de los textbox.
                * 4- se envia el comando al metodo DoQueryExecuterLimpio para ser ejecutado
                * 5- se cierra el form para volver a su antecesor
                */

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"INSERT INTO MEDICAMENTO VALUES ( @descripcion, @tipoF, @marca, @ubicacion" +
                    $", @dosis , @estado, @cantidad)";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@descripcion", dESCRIPCIONTextBox.Text);
                command.Parameters.AddWithValue("@tipoF", CBXtipoFarmaco.Text);
                command.Parameters.AddWithValue("@marca", CBXMarca.Text);
                command.Parameters.AddWithValue("@ubicacion", CBXUbicacion.Text);
                command.Parameters.AddWithValue("@dosis", dOSISTextBox.Text);
                command.Parameters.AddWithValue("@estado", eSTADOComboBox.SelectedValue.ToString());
                command.Parameters.AddWithValue("@cantidad", txtcantidad.Value);
                Helper.DoQueryExecuterLimpio(command);
                MessageBox.Show("Registro guardado con exito");
                this.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al guardar registro: " + er);
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /* Al momento de cerrar el form llama a su form antecesor y utiliza el metodo abrirForm para esto, ubicado en el form FrmMenu, el cual resive el form deseado.
         */
        private void FrmAMedicamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMedicamento fmmedico = new FrmMedicamento();
            FrmMenu fmmenu = new FrmMenu();
            fmmenu.abrirForm(fmmedico);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //cierra el form
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
