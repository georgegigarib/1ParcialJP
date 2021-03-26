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
using System.IO;
using System.Diagnostics;

namespace _1ParcialJP
{
    
    public partial class FrmMarca : Form

    {
        public SqlConnection con { get; set; }

        public FrmMarca()
        {
            InitializeComponent();

        }
        FrmMenu menu = new FrmMenu();
        public void FrmMarca_Load(object sender, EventArgs e)
        {
            refrescargrid();
            selectsearch.SelectedIndex = 0;
            String[] ArrayTitulos = {"Activa", "Inactiva" };
            String[] ArrayValues = { "ACTIVA", "INACTIVA" };
            Helper.llenarCBX(eSTADOComboBox, ArrayTitulos, ArrayValues);
            String[] ArrayTitulos1 = {"ID", "Estado", "Descripcion" };
            String[] ArrayValues1 = { "ID_MARCA", "ESTADO", "DESCRIPCION" };
            Helper.llenarCBX(selectsearch, ArrayTitulos1, ArrayValues1);

            this.ControlBox = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FrmAMarca fmAMarca = new FrmAMarca();
            this.Close();
            FrmMenu fmmenu = new FrmMenu();
            fmmenu.abrirForm(fmAMarca);
        }
        public void refrescargrid()
        {
            try
            {
                mARCADataGridView.DataSource = Helper.QueryTraerTabla("MARCA");
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
            if(mARCADataGridView[2, e.RowIndex].Value.ToString() == "ACTIVA")
            {
                eSTADOComboBox.Text = "Activa";
            }
            else
            {
                eSTADOComboBox.Text = "Inactiva";
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            // prueba de sanitizacion
            try
            {
            string sql = $"UPDATE MARCA SET ESTADO = @estado, DESCRIPCION = @descripcion WHERE ID_MARCA = @id ";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@descripcion", dESCRIPCIONTextBox.Text);
            command.Parameters.AddWithValue("@estado", eSTADOComboBox.SelectedValue.ToString());
            command.Parameters.AddWithValue("@id", iD_MARCATextBox.Text);
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
            FrmMenu fmMenu = new FrmMenu();
            fmMenu.abrirMenu();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"DELETE FROM MARCA WHERE ID_MARCA = @id";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@id", iD_MARCATextBox.Text);
                Helper.DoQueryExecuterLimpio(command);
                MessageBox.Show("Registro Eliminado con exito");
                refrescargrid();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Eliminar registro: " + er);
            }
        }



        // de aqui en adelante
        DataTable dt = null;
        private void button2_Click_1(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM MARCA WHERE {selectsearch.SelectedValue.ToString()} LIKE @search";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@search", "%" + txtsearch.Text + "%");
            dt = Helper.DoQueryReceiverLimpio(command);
            mARCADataGridView.DataSource = dt;
            mARCADataGridView.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string filePath = "c:/algo";
        
        private void button4_Click(object sender, EventArgs e)
        {
            writeFileHeader("sep=,");
            writeFileHeader("ID_MARCA, DESCRIPCION, ESTADO");

            foreach (DataRow row in mARCADataGridView.Rows)
            {
                string linea = "";

                foreach (DataColumn dc in mARCADataGridView.Columns)
                {
                    linea += row[dc].ToString() + ",";
                }
                writeFileLine(linea);
            }

            Process.Start(filePath);
        }
        private void writeFileLine(string pLine)
        {
            using (System.IO.StreamWriter w = File.AppendText(filePath))
            {
                w.WriteLine(pLine);
            }
        }
        private void writeFileHeader(string pLine)
        {
            using (System.IO.StreamWriter w = File.CreateText(filePath))
            {
                w.WriteLine(pLine);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(eSTADOComboBox.SelectedValue.ToString());
        }
    }
}
