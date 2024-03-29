﻿using System;
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
    public partial class Form5_ModificarPregunta : Form
    {
        public Form5_ModificarPregunta()
        {
            InitializeComponent();
        }

        private void Form5ModificarPregunta_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void comboBox5_Dificultad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_Pregunta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_Respuesta1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_Respuesta2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_Respuesta3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_Respuesta_correcta_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Guardar_Click(object sender, EventArgs e)
        {
            if (comboBox5_Dificultad.Text == "" || richTextBox5_Pregunta.Text == "" || textBox5_Respuesta1.Text == "" || textBox5_Respuesta2.Text == "" || textBox5_Respuesta3.Text == "" || textBox5_Respuesta_correcta.Text == "")
            {
                MessageBox.Show("¡Para guardar una nueva pregunta debes rellenar todos los campos!", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string pregunta = richTextBox5_Pregunta.Text;
                MessageBox.Show(" Tu pregunta: " + pregunta + " ha sido modificada. ");
                //Oculta Form4_AñadirPregunta y abre Form3_Preguntas
                this.Hide();
                Form3_Preguntas F_MPregunta = new Form3_Preguntas();
                F_MPregunta.ShowDialog();
            }            
        }

        private void button5_Atras_Click(object sender, EventArgs e)
        {
            //Oculta Form5_ModificarPregunta y abre Form3_Preguntas
            this.Hide();
            Form3_Preguntas F_MPregunta = new Form3_Preguntas();
            F_MPregunta.ShowDialog();
        }
    }
}
