using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _1ParcialJP
{
    public partial class FrmAPaciente : Form
    {
        public FrmAPaciente()
        {
            InitializeComponent();
        }


        private void FrmAPaciente_Load(object sender, EventArgs e)
        {
            /*Esta seccion se encarga de llenar los COMOBOX con registros de la base de datos,
            * 1- Se limpian los comobox 
            * 2- Se crea un objeto Datatable y uno SqlCommand
            * 3- se llena el objeto datatable con el Datatable que trae la funcion DoQueryReceiverLimpio cuando se le envia un SqlCommand con su respectivo QUERY
            * 4- Se hace un FOREACH para recorrer cada fila y llenar el combobox con los ITEMS
            * 5- se limpia el objeto Datatable para un proximo uso
            */
            String[] ArrayTitulos = { "Saludable", "Estable", "Grave" };
            String[] ArrayValues = { "SALUDABLE", "ESTABLE", "GRAVE" };
            Helper.llenarCBX(eSTADOComboBox, ArrayTitulos, ArrayValues);
            String[] ArrayTitulos1 = { "Activo", "Inactivo" };
            String[] ArrayValues1 = { "ACTIVO", "INACTIVO" };
            Helper.llenarCBX(tIPO_PACIENTEComboBox, ArrayTitulos1, ArrayValues1);

            //seteo de primera opcion
            eSTADOComboBox.SelectedIndex = 0;
            tIPO_PACIENTEComboBox.SelectedIndex = 0;

            //Se quita el control box del windows form, Botones de minimizar, maximizar y cerrar
            this.ControlBox = false;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnGguardar_Click_1(object sender, EventArgs e)
        {
            //en esta parte se valida la cedula primero, se envia un string al a funcion validaCedula
            // y esta devuelve un booleano, si es verdadero, continua con la funcion
            string cedula = cEDULATextBox.Text;
            if (ValidacionCedula.validaCedula(cedula))
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
                    string sql = $"INSERT INTO PACIENTE VALUES (@nombre, @cedula , @carnet , @tipo , @estado)";
                    SqlCommand command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@nombre", nOMBRETextBox.Text);
                    command.Parameters.AddWithValue("@cedula", cEDULATextBox.Text);
                    command.Parameters.AddWithValue("@carnet", nUM_CARNETTextBox.Text);
                    command.Parameters.AddWithValue("@tipo", tIPO_PACIENTEComboBox.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@estado", eSTADOComboBox.SelectedValue.ToString());
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
                MessageBox.Show("Cedula Incorrecta");
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /* Al momento de cerrar el form llama a su form antecesor y utiliza el metodo abrirForm para esto, ubicado en el form FrmMenu, el cual resive el form deseado.
         */
        private void FrmAPaciente_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmPaciente fmPaciente = new FrmPaciente();
            FrmMenu menu = new FrmMenu();
            menu.abrirForm(fmPaciente);
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //cierra el form
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
