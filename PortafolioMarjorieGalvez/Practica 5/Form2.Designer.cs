namespace Practica_5
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
            this.dgvA = new System.Windows.Forms.DataGridView();
            this.dgvB = new System.Windows.Forms.DataGridView();
            this.dgvC = new System.Windows.Forms.DataGridView();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rdoMultiplicar = new System.Windows.Forms.RadioButton();
            this.rdoSumar = new System.Windows.Forms.RadioButton();
            this.grp = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).BeginInit();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvA
            // 
            this.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA.Location = new System.Drawing.Point(12, 42);
            this.dgvA.Name = "dgvA";
            this.dgvA.Size = new System.Drawing.Size(206, 124);
            this.dgvA.TabIndex = 0;
            // 
            // dgvB
            // 
            this.dgvB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvB.Location = new System.Drawing.Point(234, 42);
            this.dgvB.Name = "dgvB";
            this.dgvB.Size = new System.Drawing.Size(216, 124);
            this.dgvB.TabIndex = 1;
            // 
            // dgvC
            // 
            this.dgvC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvC.Location = new System.Drawing.Point(475, 42);
            this.dgvC.Name = "dgvC";
            this.dgvC.Size = new System.Drawing.Size(255, 124);
            this.dgvC.TabIndex = 2;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(9, 9);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(47, 13);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "Matríz A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(231, 9);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(47, 13);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "Matríz B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(472, 9);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(47, 13);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "Matríz C";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(133, 36);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rdoMultiplicar
            // 
            this.rdoMultiplicar.AutoSize = true;
            this.rdoMultiplicar.Location = new System.Drawing.Point(13, 62);
            this.rdoMultiplicar.Name = "rdoMultiplicar";
            this.rdoMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rdoMultiplicar.TabIndex = 7;
            this.rdoMultiplicar.TabStop = true;
            this.rdoMultiplicar.Text = "Multiplicar";
            this.rdoMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rdoSumar
            // 
            this.rdoSumar.AutoSize = true;
            this.rdoSumar.Location = new System.Drawing.Point(13, 19);
            this.rdoSumar.Name = "rdoSumar";
            this.rdoSumar.Size = new System.Drawing.Size(55, 17);
            this.rdoSumar.TabIndex = 8;
            this.rdoSumar.TabStop = true;
            this.rdoSumar.Text = "Sumar";
            this.rdoSumar.UseVisualStyleBackColor = true;
            this.rdoSumar.CheckedChanged += new System.EventHandler(this.rdoSumar_CheckedChanged);
            // 
            // grp
            // 
            this.grp.Controls.Add(this.rdoSumar);
            this.grp.Controls.Add(this.btnCalcular);
            this.grp.Controls.Add(this.rdoMultiplicar);
            this.grp.Location = new System.Drawing.Point(221, 221);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(229, 100);
            this.grp.TabIndex = 9;
            this.grp.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 333);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.dgvC);
            this.Controls.Add(this.dgvB);
            this.Controls.Add(this.dgvA);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).EndInit();
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvA;
        private System.Windows.Forms.DataGridView dgvB;
        private System.Windows.Forms.DataGridView dgvC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rdoMultiplicar;
        private System.Windows.Forms.RadioButton rdoSumar;
        private System.Windows.Forms.GroupBox grp;
    }
}