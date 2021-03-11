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
    public partial class FrmAVisita : Form
    {
        public FrmAVisita()
        {
            InitializeComponent();
        }

        private DataTable combolista(string id, string tabla)
        {
            SqlCommand command = new SqlCommand($"SELECT {id} FROM {tabla}");
            return Helper.DoQueryReceiverLimpio(command);
        }

        private void FrmAVisita_Load(object sender, EventArgs e)
        {
            fECHADateTimePicker.MaxDate = DateTime.Now;
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

            nOMBRE_MEDICOComboBox.SelectedIndex = 0;
            CBXPACIENTE.SelectedIndex = 0;

        }

        private void btnGguardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                string sql = $"INSERT INTO VISITA VALUES (@nombremedico, @nombrepaciente, @fecha, @hora" +
                    $", @sintomas, @medicamentos, @estado, @recomendaciones)";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@nombremedico", nOMBRE_MEDICOComboBox.Text);
                command.Parameters.AddWithValue("@nombrepaciente", CBXPACIENTE.Text);
                command.Parameters.AddWithValue("@fecha", fECHADateTimePicker.Text);
                command.Parameters.AddWithValue("@hora", hORADateTimePicker.Text);
                command.Parameters.AddWithValue("@sintomas", sINTOMASTextBox.Text);
                command.Parameters.AddWithValue("@medicamentos", mEDICAMENTOSTextBox.Text);
                command.Parameters.AddWithValue("@estado", eSTADOTextBox.Text);
                command.Parameters.AddWithValue("@recomendaciones", rECOMENDACIONESTextBox.Text);
                Helper.DoQueryExecuterLimpio(command);
                MessageBox.Show("Registro guardado con exito");
                this.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al guardar registro: " + er);
            }
        }

        private void FrmAVisita_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmVisitas fmvisitas = new FrmVisitas();
            fmvisitas.Show();
            this.Hide();
        }
    }
}
