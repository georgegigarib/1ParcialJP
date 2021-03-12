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
    public partial class FrmAMarca : Form
    {

        public SqlConnection con { get; set; }
        public FrmAMarca()
        {
            InitializeComponent();
        }

        private void FrmAMarca_Load(object sender, EventArgs e)
        {
            eSTADOComboBox.SelectedIndex = 0;
            this.ControlBox = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"INSERT INTO MARCA VALUES (@descripcion, @estadoo ) ";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@descripcion", dESCRIPCIONTextBox.Text);
                command.Parameters.AddWithValue("@estadoo", eSTADOComboBox.Text);
                Helper.DoQueryExecuterLimpio(command);
                MessageBox.Show("Registro Guardado con exito");
                this.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Guardar Registro: " + er);
            }
        }
        private void FrmAMarca_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu fmmenu = new FrmMenu();
            FrmMarca fmMarca = new FrmMarca();
            fmmenu.abrirForm(fmMarca);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
