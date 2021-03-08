
namespace _1ParcialJP
{
    partial class FrmATF
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
            System.Windows.Forms.Label dESCRIPCIONLabel;
            System.Windows.Forms.Label eSTADOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmATF));
            this.eSTADOComboBox = new System.Windows.Forms.ComboBox();
            this.dESCRIPCIONTextBox = new System.Windows.Forms.TextBox();
            this.btnGguardar = new System.Windows.Forms.Button();
            dESCRIPCIONLabel = new System.Windows.Forms.Label();
            eSTADOLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dESCRIPCIONLabel
            // 
            dESCRIPCIONLabel.AutoSize = true;
            dESCRIPCIONLabel.Location = new System.Drawing.Point(13, 61);
            dESCRIPCIONLabel.Name = "dESCRIPCIONLabel";
            dESCRIPCIONLabel.Size = new System.Drawing.Size(90, 15);
            dESCRIPCIONLabel.TabIndex = 21;
            dESCRIPCIONLabel.Text = "DESCRIPCION:";
            // 
            // eSTADOLabel
            // 
            eSTADOLabel.AutoSize = true;
            eSTADOLabel.Location = new System.Drawing.Point(13, 22);
            eSTADOLabel.Name = "eSTADOLabel";
            eSTADOLabel.Size = new System.Drawing.Size(59, 15);
            eSTADOLabel.TabIndex = 23;
            eSTADOLabel.Text = "ESTADO:";
            // 
            // eSTADOComboBox
            // 
            this.eSTADOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eSTADOComboBox.FormattingEnabled = true;
            this.eSTADOComboBox.Items.AddRange(new object[] {
            "DISPONIBLE",
            "NO DISPNIBLE",
            "DESCONTINUADO",
            "EN PRUEBA"});
            this.eSTADOComboBox.Location = new System.Drawing.Point(119, 22);
            this.eSTADOComboBox.Name = "eSTADOComboBox";
            this.eSTADOComboBox.Size = new System.Drawing.Size(122, 23);
            this.eSTADOComboBox.TabIndex = 25;
            // 
            // dESCRIPCIONTextBox
            // 
            this.dESCRIPCIONTextBox.Location = new System.Drawing.Point(19, 80);
            this.dESCRIPCIONTextBox.Multiline = true;
            this.dESCRIPCIONTextBox.Name = "dESCRIPCIONTextBox";
            this.dESCRIPCIONTextBox.Size = new System.Drawing.Size(247, 101);
            this.dESCRIPCIONTextBox.TabIndex = 22;
            // 
            // btnGguardar
            // 
            this.btnGguardar.BackgroundImage = global::_1ParcialJP.Properties.Resources.save_icon;
            this.btnGguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGguardar.Location = new System.Drawing.Point(287, 17);
            this.btnGguardar.Name = "btnGguardar";
            this.btnGguardar.Size = new System.Drawing.Size(70, 68);
            this.btnGguardar.TabIndex = 26;
            this.btnGguardar.UseVisualStyleBackColor = true;
            this.btnGguardar.Click += new System.EventHandler(this.btnGguardar_Click_1);
            // 
            // FrmATF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(369, 212);
            this.Controls.Add(this.btnGguardar);
            this.Controls.Add(this.eSTADOComboBox);
            this.Controls.Add(dESCRIPCIONLabel);
            this.Controls.Add(this.dESCRIPCIONTextBox);
            this.Controls.Add(eSTADOLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmATF";
            this.Text = "Agregar Tipo Farmaco";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmATF_FormClosed);
            this.Load += new System.EventHandler(this.FrmATF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox eSTADOComboBox;
        private System.Windows.Forms.TextBox dESCRIPCIONTextBox;
        private System.Windows.Forms.Button btnGguardar;
    }
}