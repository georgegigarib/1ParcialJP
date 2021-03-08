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
                string sql = "SELECT * FROM VISITA";
                SqlDataAdapter da = Helper.DoQueryReceiver(sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                vISITADataGridView.DataSource = dt;
                vISITADataGridView.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener registros de la base de datos: " + er);
            }
        }
        
        private void vISITABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vISITABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pARCIALJPDataSet);
           
        }

        private void FrmVisitas_Load(object sender, EventArgs e)
        {
           

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
       

        private void btnGguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"UPDATE VISITA SET NOMBRE_MEDICO ='{nOMBRE_MEDICOComboBox.Text}', NOMBRE_PACIENTE ='{CBXPACIENTE.Text}', " +
                    $"FECHA='{fECHADateTimePicker.Text}', HORA ='{hORADateTimePicker.Text}', SINTOMAS='{sINTOMASTextBox.Text}'," +
                    $" MEDICAMENTOS='{mEDICAMENTOSTextBox.Text}', ESTADO='{eSTADOTextBox.Text}', RECOMENDACIONES='{rECOMENDACIONESTextBox.Text}'" +
                    $"WHERE ID_VISITA ='{iD_VISITATextBox.Text}'";
                Helper.DoQueryExecuter(sql);
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
                string sql = $"DELETE FROM VISITA WHERE ID_VISITA = '{iD_VISITATextBox.Text}'";
                Helper.DoQueryExecuter(sql);
                MessageBox.Show("Registro Eliminado con exito");
                refrescargrid();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Eliminar registro: " + er);
            }
        }


        private void vISITADataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAVisita fmAVisita = new FrmAVisita();
            fmAVisita.Show();
            this.Hide();
        }

        private void vISITADataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
    }
}
