namespace Practica_6
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
            this.btnAgg = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lstDatos = new System.Windows.Forms.ListView();
            this.Tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.mskClave = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgg
            // 
            this.btnAgg.Location = new System.Drawing.Point(374, 33);
            this.btnAgg.Name = "btnAgg";
            this.btnAgg.Size = new System.Drawing.Size(75, 23);
            this.btnAgg.TabIndex = 0;
            this.btnAgg.Text = "Agregar";
            this.btnAgg.UseVisualStyleBackColor = true;
            this.btnAgg.Click += new System.EventHandler(this.btnAgg_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(374, 86);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(374, 136);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(12, 22);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 3;
            this.lblTel.Text = "Télefono:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 86);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(47, 13);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nombre:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(89, 79);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(374, 316);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(12, 146);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(58, 13);
            this.lblProductos.TabIndex = 8;
            this.lblProductos.Text = "Productos:";
            // 
            // lstDatos
            // 
            this.lstDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tel,
            this.Nom});
            this.lstDatos.HideSelection = false;
            this.lstDatos.Location = new System.Drawing.Point(15, 180);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(182, 145);
            this.lstDatos.TabIndex = 9;
            this.lstDatos.UseCompatibleStateImageBehavior = false;
            this.lstDatos.View = System.Windows.Forms.View.Details;
            // 
            // Tel
            // 
            this.Tel.Text = "Télefono";
            // 
            // Nom
            // 
            this.Nom.Text = "Nombre";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // mskClave
            // 
            this.mskClave.Location = new System.Drawing.Point(89, 22);
            this.mskClave.Mask = "0000-0000";
            this.mskClave.Name = "mskClave";
            this.mskClave.Size = new System.Drawing.Size(75, 20);
            this.mskClave.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 400);
            this.Controls.Add(this.mskClave);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgg);
            this.Name = "Form2";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgg;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.ListView lstDatos;
        private System.Windows.Forms.ColumnHeader Tel;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.MaskedTextBox mskClave;
    }
}