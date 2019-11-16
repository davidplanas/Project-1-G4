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
    public partial class Form1_Iniciar : Form
    {
        public Form1_Iniciar()
        {
            InitializeComponent();
        }

        private void FormIniciar_Load(object sender, EventArgs e)
        {

        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Esto no sera asi, era para testear el boton
            Form4_AñadirPregunta F_APregunta = new Form4_AñadirPregunta();
            F_APregunta.ShowDialog();

            
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
