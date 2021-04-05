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
    public partial class FrmAMedico : Form
    {
        public FrmAMedico()
        {
            InitializeComponent();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FrmAMedico_Load(object sender, EventArgs e)
        {

            /* La funcion *llenarCBX* se encarga de llenar los comboBoxs que se encuentran en el diseño los cuales requieren opciones fuera de la base de datos,
             * hay que enviarle el NOMBRE del ComboBox, El de los TITULOS (el que se mostrara, como una mascara) y el ARRAY de los VALUES de esos titulos, 
             * como si fuesen un ID)*/
            this.ControlBox = false;
            String[] ArrayTitulos = { "Disponible", "Vacaciones", "Licencia", "No Disponible" };
            String[] ArrayValues = { "DISPONIBLE", "VACACIONES", "LICENCIA", "NO DISPONIBLE" };
            Helper.llenarCBX(eSTADOComboBox, ArrayTitulos, ArrayValues);
            String[] ArrayTitulos1 = { "Matutino", "Vespertino", "Nocturno" };
            String[] ArrayValues1 = { "MATUTINO", "VESPERTINO", "NOCTURNO" };
            Helper.llenarCBX(tANDA_LABORTextBox, ArrayTitulos1, ArrayValues1);

            //seteo de primera opcion
            eSTADOComboBox.SelectedIndex = 0;

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void btnGguardar_Click_1(object sender, EventArgs e)
        {
            //en esta parte se valida la cedula primero, se envia un string al a funcion validaCedula
            // y esta devuelve un booleano, si es verdadero, continua con la funcion
            string cedula = cEDULATextBox.Text;
            if (ValidacionCedula.validaCedula(cedula))
            {
                try
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
                    string sql = $"INSERT INTO MEDICO VALUES ( @nombre , @cedula, @tanda , @especialidad, @estado)";
                    SqlCommand command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@nombre", nOMBRETextBox.Text);
                    command.Parameters.AddWithValue("@cedula", cEDULATextBox.Text);
                    command.Parameters.AddWithValue("@tanda", tANDA_LABORTextBox.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@especialidad", eSPECIALIDADTextBox.Text);
                    command.Parameters.AddWithValue("@estado", eSTADOComboBox.SelectedValue.ToString()); ;
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
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /* Al momento de cerrar el form llama a su form antecesor y utiliza el metodo abrirForm para esto, ubicado en el form FrmMenu, el cual resive el form deseado.
        */
        private void FrmAMedico_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMedico fmmedico = new FrmMedico();
            FrmMenu fmmenu = new FrmMenu();
            fmmenu.abrirForm(fmmedico);
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //cierra el form
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
