<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="carrito.aspx.cs" Inherits="TiendaVehiculo.usuario.cliente.carrito" %>


<asp:Content ID="Content3" ContentPlaceHolderID="foldermedio" runat="server">
  
    <h1> 
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="cliente,vehiculo" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="cliente" HeaderText="cliente" ReadOnly="True" SortExpression="cliente" />
                <asp:BoundField DataField="vehiculo" HeaderText="vehiculo" ReadOnly="True" SortExpression="vehiculo" />
                <asp:BoundField DataField="cantidad" HeaderText="cantidad" SortExpression="cantidad" />
                <asp:BoundField DataField="fecha" HeaderText="fecha" SortExpression="fecha" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [CARRITO]"></asp:SqlDataSource>
    </h1>

    <div id="carrito">

    </div>
</asp:Content>

