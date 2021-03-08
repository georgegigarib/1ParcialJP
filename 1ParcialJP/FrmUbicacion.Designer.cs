
namespace _1ParcialJP
{
    partial class FrmUbicacion
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
            System.Windows.Forms.Label iD_UBICACIONLabel;
            System.Windows.Forms.Label dESCRIPCIONLabel;
            System.Windows.Forms.Label eSTANTELabel;
            System.Windows.Forms.Label tRAMOLabel;
            System.Windows.Forms.Label cELDALabel;
            System.Windows.Forms.Label eSTADOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUbicacion));
            this.pARCIALJPDataSet = new _1ParcialJP.PARCIALJPDataSet();
            this.uBICACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uBICACIONTableAdapter = new _1ParcialJP.PARCIALJPDataSetTableAdapters.UBICACIONTableAdapter();
            this.tableAdapterManager = new _1ParcialJP.PARCIALJPDataSetTableAdapters.TableAdapterManager();
            this.uBICACIONDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dESCRIPCIONTextBox = new System.Windows.Forms.TextBox();
            this.eSTANTETextBox = new System.Windows.Forms.TextBox();
            this.tRAMOTextBox = new System.Windows.Forms.TextBox();
            this.cELDATextBox = new System.Windows.Forms.TextBox();
            this.iD_UBICACIONTextBox = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGguardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.eSTADOComboBox = new System.Windows.Forms.ComboBox();
            iD_UBICACIONLabel = new System.Windows.Forms.Label();
            dESCRIPCIONLabel = new System.Windows.Forms.Label();
            eSTANTELabel = new System.Windows.Forms.Label();
            tRAMOLabel = new System.Windows.Forms.Label();
            cELDALabel = new System.Windows.Forms.Label();
            eSTADOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBICACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBICACIONDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_UBICACIONLabel
            // 
            iD_UBICACIONLabel.AutoSize = true;
            iD_UBICACIONLabel.Location = new System.Drawing.Point(19, 24);
            iD_UBICACIONLabel.Name = "iD_UBICACIONLabel";
            iD_UBICACIONLabel.Size = new System.Drawing.Size(95, 15);
            iD_UBICACIONLabel.TabIndex = 2;
            iD_UBICACIONLabel.Text = "ID UBICACION:";
            // 
            // dESCRIPCIONLabel
            // 
            dESCRIPCIONLabel.AutoSize = true;
            dESCRIPCIONLabel.Location = new System.Drawing.Point(287, 55);
            dESCRIPCIONLabel.Name = "dESCRIPCIONLabel";
            dESCRIPCIONLabel.Size = new System.Drawing.Size(90, 15);
            dESCRIPCIONLabel.TabIndex = 4;
            dESCRIPCIONLabel.Text = "DESCRIPCION:";
            // 
            // eSTANTELabel
            // 
            eSTANTELabel.AutoSize = true;
            eSTANTELabel.Location = new System.Drawing.Point(19, 55);
            eSTANTELabel.Name = "eSTANTELabel";
            eSTANTELabel.Size = new System.Drawing.Size(65, 15);
            eSTANTELabel.TabIndex = 6;
            eSTANTELabel.Text = "ESTANTE:";
            // 
            // tRAMOLabel
            // 
            tRAMOLabel.AutoSize = true;
            tRAMOLabel.Location = new System.Drawing.Point(19, 91);
            tRAMOLabel.Name = "tRAMOLabel";
            tRAMOLabel.Size = new System.Drawing.Size(57, 15);
            tRAMOLabel.TabIndex = 8;
            tRAMOLabel.Text = "TRAMO:";
            // 
            // cELDALabel
            // 
            cELDALabel.AutoSize = true;
            cELDALabel.Location = new System.Drawing.Point(19, 121);
            cELDALabel.Name = "cELDALabel";
            cELDALabel.Size = new System.Drawing.Size(51, 15);
            cELDALabel.TabIndex = 10;
            cELDALabel.Text = "CELDA:";
            // 
            // eSTADOLabel
            // 
            eSTADOLabel.AutoSize = true;
            eSTADOLabel.Location = new System.Drawing.Point(287, 21);
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
            // uBICACIONBindingSource
            // 
            this.uBICACIONBindingSource.DataMember = "UBICACION";
            this.uBICACIONBindingSource.DataSource = this.pARCIALJPDataSet;
            // 
            // uBICACIONTableAdapter
            // 
            this.uBICACIONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MARCATableAdapter = null;
            this.tableAdapterManager.MEDICAMENTOTableAdapter = null;
            this.tableAdapterManager.MEDICOTableAdapter = null;
            this.tableAdapterManager.PACIENTETableAdapter = null;
            this.tableAdapterManager.TIPO_FARMACOTableAdapter = null;
            this.tableAdapterManager.UBICACIONTableAdapter = this.uBICACIONTableAdapter;
            this.tableAdapterManager.UpdateOrder = _1ParcialJP.PARCIALJPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VISITATableAdapter = null;
            // 
            // uBICACIONDataGridView
            // 
            this.uBICACIONDataGridView.AllowUserToAddRows = false;
            this.uBICACIONDataGridView.AllowUserToDeleteRows = false;
            this.uBICACIONDataGridView.AutoGenerateColumns = false;
            this.uBICACIONDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uBICACIONDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.uBICACIONDataGridView.DataSource = this.uBICACIONBindingSource;
            this.uBICACIONDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uBICACIONDataGridView.Location = new System.Drawing.Point(0, 0);
            this.uBICACIONDataGridView.Name = "uBICACIONDataGridView";
            this.uBICACIONDataGridView.ReadOnly = true;
            this.uBICACIONDataGridView.Size = new System.Drawing.Size(777, 265);
            this.uBICACIONDataGridView.TabIndex = 1;
            this.uBICACIONDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uBICACIONDataGridView_CellContentClick);
            this.uBICACIONDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uBICACIONDataGridView_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_UBICACION";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_UBICACION";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 121;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DESCRIPCION";
            this.dataGridViewTextBoxColumn2.HeaderText = "DESCRIPCION";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 112;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ESTANTE";
            this.dataGridViewTextBoxColumn3.HeaderText = "ESTANTE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TRAMO";
            this.dataGridViewTextBoxColumn4.HeaderText = "TRAMO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CELDA";
            this.dataGridViewTextBoxColumn5.HeaderText = "CELDA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
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
            this.panel1.Controls.Add(this.uBICACIONDataGridView);
            this.panel1.Location = new System.Drawing.Point(15, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 265);
            this.panel1.TabIndex = 2;
            // 
            // dESCRIPCIONTextBox
            // 
            this.dESCRIPCIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uBICACIONBindingSource, "DESCRIPCION", true));
            this.dESCRIPCIONTextBox.Location = new System.Drawing.Point(391, 52);
            this.dESCRIPCIONTextBox.MaxLength = 200;
            this.dESCRIPCIONTextBox.Multiline = true;
            this.dESCRIPCIONTextBox.Name = "dESCRIPCIONTextBox";
            this.dESCRIPCIONTextBox.Size = new System.Drawing.Size(215, 85);
            this.dESCRIPCIONTextBox.TabIndex = 5;
            // 
            // eSTANTETextBox
            // 
            this.eSTANTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uBICACIONBindingSource, "ESTANTE", true));
            this.eSTANTETextBox.Location = new System.Drawing.Point(122, 52);
            this.eSTANTETextBox.MaxLength = 20;
            this.eSTANTETextBox.Name = "eSTANTETextBox";
            this.eSTANTETextBox.Size = new System.Drawing.Size(140, 22);
            this.eSTANTETextBox.TabIndex = 7;
            // 
            // tRAMOTextBox
            // 
            this.tRAMOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uBICACIONBindingSource, "TRAMO", true));
            this.tRAMOTextBox.Location = new System.Drawing.Point(122, 88);
            this.tRAMOTextBox.MaxLength = 20;
            this.tRAMOTextBox.Name = "tRAMOTextBox";
            this.tRAMOTextBox.Size = new System.Drawing.Size(140, 22);
            this.tRAMOTextBox.TabIndex = 9;
            // 
            // cELDATextBox
            // 
            this.cELDATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uBICACIONBindingSource, "CELDA", true));
            this.cELDATextBox.Location = new System.Drawing.Point(122, 118);
            this.cELDATextBox.MaxLength = 20;
            this.cELDATextBox.Name = "cELDATextBox";
            this.cELDATextBox.Size = new System.Drawing.Size(140, 22);
            this.cELDATextBox.TabIndex = 11;
            // 
            // iD_UBICACIONTextBox
            // 
            this.iD_UBICACIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uBICACIONBindingSource, "ID_UBICACION", true));
            this.iD_UBICACIONTextBox.Location = new System.Drawing.Point(122, 16);
            this.iD_UBICACIONTextBox.Name = "iD_UBICACIONTextBox";
            this.iD_UBICACIONTextBox.ReadOnly = true;
            this.iD_UBICACIONTextBox.Size = new System.Drawing.Size(140, 22);
            this.iD_UBICACIONTextBox.TabIndex = 14;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::_1ParcialJP.Properties.Resources.unnamed__2_;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(723, 16);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 59);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGguardar
            // 
            this.btnGguardar.BackgroundImage = global::_1ParcialJP.Properties.Resources.save_icon;
            this.btnGguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGguardar.Location = new System.Drawing.Point(644, 16);
            this.btnGguardar.Name = "btnGguardar";
            this.btnGguardar.Size = new System.Drawing.Size(70, 60);
            this.btnGguardar.TabIndex = 18;
            this.btnGguardar.UseVisualStyleBackColor = true;
            this.btnGguardar.Click += new System.EventHandler(this.btnGguardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::_1ParcialJP.Properties.Resources.add_1_icon__flatastic_1_iconset__custom_icon_design_0;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(688, 81);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(66, 59);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // eSTADOComboBox
            // 
            this.eSTADOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uBICACIONBindingSource, "ESTADO", true));
            this.eSTADOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eSTADOComboBox.FormattingEnabled = true;
            this.eSTADOComboBox.Items.AddRange(new object[] {
            "DISPONIBLE",
            "NO DISPONIBLE",
            "LLENO",
            "VACIO"});
            this.eSTADOComboBox.Location = new System.Drawing.Point(395, 17);
            this.eSTADOComboBox.Name = "eSTADOComboBox";
            this.eSTADOComboBox.Size = new System.Drawing.Size(210, 23);
            this.eSTADOComboBox.TabIndex = 20;
            // 
            // FrmUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(815, 460);
            this.Controls.Add(this.eSTADOComboBox);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGguardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.iD_UBICACIONTextBox);
            this.Controls.Add(iD_UBICACIONLabel);
            this.Controls.Add(dESCRIPCIONLabel);
            this.Controls.Add(this.dESCRIPCIONTextBox);
            this.Controls.Add(eSTANTELabel);
            this.Controls.Add(this.eSTANTETextBox);
            this.Controls.Add(tRAMOLabel);
            this.Controls.Add(this.tRAMOTextBox);
            this.Controls.Add(cELDALabel);
            this.Controls.Add(this.cELDATextBox);
            this.Controls.Add(eSTADOLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUbicacion";
            this.Text = "Ubicacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUbicacion_FormClosed);
            this.Load += new System.EventHandler(this.FrmUbicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBICACIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBICACIONDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PARCIALJPDataSet pARCIALJPDataSet;
        private System.Windows.Forms.BindingSource uBICACIONBindingSource;
        private PARCIALJPDataSetTableAdapters.UBICACIONTableAdapter uBICACIONTableAdapter;
        private PARCIALJPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView uBICACIONDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox dESCRIPCIONTextBox;
        private System.Windows.Forms.TextBox eSTANTETextBox;
        private System.Windows.Forms.TextBox tRAMOTextBox;
        private System.Windows.Forms.TextBox cELDATextBox;
        private System.Windows.Forms.TextBox iD_UBICACIONTextBox;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGguardar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox eSTADOComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}