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
    public partial class FrmMedicamento : Form
    {
        public FrmMedicamento()
        {
            InitializeComponent();
        }
        
        public void refrescargrid()
        {

            try
            {
                string sql = "SELECT * FROM MEDICAMENTO";
                SqlDataAdapter da = Helper.DoQueryReceiver(sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                mEDICAMENTODataGridView.DataSource = dt;
                mEDICAMENTODataGridView.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener registros de la base de datos: " + er);
            }
        }
        private void mEDICAMENTOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mEDICAMENTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pARCIALJPDataSet);

        }

        private void FrmMedicamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pARCIALJPDataSet.UBICACION' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'pARCIALJPDataSet.MEDICAMENTO' table. You can move, or remove it, as needed.
           
            try
            {
                CBXUbicacion.Items.Clear();
                CBXMarca.Items.Clear();
                CBXtipoFarmaco.Items.Clear();
                DataTable dt = new DataTable();
                //COMBOBOX ubicacion
                dt = combolista("ID_UBICACION", "UBICACION");
                foreach (DataRow dr in dt.Rows)
                {
                    CBXUbicacion.Items.Add(dr["ID_UBICACION"].ToString());
                }
                //COMBOBOX marca
                dt.Clear();
                dt = combolista("DESCRIPCION", "MARCA");

                foreach (DataRow dr in dt.Rows)
                {
                    CBXMarca.Items.Add(dr["DESCRIPCION"].ToString());
                }
                //COMBOBOX tipo farmaco
                dt = combolista("DESCRIPCION", "TIPO_FARMACO");

                foreach (DataRow dr in dt.Rows)
                {
                    CBXtipoFarmaco.Items.Add(dr["DESCRIPCION"].ToString());
                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener las opciones" + er);
            }

            refrescargrid();

        }

        private void iD_TFTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iD_TFLabel_Click(object sender, EventArgs e)
        {

        }

        private void dOSISTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dOSISLabel_Click(object sender, EventArgs e)
        {

        }

        private void FrmMedicamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private DataTable combolista(string id, string tabla)
        {
            string sql = $"SELECT {id} FROM {tabla}";
            SqlDataAdapter da = Helper.DoQueryReceiver(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM MEDICAMENTO WHERE ID_MEDICAMENTO = '{iD_MEDICAMENTOTextBox.Text}'";
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
                string sql = $"UPDATE MEDICAMENTO SET DESCRIPCION ='{dESCRIPCIONTextBox.Text}', ID_TF ='{CBXtipoFarmaco.Text}', " +
                    $"ESTADO='{eSTADOComboBox.Text}', ID_UBBICACION ='{CBXUbicacion.Text}', DOSIS='{dOSISTextBox.Text}', ID_MARCA='{CBXMarca.Text}'" +
                    $"WHERE ID_MEDICAMENTO ='{iD_MEDICAMENTOTextBox.Text}'";
                Helper.DoQueryExecuter(sql);
                MessageBox.Show("Registro Guardado con exito");
                refrescargrid();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Eliminar registro: " + er);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAMedicamento frmAM = new FrmAMedicamento();
            frmAM.Show();
            this.Hide();
        }

        private void mEDICAMENTODataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            iD_MEDICAMENTOTextBox.Text = mEDICAMENTODataGridView[0, e.RowIndex].Value.ToString();
            dESCRIPCIONTextBox.Text = mEDICAMENTODataGridView[1, e.RowIndex].Value.ToString();
            CBXtipoFarmaco.Text = mEDICAMENTODataGridView[2, e.RowIndex].Value.ToString();
            CBXMarca.Text = mEDICAMENTODataGridView[3, e.RowIndex].Value.ToString();
            CBXUbicacion.Text = mEDICAMENTODataGridView[4, e.RowIndex].Value.ToString();
            dOSISTextBox.Text = mEDICAMENTODataGridView[5, e.RowIndex].Value.ToString();
            eSTADOComboBox.Text = mEDICAMENTODataGridView[6, e.RowIndex].Value.ToString();
        }

        
    }
}
