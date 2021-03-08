
namespace _1ParcialJP
{
    partial class FrmAPaciente
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
            System.Windows.Forms.Label eSTADOLabel1;
            System.Windows.Forms.Label nOMBRELabel;
            System.Windows.Forms.Label cEDULALabel;
            System.Windows.Forms.Label nUM_CARNETLabel;
            System.Windows.Forms.Label tIPO_PACIENTELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAPaciente));
            this.tIPO_PACIENTEComboBox = new System.Windows.Forms.ComboBox();
            this.nOMBRETextBox = new System.Windows.Forms.TextBox();
            this.cEDULATextBox = new System.Windows.Forms.TextBox();
            this.nUM_CARNETTextBox = new System.Windows.Forms.TextBox();
            this.btnGguardar = new System.Windows.Forms.Button();
            this.eSTADOComboBox = new System.Windows.Forms.ComboBox();
            eSTADOLabel1 = new System.Windows.Forms.Label();
            nOMBRELabel = new System.Windows.Forms.Label();
            cEDULALabel = new System.Windows.Forms.Label();
            nUM_CARNETLabel = new System.Windows.Forms.Label();
            tIPO_PACIENTELabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eSTADOLabel1
            // 
            eSTADOLabel1.AutoSize = true;
            eSTADOLabel1.Location = new System.Drawing.Point(380, 23);
            eSTADOLabel1.Name = "eSTADOLabel1";
            eSTADOLabel1.Size = new System.Drawing.Size(59, 15);
            eSTADOLabel1.TabIndex = 32;
            eSTADOLabel1.Text = "ESTADO:";
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(26, 27);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(63, 15);
            nOMBRELabel.TabIndex = 24;
            nOMBRELabel.Text = "NOMBRE:";
            // 
            // cEDULALabel
            // 
            cEDULALabel.AutoSize = true;
            cEDULALabel.Location = new System.Drawing.Point(26, 67);
            cEDULALabel.Name = "cEDULALabel";
            cEDULALabel.Size = new System.Drawing.Size(60, 15);
            cEDULALabel.TabIndex = 26;
            cEDULALabel.Text = "CEDULA:";
            // 
            // nUM_CARNETLabel
            // 
            nUM_CARNETLabel.AutoSize = true;
            nUM_CARNETLabel.Location = new System.Drawing.Point(26, 106);
            nUM_CARNETLabel.Name = "nUM_CARNETLabel";
            nUM_CARNETLabel.Size = new System.Drawing.Size(92, 15);
            nUM_CARNETLabel.TabIndex = 28;
            nUM_CARNETLabel.Text = "NUM CARNET:";
            // 
            // tIPO_PACIENTELabel
            // 
            tIPO_PACIENTELabel.AutoSize = true;
            tIPO_PACIENTELabel.Location = new System.Drawing.Point(26, 152);
            tIPO_PACIENTELabel.Name = "tIPO_PACIENTELabel";
            tIPO_PACIENTELabel.Size = new System.Drawing.Size(100, 15);
            tIPO_PACIENTELabel.TabIndex = 30;
            tIPO_PACIENTELabel.Text = "TIPO PACIENTE:";
            // 
            // tIPO_PACIENTEComboBox
            // 
            this.tIPO_PACIENTEComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tIPO_PACIENTEComboBox.FormattingEnabled = true;
            this.tIPO_PACIENTEComboBox.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.tIPO_PACIENTEComboBox.Location = new System.Drawing.Point(139, 149);
            this.tIPO_PACIENTEComboBox.Name = "tIPO_PACIENTEComboBox";
            this.tIPO_PACIENTEComboBox.Size = new System.Drawing.Size(219, 23);
            this.tIPO_PACIENTEComboBox.TabIndex = 33;
            // 
            // nOMBRETextBox
            // 
            this.nOMBRETextBox.Location = new System.Drawing.Point(139, 23);
            this.nOMBRETextBox.MaxLength = 30;
            this.nOMBRETextBox.Name = "nOMBRETextBox";
            this.nOMBRETextBox.Size = new System.Drawing.Size(219, 22);
            this.nOMBRETextBox.TabIndex = 25;
            // 
            // cEDULATextBox
            // 
            this.cEDULATextBox.Location = new System.Drawing.Point(139, 63);
            this.cEDULATextBox.MaxLength = 11;
            this.cEDULATextBox.Name = "cEDULATextBox";
            this.cEDULATextBox.Size = new System.Drawing.Size(219, 22);
            this.cEDULATextBox.TabIndex = 27;
            // 
            // nUM_CARNETTextBox
            // 
            this.nUM_CARNETTextBox.Location = new System.Drawing.Point(139, 103);
            this.nUM_CARNETTextBox.Name = "nUM_CARNETTextBox";
            this.nUM_CARNETTextBox.Size = new System.Drawing.Size(219, 22);
            this.nUM_CARNETTextBox.TabIndex = 29;
            // 
            // btnGguardar
            // 
            this.btnGguardar.BackgroundImage = global::_1ParcialJP.Properties.Resources.save_icon;
            this.btnGguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGguardar.Location = new System.Drawing.Point(535, 93);
            this.btnGguardar.Name = "btnGguardar";
            this.btnGguardar.Size = new System.Drawing.Size(81, 79);
            this.btnGguardar.TabIndex = 35;
            this.btnGguardar.UseVisualStyleBackColor = true;
            this.btnGguardar.Click += new System.EventHandler(this.btnGguardar_Click_1);
            // 
            // eSTADOComboBox
            // 
            this.eSTADOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eSTADOComboBox.FormattingEnabled = true;
            this.eSTADOComboBox.Items.AddRange(new object[] {
            "SALUDABLE",
            "ESTABLE",
            "GRAVE"});
            this.eSTADOComboBox.Location = new System.Drawing.Point(445, 20);
            this.eSTADOComboBox.Name = "eSTADOComboBox";
            this.eSTADOComboBox.Size = new System.Drawing.Size(171, 23);
            this.eSTADOComboBox.TabIndex = 36;
            // 
            // FrmAPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(628, 204);
            this.Controls.Add(this.eSTADOComboBox);
            this.Controls.Add(this.btnGguardar);
            this.Controls.Add(eSTADOLabel1);
            this.Controls.Add(this.tIPO_PACIENTEComboBox);
            this.Controls.Add(nOMBRELabel);
            this.Controls.Add(this.nOMBRETextBox);
            this.Controls.Add(cEDULALabel);
            this.Controls.Add(this.cEDULATextBox);
            this.Controls.Add(nUM_CARNETLabel);
            this.Controls.Add(this.nUM_CARNETTextBox);
            this.Controls.Add(tIPO_PACIENTELabel);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAPaciente";
            this.Text = "Agregar Paciente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAPaciente_FormClosed);
            this.Load += new System.EventHandler(this.FrmAPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox tIPO_PACIENTEComboBox;
        private System.Windows.Forms.TextBox nOMBRETextBox;
        private System.Windows.Forms.TextBox cEDULATextBox;
        private System.Windows.Forms.TextBox nUM_CARNETTextBox;
        private System.Windows.Forms.Button btnGguardar;
        private System.Windows.Forms.ComboBox eSTADOComboBox;
    }
}