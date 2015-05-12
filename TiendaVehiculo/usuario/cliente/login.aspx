<%@ Page Title="" Language="C#" MasterPageFile="~/usuario/cliente/clientedefault.master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TiendaVehiculo.usuario.cliente.login" %>

<asp:Content ID="Content2" ContentPlaceHolderID="medio" runat="server">
	
<div id="iniciar sesion">
	<div id="usuario">
		<asp:TextBox ID="TextBox1" runat="server" Text="Usuario"></asp:TextBox>
		<asp:Label ID="Label1" class="error" runat="server"></asp:Label>
	</div>
	<div id="contra">
		<asp:TextBox ID="TextBox2" runat="server" Text="Contraseña"></asp:TextBox>
		<asp:Button ID="Button1" runat="server" Text="Iniciar" onClick="Button1_Click"/>
	</div>
	<div id="registroinicio">
		<a href="Registro.aspx">Registrarse </a>
	</div>


	<div id="recuperar">
		<h4> Recuperar contraseña</h4>
		<asp:TextBox ID="TextBox3" runat="server" Text="Correo"></asp:TextBox>
		<asp:Button ID="Button2" runat="server" Text="Recuperar" />
	</div>
</div>

</asp:Content>
