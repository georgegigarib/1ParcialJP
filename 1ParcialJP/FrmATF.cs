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
    public partial class FrmATF : Form
    {
        public FrmATF()
        {
            InitializeComponent();
        }

       

        private void FrmATF_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmTipoFarmaco fmTipoFarmaco = new FrmTipoFarmaco();
            fmTipoFarmaco.Show();
        }

        private void FrmATF_Load(object sender, EventArgs e)
        {
            eSTADOComboBox.SelectedIndex = 0;
        }

        private void btnGguardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = $"INSERT INTO TIPO_FARMACO VALUES ('{dESCRIPCIONTextBox.Text}', '{eSTADOComboBox.Text}')";
                Helper.DoQueryExecuter(sql);
                MessageBox.Show("Registro guardado con exito");
                this.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al guardar registro: " + er);
            }
        }
    }
}
