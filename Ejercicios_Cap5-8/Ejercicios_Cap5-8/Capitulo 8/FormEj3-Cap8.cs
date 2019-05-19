using System;
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
    public partial class FormEj3_Cap8 : Form
    {
        public FormEj3_Cap8()
        {
            InitializeComponent();
        }

        private void HoraFehca_timer_Tick(object sender, EventArgs e)
        {
            Hora_label.Text = DateTime.Now.ToString("hh:mm:ss tt");
            Fecha_label.Text = DateTime.Now.ToString("yyyy/dd/MM");
        }
    }
}
