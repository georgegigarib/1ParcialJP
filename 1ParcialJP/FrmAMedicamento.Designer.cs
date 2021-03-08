
namespace _1ParcialJP
{
    partial class FrmAMedicamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label dESCRIPCIONLabel;
            System.Windows.Forms.Label iD_TFLabel;
            System.Windows.Forms.Label iD_MARCALabel;
            System.Windows.Forms.Label iD_UBBICACIONLabel;
            System.Windows.Forms.Label dOSISLabel;
            System.Windows.Forms.Label eSTADOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAMedicamento));
            this.CBXtipoFarmaco = new System.Windows.Forms.ComboBox();
            this.CBXMarca = new System.Windows.Forms.ComboBox();
            this.CBXUbicacion = new System.Windows.Forms.ComboBox();
            this.eSTADOComboBox = new System.Windows.Forms.ComboBox();
            this.dESCRIPCIONTextBox = new System.Windows.Forms.TextBox();
            this.dOSISTextBox = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            dESCRIPCIONLabel = new System.Windows.Forms.Label();
            iD_TFLabel = new System.Windows.Forms.Label();
            iD_MARCALabel = new System.Windows.Forms.Label();
            iD_UBBICACIONLabel = new System.Windows.Forms.Label();
            dOSISLabel = new System.Windows.Forms.Label();
            eSTADOLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dESCRIPCIONLabel
            // 
            dESCRIPCIONLabel.AutoSize = true;
            dESCRIPCIONLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            dESCRIPCIONLabel.Location = new System.Drawing.Point(15, 26);
            dESCRIPCIONLabel.Name = "dESCRIPCIONLabel";
            dESCRIPCIONLabel.Size = new System.Drawing.Size(90, 15);
            dESCRIPCIONLabel.TabIndex = 26;
            dESCRIPCIONLabel.Text = "DESCRIPCION:";
            // 
            // iD_TFLabel
            // 
            iD_TFLabel.AutoSize = true;
            iD_TFLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            iD_TFLabel.Location = new System.Drawing.Point(15, 145);
            iD_TFLabel.Name = "iD_TFLabel";
            iD_TFLabel.Size = new System.Drawing.Size(104, 15);
            iD_TFLabel.TabIndex = 28;
            iD_TFLabel.Text = "TIPO FARMACO:";
            // 
            // iD_MARCALabel
            // 
            iD_MARCALabel.AutoSize = true;
            iD_MARCALabel.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            iD_MARCALabel.Location = new System.Drawing.Point(332, 65);
            iD_MARCALabel.Name = "iD_MARCALabel";
            iD_MARCALabel.Size = new System.Drawing.Size(58, 15);
            iD_MARCALabel.TabIndex = 29;
            iD_MARCALabel.Text = "MARCA:";
            // 
            // iD_UBBICACIONLabel
            // 
            iD_UBBICACIONLabel.AutoSize = true;
            iD_UBBICACIONLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            iD_UBBICACIONLabel.Location = new System.Drawing.Point(332, 29);
            iD_UBBICACIONLabel.Name = "iD_UBBICACIONLabel";
            iD_UBBICACIONLabel.Size = new System.Drawing.Size(79, 15);
            iD_UBBICACIONLabel.TabIndex = 30;
            iD_UBBICACIONLabel.Text = "UBICACION:";
            // 
            // dOSISLabel
            // 
            dOSISLabel.AutoSize = true;
            dOSISLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dOSISLabel.Location = new System.Drawing.Point(15, 61);
            dOSISLabel.Name = "dOSISLabel";
            dOSISLabel.Size = new System.Drawing.Size(52, 16);
            dOSISLabel.TabIndex = 31;
            dOSISLabel.Text = "DOSIS:";
            // 
            // eSTADOLabel
            // 
            eSTADOLabel.AutoSize = true;
            eSTADOLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            eSTADOLabel.Location = new System.Drawing.Point(15, 97);
            eSTADOLabel.Name = "eSTADOLabel";
            eSTADOLabel.Size = new System.Drawing.Size(59, 15);
            eSTADOLabel.TabIndex = 33;
            eSTADOLabel.Text = "ESTADO:";
            // 
            // CBXtipoFarmaco
            // 
            this.CBXtipoFarmaco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXtipoFarmaco.FormattingEnabled = true;
            this.CBXtipoFarmaco.Location = new System.Drawing.Point(125, 140);
            this.CBXtipoFarmaco.Name = "CBXtipoFarmaco";
            this.CBXtipoFarmaco.Size = new System.Drawing.Size(198, 21);
            this.CBXtipoFarmaco.TabIndex = 37;
            // 
            // CBXMarca
            // 
            this.CBXMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXMarca.FormattingEnabled = true;
            this.CBXMarca.Location = new System.Drawing.Point(442, 61);
            this.CBXMarca.Name = "CBXMarca";
            this.CBXMarca.Size = new System.Drawing.Size(198, 21);
            this.CBXMarca.TabIndex = 36;
            // 
            // CBXUbicacion
            // 
            this.CBXUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXUbicacion.FormattingEnabled = true;
            this.CBXUbicacion.Location = new System.Drawing.Point(442, 26);
            this.CBXUbicacion.Name = "CBXUbicacion";
            this.CBXUbicacion.Size = new System.Drawing.Size(198, 21);
            this.CBXUbicacion.TabIndex = 35;
            // 
            // eSTADOComboBox
            // 
            this.eSTADOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eSTADOComboBox.FormattingEnabled = true;
            this.eSTADOComboBox.Items.AddRange(new object[] {
            "DISPONIBLE",
            "DESCONTINUADO",
            "AGOTADO",
            "NO DISPONIBLE"});
            this.eSTADOComboBox.Location = new System.Drawing.Point(125, 94);
            this.eSTADOComboBox.Name = "eSTADOComboBox";
            this.eSTADOComboBox.Size = new System.Drawing.Size(194, 21);
            this.eSTADOComboBox.TabIndex = 34;
            // 
            // dESCRIPCIONTextBox
            // 
            this.dESCRIPCIONTextBox.Location = new System.Drawing.Point(125, 23);
            this.dESCRIPCIONTextBox.Name = "dESCRIPCIONTextBox";
            this.dESCRIPCIONTextBox.Size = new System.Drawing.Size(194, 20);
            this.dESCRIPCIONTextBox.TabIndex = 27;
            // 
            // dOSISTextBox
            // 
            this.dOSISTextBox.Location = new System.Drawing.Point(125, 58);
            this.dOSISTextBox.Name = "dOSISTextBox";
            this.dOSISTextBox.Size = new System.Drawing.Size(194, 20);
            this.dOSISTextBox.TabIndex = 32;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::_1ParcialJP.Properties.Resources.save_icon;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(565, 97);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 67);
            this.btnGuardar.TabIndex = 38;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmAMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(652, 185);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.CBXtipoFarmaco);
            this.Controls.Add(this.CBXMarca);
            this.Controls.Add(this.CBXUbicacion);
            this.Controls.Add(this.eSTADOComboBox);
            this.Controls.Add(dESCRIPCIONLabel);
            this.Controls.Add(this.dESCRIPCIONTextBox);
            this.Controls.Add(iD_TFLabel);
            this.Controls.Add(iD_MARCALabel);
            this.Controls.Add(iD_UBBICACIONLabel);
            this.Controls.Add(dOSISLabel);
            this.Controls.Add(this.dOSISTextBox);
            this.Controls.Add(eSTADOLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAMedicamento";
            this.Text = "Agregar Medicamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAMedicamento_FormClosed);
            this.Load += new System.EventHandler(this.FrmAMedicamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBXtipoFarmaco;
        private System.Windows.Forms.ComboBox CBXMarca;
        private System.Windows.Forms.ComboBox CBXUbicacion;
        private System.Windows.Forms.ComboBox eSTADOComboBox;
        private System.Windows.Forms.TextBox dESCRIPCIONTextBox;
        private System.Windows.Forms.TextBox dOSISTextBox;
        private System.Windows.Forms.Button btnGuardar;
    }
}