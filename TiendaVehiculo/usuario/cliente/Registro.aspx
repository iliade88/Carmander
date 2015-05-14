<%@ Page Title="" Language="C#" MasterPageFile="~/usuario/cliente/clientedefault.master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="TiendaVehiculo.usuario.cliente.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="medio" runat="server">

    <h1>Completa el registro</h1>

    <div id="Name">
        <h2>Nombre, Apellidos y dni</h2>
    <asp:TextBox ID="Nombre" runat="server" Text="nombre"></asp:TextBox>
    <asp:TextBox ID="Apellido1" runat="server" Text="Primer apellido"></asp:TextBox>
    <asp:TextBox ID="Apellido2" runat="server" Text="Segundo apellido"></asp:TextBox>
    </div>

    <div id="dni">
          <h2>DNI</h2>
         <asp:TextBox ID="DNI" runat="server" Text="DNI"></asp:TextBox>
    </div>

    <div id="data">
        <h2>Fecha de nacimiento </h2>
    <asp:TextBox ID="day" runat="server" Text=" DD/MM/AAAA"></asp:TextBox>
    </div>


    <div id="email">
        <h2>Correo Electrónico</h2>
    <asp:TextBox ID="Correo" runat="server" Text="Correo electronico"></asp:TextBox>
    <asp:TextBox ID="Contraseña" runat="server" Text="Contraseña"></asp:TextBox>
        </div>

    <div id="Condiciones">
        
       
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Acepto las condiciones del registro" />
        
    </div>

    <div id="aceptar">
        <asp:Button ID="aceptado" runat="server" Text="Registro" />
        <asp:Label ID="Label1" class="error" runat="server"></asp:Label>
    </div>

</asp:Content>
