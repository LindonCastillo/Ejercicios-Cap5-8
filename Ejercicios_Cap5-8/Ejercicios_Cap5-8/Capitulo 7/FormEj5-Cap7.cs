using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Cap5_8.Capitulo_7
{
    public partial class FormEj5_Cap7 : Form
    {
        public FormEj5_Cap7()
        {
            InitializeComponent();
        }

        Hashtable MiAgenda = new Hashtable();

        private void LimpiarAgenda()
        {
            Nombre_textBox.Text = string.Empty;
            Telefono_maskedTextBox.Text = string.Empty;
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            if(Nombre_textBox.Text == string.Empty || Telefono_maskedTextBox.Text == string.Empty)
            {
                MessageBox.Show("No puede dejar los campos vacios", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nombre = Convert.ToString(Nombre_textBox.Text);
                string telefono = Convert.ToString(Telefono_maskedTextBox.Text);
                MiAgenda.Add(telefono,nombre);
                LimpiarAgenda();
                MessageBox.Show("El contacto se guardo en la agenda", "Guardado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            bool existe;

            string nombre = Convert.ToString(Nombre_textBox.Text);
            string telefono = Convert.ToString(Telefono_maskedTextBox.Text);
            existe = MiAgenda.Contains(telefono);


            if (existe == true)
            {
                Nombre_textBox.Text =Convert.ToString(MiAgenda[telefono]);
                MessageBox.Show("El contacto se encuentra en la agenda", "Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Este contacto no existe!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Borrar_button_Click(object sender, EventArgs e)
        {
            bool existeTel;
            bool existeNom;

            string nombre = Convert.ToString(Nombre_textBox.Text);
            string telefono = Convert.ToString(Telefono_maskedTextBox.Text);
            existeTel = MiAgenda.Contains(telefono);
            existeNom = MiAgenda.Contains(nombre);

            if(existeNom == true||existeTel == true)
            {
                MiAgenda.Remove(telefono);
                LimpiarAgenda();
                MessageBox.Show("El contacto se borro de la agenda", "Borrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Este contacto no existe!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            LimpiarAgenda();
        }
    }
}
