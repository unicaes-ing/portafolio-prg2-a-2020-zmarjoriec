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

namespace Practica_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public object ErrorPro { get; private set; }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            string patron = @"^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$";
            
            if (!Regex.IsMatch(txtCorreo.Text),patron)
            {
                e.Cancel = true;
                txtCorreo.SelectAll();
                ErrorPro.SetError(txtCorreo, "Ingrese un correo valido");
            }

            else
            {
                e.Cancel = false;
            }
        }

        private void txtCorreo_Validated(object sender, EventArgs e)
        {
            e.Cancel = false;
        }
    }
}
