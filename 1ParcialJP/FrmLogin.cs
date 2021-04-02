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
 
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = new SqlConnection("Data Source=GEORGEDESK\\SQLEXPRESS;Initial Catalog=PARCIALJP;Integrated Security=True");
            con.Open();
            if (txtusername.Text != "" || txtpassword.Text != "")
            {
                string username = Helper.GetSha3Hash((txtusername.Text).ToString());
                string password = Helper.GetSha3Hash((txtpassword.Text).ToString());
                try
                {

                    string query = $"SELECT COUNT(*) FROM USUARIO WHERE USERNAME = '{username}' AND PASSWORD = '{password}' AND ESTADO = 'A'";

                    SqlCommand cmd = new SqlCommand(query, con);
                    Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        //  MessageBox.Show("Bienvenido " +  txtusername.Text);
                        //seteando variable de sesion
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

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Program.tipo = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmRegistro fmRegistro = new FrmRegistro();
            fmRegistro.Show();
            this.Hide();
        }
    }
    }

