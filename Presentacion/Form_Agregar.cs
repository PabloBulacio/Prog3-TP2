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
        private Articulos Articulo = null;
        public Form_Agregar()
        {
            InitializeComponent();
        }

        public Form_Agregar(Articulos newArticulo)
        {
            string titleText = "Modificar Articulo";
            InitializeComponent();
            this.Articulo = newArticulo;
            Text = titleText;
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
                if(Articulo != null)
                {
                    
                    txtCodArticulo.Text = Articulo.Codigo;
                    txtNombreArticulo.Text = Articulo.Nombre;
                    txtDescArticulo.Text = Articulo.Descripcion;
                    txtPrecioArticulo.Text = Articulo.Precio.ToString();
                    txtUrlImagen.Text = Articulo.ImagenUrl;
                    cboMarca.DataSource = marcaNegocio.listar();
                    cboMarca.SelectedValue = Articulo.IdMarca;
                    //cboMarca.DisplayMember = "Descripcion";
                    cboCategoria.DataSource = categoriaNegocio.listar();
                    cboCategoria.SelectedValue = Articulo.IdCategoria; 
                    //cboCategoria.DisplayMember = "Descripcion";
                }
                else
                {
                    cboMarca.DataSource = marcaNegocio.listar();
                    cboMarca.ValueMember = "Id";
                    cboMarca.DisplayMember = "Descripcion";
                    cboCategoria.DataSource = categoriaNegocio.listar();
                    cboCategoria.ValueMember = "Id";
                    cboCategoria.DisplayMember = "Descripcion";
                }
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
