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
    public partial class Form4_AñadirPregunta : Form
    {
        public Form4_AñadirPregunta()
        {
            InitializeComponent();
        }

        private void Form4AñadirPregunta_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void comboBox4_Dificultad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_Pregunta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Respuesta1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Respuesta2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Respuesta3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Respuesta_correcta_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Guardar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Esto no sera asi, era para testear el boton
            Form5_ModificarPregunta F_MPregunta = new Form5_ModificarPregunta();
            F_MPregunta.ShowDialog();
        }

        private void button4_Atras_Click(object sender, EventArgs e)
        {
            //Oculta Form4_AñadirPregunta y abre Form3_Preguntas
            this.Hide();
            Form3_Preguntas F_Preguntas = new Form3_Preguntas();
            F_Preguntas.ShowDialog();
        }
    }
}
