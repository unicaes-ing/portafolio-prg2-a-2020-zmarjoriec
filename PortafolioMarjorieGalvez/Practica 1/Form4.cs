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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLibros.SelectedItem.Equals("Elenor y Park"))
            {
                txtPrecio.Text = "15.99";
            }
            else if (cboLibros.SelectedItem.Equals("Es cierto que el amor lo cambia todo, todo?"))
            {
                txtPrecio.Text = "20.00";

            }
            else if (cboLibros.SelectedItem.Equals("Harry Potter y la piedra filosofal"))
            {
                txtPrecio.Text = "30.00";
            }
            else if (cboLibros.SelectedItem.Equals("El mundo de Sofía"))
            {
                txtPrecio.Text = "25.98";
            }
            else if (cboLibros.SelectedItem.Equals("Luz negra"))
            {
                txtPrecio.Text = "9.98";
            }
            else
            {
                txtPrecio.Text = "30.99";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sub, total, imp;
            if (cboLibros.SelectedItem.Equals("Elenor y Park"))
            {
                sub = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text);
                imp = sub * 0.13;
                total = sub + imp;
                txtSub.Text = sub.ToString("C2");
                txtImp.Text = imp.ToString("C2");
                txtTotal.Text = total.ToString("C2");
            }
            else if (cboLibros.SelectedItem.Equals("Es cierto que el amor lo cambia todo, todo?"))
            {
                sub = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text);
                imp = sub * 0.13;
                total = sub + imp;
                txtSub.Text = sub.ToString("C2");
                txtImp.Text = imp.ToString("C2");
                txtTotal.Text = total.ToString("C2");
            }
            else if (cboLibros.SelectedItem.Equals("Harry Potter y la piedra filosofal"))
            {
                sub = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text);
                imp = sub * 0.13;
                total = sub + imp;
                txtSub.Text = sub.ToString("C2");
                txtImp.Text = imp.ToString("C2");
                txtTotal.Text = total.ToString("C2");
            }
            else if (cboLibros.SelectedItem.Equals("Harry Potter y la piedra filosofal"))
            {
                sub = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text);
                imp = sub * 0.13;
                total = sub + imp;
                txtSub.Text = sub.ToString("C2");
                txtImp.Text = imp.ToString("C2");
                txtTotal.Text = total.ToString("C2");
            }
            else if (cboLibros.SelectedItem.Equals("El mundo de Sofía"))
            {

                sub = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text);
                imp = sub * 0.13;
                total = sub + imp;
                txtSub.Text = sub.ToString("C2");
                txtImp.Text = imp.ToString("C2");
                txtTotal.Text = total.ToString("C2");

            }
            else if (cboLibros.SelectedItem.Equals("Luz negra"))
            {
                sub = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text);
                imp = sub * 0.13;
                total = sub + imp;
                txtSub.Text = sub.ToString("C2");
                txtImp.Text = imp.ToString("C2");
                txtTotal.Text = total.ToString("C2");
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
            txtImp.Text = "";
            txtPrecio.Text = "";
            txtSub.Text = "";
            txtTotal.Text = "";
            cboLibros.Text = "";
        }
    }
}
