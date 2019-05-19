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
    public partial class FormEj2_Cap7 : Form
    {
        public FormEj2_Cap7()
        {
            InitializeComponent();
        }

        Hashtable MiDiccionario = new Hashtable();

        private void Limpiar()
        {
            Palabra_textBox.Text = string.Empty;
            Definicion_richTextBox.Text = string.Empty;
        }


        private void Buscar_button_Click(object sender, EventArgs e)
        {
            bool existe;

            string palabra = Convert.ToString(Palabra_textBox.Text);
            string definicion = Convert.ToString(Definicion_richTextBox.Text);
            existe = MiDiccionario.Contains(palabra);


            if (existe == true)
            {
                Definicion_richTextBox.Text = Convert.ToString(MiDiccionario[palabra]);
                MessageBox.Show("La palabra se encuentra en el dicionario", "Encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Esta palabra no existe!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Agregar_button_Click(object sender, EventArgs e)
        {
            if(Palabra_textBox.Text == string.Empty || Definicion_richTextBox.Text == string.Empty)
            {
                MessageBox.Show("No se puedenn dejar los campos Vacios","Fallo!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string palabra = Convert.ToString(Palabra_textBox.Text);
                string definicion = Convert.ToString(Definicion_richTextBox);
                MiDiccionario.Add(palabra, definicion);
                Limpiar();
                MessageBox.Show("Se ha agregado la palabra", "Guadado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {

            bool existePal;
            bool existeDef;

            string palabra = Convert.ToString(Palabra_textBox.Text);
            string definicion = Convert.ToString(Definicion_richTextBox.Text);
            existePal = MiDiccionario.Contains(palabra);
            existeDef = MiDiccionario.Contains(definicion);

            if (existePal == true || existeDef == true)
            {
                MiDiccionario.Remove(palabra);
                Limpiar();
                MessageBox.Show("La palabra se ha borrado del diccionario", "Borrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Esta palabra no existe!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
