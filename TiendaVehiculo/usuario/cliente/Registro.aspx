<%@ Page Title="" Language="C#" MasterPageFile="~/usuario/cliente/clientedefault.master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="TiendaVehiculo.usuario.cliente.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="medio" runat="server">

    <h1>Completa el registro</h1>

    <div id="Name">
        <h2>Nombre y Apellidos</h2>
    <asp:TextBox ID="Nombre" runat="server" Text="nombre"></asp:TextBox>
    <asp:TextBox ID="Apellidos" runat="server" Text="Apellidos"></asp:TextBox>
    </div>

    <div id="data">
        <h2>Fecha de nacimiento</h2>
    <asp:TextBox ID="day" runat="server" Text="dia"></asp:TextBox>
    <asp:TextBox ID="moth" runat="server" Text="mes"></asp:TextBox>
    <asp:TextBox ID="year" runat="server" Text="año"></asp:TextBox>
    </div>

    <div id="adress">
        <h2>Dirección y código postal</h2>
    <asp:TextBox ID="Direccion" runat="server" Text="Dirección"></asp:TextBox>
    <asp:TextBox ID="CP" runat="server" Text="Codigo postal"></asp:TextBox>
        </div>

    <div id="email">
        <h2>Correo Electrónico</h2>
    <asp:TextBox ID="Correo" runat="server" Text="Correo electronico"></asp:TextBox>
    <asp:TextBox ID="Contraseña" runat="server" Text="Contraseña"></asp:TextBox>
        </div>

    <div id="Condiciones">
        
       
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Acepto las condiciones del registro" />
    </div>

</asp:Content>
