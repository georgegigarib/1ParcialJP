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
            selectsearch.SelectedIndex = 0;
            try
            {
                mEDICAMENTODataGridView.DataSource = Helper.QueryTraerTabla("MEDICAMENTO");
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
            foreach (DataGridViewColumn column in mEDICAMENTODataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            this.ControlBox = false;

            String[] ArrayTitulos = { "Disponible", "Descontinuado", "No Disponible" };
            String[] ArrayValues = { "DISPONIBLE", "DESCONTINUADO", "NO DISPONIBLE" };
            Helper.llenarCBX(eSTADOComboBox, ArrayTitulos, ArrayValues);

            String[] ArrayTitulos1 = {  "Descripcion", "Tipo de Farmaco", "Marca", "Ubicacion", "Dosis", "Estado", "Cantidad" };
            String[] ArrayValues1 = {  "DESCRIPCION", "ID_TF", "ID_MARCA", "ID_UBBICACION", "DOSIS", "ESTADO", "CANTIDAD" };
            Helper.llenarCBX(selectsearch, ArrayTitulos1, ArrayValues1);

         
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
        private void FrmMedicamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private DataTable combolista(string id, string tabla)
        {
            SqlCommand command = new SqlCommand($"SELECT {id} FROM {tabla}");
            return Helper.DoQueryReceiverLimpio(command);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM MEDICAMENTO WHERE ID_MEDICAMENTO = '{iD_MEDICAMENTOTextBox.Text}'";
                SqlCommand command = new SqlCommand(sql);
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
            try
            {
                string sql = $"UPDATE MEDICAMENTO SET DESCRIPCION = @descripcion, ID_TF = @tipoF, " +
                    $"ESTADO= @estado, ID_UBBICACION = @ubicacion, DOSIS= @dosis, ID_MARCA = @marca, CANTIDAD = @cantidad " +
                    $"WHERE ID_MEDICAMENTO = @id";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@descripcion", dESCRIPCIONTextBox.Text);
                command.Parameters.AddWithValue("@tipoF", CBXtipoFarmaco.Text);
                command.Parameters.AddWithValue("@marca", CBXMarca.Text);
                command.Parameters.AddWithValue("@ubicacion", CBXUbicacion.Text);
                command.Parameters.AddWithValue("@dosis", dOSISTextBox.Text);
                command.Parameters.AddWithValue("@estado", eSTADOComboBox.SelectedValue.ToString());
                command.Parameters.AddWithValue("@cantidad", txtcantidad.Value);
                command.Parameters.AddWithValue("@id", iD_MEDICAMENTOTextBox.Text);
                Helper.DoQueryExecuterLimpio(command);
                MessageBox.Show("Registro guardado con exito");
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
            FrmMenu fmmenu = new FrmMenu();
            fmmenu.abrirForm(frmAM);
            this.Close();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            SqlCommand command;
            switch (selectsearch.SelectedIndex)
            {

                case 6:
                    if (int.TryParse(txtsearch.Text, out int result))
                    {
                        sql = $"SELECT * FROM MEDICAMENTO WHERE {selectsearch.SelectedValue.ToString()} <= @search";
                        command = new SqlCommand(sql);
                        command.Parameters.AddWithValue("@search", Int32.Parse(txtsearch.Text));
                        mEDICAMENTODataGridView.DataSource = Helper.DoQueryReceiverLimpio(command);
                        mEDICAMENTODataGridView.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Asegurese de solo escribir numeros.");
                    }
                    break;
                default:
                    sql = $"SELECT * FROM MEDICAMENTO WHERE {selectsearch.SelectedValue.ToString()} LIKE @search";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@search", "%" + txtsearch.Text + "%");
                    mEDICAMENTODataGridView.DataSource = Helper.DoQueryReceiverLimpio(command);
                    mEDICAMENTODataGridView.Refresh();
                    break;
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mEDICAMENTODataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                iD_MEDICAMENTOTextBox.Text = mEDICAMENTODataGridView[0, e.RowIndex].Value.ToString();
                dESCRIPCIONTextBox.Text = mEDICAMENTODataGridView[1, e.RowIndex].Value.ToString();
                CBXtipoFarmaco.Text = mEDICAMENTODataGridView[2, e.RowIndex].Value.ToString();
                CBXMarca.Text = mEDICAMENTODataGridView[3, e.RowIndex].Value.ToString();
                CBXUbicacion.Text = mEDICAMENTODataGridView[4, e.RowIndex].Value.ToString();
                dOSISTextBox.Text = mEDICAMENTODataGridView[5, e.RowIndex].Value.ToString();
                eSTADOComboBox.Text = mEDICAMENTODataGridView[6, e.RowIndex].Value.ToString();
                txtcantidad.Text = mEDICAMENTODataGridView[7, e.RowIndex].Value.ToString();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Helper help = new Helper();
            help.Exportar("ID, DESCRIPCION, TIPO DE FARMACO, MARCA, UBICACION, DOSIS, ESTADO, CANTIDAD", mEDICAMENTODataGridView, 8);
        }
    }
}
