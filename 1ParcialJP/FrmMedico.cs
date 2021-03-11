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
    public partial class FrmMedico : Form
    {
        public FrmMedico()
        {
            InitializeComponent();
        }
        public void refrescargrid()
        {

            try
            {
                string sql = "SELECT * FROM MEDICO";
                DataTable dt = Helper.DoQueryReceiver(sql);
                mEDICODataGridView.DataSource = dt;
                mEDICODataGridView.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener registros de la base de datos: " + er);
            }
        }

        private void FrmMedico_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void mEDICOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mEDICOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pARCIALJPDataSet);

        }

        private void FrmMedico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pARCIALJPDataSet.MEDICO' table. You can move, or remove it, as needed.
            refrescargrid();
            selectsearch.SelectedIndex = 0;
        }

        private void iD_MEDICOLabel_Click(object sender, EventArgs e)
        {

        }

        private void iD_MEDICOTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM MEDICO WHERE ID_MEDICO = '{iD_MEDICOTextBox.Text}'";
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
            string cedula = cEDULATextBox.Text;

            if (ValidacionCedula.validaCedula(cedula))
            {
                
                try
                {
                    string sql = $"UPDATE MEDICO SET NOMBRE = @nombre , CEDULA = @cedula , " +
                        $"ESTADO= @estado , ESPECIALIDAD = @especialidad , TANDA_LABOR = @tanda " +
                        $"WHERE ID_MEDICO = @id";
                    SqlCommand command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@nombre", nOMBRETextBox.Text);
                    command.Parameters.AddWithValue("@cedula", cEDULATextBox.Text);
                    command.Parameters.AddWithValue("@tanda", tANDA_LABORTextBox.Text);
                    command.Parameters.AddWithValue("@especialidad", eSPECIALIDADTextBox.Text);
                    command.Parameters.AddWithValue("@estado", eSTADOComboBox.Text);
                    command.Parameters.AddWithValue("@id", iD_MEDICOTextBox.Text);
                    Helper.DoQueryExecuterLimpio(command);
                    MessageBox.Show("Registro Guardado con exito");
                    refrescargrid();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error al Eliminar registro: " + er);
                }

            }
            else
            {
                MessageBox.Show("Cedula Incorrecta");
            }
           
        }


        private void mEDICODataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            iD_MEDICOTextBox.Text = mEDICODataGridView[0, e.RowIndex].Value.ToString();
            nOMBRETextBox.Text = mEDICODataGridView[1, e.RowIndex].Value.ToString();
            cEDULATextBox.Text = mEDICODataGridView[2, e.RowIndex].Value.ToString();
            tANDA_LABORTextBox.Text = mEDICODataGridView[3, e.RowIndex].Value.ToString();
            eSPECIALIDADTextBox.Text = mEDICODataGridView[4, e.RowIndex].Value.ToString();
            eSTADOComboBox.Text = mEDICODataGridView[5, e.RowIndex].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAMedico frmAMedico= new FrmAMedico();
            this.Hide();
            frmAMedico.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM MEDICO WHERE @select LIKE @search";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@search", "%" + txtsearch.Text + "%");
            command.Parameters.AddWithValue("@select", selectsearch.Text);
            DataTable dt = Helper.DoQueryReceiverLimpio(command);
            mEDICODataGridView.DataSource = dt;
            mEDICODataGridView.Refresh();
        }
    }
}
