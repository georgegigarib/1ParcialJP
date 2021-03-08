
namespace _1ParcialJP
{
    partial class FrmVisitas
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
            System.Windows.Forms.Label iD_VISITALabel;
            System.Windows.Forms.Label nOMBRE_MEDICOLabel;
            System.Windows.Forms.Label nOMBRE_PACIENTELabel;
            System.Windows.Forms.Label fECHALabel;
            System.Windows.Forms.Label hORALabel;
            System.Windows.Forms.Label sINTOMASLabel;
            System.Windows.Forms.Label mEDICAMENTOSLabel;
            System.Windows.Forms.Label rECOMENDACIONESLabel;
            System.Windows.Forms.Label eSTADOLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisitas));
            this.pARCIALJPDataSet = new _1ParcialJP.PARCIALJPDataSet();
            this.vISITABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vISITATableAdapter = new _1ParcialJP.PARCIALJPDataSetTableAdapters.VISITATableAdapter();
            this.tableAdapterManager = new _1ParcialJP.PARCIALJPDataSetTableAdapters.TableAdapterManager();
            this.vISITADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_VISITATextBox = new System.Windows.Forms.TextBox();
            this.fECHADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sINTOMASTextBox = new System.Windows.Forms.TextBox();
            this.mEDICAMENTOSTextBox = new System.Windows.Forms.TextBox();
            this.rECOMENDACIONESTextBox = new System.Windows.Forms.TextBox();
            this.eSTADOTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hORADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.CBXPACIENTE = new System.Windows.Forms.ComboBox();
            this.nOMBRE_MEDICOComboBox = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGguardar = new System.Windows.Forms.Button();
            iD_VISITALabel = new System.Windows.Forms.Label();
            nOMBRE_MEDICOLabel = new System.Windows.Forms.Label();
            nOMBRE_PACIENTELabel = new System.Windows.Forms.Label();
            fECHALabel = new System.Windows.Forms.Label();
            hORALabel = new System.Windows.Forms.Label();
            sINTOMASLabel = new System.Windows.Forms.Label();
            mEDICAMENTOSLabel = new System.Windows.Forms.Label();
            rECOMENDACIONESLabel = new System.Windows.Forms.Label();
            eSTADOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISITABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISITADataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_VISITALabel
            // 
            iD_VISITALabel.AutoSize = true;
            iD_VISITALabel.Location = new System.Drawing.Point(13, 27);
            iD_VISITALabel.Name = "iD_VISITALabel";
            iD_VISITALabel.Size = new System.Drawing.Size(66, 15);
            iD_VISITALabel.TabIndex = 2;
            iD_VISITALabel.Text = "ID VISITA:";
            // 
            // nOMBRE_MEDICOLabel
            // 
            nOMBRE_MEDICOLabel.AutoSize = true;
            nOMBRE_MEDICOLabel.Location = new System.Drawing.Point(13, 63);
            nOMBRE_MEDICOLabel.Name = "nOMBRE_MEDICOLabel";
            nOMBRE_MEDICOLabel.Size = new System.Drawing.Size(115, 15);
            nOMBRE_MEDICOLabel.TabIndex = 4;
            nOMBRE_MEDICOLabel.Text = "NOMBRE MEDICO:";
            // 
            // nOMBRE_PACIENTELabel
            // 
            nOMBRE_PACIENTELabel.AutoSize = true;
            nOMBRE_PACIENTELabel.Location = new System.Drawing.Point(13, 97);
            nOMBRE_PACIENTELabel.Name = "nOMBRE_PACIENTELabel";
            nOMBRE_PACIENTELabel.Size = new System.Drawing.Size(125, 15);
            nOMBRE_PACIENTELabel.TabIndex = 6;
            nOMBRE_PACIENTELabel.Text = "NOMBRE PACIENTE:";
            // 
            // fECHALabel
            // 
            fECHALabel.AutoSize = true;
            fECHALabel.Location = new System.Drawing.Point(414, 24);
            fECHALabel.Name = "fECHALabel";
            fECHALabel.Size = new System.Drawing.Size(51, 15);
            fECHALabel.TabIndex = 8;
            fECHALabel.Text = "FECHA:";
            // 
            // hORALabel
            // 
            hORALabel.AutoSize = true;
            hORALabel.Location = new System.Drawing.Point(414, 68);
            hORALabel.Name = "hORALabel";
            hORALabel.Size = new System.Drawing.Size(46, 15);
            hORALabel.TabIndex = 10;
            hORALabel.Text = "HORA:";
            // 
            // sINTOMASLabel
            // 
            sINTOMASLabel.AutoSize = true;
            sINTOMASLabel.Location = new System.Drawing.Point(414, 100);
            sINTOMASLabel.Name = "sINTOMASLabel";
            sINTOMASLabel.Size = new System.Drawing.Size(76, 15);
            sINTOMASLabel.TabIndex = 12;
            sINTOMASLabel.Text = "SINTOMAS:";
            // 
            // mEDICAMENTOSLabel
            // 
            mEDICAMENTOSLabel.AutoSize = true;
            mEDICAMENTOSLabel.Location = new System.Drawing.Point(703, 95);
            mEDICAMENTOSLabel.Name = "mEDICAMENTOSLabel";
            mEDICAMENTOSLabel.Size = new System.Drawing.Size(112, 15);
            mEDICAMENTOSLabel.TabIndex = 14;
            mEDICAMENTOSLabel.Text = "MEDICAMENTOS:";
            // 
            // rECOMENDACIONESLabel
            // 
            rECOMENDACIONESLabel.AutoSize = true;
            rECOMENDACIONESLabel.Location = new System.Drawing.Point(703, 23);
            rECOMENDACIONESLabel.Name = "rECOMENDACIONESLabel";
            rECOMENDACIONESLabel.Size = new System.Drawing.Size(133, 15);
            rECOMENDACIONESLabel.TabIndex = 16;
            rECOMENDACIONESLabel.Text = "RECOMENDACIONES:";
            // 
            // eSTADOLabel
            // 
            eSTADOLabel.AutoSize = true;
            eSTADOLabel.Location = new System.Drawing.Point(13, 134);
            eSTADOLabel.Name = "eSTADOLabel";
            eSTADOLabel.Size = new System.Drawing.Size(59, 15);
            eSTADOLabel.TabIndex = 18;
            eSTADOLabel.Text = "ESTADO:";
            // 
            // pARCIALJPDataSet
            // 
            this.pARCIALJPDataSet.DataSetName = "PARCIALJPDataSet";
            this.pARCIALJPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vISITABindingSource
            // 
            this.vISITABindingSource.DataMember = "VISITA";
            this.vISITABindingSource.DataSource = this.pARCIALJPDataSet;
            // 
            // vISITATableAdapter
            // 
            this.vISITATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MARCATableAdapter = null;
            this.tableAdapterManager.MEDICAMENTOTableAdapter = null;
            this.tableAdapterManager.MEDICOTableAdapter = null;
            this.tableAdapterManager.PACIENTETableAdapter = null;
            this.tableAdapterManager.TIPO_FARMACOTableAdapter = null;
            this.tableAdapterManager.UBICACIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _1ParcialJP.PARCIALJPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VISITATableAdapter = this.vISITATableAdapter;
            // 
            // vISITADataGridView
            // 
            this.vISITADataGridView.AllowUserToAddRows = false;
            this.vISITADataGridView.AllowUserToDeleteRows = false;
            this.vISITADataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vISITADataGridView.AutoGenerateColumns = false;
            this.vISITADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vISITADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.vISITADataGridView.DataSource = this.vISITABindingSource;
            this.vISITADataGridView.Location = new System.Drawing.Point(0, 0);
            this.vISITADataGridView.Name = "vISITADataGridView";
            this.vISITADataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.vISITADataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.vISITADataGridView.Size = new System.Drawing.Size(1133, 280);
            this.vISITADataGridView.TabIndex = 1;
            this.vISITADataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vISITADataGridView_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_VISITA";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_VISITA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE_MEDICO";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE_MEDICO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 141;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NOMBRE_PACIENTE";
            this.dataGridViewTextBoxColumn3.HeaderText = "NOMBRE_PACIENTE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 151;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FECHA";
            this.dataGridViewTextBoxColumn4.HeaderText = "FECHA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HORA";
            this.dataGridViewTextBoxColumn5.HeaderText = "HORA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SINTOMAS";
            this.dataGridViewTextBoxColumn6.HeaderText = "SINTOMAS";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MEDICAMENTOS";
            this.dataGridViewTextBoxColumn7.HeaderText = "MEDICAMENTOS";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 134;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RECOMENDACIONES";
            this.dataGridViewTextBoxColumn8.HeaderText = "RECOMENDACIONES";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 155;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ESTADO";
            this.dataGridViewTextBoxColumn9.HeaderText = "ESTADO";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // iD_VISITATextBox
            // 
            this.iD_VISITATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vISITABindingSource, "ID_VISITA", true));
            this.iD_VISITATextBox.Enabled = false;
            this.iD_VISITATextBox.Location = new System.Drawing.Point(159, 23);
            this.iD_VISITATextBox.Name = "iD_VISITATextBox";
            this.iD_VISITATextBox.Size = new System.Drawing.Size(233, 22);
            this.iD_VISITATextBox.TabIndex = 3;
            // 
            // fECHADateTimePicker
            // 
            this.fECHADateTimePicker.Checked = false;
            this.fECHADateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.fECHADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vISITABindingSource, "FECHA", true));
            this.fECHADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fECHADateTimePicker.Location = new System.Drawing.Point(502, 20);
            this.fECHADateTimePicker.Name = "fECHADateTimePicker";
            this.fECHADateTimePicker.Size = new System.Drawing.Size(140, 22);
            this.fECHADateTimePicker.TabIndex = 9;
            this.fECHADateTimePicker.Value = new System.DateTime(2021, 2, 13, 0, 0, 0, 0);
            // 
            // sINTOMASTextBox
            // 
            this.sINTOMASTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vISITABindingSource, "SINTOMAS", true));
            this.sINTOMASTextBox.Location = new System.Drawing.Point(502, 97);
            this.sINTOMASTextBox.MaxLength = 2000;
            this.sINTOMASTextBox.Multiline = true;
            this.sINTOMASTextBox.Name = "sINTOMASTextBox";
            this.sINTOMASTextBox.Size = new System.Drawing.Size(194, 67);
            this.sINTOMASTextBox.TabIndex = 13;
            // 
            // mEDICAMENTOSTextBox
            // 
            this.mEDICAMENTOSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vISITABindingSource, "MEDICAMENTOS", true));
            this.mEDICAMENTOSTextBox.Location = new System.Drawing.Point(849, 97);
            this.mEDICAMENTOSTextBox.MaxLength = 200;
            this.mEDICAMENTOSTextBox.Multiline = true;
            this.mEDICAMENTOSTextBox.Name = "mEDICAMENTOSTextBox";
            this.mEDICAMENTOSTextBox.Size = new System.Drawing.Size(189, 67);
            this.mEDICAMENTOSTextBox.TabIndex = 15;
            // 
            // rECOMENDACIONESTextBox
            // 
            this.rECOMENDACIONESTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vISITABindingSource, "RECOMENDACIONES", true));
            this.rECOMENDACIONESTextBox.Location = new System.Drawing.Point(849, 20);
            this.rECOMENDACIONESTextBox.MaxLength = 200;
            this.rECOMENDACIONESTextBox.Multiline = true;
            this.rECOMENDACIONESTextBox.Name = "rECOMENDACIONESTextBox";
            this.rECOMENDACIONESTextBox.Size = new System.Drawing.Size(189, 70);
            this.rECOMENDACIONESTextBox.TabIndex = 17;
            // 
            // eSTADOTextBox
            // 
            this.eSTADOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vISITABindingSource, "ESTADO", true));
            this.eSTADOTextBox.Location = new System.Drawing.Point(159, 130);
            this.eSTADOTextBox.MaxLength = 20;
            this.eSTADOTextBox.Name = "eSTADOTextBox";
            this.eSTADOTextBox.Size = new System.Drawing.Size(233, 22);
            this.eSTADOTextBox.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vISITADataGridView);
            this.panel1.Location = new System.Drawing.Point(14, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 280);
            this.panel1.TabIndex = 20;
            // 
            // hORADateTimePicker
            // 
            this.hORADateTimePicker.CustomFormat = "hh-mm-ss";
            this.hORADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vISITABindingSource, "HORA", true));
            this.hORADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hORADateTimePicker.Location = new System.Drawing.Point(502, 60);
            this.hORADateTimePicker.Name = "hORADateTimePicker";
            this.hORADateTimePicker.ShowUpDown = true;
            this.hORADateTimePicker.Size = new System.Drawing.Size(140, 22);
            this.hORADateTimePicker.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::_1ParcialJP.Properties.Resources.add_1_icon__flatastic_1_iconset__custom_icon_design_0;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(1086, 93);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(60, 60);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // CBXPACIENTE
            // 
            this.CBXPACIENTE.FormattingEnabled = true;
            this.CBXPACIENTE.Location = new System.Drawing.Point(159, 93);
            this.CBXPACIENTE.Name = "CBXPACIENTE";
            this.CBXPACIENTE.Size = new System.Drawing.Size(233, 23);
            this.CBXPACIENTE.TabIndex = 26;
            // 
            // nOMBRE_MEDICOComboBox
            // 
            this.nOMBRE_MEDICOComboBox.FormattingEnabled = true;
            this.nOMBRE_MEDICOComboBox.Location = new System.Drawing.Point(159, 60);
            this.nOMBRE_MEDICOComboBox.Name = "nOMBRE_MEDICOComboBox";
            this.nOMBRE_MEDICOComboBox.Size = new System.Drawing.Size(233, 23);
            this.nOMBRE_MEDICOComboBox.TabIndex = 27;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::_1ParcialJP.Properties.Resources.unnamed__2_;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(1111, 20);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 54);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGguardar
            // 
            this.btnGguardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGguardar.BackgroundImage")));
            this.btnGguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGguardar.Enabled = false;
            this.btnGguardar.Location = new System.Drawing.Point(1046, 20);
            this.btnGguardar.Name = "btnGguardar";
            this.btnGguardar.Size = new System.Drawing.Size(57, 54);
            this.btnGguardar.TabIndex = 23;
            this.btnGguardar.UseVisualStyleBackColor = true;
            this.btnGguardar.Click += new System.EventHandler(this.btnGguardar_Click);
            // 
            // FrmVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1170, 478);
            this.Controls.Add(this.nOMBRE_MEDICOComboBox);
            this.Controls.Add(this.CBXPACIENTE);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGguardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.hORADateTimePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(iD_VISITALabel);
            this.Controls.Add(this.iD_VISITATextBox);
            this.Controls.Add(nOMBRE_MEDICOLabel);
            this.Controls.Add(nOMBRE_PACIENTELabel);
            this.Controls.Add(fECHALabel);
            this.Controls.Add(this.fECHADateTimePicker);
            this.Controls.Add(hORALabel);
            this.Controls.Add(sINTOMASLabel);
            this.Controls.Add(this.sINTOMASTextBox);
            this.Controls.Add(mEDICAMENTOSLabel);
            this.Controls.Add(this.mEDICAMENTOSTextBox);
            this.Controls.Add(rECOMENDACIONESLabel);
            this.Controls.Add(this.rECOMENDACIONESTextBox);
            this.Controls.Add(eSTADOLabel);
            this.Controls.Add(this.eSTADOTextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVisitas";
            this.Text = "Visitas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVisitas_FormClosed);
            this.Load += new System.EventHandler(this.FrmVisitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISITABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISITADataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PARCIALJPDataSet pARCIALJPDataSet;
        private System.Windows.Forms.BindingSource vISITABindingSource;
        private PARCIALJPDataSetTableAdapters.VISITATableAdapter vISITATableAdapter;
        private PARCIALJPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vISITADataGridView;
        private System.Windows.Forms.TextBox iD_VISITATextBox;
        private System.Windows.Forms.DateTimePicker fECHADateTimePicker;
        private System.Windows.Forms.TextBox sINTOMASTextBox;
        private System.Windows.Forms.TextBox mEDICAMENTOSTextBox;
        private System.Windows.Forms.TextBox rECOMENDACIONESTextBox;
        private System.Windows.Forms.TextBox eSTADOTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker hORADateTimePicker;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGguardar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox CBXPACIENTE;
        private System.Windows.Forms.ComboBox nOMBRE_MEDICOComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}