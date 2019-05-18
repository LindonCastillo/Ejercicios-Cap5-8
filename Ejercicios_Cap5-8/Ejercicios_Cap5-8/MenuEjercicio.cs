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
            //formEj4_Cap5.MdiParent = this;
            formEj4_Cap5.Show();
        }
    }
}
