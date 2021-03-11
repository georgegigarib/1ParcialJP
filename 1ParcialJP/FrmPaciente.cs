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
    public partial class FrmPaciente : Form
    {
        public FrmPaciente()
        {
            InitializeComponent();
        }
        public void refrescargrid()
        {

            try
            {
                pACIENTEDataGridView.DataSource = Helper.QueryTraerTabla("PACIENTE");
                pACIENTEDataGridView.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener registros de la base de datos: " + er);
            }
        }
        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            selectsearch.SelectedIndex = 0;
            refrescargrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAPaciente frmAPaciente = new FrmAPaciente();
            this.Hide();
            frmAPaciente.ShowDialog();
        }

        

        private void FrmPaciente_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void btnGguardar_Click(object sender, EventArgs e)
        {
            string cedula = cEDULATextBox.Text;

            if (ValidacionCedula.validaCedula(cedula))
            {
                try
                {
                    string sql = $"UPDATE PACIENTE SET NOMBRE = @nombre , CEDULA = @cedula , " +
                        $"ESTADO = @estado , NUM_CARNET = @carnet , TIPO_PACIENTE= @tipo " +
                        $"WHERE ID_PACIENTE = @id ";
                    SqlCommand command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@nombre", nOMBRETextBox.Text);
                    command.Parameters.AddWithValue("@cedula", cEDULATextBox.Text);
                    command.Parameters.AddWithValue("@carnet", nUM_CARNETTextBox.Text);
                    command.Parameters.AddWithValue("@tipo", tIPO_PACIENTEComboBox.Text);
                    command.Parameters.AddWithValue("@estado", eSTADOComboBox.Text);
                    command.Parameters.AddWithValue("@id", iD_PACIENTETextBox.Text);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM PACIENTE WHERE ID_PACIENTE = @id";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@id", iD_PACIENTETextBox.Text);
                Helper.DoQueryExecuterLimpio(command);
                MessageBox.Show("Registro Eliminado con exito");
                refrescargrid();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Eliminar registro: " + er);
            }
        }

        private void pACIENTEDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            iD_PACIENTETextBox.Text = pACIENTEDataGridView[0, e.RowIndex].Value.ToString();
            nOMBRETextBox.Text = pACIENTEDataGridView[1, e.RowIndex].Value.ToString();
            cEDULATextBox.Text = pACIENTEDataGridView[2, e.RowIndex].Value.ToString();
            nUM_CARNETTextBox.Text = pACIENTEDataGridView[3, e.RowIndex].Value.ToString();
            tIPO_PACIENTEComboBox.Text = pACIENTEDataGridView[4, e.RowIndex].Value.ToString();
            eSTADOComboBox.Text = pACIENTEDataGridView[5, e.RowIndex].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM PACIENTE WHERE {selectsearch.Text} LIKE @search";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@search", "%" + txtsearch.Text + "%");
            pACIENTEDataGridView.DataSource = Helper.DoQueryReceiverLimpio(command);
            pACIENTEDataGridView.Refresh();
        }

        
    }
}
