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
    public partial class Form7_AñadirLogro : Form
    {
        public Form7_AñadirLogro()
        {
            InitializeComponent();
        }

        private void Form7_AñadirLogro_Load(object sender, EventArgs e)
        {

        }

        private void button7_Guardar_Click(object sender, EventArgs e)
        {
            /*
             * Creo una string para guardar tanto el logro como la descripción.
             */
            string descripción_logro = richTextBox7_Logro.Text;
            string logro = textBox7_Logro.Text;
            MessageBox.Show(" Tu logro: " + logro + " de descripción: " + descripción_logro + " ha sido añadido. ");

        }
    }
}
