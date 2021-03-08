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
                string sql = "SELECT * FROM TIPO_FARMACO";
                SqlDataAdapter da = Helper.DoQueryReceiver(sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tIPO_FARMACODataGridView.DataSource = dt;
                tIPO_FARMACODataGridView.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener registros de la base de datos: " + er);
            }
        }
        private void tIPO_FARMACOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tIPO_FARMACOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pARCIALJPDataSet);

        }

        private void FrmTipoFarmaco_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pARCIALJPDataSet.TIPO_FARMACO' table. You can move, or remove it, as needed.
            refrescargrid();

        }

        private void tIPO_FARMACODataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tIPO_FARMACODataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            iD_TFTextBox.Text = tIPO_FARMACODataGridView[0, e.RowIndex].Value.ToString();
            dESCRIPCIONTextBox.Text = tIPO_FARMACODataGridView[1, e.RowIndex].Value.ToString();
            eSTADOComboBox.Text = tIPO_FARMACODataGridView[2, e.RowIndex].Value.ToString();
            
        }

        private void btnGguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"UPDATE TIPO_FARMACO SET ESTADO ='{eSTADOComboBox.Text}', DESCRIPCION ='{dESCRIPCIONTextBox.Text}' " +
                    $"WHERE ID_TF ='{iD_TFTextBox.Text}'";
                Helper.DoQueryExecuter(sql);
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
            this.Hide();
            fmATF.ShowDialog();
        }

        private void FrmTipoFarmaco_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM TIPO_FARMACO WHERE ID_TF = '{iD_TFTextBox.Text}'";
                Helper.DoQueryExecuter(sql);
                MessageBox.Show("Registro Eliminado con exito");
                refrescargrid();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Eliminar registro: " + er);
            }
        }
    }
}
