<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UIWEB.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Tela de Usuarios</h1>

<asp:GridView ID="grdUsuarios" runat="server" CellPadding="5" AutoGenerateColumns="False" CssClass="gridGeral">
    <HeaderStyle CssClass = "gridHeader" />
    <RowStyle CssClass = "gridRowStyle" />
    <AlternatingRowStyle CssClass = "gridAltRowStyle" />
    <FooterStyle CssClass = "gridFooterStyle" />
    <Columns>
        <asp:BoundField DataField="usuarioId" HeaderText="ID"/>
        <asp:BoundField DataField="usuarioNome" HeaderText="Nome"/>
        <asp:BoundField DataField="usuarioSenha" HeaderText="Senha"/>
        <asp:BoundField DataField="usuarioNivel" HeaderText="Nivel"/>
        <asp:BoundField DataField="usuarioAtivo" HeaderText="Ativo"/>
    </Columns>
    
</asp:GridView>  
    
    <asp:Button runat="server" ID="btnAdicionar" Text="Adicionar"/> 

</asp:Content>

