
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
            System.Windows.Forms.Label label1;
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
            this.button2 = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.selectsearch = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            iD_UBICACIONLabel = new System.Windows.Forms.Label();
            dESCRIPCIONLabel = new System.Windows.Forms.Label();
            eSTANTELabel = new System.Windows.Forms.Label();
            tRAMOLabel = new System.Windows.Forms.Label();
            cELDALabel = new System.Windows.Forms.Label();
            eSTADOLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBICACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBICACIONDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_UBICACIONLabel
            // 
            iD_UBICACIONLabel.AutoSize = true;
            iD_UBICACIONLabel.Location = new System.Drawing.Point(15, 23);
            iD_UBICACIONLabel.Name = "iD_UBICACIONLabel";
            iD_UBICACIONLabel.Size = new System.Drawing.Size(95, 15);
            iD_UBICACIONLabel.TabIndex = 2;
            iD_UBICACIONLabel.Text = "ID UBICACION:";
            // 
            // dESCRIPCIONLabel
            // 
            dESCRIPCIONLabel.AutoSize = true;
            dESCRIPCIONLabel.Location = new System.Drawing.Point(316, 54);
            dESCRIPCIONLabel.Name = "dESCRIPCIONLabel";
            dESCRIPCIONLabel.Size = new System.Drawing.Size(90, 15);
            dESCRIPCIONLabel.TabIndex = 4;
            dESCRIPCIONLabel.Text = "DESCRIPCION:";
            // 
            // eSTANTELabel
            // 
            eSTANTELabel.AutoSize = true;
            eSTANTELabel.Location = new System.Drawing.Point(15, 54);
            eSTANTELabel.Name = "eSTANTELabel";
            eSTANTELabel.Size = new System.Drawing.Size(65, 15);
            eSTANTELabel.TabIndex = 6;
            eSTANTELabel.Text = "ESTANTE:";
            // 
            // tRAMOLabel
            // 
            tRAMOLabel.AutoSize = true;
            tRAMOLabel.Location = new System.Drawing.Point(15, 90);
            tRAMOLabel.Name = "tRAMOLabel";
            tRAMOLabel.Size = new System.Drawing.Size(57, 15);
            tRAMOLabel.TabIndex = 8;
            tRAMOLabel.Text = "TRAMO:";
            // 
            // cELDALabel
            // 
            cELDALabel.AutoSize = true;
            cELDALabel.Location = new System.Drawing.Point(15, 128);
            cELDALabel.Name = "cELDALabel";
            cELDALabel.Size = new System.Drawing.Size(51, 15);
            cELDALabel.TabIndex = 10;
            cELDALabel.Text = "CELDA:";
            // 
            // eSTADOLabel
            // 
            eSTADOLabel.AutoSize = true;
            eSTADOLabel.Location = new System.Drawing.Point(316, 18);
            eSTADOLabel.Name = "eSTADOLabel";
            eSTADOLabel.Size = new System.Drawing.Size(59, 15);
            eSTADOLabel.TabIndex = 12;
            eSTADOLabel.Text = "ESTADO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(14, 190);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(164, 17);
            label1.TabIndex = 24;
            label1.Text = "REALIZAR CONSULTA";
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
            this.uBICACIONDataGridView.Size = new System.Drawing.Size(709, 328);
            this.uBICACIONDataGridView.TabIndex = 1;
            this.uBICACIONDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uBICACIONDataGridView_CellContentClick_1);
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
            this.panel1.Location = new System.Drawing.Point(5, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 328);
            this.panel1.TabIndex = 2;
            // 
            // dESCRIPCIONTextBox
            // 
            this.dESCRIPCIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uBICACIONBindingSource, "DESCRIPCION", true));
            this.dESCRIPCIONTextBox.Location = new System.Drawing.Point(420, 51);
            this.dESCRIPCIONTextBox.MaxLength = 200;
            this.dESCRIPCIONTextBox.Multiline = true;
            this.dESCRIPCIONTextBox.Name = "dESCRIPCIONTextBox";
            this.dESCRIPCIONTextBox.Size = new System.Drawing.Size(210, 92);
            this.dESCRIPCIONTextBox.TabIndex = 5;
            // 
            // eSTANTETextBox
            // 
            this.eSTANTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uBICACIONBindingSource, "ESTANTE", true));
            this.eSTANTETextBox.Enabled = false;
            this.eSTANTETextBox.Location = new System.Drawing.Point(118, 51);
            this.eSTANTETextBox.MaxLength = 20;
            this.eSTANTETextBox.Name = "eSTANTETextBox";
            this.eSTANTETextBox.ReadOnly = true;
            this.eSTANTETextBox.Size = new System.Drawing.Size(182, 22);
            this.eSTANTETextBox.TabIndex = 7;
            // 
            // tRAMOTextBox
            // 
            this.tRAMOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uBICACIONBindingSource, "TRAMO", true));
            this.tRAMOTextBox.Enabled = false;
            this.tRAMOTextBox.Location = new System.Drawing.Point(118, 87);
            this.tRAMOTextBox.MaxLength = 20;
            this.tRAMOTextBox.Name = "tRAMOTextBox";
            this.tRAMOTextBox.ReadOnly = true;
            this.tRAMOTextBox.Size = new System.Drawing.Size(182, 22);
            this.tRAMOTextBox.TabIndex = 9;
            // 
            // cELDATextBox
            // 
            this.cELDATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uBICACIONBindingSource, "CELDA", true));
            this.cELDATextBox.Enabled = false;
            this.cELDATextBox.Location = new System.Drawing.Point(118, 125);
            this.cELDATextBox.MaxLength = 20;
            this.cELDATextBox.Name = "cELDATextBox";
            this.cELDATextBox.ReadOnly = true;
            this.cELDATextBox.Size = new System.Drawing.Size(182, 22);
            this.cELDATextBox.TabIndex = 11;
            // 
            // iD_UBICACIONTextBox
            // 
            this.iD_UBICACIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uBICACIONBindingSource, "ID_UBICACION", true));
            this.iD_UBICACIONTextBox.Location = new System.Drawing.Point(118, 15);
            this.iD_UBICACIONTextBox.MaxLength = 5;
            this.iD_UBICACIONTextBox.Name = "iD_UBICACIONTextBox";
            this.iD_UBICACIONTextBox.ReadOnly = true;
            this.iD_UBICACIONTextBox.Size = new System.Drawing.Size(182, 22);
            this.iD_UBICACIONTextBox.TabIndex = 14;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::_1ParcialJP.Properties.Resources.unnamed__2_;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(650, 151);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 63);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGguardar
            // 
            this.btnGguardar.BackgroundImage = global::_1ParcialJP.Properties.Resources.save_icon;
            this.btnGguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGguardar.Location = new System.Drawing.Point(650, 82);
            this.btnGguardar.Name = "btnGguardar";
            this.btnGguardar.Size = new System.Drawing.Size(64, 63);
            this.btnGguardar.TabIndex = 18;
            this.btnGguardar.UseVisualStyleBackColor = true;
            this.btnGguardar.Click += new System.EventHandler(this.btnGguardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::_1ParcialJP.Properties.Resources.add_1_icon__flatastic_1_iconset__custom_icon_design_0;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Location = new System.Drawing.Point(650, 11);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(64, 65);
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
            this.eSTADOComboBox.Location = new System.Drawing.Point(420, 15);
            this.eSTADOComboBox.Name = "eSTADOComboBox";
            this.eSTADOComboBox.Size = new System.Drawing.Size(210, 23);
            this.eSTADOComboBox.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::_1ParcialJP.Properties.Resources._1024px_Search_Icon_svg;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(587, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 48);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(232, 209);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(349, 22);
            this.txtsearch.TabIndex = 22;
            // 
            // selectsearch
            // 
            this.selectsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectsearch.FormattingEnabled = true;
            this.selectsearch.Items.AddRange(new object[] {
            "ESTANTE",
            "TRAMO",
            "CELDA",
            "ESTADO",
            "DESCRIPCION"});
            this.selectsearch.Location = new System.Drawing.Point(8, 208);
            this.selectsearch.Name = "selectsearch";
            this.selectsearch.Size = new System.Drawing.Size(218, 23);
            this.selectsearch.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(eSTADOLabel);
            this.groupBox1.Controls.Add(this.selectsearch);
            this.groupBox1.Controls.Add(this.cELDATextBox);
            this.groupBox1.Controls.Add(this.eSTADOComboBox);
            this.groupBox1.Controls.Add(cELDALabel);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.tRAMOTextBox);
            this.groupBox1.Controls.Add(this.btnGguardar);
            this.groupBox1.Controls.Add(tRAMOLabel);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.eSTANTETextBox);
            this.groupBox1.Controls.Add(this.iD_UBICACIONTextBox);
            this.groupBox1.Controls.Add(eSTANTELabel);
            this.groupBox1.Controls.Add(iD_UBICACIONLabel);
            this.groupBox1.Controls.Add(this.dESCRIPCIONTextBox);
            this.groupBox1.Controls.Add(dESCRIPCIONLabel);
            this.groupBox1.Location = new System.Drawing.Point(223, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 571);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ubicaciones";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.BackgroundImage = global::_1ParcialJP.Properties.Resources.x_png_33;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Location = new System.Drawing.Point(978, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 40);
            this.button3.TabIndex = 26;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1183, 584);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox selectsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
    }
}