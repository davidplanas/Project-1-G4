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

        }

        private void button5_Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Esto no sera asi, era para testear el boton
            Form4_AñadirPregunta F_APregunta = new Form4_AñadirPregunta();
            F_APregunta.ShowDialog();
        }
    }
}