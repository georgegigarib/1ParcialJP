
namespace _1ParcialJP
{
    partial class FrmMedicamento
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_MEDICAMENTOLabel;
            System.Windows.Forms.Label dESCRIPCIONLabel;
            System.Windows.Forms.Label iD_TFLabel;
            System.Windows.Forms.Label iD_MARCALabel;
            System.Windows.Forms.Label iD_UBBICACIONLabel;
            System.Windows.Forms.Label dOSISLabel;
            System.Windows.Forms.Label eSTADOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedicamento));
            this.mEDICAMENTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDICAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pARCIALJPDataSet = new _1ParcialJP.PARCIALJPDataSet();
            this.iD_MEDICAMENTOTextBox = new System.Windows.Forms.TextBox();
            this.dESCRIPCIONTextBox = new System.Windows.Forms.TextBox();
            this.dOSISTextBox = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGguardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.eSTADOComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBXUbicacion = new System.Windows.Forms.ComboBox();
            this.mEDICAMENTOTableAdapter = new _1ParcialJP.PARCIALJPDataSetTableAdapters.MEDICAMENTOTableAdapter();
            this.tableAdapterManager = new _1ParcialJP.PARCIALJPDataSetTableAdapters.TableAdapterManager();
            this.uBICACIONTableAdapter = new _1ParcialJP.PARCIALJPDataSetTableAdapters.UBICACIONTableAdapter();
            this.uBICACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CBXMarca = new System.Windows.Forms.ComboBox();
            this.CBXtipoFarmaco = new System.Windows.Forms.ComboBox();
            iD_MEDICAMENTOLabel = new System.Windows.Forms.Label();
            dESCRIPCIONLabel = new System.Windows.Forms.Label();
            iD_TFLabel = new System.Windows.Forms.Label();
            iD_MARCALabel = new System.Windows.Forms.Label();
            iD_UBBICACIONLabel = new System.Windows.Forms.Label();
            dOSISLabel = new System.Windows.Forms.Label();
            eSTADOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uBICACIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_MEDICAMENTOLabel
            // 
            iD_MEDICAMENTOLabel.AutoSize = true;
            iD_MEDICAMENTOLabel.Location = new System.Drawing.Point(19, 17);
            iD_MEDICAMENTOLabel.Name = "iD_MEDICAMENTOLabel";
            iD_MEDICAMENTOLabel.Size = new System.Drawing.Size(121, 15);
            iD_MEDICAMENTOLabel.TabIndex = 2;
            iD_MEDICAMENTOLabel.Text = "ID MEDICAMENTO:";
            // 
            // dESCRIPCIONLabel
            // 
            dESCRIPCIONLabel.AutoSize = true;
            dESCRIPCIONLabel.Location = new System.Drawing.Point(19, 54);
            dESCRIPCIONLabel.Name = "dESCRIPCIONLabel";
            dESCRIPCIONLabel.Size = new System.Drawing.Size(90, 15);
            dESCRIPCIONLabel.TabIndex = 4;
            dESCRIPCIONLabel.Text = "DESCRIPCION:";
            // 
            // iD_TFLabel
            // 
            iD_TFLabel.AutoSize = true;
            iD_TFLabel.Location = new System.Drawing.Point(414, 20);
            iD_TFLabel.Name = "iD_TFLabel";
            iD_TFLabel.Size = new System.Drawing.Size(104, 15);
            iD_TFLabel.TabIndex = 6;
            iD_TFLabel.Text = "TIPO FARMACO:";
            iD_TFLabel.Click += new System.EventHandler(this.iD_TFLabel_Click);
            // 
            // iD_MARCALabel
            // 
            iD_MARCALabel.AutoSize = true;
            iD_MARCALabel.Location = new System.Drawing.Point(414, 50);
            iD_MARCALabel.Name = "iD_MARCALabel";
            iD_MARCALabel.Size = new System.Drawing.Size(58, 15);
            iD_MARCALabel.TabIndex = 8;
            iD_MARCALabel.Text = "MARCA:";
            // 
            // iD_UBBICACIONLabel
            // 
            iD_UBBICACIONLabel.AutoSize = true;
            iD_UBBICACIONLabel.Location = new System.Drawing.Point(414, 80);
            iD_UBBICACIONLabel.Name = "iD_UBBICACIONLabel";
            iD_UBBICACIONLabel.Size = new System.Drawing.Size(79, 15);
            iD_UBBICACIONLabel.TabIndex = 10;
            iD_UBBICACIONLabel.Text = "UBICACION:";
            // 
            // dOSISLabel
            // 
            dOSISLabel.AutoSize = true;
            dOSISLabel.Location = new System.Drawing.Point(19, 95);
            dOSISLabel.Name = "dOSISLabel";
            dOSISLabel.Size = new System.Drawing.Size(46, 15);
            dOSISLabel.TabIndex = 12;
            dOSISLabel.Text = "DOSIS:";
            dOSISLabel.Click += new System.EventHandler(this.dOSISLabel_Click);
            // 
            // eSTADOLabel
            // 
            eSTADOLabel.AutoSize = true;
            eSTADOLabel.Location = new System.Drawing.Point(19, 136);
            eSTADOLabel.Name = "eSTADOLabel";
            eSTADOLabel.Size = new System.Drawing.Size(59, 15);
            eSTADOLabel.TabIndex = 14;
            eSTADOLabel.Text = "ESTADO:";
            // 
            // mEDICAMENTODataGridView
            // 
            this.mEDICAMENTODataGridView.AutoGenerateColumns = false;
            this.mEDICAMENTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mEDICAMENTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.mEDICAMENTODataGridView.DataSource = this.mEDICAMENTOBindingSource;
            this.mEDICAMENTODataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mEDICAMENTODataGridView.Location = new System.Drawing.Point(0, 0);
            this.mEDICAMENTODataGridView.Name = "mEDICAMENTODataGridView";
            this.mEDICAMENTODataGridView.Size = new System.Drawing.Size(887, 327);
            this.mEDICAMENTODataGridView.TabIndex = 1;
            this.mEDICAMENTODataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mEDICAMENTODataGridView_CellContentClick_1); // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_MEDICAMENTO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_MEDICAMENTO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 147;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DESCRIPCION";
            this.dataGridViewTextBoxColumn2.HeaderText = "DESCRIPCION";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 112;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_TF";
            this.dataGridViewTextBoxColumn3.HeaderText = "TIPO_FARMACO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_MARCA";
            this.dataGridViewTextBoxColumn4.HeaderText = "MARCA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_UBBICACION";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID_UBBICACION";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 129;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DOSIS";
            this.dataGridViewTextBoxColumn6.HeaderText = "DOSIS";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ESTADO";
            this.dataGridViewTextBoxColumn7.HeaderText = "ESTADO";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // mEDICAMENTOBindingSource
            // 
            this.mEDICAMENTOBindingSource.DataMember = "MEDICAMENTO";
            this.mEDICAMENTOBindingSource.DataSource = this.pARCIALJPDataSet;
            // 
            // pARCIALJPDataSet
            // 
            this.pARCIALJPDataSet.DataSetName = "PARCIALJPDataSet";
            this.pARCIALJPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iD_MEDICAMENTOTextBox
            // 
            this.iD_MEDICAMENTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDICAMENTOBindingSource, "ID_MEDICAMENTO", true));
            this.iD_MEDICAMENTOTextBox.Location = new System.Drawing.Point(147, 14);
            this.iD_MEDICAMENTOTextBox.Name = "iD_MEDICAMENTOTextBox";
            this.iD_MEDICAMENTOTextBox.ReadOnly = true;
            this.iD_MEDICAMENTOTextBox.Size = new System.Drawing.Size(226, 22);
            this.iD_MEDICAMENTOTextBox.TabIndex = 3;
            // 
            // dESCRIPCIONTextBox
            // 
            this.dESCRIPCIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDICAMENTOBindingSource, "DESCRIPCION", true));
            this.dESCRIPCIONTextBox.Location = new System.Drawing.Point(147, 51);
            this.dESCRIPCIONTextBox.Name = "dESCRIPCIONTextBox";
            this.dESCRIPCIONTextBox.Size = new System.Drawing.Size(226, 22);
            this.dESCRIPCIONTextBox.TabIndex = 5;
            // 
            // dOSISTextBox
            // 
            this.dOSISTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDICAMENTOBindingSource, "DOSIS", true));
            this.dOSISTextBox.Location = new System.Drawing.Point(147, 91);
            this.dOSISTextBox.Name = "dOSISTextBox";
            this.dOSISTextBox.Size = new System.Drawing.Size(226, 22);
            this.dOSISTextBox.TabIndex = 13;
            this.dOSISTextBox.TextChanged += new System.EventHandler(this.dOSISTextBox_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::_1ParcialJP.Properties.Resources.unnamed__2_;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(858, 8);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(54, 61);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGguardar
            // 
            this.btnGguardar.BackgroundImage = global::_1ParcialJP.Properties.Resources.save_icon;
            this.btnGguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGguardar.Location = new System.Drawing.Point(790, 7);
            this.btnGguardar.Name = "btnGguardar";
            this.btnGguardar.Size = new System.Drawing.Size(62, 62);
            this.btnGguardar.TabIndex = 17;
            this.btnGguardar.UseVisualStyleBackColor = true;
            this.btnGguardar.Click += new System.EventHandler(this.btnGguardar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::_1ParcialJP.Properties.Resources.add_1_icon__flatastic_1_iconset__custom_icon_design_0;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(824, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 62);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eSTADOComboBox
            // 
            this.eSTADOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDICAMENTOBindingSource, "ESTADO", true));
            this.eSTADOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eSTADOComboBox.FormattingEnabled = true;
            this.eSTADOComboBox.Items.AddRange(new object[] {
            "DISPONIBLE",
            "DESCONTINUADO",
            "AGOTADO",
            "NO DISPONIBLE"});
            this.eSTADOComboBox.Location = new System.Drawing.Point(147, 133);
            this.eSTADOComboBox.Name = "eSTADOComboBox";
            this.eSTADOComboBox.Size = new System.Drawing.Size(226, 23);
            this.eSTADOComboBox.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mEDICAMENTODataGridView);
            this.panel1.Location = new System.Drawing.Point(14, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 327);
            this.panel1.TabIndex = 20;
            // 
            // CBXUbicacion
            // 
            this.CBXUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXUbicacion.FormattingEnabled = true;
            this.CBXUbicacion.Location = new System.Drawing.Point(542, 76);
            this.CBXUbicacion.Name = "CBXUbicacion";
            this.CBXUbicacion.Size = new System.Drawing.Size(230, 23);
            this.CBXUbicacion.TabIndex = 21;
            // 
            // mEDICAMENTOTableAdapter
            // 
            this.mEDICAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MARCATableAdapter = null;
            this.tableAdapterManager.MEDICAMENTOTableAdapter = this.mEDICAMENTOTableAdapter;
            this.tableAdapterManager.MEDICOTableAdapter = null;
            this.tableAdapterManager.PACIENTETableAdapter = null;
            this.tableAdapterManager.TIPO_FARMACOTableAdapter = null;
            this.tableAdapterManager.UBICACIONTableAdapter = this.uBICACIONTableAdapter;
            this.tableAdapterManager.UpdateOrder = _1ParcialJP.PARCIALJPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VISITATableAdapter = null;
            // 
            // uBICACIONTableAdapter
            // 
            this.uBICACIONTableAdapter.ClearBeforeFill = true;
            // 
            // uBICACIONBindingSource
            // 
            this.uBICACIONBindingSource.DataMember = "UBICACION";
            this.uBICACIONBindingSource.DataSource = this.pARCIALJPDataSet;
            // 
            // CBXMarca
            // 
            this.CBXMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXMarca.FormattingEnabled = true;
            this.CBXMarca.Location = new System.Drawing.Point(542, 45);
            this.CBXMarca.Name = "CBXMarca";
            this.CBXMarca.Size = new System.Drawing.Size(230, 23);
            this.CBXMarca.TabIndex = 22;
            // 
            // CBXtipoFarmaco
            // 
            this.CBXtipoFarmaco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXtipoFarmaco.FormattingEnabled = true;
            this.CBXtipoFarmaco.Location = new System.Drawing.Point(542, 14);
            this.CBXtipoFarmaco.Name = "CBXtipoFarmaco";
            this.CBXtipoFarmaco.Size = new System.Drawing.Size(230, 23);
            this.CBXtipoFarmaco.TabIndex = 23;
            // 
            // FrmMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(924, 530);
            this.Controls.Add(this.CBXtipoFarmaco);
            this.Controls.Add(this.CBXMarca);
            this.Controls.Add(this.CBXUbicacion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.eSTADOComboBox);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGguardar);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_MEDICAMENTOLabel);
            this.Controls.Add(this.iD_MEDICAMENTOTextBox);
            this.Controls.Add(dESCRIPCIONLabel);
            this.Controls.Add(this.dESCRIPCIONTextBox);
            this.Controls.Add(iD_TFLabel);
            this.Controls.Add(iD_MARCALabel);
            this.Controls.Add(iD_UBBICACIONLabel);
            this.Controls.Add(dOSISLabel);
            this.Controls.Add(this.dOSISTextBox);
            this.Controls.Add(eSTADOLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMedicamento";
            this.Text = "Medicamentos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMedicamento_FormClosed);
            this.Load += new System.EventHandler(this.FrmMedicamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uBICACIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PARCIALJPDataSet pARCIALJPDataSet;
        private System.Windows.Forms.BindingSource mEDICAMENTOBindingSource;
        private PARCIALJPDataSetTableAdapters.MEDICAMENTOTableAdapter mEDICAMENTOTableAdapter;
        private PARCIALJPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView mEDICAMENTODataGridView;
        private System.Windows.Forms.TextBox iD_MEDICAMENTOTextBox;
        private System.Windows.Forms.TextBox dESCRIPCIONTextBox;
        private System.Windows.Forms.TextBox dOSISTextBox;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGguardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox eSTADOComboBox;
        private System.Windows.Forms.Panel panel1;
        private PARCIALJPDataSetTableAdapters.UBICACIONTableAdapter uBICACIONTableAdapter;
        private System.Windows.Forms.BindingSource uBICACIONBindingSource;
        private System.Windows.Forms.ComboBox CBXUbicacion;
        private System.Windows.Forms.ComboBox CBXMarca;
        private System.Windows.Forms.ComboBox CBXtipoFarmaco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}