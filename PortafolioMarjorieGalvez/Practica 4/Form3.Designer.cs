namespace Practica_4
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblFibo = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtFibo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(162, 138);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(45, 48);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(44, 13);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "Número";
            // 
            // lblFibo
            // 
            this.lblFibo.AutoSize = true;
            this.lblFibo.Location = new System.Drawing.Point(45, 222);
            this.lblFibo.Name = "lblFibo";
            this.lblFibo.Size = new System.Drawing.Size(53, 13);
            this.lblFibo.TabIndex = 2;
            this.lblFibo.Text = "Fibonacci";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(137, 48);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 3;
            // 
            // txtFibo
            // 
            this.txtFibo.Location = new System.Drawing.Point(137, 215);
            this.txtFibo.Name = "txtFibo";
            this.txtFibo.Size = new System.Drawing.Size(100, 20);
            this.txtFibo.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 290);
            this.Controls.Add(this.txtFibo);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblFibo);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblFibo;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtFibo;
    }
}