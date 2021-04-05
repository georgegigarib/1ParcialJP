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
    public partial class FrmAUbicacion : Form
    {
        public FrmAUbicacion()
        {
            InitializeComponent();
        }

        private void FrmAUbicacion_Load(object sender, EventArgs e)
        {
            /* La funcion *llenarCBX* se encarga de llenar los comboBoxs que se encuentran en el diseño los cuales requieren opciones fuera de la base de datos,
            * hay que enviarle el NOMBRE del ComboBox, El de los TITULOS (el que se mostrara, como una mascara) y el ARRAY de los VALUES de esos titulos, 
            * como si fuesen un ID)*/
            String[] ArrayTitulos = { "Disponible", "No Disponible", "Lleno", "Vacio" };
            String[] ArrayValues = { "DISPONIBLE", "NO DISPNIBLE", "LLENO", "VACIO" };
            Helper.llenarCBX(eSTADOComboBox, ArrayTitulos, ArrayValues);

            //seteo de primera opcion
            eSTADOComboBox.SelectedIndex = 0;

            //Se quita el control box del windows form, Botones de minimizar, maximizar y cerrar
            this.ControlBox = false;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*
                * Este apartado realiza el  guardado del registro.
                * 1- Se crea un string el cual tendra el query con distintos @parametros que seran cambiados mas adelante
                * 2- se crea un SqlCommand con el string creado
                * 3- se reemplazan los parametros con los textos de los textbox.
                * 4- se envia el comando al metodo DoQueryExecuterLimpio para ser ejecutado
                * 5- se cierra el form para volver a su antecesor
                */

        private void btnGguardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = $"INSERT INTO UBICACION VALUES (@id , @descripcion , @estante, @tramo, @celda, @estado)";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@id", iD_UBICACIONTextBox.Text);
                command.Parameters.AddWithValue("@descripcion", dESCRIPCIONTextBox.Text);
                command.Parameters.AddWithValue("@estante", eSTANTETextBox.Text);
                command.Parameters.AddWithValue("@tramo", tRAMOTextBox.Text);
                command.Parameters.AddWithValue("@celda", cELDATextBox.Text);
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
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* Al momento de cerrar el form llama a su form antecesor y utiliza el metodo abrirForm para esto, ubicado en el form FrmMenu, el cual resive el form deseado.
     */
        private void FrmAUbicacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmUbicacion fmUbicacion = new FrmUbicacion();
            FrmMenu menu = new FrmMenu();
            menu.abrirForm(fmUbicacion);
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //cierra el form
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
