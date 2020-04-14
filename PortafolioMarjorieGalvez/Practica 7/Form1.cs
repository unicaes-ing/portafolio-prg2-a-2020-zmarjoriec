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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string patronNombre = @"^(([A-Z[ÄËÏÖÜ][a-zñ[áéíóú]{1,})(\s)?)*$";
        string patronCorreo = @"^\S[_a-zA-Z0-9-]+(.[_a-zA-Z0-9-]+)*@\S[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{1,4})$";
        string patronTel = @"^([2|6|7][0-9]{3})-([0-9]{4})$";

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || !Regex.IsMatch(txtNombre.Text, patronNombre))
            {
                MessageBox.Show("Ingrese el nombre");
                txtNombre.Focus();
            }
            else if (txtCorreo.Text == "" || !Regex.IsMatch(txtCorreo.Text, patronCorreo) || txtCorreo.Text.Contains(";") || txtCorreo.Text.Contains(":"))
            {
                MessageBox.Show("El correo es un campo obligatorio");
                txtNombre.Focus();
            }
            if (mskTel.Text == "" || !Regex.IsMatch(mskTel.Text, patronTel))
            {
                MessageBox.Show("El teléfono es un campo obligatorio");
                mskTel.Focus();
            }
            else
            {
                dgv1.Rows.Add(txtNombre.Text, txtCorreo.Text, mskTel.Text);
                dgv1.ClearSelection();

                FileStream fs = null;
                BinaryWriter bw = null;
                try
                {
                    fs = new FileStream("propietarios.dat", FileMode.Append, FileAccess.Write);
                    bw = new BinaryWriter(fs);
                    bw.Write(txtNombre.Text);
                    bw.Write(txtCorreo.Text);
                    bw.Write(mskTel.Text);
                    MessageBox.Show("Los datos fueron almacenados");
                    txtCorreo.Clear();
                    txtNombre.Clear();
                    mskTel.Clear();
                    txtNombre.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese los datos correctamente");
                }
                finally
                {
                    if (bw != null) bw.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string nombre, correo, telefono;
            FileStream fs = null;
            BinaryReader br = null;
            try
            {
                fs = new FileStream("propietarios.dat", FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                dgv1.Rows.Clear();
                while (true)
                {
                    nombre = br.ReadString();
                    correo = br.ReadString();
                    telefono = br.ReadString();
                    dgv1.Rows.Add(nombre, correo, telefono);
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
                    dgv1.ClearSelection();
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtNombre.Text, patronNombre))
            {
                error.SetError(txtNombre, "El nombre debe iniciar con letra mayúscula");
            }
            else
            {
                error.Clear();
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtCorreo.Text, patronCorreo) || txtCorreo.Text.Contains(";") || txtCorreo.Text.Contains(":"))
            {
                error.SetError(txtCorreo, "Ingrese un correo valido...");
            }
            else
            {
                error.Clear();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mskTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!Regex.IsMatch(mskTel.Text, patronTel))
            {
                error.SetError(mskTel, "el numero ingresado no es correcto");
            }
            else
            {
                error.Clear();
            }
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            if (dgv1.Rows.Count > 0)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ingrese correctamente los datos");
                txtNombre.Focus();
            }
        }
    }
}
