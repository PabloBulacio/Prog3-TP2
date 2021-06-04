using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace WebApp
{
    public partial class Products : System.Web.UI.Page
    {
        private List<Articulos> listaArticulos;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticulosNegocio articulosNegocio = new ArticulosNegocio();

            try
            {
                listaArticulos = articulosNegocio.Listar();
                dgvProducts.DataSource = listaArticulos;
                dgvProducts.DataBind();
            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx");
            }
        }
    }
}