﻿
namespace _1ParcialJP
{
    partial class FrmPaciente
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
            System.Windows.Forms.Label iD_PACIENTELabel;
            System.Windows.Forms.Label nOMBRELabel;
            System.Windows.Forms.Label cEDULALabel;
            System.Windows.Forms.Label nUM_CARNETLabel;
            System.Windows.Forms.Label tIPO_PACIENTELabel;
            System.Windows.Forms.Label eSTADOLabel1;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaciente));
            this.pARCIALJPDataSet = new _1ParcialJP.PARCIALJPDataSet();
            this.pACIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pACIENTETableAdapter = new _1ParcialJP.PARCIALJPDataSetTableAdapters.PACIENTETableAdapter();
            this.tableAdapterManager = new _1ParcialJP.PARCIALJPDataSetTableAdapters.TableAdapterManager();
            this.pACIENTEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_PACIENTETextBox = new System.Windows.Forms.TextBox();
            this.nOMBRETextBox = new System.Windows.Forms.TextBox();
            this.cEDULATextBox = new System.Windows.Forms.TextBox();
            this.nUM_CARNETTextBox = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGguardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tIPO_PACIENTEComboBox = new System.Windows.Forms.ComboBox();
            this.eSTADOComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.selectsearch = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            iD_PACIENTELabel = new System.Windows.Forms.Label();
            nOMBRELabel = new System.Windows.Forms.Label();
            cEDULALabel = new System.Windows.Forms.Label();
            nUM_CARNETLabel = new System.Windows.Forms.Label();
            tIPO_PACIENTELabel = new System.Windows.Forms.Label();
            eSTADOLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTEDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_PACIENTELabel
            // 
            iD_PACIENTELabel.AutoSize = true;
            iD_PACIENTELabel.Location = new System.Drawing.Point(38, 29);
            iD_PACIENTELabel.Name = "iD_PACIENTELabel";
            iD_PACIENTELabel.Size = new System.Drawing.Size(85, 15);
            iD_PACIENTELabel.TabIndex = 2;
            iD_PACIENTELabel.Text = "ID PACIENTE:";
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(38, 66);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(63, 15);
            nOMBRELabel.TabIndex = 4;
            nOMBRELabel.Text = "NOMBRE:";
            // 
            // cEDULALabel
            // 
            cEDULALabel.AutoSize = true;
            cEDULALabel.Location = new System.Drawing.Point(38, 107);
            cEDULALabel.Name = "cEDULALabel";
            cEDULALabel.Size = new System.Drawing.Size(60, 15);
            cEDULALabel.TabIndex = 6;
            cEDULALabel.Text = "CEDULA:";
            // 
            // nUM_CARNETLabel
            // 
            nUM_CARNETLabel.AutoSize = true;
            nUM_CARNETLabel.Location = new System.Drawing.Point(38, 145);
            nUM_CARNETLabel.Name = "nUM_CARNETLabel";
            nUM_CARNETLabel.Size = new System.Drawing.Size(92, 15);
            nUM_CARNETLabel.TabIndex = 8;
            nUM_CARNETLabel.Text = "NUM CARNET:";
            // 
            // tIPO_PACIENTELabel
            // 
            tIPO_PACIENTELabel.AutoSize = true;
            tIPO_PACIENTELabel.Location = new System.Drawing.Point(386, 70);
            tIPO_PACIENTELabel.Name = "tIPO_PACIENTELabel";
            tIPO_PACIENTELabel.Size = new System.Drawing.Size(100, 15);
            tIPO_PACIENTELabel.TabIndex = 10;
            tIPO_PACIENTELabel.Text = "TIPO PACIENTE:";
            // 
            // eSTADOLabel1
            // 
            eSTADOLabel1.AutoSize = true;
            eSTADOLabel1.Location = new System.Drawing.Point(391, 29);
            eSTADOLabel1.Name = "eSTADOLabel1";
            eSTADOLabel1.Size = new System.Drawing.Size(59, 15);
            eSTADOLabel1.TabIndex = 20;
            eSTADOLabel1.Text = "ESTADO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(24, 179);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(140, 15);
            label1.TabIndex = 33;
            label1.Text = "REALIZAR CONSULTA:";
            // 
            // pARCIALJPDataSet
            // 
            this.pARCIALJPDataSet.DataSetName = "PARCIALJPDataSet";
            this.pARCIALJPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pACIENTEBindingSource
            // 
            this.pACIENTEBindingSource.DataMember = "PACIENTE";
            this.pACIENTEBindingSource.DataSource = this.pARCIALJPDataSet;
            // 
            // pACIENTETableAdapter
            // 
            this.pACIENTETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MARCATableAdapter = null;
            this.tableAdapterManager.MEDICAMENTOTableAdapter = null;
            this.tableAdapterManager.MEDICOTableAdapter = null;
            this.tableAdapterManager.PACIENTETableAdapter = this.pACIENTETableAdapter;
            this.tableAdapterManager.TIPO_FARMACOTableAdapter = null;
            this.tableAdapterManager.UBICACIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _1ParcialJP.PARCIALJPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VISITATableAdapter = null;
            // 
            // pACIENTEDataGridView
            // 
            this.pACIENTEDataGridView.AllowUserToAddRows = false;
            this.pACIENTEDataGridView.AllowUserToDeleteRows = false;
            this.pACIENTEDataGridView.AutoGenerateColumns = false;
            this.pACIENTEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pACIENTEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pACIENTEDataGridView.DataSource = this.pACIENTEBindingSource;
            this.pACIENTEDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pACIENTEDataGridView.Location = new System.Drawing.Point(0, 0);
            this.pACIENTEDataGridView.Name = "pACIENTEDataGridView";
            this.pACIENTEDataGridView.ReadOnly = true;
            this.pACIENTEDataGridView.Size = new System.Drawing.Size(791, 323);
            this.pACIENTEDataGridView.TabIndex = 1;
            this.pACIENTEDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pACIENTEDataGridView_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_PACIENTE";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_PACIENTE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 111;
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NUM_CARNET";
            this.dataGridViewTextBoxColumn4.HeaderText = "NUM_CARNET";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 119;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TIPO_PACIENTE";
            this.dataGridViewTextBoxColumn5.HeaderText = "TIPO_PACIENTE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 126;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ESTADO";
            this.dataGridViewTextBoxColumn6.HeaderText = "ESTADO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 81;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pACIENTEDataGridView);
            this.panel1.Location = new System.Drawing.Point(20, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 323);
            this.panel1.TabIndex = 2;
            // 
            // iD_PACIENTETextBox
            // 
            this.iD_PACIENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTEBindingSource, "ID_PACIENTE", true));
            this.iD_PACIENTETextBox.Location = new System.Drawing.Point(151, 26);
            this.iD_PACIENTETextBox.Name = "iD_PACIENTETextBox";
            this.iD_PACIENTETextBox.ReadOnly = true;
            this.iD_PACIENTETextBox.Size = new System.Drawing.Size(219, 22);
            this.iD_PACIENTETextBox.TabIndex = 3;
            // 
            // nOMBRETextBox
            // 
            this.nOMBRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTEBindingSource, "NOMBRE", true));
            this.nOMBRETextBox.Location = new System.Drawing.Point(151, 63);
            this.nOMBRETextBox.MaxLength = 30;
            this.nOMBRETextBox.Name = "nOMBRETextBox";
            this.nOMBRETextBox.Size = new System.Drawing.Size(219, 22);
            this.nOMBRETextBox.TabIndex = 5;
            // 
            // cEDULATextBox
            // 
            this.cEDULATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTEBindingSource, "CEDULA", true));
            this.cEDULATextBox.Location = new System.Drawing.Point(151, 103);
            this.cEDULATextBox.MaxLength = 11;
            this.cEDULATextBox.Name = "cEDULATextBox";
            this.cEDULATextBox.Size = new System.Drawing.Size(219, 22);
            this.cEDULATextBox.TabIndex = 7;
            // 
            // nUM_CARNETTextBox
            // 
            this.nUM_CARNETTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTEBindingSource, "NUM_CARNET", true));
            this.nUM_CARNETTextBox.Location = new System.Drawing.Point(151, 142);
            this.nUM_CARNETTextBox.Name = "nUM_CARNETTextBox";
            this.nUM_CARNETTextBox.Size = new System.Drawing.Size(219, 22);
            this.nUM_CARNETTextBox.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::_1ParcialJP.Properties.Resources.unnamed__2_;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(748, 160);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(63, 64);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGguardar
            // 
            this.btnGguardar.BackgroundImage = global::_1ParcialJP.Properties.Resources.save_icon;
            this.btnGguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGguardar.Location = new System.Drawing.Point(748, 87);
            this.btnGguardar.Name = "btnGguardar";
            this.btnGguardar.Size = new System.Drawing.Size(63, 64);
            this.btnGguardar.TabIndex = 18;
            this.btnGguardar.UseVisualStyleBackColor = true;
            this.btnGguardar.Click += new System.EventHandler(this.btnGguardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::_1ParcialJP.Properties.Resources.add_1_icon__flatastic_1_iconset__custom_icon_design_0;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Location = new System.Drawing.Point(748, 17);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(63, 64);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tIPO_PACIENTEComboBox
            // 
            this.tIPO_PACIENTEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTEBindingSource, "TIPO_PACIENTE", true));
            this.tIPO_PACIENTEComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tIPO_PACIENTEComboBox.FormattingEnabled = true;
            this.tIPO_PACIENTEComboBox.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.tIPO_PACIENTEComboBox.Location = new System.Drawing.Point(499, 66);
            this.tIPO_PACIENTEComboBox.Name = "tIPO_PACIENTEComboBox";
            this.tIPO_PACIENTEComboBox.Size = new System.Drawing.Size(219, 23);
            this.tIPO_PACIENTEComboBox.TabIndex = 20;
            // 
            // eSTADOComboBox
            // 
            this.eSTADOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTEBindingSource, "ESTADO", true));
            this.eSTADOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eSTADOComboBox.FormattingEnabled = true;
            this.eSTADOComboBox.Items.AddRange(new object[] {
            "SALUDABLE",
            "ESTABLE",
            "GRAVE"});
            this.eSTADOComboBox.Location = new System.Drawing.Point(499, 29);
            this.eSTADOComboBox.Name = "eSTADOComboBox";
            this.eSTADOComboBox.Size = new System.Drawing.Size(219, 23);
            this.eSTADOComboBox.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::_1ParcialJP.Properties.Resources._1024px_Search_Icon_svg;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(672, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 47);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(297, 204);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(369, 22);
            this.txtsearch.TabIndex = 31;
            // 
            // selectsearch
            // 
            this.selectsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectsearch.FormattingEnabled = true;
            this.selectsearch.Items.AddRange(new object[] {
            "NOMBRE",
            "CEDULA",
            "NUM_CARNET",
            "TIPO_PACIENTE",
            "ESTADO"});
            this.selectsearch.Location = new System.Drawing.Point(27, 203);
            this.selectsearch.Name = "selectsearch";
            this.selectsearch.Size = new System.Drawing.Size(251, 23);
            this.selectsearch.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.nOMBRETextBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(eSTADOLabel1);
            this.groupBox1.Controls.Add(tIPO_PACIENTELabel);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.nUM_CARNETTextBox);
            this.groupBox1.Controls.Add(this.selectsearch);
            this.groupBox1.Controls.Add(nUM_CARNETLabel);
            this.groupBox1.Controls.Add(this.eSTADOComboBox);
            this.groupBox1.Controls.Add(this.cEDULATextBox);
            this.groupBox1.Controls.Add(this.tIPO_PACIENTEComboBox);
            this.groupBox1.Controls.Add(cEDULALabel);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(nOMBRELabel);
            this.groupBox1.Controls.Add(this.btnGguardar);
            this.groupBox1.Controls.Add(this.iD_PACIENTETextBox);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(iD_PACIENTELabel);
            this.groupBox1.Location = new System.Drawing.Point(223, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 571);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pacientes";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.BackgroundImage = global::_1ParcialJP.Properties.Resources.x_png_33;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Location = new System.Drawing.Point(1074, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 40);
            this.button3.TabIndex = 35;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1213, 610);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPaciente";
            this.Text = "Pacientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPaciente_FormClosed);
            this.Load += new System.EventHandler(this.FrmPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTEDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PARCIALJPDataSet pARCIALJPDataSet;
        private System.Windows.Forms.BindingSource pACIENTEBindingSource;
        private PARCIALJPDataSetTableAdapters.PACIENTETableAdapter pACIENTETableAdapter;
        private PARCIALJPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pACIENTEDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox iD_PACIENTETextBox;
        private System.Windows.Forms.TextBox nOMBRETextBox;
        private System.Windows.Forms.TextBox cEDULATextBox;
        private System.Windows.Forms.TextBox nUM_CARNETTextBox;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGguardar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox tIPO_PACIENTEComboBox;
        private System.Windows.Forms.ComboBox eSTADOComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox selectsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
    }
}