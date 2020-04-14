namespace Practica_7
{
    partial class Form2
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblFNac = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cboPropietario = new System.Windows.Forms.ComboBox();
            this.cboEspecie = new System.Windows.Forms.ComboBox();
            this.dtpNaci = new System.Windows.Forms.DateTimePicker();
            this.mskCodigo = new System.Windows.Forms.MaskedTextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.rdoHembra = new System.Windows.Forms.RadioButton();
            this.rdoMacho = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(38, 11);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(98, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código de mascota";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(38, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Location = new System.Drawing.Point(38, 73);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(57, 13);
            this.lblPropietario.TabIndex = 2;
            this.lblPropietario.Text = "Propietario";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(38, 106);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(45, 13);
            this.lblEspecie.TabIndex = 3;
            this.lblEspecie.Text = "Especie";
            // 
            // lblFNac
            // 
            this.lblFNac.AutoSize = true;
            this.lblFNac.Location = new System.Drawing.Point(38, 141);
            this.lblFNac.Name = "lblFNac";
            this.lblFNac.Size = new System.Drawing.Size(106, 13);
            this.lblFNac.TabIndex = 4;
            this.lblFNac.Text = "Fecha de nacimiento";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(38, 176);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 5;
            this.lblPeso.Text = "Peso";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(38, 210);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo";
            this.lblSexo.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(150, 42);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 8;
            // 
            // cboPropietario
            // 
            this.cboPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPropietario.FormattingEnabled = true;
            this.cboPropietario.Location = new System.Drawing.Point(150, 70);
            this.cboPropietario.Name = "cboPropietario";
            this.cboPropietario.Size = new System.Drawing.Size(121, 21);
            this.cboPropietario.TabIndex = 9;
            // 
            // cboEspecie
            // 
            this.cboEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecie.FormattingEnabled = true;
            this.cboEspecie.Location = new System.Drawing.Point(150, 103);
            this.cboEspecie.Name = "cboEspecie";
            this.cboEspecie.Size = new System.Drawing.Size(121, 21);
            this.cboEspecie.TabIndex = 10;
            // 
            // dtpNaci
            // 
            this.dtpNaci.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNaci.Location = new System.Drawing.Point(150, 141);
            this.dtpNaci.Name = "dtpNaci";
            this.dtpNaci.Size = new System.Drawing.Size(100, 20);
            this.dtpNaci.TabIndex = 11;
            // 
            // mskCodigo
            // 
            this.mskCodigo.Location = new System.Drawing.Point(150, 8);
            this.mskCodigo.Mask = "LL0000";
            this.mskCodigo.Name = "mskCodigo";
            this.mskCodigo.Size = new System.Drawing.Size(100, 20);
            this.mskCodigo.TabIndex = 12;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(150, 173);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 13;
            // 
            // rdoHembra
            // 
            this.rdoHembra.AutoSize = true;
            this.rdoHembra.Location = new System.Drawing.Point(150, 208);
            this.rdoHembra.Name = "rdoHembra";
            this.rdoHembra.Size = new System.Drawing.Size(62, 17);
            this.rdoHembra.TabIndex = 14;
            this.rdoHembra.TabStop = true;
            this.rdoHembra.Text = "Hembra";
            this.rdoHembra.UseVisualStyleBackColor = true;
            // 
            // rdoMacho
            // 
            this.rdoMacho.AutoSize = true;
            this.rdoMacho.Location = new System.Drawing.Point(245, 208);
            this.rdoMacho.Name = "rdoMacho";
            this.rdoMacho.Size = new System.Drawing.Size(58, 17);
            this.rdoMacho.TabIndex = 15;
            this.rdoMacho.TabStop = true;
            this.rdoMacho.Text = "Macho";
            this.rdoMacho.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(419, 205);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Nombre,
            this.Propietario,
            this.Especie,
            this.Fecha,
            this.Peso,
            this.Sexo});
            this.dataGridView1.Location = new System.Drawing.Point(31, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(715, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código de mascota";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Propietario
            // 
            this.Propietario.HeaderText = "Propietario";
            this.Propietario.Name = "Propietario";
            this.Propietario.ReadOnly = true;
            // 
            // Especie
            // 
            this.Especie.HeaderText = "Especie";
            this.Especie.Name = "Especie";
            this.Especie.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha de nacimiento";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(662, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rdoMacho);
            this.Controls.Add(this.rdoHembra);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.mskCodigo);
            this.Controls.Add(this.dtpNaci);
            this.Controls.Add(this.cboEspecie);
            this.Controls.Add(this.cboPropietario);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblFNac);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblFNac;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cboPropietario;
        private System.Windows.Forms.ComboBox cboEspecie;
        private System.Windows.Forms.DateTimePicker dtpNaci;
        private System.Windows.Forms.MaskedTextBox mskCodigo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.RadioButton rdoHembra;
        private System.Windows.Forms.RadioButton rdoMacho;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.ErrorProvider err;
    }
}