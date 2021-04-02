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
            this.ControlBox = false;
            try
            {
                nOMBRE_MEDICOComboBox.Items.Clear();
                CBXPACIENTE.Items.Clear();
                cbxMedicamento.Items.Clear();
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
                dt.Clear();
                dt = combolista("DESCRIPCION", "MEDICAMENTO");
                foreach (DataRow dr in dt.Rows)
                {
                    cbxMedicamento.Items.Add(dr["DESCRIPCION"].ToString());
                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Error al obtener las opciones" + er);
            }


        }

        private void btnGguardar_Click(object sender, EventArgs e)
        {
            string query = $"select CANTIDAD from MEDICAMENTO where DESCRIPCION = '{cbxMedicamento.Text}'";
            if (Int32.Parse(Helper.soloFila(query)) >= txtcantidadVisita.Value)
            {
                //update a valor cantidad de medicamento
                string sql = $"update MEDICAMENTO set CANTIDAD = CANTIDAD - @cantidad where DESCRIPCION = @medicamentos ";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@medicamentos", cbxMedicamento.Text);
                command.Parameters.AddWithValue("@cantidad", txtcantidadVisita.Value);
                Helper.DoQueryExecuterLimpio(command);


                try
                {
                     sql = $"INSERT INTO VISITA VALUES (@nombremedico, @nombrepaciente, @fecha, @hora" +
                        $", @sintomas, @medicamentos, @cantidad, @estado, @recomendaciones)";
                    command = new SqlCommand(sql);
                    command.Parameters.AddWithValue("@nombremedico", nOMBRE_MEDICOComboBox.Text);
                    command.Parameters.AddWithValue("@nombrepaciente", CBXPACIENTE.Text);
                    command.Parameters.AddWithValue("@fecha", fECHADateTimePicker.Text);
                    command.Parameters.AddWithValue("@hora", hORADateTimePicker.Text);
                    command.Parameters.AddWithValue("@sintomas", sINTOMASTextBox.Text);
                    command.Parameters.AddWithValue("@medicamentos", cbxMedicamento.Text);
                    command.Parameters.AddWithValue("@cantidad", txtcantidadVisita.Value);
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
            else
            {
                MessageBox.Show("La cantidad introducida excede el stock.");
            }
           
        }

        private void FrmAVisita_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmVisitas fmvisitas = new FrmVisitas();
            FrmMenu menu = new FrmMenu();
            menu.abrirForm(fmvisitas);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
