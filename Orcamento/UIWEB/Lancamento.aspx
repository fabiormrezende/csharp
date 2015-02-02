<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="Lancamento.aspx.cs" Inherits="UIWEB.Lancamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Tela de Lançamentos</h1>
    <p>&nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="LinqDataSource1">
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" EntityTypeName="">
        </asp:LinqDataSource>
    </p>
</asp:Content>
