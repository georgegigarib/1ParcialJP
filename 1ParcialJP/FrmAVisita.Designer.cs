
namespace _1ParcialJP
{
    partial class FrmAVisita
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
            System.Windows.Forms.Label nOMBRE_MEDICOLabel;
            System.Windows.Forms.Label nOMBRE_PACIENTELabel;
            System.Windows.Forms.Label fECHALabel;
            System.Windows.Forms.Label hORALabel;
            System.Windows.Forms.Label sINTOMASLabel;
            System.Windows.Forms.Label mEDICAMENTOSLabel;
            System.Windows.Forms.Label rECOMENDACIONESLabel;
            System.Windows.Forms.Label eSTADOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAVisita));
            this.nOMBRE_MEDICOComboBox = new System.Windows.Forms.ComboBox();
            this.CBXPACIENTE = new System.Windows.Forms.ComboBox();
            this.hORADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fECHADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sINTOMASTextBox = new System.Windows.Forms.TextBox();
            this.mEDICAMENTOSTextBox = new System.Windows.Forms.TextBox();
            this.rECOMENDACIONESTextBox = new System.Windows.Forms.TextBox();
            this.eSTADOTextBox = new System.Windows.Forms.TextBox();
            this.btnGguardar = new System.Windows.Forms.Button();
            nOMBRE_MEDICOLabel = new System.Windows.Forms.Label();
            nOMBRE_PACIENTELabel = new System.Windows.Forms.Label();
            fECHALabel = new System.Windows.Forms.Label();
            hORALabel = new System.Windows.Forms.Label();
            sINTOMASLabel = new System.Windows.Forms.Label();
            mEDICAMENTOSLabel = new System.Windows.Forms.Label();
            rECOMENDACIONESLabel = new System.Windows.Forms.Label();
            eSTADOLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nOMBRE_MEDICOLabel
            // 
            nOMBRE_MEDICOLabel.AutoSize = true;
            nOMBRE_MEDICOLabel.Location = new System.Drawing.Point(19, 24);
            nOMBRE_MEDICOLabel.Name = "nOMBRE_MEDICOLabel";
            nOMBRE_MEDICOLabel.Size = new System.Drawing.Size(115, 15);
            nOMBRE_MEDICOLabel.TabIndex = 30;
            nOMBRE_MEDICOLabel.Text = "NOMBRE MEDICO:";
            // 
            // nOMBRE_PACIENTELabel
            // 
            nOMBRE_PACIENTELabel.AutoSize = true;
            nOMBRE_PACIENTELabel.Location = new System.Drawing.Point(19, 58);
            nOMBRE_PACIENTELabel.Name = "nOMBRE_PACIENTELabel";
            nOMBRE_PACIENTELabel.Size = new System.Drawing.Size(125, 15);
            nOMBRE_PACIENTELabel.TabIndex = 31;
            nOMBRE_PACIENTELabel.Text = "NOMBRE PACIENTE:";
            // 
            // fECHALabel
            // 
            fECHALabel.AutoSize = true;
            fECHALabel.Location = new System.Drawing.Point(19, 137);
            fECHALabel.Name = "fECHALabel";
            fECHALabel.Size = new System.Drawing.Size(51, 15);
            fECHALabel.TabIndex = 32;
            fECHALabel.Text = "FECHA:";
            // 
            // hORALabel
            // 
            hORALabel.AutoSize = true;
            hORALabel.Location = new System.Drawing.Point(19, 167);
            hORALabel.Name = "hORALabel";
            hORALabel.Size = new System.Drawing.Size(46, 15);
            hORALabel.TabIndex = 34;
            hORALabel.Text = "HORA:";
            // 
            // sINTOMASLabel
            // 
            sINTOMASLabel.AutoSize = true;
            sINTOMASLabel.Location = new System.Drawing.Point(19, 211);
            sINTOMASLabel.Name = "sINTOMASLabel";
            sINTOMASLabel.Size = new System.Drawing.Size(76, 15);
            sINTOMASLabel.TabIndex = 35;
            sINTOMASLabel.Text = "SINTOMAS:";
            // 
            // mEDICAMENTOSLabel
            // 
            mEDICAMENTOSLabel.AutoSize = true;
            mEDICAMENTOSLabel.Location = new System.Drawing.Point(21, 406);
            mEDICAMENTOSLabel.Name = "mEDICAMENTOSLabel";
            mEDICAMENTOSLabel.Size = new System.Drawing.Size(112, 15);
            mEDICAMENTOSLabel.TabIndex = 37;
            mEDICAMENTOSLabel.Text = "MEDICAMENTOS:";
            // 
            // rECOMENDACIONESLabel
            // 
            rECOMENDACIONESLabel.AutoSize = true;
            rECOMENDACIONESLabel.Location = new System.Drawing.Point(19, 306);
            rECOMENDACIONESLabel.Name = "rECOMENDACIONESLabel";
            rECOMENDACIONESLabel.Size = new System.Drawing.Size(133, 15);
            rECOMENDACIONESLabel.TabIndex = 39;
            rECOMENDACIONESLabel.Text = "RECOMENDACIONES:";
            // 
            // eSTADOLabel
            // 
            eSTADOLabel.AutoSize = true;
            eSTADOLabel.Location = new System.Drawing.Point(19, 95);
            eSTADOLabel.Name = "eSTADOLabel";
            eSTADOLabel.Size = new System.Drawing.Size(59, 15);
            eSTADOLabel.TabIndex = 41;
            eSTADOLabel.Text = "ESTADO:";
            // 
            // nOMBRE_MEDICOComboBox
            // 
            this.nOMBRE_MEDICOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nOMBRE_MEDICOComboBox.FormattingEnabled = true;
            this.nOMBRE_MEDICOComboBox.Location = new System.Drawing.Point(164, 21);
            this.nOMBRE_MEDICOComboBox.Name = "nOMBRE_MEDICOComboBox";
            this.nOMBRE_MEDICOComboBox.Size = new System.Drawing.Size(233, 23);
            this.nOMBRE_MEDICOComboBox.TabIndex = 46;
            // 
            // CBXPACIENTE
            // 
            this.CBXPACIENTE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXPACIENTE.FormattingEnabled = true;
            this.CBXPACIENTE.Location = new System.Drawing.Point(164, 54);
            this.CBXPACIENTE.Name = "CBXPACIENTE";
            this.CBXPACIENTE.Size = new System.Drawing.Size(233, 23);
            this.CBXPACIENTE.TabIndex = 45;
            // 
            // hORADateTimePicker
            // 
            this.hORADateTimePicker.CustomFormat = "hh-mm-ss";
            this.hORADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hORADateTimePicker.Location = new System.Drawing.Point(164, 159);
            this.hORADateTimePicker.Name = "hORADateTimePicker";
            this.hORADateTimePicker.ShowUpDown = true;
            this.hORADateTimePicker.Size = new System.Drawing.Size(140, 22);
            this.hORADateTimePicker.TabIndex = 43;
            // 
            // fECHADateTimePicker
            // 
            this.fECHADateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.fECHADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fECHADateTimePicker.Location = new System.Drawing.Point(164, 129);
            this.fECHADateTimePicker.Name = "fECHADateTimePicker";
            this.fECHADateTimePicker.Size = new System.Drawing.Size(140, 22);
            this.fECHADateTimePicker.TabIndex = 33;
            this.fECHADateTimePicker.Value = new System.DateTime(2021, 2, 11, 0, 0, 0, 0);
            // 
            // sINTOMASTextBox
            // 
            this.sINTOMASTextBox.Location = new System.Drawing.Point(164, 208);
            this.sINTOMASTextBox.MaxLength = 2000;
            this.sINTOMASTextBox.Multiline = true;
            this.sINTOMASTextBox.Name = "sINTOMASTextBox";
            this.sINTOMASTextBox.Size = new System.Drawing.Size(194, 67);
            this.sINTOMASTextBox.TabIndex = 36;
            // 
            // mEDICAMENTOSTextBox
            // 
            this.mEDICAMENTOSTextBox.Location = new System.Drawing.Point(164, 403);
            this.mEDICAMENTOSTextBox.MaxLength = 200;
            this.mEDICAMENTOSTextBox.Multiline = true;
            this.mEDICAMENTOSTextBox.Name = "mEDICAMENTOSTextBox";
            this.mEDICAMENTOSTextBox.Size = new System.Drawing.Size(189, 94);
            this.mEDICAMENTOSTextBox.TabIndex = 38;
            // 
            // rECOMENDACIONESTextBox
            // 
            this.rECOMENDACIONESTextBox.Location = new System.Drawing.Point(164, 302);
            this.rECOMENDACIONESTextBox.MaxLength = 200;
            this.rECOMENDACIONESTextBox.Multiline = true;
            this.rECOMENDACIONESTextBox.Name = "rECOMENDACIONESTextBox";
            this.rECOMENDACIONESTextBox.Size = new System.Drawing.Size(189, 70);
            this.rECOMENDACIONESTextBox.TabIndex = 40;
            // 
            // eSTADOTextBox
            // 
            this.eSTADOTextBox.Location = new System.Drawing.Point(164, 91);
            this.eSTADOTextBox.MaxLength = 20;
            this.eSTADOTextBox.Name = "eSTADOTextBox";
            this.eSTADOTextBox.Size = new System.Drawing.Size(233, 22);
            this.eSTADOTextBox.TabIndex = 42;
            // 
            // btnGguardar
            // 
            this.btnGguardar.BackgroundImage = global::_1ParcialJP.Properties.Resources.save_icon;
            this.btnGguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGguardar.Location = new System.Drawing.Point(405, 415);
            this.btnGguardar.Name = "btnGguardar";
            this.btnGguardar.Size = new System.Drawing.Size(85, 84);
            this.btnGguardar.TabIndex = 47;
            this.btnGguardar.UseVisualStyleBackColor = true;
            this.btnGguardar.Click += new System.EventHandler(this.btnGguardar_Click);
            // 
            // FrmAVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 511);
            this.Controls.Add(this.btnGguardar);
            this.Controls.Add(this.nOMBRE_MEDICOComboBox);
            this.Controls.Add(this.CBXPACIENTE);
            this.Controls.Add(this.hORADateTimePicker);
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
            this.Name = "FrmAVisita";
            this.Text = "Registrar Visita";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAVisita_FormClosed);
            this.Load += new System.EventHandler(this.FrmAVisita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox nOMBRE_MEDICOComboBox;
        private System.Windows.Forms.ComboBox CBXPACIENTE;
        private System.Windows.Forms.DateTimePicker hORADateTimePicker;
        private System.Windows.Forms.DateTimePicker fECHADateTimePicker;
        private System.Windows.Forms.TextBox sINTOMASTextBox;
        private System.Windows.Forms.TextBox mEDICAMENTOSTextBox;
        private System.Windows.Forms.TextBox rECOMENDACIONESTextBox;
        private System.Windows.Forms.TextBox eSTADOTextBox;
        private System.Windows.Forms.Button btnGguardar;
    }
}