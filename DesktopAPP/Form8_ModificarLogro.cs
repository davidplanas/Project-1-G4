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

        private void Form8_ModificarLogro_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void button8_Guardar_Click(object sender, EventArgs e)
        {
            /*
             * Creo una string para guardar tanto el logro como la descripción.
             */
            string descripción_logro = richTextBox8_Logro.Text;
            string logro = textBox8_Logro.Text;
            MessageBox.Show(" Tu logro: " + logro + " de descripción: " + descripción_logro + " ha sido modificado. ");
            //Oculta Form8 y abre Form6
            this.Hide();
            Form6_PantallaLogros F_Logro = new Form6_PantallaLogros();
            F_Logro.ShowDialog();
        }

        private void button8_Atras_Click(object sender, EventArgs e)
        {
            // Oculta Form8 y abre Form6
            this.Hide();
            Form6_PantallaLogros F_Adm = new Form6_PantallaLogros();
            F_Adm.ShowDialog();
        }

        private void richTextBox8_Logro_TextChanged(object sender, EventArgs e)
        {

        }    
    }
}
