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
    public partial class Form6_PantallaLogros : Form
    {
        public Form6_PantallaLogros()
        {
            InitializeComponent();
        }

        private void Form6_PantallaLogros_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Oculta Form6 y abre Form7
            this.Hide();
            Form7_AñadirLogro F_Adm = new Form7_AñadirLogro();
            F_Adm.ShowDialog();
        }

        private void button5_Atras_Click(object sender, EventArgs e)
        {
            // Oculta Form6 y abre Form2
            this.Hide();
            Form2_Administrar F_Adm = new Form2_Administrar();
            F_Adm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Oculta Form6 y abre Form8
            this.Hide();
            Form8_ModificarLogro F_Adm = new Form8_ModificarLogro();
            F_Adm.ShowDialog();
        }
    }
}
