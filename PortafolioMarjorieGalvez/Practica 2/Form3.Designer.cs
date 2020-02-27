namespace Practica_2
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
            this.lblLongitud = new System.Windows.Forms.Label();
            this.lstDe = new System.Windows.Forms.ListBox();
            this.lstA = new System.Windows.Forms.ListBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtConversion = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpDe = new System.Windows.Forms.GroupBox();
            this.grpA = new System.Windows.Forms.GroupBox();
            this.grpDe.SuspendLayout();
            this.grpA.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Location = new System.Drawing.Point(12, 39);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(161, 13);
            this.lblLongitud.TabIndex = 0;
            this.lblLongitud.Text = "Introduzca la longitud a convertir";
            // 
            // lstDe
            // 
            this.lstDe.FormattingEnabled = true;
            this.lstDe.Items.AddRange(new object[] {
            "Pulgadas (in)",
            "Pies (ft)",
            "Yardas (yd)"});
            this.lstDe.Location = new System.Drawing.Point(35, 19);
            this.lstDe.Name = "lstDe";
            this.lstDe.Size = new System.Drawing.Size(120, 95);
            this.lstDe.TabIndex = 1;
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.Items.AddRange(new object[] {
            "Pulgadas (in)",
            "Pies (ft)",
            "Yardas (yd)"});
            this.lstA.Location = new System.Drawing.Point(36, 19);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(120, 95);
            this.lstA.TabIndex = 2;
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(183, 36);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(100, 20);
            this.txtLongitud.TabIndex = 3;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(183, 239);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 4;
            // 
            // txtConversion
            // 
            this.txtConversion.AutoSize = true;
            this.txtConversion.Location = new System.Drawing.Point(47, 242);
            this.txtConversion.Name = "txtConversion";
            this.txtConversion.Size = new System.Drawing.Size(101, 13);
            this.txtConversion.TabIndex = 5;
            this.txtConversion.Text = "Longitud convertida";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(125, 315);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 25);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(281, 315);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpDe
            // 
            this.grpDe.Controls.Add(this.lstDe);
            this.grpDe.Location = new System.Drawing.Point(15, 91);
            this.grpDe.Name = "grpDe";
            this.grpDe.Size = new System.Drawing.Size(185, 125);
            this.grpDe.TabIndex = 8;
            this.grpDe.TabStop = false;
            this.grpDe.Text = "De";
            // 
            // grpA
            // 
            this.grpA.Controls.Add(this.lstA);
            this.grpA.Location = new System.Drawing.Point(245, 91);
            this.grpA.Name = "grpA";
            this.grpA.Size = new System.Drawing.Size(192, 125);
            this.grpA.TabIndex = 0;
            this.grpA.TabStop = false;
            this.grpA.Text = "a";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 406);
            this.Controls.Add(this.grpA);
            this.Controls.Add(this.grpDe);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtConversion);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.lblLongitud);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.grpDe.ResumeLayout(false);
            this.grpA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.ListBox lstDe;
        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label txtConversion;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpDe;
        private System.Windows.Forms.GroupBox grpA;
    }
}