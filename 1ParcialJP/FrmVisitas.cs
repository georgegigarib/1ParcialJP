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
    public partial class FrmVisitas : Form
    {
        public FrmVisitas()
        {
            InitializeComponent();
        }
        public void refrescargrid()
        {

            try
            {
                vISITADataGridView.DataSource = Helper.QueryTraerTabla("VISITA");
                vISITADataGridView.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener registros de la base de datos: " + er);
            }
        }

        private void FrmVisitas_Load(object sender, EventArgs e)
        {
            selectsearch.SelectedIndex = 0;
            this.ControlBox = false;
            try
            {
                nOMBRE_MEDICOComboBox.Items.Clear();
                CBXPACIENTE.Items.Clear();
                DataTable dt = new DataTable();
                //COMBOBOX nombre medico
                dt = combolista("NOMBRE", "MEDICO");
                foreach (DataRow dr in dt.Rows)
                {
                    nOMBRE_MEDICOComboBox.Items.Add(dr["NOMBRE"].ToString());
                }
                //COMBOBOX nombre paciente
                dt.Clear();
                dt = combolista("NOMBRE", "PACIENTE");

                foreach (DataRow dr in dt.Rows)
                {
                    CBXPACIENTE.Items.Add(dr["NOMBRE"].ToString());
                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener las opciones" + er);
            }
            finally { refrescargrid(); }
        }

        private void FrmVisitas_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private DataTable combolista(string id, string tabla)
        {
            SqlCommand command = new SqlCommand($"SELECT {id} FROM {tabla}");
            return Helper.DoQueryReceiverLimpio(command);
        }
        private void btnGguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"UPDATE VISITA SET NOMBRE_MEDICO = @nombremedico, NOMBRE_PACIENTE = @nombrepaciente, " +
                    $"FECHA= @fecha, HORA = @hora, SINTOMAS= @sintomas," +
                    $" MEDICAMENTOS= @medicamentos, ESTADO= @estado, RECOMENDACIONES= @recomendaciones" +
                    $"WHERE ID_VISITA = @id";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@nombrebedico", nOMBRE_MEDICOComboBox.Text);
                command.Parameters.AddWithValue("@nombrepaciente", CBXPACIENTE.Text);
                command.Parameters.AddWithValue("@fecha", fECHADateTimePicker.Text);
                command.Parameters.AddWithValue("@hora", hORADateTimePicker.Text);
                command.Parameters.AddWithValue("@sintomas", sINTOMASTextBox.Text);
                command.Parameters.AddWithValue("@medicamentos", mEDICAMENTOSTextBox.Text);
                command.Parameters.AddWithValue("@estado", eSTADOTextBox.Text);
                command.Parameters.AddWithValue("@recomendaciones", rECOMENDACIONESTextBox.Text);
                command.Parameters.AddWithValue("@id", iD_VISITATextBox.Text);
                Helper.DoQueryExecuterLimpio(command);
                MessageBox.Show("Registro Guardado con exito");
                //refrescargrid();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Eliminar registro: " + er);
            }
            refrescargrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM VISITA WHERE ID_VISITA = @id ";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@id", iD_VISITATextBox.Text);
                Helper.DoQueryExecuterLimpio(command);
                MessageBox.Show("Registro Eliminado con exito");
                refrescargrid();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Eliminar registro: " + er);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAVisita fmAVisita = new FrmAVisita();
            FrmMenu menu = new FrmMenu();
            menu.abrirForm(fmAVisita);
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            switch (selectsearch.SelectedIndex)
            {
               
                case 6:
                    sql = $"SELECT * FROM VISITA WHERE {selectsearch.Text} >= @search";
                    break;
            default:
                    sql = $"SELECT * FROM VISITA WHERE {selectsearch.Text} LIKE @search";
                    break;
            }

            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@search", "%" + txtsearch.Text + "%");
            vISITADataGridView.DataSource = Helper.DoQueryReceiverLimpio(command);
            vISITADataGridView.Refresh();
        }

        private void selectsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsearch.Clear();
            if(selectsearch.SelectedIndex == 6)
            {
                txtfecha.Visible = true;
                txtsearch.Visible = false;
            }
            else
            {
                txtfecha.Visible = false;
                txtsearch.Visible = true;
            }
        }

        private void vISITADataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            iD_VISITATextBox.Text = vISITADataGridView[0, e.RowIndex].Value.ToString();
            nOMBRE_MEDICOComboBox.Text = vISITADataGridView[1, e.RowIndex].Value.ToString();
            CBXPACIENTE.Text = vISITADataGridView[2, e.RowIndex].Value.ToString();
            fECHADateTimePicker.Text = vISITADataGridView[3, e.RowIndex].Value.ToString();
            hORADateTimePicker.Text = vISITADataGridView[4, e.RowIndex].Value.ToString();
            sINTOMASTextBox.Text = vISITADataGridView[5, e.RowIndex].Value.ToString();
            mEDICAMENTOSTextBox.Text = vISITADataGridView[6, e.RowIndex].Value.ToString();
            rECOMENDACIONESTextBox.Text = vISITADataGridView[7, e.RowIndex].Value.ToString();
            eSTADOTextBox.Text = vISITADataGridView[8, e.RowIndex].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
