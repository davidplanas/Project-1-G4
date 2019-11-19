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
    public partial class Form3_Preguntas : Form
    {
        public Form3_Preguntas()
        {
            InitializeComponent();
        }

        private void button3_Atras_Click(object sender, EventArgs e)
        {
            // Oculta Form3_Preguntas y abre Form2_Administrar
            this.Hide();
            Form2_Administrar F_Adm = new Form2_Administrar();
            F_Adm.ShowDialog();
        }
    }
}
