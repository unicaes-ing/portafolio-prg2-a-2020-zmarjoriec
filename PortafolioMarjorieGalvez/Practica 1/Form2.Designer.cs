namespace Practica_1
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.lblBi = new System.Windows.Forms.Label();
            this.lblOc = new System.Windows.Forms.Label();
            this.lblHexa = new System.Windows.Forms.Label();
            this.grpEquivale = new System.Windows.Forms.GroupBox();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.txtOctal = new System.Windows.Forms.TextBox();
            this.txtHexa = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.grpEquivale.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(46, 237);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(158, 237);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(284, 237);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Location = new System.Drawing.Point(26, 21);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(48, 13);
            this.lblDecimal.TabIndex = 3;
            this.lblDecimal.Text = "Decimal:";
            // 
            // lblBi
            // 
            this.lblBi.AutoSize = true;
            this.lblBi.Location = new System.Drawing.Point(12, 29);
            this.lblBi.Name = "lblBi";
            this.lblBi.Size = new System.Drawing.Size(42, 13);
            this.lblBi.TabIndex = 4;
            this.lblBi.Text = "Binario:";
            // 
            // lblOc
            // 
            this.lblOc.AutoSize = true;
            this.lblOc.Location = new System.Drawing.Point(12, 63);
            this.lblOc.Name = "lblOc";
            this.lblOc.Size = new System.Drawing.Size(35, 13);
            this.lblOc.TabIndex = 5;
            this.lblOc.Text = "Octal:";
            // 
            // lblHexa
            // 
            this.lblHexa.AutoSize = true;
            this.lblHexa.Location = new System.Drawing.Point(12, 102);
            this.lblHexa.Name = "lblHexa";
            this.lblHexa.Size = new System.Drawing.Size(71, 13);
            this.lblHexa.TabIndex = 6;
            this.lblHexa.Text = "Hexadecimal:";
            // 
            // grpEquivale
            // 
            this.grpEquivale.Controls.Add(this.txtHexa);
            this.grpEquivale.Controls.Add(this.txtOctal);
            this.grpEquivale.Controls.Add(this.txtBinario);
            this.grpEquivale.Controls.Add(this.lblBi);
            this.grpEquivale.Controls.Add(this.lblHexa);
            this.grpEquivale.Controls.Add(this.lblOc);
            this.grpEquivale.Location = new System.Drawing.Point(46, 65);
            this.grpEquivale.Name = "grpEquivale";
            this.grpEquivale.Size = new System.Drawing.Size(223, 140);
            this.grpEquivale.TabIndex = 7;
            this.grpEquivale.TabStop = false;
            this.grpEquivale.Text = "Equivale a:";
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(95, 26);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(100, 20);
            this.txtBinario.TabIndex = 7;
            // 
            // txtOctal
            // 
            this.txtOctal.Location = new System.Drawing.Point(95, 60);
            this.txtOctal.Name = "txtOctal";
            this.txtOctal.Size = new System.Drawing.Size(100, 20);
            this.txtOctal.TabIndex = 8;
            // 
            // txtHexa
            // 
            this.txtHexa.Location = new System.Drawing.Point(95, 102);
            this.txtHexa.Name = "txtHexa";
            this.txtHexa.Size = new System.Drawing.Size(100, 20);
            this.txtHexa.TabIndex = 9;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(93, 18);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 331);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.grpEquivale);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form2";
            this.Text = "Sistemas";
            this.grpEquivale.ResumeLayout(false);
            this.grpEquivale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.Label lblBi;
        private System.Windows.Forms.Label lblOc;
        private System.Windows.Forms.Label lblHexa;
        private System.Windows.Forms.GroupBox grpEquivale;
        private System.Windows.Forms.TextBox txtHexa;
        private System.Windows.Forms.TextBox txtOctal;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.TextBox txtDecimal;
    }
}