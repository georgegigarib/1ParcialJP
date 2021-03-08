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
    public partial class FrmAMedico : Form
    {
        public FrmAMedico()
        {
            InitializeComponent();
        }

      

        private void FrmAMedico_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMedico fmmedico = new FrmMedico();
            fmmedico.Show();

        }

        private void FrmAMedico_Load(object sender, EventArgs e)
        {
            eSTADOComboBox.SelectedIndex = 0;
        }
       
        private void btnGguardar_Click_1(object sender, EventArgs e)
        {


            string cedula = cEDULATextBox.Text;

            if (ValidacionCedula.validaCedula(cedula))
            {

                try
                {
                    string sql = $"INSERT INTO MEDICO VALUES ('{nOMBRETextBox.Text}', '{cEDULATextBox.Text}','{tANDA_LABORTextBox.Text}','{eSPECIALIDADTextBox.Text}','{eSTADOComboBox.Text}')";
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
