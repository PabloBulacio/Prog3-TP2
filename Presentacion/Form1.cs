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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Form_Agregar elemento = new Form_Agregar();
            elemento.ShowDialog();
            cargarGrilla();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Articulos selectedItem = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

            Form_Agregar ModifyingForm = new Form_Agregar(selectedItem);//PAT [2020-29-04] - Cambio para usar la ventana Form_Agregar en lugar de Form_Modificar ya que los dos forms son similares y podriamos usar el mismo form para las dos acciones
            ModifyingForm.ShowDialog();
            cargarGrilla();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e) { }

        private void btn_Detalles_Click(object sender, EventArgs e)
        {
            Form_Detalles elemento = new Form_Detalles();
            elemento.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void ReloadImg(string img)
        {
            pictureBox_Articulo.Load(img);
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

      

        private void ocultarColumnas()
        {

            dgvArticulos.Columns["Marca"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            ReloadImg(seleccionado.ImagenUrl);
        }

        private void btn_Eliminar_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            busqueda();
        }

        private void text_Filtro_KeyUp(object sender, KeyEventArgs e)
        {
            busqueda();
        }
        
        private void busqueda()
        {

            List<Articulos> listaFiltrada;
            if (text_Filtro.Text != "")
            {
                listaFiltrada = listaArticulos.FindAll(buscado => buscado.Nombre.ToUpper().Contains(text_Filtro.Text.ToUpper()) || buscado.Marca.Descripcion.ToUpper().Contains(text_Filtro.Text.ToUpper()));
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

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
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
    }
    
}
