
namespace _1ParcialJP
{
    partial class FrmUsuario
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label iD_MARCALabel;
            System.Windows.Forms.Label dESCRIPCIONLabel;
            System.Windows.Forms.Label eSTADOLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.selectsearch = new System.Windows.Forms.ComboBox();
            this.txtTU = new System.Windows.Forms.ComboBox();
            this.txtNombreU = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGguardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewUsuario = new System.Windows.Forms.DataGridView();
            this.txtEC = new System.Windows.Forms.ComboBox();
            this.txtIdU = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            iD_MARCALabel = new System.Windows.Forms.Label();
            dESCRIPCIONLabel = new System.Windows.Forms.Label();
            eSTADOLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            label1.Location = new System.Drawing.Point(6, 183);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(137, 15);
            label1.TabIndex = 29;
            label1.Text = "REALIZAR CONSULTA";
            // 
            // iD_MARCALabel
            // 
            iD_MARCALabel.AutoSize = true;
            iD_MARCALabel.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            iD_MARCALabel.Location = new System.Drawing.Point(9, 18);
            iD_MARCALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iD_MARCALabel.Name = "iD_MARCALabel";
            iD_MARCALabel.Size = new System.Drawing.Size(23, 15);
            iD_MARCALabel.TabIndex = 20;
            iD_MARCALabel.Text = "ID:";
            // 
            // dESCRIPCIONLabel
            // 
            dESCRIPCIONLabel.AutoSize = true;
            dESCRIPCIONLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            dESCRIPCIONLabel.Location = new System.Drawing.Point(9, 56);
            dESCRIPCIONLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dESCRIPCIONLabel.Name = "dESCRIPCIONLabel";
            dESCRIPCIONLabel.Size = new System.Drawing.Size(63, 15);
            dESCRIPCIONLabel.TabIndex = 17;
            dESCRIPCIONLabel.Text = "NOMBRE:";
            // 
            // eSTADOLabel
            // 
            eSTADOLabel.AutoSize = true;
            eSTADOLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            eSTADOLabel.Location = new System.Drawing.Point(9, 96);
            eSTADOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            eSTADOLabel.Name = "eSTADOLabel";
            eSTADOLabel.Size = new System.Drawing.Size(97, 15);
            eSTADOLabel.TabIndex = 19;
            eSTADOLabel.Text = "TIPO USUARIO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            label2.Location = new System.Drawing.Point(9, 138);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(112, 15);
            label2.TabIndex = 31;
            label2.Text = "ESTADO CUENTA:";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(206, 205);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(217, 22);
            this.txtsearch.TabIndex = 27;
            // 
            // selectsearch
            // 
            this.selectsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectsearch.FormattingEnabled = true;
            this.selectsearch.Items.AddRange(new object[] {
            "NOMBRE",
            "TIPO",
            "ESTADO"});
            this.selectsearch.Location = new System.Drawing.Point(4, 205);
            this.selectsearch.Margin = new System.Windows.Forms.Padding(4);
            this.selectsearch.Name = "selectsearch";
            this.selectsearch.Size = new System.Drawing.Size(194, 24);
            this.selectsearch.TabIndex = 26;
            // 
            // txtTU
            // 
            this.txtTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTU.FormattingEnabled = true;
            this.txtTU.Items.AddRange(new object[] {
            "A",
            "U"});
            this.txtTU.Location = new System.Drawing.Point(136, 92);
            this.txtTU.Margin = new System.Windows.Forms.Padding(4);
            this.txtTU.Name = "txtTU";
            this.txtTU.Size = new System.Drawing.Size(241, 24);
            this.txtTU.TabIndex = 25;
            // 
            // txtNombreU
            // 
            this.txtNombreU.Location = new System.Drawing.Point(136, 52);
            this.txtNombreU.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreU.MaxLength = 200;
            this.txtNombreU.Multiline = true;
            this.txtNombreU.Name = "txtNombreU";
            this.txtNombreU.Size = new System.Drawing.Size(241, 24);
            this.txtNombreU.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::_1ParcialJP.Properties.Resources._1024px_Search_Icon_svg;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(431, 181);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 46);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::_1ParcialJP.Properties.Resources.unnamed__2_;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(486, 158);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 64);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGguardar
            // 
            this.btnGguardar.BackgroundImage = global::_1ParcialJP.Properties.Resources.save_icon;
            this.btnGguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGguardar.Location = new System.Drawing.Point(486, 86);
            this.btnGguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGguardar.Name = "btnGguardar";
            this.btnGguardar.Size = new System.Drawing.Size(64, 64);
            this.btnGguardar.TabIndex = 23;
            this.btnGguardar.UseVisualStyleBackColor = true;
            this.btnGguardar.Click += new System.EventHandler(this.btnGguardar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::_1ParcialJP.Properties.Resources.add_1_icon__flatastic_1_iconset__custom_icon_design_0;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(486, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewUsuario);
            this.groupBox1.Location = new System.Drawing.Point(4, 237);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(554, 327);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsuario.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewUsuario.Location = new System.Drawing.Point(4, 19);
            this.dataGridViewUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.ReadOnly = true;
            this.dataGridViewUsuario.Size = new System.Drawing.Size(546, 304);
            this.dataGridViewUsuario.TabIndex = 0;
            this.dataGridViewUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuario_CellContentClick);
            // 
            // txtEC
            // 
            this.txtEC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEC.FormattingEnabled = true;
            this.txtEC.Items.AddRange(new object[] {
            "A",
            "I",
            "B",
            "S"});
            this.txtEC.Location = new System.Drawing.Point(136, 134);
            this.txtEC.Margin = new System.Windows.Forms.Padding(4);
            this.txtEC.Name = "txtEC";
            this.txtEC.Size = new System.Drawing.Size(241, 24);
            this.txtEC.TabIndex = 32;
            // 
            // txtIdU
            // 
            this.txtIdU.Location = new System.Drawing.Point(136, 14);
            this.txtIdU.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdU.Name = "txtIdU";
            this.txtIdU.ReadOnly = true;
            this.txtIdU.Size = new System.Drawing.Size(241, 22);
            this.txtIdU.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEC);
            this.groupBox2.Controls.Add(this.txtTU);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(eSTADOLabel);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtNombreU);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(dESCRIPCIONLabel);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtIdU);
            this.groupBox2.Controls.Add(this.txtsearch);
            this.groupBox2.Controls.Add(iD_MARCALabel);
            this.groupBox2.Controls.Add(this.selectsearch);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnGguardar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Location = new System.Drawing.Point(223, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 571);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuarios";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.BackgroundImage = global::_1ParcialJP.Properties.Resources.x_png_33;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Location = new System.Drawing.Point(814, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 40);
            this.button3.TabIndex = 34;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1031, 628);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUsuario";
            this.Text = "Usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUsuario_FormClosed);
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox selectsearch;
        private System.Windows.Forms.ComboBox txtTU;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGguardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombreU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewUsuario;
        private System.Windows.Forms.ComboBox txtEC;
        private System.Windows.Forms.TextBox txtIdU;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
    }
}