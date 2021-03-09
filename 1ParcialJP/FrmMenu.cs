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
    public partial class FrmMenu : Form
    {
        
        public FrmMenu()
        {
            InitializeComponent();
        }

        
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            if(Program.tipo != "A")
            {
                lblAU.Visible = false;
                btnAU.Visible = false;
            }
        }
       


        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.tipo = "";
            FrmLogin fmLogin = new FrmLogin();
            fmLogin.Show();
            this.Hide();
        }

        

        private void btnMedicamento_Click(object sender, EventArgs e)
        {
            FrmMedicamento fmmedico = new FrmMedicamento();
            fmmedico.Show();
            this.Hide();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            FrmMedico fmmedico = new FrmMedico();
            fmmedico.Show();
            this.Hide();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            FrmMarca fmmarca = new FrmMarca();
            fmmarca.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPaciente fmPaciente = new FrmPaciente();
            fmPaciente.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTipoFarmaco fmTipoFarmaco = new FrmTipoFarmaco();
            fmTipoFarmaco.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUbicacion fmUbicacion = new FrmUbicacion();
            fmUbicacion.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmVisitas fmvisitas = new FrmVisitas();
            fmvisitas.Show();
            this.Hide();

        }

        private void btnAU_Click(object sender, EventArgs e)
        {
            FrmUsuario fmusuario = new FrmUsuario();
            fmusuario.Show();
            this.Hide();
        }
    }
}
