namespace Practica_1
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
            this.lblExam1 = new System.Windows.Forms.Label();
            this.lblExam2 = new System.Windows.Forms.Label();
            this.lblExam3 = new System.Windows.Forms.Label();
            this.lblProm = new System.Windows.Forms.Label();
            this.txtExam1 = new System.Windows.Forms.TextBox();
            this.txtExam2 = new System.Windows.Forms.TextBox();
            this.txtExam3 = new System.Windows.Forms.TextBox();
            this.txtProm = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExam1
            // 
            this.lblExam1.AutoSize = true;
            this.lblExam1.Location = new System.Drawing.Point(16, 35);
            this.lblExam1.Name = "lblExam1";
            this.lblExam1.Size = new System.Drawing.Size(57, 13);
            this.lblExam1.TabIndex = 0;
            this.lblExam1.Text = "Examen 1:";
            // 
            // lblExam2
            // 
            this.lblExam2.AutoSize = true;
            this.lblExam2.Location = new System.Drawing.Point(16, 79);
            this.lblExam2.Name = "lblExam2";
            this.lblExam2.Size = new System.Drawing.Size(57, 13);
            this.lblExam2.TabIndex = 1;
            this.lblExam2.Text = "Examen 2:";
            // 
            // lblExam3
            // 
            this.lblExam3.AutoSize = true;
            this.lblExam3.Location = new System.Drawing.Point(16, 128);
            this.lblExam3.Name = "lblExam3";
            this.lblExam3.Size = new System.Drawing.Size(57, 13);
            this.lblExam3.TabIndex = 2;
            this.lblExam3.Text = "Examen 3:";
            // 
            // lblProm
            // 
            this.lblProm.AutoSize = true;
            this.lblProm.Location = new System.Drawing.Point(16, 219);
            this.lblProm.Name = "lblProm";
            this.lblProm.Size = new System.Drawing.Size(54, 13);
            this.lblProm.TabIndex = 3;
            this.lblProm.Text = "Promedio:";
            // 
            // txtExam1
            // 
            this.txtExam1.Location = new System.Drawing.Point(111, 34);
            this.txtExam1.Name = "txtExam1";
            this.txtExam1.Size = new System.Drawing.Size(100, 20);
            this.txtExam1.TabIndex = 4;
            // 
            // txtExam2
            // 
            this.txtExam2.Location = new System.Drawing.Point(111, 79);
            this.txtExam2.Name = "txtExam2";
            this.txtExam2.Size = new System.Drawing.Size(100, 20);
            this.txtExam2.TabIndex = 5;
            // 
            // txtExam3
            // 
            this.txtExam3.Location = new System.Drawing.Point(111, 128);
            this.txtExam3.Name = "txtExam3";
            this.txtExam3.Size = new System.Drawing.Size(100, 20);
            this.txtExam3.TabIndex = 6;
            // 
            // txtProm
            // 
            this.txtProm.Location = new System.Drawing.Point(111, 212);
            this.txtProm.Name = "txtProm";
            this.txtProm.Size = new System.Drawing.Size(100, 20);
            this.txtProm.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(57, 282);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(186, 282);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(75, 23);
            this.btnLimp.TabIndex = 9;
            this.btnLimp.Text = "Limpiar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(321, 282);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 405);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtProm);
            this.Controls.Add(this.txtExam3);
            this.Controls.Add(this.txtExam2);
            this.Controls.Add(this.txtExam1);
            this.Controls.Add(this.lblProm);
            this.Controls.Add(this.lblExam3);
            this.Controls.Add(this.lblExam2);
            this.Controls.Add(this.lblExam1);
            this.Name = "Form1";
            this.Text = "Promedio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExam1;
        private System.Windows.Forms.Label lblExam2;
        private System.Windows.Forms.Label lblExam3;
        private System.Windows.Forms.Label lblProm;
        private System.Windows.Forms.TextBox txtExam1;
        private System.Windows.Forms.TextBox txtExam2;
        private System.Windows.Forms.TextBox txtExam3;
        private System.Windows.Forms.TextBox txtProm;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnSalir;
    }
}

