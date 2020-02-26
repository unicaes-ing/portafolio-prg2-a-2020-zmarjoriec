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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtBinario.Text = Convert.ToString(Convert.ToInt32(txtDecimal.Text));
            txtOctal.Text = Convert.ToString(Convert.ToInt32(txtDecimal.Text));
            txtHexa.Text = Convert.ToString(Convert.ToInt32(txtDecimal.Text));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDecimal.Text = "";
            txtHexa.Text = "";
            txtOctal.Text = "";
            txtBinario.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
