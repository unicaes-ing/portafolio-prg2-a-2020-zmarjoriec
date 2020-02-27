using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total;
            total = Convert.ToDouble(txtIn1.Text) + Convert.ToDouble(txtIn2.Text) + Convert.ToDouble(txtIn3.Text);
            txtPor1.Text = Convert.ToString(((Convert.ToDouble(txtIn1.Text) / total) * 100).ToString("N2") + "%");
            txtPor2.Text = Convert.ToString(((Convert.ToDouble(txtIn2.Text) / total) * 100).ToString("N2") + "%");
            txtPor3.Text = Convert.ToString(((Convert.ToDouble(txtIn3.Text) / total) * 100).ToString("N2") + "%");
            txtInversion.Text = Convert.ToString("C2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIn1.Text = "";
            txtIn2.Text = "";
            txtIn3.Text = "";
            txtPor1.Text = "";
            txtPor2.Text = "";
            txtPor3.Text = "";
            txtInversion.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
