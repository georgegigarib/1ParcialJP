
namespace _1ParcialJP
{
    partial class FrmMedico
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
            System.Windows.Forms.Label iD_MEDICOLabel;
            System.Windows.Forms.Label nOMBRELabel;
            System.Windows.Forms.Label cEDULALabel;
            System.Windows.Forms.Label tANDA_LABORLabel;
            System.Windows.Forms.Label eSPECIALIDADLabel;
            System.Windows.Forms.Label eSTADOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedico));
            this.pARCIALJPDataSet = new _1ParcialJP.PARCIALJPDataSet();
            this.mEDICOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICOTableAdapter = new _1ParcialJP.PARCIALJPDataSetTableAdapters.MEDICOTableAdapter();
            this.tableAdapterManager = new _1ParcialJP.PARCIALJPDataSetTableAdapters.TableAdapterManager();
            this.mEDICODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_MEDICOTextBox = new System.Windows.Forms.TextBox();
            this.nOMBRETextBox = new System.Windows.Forms.TextBox();
            this.cEDULATextBox = new System.Windows.Forms.TextBox();
            this.eSPECIALIDADTextBox = new System.Windows.Forms.TextBox();
            this.eSTADOComboBox = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGguardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tANDA_LABORTextBox = new System.Windows.Forms.ComboBox();
            iD_MEDICOLabel = new System.Windows.Forms.Label();
            nOMBRELabel = new System.Windows.Forms.Label();
            cEDULALabel = new System.Windows.Forms.Label();
            tANDA_LABORLabel = new System.Windows.Forms.Label();
            eSPECIALIDADLabel = new System.Windows.Forms.Label();
            eSTADOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICODataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_MEDICOLabel
            // 
            iD_MEDICOLabel.AutoSize = true;
            iD_MEDICOLabel.Location = new System.Drawing.Point(19, 29);
            iD_MEDICOLabel.Name = "iD_MEDICOLabel";
            iD_MEDICOLabel.Size = new System.Drawing.Size(75, 15);
            iD_MEDICOLabel.TabIndex = 2;
            iD_MEDICOLabel.Text = "ID MEDICO:";
            iD_MEDICOLabel.Click += new System.EventHandler(this.iD_MEDICOLabel_Click);
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(19, 72);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(63, 15);
            nOMBRELabel.TabIndex = 4;
            nOMBRELabel.Text = "NOMBRE:";
            // 
            // cEDULALabel
            // 
            cEDULALabel.AutoSize = true;
            cEDULALabel.Location = new System.Drawing.Point(19, 117);
            cEDULALabel.Name = "cEDULALabel";
            cEDULALabel.Size = new System.Drawing.Size(60, 15);
            cEDULALabel.TabIndex = 6;
            cEDULALabel.Text = "CEDULA:";
            // 
            // tANDA_LABORLabel
            // 
            tANDA_LABORLabel.AutoSize = true;
            tANDA_LABORLabel.Location = new System.Drawing.Point(367, 72);
            tANDA_LABORLabel.Name = "tANDA_LABORLabel";
            tANDA_LABORLabel.Size = new System.Drawing.Size(99, 15);
            tANDA_LABORLabel.TabIndex = 8;
            tANDA_LABORLabel.Text = "TANDA LABOR:";
            // 
            // eSPECIALIDADLabel
            // 
            eSPECIALIDADLabel.AutoSize = true;
            eSPECIALIDADLabel.Location = new System.Drawing.Point(367, 29);
            eSPECIALIDADLabel.Name = "eSPECIALIDADLabel";
            eSPECIALIDADLabel.Size = new System.Drawing.Size(99, 15);
            eSPECIALIDADLabel.TabIndex = 10;
            eSPECIALIDADLabel.Text = "ESPECIALIDAD:";
            // 
            // eSTADOLabel
            // 
            eSTADOLabel.AutoSize = true;
            eSTADOLabel.Location = new System.Drawing.Point(19, 157);
            eSTADOLabel.Name = "eSTADOLabel";
            eSTADOLabel.Size = new System.Drawing.Size(59, 15);
            eSTADOLabel.TabIndex = 12;
            eSTADOLabel.Text = "ESTADO:";
            // 
            // pARCIALJPDataSet
            // 
            this.pARCIALJPDataSet.DataSetName = "PARCIALJPDataSet";
            this.pARCIALJPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mEDICOBindingSource
            // 
            this.mEDICOBindingSource.DataMember = "MEDICO";
            this.mEDICOBindingSource.DataSource = this.pARCIALJPDataSet;
            // 
            // mEDICOTableAdapter
            // 
            this.mEDICOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MARCATableAdapter = null;
            this.tableAdapterManager.MEDICAMENTOTableAdapter = null;
            this.tableAdapterManager.MEDICOTableAdapter = this.mEDICOTableAdapter;
            this.tableAdapterManager.PACIENTETableAdapter = null;
            this.tableAdapterManager.TIPO_FARMACOTableAdapter = null;
            this.tableAdapterManager.UBICACIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _1ParcialJP.PARCIALJPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VISITATableAdapter = null;
            // 
            // mEDICODataGridView
            // 
            this.mEDICODataGridView.AllowUserToAddRows = false;
            this.mEDICODataGridView.AllowUserToDeleteRows = false;
            this.mEDICODataGridView.AutoGenerateColumns = false;
            this.mEDICODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mEDICODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.mEDICODataGridView.DataSource = this.mEDICOBindingSource;
            this.mEDICODataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mEDICODataGridView.Location = new System.Drawing.Point(0, 0);
            this.mEDICODataGridView.Name = "mEDICODataGridView";
            this.mEDICODataGridView.ReadOnly = true;
            this.mEDICODataGridView.Size = new System.Drawing.Size(766, 312);
            this.mEDICODataGridView.TabIndex = 1;
            this.mEDICODataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mEDICODataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_MEDICO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_MEDICO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CEDULA";
            this.dataGridViewTextBoxColumn3.HeaderText = "CEDULA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TANDA_LABOR";
            this.dataGridViewTextBoxColumn4.HeaderText = "TANDA_LABOR";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 126;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ESPECIALIDAD";
            this.dataGridViewTextBoxColumn5.HeaderText = "ESPECIALIDAD";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 121;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ESTADO";
            this.dataGridViewTextBoxColumn6.HeaderText = "ESTADO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mEDICODataGridView);
            this.panel1.Location = new System.Drawing.Point(14, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 312);
            this.panel1.TabIndex = 2;
            // 
            // iD_MEDICOTextBox
            // 
            this.iD_MEDICOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDICOBindingSource, "ID_MEDICO", true));
            this.iD_MEDICOTextBox.Location = new System.Drawing.Point(127, 25);
            this.iD_MEDICOTextBox.Name = "iD_MEDICOTextBox";
            this.iD_MEDICOTextBox.ReadOnly = true;
            this.iD_MEDICOTextBox.Size = new System.Drawing.Size(223, 22);
            this.iD_MEDICOTextBox.TabIndex = 3;
            this.iD_MEDICOTextBox.TextChanged += new System.EventHandler(this.iD_MEDICOTextBox_TextChanged);
            // 
            // nOMBRETextBox
            // 
            this.nOMBRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDICOBindingSource, "NOMBRE", true));
            this.nOMBRETextBox.Location = new System.Drawing.Point(127, 68);
            this.nOMBRETextBox.MaxLength = 30;
            this.nOMBRETextBox.Name = "nOMBRETextBox";
            this.nOMBRETextBox.Size = new System.Drawing.Size(223, 22);
            this.nOMBRETextBox.TabIndex = 5;
            // 
            // cEDULATextBox
            // 
            this.cEDULATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDICOBindingSource, "CEDULA", true));
            this.cEDULATextBox.Location = new System.Drawing.Point(127, 113);
            this.cEDULATextBox.MaxLength = 11;
            this.cEDULATextBox.Name = "cEDULATextBox";
            this.cEDULATextBox.Size = new System.Drawing.Size(223, 22);
            this.cEDULATextBox.TabIndex = 7;
            // 
            // eSPECIALIDADTextBox
            // 
            this.eSPECIALIDADTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDICOBindingSource, "ESPECIALIDAD", true));
            this.eSPECIALIDADTextBox.Location = new System.Drawing.Point(476, 25);
            this.eSPECIALIDADTextBox.MaxLength = 200;
            this.eSPECIALIDADTextBox.Name = "eSPECIALIDADTextBox";
            this.eSPECIALIDADTextBox.Size = new System.Drawing.Size(220, 22);
            this.eSPECIALIDADTextBox.TabIndex = 11;
            // 
            // eSTADOComboBox
            // 
            this.eSTADOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDICOBindingSource, "ESTADO", true));
            this.eSTADOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eSTADOComboBox.FormattingEnabled = true;
            this.eSTADOComboBox.Items.AddRange(new object[] {
            "DISPONIBLE",
            "NO DISPONIBLE",
            "VACACIONES",
            "LICENCIA"});
            this.eSTADOComboBox.Location = new System.Drawing.Point(127, 153);
            this.eSTADOComboBox.Name = "eSTADOComboBox";
            this.eSTADOComboBox.Size = new System.Drawing.Size(223, 23);
            this.eSTADOComboBox.TabIndex = 13;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::_1ParcialJP.Properties.Resources.unnamed__2_;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(715, 128);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 54);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGguardar
            // 
            this.btnGguardar.BackgroundImage = global::_1ParcialJP.Properties.Resources.save_icon;
            this.btnGguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGguardar.Location = new System.Drawing.Point(715, 74);
            this.btnGguardar.Name = "btnGguardar";
            this.btnGguardar.Size = new System.Drawing.Size(56, 48);
            this.btnGguardar.TabIndex = 15;
            this.btnGguardar.UseVisualStyleBackColor = true;
            this.btnGguardar.Click += new System.EventHandler(this.btnGguardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::_1ParcialJP.Properties.Resources.add_1_icon__flatastic_1_iconset__custom_icon_design_0;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(715, 10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(56, 58);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tANDA_LABORTextBox
            // 
            this.tANDA_LABORTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tANDA_LABORTextBox.FormattingEnabled = true;
            this.tANDA_LABORTextBox.Items.AddRange(new object[] {
            "MATUTINO",
            "VESPERTINO",
            "NOCTURNO"});
            this.tANDA_LABORTextBox.Location = new System.Drawing.Point(476, 69);
            this.tANDA_LABORTextBox.Name = "tANDA_LABORTextBox";
            this.tANDA_LABORTextBox.Size = new System.Drawing.Size(220, 23);
            this.tANDA_LABORTextBox.TabIndex = 17;
            // 
            // FrmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 532);
            this.Controls.Add(this.tANDA_LABORTextBox);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGguardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.eSTADOComboBox);
            this.Controls.Add(iD_MEDICOLabel);
            this.Controls.Add(this.iD_MEDICOTextBox);
            this.Controls.Add(nOMBRELabel);
            this.Controls.Add(this.nOMBRETextBox);
            this.Controls.Add(cEDULALabel);
            this.Controls.Add(this.cEDULATextBox);
            this.Controls.Add(tANDA_LABORLabel);
            this.Controls.Add(eSPECIALIDADLabel);
            this.Controls.Add(this.eSPECIALIDADTextBox);
            this.Controls.Add(eSTADOLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMedico";
            this.Text = "Medicos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMedico_FormClosed);
            this.Load += new System.EventHandler(this.FrmMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICODataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PARCIALJPDataSet pARCIALJPDataSet;
        private System.Windows.Forms.BindingSource mEDICOBindingSource;
        private PARCIALJPDataSetTableAdapters.MEDICOTableAdapter mEDICOTableAdapter;
        private PARCIALJPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView mEDICODataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox iD_MEDICOTextBox;
        private System.Windows.Forms.TextBox nOMBRETextBox;
        private System.Windows.Forms.TextBox cEDULATextBox;
        private System.Windows.Forms.TextBox eSPECIALIDADTextBox;
        private System.Windows.Forms.ComboBox eSTADOComboBox;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGguardar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ComboBox tANDA_LABORTextBox;
    }
}