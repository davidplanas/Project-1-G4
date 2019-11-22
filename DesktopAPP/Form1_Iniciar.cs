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

        private void Form1_Iniciar_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            //Oculta Form1_Iniciar y abre Form2_Administrar
            this.Hide();
            Form2_Administrar F_Adm = new Form2_Administrar();
            F_Adm.ShowDialog();            
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Iniciar_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
