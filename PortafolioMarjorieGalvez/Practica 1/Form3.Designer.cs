namespace Practica_1
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
            this.lblIn = new System.Windows.Forms.Label();
            this.lblPor = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtIn1 = new System.Windows.Forms.TextBox();
            this.txtIn2 = new System.Windows.Forms.TextBox();
            this.txtIn3 = new System.Windows.Forms.TextBox();
            this.txtPor1 = new System.Windows.Forms.TextBox();
            this.txtPor2 = new System.Windows.Forms.TextBox();
            this.txtPor3 = new System.Windows.Forms.TextBox();
            this.txtInversion = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(130, 31);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(71, 13);
            this.lblIn.TabIndex = 0;
            this.lblIn.Text = "Inversionistas";
            // 
            // lblPor
            // 
            this.lblPor.AutoSize = true;
            this.lblPor.Location = new System.Drawing.Point(313, 31);
            this.lblPor.Name = "lblPor";
            this.lblPor.Size = new System.Drawing.Size(63, 13);
            this.lblPor.TabIndex = 1;
            this.lblPor.Text = "Porcentajes";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(25, 68);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(16, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "1:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(25, 113);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(16, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "2:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(25, 166);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(16, 13);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "3:";
            // 
            // txtIn1
            // 
            this.txtIn1.Location = new System.Drawing.Point(114, 61);
            this.txtIn1.Name = "txtIn1";
            this.txtIn1.Size = new System.Drawing.Size(100, 20);
            this.txtIn1.TabIndex = 5;
            // 
            // txtIn2
            // 
            this.txtIn2.Location = new System.Drawing.Point(114, 110);
            this.txtIn2.Name = "txtIn2";
            this.txtIn2.Size = new System.Drawing.Size(100, 20);
            this.txtIn2.TabIndex = 6;
            this.txtIn2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtIn3
            // 
            this.txtIn3.Location = new System.Drawing.Point(114, 159);
            this.txtIn3.Name = "txtIn3";
            this.txtIn3.Size = new System.Drawing.Size(100, 20);
            this.txtIn3.TabIndex = 7;
            // 
            // txtPor1
            // 
            this.txtPor1.Location = new System.Drawing.Point(294, 61);
            this.txtPor1.Name = "txtPor1";
            this.txtPor1.Size = new System.Drawing.Size(100, 20);
            this.txtPor1.TabIndex = 8;
            // 
            // txtPor2
            // 
            this.txtPor2.Location = new System.Drawing.Point(294, 113);
            this.txtPor2.Name = "txtPor2";
            this.txtPor2.Size = new System.Drawing.Size(100, 20);
            this.txtPor2.TabIndex = 9;
            // 
            // txtPor3
            // 
            this.txtPor3.Location = new System.Drawing.Point(294, 159);
            this.txtPor3.Name = "txtPor3";
            this.txtPor3.Size = new System.Drawing.Size(100, 20);
            this.txtPor3.TabIndex = 10;
            // 
            // txtInversion
            // 
            this.txtInversion.Location = new System.Drawing.Point(56, 249);
            this.txtInversion.Name = "txtInversion";
            this.txtInversion.Size = new System.Drawing.Size(100, 20);
            this.txtInversion.TabIndex = 11;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(53, 211);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total Inversion:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(56, 296);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(187, 296);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(343, 296);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 365);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtInversion);
            this.Controls.Add(this.txtPor3);
            this.Controls.Add(this.txtPor2);
            this.Controls.Add(this.txtPor1);
            this.Controls.Add(this.txtIn3);
            this.Controls.Add(this.txtIn2);
            this.Controls.Add(this.txtIn1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblPor);
            this.Controls.Add(this.lblIn);
            this.Name = "Form3";
            this.Text = "Inversiones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblPor;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtIn1;
        private System.Windows.Forms.TextBox txtIn2;
        private System.Windows.Forms.TextBox txtIn3;
        private System.Windows.Forms.TextBox txtPor1;
        private System.Windows.Forms.TextBox txtPor2;
        private System.Windows.Forms.TextBox txtPor3;
        private System.Windows.Forms.TextBox txtInversion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}