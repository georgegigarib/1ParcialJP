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


        public void refrescargrid()
        {

            try
            {
                string sql = "SELECT ID_USUARIO, NOMBRE, TIPO, ESTADO FROM USUARIO";
                SqlCommand command = new SqlCommand(sql);
                dataGridViewUsuario.DataSource = Helper.DoQueryReceiverLimpio(command);
                dataGridViewUsuario.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener registros de la base de datos: " + er);
            }
        }
        private void FrmUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistro fmregistro = new FrmRegistro();
            FrmMenu menu = new FrmMenu();
            menu.abrirForm(fmregistro);
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridViewUsuario.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            String[] ArrayTitulos = { "Administrador", "Usuario Regular" };
            String[] ArrayValues = { "A", "U", };
            Helper.llenarCBX(txtTU, ArrayTitulos, ArrayValues);
            String[] ArrayTitulos1 = { "Activa", "Inactiva","Bloqueada","Suspendida" };
            String[] ArrayValues1 = { "A", "I", "B", "S" };
            Helper.llenarCBX(txtEC, ArrayTitulos1, ArrayValues1);
            String[] ArrayTitulos2 = { "ID", "Nombre", "Tipo de Usuario", "Estado de Cuenta" };
            String[] ArrayValues2 = { "ID_USUARIO", "NOMBRE","TIPO", "ESTADO" };
            Helper.llenarCBX(selectsearch, ArrayTitulos2, ArrayValues2);
            selectsearch.SelectedIndex = 0;
            this.ControlBox = false;
            refrescargrid();
        }

        private void dataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIdU.Text = dataGridViewUsuario[0, e.RowIndex].Value.ToString();
                txtNombreU.Text = dataGridViewUsuario[1, e.RowIndex].Value.ToString();
                txtTU.SelectedValue = dataGridViewUsuario[2, e.RowIndex].Value.ToString();
                txtEC.SelectedValue = dataGridViewUsuario[3, e.RowIndex].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM USUARIO WHERE ID_USUARIO = @id";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@id", txtIdU.Text);
                Helper.DoQueryExecuterLimpio(command);
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
                string sql = $"UPDATE USUARIO SET NOMBRE = @nombre, TIPO = @tipo, ESTADO= @estado WHERE ID_USUARIO = @id";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@nombre", txtNombreU.Text);
                command.Parameters.AddWithValue("@tipo", txtTU.SelectedValue.ToString());
                command.Parameters.AddWithValue("@estado", txtEC.SelectedValue.ToString());
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
            string sql = $"SELECT ID_USUARIO, NOMBRE, TIPO, ESTADO FROM USUARIO WHERE {selectsearch.SelectedValue.ToString()} LIKE @search";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@search", "%" + txtsearch.Text + "%");
            dataGridViewUsuario.DataSource = Helper.DoQueryReceiverLimpio(command);
            dataGridViewUsuario.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Helper help = new Helper();
            help.Exportar("ID, NOMBRE, TIPO DE USUARIO, ESTADO DE CUENTA", dataGridViewUsuario, 4);
        }
    }
}
