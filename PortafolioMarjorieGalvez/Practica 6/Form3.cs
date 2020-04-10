using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
      
        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }

        public struct Datos
        {
            public string NIT;
            public string Nombre;
            public double Sueldo;
        }
        Dictionary<string, Datos> Registro = new Dictionary<string, Datos>();

        string patronNombre = @"^(([A-Z[ÄËÏÖÜ][a-zñ[áéíóú]{2,})(\s)?)*[^\s]$";


        private void btnAgg_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "" || !Regex.IsMatch(txtNom.Text, patronNombre))
            {
                MessageBox.Show("Ingrese un nombre.");
                txtNom.Focus();
            }
            else if (mskNIT.Text == "" || !mskNIT.MaskFull)
            {
                MessageBox.Show("Ingrese un NIT.");
                mskNIT.Focus();
            }
            else if (txtSueldo.Text == "")
            {
                MessageBox.Show("Ingrese un sueldo.");
                txtNom.Focus();
            }
            else if (Registro.ContainsKey(mskNIT.Text))
            {
                MessageBox.Show("Este número de NIT ya existe en el registo, Ingrese un numero de NIT nuevo...");
            }
            else
            {
                Datos Dato = new Datos();
                Dato.NIT = mskNIT.Text;
                Dato.Nombre = txtNom.Text;
                Dato.Sueldo = Convert.ToDouble(txtSueldo.Text);
               Registro.Add(Dato.NIT, Dato);

                dgv1.Rows.Add(Dato.NIT, Dato.Nombre, Dato.Sueldo);
                dgv1.ClearSelection();
                double total = 0.0;
                for (int i = 0; i < dgv1.Rows.Count; i++)
                {
                    total = total + Convert.ToDouble(dgv1.Rows[i].Cells[2].Value);
                }
                lblTotal.Text = "Total Planilla: $" + total.ToString();

            }
            mskNIT.Text = "";
            txtNom.Clear();
            txtSueldo.Clear();
            mskNIT.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (mskNIT2.Text == "" || !mskNIT2.MaskFull)
            {
                MessageBox.Show("Ingrese un código");
                mskNIT2.Focus();
            }
            else if (Registro.ContainsKey(mskNIT2.Text))
            {
                for (int M = 0; M < dgv1.Rows.Count; M++)
                {
                    dgv1.Rows[M].DefaultCellStyle.BackColor = Color.White;
                    if (dgv1.Rows[M].Cells[0].Value.Equals(mskNIT2.Text))
                    {
                        dgv1.Rows[M].DefaultCellStyle.BackColor = Color.Aquamarine;
                    }
                }

            }
            else
            {
                MessageBox.Show("El NIT ingresado no esta regirstrado");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (mskNIT2.Text == "" || !mskNIT2.MaskFull)
            {
                MessageBox.Show("Ingrese un código ha eliminar");
                mskNIT2.Focus();
            }
            else if (Registro.ContainsKey(mskNIT2.Text))
            {
                for (int M = 0; M < dgv1.Rows.Count; M++)
                {
                    if (dgv1.Rows[M].Cells[0].Value.Equals(mskNIT2.Text))
                    {
                        dgv1.Rows.RemoveAt(M);
                        Registro.Remove(mskNIT2.Text);
                    }
                }
                double total = 0.0;
                for (int i = 0; i < dgv1.Rows.Count; i++)
                {
                    total = total + Convert.ToDouble(dgv1.Rows[i].Cells[2].Value);
                }
                lblNIT.Text = "Total Planilla: $" + total.ToString();
            }
            else
            {
                MessageBox.Show("Código no existente");
            }
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && !txtSueldo.Text.Contains("."))
            {
                e.Handled = false;
            }
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
