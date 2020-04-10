namespace Practica_6
{
    partial class Form3
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
            this.lblNIT = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblNIT2 = new System.Windows.Forms.Label();
            this.btnAgg = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.NIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.mskNIT = new System.Windows.Forms.MaskedTextBox();
            this.mskNIT2 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNIT
            // 
            this.lblNIT.AutoSize = true;
            this.lblNIT.Location = new System.Drawing.Point(40, 25);
            this.lblNIT.Name = "lblNIT";
            this.lblNIT.Size = new System.Drawing.Size(25, 13);
            this.lblNIT.TabIndex = 0;
            this.lblNIT.Text = "NIT";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(40, 81);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(44, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nombre";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(40, 140);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.TabIndex = 2;
            this.lblSueldo.Text = "Sueldo";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(147, 81);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 4;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(147, 133);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 5;
            this.txtSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldo_KeyPress);
            // 
            // lblNIT2
            // 
            this.lblNIT2.AutoSize = true;
            this.lblNIT2.Location = new System.Drawing.Point(40, 373);
            this.lblNIT2.Name = "lblNIT2";
            this.lblNIT2.Size = new System.Drawing.Size(25, 13);
            this.lblNIT2.TabIndex = 7;
            this.lblNIT2.Text = "NIT";
            // 
            // btnAgg
            // 
            this.btnAgg.Location = new System.Drawing.Point(339, 135);
            this.btnAgg.Name = "btnAgg";
            this.btnAgg.Size = new System.Drawing.Size(75, 23);
            this.btnAgg.TabIndex = 8;
            this.btnAgg.Text = "Agregar";
            this.btnAgg.UseVisualStyleBackColor = true;
            this.btnAgg.Click += new System.EventHandler(this.btnAgg_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(90, 401);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(196, 401);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 10;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(514, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NIT,
            this.Nombre,
            this.Sueldo});
            this.dgv1.Location = new System.Drawing.Point(43, 185);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(344, 138);
            this.dgv1.TabIndex = 12;
            // 
            // NIT
            // 
            this.NIT.HeaderText = "NIT";
            this.NIT.Name = "NIT";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(366, 377);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(69, 13);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total plantilla";
            // 
            // mskNIT
            // 
            this.mskNIT.Location = new System.Drawing.Point(147, 25);
            this.mskNIT.Mask = "0000-000000-000-0";
            this.mskNIT.Name = "mskNIT";
            this.mskNIT.Size = new System.Drawing.Size(100, 20);
            this.mskNIT.TabIndex = 14;
            // 
            // mskNIT2
            // 
            this.mskNIT2.Location = new System.Drawing.Point(147, 370);
            this.mskNIT2.Mask = "0000-000000-000-0";
            this.mskNIT2.Name = "mskNIT2";
            this.mskNIT2.Size = new System.Drawing.Size(100, 20);
            this.mskNIT2.TabIndex = 15;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.mskNIT2);
            this.Controls.Add(this.mskNIT);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgg);
            this.Controls.Add(this.lblNIT2);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblNIT);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNIT;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblNIT2;
        private System.Windows.Forms.Button btnAgg;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.MaskedTextBox mskNIT;
        private System.Windows.Forms.MaskedTextBox mskNIT2;
    }
}