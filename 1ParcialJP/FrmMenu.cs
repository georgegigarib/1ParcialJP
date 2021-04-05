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
            //se verifica que el tipo de usuario que ingrese sea administrador, en caso de que no sea asi,
            // el boton para ingresar al FrmUsuario se hará invisible
            if (Program.tipo != "A")
            {
                btnAU.Visible = false;
            }
            //midContainer
            IsMdiContainer = true;

            //ESTE BLOQUE ASIGNA UNA IMAGEN A LOS BOTONES
            button3.Image = (Image)(new Bitmap(_1ParcialJP.Properties.Resources.pngkey_com_location_png_104244, new Size(30, 35)));
            btnMedicamento.Image = (Image)(new Bitmap(_1ParcialJP.Properties.Resources._234735, new Size(35, 35)));
            btnMedico.Image = (Image)(new Bitmap(_1ParcialJP.Properties.Resources.medico, new Size(40, 40)));
            btnMedicamento.Image = (Image)(new Bitmap(_1ParcialJP.Properties.Resources._234735, new Size(35, 35)));
            btnMarca.Image = (Image)(new Bitmap(_1ParcialJP.Properties.Resources.unnamed__3_1, new Size(40, 40)));
            btnVisitas.Image = (Image)(new Bitmap(_1ParcialJP.Properties.Resources._172ddc045ae1707a415adeae0543a5f0_icono_de_trazo_de_color_del_paciente_by_vexels, new Size(35, 35)));
            btnAU.Image = (Image)(new Bitmap(_1ParcialJP.Properties.Resources.d1f3ccc7e836617fb6e5db7fed1ae90b, new Size(30, 35)));
            button1.Image = (Image)(new Bitmap(_1ParcialJP.Properties.Resources.user_no_photo_300x3001, new Size(35, 35)));
            button2.Image = (Image)(new Bitmap(_1ParcialJP.Properties.Resources.pngjoy_com_medicamentos_salud_a_nivel_mundial_transparent_png_6610358, new Size(40, 40)));
            //FIN DEL BLOQUE

            //abrir el  menu
            abrirMenu();

            //cambia el color del midcontainer
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
        /////////////////////////////////////////////////////////////// <ABRIR FORMS>//////////////////////////////////////////////////////////////
        //cada boton llama a la funcion abrirForm la cual recibe el form que se desea abrir
        private void btnMedicamento_Click(object sender, EventArgs e)
        {
            FrmMedicamento fmmedico = new FrmMedicamento();
            abrirForm(fmmedico);
            // _1ParcialJP.Properties.Resources._234735
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            FrmMedico fmmedico = new FrmMedico();
            abrirForm(fmmedico);
            // _1ParcialJP.Properties.Resources.medico
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            FrmMarca fmmarca = new FrmMarca();
            abrirForm(fmmarca);
            // _1ParcialJP.Properties.Resources.unnamed__3_1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPaciente fmPaciente = new FrmPaciente();
            abrirForm(fmPaciente);
            // _1ParcialJP.Properties.Resources.user_no_photo_300x3001
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTipoFarmaco fmTipoFarmaco = new FrmTipoFarmaco();
            abrirForm(fmTipoFarmaco);
            // _1ParcialJP.Properties.Resources.pngjoy_com_medicamentos_salud_a_nivel_mundial_transparent_png_6610358
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUbicacion fmUbicacion = new FrmUbicacion();
            abrirForm(fmUbicacion);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmVisitas fmvisitas = new FrmVisitas();
            abrirForm(fmvisitas);
            // _1ParcialJP.Properties.Resources._172ddc045ae1707a415adeae0543a5f0_icono_de_trazo_de_color_del_paciente_by_vexels
        }

        private void btnAU_Click(object sender, EventArgs e)
        {
            FrmUsuario fmusuario = new FrmUsuario();
            abrirForm(fmusuario);
            // _1ParcialJP.Properties.Resources.d1f3ccc7e836617fb6e5db7fed1ae90b
        }

        /////////////////////////////////////////////////////////////// <summary>//////////////////////////////////////////////////////////////
        private void button4_Click_1(object sender, EventArgs e)
        {
            //actualmente desabilitado
            abrirMenu();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //actualmente desabilitado
            cerrarMenu();
        }
        public void abrirMenu()
        {
            //actualmente desabilitado
            button4.Visible = false;
            GBMenu.Show();
        }
        public void cerrarMenu()
        {
            //actualmente desabilitado
            button4.Visible = true;
            GBMenu.Hide();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*
         * esta funcion habre el form deseado, recibe el objeto del form
         */

        public void abrirForm(Form form)
        {
            FrmMenu fmMenu = new FrmMenu();
            //esto cuenta cuantos forms hay abiertos (childrens)
            int formCount = this.MdiChildren.Count();
            if (formCount != 0)
            {
                //por cada form  (childer) abierto, los cierra todos
                foreach (Form c in this.MdiChildren)
                {
                    c.Close();
                }
            }
            //convierte el dorm recibido y lo maximiza en el MDI
            //por ultimo da show al form
            form.MdiParent = FrmMenu.ActiveForm;
            form.WindowState = FormWindowState.Maximized;
            form.ControlBox = false;
            form.Show();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///al cerrar el form abre el form FrmLogin
        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.tipo = "";
            FrmLogin fmLogin = new FrmLogin();
            fmLogin.Show();
        }
    }
}
