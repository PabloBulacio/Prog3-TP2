<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebApp.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="table">
        <tr>
            <td>Nombre</td>
            <td>Imágen</td>
            <td>Acción</td>
            
        </tr>

        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Nombre")%></td>
                    <td>
                        <img src='<%#Eval("ImagenUrl")%>' alt="Alternate Text" style="max-width:100px"/>
                    <td>
                        <asp:Button Text="Eliminar" CssClass="btn btn-primary" ID="Eliminar" OnClick="Eliminar_Click" CommandArgument='<%#Eval("IdArticulo")%>' runat="server" UseSubmitBehavior="false"/>
                    </td>
                                     
                </tr>

            </ItemTemplate>
        </asp:Repeater>


    </table>

   

</asp:Content>
