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
                string sql = "SELECT * FROM PACIENTE";
                SqlDataAdapter da = Helper.DoQueryReceiver(sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                pACIENTEDataGridView.DataSource = dt;
                pACIENTEDataGridView.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener registros de la base de datos: " + er);
            }
        }
        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pARCIALJPDataSet.PACIENTE' table. You can move, or remove it, as needed.
           
            refrescargrid();
        }

        private void pACIENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pACIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pARCIALJPDataSet);

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
                    string sql = $"UPDATE PACIENTE SET NOMBRE ='{nOMBRETextBox.Text}', CEDULA ='{cEDULATextBox.Text}', " +
                        $"ESTADO='{eSTADOComboBox.Text}', NUM_CARNET ='{nUM_CARNETTextBox.Text}', TIPO_PACIENTE='{tIPO_PACIENTEComboBox.Text}' " +
                        $"WHERE ID_PACIENTE ='{iD_PACIENTETextBox.Text}'";
                    Helper.DoQueryExecuter(sql);
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
                string sql = $"DELETE FROM PACIENTE WHERE ID_PACIENTE = '{iD_PACIENTETextBox.Text}'";
                Helper.DoQueryExecuter(sql);
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
    }
}
