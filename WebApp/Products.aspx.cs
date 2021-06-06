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
        public List<Articulos> listaArticulos;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticulosNegocio articulosNegocio = new ArticulosNegocio();

            try
            {
                listaArticulos = articulosNegocio.Listar();

                Session.Add("listadoArticulos", listaArticulos);
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx");
            }

        }
    }
}