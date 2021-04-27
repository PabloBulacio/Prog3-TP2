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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Form_Agregar elemento = new Form_Agregar();
            elemento.ShowDialog();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Form_Modificar elemento = new Form_Modificar();
            elemento.ShowDialog();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Form_Eliminar elemento = new Form_Eliminar();
            elemento.ShowDialog();
        }

        private void btn_Detalles_Click(object sender, EventArgs e)
        {
            Form_Detalles elemento = new Form_Detalles();
            elemento.ShowDialog();
        }
    }
}
