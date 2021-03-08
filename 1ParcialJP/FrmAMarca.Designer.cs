
namespace _1ParcialJP
{
    partial class FrmAMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAMarca));
            this.pARCIALJPDataSet = new _1ParcialJP.PARCIALJPDataSet();
            this.mARCABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mARCATableAdapter = new _1ParcialJP.PARCIALJPDataSetTableAdapters.MARCATableAdapter();
            this.tableAdapterManager = new _1ParcialJP.PARCIALJPDataSetTableAdapters.TableAdapterManager();
            this.dESCRIPCIONTextBox = new System.Windows.Forms.TextBox();
            this.eSTADOComboBox = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            dESCRIPCIONLabel = new System.Windows.Forms.Label();
            eSTADOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dESCRIPCIONLabel
            // 
            dESCRIPCIONLabel.AutoSize = true;
            dESCRIPCIONLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dESCRIPCIONLabel.Location = new System.Drawing.Point(12, 56);
            dESCRIPCIONLabel.Name = "dESCRIPCIONLabel";
            dESCRIPCIONLabel.Size = new System.Drawing.Size(90, 15);
            dESCRIPCIONLabel.TabIndex = 0;
            dESCRIPCIONLabel.Text = "DESCRIPCION:";
            // 
            // eSTADOLabel
            // 
            eSTADOLabel.AutoSize = true;
            eSTADOLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eSTADOLabel.Location = new System.Drawing.Point(12, 22);
            eSTADOLabel.Name = "eSTADOLabel";
            eSTADOLabel.Size = new System.Drawing.Size(59, 15);
            eSTADOLabel.TabIndex = 2;
            eSTADOLabel.Text = "ESTADO:";
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
            // dESCRIPCIONTextBox
            // 
            this.dESCRIPCIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mARCABindingSource, "DESCRIPCION", true));
            this.dESCRIPCIONTextBox.Location = new System.Drawing.Point(103, 53);
            this.dESCRIPCIONTextBox.Multiline = true;
            this.dESCRIPCIONTextBox.Name = "dESCRIPCIONTextBox";
            this.dESCRIPCIONTextBox.Size = new System.Drawing.Size(198, 109);
            this.dESCRIPCIONTextBox.TabIndex = 1;
            // 
            // eSTADOComboBox
            // 
            this.eSTADOComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.eSTADOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mARCABindingSource, "ESTADO", true));
            this.eSTADOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eSTADOComboBox.FormattingEnabled = true;
            this.eSTADOComboBox.Items.AddRange(new object[] {
            "ACTIVA",
            "INACTIVA"});
            this.eSTADOComboBox.Location = new System.Drawing.Point(103, 19);
            this.eSTADOComboBox.Name = "eSTADOComboBox";
            this.eSTADOComboBox.Size = new System.Drawing.Size(198, 21);
            this.eSTADOComboBox.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::_1ParcialJP.Properties.Resources.save_icon;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(318, 56);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 67);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmAMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(405, 181);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(eSTADOLabel);
            this.Controls.Add(this.eSTADOComboBox);
            this.Controls.Add(dESCRIPCIONLabel);
            this.Controls.Add(this.dESCRIPCIONTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAMarca";
            this.Text = "Agregar Marca";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAMarca_FormClosed);
            this.Load += new System.EventHandler(this.FrmAMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pARCIALJPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PARCIALJPDataSet pARCIALJPDataSet;
        private System.Windows.Forms.BindingSource mARCABindingSource;
        private PARCIALJPDataSetTableAdapters.MARCATableAdapter mARCATableAdapter;
        private PARCIALJPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox dESCRIPCIONTextBox;
        private System.Windows.Forms.ComboBox eSTADOComboBox;
        private System.Windows.Forms.Button btnGuardar;
    }
}