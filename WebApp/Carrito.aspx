<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebApp.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="table">
        <tr>
            <td>Nombre</td>
            <td>Acción</td>
            <td>Cantidad</td>
        </tr>

        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Nombre")%></td>
                    <td>
                        <asp:Button Text="Eliminar" CssClass="btn btn-primary" ID="btnEliminar2" OnClick="btnEliminar2_Click" CommandArgument='<%#Eval("IdArticulo")%>' runat="server" />
                    </td>
                                     
                </tr>

            </ItemTemplate>
        </asp:Repeater>


    </table>

   

</asp:Content>
