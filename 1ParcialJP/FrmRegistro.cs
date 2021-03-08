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

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con = new SqlConnection("Data Source=GEORGEDESK\\SQLEXPRESS;Initial Catalog=PARCIALJP;Integrated Security=True");
            con.Open();

            if (txtusername.Text != "" || txtpassword.Text != "" || txtpassword2.Text != "")
            {
                if (txtpassword2.Text != txtpassword2.Text)
                {
                    MessageBox.Show("Las Contraseñas no coinciden");
                }
                else {

                    string username = Helper.GetSha3Hash((txtusername.Text).ToString());
                    string password = Helper.GetSha3Hash((txtpassword.Text).ToString());
                    try
                    {

                        string query = $"SELECT COUNT(*) FROM USUARIO WHERE USERNAME = '{username}' AND PASSWORD = '{password}'";

                        SqlCommand cmd = new SqlCommand(query, con);
                        Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 0)
                        {
                            try
                            {
                                Helper.DoQueryExecuter($"INSERT INTO USUARIO VALUES ('{username}', '{password}', 'U', 'A')");
                            }
                            catch(Exception er)
                            {
                                MessageBox.Show("No se pudo registrar " + er);
                            }
                            MessageBox.Show("Bienvenido " + txtusername.Text);
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
            }
            else
            {
                MessageBox.Show("Datos incompletos");
            }


        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin fmLogin = new FrmLogin();
            fmLogin.Show();
            this.Hide();
        }
    }
}
