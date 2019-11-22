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
            MaximizeBox = false;
        }

        private void button7_Guardar_Click(object sender, EventArgs e)
        {
            /*
             * Creo una string para guardar tanto el logro como la descripción.
             */
            string descripción_logro = richTextBox7_Logro.Text;
            string logro = textBox7_Logro.Text;
            MessageBox.Show(" Tu logro: " + logro + " de descripción: " + descripción_logro + " ha sido añadido. ");
            //Oculta Form7 y abre Form6
            this.Hide();
            Form6_PantallaLogros F_Logro = new Form6_PantallaLogros();
            F_Logro.ShowDialog();

        }

        private void button7_Atras_Click(object sender, EventArgs e)
        {
            // Oculta Form7 y abre Form6
            this.Hide();
            Form6_PantallaLogros F_Adm = new Form6_PantallaLogros();
            F_Adm.ShowDialog();
        }

        private void richTextBox7_Logro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
