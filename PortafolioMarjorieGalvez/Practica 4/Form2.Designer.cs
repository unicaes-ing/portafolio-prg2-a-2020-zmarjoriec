namespace Practica_4
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.lblNumB = new System.Windows.Forms.Label();
            this.txtNumBus = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(335, 61);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(158, 61);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 1;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(28, 61);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(44, 13);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "Número";
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(31, 125);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(136, 134);
            this.lstNumeros.TabIndex = 3;
            // 
            // lblNumB
            // 
            this.lblNumB.AutoSize = true;
            this.lblNumB.Location = new System.Drawing.Point(270, 171);
            this.lblNumB.Name = "lblNumB";
            this.lblNumB.Size = new System.Drawing.Size(44, 13);
            this.lblNumB.TabIndex = 4;
            this.lblNumB.Text = "Número";
            // 
            // txtNumBus
            // 
            this.txtNumBus.Location = new System.Drawing.Point(273, 199);
            this.txtNumBus.Name = "txtNumBus";
            this.txtNumBus.Size = new System.Drawing.Size(100, 20);
            this.txtNumBus.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(273, 256);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 384);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNumBus);
            this.Controls.Add(this.lblNumB);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Label lblNumB;
        private System.Windows.Forms.TextBox txtNumBus;
        private System.Windows.Forms.Button btnBuscar;
    }
}