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
            string sql = $"SELECT {id} FROM {tabla}";
            SqlDataAdapter da = Helper.DoQueryReceiver(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
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
                string sql = $"INSERT INTO VISITA VALUES ('{nOMBRE_MEDICOComboBox.Text}', '{CBXPACIENTE.Text}', '{fECHADateTimePicker.Text}', '{hORADateTimePicker.Text}'" +
                    $", '{sINTOMASTextBox.Text}', '{mEDICAMENTOSTextBox.Text}', '{rECOMENDACIONESTextBox.Text}', '{eSTADOTextBox.Text}')";
                Helper.DoQueryExecuter(sql);
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
