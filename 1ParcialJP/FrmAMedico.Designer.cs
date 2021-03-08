
namespace _1ParcialJP
{
    partial class FrmAMedico
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
            System.Windows.Forms.Label nOMBRELabel;
            System.Windows.Forms.Label cEDULALabel;
            System.Windows.Forms.Label tANDA_LABORLabel;
            System.Windows.Forms.Label eSPECIALIDADLabel;
            System.Windows.Forms.Label eSTADOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAMedico));
            this.eSTADOComboBox = new System.Windows.Forms.ComboBox();
            this.nOMBRETextBox = new System.Windows.Forms.TextBox();
            this.cEDULATextBox = new System.Windows.Forms.TextBox();
            this.eSPECIALIDADTextBox = new System.Windows.Forms.TextBox();
            this.btnGguardar = new System.Windows.Forms.Button();
            this.tANDA_LABORTextBox = new System.Windows.Forms.ComboBox();
            nOMBRELabel = new System.Windows.Forms.Label();
            cEDULALabel = new System.Windows.Forms.Label();
            tANDA_LABORLabel = new System.Windows.Forms.Label();
            eSPECIALIDADLabel = new System.Windows.Forms.Label();
            eSTADOLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(19, 22);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(63, 15);
            nOMBRELabel.TabIndex = 16;
            nOMBRELabel.Text = "NOMBRE:";
            // 
            // cEDULALabel
            // 
            cEDULALabel.AutoSize = true;
            cEDULALabel.Location = new System.Drawing.Point(19, 67);
            cEDULALabel.Name = "cEDULALabel";
            cEDULALabel.Size = new System.Drawing.Size(60, 15);
            cEDULALabel.TabIndex = 18;
            cEDULALabel.Text = "CEDULA:";
            // 
            // tANDA_LABORLabel
            // 
            tANDA_LABORLabel.AutoSize = true;
            tANDA_LABORLabel.Location = new System.Drawing.Point(370, 21);
            tANDA_LABORLabel.Name = "tANDA_LABORLabel";
            tANDA_LABORLabel.Size = new System.Drawing.Size(99, 15);
            tANDA_LABORLabel.TabIndex = 20;
            tANDA_LABORLabel.Text = "TANDA LABOR:";
            // 
            // eSPECIALIDADLabel
            // 
            eSPECIALIDADLabel.AutoSize = true;
            eSPECIALIDADLabel.Location = new System.Drawing.Point(19, 157);
            eSPECIALIDADLabel.Name = "eSPECIALIDADLabel";
            eSPECIALIDADLabel.Size = new System.Drawing.Size(99, 15);
            eSPECIALIDADLabel.TabIndex = 22;
            eSPECIALIDADLabel.Text = "ESPECIALIDAD:";
            // 
            // eSTADOLabel
            // 
            eSTADOLabel.AutoSize = true;
            eSTADOLabel.Location = new System.Drawing.Point(19, 107);
            eSTADOLabel.Name = "eSTADOLabel";
            eSTADOLabel.Size = new System.Drawing.Size(59, 15);
            eSTADOLabel.TabIndex = 24;
            eSTADOLabel.Text = "ESTADO:";
            // 
            // eSTADOComboBox
            // 
            this.eSTADOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eSTADOComboBox.FormattingEnabled = true;
            this.eSTADOComboBox.Items.AddRange(new object[] {
            "DISPONIBLE",
            "NO DISPONIBLE",
            "VACACIONES",
            "LICENCIA"});
            this.eSTADOComboBox.Location = new System.Drawing.Point(127, 104);
            this.eSTADOComboBox.Name = "eSTADOComboBox";
            this.eSTADOComboBox.Size = new System.Drawing.Size(223, 23);
            this.eSTADOComboBox.TabIndex = 25;
            // 
            // nOMBRETextBox
            // 
            this.nOMBRETextBox.Location = new System.Drawing.Point(127, 18);
            this.nOMBRETextBox.MaxLength = 30;
            this.nOMBRETextBox.Name = "nOMBRETextBox";
            this.nOMBRETextBox.Size = new System.Drawing.Size(223, 22);
            this.nOMBRETextBox.TabIndex = 17;
            // 
            // cEDULATextBox
            // 
            this.cEDULATextBox.Location = new System.Drawing.Point(127, 63);
            this.cEDULATextBox.MaxLength = 11;
            this.cEDULATextBox.Name = "cEDULATextBox";
            this.cEDULATextBox.Size = new System.Drawing.Size(223, 22);
            this.cEDULATextBox.TabIndex = 19;
            // 
            // eSPECIALIDADTextBox
            // 
            this.eSPECIALIDADTextBox.Location = new System.Drawing.Point(127, 153);
            this.eSPECIALIDADTextBox.MaxLength = 200;
            this.eSPECIALIDADTextBox.Name = "eSPECIALIDADTextBox";
            this.eSPECIALIDADTextBox.Size = new System.Drawing.Size(220, 22);
            this.eSPECIALIDADTextBox.TabIndex = 23;
            // 
            // btnGguardar
            // 
            this.btnGguardar.BackgroundImage = global::_1ParcialJP.Properties.Resources.save_icon;
            this.btnGguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGguardar.Location = new System.Drawing.Point(631, 132);
            this.btnGguardar.Name = "btnGguardar";
            this.btnGguardar.Size = new System.Drawing.Size(67, 64);
            this.btnGguardar.TabIndex = 26;
            this.btnGguardar.UseVisualStyleBackColor = true;
            this.btnGguardar.Click += new System.EventHandler(this.btnGguardar_Click_1);
            // 
            // tANDA_LABORTextBox
            // 
            this.tANDA_LABORTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tANDA_LABORTextBox.FormattingEnabled = true;
            this.tANDA_LABORTextBox.Items.AddRange(new object[] {
            "MATUTINO",
            "VESPERTINO",
            "NOCTURNO"});
            this.tANDA_LABORTextBox.Location = new System.Drawing.Point(487, 19);
            this.tANDA_LABORTextBox.Name = "tANDA_LABORTextBox";
            this.tANDA_LABORTextBox.Size = new System.Drawing.Size(190, 23);
            this.tANDA_LABORTextBox.TabIndex = 27;
            // 
            // FrmAMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(709, 204);
            this.Controls.Add(this.tANDA_LABORTextBox);
            this.Controls.Add(this.btnGguardar);
            this.Controls.Add(this.eSTADOComboBox);
            this.Controls.Add(nOMBRELabel);
            this.Controls.Add(this.nOMBRETextBox);
            this.Controls.Add(cEDULALabel);
            this.Controls.Add(this.cEDULATextBox);
            this.Controls.Add(tANDA_LABORLabel);
            this.Controls.Add(eSPECIALIDADLabel);
            this.Controls.Add(this.eSPECIALIDADTextBox);
            this.Controls.Add(eSTADOLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAMedico";
            this.Text = "Agregar Medico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAMedico_FormClosed);
            this.Load += new System.EventHandler(this.FrmAMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox eSTADOComboBox;
        private System.Windows.Forms.TextBox nOMBRETextBox;
        private System.Windows.Forms.TextBox cEDULATextBox;
        private System.Windows.Forms.TextBox eSPECIALIDADTextBox;
        private System.Windows.Forms.Button btnGguardar;
        private System.Windows.Forms.ComboBox tANDA_LABORTextBox;
    }
}