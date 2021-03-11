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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }
        public void refrescargrid()
        {

            try
            {
                string sql = "SELECT ID_USUARIO, NOMBRE, TIPO, ESTADO FROM USUARIO";
                DataTable dt = Helper.DoQueryReceiver(sql);
                dataGridViewUsuario.DataSource = dt;
                dataGridViewUsuario.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener registros de la base de datos: " + er);
            }
        }
        private void FrmUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistro fmregistro = new FrmRegistro();
            fmregistro.Show();
            this.Hide();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            refrescargrid();

        }

        private void dataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdU.Text = dataGridViewUsuario[0, e.RowIndex].Value.ToString();
            txtNombreU.Text = dataGridViewUsuario[1, e.RowIndex].Value.ToString();
            txtTU.Text = dataGridViewUsuario[2, e.RowIndex].Value.ToString();
            txtEC.Text = dataGridViewUsuario[3, e.RowIndex].Value.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM USUARIO WHERE ID_USUARIO = '{txtIdU.Text}'";
                Helper.DoQueryExecuter(sql);
                MessageBox.Show("Registro Eliminado con exito");
                refrescargrid();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Eliminar registro: " + er);
            }
        }

        private void btnGguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"UPDATE USUARIO SET NOMBRE = @nombre, TIPO = @tipo, " +
                    $"ESTADO= @estado WHERE ID_USUARIO = @id";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@nombre", txtNombreU.Text);
                command.Parameters.AddWithValue("@tipo", txtTU.Text);
                command.Parameters.AddWithValue("@estado", txtEC.Text);
                command.Parameters.AddWithValue("@id", txtIdU.Text);
                Helper.DoQueryExecuterLimpio(command);
                MessageBox.Show("Registro Guardado con exito");
                refrescargrid();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Eliminar registro: " + er);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM USUARIO WHERE @select LIKE @search";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@search", "%" + txtsearch.Text + "%");
            command.Parameters.AddWithValue("@select", selectsearch.Text);
            DataTable dt = Helper.DoQueryReceiverLimpio(command);
            dataGridViewUsuario.DataSource = dt;
            dataGridViewUsuario.Refresh();
        }
    }
}
