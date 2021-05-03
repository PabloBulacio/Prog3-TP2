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
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (Articulo != null)
                {
                    txtCodArticulo.Text = Articulo.Codigo;
                    txtNombreArticulo.Text = Articulo.Nombre;
                    txtDescArticulo.Text = Articulo.Descripcion;
                    txtPrecioArticulo.Text = Articulo.Precio.ToString();
                    txtUrlImagen.Text = Articulo.ImagenUrl;
                    cboMarca.DataSource = marcaNegocio.listar();
                    cboMarca.SelectedValue = Articulo.Marca.Id;
                    cboCategoria.DataSource = categoriaNegocio.listar();
                    cboCategoria.SelectedValue = Articulo.Categoria.Id; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form_Agregar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("De verdad querés salir? Perderás los datos", "Saliendo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                return;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btn_Aceptar_Agregar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio nuevoArtNegocio = new ArticulosNegocio();
            try
            {
                if (Articulo == null)
                    Articulo = new Articulos();

                Articulo.Codigo = txtCodArticulo.Text;
                Articulo.Nombre = txtNombreArticulo.Text;
                Articulo.Descripcion = txtDescArticulo.Text;
                Articulo.Precio = Convert.ToDecimal(txtPrecioArticulo.Text);
                Articulo.Marca = (Marcas)cboMarca.SelectedItem;
                Articulo.Categoria = (Categorias)cboCategoria.SelectedItem;
                Articulo.ImagenUrl = txtUrlImagen.Text;


                if (Articulo.IdArticulo == 0)
                {
                    nuevoArtNegocio.agregar(Articulo);
                    MessageBox.Show("agregado sin problema");
                }
                else
                {
                    nuevoArtNegocio.Modificar(Articulo);
                    MessageBox.Show("Modificado sin problema");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ReloadImg(string img)
        {
            try
            {
                pictureBox_Agregar.Load(img);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            ReloadImg(txtUrlImagen.Text);
        }
    }
}
