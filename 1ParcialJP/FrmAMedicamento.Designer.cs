
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAMedicamento));
            this.CBXtipoFarmaco = new System.Windows.Forms.ComboBox();
            this.CBXMarca = new System.Windows.Forms.ComboBox();
            this.CBXUbicacion = new System.Windows.Forms.ComboBox();
            this.eSTADOComboBox = new System.Windows.Forms.ComboBox();
            this.dESCRIPCIONTextBox = new System.Windows.Forms.TextBox();
            this.dOSISTextBox = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            dESCRIPCIONLabel = new System.Windows.Forms.Label();
            iD_TFLabel = new System.Windows.Forms.Label();
            iD_MARCALabel = new System.Windows.Forms.Label();
            iD_UBBICACIONLabel = new System.Windows.Forms.Label();
            dOSISLabel = new System.Windows.Forms.Label();
            eSTADOLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dESCRIPCIONLabel
            // 
            dESCRIPCIONLabel.AutoSize = true;
            dESCRIPCIONLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            dESCRIPCIONLabel.Location = new System.Drawing.Point(18, 22);
            dESCRIPCIONLabel.Name = "dESCRIPCIONLabel";
            dESCRIPCIONLabel.Size = new System.Drawing.Size(90, 15);
            dESCRIPCIONLabel.TabIndex = 26;
            dESCRIPCIONLabel.Text = "DESCRIPCION:";
            // 
            // iD_TFLabel
            // 
            iD_TFLabel.AutoSize = true;
            iD_TFLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            iD_TFLabel.Location = new System.Drawing.Point(18, 208);
            iD_TFLabel.Name = "iD_TFLabel";
            iD_TFLabel.Size = new System.Drawing.Size(104, 15);
            iD_TFLabel.TabIndex = 28;
            iD_TFLabel.Text = "TIPO FARMACO:";
            // 
            // iD_MARCALabel
            // 
            iD_MARCALabel.AutoSize = true;
            iD_MARCALabel.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            iD_MARCALabel.Location = new System.Drawing.Point(18, 171);
            iD_MARCALabel.Name = "iD_MARCALabel";
            iD_MARCALabel.Size = new System.Drawing.Size(58, 15);
            iD_MARCALabel.TabIndex = 29;
            iD_MARCALabel.Text = "MARCA:";
            // 
            // iD_UBBICACIONLabel
            // 
            iD_UBBICACIONLabel.AutoSize = true;
            iD_UBBICACIONLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            iD_UBBICACIONLabel.Location = new System.Drawing.Point(18, 131);
            iD_UBBICACIONLabel.Name = "iD_UBBICACIONLabel";
            iD_UBBICACIONLabel.Size = new System.Drawing.Size(79, 15);
            iD_UBBICACIONLabel.TabIndex = 30;
            iD_UBBICACIONLabel.Text = "UBICACION:";
            // 
            // dOSISLabel
            // 
            dOSISLabel.AutoSize = true;
            dOSISLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dOSISLabel.Location = new System.Drawing.Point(18, 54);
            dOSISLabel.Name = "dOSISLabel";
            dOSISLabel.Size = new System.Drawing.Size(52, 16);
            dOSISLabel.TabIndex = 31;
            dOSISLabel.Text = "DOSIS:";
            // 
            // eSTADOLabel
            // 
            eSTADOLabel.AutoSize = true;
            eSTADOLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            eSTADOLabel.Location = new System.Drawing.Point(18, 96);
            eSTADOLabel.Name = "eSTADOLabel";
            eSTADOLabel.Size = new System.Drawing.Size(59, 15);
            eSTADOLabel.TabIndex = 33;
            eSTADOLabel.Text = "ESTADO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            label1.Location = new System.Drawing.Point(18, 244);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 15);
            label1.TabIndex = 39;
            label1.Text = "CANTIDAD:";
            // 
            // CBXtipoFarmaco
            // 
            this.CBXtipoFarmaco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXtipoFarmaco.FormattingEnabled = true;
            this.CBXtipoFarmaco.Location = new System.Drawing.Point(128, 203);
            this.CBXtipoFarmaco.Name = "CBXtipoFarmaco";
            this.CBXtipoFarmaco.Size = new System.Drawing.Size(198, 21);
            this.CBXtipoFarmaco.TabIndex = 37;
            // 
            // CBXMarca
            // 
            this.CBXMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXMarca.FormattingEnabled = true;
            this.CBXMarca.Location = new System.Drawing.Point(128, 167);
            this.CBXMarca.Name = "CBXMarca";
            this.CBXMarca.Size = new System.Drawing.Size(198, 21);
            this.CBXMarca.TabIndex = 36;
            // 
            // CBXUbicacion
            // 
            this.CBXUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXUbicacion.FormattingEnabled = true;
            this.CBXUbicacion.Location = new System.Drawing.Point(128, 128);
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
            this.eSTADOComboBox.Location = new System.Drawing.Point(128, 90);
            this.eSTADOComboBox.Name = "eSTADOComboBox";
            this.eSTADOComboBox.Size = new System.Drawing.Size(198, 21);
            this.eSTADOComboBox.TabIndex = 34;
            // 
            // dESCRIPCIONTextBox
            // 
            this.dESCRIPCIONTextBox.Location = new System.Drawing.Point(128, 19);
            this.dESCRIPCIONTextBox.Name = "dESCRIPCIONTextBox";
            this.dESCRIPCIONTextBox.Size = new System.Drawing.Size(198, 20);
            this.dESCRIPCIONTextBox.TabIndex = 27;
            // 
            // dOSISTextBox
            // 
            this.dOSISTextBox.Location = new System.Drawing.Point(128, 54);
            this.dOSISTextBox.Name = "dOSISTextBox";
            this.dOSISTextBox.Size = new System.Drawing.Size(198, 20);
            this.dOSISTextBox.TabIndex = 32;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::_1ParcialJP.Properties.Resources.save_icon;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(366, 192);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 67);
            this.btnGuardar.TabIndex = 38;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.dESCRIPCIONTextBox);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(eSTADOLabel);
            this.groupBox1.Controls.Add(this.CBXtipoFarmaco);
            this.groupBox1.Controls.Add(this.dOSISTextBox);
            this.groupBox1.Controls.Add(this.CBXMarca);
            this.groupBox1.Controls.Add(dOSISLabel);
            this.groupBox1.Controls.Add(this.CBXUbicacion);
            this.groupBox1.Controls.Add(iD_UBBICACIONLabel);
            this.groupBox1.Controls.Add(this.eSTADOComboBox);
            this.groupBox1.Controls.Add(iD_MARCALabel);
            this.groupBox1.Controls.Add(dESCRIPCIONLabel);
            this.groupBox1.Controls.Add(iD_TFLabel);
            this.groupBox1.Location = new System.Drawing.Point(217, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 280);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Medicamento";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(128, 238);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(139, 20);
            this.txtcantidad.TabIndex = 40;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.BackgroundImage = global::_1ParcialJP.Properties.Resources.red_go_back_arrow;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Location = new System.Drawing.Point(698, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 40);
            this.button3.TabIndex = 40;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmAMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1041, 456);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAMedicamento";
            this.Text = "Agregar Medicamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAMedicamento_FormClosed);
            this.Load += new System.EventHandler(this.FrmAMedicamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
         
        private System.Windows.Forms.ComboBox CBXtipoFarmaco;
        private System.Windows.Forms.ComboBox CBXMarca;
        private System.Windows.Forms.ComboBox CBXUbicacion;
        private System.Windows.Forms.ComboBox eSTADOComboBox;
        private System.Windows.Forms.TextBox dESCRIPCIONTextBox;
        private System.Windows.Forms.TextBox dOSISTextBox;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown txtcantidad;
    }
}