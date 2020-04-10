namespace Practica_6
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
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.grpAccion = new System.Windows.Forms.GroupBox();
            this.rdoLimp = new System.Windows.Forms.RadioButton();
            this.rdoOrdenar = new System.Windows.Forms.RadioButton();
            this.rdoQuitar = new System.Windows.Forms.RadioButton();
            this.rdoInsertar = new System.Windows.Forms.RadioButton();
            this.rdoBuscar = new System.Windows.Forms.RadioButton();
            this.rdoAgg = new System.Windows.Forms.RadioButton();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpAccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(48, 25);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(54, 13);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "Empleado";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(24, 52);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtEmpleado.TabIndex = 1;
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.Location = new System.Drawing.Point(24, 105);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(127, 147);
            this.lstNombres.TabIndex = 2;
            // 
            // grpAccion
            // 
            this.grpAccion.Controls.Add(this.rdoLimp);
            this.grpAccion.Controls.Add(this.rdoOrdenar);
            this.grpAccion.Controls.Add(this.rdoQuitar);
            this.grpAccion.Controls.Add(this.rdoInsertar);
            this.grpAccion.Controls.Add(this.rdoBuscar);
            this.grpAccion.Controls.Add(this.rdoAgg);
            this.grpAccion.Location = new System.Drawing.Point(288, 25);
            this.grpAccion.Name = "grpAccion";
            this.grpAccion.Size = new System.Drawing.Size(134, 155);
            this.grpAccion.TabIndex = 3;
            this.grpAccion.TabStop = false;
            this.grpAccion.Text = "Acción";
            // 
            // rdoLimp
            // 
            this.rdoLimp.AutoSize = true;
            this.rdoLimp.Location = new System.Drawing.Point(19, 131);
            this.rdoLimp.Name = "rdoLimp";
            this.rdoLimp.Size = new System.Drawing.Size(58, 17);
            this.rdoLimp.TabIndex = 5;
            this.rdoLimp.TabStop = true;
            this.rdoLimp.Text = "Limpiar";
            this.rdoLimp.UseVisualStyleBackColor = true;
            // 
            // rdoOrdenar
            // 
            this.rdoOrdenar.AutoSize = true;
            this.rdoOrdenar.Location = new System.Drawing.Point(19, 108);
            this.rdoOrdenar.Name = "rdoOrdenar";
            this.rdoOrdenar.Size = new System.Drawing.Size(63, 17);
            this.rdoOrdenar.TabIndex = 4;
            this.rdoOrdenar.TabStop = true;
            this.rdoOrdenar.Text = "Ordenar";
            this.rdoOrdenar.UseVisualStyleBackColor = true;
            // 
            // rdoQuitar
            // 
            this.rdoQuitar.AutoSize = true;
            this.rdoQuitar.Location = new System.Drawing.Point(19, 85);
            this.rdoQuitar.Name = "rdoQuitar";
            this.rdoQuitar.Size = new System.Drawing.Size(53, 17);
            this.rdoQuitar.TabIndex = 3;
            this.rdoQuitar.TabStop = true;
            this.rdoQuitar.Text = "Quitar";
            this.rdoQuitar.UseVisualStyleBackColor = true;
            // 
            // rdoInsertar
            // 
            this.rdoInsertar.AutoSize = true;
            this.rdoInsertar.Location = new System.Drawing.Point(19, 62);
            this.rdoInsertar.Name = "rdoInsertar";
            this.rdoInsertar.Size = new System.Drawing.Size(60, 17);
            this.rdoInsertar.TabIndex = 2;
            this.rdoInsertar.TabStop = true;
            this.rdoInsertar.Text = "Insertar";
            this.rdoInsertar.UseVisualStyleBackColor = true;
            this.rdoInsertar.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdoBuscar
            // 
            this.rdoBuscar.AutoSize = true;
            this.rdoBuscar.Location = new System.Drawing.Point(19, 39);
            this.rdoBuscar.Name = "rdoBuscar";
            this.rdoBuscar.Size = new System.Drawing.Size(58, 17);
            this.rdoBuscar.TabIndex = 1;
            this.rdoBuscar.TabStop = true;
            this.rdoBuscar.Text = "Buscar";
            this.rdoBuscar.UseVisualStyleBackColor = true;
            // 
            // rdoAgg
            // 
            this.rdoAgg.AutoSize = true;
            this.rdoAgg.Location = new System.Drawing.Point(19, 16);
            this.rdoAgg.Name = "rdoAgg";
            this.rdoAgg.Size = new System.Drawing.Size(62, 17);
            this.rdoAgg.TabIndex = 0;
            this.rdoAgg.TabStop = true;
            this.rdoAgg.Text = "Agregar";
            this.rdoAgg.UseVisualStyleBackColor = true;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(288, 229);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 4;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(388, 314);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 372);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.grpAccion);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAccion.ResumeLayout(false);
            this.grpAccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.GroupBox grpAccion;
        private System.Windows.Forms.RadioButton rdoLimp;
        private System.Windows.Forms.RadioButton rdoOrdenar;
        private System.Windows.Forms.RadioButton rdoQuitar;
        private System.Windows.Forms.RadioButton rdoInsertar;
        private System.Windows.Forms.RadioButton rdoBuscar;
        private System.Windows.Forms.RadioButton rdoAgg;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnSalir;
    }
}

