﻿using System;
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
                SqlDataAdapter da = Helper.DoQueryReceiver(sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
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
                string sql = $"UPDATE USUARIO SET NOMBRE ='{txtNombreU.Text}', TIPO ='{txtTU.Text}', " +
                    $"ESTADO='{txtEC.Text}' WHERE ID_USUARIO ='{txtIdU.Text}'";
                Helper.DoQueryExecuter(sql);
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
            string query = $"SELECT ID_USUARIO, NOMBRE, TIPO, ESTADO FROM USUARIO WHERE {selectsearch.Text} LIKE '%{txtsearch.Text}%'";
            SqlDataAdapter da = Helper.DoQueryReceiver(query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewUsuario.DataSource = dt;
            dataGridViewUsuario.Refresh();
        }
    }
}
