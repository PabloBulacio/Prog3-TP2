using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class Form_Detalles : Form
    {
        private Articulos Articulo = null;

        public Form_Detalles()
        {
            InitializeComponent();
        }
        public Form_Detalles(Articulos nuevoArticulo)
        {
            InitializeComponent();
            this.Articulo = nuevoArticulo;
           
        }

        private void Form_Detalles_Load(object sender, EventArgs e)
        {
            String detalles;

            detalles =  "Código: " + Articulo.Codigo + "\r\n";
            detalles += "Nombre: " + Articulo.Nombre + "\r\n";
            detalles += "Descripción: " + Articulo.Descripcion + "\r\n";
            detalles += "Marca: " + Articulo.Marca.Descripcion + "\r\n";
            detalles += "Categoría : " + Articulo.Categoria.Descripcion + "\r\n";
            detalles += "Precio : $ " + Articulo.Precio + "\r\n"; 

            txt_Detalles.Text = detalles;
            pictureBox_Detalles.Load(Articulo.ImagenUrl);
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
