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
    public partial class FrmUbicacion : Form
    {
        public FrmUbicacion()
        {
            InitializeComponent();
        }
        public void refrescargrid()
        {

            try
            {
                string sql = "SELECT * FROM UBICACION";
                SqlDataAdapter da = Helper.DoQueryReceiver(sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                uBICACIONDataGridView.DataSource = dt;
                uBICACIONDataGridView.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener registros de la base de datos: " + er);
            }
        }
        private void uBICACIONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uBICACIONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pARCIALJPDataSet);

        }

        private void FrmUbicacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pARCIALJPDataSet.UBICACION' table. You can move, or remove it, as needed.
            refrescargrid();
        }

        private void FrmUbicacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void uBICACIONDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM UBICACION WHERE ID_UBICACION = '{iD_UBICACIONTextBox.Text}'";
                Helper.DoQueryExecuter(sql);
                MessageBox.Show("Registro Eliminado con exito");
                refrescargrid();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Eliminar registro: " + er);
            }
        }

        

        
        private void uBICACIONDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            iD_UBICACIONTextBox.Text = uBICACIONDataGridView[0, e.RowIndex].Value.ToString();
            dESCRIPCIONTextBox.Text = uBICACIONDataGridView[1, e.RowIndex].Value.ToString();
            eSTANTETextBox.Text = uBICACIONDataGridView[2, e.RowIndex].Value.ToString();
            tRAMOTextBox.Text = uBICACIONDataGridView[3, e.RowIndex].Value.ToString();
            cELDATextBox.Text = uBICACIONDataGridView[4, e.RowIndex].Value.ToString();
            eSTADOComboBox.Text = uBICACIONDataGridView[5, e.RowIndex].Value.ToString();
        }

        private void btnGguardar_Click(object sender, EventArgs e)
        {
            

            try
            {
                string sql = $"UPDATE UBICACION SET DESCRIPCION ='{dESCRIPCIONTextBox.Text}', ESTANTE ='{eSTANTETextBox.Text}', " +
                    $"TRAMO='{tRAMOTextBox.Text}', CELDA ='{cELDATextBox.Text}', ESTADO='{eSTADOComboBox.Text}' " +
                    $"WHERE ID_UBICACION ='{iD_UBICACIONTextBox.Text}'";
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
            FrmAUbicacion fmAUbicacion = new FrmAUbicacion();
            fmAUbicacion.Show();
            this.Hide();
        }
    }
}
