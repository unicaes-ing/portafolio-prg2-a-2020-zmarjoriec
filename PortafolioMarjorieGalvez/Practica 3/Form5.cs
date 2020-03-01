using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            string nombre = Convert.ToString(txtNombre.Text);
            int hora = Convert.ToInt32(txtHoras.Text);
            double valor = Convert.ToDouble(txtValor.Text);
            double sub, total, iva;
            sub = hora * valor;
            iva = sub * 0.13;
            total = sub + iva;
            dgvTabla.Rows.Add(nombre, hora, valor, sub, iva, total);

            dgvTabla.ClearSelection();
            int tot = 0;
            for (int f = 0; f < dgvTabla.Rows.Count; f++)
            {
                total += Convert.ToInt32(dgvTabla.Rows[f].Cells[3].Value);
                lblTotal.Text = string.Format("{0:C2}", tot);
            }
        }
    }
}
