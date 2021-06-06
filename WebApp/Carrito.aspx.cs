﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebApp
{
    public partial class Carrito : System.Web.UI.Page
    {

        public List<Articulos> carritos;
        protected void Page_Load(object sender, EventArgs e)
        {
            carritos = (List<Articulos>)Session["listaCarrito"];
            if (carritos == null)
                carritos = new List<Articulos>();

            if (!IsPostBack)
            {
                if (Request.QueryString["idArticulo"] != null)
                {
                    if (carritos.Find(x => x.IdArticulo.ToString() == Request.QueryString["idArticulo"]) == null)
                    {
                        List<Articulos> listadoOriginal = (List<Articulos>)Session["listadoArticulos"];
                        carritos.Add(listadoOriginal.Find(x => x.IdArticulo.ToString() == Request.QueryString["idArticulo"]));
                    }
                }

                //Repeater
                repetidor.DataSource = carritos;
                repetidor.DataBind();
            }

            Session.Add("listaCarrito", carritos);

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            var argument = ((Button)sender).CommandArgument;
        }

        protected void btnEliminar2_Click(object sender, EventArgs e)
        {
            var argument = ((Button)sender).CommandArgument;
            List<Articulos> carritos = (List<Articulos>)Session["listaCarritos"];
            Articulos elim = carritos.Find(x => x.IdArticulo.ToString() == argument);
            carritos.Remove(elim);
            Session.Add("listaCarritos", carritos);
            repetidor.DataSource = null;
            repetidor.DataSource = carritos;
            repetidor.DataBind();
        }

     
    }
}