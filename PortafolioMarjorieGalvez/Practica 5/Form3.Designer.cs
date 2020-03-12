namespace Practica_5
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
            this.lblSucursales = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lstSucursales = new System.Windows.Forms.ListBox();
            this.lstVentas = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSucursales
            // 
            this.lblSucursales.AutoSize = true;
            this.lblSucursales.Location = new System.Drawing.Point(53, 38);
            this.lblSucursales.Name = "lblSucursales";
            this.lblSucursales.Size = new System.Drawing.Size(62, 13);
            this.lblSucursales.TabIndex = 0;
            this.lblSucursales.Text = "Sucursales:";
            this.lblSucursales.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Location = new System.Drawing.Point(311, 38);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(43, 13);
            this.lblVentas.TabIndex = 1;
            this.lblVentas.Text = "Ventas:";
            // 
            // lstSucursales
            // 
            this.lstSucursales.FormattingEnabled = true;
            this.lstSucursales.Location = new System.Drawing.Point(56, 95);
            this.lstSucursales.Name = "lstSucursales";
            this.lstSucursales.Size = new System.Drawing.Size(118, 160);
            this.lstSucursales.TabIndex = 2;
            // 
            // lstVentas
            // 
            this.lstVentas.FormattingEnabled = true;
            this.lstVentas.Location = new System.Drawing.Point(314, 95);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(125, 160);
            this.lstVentas.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(250, 307);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total de ventas:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 388);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstVentas);
            this.Controls.Add(this.lstSucursales);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.lblSucursales);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSucursales;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.ListBox lstSucursales;
        private System.Windows.Forms.ListBox lstVentas;
        private System.Windows.Forms.Label lblTotal;
    }
}