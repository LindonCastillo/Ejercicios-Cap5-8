using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios_Cap5_8.Capitulo_5;
using Ejercicios_Cap5_8.Capitulo_7;

namespace Ejercicios_Cap5_8
{
    public partial class FormMenuEjercicio : Form
    {
        public FormMenuEjercicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEj4_Cap5 formEj4_Cap5 = new FormEj4_Cap5();
            formEj4_Cap5.Show();
        }

        private void Ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEj2_Cap7 formEj2_Cap7 = new FormEj2_Cap7();
            formEj2_Cap7.Show();
        }

        private void Ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEj5_Cap7 formEj5_Cap7 = new FormEj5_Cap7();
            formEj5_Cap7.Show();
        }
    }
}
