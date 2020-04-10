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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        Dictionary<string, string> registroClientes = new Dictionary<string, string>();
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            bool valido = true;
            err.Clear();
            if (txtValor.TextLength <= 0)
            {
                err.SetError(txtValor, "Ingrese el nombre correctamente");
                valido = false;
            }
            else
            {
                string patronNombre = @"^(([A-ZÁÉÍÓÚ][a-zñáéíóú]{2,})(\s)?)*[^\s]$";
                if (!Regex.IsMatch(txtValor.Text, patronNombre))
                {
                    err.SetError(txtValor, "Ingrese de forma correcta, nombre y apellido con inicial mayuscula ");
                    valido = false;
                }
            }
            if (!mskClave.MaskFull)
            {
                err.SetError(mskClave, "Ingrese correctamente el número de telefono");
                valido = false;
            }
            else
            {
                string patronTel = "^([2|6|7][0-9]{3})-([0-9]{4})$";
                if (!Regex.IsMatch(mskClave.Text, patronTel))
                {
                    err.SetError(mskClave, "El número ingresado no es valido");
                    valido = false;
                }
            }
            {
                registroClientes.Add(mskClave.Text, txtValor.Text);
                ListViewItem lista = new ListViewItem(mskClave.Text);
                lista.SubItems.Add(txtValor.Text);
                lstDatos.Items.Add(lista);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (mskClave.TextLength > 0)
            {
                if (!registroClientes.ContainsKey(mskClave.Text))
                {
                    MessageBox.Show("El número no se encuentra en la lista");
                    txtValor.Clear();
                    mskClave.Focus();
                    mskClave.SelectAll();
                }
                else
                {
                    MessageBox.Show("El número pertenece a : " + registroClientes[mskClave.Text].ToString());
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (mskClave.Text.Equals("") || registroClientes.Count == 0)
            {
                MessageBox.Show("No existen datos para borrar");
            }
            else if (lstDatos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un elemento para eliminar");
            }
            else
            {
                registroClientes.Remove(mskClave.Text);
                foreach (ListViewItem lista in lstDatos.SelectedItems)
                {
                    lista.Remove();
                }
            }
        }
    }
}
