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
    
    public partial class FrmMarca : Form

    {

        public SqlConnection con { get; set; }
        FrmAMarca aMarca = new FrmAMarca();

        public FrmMarca()
        {
            InitializeComponent();

        }

        private void mARCABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mARCABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pARCIALJPDataSet);

        }
       
        public void FrmMarca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pARCIALJPDataSet.MARCA' table. You can move, or remove it, as needed.
            refrescargrid();
            selectsearch.SelectedIndex = 0;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            aMarca.ShowDialog();
        }
        public void refrescargrid()
        {
           
            try
            {
                string sql = "SELECT * FROM MARCA";
                DataTable dt = Helper.DoQueryReceiver(sql);
                mARCADataGridView.DataSource = dt;
                mARCADataGridView.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener registros de la base de datos: " + er);
            }
        }

        private void mARCADataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            iD_MARCATextBox.Text = mARCADataGridView[0, e.RowIndex].Value.ToString();
            dESCRIPCIONTextBox.Text = mARCADataGridView[1, e.RowIndex].Value.ToString();
            eSTADOComboBox.Text = mARCADataGridView[2, e.RowIndex].Value.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            // prueba de sanitizacion
            try
            {
            string sql = $"UPDATE MARCA SET ESTADO = '{eSTADOComboBox.Text}', DESCRIPCION = @descripcion WHERE ID_MARCA ='{iD_MARCATextBox.Text}'";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@descripcion", dESCRIPCIONTextBox.Text);
            Helper.DoQueryExecuterLimpio(command);
            MessageBox.Show("Registro Guardado con exito");
            refrescargrid();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Guardar Cambios: " + er);
            }
        }

        private void FrmMarca_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM MARCA WHERE ID_MARCA = '{iD_MARCATextBox.Text}'";
                Helper.DoQueryExecuter(sql);
                MessageBox.Show("Registro Eliminado con exito");
                refrescargrid();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Eliminar registro: " + er);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM MARCA WHERE {selectsearch.Text} LIKE @search";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@search", "%" + txtsearch.Text + "%" );
            DataTable dt = Helper.DoQueryReceiverLimpio(command);
            mARCADataGridView.DataSource = dt;
            mARCADataGridView.Refresh();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectsearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
