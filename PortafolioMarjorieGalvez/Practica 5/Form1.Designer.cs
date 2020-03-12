namespace Practica_5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVendedores = new System.Windows.Forms.Label();
            this.btnAZ = new System.Windows.Forms.Button();
            this.btnZA = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lstVendedores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblVendedores
            // 
            this.lblVendedores.AutoSize = true;
            this.lblVendedores.Location = new System.Drawing.Point(34, 46);
            this.lblVendedores.Name = "lblVendedores";
            this.lblVendedores.Size = new System.Drawing.Size(64, 13);
            this.lblVendedores.TabIndex = 0;
            this.lblVendedores.Text = "Vendedores";
            // 
            // btnAZ
            // 
            this.btnAZ.Location = new System.Drawing.Point(339, 46);
            this.btnAZ.Name = "btnAZ";
            this.btnAZ.Size = new System.Drawing.Size(75, 23);
            this.btnAZ.TabIndex = 1;
            this.btnAZ.Text = "Ordenar A-Z";
            this.btnAZ.UseVisualStyleBackColor = true;
            this.btnAZ.Click += new System.EventHandler(this.btnAZ_Click);
            // 
            // btnZA
            // 
            this.btnZA.Location = new System.Drawing.Point(339, 90);
            this.btnZA.Name = "btnZA";
            this.btnZA.Size = new System.Drawing.Size(75, 23);
            this.btnZA.TabIndex = 2;
            this.btnZA.Text = "Ordenar Z-A";
            this.btnZA.UseVisualStyleBackColor = true;
            this.btnZA.Click += new System.EventHandler(this.btnZA_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(339, 137);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(339, 293);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(336, 225);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(44, 13);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(314, 255);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lstVendedores
            // 
            this.lstVendedores.FormattingEnabled = true;
            this.lstVendedores.Location = new System.Drawing.Point(37, 76);
            this.lstVendedores.Name = "lstVendedores";
            this.lstVendedores.Size = new System.Drawing.Size(163, 199);
            this.lstVendedores.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 369);
            this.Controls.Add(this.lstVendedores);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnZA);
            this.Controls.Add(this.btnAZ);
            this.Controls.Add(this.lblVendedores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVendedores;
        private System.Windows.Forms.Button btnAZ;
        private System.Windows.Forms.Button btnZA;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox lstVendedores;
    }
}

