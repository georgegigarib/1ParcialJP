using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _1ParcialJP
{
    public partial class FrmAPaciente : Form
    {
        public FrmAPaciente()
        {
            InitializeComponent();
        }

        private void FrmAPaciente_Load(object sender, EventArgs e)
        {
            eSTADOComboBox.SelectedIndex = 0;
            tIPO_PACIENTEComboBox.SelectedIndex = 0;
        }

        private void FrmAPaciente_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmPaciente fmPaciente = new FrmPaciente();
            fmPaciente.Show();
        }

        

        private void btnGguardar_Click_1(object sender, EventArgs e)
        {

            string cedula = cEDULATextBox.Text;
            if (ValidacionCedula.validaCedula(cedula))
            {
                try
                {
                    string sql = $"INSERT INTO PACIENTE VALUES (@nombre, @cedula , @carnet , @tipo , @estado )";
                    SqlCommand command = new SqlCommand();
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@nombre", nOMBRETextBox.Text);
                    command.Parameters.AddWithValue("@cedula", cEDULATextBox.Text);
                    command.Parameters.AddWithValue("@carnet", nUM_CARNETTextBox.Text);
                    command.Parameters.AddWithValue("@tipo", tIPO_PACIENTEComboBox.Text);
                    command.Parameters.AddWithValue("@estado", eSTADOComboBox.Text);
                    Helper.DoQueryExecuterLimpio(command);
                    Helper.DoQueryExecuter(sql);
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
                MessageBox.Show("Cedula Incorrecta");
            }

            
        }

        
    }
}
