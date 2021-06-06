<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebApp.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="position:absolute; top:50%; left: 50%; margin-top: -100px; margin-left: -100px;" >
        <asp:Button Text="Inicio" ID="btnInit" OnClick="btnInit_Click" runat="server"  />
    </div>
</asp:Content>
