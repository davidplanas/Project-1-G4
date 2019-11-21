using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAPP
{
    public partial class Form8_ModificarLogro : Form
    {
        public Form8_ModificarLogro()
        {
            InitializeComponent();
        }

        private void button8_Guardar_Click(object sender, EventArgs e)
        {
            /*
             * Creo una string para guardar tanto el logro como la descripción.
             */
            string descripción_logro = richTextBox8_Logro.Text;
            string logro = textBox8_Logro.Text;
            MessageBox.Show(" Tu logro: " + logro + " de descripción: " + descripción_logro + " ha sido añadido. ");
        }
    }
}
