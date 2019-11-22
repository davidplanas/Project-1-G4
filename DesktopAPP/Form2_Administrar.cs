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
    public partial class Form2_Administrar : Form
    {
        public Form2_Administrar()
        {
            InitializeComponent();
        }

        private void Form2_Administrar_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void button2_Atras_Click(object sender, EventArgs e)
        {
            //Oculta Form2_Administrar y abre Form1_Iniciar
            this.Hide();
            Form1_Iniciar F_Iniciar = new Form1_Iniciar();
            F_Iniciar.ShowDialog();            
        }

        private void button2_AdmPregunta_Click(object sender, EventArgs e)
        {
           //Oculta Form2_Administrar y abre Form3_Preguntas
           this.Hide();
           Form3_Preguntas F_Preguntas = new Form3_Preguntas();
           F_Preguntas.ShowDialog();
        }

        private void button2_AdmLogros_Click(object sender, EventArgs e)
        {
            // Oculta Form2_Administrar y abre Form6_Logros
             this.Hide();
             Form6_PantallaLogros F_Logros = new Form6_PantallaLogros();
             F_Logros.ShowDialog();
        }
    }
}
