using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                    string sql = $"INSERT INTO PACIENTE VALUES ('{nOMBRETextBox.Text}', '{cEDULATextBox.Text}'," +
                        $"'{nUM_CARNETTextBox.Text}','{tIPO_PACIENTEComboBox.Text}','{eSTADOComboBox.Text}')";
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
