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
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }
        //Registar usuario

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            /* La funcion *llenarCBX* se encarga de llenar los comboBoxs que se encuentran en el diseño los cuales requieren opciones fuera de la base de datos,
            * hay que enviarle el NOMBRE del ComboBox, El de los TITULOS (el que se mostrara, como una mascara) y el ARRAY de los VALUES de esos titulos, 
            * como si fuesen un ID)*/
            String[] ArrayTitulos = { "Administrador", "Usuario Regular" };
            String[] ArrayValues = { "A", "U", };
            Helper.llenarCBX(cbxtipo, ArrayTitulos, ArrayValues);

            String[] ArrayTitulos1 = { "Activa", "Inactiva", "Bloqueada", "Suspendida" };
            String[] ArrayValues1 = { "A", "I", "B", "S" };
            Helper.llenarCBX(cbxestado, ArrayTitulos1, ArrayValues1);

            //en caso de no haber accedido por el From usuario el CBX de tipo de usuario y estado de cuenta se hará invisible
            if (Program.tipo != "A")
            {
                GBTCU.Visible = false;
            }
            else
            {
                //cambiando posicion del GroupBox
                groupBox1.Location = new Point(223, 12);

                //Se quita el control box del windows form, Botones de minimizar, maximizar y cerrar
                this.ControlBox = false;

                //titulo dedl Form
                this.Text = "Registrar usuario";
            }

            //Seteando el comboBox en la primera posicion
            cbxtipo.SelectedIndex = 0;
            cbxestado.SelectedIndex = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //se abre la conexion
            SqlConnection con = new SqlConnection();
            con = new SqlConnection("Data Source=GEORGEDESK\\SQLEXPRESS;Initial Catalog=PARCIALJP;Integrated Security=True");
            con.Open();
            //se verifica que ningun campo importante este vacio
            if (txtusername.Text != "" && txtpassword.Text != "" && txtpassword2.Text != "" && txtnombre.Text != "")
            {
                //se verifica que las contraseñas esten iguales
                if (txtpassword2.Text != txtpassword.Text)
                {
                    MessageBox.Show("Las Contraseñas no coinciden");
                }
                else
                {
                    //se envia el string del usuario y contraseña a la funcion GetSha3Hash, la cual devuelve un string que se almacenara en las variables username y password
                    string username = Helper.GetSha3Hash((txtusername.Text).ToString());
                    string password = Helper.GetSha3Hash((txtpassword.Text).ToString());
                    try
                    {
                        //se envia un query el cual devolvera el numero de filas con dichos parametros, este pasa a convertirse a entero para ser comparado luego
                        string query = $"SELECT COUNT(*) FROM USUARIO WHERE USERNAME = '{username}'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        Int32 count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 0)
                        {
                            //en caso de no haber ningun registro con esos datos, sigue...
                            try
                            {
                                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                                /*
                                * Este apartado realiza el  guardado del registro.
                                * 1- Se crea un string el cual tendra el query con distintos @parametros que seran cambiados mas adelante
                                * 2- se crea un SqlCommand con el string creado
                                * 3- se reemplazan los parametros con los textos de los textbox.
                                * 4- se envia el comando al metodo DoQueryExecuterLimpio para ser ejecutado
                                * 5- se cierra el form para volver a su antecesor
                                */
                                string sql = $"INSERT INTO USUARIO VALUES ('{username}', '{password}', @tipo, @estado, @nombre)";
                                SqlCommand command = new SqlCommand(sql);
                                command.Parameters.AddWithValue("@nombre", txtnombre.Text);
                                command.Parameters.AddWithValue("@tipo", cbxtipo.SelectedValue.ToString());
                                command.Parameters.AddWithValue("@estado", cbxestado.SelectedValue.ToString());
                                Helper.DoQueryExecuterLimpio(command);

                                /*aqui se verifica si se esta iniciando a este form por afuera o a traves del form FrmUsuario, 
                                 * el cual es solo accesible para los administradores, 
                                 *si la variable no esta vacia da un mensaje de que se registro el usuario
                                 */
                                if (Program.tipo != "")
                                {
                                    MessageBox.Show("Usuario registrado con exito ");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Bienvenido " + txtusername.Text);
                                    FrmMenu fmMenu = new FrmMenu();
                                    fmMenu.Show();
                                    this.Hide();
                                }
                            }
                            catch (Exception er)
                            {
                                MessageBox.Show("No se pudo registrar " + er);
                            }
                        }
                        else
                        {
                            //sucede cuando se encuentra un usuario con el mismo USERNAME
                            MessageBox.Show("Usuario no Disponible");
                        }

                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("No se pudo ingresar al sistema " + er);
                    }
                    finally
                    {
                        //cierre de conexion
                        con.Close();
                    }
                }
            }
            else
            {
                //falto un dato importante al registrarse
                MessageBox.Show("Datos incompletos");
            }
        }
        /*aqui se verifica si se esta iniciando a este form por afuera o a traves del form FrmUsuario, 
         * el cual es solo accesible para los administradores, 
         *si la variable no esta vacia ira al form FrmUsuario
         *de lo contrario ira al FrmLogin
         */
        private void FrmRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.tipo != "")
            {
                FrmMenu menu = new FrmMenu();
                FrmUsuario usuario = new FrmUsuario();
                menu.abrirForm(usuario);
            }
            else
            {
                FrmLogin fmLogin = new FrmLogin();
                fmLogin.Show();
                this.Hide();
            }
        }

    }

}

