<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="carrito.aspx.cs" Inherits="TiendaVehiculo.usuario.cliente.carrito" %>


<asp:Content ID="Content3" ContentPlaceHolderID="foldermedio" runat="server">
  
    <h1> Carrito</h1>

    <div id="cuadricula">
        <asp:Table id="carrito">
            <asp:TableHeaderRow>
                <asp:TableCell>Referéncia</asp:TableCell>
                <asp:TableCell>Artículo</asp:TableCell>
                <asp:TableCell>Precio</asp:TableCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableCell>C1</asp:TableCell>
                <asp:TableCell>
                    <asp:TableCell><img src="../../imagenes/vehiculos/coches/seat ibiza.png" /></asp:TableCell>
                    <asp:TableCell> Seat Ibiza</asp:TableCell>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableFooterRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>Total:</asp:TableCell>
                <asp:TableCell ID="total">19000</asp:TableCell>
            </asp:TableFooterRow>
            
        </asp:Table>    
    </div>

</asp:Content>

