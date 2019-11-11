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
    public partial class FormIniciar : Form
    {
        public FormIniciar()
        {
            InitializeComponent();
        }

        private void FormIniciar_Load(object sender, EventArgs e)
        {

        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            //Abre el siguiente formulario (Administrar preguntas y logros)
            //Hay que mirar como se hace para que se abra en la misma ventana en lugar de en otra
            //De momento lo dejo asi
            FormAdministrar F_Adm = new FormAdministrar();
            F_Adm.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
