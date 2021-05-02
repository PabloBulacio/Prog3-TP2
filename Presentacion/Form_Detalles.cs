using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form_Detalles : Form
    {
        public Form_Detalles()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Detalles_Load(object sender, EventArgs e)
        {
            ///String detalles;

            ///detalles = "Nombre: " + txt_Nombre.Text + "\r\n";
            ///detalles += "Ocupacion: " + (String)(checkBox_Programador.Checked ? "Programador" : "No es Programador") + "\r\n";
            ///detalles += "Sexo: " + (String)(radioButton_Hombre.Checked ? "Hombre" : "Mujer") + "\r\n";

            //Vuelco la salida al TextBox Salida.
            ///txt_Detalles.Text = detalles;
        }

        private void textBox_Detalles_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
