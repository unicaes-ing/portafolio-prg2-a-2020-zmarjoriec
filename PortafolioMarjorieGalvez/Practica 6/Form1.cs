using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> ListaEmpleados = new List<string>();
        string patronNombre = @"^(([A-Z[ÄËÏÖÜ][a-zñ[áéíóú]{2,})(\s)?)*[^\s]$";

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            lstNombres.DataSource = null;
            if (rdoAgg.Checked)
            {
                lstNombres.Items.Clear();
                txtEmpleado.SelectAll();
                txtEmpleado.Focus();
                if (txtEmpleado.Text != "" && Regex.IsMatch(txtEmpleado.Text, patronNombre))
                {
                    ListaEmpleados.Add(txtEmpleado.Text);
                    foreach (string empleado in ListaEmpleados)
                    {
                        lstNombres.Items.Add(empleado);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre.");
                }
            }

            else if (rdoBuscar.Checked)
            {
                if (txtEmpleado.Text != "" && Regex.IsMatch(txtEmpleado.Text, patronNombre) && lstNombres.Items.Count >= 0)
                {
                    foreach (string empleado in ListaEmpleados)
                    {
                        if (txtEmpleado.Text == empleado)
                        {
                            lstNombres.SelectedItem = empleado;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El nombre no existe en la lista.");
                }
            }
            else if (rdoInsertar.Checked)
            {
                if (txtEmpleado.Text != "" && Regex.IsMatch(txtEmpleado.Text, patronNombre) && lstNombres.Items.Count >= 0)
                {
                    lstNombres.Items.Insert(lstNombres.SelectedIndex, txtEmpleado.Text);
                    ListaEmpleados.Insert(lstNombres.SelectedIndex, txtEmpleado.Text);

                }
                else
                {
                    MessageBox.Show("ERROR!");
                }



            }
            else if (rdoQuitar.Checked)
            {
                if (txtEmpleado.Text != "" && Regex.IsMatch(txtEmpleado.Text, patronNombre) && lstNombres.Items.Count > 0)
                {
                    ListaEmpleados.RemoveAt(lstNombres.SelectedIndex);
                    lstNombres.Items.RemoveAt(lstNombres.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Error al quitar el nombre.");
                }
            }

            else if (rdoOrdenar.Checked)
            {
                ListaEmpleados.Sort();
                if (lstNombres.Items.Count >= 1)
                {
                    lstNombres.DataSource = ListaEmpleados;
                }
                else
                {
                    MessageBox.Show("No se puede ordenar la lista.");
                }
            }
            else
            {
                if (lstNombres.Items.Count >= 1)
                {
                    lstNombres.Items.Clear();
                    ListaEmpleados.Clear();
                }
                else
                {
                    MessageBox.Show("No hay elementos para borrar.");
                }
            }
            txtEmpleado.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
