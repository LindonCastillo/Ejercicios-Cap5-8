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

namespace Ejercicios_Cap5_8.Capitulo_8
{
    public partial class FormEj5_Cap8 : Form
    {
        public FormEj5_Cap8()
        {
            InitializeComponent();
        }

        ArrayList Cadenas = new ArrayList(2);
        private void MostrarOrden_button_Click(object sender, EventArgs e)
        {
            if(Cadena1_textBox.Text == string.Empty|| Cadena2_textBox.Text == string.Empty)
            {
                MessageBox.Show("No Deje Los Campos Cadena 1 y Cadena 2 Vacios","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string cadena1 = Convert.ToString(Cadena1_textBox.Text);
                string cadena2 = Convert.ToString(Cadena2_textBox.Text);

                Cadenas.Insert(0,cadena1);
                Cadenas.Insert(1,cadena2);
                Cadenas.Sort();

                OrdenCadena1_textBox.Text = Convert.ToString(Cadenas[0]);
                OrdenCadena2_textBox.Text = Convert.ToString(Cadenas[1]);
                Cadenas.Clear();
            }


        }
    }
}
