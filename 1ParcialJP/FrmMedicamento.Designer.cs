
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedicamento));
            this.mEDICAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pARCIALJPDataSet = new _1ParcialJP.PARCIALJPDataSet();
            this.iD_MEDICAMENTOTextBox = new System.Windows.Forms.TextBox();
            this.dESCRIPCIONTextBox = new System.Windows.Forms.TextBox();
            this.dOSISTextBox = new System.Windows.Forms.TextBox();
            this.eSTADOComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mEDICAMENTODataGridView = new System.Windows.Forms.DataGridView();
            this.CBXUbicacion = new System.Windows.Forms.ComboBox();
            this.mEDICAMENTOTableAdapter = new _1ParcialJP.PARCIALJPDataSetTableAdapters.MEDICAMENTOTableAdapter();
            this.tableAdapterManager = new _1ParcialJP.PARCIALJPDataSetTableAdapters.TableAdapterManager();
            this.uBICACIONTableAdapter = new _1ParcialJP.PARCIALJPDataSetTableAdapters.UBICACIONTableAdapter();
            this.uBICACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CBXMarca = new System.Windows.Forms.ComboBox();
            this.CBXtipoFarmaco = new System.Windows.Forms.ComboBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.selectsearch = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGguardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.iDMEDICAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMARCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUBBICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOSISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_MEDICAMENTOLabel = new System.Windows.Forms.Label();
            dESCRIPCIONLabel = new System.Windows.Forms.Label();
            iD_TFLabel = new System.Windows.Forms.Label();
            iD_MARCALabel = new System.Windows.Forms.Label();
            iD_UBBICACIONLabel = new System.Windows.Forms.Label();
            dOSISLabel = new System.Windows.Forms.Label();
            eSTADOLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBICACIONBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_MEDICAMENTOLabel
            // 
            iD_MEDICAMENTOLabel.AutoSize = true;
            iD_MEDICAMENTOLabel.Location = new System.Drawing.Point(30, 24);
            iD_MEDICAMENTOLabel.Name = "iD_MEDICAMENTOLabel";
            iD_MEDICAMENTOLabel.Size = new System.Drawing.Size(121, 15);
            iD_MEDICAMENTOLabel.TabIndex = 2;
            iD_MEDICAMENTOLabel.Text = "ID MEDICAMENTO:";
            // 
            // dESCRIPCIONLabel
            // 
            dESCRIPCIONLabel.AutoSize = true;
            dESCRIPCIONLabel.Location = new System.Drawing.Point(30, 61);
            dESCRIPCIONLabel.Name = "dESCRIPCIONLabel";
            dESCRIPCIONLabel.Size = new System.Drawing.Size(90, 15);
            dESCRIPCIONLabel.TabIndex = 4;
            dESCRIPCIONLabel.Text = "DESCRIPCION:";
            // 
            // iD_TFLabel
            // 
            iD_TFLabel.AutoSize = true;
            iD_TFLabel.Location = new System.Drawing.Point(414, 25);
            iD_TFLabel.Name = "iD_TFLabel";
            iD_TFLabel.Size = new System.Drawing.Size(104, 15);
            iD_TFLabel.TabIndex = 6;
            iD_TFLabel.Text = "TIPO FARMACO:";
            // 
            // iD_MARCALabel
            // 
            iD_MARCALabel.AutoSize = true;
            iD_MARCALabel.Location = new System.Drawing.Point(414, 63);
            iD_MARCALabel.Name = "iD_MARCALabel";
            iD_MARCALabel.Size = new System.Drawing.Size(58, 15);
            iD_MARCALabel.TabIndex = 8;
            iD_MARCALabel.Text = "MARCA:";
            // 
            // iD_UBBICACIONLabel
            // 
            iD_UBBICACIONLabel.AutoSize = true;
            iD_UBBICACIONLabel.Location = new System.Drawing.Point(414, 103);
            iD_UBBICACIONLabel.Name = "iD_UBBICACIONLabel";
            iD_UBBICACIONLabel.Size = new System.Drawing.Size(79, 15);
            iD_UBBICACIONLabel.TabIndex = 10;
            iD_UBBICACIONLabel.Text = "UBICACION:";
            // 
            // dOSISLabel
            // 
            dOSISLabel.AutoSize = true;
            dOSISLabel.Location = new System.Drawing.Point(30, 102);
            dOSISLabel.Name = "dOSISLabel";
            dOSISLabel.Size = new System.Drawing.Size(46, 15);
            dOSISLabel.TabIndex = 12;
            dOSISLabel.Text = "DOSIS:";
            // 
            // eSTADOLabel
            // 
            eSTADOLabel.AutoSize = true;
            eSTADOLabel.Location = new System.Drawing.Point(30, 143);
            eSTADOLabel.Name = "eSTADOLabel";
            eSTADOLabel.Size = new System.Drawing.Size(59, 15);
            eSTADOLabel.TabIndex = 14;
            eSTADOLabel.Text = "ESTADO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(30, 180);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(140, 15);
            label1.TabIndex = 27;
            label1.Text = "REALIZAR CONSULTA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(414, 143);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 15);
            label2.TabIndex = 28;
            label2.Text = "CANTIDAD:";
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
            this.iD_MEDICAMENTOTextBox.Location = new System.Drawing.Point(158, 21);
            this.iD_MEDICAMENTOTextBox.Name = "iD_MEDICAMENTOTextBox";
            this.iD_MEDICAMENTOTextBox.ReadOnly = true;
            this.iD_MEDICAMENTOTextBox.Size = new System.Drawing.Size(226, 22);
            this.iD_MEDICAMENTOTextBox.TabIndex = 3;
            // 
            // dESCRIPCIONTextBox
            // 
            this.dESCRIPCIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDICAMENTOBindingSource, "DESCRIPCION", true));
            this.dESCRIPCIONTextBox.Location = new System.Drawing.Point(158, 58);
            this.dESCRIPCIONTextBox.Name = "dESCRIPCIONTextBox";
            this.dESCRIPCIONTextBox.Size = new System.Drawing.Size(226, 22);
            this.dESCRIPCIONTextBox.TabIndex = 5;
            // 
            // dOSISTextBox
            // 
            this.dOSISTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDICAMENTOBindingSource, "DOSIS", true));
            this.dOSISTextBox.Location = new System.Drawing.Point(158, 98);
            this.dOSISTextBox.Name = "dOSISTextBox";
            this.dOSISTextBox.Size = new System.Drawing.Size(226, 22);
            this.dOSISTextBox.TabIndex = 13;
            // 
            // eSTADOComboBox
            // 
            this.eSTADOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mEDICAMENTOBindingSource, "ESTADO", true));
            this.eSTADOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eSTADOComboBox.FormattingEnabled = true;
            this.eSTADOComboBox.Location = new System.Drawing.Point(158, 140);
            this.eSTADOComboBox.Name = "eSTADOComboBox";
            this.eSTADOComboBox.Size = new System.Drawing.Size(226, 23);
            this.eSTADOComboBox.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mEDICAMENTODataGridView);
            this.panel1.Location = new System.Drawing.Point(22, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 321);
            this.panel1.TabIndex = 20;
            // 
            // mEDICAMENTODataGridView
            // 
            this.mEDICAMENTODataGridView.AllowUserToAddRows = false;
            this.mEDICAMENTODataGridView.AllowUserToDeleteRows = false;
            this.mEDICAMENTODataGridView.AutoGenerateColumns = false;
            this.mEDICAMENTODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mEDICAMENTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mEDICAMENTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMEDICAMENTODataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn,
            this.iDTFDataGridViewTextBoxColumn,
            this.iDMARCADataGridViewTextBoxColumn,
            this.iDUBBICACIONDataGridViewTextBoxColumn,
            this.dOSISDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.cANTIDADDataGridViewTextBoxColumn});
            this.mEDICAMENTODataGridView.DataSource = this.mEDICAMENTOBindingSource;
            this.mEDICAMENTODataGridView.Location = new System.Drawing.Point(4, 4);
            this.mEDICAMENTODataGridView.Name = "mEDICAMENTODataGridView";
            this.mEDICAMENTODataGridView.ReadOnly = true;
            this.mEDICAMENTODataGridView.Size = new System.Drawing.Size(881, 314);
            this.mEDICAMENTODataGridView.TabIndex = 0;
            this.mEDICAMENTODataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mEDICAMENTODataGridView_CellContentClick);
            // 
            // CBXUbicacion
            // 
            this.CBXUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXUbicacion.FormattingEnabled = true;
            this.CBXUbicacion.Location = new System.Drawing.Point(540, 102);
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
            this.CBXMarca.Location = new System.Drawing.Point(540, 61);
            this.CBXMarca.Name = "CBXMarca";
            this.CBXMarca.Size = new System.Drawing.Size(230, 23);
            this.CBXMarca.TabIndex = 22;
            // 
            // CBXtipoFarmaco
            // 
            this.CBXtipoFarmaco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXtipoFarmaco.FormattingEnabled = true;
            this.CBXtipoFarmaco.Location = new System.Drawing.Point(540, 22);
            this.CBXtipoFarmaco.Name = "CBXtipoFarmaco";
            this.CBXtipoFarmaco.Size = new System.Drawing.Size(230, 23);
            this.CBXtipoFarmaco.TabIndex = 23;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(290, 200);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(369, 22);
            this.txtsearch.TabIndex = 25;
            // 
            // selectsearch
            // 
            this.selectsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectsearch.FormattingEnabled = true;
            this.selectsearch.Items.AddRange(new object[] {
            "DESCRIPCION",
            "DOSIS",
            "ESTADO",
            "ID_TF",
            "ID_MARCA",
            "ID_UBICACION"});
            this.selectsearch.Location = new System.Drawing.Point(20, 199);
            this.selectsearch.Name = "selectsearch";
            this.selectsearch.Size = new System.Drawing.Size(251, 23);
            this.selectsearch.TabIndex = 24;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::_1ParcialJP.Properties.Resources.unnamed__2_;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(848, 158);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(62, 58);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGguardar
            // 
            this.btnGguardar.BackgroundImage = global::_1ParcialJP.Properties.Resources.save_icon;
            this.btnGguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGguardar.Location = new System.Drawing.Point(848, 93);
            this.btnGguardar.Name = "btnGguardar";
            this.btnGguardar.Size = new System.Drawing.Size(62, 59);
            this.btnGguardar.TabIndex = 17;
            this.btnGguardar.UseVisualStyleBackColor = true;
            this.btnGguardar.Click += new System.EventHandler(this.btnGguardar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::_1ParcialJP.Properties.Resources.add_1_icon__flatastic_1_iconset__custom_icon_design_0;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(848, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 59);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::_1ParcialJP.Properties.Resources._1024px_Search_Icon_svg;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(665, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 42);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.iD_MEDICAMENTOTextBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(eSTADOLabel);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.dOSISTextBox);
            this.groupBox1.Controls.Add(this.selectsearch);
            this.groupBox1.Controls.Add(dOSISLabel);
            this.groupBox1.Controls.Add(this.CBXtipoFarmaco);
            this.groupBox1.Controls.Add(iD_UBBICACIONLabel);
            this.groupBox1.Controls.Add(this.CBXMarca);
            this.groupBox1.Controls.Add(iD_MARCALabel);
            this.groupBox1.Controls.Add(this.CBXUbicacion);
            this.groupBox1.Controls.Add(iD_TFLabel);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dESCRIPCIONTextBox);
            this.groupBox1.Controls.Add(this.eSTADOComboBox);
            this.groupBox1.Controls.Add(dESCRIPCIONLabel);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(iD_MEDICAMENTOLabel);
            this.groupBox1.Controls.Add(this.btnGguardar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(223, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 571);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicamentos";
            // 
            // btnExportar
            // 
            this.btnExportar.BackgroundImage = global::_1ParcialJP.Properties.Resources.Microsoft_Excel_2013_logo_svg_;
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.Location = new System.Drawing.Point(803, 13);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(39, 38);
            this.btnExportar.TabIndex = 31;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(539, 143);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(120, 22);
            this.txtcantidad.TabIndex = 30;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.BackgroundImage = global::_1ParcialJP.Properties.Resources.x_png_33;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Location = new System.Drawing.Point(1166, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 40);
            this.button3.TabIndex = 29;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // iDMEDICAMENTODataGridViewTextBoxColumn
            // 
            this.iDMEDICAMENTODataGridViewTextBoxColumn.DataPropertyName = "ID_MEDICAMENTO";
            this.iDMEDICAMENTODataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDMEDICAMENTODataGridViewTextBoxColumn.Name = "iDMEDICAMENTODataGridViewTextBoxColumn";
            this.iDMEDICAMENTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            this.dESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDTFDataGridViewTextBoxColumn
            // 
            this.iDTFDataGridViewTextBoxColumn.DataPropertyName = "ID_TF";
            this.iDTFDataGridViewTextBoxColumn.HeaderText = "TIPO DE FARMACO";
            this.iDTFDataGridViewTextBoxColumn.Name = "iDTFDataGridViewTextBoxColumn";
            this.iDTFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDMARCADataGridViewTextBoxColumn
            // 
            this.iDMARCADataGridViewTextBoxColumn.DataPropertyName = "ID_MARCA";
            this.iDMARCADataGridViewTextBoxColumn.HeaderText = "MARCA";
            this.iDMARCADataGridViewTextBoxColumn.Name = "iDMARCADataGridViewTextBoxColumn";
            this.iDMARCADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDUBBICACIONDataGridViewTextBoxColumn
            // 
            this.iDUBBICACIONDataGridViewTextBoxColumn.DataPropertyName = "ID_UBBICACION";
            this.iDUBBICACIONDataGridViewTextBoxColumn.HeaderText = "UBICACION";
            this.iDUBBICACIONDataGridViewTextBoxColumn.Name = "iDUBBICACIONDataGridViewTextBoxColumn";
            this.iDUBBICACIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOSISDataGridViewTextBoxColumn
            // 
            this.dOSISDataGridViewTextBoxColumn.DataPropertyName = "DOSIS";
            this.dOSISDataGridViewTextBoxColumn.HeaderText = "DOSIS";
            this.dOSISDataGridViewTextBoxColumn.Name = "dOSISDataGridViewTextBoxColumn";
            this.dOSISDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            this.eSTADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cANTIDADDataGridViewTextBoxColumn
            // 
            this.cANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.HeaderText = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.Name = "cANTIDADDataGridViewTextBoxColumn";
            this.cANTIDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1309, 584);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMedicamento";
            this.Text = "Medicamentos";
            this.Load += new System.EventHandler(this.FrmMedicamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBICACIONBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PARCIALJPDataSet pARCIALJPDataSet;
        private System.Windows.Forms.BindingSource mEDICAMENTOBindingSource;
        private PARCIALJPDataSetTableAdapters.MEDICAMENTOTableAdapter mEDICAMENTOTableAdapter;
        private PARCIALJPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox selectsearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.DataGridView mEDICAMENTODataGridView;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMEDICAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMARCADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUBBICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOSISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDataGridViewTextBoxColumn;
    }
}