<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="WebApp.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        
    <div class="container">
        <div class="row">

            <%foreach(Dominio.Articulos item in listaArticulos)
                {%>
                <div class="col">
                    <div class="card" style="width: 18rem;">
                        <img src="<% = item.ImagenUrl %>"" class="card-img-top" alt="..." />
                        <div class="card-body">
                            <h5 class="card-title"><%= item.Nombre %></h5>
                            <a href="DetalleArticulo.aspx?idArticulo=<% = item.IdArticulo %>" class="btn btn-primary">Ver Detalle</a>
                            <a href="Carrito.aspx?idArticulo=<% = item.IdArticulo %>" class="btn btn-primary">Agregar al carrito</a>
                        </div>
                    </div>
                </div>
             <% } %>
        </div>
    </div>
</asp:Content>
