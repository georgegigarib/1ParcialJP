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
    public partial class FrmAMedicamento : Form
    {
        public FrmAMedicamento()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"INSERT INTO MEDICAMENTO VALUES ( @descripcion, @tipoF, @marca, @ubicacion" +
                    $", @dosis , @estado)" ;
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@descripcion", dESCRIPCIONTextBox.Text);
                command.Parameters.AddWithValue("@tipoF", CBXtipoFarmaco.Text);
                command.Parameters.AddWithValue("@marca", CBXMarca.Text);
                command.Parameters.AddWithValue("@ubicacion", CBXUbicacion.Text);
                command.Parameters.AddWithValue("@dosis", dOSISTextBox.Text);
                command.Parameters.AddWithValue("@estado", eSTADOComboBox.Text);
                Helper.DoQueryExecuterLimpio(command);
                MessageBox.Show("Registro guardado con exito");
                this.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al guardar registro: " + er);
            }
        }

        private void FrmAMedicamento_Load(object sender, EventArgs e)
        {
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
                CBXUbicacion.SelectedIndex = 0;
                CBXMarca.SelectedIndex = 0;
                CBXtipoFarmaco.SelectedIndex = 0;
                eSTADOComboBox.SelectedIndex = 0;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener las opciones" + er);
            }

        }
            private DataTable combolista(string id, string tabla)
        {
            SqlCommand command = new SqlCommand($"SELECT {id} FROM {tabla}");
            return Helper.DoQueryReceiverLimpio(command);
        }

        private void FrmAMedicamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMedicamento fmmedico = new FrmMedicamento();
            fmmedico.Show();
        }

      
    }
}
