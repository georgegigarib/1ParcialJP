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
               // btnAU.Visible = false;
            }
            IsMdiContainer = true;
            button3.Image = (Image)(new Bitmap(_1ParcialJP.Properties.Resources.pngkey_com_location_png_104244, new Size(30, 35)));
            btnMedicamento.Image = (Image)(new Bitmap(_1ParcialJP.Properties.Resources._234735, new Size(30, 35)));
            btnMedico.Image = (Image)(new Bitmap(_1ParcialJP.Properties.Resources.medico, new Size(30, 35)));
            btnMedicamento.Image = (Image)(new Bitmap(_1ParcialJP.Properties.Resources._234735, new Size(30, 35)));
            btnMarca.Image = (Image)(new Bitmap(_1ParcialJP.Properties.Resources.unnamed__3_1, new Size(30, 35)));
            btnVisitas.Image = (Image)(new Bitmap(_1ParcialJP.Properties.Resources.user_no_photo_300x3001, new Size(30, 35)));
            btnAU.Image = (Image)(new Bitmap(_1ParcialJP.Properties.Resources.d1f3ccc7e836617fb6e5db7fed1ae90b, new Size(30, 35)));
            button1.Image = (Image)(new Bitmap(_1ParcialJP.Properties.Resources.user_no_photo_300x3001, new Size(30, 35)));
            button2.Image = (Image)(new Bitmap(_1ParcialJP.Properties.Resources.pngjoy_com_medicamentos_salud_a_nivel_mundial_transparent_png_6610358, new Size(30, 35)));
            abrirMenu();
            this.BackColor = System.Drawing.Color.Black;
            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackColor = Color.FromArgb(153, 180, 209);
                    // 4#
                    break;
                }
            }
        }
       


        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.tipo = "";
            FrmLogin fmLogin = new FrmLogin();
            fmLogin.Show();
            //  this.Hide();
        }

        

        private void btnMedicamento_Click(object sender, EventArgs e)
        {
            FrmMedicamento fmmedico = new FrmMedicamento();
            fmmedico.MdiParent = this;
            fmmedico.Show();
            // _1ParcialJP.Properties.Resources._234735
            //  //  this.Hide();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            FrmMedico fmmedico = new FrmMedico();
            fmmedico.MdiParent = this;
            fmmedico.Show();
            //  this.Hide();
            // _1ParcialJP.Properties.Resources.medico
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            FrmMarca fmmarca = new FrmMarca();
            fmmarca.MdiParent = this;
            fmmarca.Show();
            //  this.Hide();
            // _1ParcialJP.Properties.Resources.unnamed__3_1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPaciente fmPaciente = new FrmPaciente();
            fmPaciente.MdiParent = this;
            fmPaciente.Show();
            //  this.Hide();
            // _1ParcialJP.Properties.Resources.user_no_photo_300x3001
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTipoFarmaco fmTipoFarmaco = new FrmTipoFarmaco();
            fmTipoFarmaco.MdiParent = this;
            fmTipoFarmaco.Show();
            //  this.Hide();
            // _1ParcialJP.Properties.Resources.pngjoy_com_medicamentos_salud_a_nivel_mundial_transparent_png_6610358
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUbicacion fmUbicacion = new FrmUbicacion();
            fmUbicacion.MdiParent = this;
            fmUbicacion.Show();
            //  this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmVisitas fmvisitas = new FrmVisitas();
            fmvisitas.MdiParent = this;
            fmvisitas.Show();
            //  this.Hide();
            // _1ParcialJP.Properties.Resources._172ddc045ae1707a415adeae0543a5f0_icono_de_trazo_de_color_del_paciente_by_vexels
        }

        private void btnAU_Click(object sender, EventArgs e)
        {
            FrmUsuario fmusuario = new FrmUsuario();
            fmusuario.MdiParent = this;
            fmusuario.Show();
            //  this.Hide();
            // _1ParcialJP.Properties.Resources.d1f3ccc7e836617fb6e5db7fed1ae90b
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            abrirMenu();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            GBMenu.Hide();
            btnMenu.Visible = false;
        }
        private void abrirMenu()
        {
            button4.Visible = false;
            GBMenu.Show();
            btnMenu.Visible = true;
        }
    }
}
