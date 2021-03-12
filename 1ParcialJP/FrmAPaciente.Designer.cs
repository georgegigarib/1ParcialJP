
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            eSTADOLabel1 = new System.Windows.Forms.Label();
            nOMBRELabel = new System.Windows.Forms.Label();
            cEDULALabel = new System.Windows.Forms.Label();
            nUM_CARNETLabel = new System.Windows.Forms.Label();
            tIPO_PACIENTELabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eSTADOLabel1
            // 
            eSTADOLabel1.AutoSize = true;
            eSTADOLabel1.Location = new System.Drawing.Point(14, 187);
            eSTADOLabel1.Name = "eSTADOLabel1";
            eSTADOLabel1.Size = new System.Drawing.Size(59, 15);
            eSTADOLabel1.TabIndex = 32;
            eSTADOLabel1.Text = "ESTADO:";
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(14, 25);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(63, 15);
            nOMBRELabel.TabIndex = 24;
            nOMBRELabel.Text = "NOMBRE:";
            // 
            // cEDULALabel
            // 
            cEDULALabel.AutoSize = true;
            cEDULALabel.Location = new System.Drawing.Point(14, 65);
            cEDULALabel.Name = "cEDULALabel";
            cEDULALabel.Size = new System.Drawing.Size(60, 15);
            cEDULALabel.TabIndex = 26;
            cEDULALabel.Text = "CEDULA:";
            // 
            // nUM_CARNETLabel
            // 
            nUM_CARNETLabel.AutoSize = true;
            nUM_CARNETLabel.Location = new System.Drawing.Point(14, 105);
            nUM_CARNETLabel.Name = "nUM_CARNETLabel";
            nUM_CARNETLabel.Size = new System.Drawing.Size(92, 15);
            nUM_CARNETLabel.TabIndex = 28;
            nUM_CARNETLabel.Text = "NUM CARNET:";
            // 
            // tIPO_PACIENTELabel
            // 
            tIPO_PACIENTELabel.AutoSize = true;
            tIPO_PACIENTELabel.Location = new System.Drawing.Point(14, 145);
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
            this.tIPO_PACIENTEComboBox.Location = new System.Drawing.Point(127, 142);
            this.tIPO_PACIENTEComboBox.Name = "tIPO_PACIENTEComboBox";
            this.tIPO_PACIENTEComboBox.Size = new System.Drawing.Size(219, 23);
            this.tIPO_PACIENTEComboBox.TabIndex = 33;
            // 
            // nOMBRETextBox
            // 
            this.nOMBRETextBox.Location = new System.Drawing.Point(127, 21);
            this.nOMBRETextBox.MaxLength = 30;
            this.nOMBRETextBox.Name = "nOMBRETextBox";
            this.nOMBRETextBox.Size = new System.Drawing.Size(219, 22);
            this.nOMBRETextBox.TabIndex = 25;
            // 
            // cEDULATextBox
            // 
            this.cEDULATextBox.Location = new System.Drawing.Point(127, 62);
            this.cEDULATextBox.MaxLength = 11;
            this.cEDULATextBox.Name = "cEDULATextBox";
            this.cEDULATextBox.Size = new System.Drawing.Size(219, 22);
            this.cEDULATextBox.TabIndex = 27;
            // 
            // nUM_CARNETTextBox
            // 
            this.nUM_CARNETTextBox.Location = new System.Drawing.Point(127, 102);
            this.nUM_CARNETTextBox.Name = "nUM_CARNETTextBox";
            this.nUM_CARNETTextBox.Size = new System.Drawing.Size(219, 22);
            this.nUM_CARNETTextBox.TabIndex = 29;
            // 
            // btnGguardar
            // 
            this.btnGguardar.BackgroundImage = global::_1ParcialJP.Properties.Resources.save_icon;
            this.btnGguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGguardar.Location = new System.Drawing.Point(394, 141);
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
            this.eSTADOComboBox.Location = new System.Drawing.Point(127, 184);
            this.eSTADOComboBox.Name = "eSTADOComboBox";
            this.eSTADOComboBox.Size = new System.Drawing.Size(171, 23);
            this.eSTADOComboBox.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nOMBRETextBox);
            this.groupBox1.Controls.Add(this.eSTADOComboBox);
            this.groupBox1.Controls.Add(tIPO_PACIENTELabel);
            this.groupBox1.Controls.Add(this.btnGguardar);
            this.groupBox1.Controls.Add(this.nUM_CARNETTextBox);
            this.groupBox1.Controls.Add(eSTADOLabel1);
            this.groupBox1.Controls.Add(nUM_CARNETLabel);
            this.groupBox1.Controls.Add(this.tIPO_PACIENTEComboBox);
            this.groupBox1.Controls.Add(this.cEDULATextBox);
            this.groupBox1.Controls.Add(nOMBRELabel);
            this.groupBox1.Controls.Add(cEDULALabel);
            this.groupBox1.Location = new System.Drawing.Point(273, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 233);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Paciente";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.BackgroundImage = global::_1ParcialJP.Properties.Resources.red_go_back_arrow;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Location = new System.Drawing.Point(791, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 40);
            this.button3.TabIndex = 38;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmAPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1075, 524);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAPaciente";
            this.Text = "Agregar Paciente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAPaciente_FormClosed);
            this.Load += new System.EventHandler(this.FrmAPaciente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox tIPO_PACIENTEComboBox;
        private System.Windows.Forms.TextBox nOMBRETextBox;
        private System.Windows.Forms.TextBox cEDULATextBox;
        private System.Windows.Forms.TextBox nUM_CARNETTextBox;
        private System.Windows.Forms.Button btnGguardar;
        private System.Windows.Forms.ComboBox eSTADOComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
    }
}