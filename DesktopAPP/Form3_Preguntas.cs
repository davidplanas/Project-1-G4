using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DesktopAPP
{
    public partial class Form3_Preguntas : Form
    {
        public Form3_Preguntas()
        {
            InitializeComponent();
        }

        private void Form3_Preguntas_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void button3_Atras_Click(object sender, EventArgs e)
        {
            // Oculta Form3_Preguntas y abre Form2_Administrar
            this.Hide();
            Form2_Administrar F_Adm = new Form2_Administrar();
            F_Adm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aun no he terminado esto xd
            //JArray  jArrayPreguntas = JArray.Parse(File.ReadAllText(preguntas.json));
           //dataGridView_form3.DataSource = jArrayPreguntas;
        }

        private void button3_añadirpregunta_Click(object sender, EventArgs e)
        {
            //Oculta Form3 y abre Form4
            this.Hide();
            Form4_AñadirPregunta F_Adm = new Form4_AñadirPregunta();
            F_Adm.ShowDialog();
        }

        private void button3_modificarpregunta_Click(object sender, EventArgs e)
        {
            //Oculta Form3 y abre Form4
            this.Hide();
            Form4_AñadirPregunta F_Adm = new Form4_AñadirPregunta();
            F_Adm.ShowDialog();
        }

        private void button3_eliminarpregunta_Click(object sender, EventArgs e)
        {
            //Falta el codigo para eliminar preguntas...
        }
    }
}
