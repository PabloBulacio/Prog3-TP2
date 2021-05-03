using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        private List<Articulos> listaArticulos;
        
        public Form1()
        {
            InitializeComponent();
        }

        #region Eventos Click de botones
        /**
        * Descripcion. Eventos Click de los siguientes botones
        * -Agregar
        * -Modificar
        * -Detalles
        * -Buscar
        * -Eliminar
        */
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Form_Agregar elemento = new Form_Agregar();
            elemento.ShowDialog();
            cargarGrilla();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {           
            if(dgvArticulos.SelectedRows.Count > 0)
            {
                Articulos selectedItem = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

                Form_Agregar ModifyingForm = new Form_Agregar(selectedItem);//PAT [2020-29-04] - Cambio para usar la ventana Form_Agregar en lugar de Form_Modificar ya que los dos forms son similares y podriamos usar el mismo form para las dos acciones
                ModifyingForm.ShowDialog();
                cargarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un item");
            }
        }

        private void btn_Detalles_Click(object sender, EventArgs e)
        {
            Articulos selectedItem = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

            Form_Detalles ModifyingForm = new Form_Detalles(selectedItem);
            ModifyingForm.ShowDialog();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            busqueda();
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {

            if (dgvArticulos.SelectedRows.Count > 0)
            {
                Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                ArticulosNegocio articuloNegocio = new ArticulosNegocio();
                try
                {
                    if (MessageBox.Show("Estás seguro de eliminarlo?", "Confirme la Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        articuloNegocio.eliminar(seleccionado.IdArticulo);
                        cargarGrilla();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un item");
            }
        }
        #endregion Eventos Click de botones

        #region Eventos automaticos
        /**
        * Descripcion. Eventos automaticos que no son On-Click de botones.
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void dgvArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            ReloadImg(seleccionado.ImagenUrl);
        }

        private void text_Filtro_KeyUp(object sender, KeyEventArgs e)
        {
            busqueda();
        }
        #endregion Eventos automaticos
        
        #region Eventos custom
        /**
        * Descripcion. Funciones creadas manualmente.
        */
        private void busqueda()
        {

            List<Articulos> listaFiltrada;
            if (text_Filtro.Text != "")
            {
                listaFiltrada = listaArticulos.FindAll(buscado => buscado.Nombre.ToUpper().Contains(text_Filtro.Text.ToUpper()) || buscado.Marca.Descripcion.ToUpper().Contains(text_Filtro.Text.ToUpper()) || buscado.Codigo.ToUpper().Contains(text_Filtro.Text.ToUpper()));
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
            }
            else
            {
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaArticulos;
            }

            ocultarColumnas();
        }

        private void ocultarColumnas()
        {

            dgvArticulos.Columns["IdArticulo"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
        }

        private void cargarGrilla()
        {
            ArticulosNegocio articulosNegocio = new ArticulosNegocio();

            try
            {
                listaArticulos = articulosNegocio.Listar();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();


                ReloadImg(listaArticulos[0].ImagenUrl);
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
                pictureBox_Articulo.Load(img);
            }
            catch (Exception ex)
            {
                MessageBox.Show("La imagen del articulo seleccionado no pudo cargarse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox_Articulo.Image = null;
            }
        }
        #endregion Eventos custom
    }

}
