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
    public partial class FrmAUbicacion : Form
    {
        public FrmAUbicacion()
        {
            InitializeComponent();
        }

        private void FrmAUbicacion_Load(object sender, EventArgs e)
        {
            eSTADOComboBox.SelectedIndex = 0;
        }

        private void FrmAUbicacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmUbicacion fmUbicacion = new FrmUbicacion();
            fmUbicacion.Show();
        }

        

        private void btnGguardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = $"INSERT INTO UBICACION VALUES ('{iD_UBICACIONTextBox.Text}' ,'{dESCRIPCIONTextBox.Text}', '{eSTANTETextBox.Text}', '{tRAMOTextBox.Text}', '{cELDATextBox.Text}', '{eSTADOComboBox.Text}')";
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
