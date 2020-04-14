using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace Practica_7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string patronNombre = @"^(([A-Z[ÄËÏÖÜ][a-zñ[áéíóú]{1,})(\s)?)*[^\s]$";
        string patronCodigo = @"^[A-Z]{2}[0-9]{4}$";
        [Serializable]
        public struct Datos
        {
            public string Codigo;
            public string Nombre;
            public string Propietario;
            public string Especie;
            public string FechaNacimiento;
            public double Peso;
            public string Sexo;
        }
        Datos dato = new Datos();
        Dictionary<string, Datos> regisMascotas = new Dictionary<string, Datos>();
        BinaryFormatter formatter = new BinaryFormatter();
        const string NOMBRE_ARCHIVO = "mascotas.dat";

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (mskCodigo.Text == "" || !mskCodigo.MaskFull || !Regex.IsMatch(mskCodigo.Text, patronCodigo))
            {
                MessageBox.Show("Ingrese el codigo");
                mskCodigo.Focus();
            }
            else if (txtNom.Text == "" || !Regex.IsMatch(txtNom.Text, patronNombre))
            {
                MessageBox.Show("Ingrese el nombre");
                txtNom.Focus();
            }
            else if (Convert.ToString(cboPropietario.SelectedItem) == "")
            {
                MessageBox.Show("Debe seleccionar un propietario de la mascota");
            }
            else if (Convert.ToString(cboEspecie.SelectedItem) == "")
            {
                MessageBox.Show("Ingrese la especie");
            }
            else if (txtPeso.Text == "")
            {
                MessageBox.Show("Ingrese el peso");
                txtNom.Focus();
            }
            else
            {
                dato.Codigo = mskCodigo.Text;
                dato.Nombre = txtNom.Text;
                dato.Propietario = cboPropietario.Text;
                dato.Especie = cboEspecie.Text;
                dato.FechaNacimiento = dtpNaci.Text;
                dato.Peso = Convert.ToDouble(txtPeso.Text);
                if (rdoMacho.Checked)
                {
                    dato.Sexo = rdoMacho.Text;
                }
                else
                {
                    dato.Sexo = rdoHembra.Text;
                }
                if (regisMascotas.ContainsKey(dato.Codigo))
                {
                    MessageBox.Show("El codigo ya se encuentra en el registro");
                    mskCodigo.Focus();
                }
                else
                {
                    regisMascotas.Add(dato.Codigo, dato);
                    try
                    {
                        FileStream writerFS = new FileStream(NOMBRE_ARCHIVO, FileMode.Create, FileAccess.Write);
                        formatter.Serialize(writerFS, regisMascotas);
                        writerFS.Close();
                        MessageBox.Show("Los datos han sido guardados correctamente");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Los datos no fueron guardados correctamente");

                    }
                    dataGridView1.Rows.Add(dato.Codigo, dato.Nombre, dato.Propietario, dato.Especie, dato.FechaNacimiento, dato.Peso, dato.Sexo);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string Nombre, Correo, Telefono;
            FileStream fs = null;
            BinaryReader br = null;
            try
            {
                fs = new FileStream("propietarios.dat", FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                cboPropietario.Items.Clear();
                while (true)
                {
                    Nombre = br.ReadString();
                    Correo = br.ReadString();
                    Telefono = br.ReadString();
                    cboPropietario.Items.Add(Nombre);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                if (br != null)
                {
                    br.Close();
                }
            }
            if (File.Exists(NOMBRE_ARCHIVO))
            {
                try
                {
                    FileStream ReaderFS = new FileStream(NOMBRE_ARCHIVO, FileMode.Open, FileAccess.Read);
                    regisMascotas = (Dictionary<string, Datos>)formatter.Deserialize(ReaderFS);
                    ReaderFS.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("No fue posible leer el archivo");
                }
                if (regisMascotas.Count > 0)
                {
                    dataGridView1.Rows.Clear();

                    foreach (Datos dato in regisMascotas.Values)
                    {
                        dataGridView1.Rows.Add(dato.Codigo, dato.Nombre, dato.Propietario, dato.Especie, dato.FechaNacimiento, dato.Peso, dato.Sexo);
                    }
                    dataGridView1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("No Existen datos almacenados en el archivo");
                }

            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtNom.Text, patronNombre))
            {
                err.SetError(txtNom, "El nombre debe iniciar con letra mayúscula...");
            }
            else
            {
                err.Clear();
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void mskCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!Regex.IsMatch(mskCodigo.Text, patronCodigo))
            {
                err.SetError(mskCodigo, "Ingrese un código valido...");
            }
            else
            {
                err.Clear();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
