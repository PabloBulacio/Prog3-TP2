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
using Negocio;

namespace Presentacion
{
    public partial class Form_Agregar : Form
    {
        public Form_Agregar()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Agregar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Agregar_Load(object sender, EventArgs e)
        {
            MarcasNegocio marcaNegocio = new MarcasNegocio();
            CategoriasNegocio categoriaNegocio = new CategoriasNegocio();
            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
        }

        private void Form_Agregar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("De verad querés salir? Perderás los datos", "Saliendo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            Dispose();
        }

        private void btn_Aceptar_Agregar_Click(object sender, EventArgs e)
        {
            Articulos nuevoArticulo = new Articulos();
            ArticulosNegocio nuevoArtNegocio = new ArticulosNegocio();
            try
            {
                nuevoArticulo.Codigo = txtCodArticulo.Text;
                nuevoArticulo.Nombre = txtNombreArticulo.Text;
                nuevoArticulo.Descripcion = txtDescArticulo.Text;
                nuevoArticulo.Precio = Convert.ToDecimal(txtPrecioArticulo.Text);
                nuevoArticulo.Marca = (Marcas)cboMarca.SelectedItem;
                nuevoArticulo.Categoria = (Categorias)cboCategoria.SelectedItem;
                nuevoArticulo.ImagenUrl = txtUrlImagen.Text;

                nuevoArtNegocio.agregar(nuevoArticulo);
                MessageBox.Show("agregado sin problema");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
