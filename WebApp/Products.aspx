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
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <a href="DetalleArticulo.aspx?id=<% = item.IdArticulo %>" class="btn btn-primary">Ver Detalle</a>
                            <a href="Carrito.aspx?id=<% = item.IdArticulo %>"><i class="fas fa-heart"></i></a>

                        </div>
                    </div>
                </div>
             <% } %>
        </div>
    </div>
</asp:Content>
