using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Practica_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            string patron = @"^[^@]+@[^@]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(txtCorreo.Text, patron))
            {
                e.Cancel = true;
                txtCorreo.SelectAll();
                err.SetError(txtCorreo, "Ingrese un correo válido");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void txtCorreo_Validated(object sender, EventArgs e)
        {
            err.Clear();
        }

        private void txtContra_Validating(object sender, CancelEventArgs e)
        {
            string patron2 = @"(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$";
            if (txtContra.TextLength<8)
            {
                e.Cancel = true;
                txtContra.SelectAll();
                err.SetError(txtContra, "La contraseña debe tener al menos 8 caracteres");

            }
            else if (!Regex.IsMatch(txtContra.Text, patron2))
            {
                e.Cancel = true;
                txtContra.SelectAll();
                err.SetError(txtContra, "La contraseña debe contener al menos un número o carácter");

            }

        }

        private void txtContra_Validated(object sender, EventArgs e)
        {
            err.Clear();
        }

        private void txtConfir_Validating(object sender, CancelEventArgs e)
        {
            string patron3= @"(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$";
            if (txtContra.TextLength < 8)
            {
                e.Cancel = true;
                txtContra.SelectAll();
                err.SetError(txtContra, "La contraseña debe tener al menos 8 caracteres");

            }
            else if (!Regex.IsMatch(txtContra.Text, patron2))
            {
                e.Cancel = true;
                txtContra.SelectAll();
                err.SetError(txtContra, "La contraseña debe contener al menos un número o carácter");

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text=="")
            {
                txtCorreo.Focus();
                MessageBox.Show("Debe crear un correo electronico");
            }
            else if (txtContra.Text=="")
                {
                txtContra.Focus();
                MessageBox.Show("Escriba una contraseña");

            }
            else if (txtConfir.Text=="")
            {
                txtConfir.Focus();
                MessageBox.Show("Escriba una contraseña para poder confirmarla");
            }
            else if (txtContra.Text != txtConfir.Text)
            {
                txtConfir.Focus();
                txtConfir.SelectAll();
                MessageBox.Show("Las contraseñas han sido distintas");
            }
            else
            {
                MessageBox.Show("Los datos se registraron con exito");
                Close();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
