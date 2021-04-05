using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1ParcialJP
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //al cargar este From se resetea la variable tipo
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Program.tipo = "";
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button1_Click(object sender, EventArgs e)
        {
            //se abre la conexion

            SqlConnection con = new SqlConnection();
            con = new SqlConnection("Data Source=GEORGEDESK\\SQLEXPRESS;Initial Catalog=PARCIALJP;Integrated Security=True");
            con.Open();

            //se verifica que ningun campo importante este vacio
            if (txtusername.Text != "" || txtpassword.Text != "")
            {
                //se envia el string del usuario y contraseña a la funcion GetSha3Hash, la cual devuelve un string que se almacenara en las variables username y password

                string username = Helper.GetSha3Hash((txtusername.Text).ToString());
                string password = Helper.GetSha3Hash((txtpassword.Text).ToString());
                try
                {
                    //se envia un query el cual devolvera el numero de filas con dichos parametros, este pasa a convertirse a entero para ser comparado luego
                    string query = $"SELECT COUNT(*) FROM USUARIO WHERE USERNAME = '{username}' AND PASSWORD = '{password}' AND ESTADO = 'A'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        //en caso de haber algun reggistro con esos datos, sigue...
                        MessageBox.Show("Bienvenido " + txtusername.Text);
                        /* seteando variable de sesion
                        *  se hace una variable string con un query y se envia a la funcion soloFila
                        *  la cual devuelve un string que ira a darle valor a la variable TIPO
                         */
                        query = $"SELECT TIPO FROM USUARIO WHERE USERNAME = '{username}'";
                        Program.tipo = Helper.soloFila(query);
                        FrmMenu fmMenu = new FrmMenu();
                        fmMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos");
                    }

                }
                catch (Exception er)
                {
                    MessageBox.Show("No se pudo ingresar al sistema " + er);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Datos incompletos");
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //abre el FrmRegistro
        private void label3_Click(object sender, EventArgs e)
        {
            FrmRegistro fmRegistro = new FrmRegistro();
            fmRegistro.Show();
            this.Hide();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //cierra el Enviroment completo y el programa deja de correr
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}

