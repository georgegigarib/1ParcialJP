
namespace _1ParcialJP
{
    partial class FrmMarca
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
            System.Windows.Forms.Label dESCRIPCIONLabel;
            System.Windows.Forms.Label eSTADOLabel;
            System.Windows.Forms.Label iD_MARCALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarca));
            this.pARCIALJPDataSet = new _1ParcialJP.PARCIALJPDataSet();
            this.mARCABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mARCATableAdapter = new _1ParcialJP.PARCIALJPDataSetTableAdapters.MARCATableAdapter();
            this.tableAdapterManager = new _1ParcialJP.PARCIALJPDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mARCADataGridView = new System.Windows.Forms.DataGridView();
            this.iDMARCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGguardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dESCRIPCIONTextBox = new System.Windows.Forms.TextBox();
            this.eSTADOComboBox = new System.Windows.Forms.ComboBox();
            this.iD_MARCATextBox = new System.Windows.Forms.TextBox();
            dESCRIPCIONLabel = new System.Windows.Forms.Label();
            eSTADOLabel = new System.Windows.Forms.Label();
            iD_MARCALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCABindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mARCADataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dESCRIPCIONLabel
            // 
            dESCRIPCIONLabel.AutoSize = true;
            dESCRIPCIONLabel.Location = new System.Drawing.Point(14, 83);
            dESCRIPCIONLabel.Name = "dESCRIPCIONLabel";
            dESCRIPCIONLabel.Size = new System.Drawing.Size(74, 15);
            dESCRIPCIONLabel.TabIndex = 3;
            dESCRIPCIONLabel.Text = "Descripcion:";
            // 
            // eSTADOLabel
            // 
            eSTADOLabel.AutoSize = true;
            eSTADOLabel.Location = new System.Drawing.Point(14, 53);
            eSTADOLabel.Name = "eSTADOLabel";
            eSTADOLabel.Size = new System.Drawing.Size(44, 15);
            eSTADOLabel.TabIndex = 5;
            eSTADOLabel.Text = "Estado";
            // 
            // iD_MARCALabel
            // 
            iD_MARCALabel.AutoSize = true;
            iD_MARCALabel.Location = new System.Drawing.Point(14, 23);
            iD_MARCALabel.Name = "iD_MARCALabel";
            iD_MARCALabel.Size = new System.Drawing.Size(23, 15);
            iD_MARCALabel.TabIndex = 6;
            iD_MARCALabel.Text = "ID:";
            // 
            // pARCIALJPDataSet
            // 
            this.pARCIALJPDataSet.DataSetName = "PARCIALJPDataSet";
            this.pARCIALJPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mARCABindingSource
            // 
            this.mARCABindingSource.DataMember = "MARCA";
            this.mARCABindingSource.DataSource = this.pARCIALJPDataSet;
            // 
            // mARCATableAdapter
            // 
            this.mARCATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MARCATableAdapter = this.mARCATableAdapter;
            this.tableAdapterManager.MEDICAMENTOTableAdapter = null;
            this.tableAdapterManager.MEDICOTableAdapter = null;
            this.tableAdapterManager.PACIENTETableAdapter = null;
            this.tableAdapterManager.TIPO_FARMACOTableAdapter = null;
            this.tableAdapterManager.UBICACIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _1ParcialJP.PARCIALJPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VISITATableAdapter = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mARCADataGridView);
            this.panel1.Location = new System.Drawing.Point(14, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 264);
            this.panel1.TabIndex = 8;
            // 
            // mARCADataGridView
            // 
            this.mARCADataGridView.AllowUserToAddRows = false;
            this.mARCADataGridView.AllowUserToDeleteRows = false;
            this.mARCADataGridView.AutoGenerateColumns = false;
            this.mARCADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mARCADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMARCADataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn});
            this.mARCADataGridView.DataSource = this.mARCABindingSource;
            this.mARCADataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mARCADataGridView.Location = new System.Drawing.Point(0, 0);
            this.mARCADataGridView.Name = "mARCADataGridView";
            this.mARCADataGridView.ReadOnly = true;
            this.mARCADataGridView.Size = new System.Drawing.Size(419, 264);
            this.mARCADataGridView.TabIndex = 0;
            this.mARCADataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mARCADataGridView_CellContentClick_1);
            // 
            // iDMARCADataGridViewTextBoxColumn
            // 
            this.iDMARCADataGridViewTextBoxColumn.DataPropertyName = "ID_MARCA";
            this.iDMARCADataGridViewTextBoxColumn.HeaderText = "ID_MARCA";
            this.iDMARCADataGridViewTextBoxColumn.Name = "iDMARCADataGridViewTextBoxColumn";
            this.iDMARCADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            this.dESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRIPCIONDataGridViewTextBoxColumn.Width = 112;
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            this.eSTADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::_1ParcialJP.Properties.Resources.add_1_icon__flatastic_1_iconset__custom_icon_design_0;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(359, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 56);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGguardar
            // 
            this.btnGguardar.BackgroundImage = global::_1ParcialJP.Properties.Resources.save_icon;
            this.btnGguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGguardar.Location = new System.Drawing.Point(359, 75);
            this.btnGguardar.Name = "btnGguardar";
            this.btnGguardar.Size = new System.Drawing.Size(61, 57);
            this.btnGguardar.TabIndex = 10;
            this.btnGguardar.UseVisualStyleBackColor = true;
            this.btnGguardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::_1ParcialJP.Properties.Resources.unnamed__2_;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(359, 138);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(61, 55);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dESCRIPCIONTextBox
            // 
            this.dESCRIPCIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mARCABindingSource, "DESCRIPCION", true));
            this.dESCRIPCIONTextBox.Location = new System.Drawing.Point(98, 80);
            this.dESCRIPCIONTextBox.MaxLength = 200;
            this.dESCRIPCIONTextBox.Multiline = true;
            this.dESCRIPCIONTextBox.Name = "dESCRIPCIONTextBox";
            this.dESCRIPCIONTextBox.Size = new System.Drawing.Size(245, 133);
            this.dESCRIPCIONTextBox.TabIndex = 4;
            // 
            // eSTADOComboBox
            // 
            this.eSTADOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mARCABindingSource, "ESTADO", true));
            this.eSTADOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mARCABindingSource, "ESTADO", true));
            this.eSTADOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eSTADOComboBox.FormattingEnabled = true;
            this.eSTADOComboBox.Items.AddRange(new object[] {
            "ACTIVA",
            "INACTIVA"});
            this.eSTADOComboBox.Location = new System.Drawing.Point(98, 48);
            this.eSTADOComboBox.Name = "eSTADOComboBox";
            this.eSTADOComboBox.Size = new System.Drawing.Size(182, 23);
            this.eSTADOComboBox.TabIndex = 12;
            // 
            // iD_MARCATextBox
            // 
            this.iD_MARCATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mARCABindingSource, "ID_MARCA", true));
            this.iD_MARCATextBox.Location = new System.Drawing.Point(98, 20);
            this.iD_MARCATextBox.Name = "iD_MARCATextBox";
            this.iD_MARCATextBox.ReadOnly = true;
            this.iD_MARCATextBox.Size = new System.Drawing.Size(182, 22);
            this.iD_MARCATextBox.TabIndex = 7;
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(450, 501);
            this.Controls.Add(this.eSTADOComboBox);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGguardar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(iD_MARCALabel);
            this.Controls.Add(this.iD_MARCATextBox);
            this.Controls.Add(dESCRIPCIONLabel);
            this.Controls.Add(this.dESCRIPCIONTextBox);
            this.Controls.Add(eSTADOLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMarca";
            this.Text = "Marcas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMarca_FormClosed);
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCABindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mARCADataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PARCIALJPDataSet pARCIALJPDataSet;
        private System.Windows.Forms.BindingSource mARCABindingSource;
        private PARCIALJPDataSetTableAdapters.MARCATableAdapter mARCATableAdapter;
        private PARCIALJPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGguardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView mARCADataGridView;
        private System.Windows.Forms.TextBox dESCRIPCIONTextBox;
        private System.Windows.Forms.ComboBox eSTADOComboBox;
        private System.Windows.Forms.TextBox iD_MARCATextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMARCADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
    }
}

