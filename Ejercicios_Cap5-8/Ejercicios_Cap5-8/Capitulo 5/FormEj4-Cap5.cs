using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Cap5_8.Capitulo_5
{
    public partial class FormEj4_Cap5 : Form
    {
        public FormEj4_Cap5()
        {
            InitializeComponent();
        }

        private void Calcular_button_Click(object sender, EventArgs e)
        {
            
            double num = Convert.ToDouble(Numero_textBox.Text);
            double factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }

            Resultado_textBox.Text = Convert.ToString(factorial);
        }
    }
}
