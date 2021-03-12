﻿using System;
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
    public partial class FrmTipoFarmaco : Form
    {
        public FrmTipoFarmaco()
        {
            InitializeComponent();
        }
        public void refrescargrid()
        {

            try
            {
                tIPO_FARMACODataGridView.DataSource = Helper.QueryTraerTabla("TIPO_FARMACO");
                tIPO_FARMACODataGridView.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener registros de la base de datos: " + er);
            }
        }

        private void FrmTipoFarmaco_Load(object sender, EventArgs e)
        {
            refrescargrid();
            selectsearch.SelectedIndex = 0;
            this.ControlBox = false;
        }


        private void btnGguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"UPDATE TIPO_FARMACO SET ESTADO = @estado, DESCRIPCION = @descripcion WHERE ID_TF = @id ";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@descripcion", dESCRIPCIONTextBox.Text);
                command.Parameters.AddWithValue("@estado", eSTADOComboBox.Text);
                command.Parameters.AddWithValue("@id", iD_TFTextBox.Text);
                Helper.DoQueryExecuterLimpio(command);
                MessageBox.Show("Registro Guardado con exito");
                refrescargrid();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Eliminar registro: " + er);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmATF fmATF = new FrmATF();
            FrmMenu menu = new FrmMenu();
            menu.abrirForm(fmATF);
        }

        private void FrmTipoFarmaco_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM TIPO_FARMACO WHERE ID_TF = @id ";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@id", iD_TFTextBox.Text);
                Helper.DoQueryExecuterLimpio(command);
                MessageBox.Show("Registro Eliminado con exito");
                refrescargrid();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Eliminar registro: " + er);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM TIPO_FARMACO WHERE {selectsearch.Text} LIKE @search";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@search", "%" + txtsearch.Text + "%");
            tIPO_FARMACODataGridView.DataSource = Helper.DoQueryReceiverLimpio(command);
            tIPO_FARMACODataGridView.Refresh();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
