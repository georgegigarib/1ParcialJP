
namespace _1ParcialJP
{
    partial class FrmTipoFarmaco
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
            System.Windows.Forms.Label iD_TFLabel;
            System.Windows.Forms.Label dESCRIPCIONLabel;
            System.Windows.Forms.Label eSTADOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoFarmaco));
            this.pARCIALJPDataSet = new _1ParcialJP.PARCIALJPDataSet();
            this.tIPO_FARMACOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPO_FARMACOTableAdapter = new _1ParcialJP.PARCIALJPDataSetTableAdapters.TIPO_FARMACOTableAdapter();
            this.tableAdapterManager = new _1ParcialJP.PARCIALJPDataSetTableAdapters.TableAdapterManager();
            this.tIPO_FARMACODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_TFTextBox = new System.Windows.Forms.TextBox();
            this.dESCRIPCIONTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGguardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.eSTADOComboBox = new System.Windows.Forms.ComboBox();
            iD_TFLabel = new System.Windows.Forms.Label();
            dESCRIPCIONLabel = new System.Windows.Forms.Label();
            eSTADOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPO_FARMACOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPO_FARMACODataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_TFLabel
            // 
            iD_TFLabel.AutoSize = true;
            iD_TFLabel.Location = new System.Drawing.Point(14, 38);
            iD_TFLabel.Name = "iD_TFLabel";
            iD_TFLabel.Size = new System.Drawing.Size(41, 15);
            iD_TFLabel.TabIndex = 2;
            iD_TFLabel.Text = "ID TF:";
            // 
            // dESCRIPCIONLabel
            // 
            dESCRIPCIONLabel.AutoSize = true;
            dESCRIPCIONLabel.Location = new System.Drawing.Point(14, 110);
            dESCRIPCIONLabel.Name = "dESCRIPCIONLabel";
            dESCRIPCIONLabel.Size = new System.Drawing.Size(90, 15);
            dESCRIPCIONLabel.TabIndex = 4;
            dESCRIPCIONLabel.Text = "DESCRIPCION:";
            // 
            // eSTADOLabel
            // 
            eSTADOLabel.AutoSize = true;
            eSTADOLabel.Location = new System.Drawing.Point(12, 72);
            eSTADOLabel.Name = "eSTADOLabel";
            eSTADOLabel.Size = new System.Drawing.Size(59, 15);
            eSTADOLabel.TabIndex = 6;
            eSTADOLabel.Text = "ESTADO:";
            // 
            // pARCIALJPDataSet
            // 
            this.pARCIALJPDataSet.DataSetName = "PARCIALJPDataSet";
            this.pARCIALJPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIPO_FARMACOBindingSource
            // 
            this.tIPO_FARMACOBindingSource.DataMember = "TIPO_FARMACO";
            this.tIPO_FARMACOBindingSource.DataSource = this.pARCIALJPDataSet;
            // 
            // tIPO_FARMACOTableAdapter
            // 
            this.tIPO_FARMACOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MARCATableAdapter = null;
            this.tableAdapterManager.MEDICAMENTOTableAdapter = null;
            this.tableAdapterManager.MEDICOTableAdapter = null;
            this.tableAdapterManager.PACIENTETableAdapter = null;
            this.tableAdapterManager.TIPO_FARMACOTableAdapter = this.tIPO_FARMACOTableAdapter;
            this.tableAdapterManager.UBICACIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _1ParcialJP.PARCIALJPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VISITATableAdapter = null;
            // 
            // tIPO_FARMACODataGridView
            // 
            this.tIPO_FARMACODataGridView.AllowUserToAddRows = false;
            this.tIPO_FARMACODataGridView.AllowUserToDeleteRows = false;
            this.tIPO_FARMACODataGridView.AutoGenerateColumns = false;
            this.tIPO_FARMACODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tIPO_FARMACODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tIPO_FARMACODataGridView.DataSource = this.tIPO_FARMACOBindingSource;
            this.tIPO_FARMACODataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tIPO_FARMACODataGridView.Location = new System.Drawing.Point(0, 0);
            this.tIPO_FARMACODataGridView.Name = "tIPO_FARMACODataGridView";
            this.tIPO_FARMACODataGridView.ReadOnly = true;
            this.tIPO_FARMACODataGridView.Size = new System.Drawing.Size(418, 255);
            this.tIPO_FARMACODataGridView.TabIndex = 1;
            this.tIPO_FARMACODataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tIPO_FARMACODataGridView_CellContentClick);
            this.tIPO_FARMACODataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tIPO_FARMACODataGridView_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_TF";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_TF";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ESTADO";
            this.dataGridViewTextBoxColumn3.HeaderText = "ESTADO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // iD_TFTextBox
            // 
            this.iD_TFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tIPO_FARMACOBindingSource, "ID_TF", true));
            this.iD_TFTextBox.Location = new System.Drawing.Point(92, 38);
            this.iD_TFTextBox.Name = "iD_TFTextBox";
            this.iD_TFTextBox.ReadOnly = true;
            this.iD_TFTextBox.Size = new System.Drawing.Size(122, 22);
            this.iD_TFTextBox.TabIndex = 3;
            // 
            // dESCRIPCIONTextBox
            // 
            this.dESCRIPCIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tIPO_FARMACOBindingSource, "DESCRIPCION", true));
            this.dESCRIPCIONTextBox.Location = new System.Drawing.Point(118, 110);
            this.dESCRIPCIONTextBox.Multiline = true;
            this.dESCRIPCIONTextBox.Name = "dESCRIPCIONTextBox";
            this.dESCRIPCIONTextBox.Size = new System.Drawing.Size(307, 44);
            this.dESCRIPCIONTextBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tIPO_FARMACODataGridView);
            this.panel1.Location = new System.Drawing.Point(8, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 255);
            this.panel1.TabIndex = 8;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::_1ParcialJP.Properties.Resources.unnamed__2_;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(366, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(59, 59);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGguardar
            // 
            this.btnGguardar.BackgroundImage = global::_1ParcialJP.Properties.Resources.save_icon;
            this.btnGguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGguardar.Location = new System.Drawing.Point(301, 12);
            this.btnGguardar.Name = "btnGguardar";
            this.btnGguardar.Size = new System.Drawing.Size(59, 59);
            this.btnGguardar.TabIndex = 18;
            this.btnGguardar.UseVisualStyleBackColor = true;
            this.btnGguardar.Click += new System.EventHandler(this.btnGguardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::_1ParcialJP.Properties.Resources.add_1_icon__flatastic_1_iconset__custom_icon_design_0;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(233, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(62, 59);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // eSTADOComboBox
            // 
            this.eSTADOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tIPO_FARMACOBindingSource, "ESTADO", true));
            this.eSTADOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eSTADOComboBox.FormattingEnabled = true;
            this.eSTADOComboBox.Items.AddRange(new object[] {
            "DISPONIBLE",
            "NO DISPNIBLE",
            "DESCONTINUADO",
            "EN PRUEBA"});
            this.eSTADOComboBox.Location = new System.Drawing.Point(92, 72);
            this.eSTADOComboBox.Name = "eSTADOComboBox";
            this.eSTADOComboBox.Size = new System.Drawing.Size(122, 23);
            this.eSTADOComboBox.TabIndex = 20;
            // 
            // FrmTipoFarmaco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(445, 440);
            this.Controls.Add(this.eSTADOComboBox);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGguardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(iD_TFLabel);
            this.Controls.Add(this.iD_TFTextBox);
            this.Controls.Add(dESCRIPCIONLabel);
            this.Controls.Add(this.dESCRIPCIONTextBox);
            this.Controls.Add(eSTADOLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTipoFarmaco";
            this.Text = "Tipo Farmaco";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTipoFarmaco_FormClosed);
            this.Load += new System.EventHandler(this.FrmTipoFarmaco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPO_FARMACOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPO_FARMACODataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PARCIALJPDataSet pARCIALJPDataSet;
        private System.Windows.Forms.BindingSource tIPO_FARMACOBindingSource;
        private PARCIALJPDataSetTableAdapters.TIPO_FARMACOTableAdapter tIPO_FARMACOTableAdapter;
        private PARCIALJPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tIPO_FARMACODataGridView;
        private System.Windows.Forms.TextBox iD_TFTextBox;
        private System.Windows.Forms.TextBox dESCRIPCIONTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGguardar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox eSTADOComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}