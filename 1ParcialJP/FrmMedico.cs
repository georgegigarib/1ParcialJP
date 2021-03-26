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
                mEDICODataGridView.DataSource = Helper.QueryTraerTabla("MEDICO");
                mEDICODataGridView.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener registros de la base de datos: " + er);
            }
        }

        private void FrmMedico_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void FrmMedico_Load(object sender, EventArgs e)
        {
            refrescargrid();
            String[] ArrayTitulos = { "Disponible", "Vacaciones", "Licencia", "No Disponible" };
            String[] ArrayValues = { "DISPONIBLE", "VACACIONES", "LICENCIA", "NO DISPONIBLE" };
            Helper.llenarCBX(eSTADOComboBox, ArrayTitulos, ArrayValues);
            String[] ArrayTitulos1 = { "Matutino", "Vespertino", "Nocturno" };
            String[] ArrayValues1 = { "MATUTINO", "VESPERTINO", "NOCTURNO" };
            Helper.llenarCBX(tANDA_LABORTextBox, ArrayTitulos1, ArrayValues1);
            String[] ArrayTitulos2 = { "Nombre", "Cedula", "Estado","Especialidad","Tanda de Labor" };
            String[] ArrayValues2 = { "NOMBRE", "CEDULA", "ESTADO", "ESPECIALIDAD", "TANDA_LABOR" };
            Helper.llenarCBX(selectsearch, ArrayTitulos2, ArrayValues2);
            selectsearch.SelectedIndex = 0;
            this.ControlBox = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM MEDICO WHERE ID_MEDICO = @id";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@id", iD_MEDICOTextBox.Text);
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
                    command.Parameters.AddWithValue("@tanda", tANDA_LABORTextBox.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@especialidad", eSPECIALIDADTextBox.Text);
                    command.Parameters.AddWithValue("@estado", eSTADOComboBox.SelectedValue.ToString());
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
            FrmMenu fmmenu = new FrmMenu();
            fmmenu.abrirForm(frmAMedico);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM MEDICO WHERE {selectsearch.SelectedValue.ToString()} LIKE @search";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@search", "%" + txtsearch.Text + "%");
            mEDICODataGridView.DataSource = Helper.DoQueryReceiverLimpio(command);
            mEDICODataGridView.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
