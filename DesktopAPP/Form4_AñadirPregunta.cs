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
            //Añado la constante "Dificultades" de la clase "Constantes" a la comboBox4_Dificultad
            comboBox4_Dificultad.Items.AddRange(Constantes.Dificultades);            
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
            if (comboBox4_Dificultad.Text == "" || richTextBox4_Pregunta.Text == "" || textBox4_Respuesta1.Text == "" || textBox4_Respuesta2.Text == "" || textBox4_Respuesta3.Text == "" || textBox4_Respuesta_correcta.Text == "")
            {
                MessageBox.Show("¡Para guardar una nueva pregunta debes rellenar todos los campos!", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string pregunta = richTextBox4_Pregunta.Text;
                MessageBox.Show(" Tu pregunta: " + pregunta + " ha sido añadida. ");
                //Oculta Form4_AñadirPregunta y abre Form3_Preguntas
                this.Hide();
                Form3_Preguntas F_MPregunta = new Form3_Preguntas();
                F_MPregunta.ShowDialog();
            }
            
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
