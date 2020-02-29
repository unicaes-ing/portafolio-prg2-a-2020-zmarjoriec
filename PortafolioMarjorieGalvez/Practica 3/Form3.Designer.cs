namespace Practica_3
{
    partial class Form4
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
            this.btnLanzar = new System.Windows.Forms.Button();
            this.lstDado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnLanzar
            // 
            this.btnLanzar.Location = new System.Drawing.Point(79, 242);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(75, 23);
            this.btnLanzar.TabIndex = 0;
            this.btnLanzar.Text = "Lanzar";
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // lstDado
            // 
            this.lstDado.FormattingEnabled = true;
            this.lstDado.Location = new System.Drawing.Point(59, 38);
            this.lstDado.Name = "lstDado";
            this.lstDado.Size = new System.Drawing.Size(124, 173);
            this.lstDado.TabIndex = 1;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 304);
            this.Controls.Add(this.lstDado);
            this.Controls.Add(this.btnLanzar);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.ListBox lstDado;
    }
}