﻿using System;
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
            FrmMenu menu = new FrmMenu();
            menu.abrirForm(fmTipoFarmaco);
        }

        private void FrmATF_Load(object sender, EventArgs e)
        {
            String[] ArrayTitulos = { "Disponible", "No Disponible", "Descontinuado", "En Prueba" };
            String[] ArrayValues = { "DISPONIBLE", "NO DISPNIBLE", "DESCONTINUADO", "EN PRUEBA" };
            Helper.llenarCBX(eSTADOComboBox, ArrayTitulos, ArrayValues);
            eSTADOComboBox.SelectedIndex = 0;
            this.ControlBox = false;
        }

        private void btnGguardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = $"INSERT INTO TIPO_FARMACO VALUES ( @descripcion , @estado )";
                SqlCommand command = new SqlCommand(sql);
                command.Parameters.AddWithValue("@descripcion", dESCRIPCIONTextBox.Text);
                command.Parameters.AddWithValue("@estado", eSTADOComboBox.SelectedValue.ToString());
                Helper.DoQueryExecuterLimpio(command);
                MessageBox.Show("Registro guardado con exito");
                this.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al guardar registro: " + er);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
