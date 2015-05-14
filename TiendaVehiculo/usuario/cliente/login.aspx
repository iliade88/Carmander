<%@ Page Title="" Language="C#" MasterPageFile="~/usuario/cliente/clientedefault.master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TiendaVehiculo.usuario.cliente.login" %>

<asp:Content ID="Content2" ContentPlaceHolderID="medio" runat="server">
	
<div id="iniciarsesion">
    <h1>Iniciar Sesión</h1>
    <hr />
	<div id="usuario">
        <label id="icon" for="email"><i class="icon-envelope"></i></label>
		<asp:TextBox ID="email" name="email" runat="server" placeholder="Email"></asp:TextBox>
		<asp:Label ID="Label1" class="error" runat="server"></asp:Label>
	</div>
	<div id="contra">
        <label id="icon" for="pass"><i class="icon-shield"></i></label>
		<asp:TextBox ID="pass" TextMode="password" runat="server" placeholder="Contraseña"></asp:TextBox>
		<asp:Button ID="Button1" runat="server" Text="Iniciar" class="button" onClick="Button1_Click"/>
	</div>
    <hr />
	<div id="registroinicio">
		<a href="Registro.aspx">Registrarse 
        </a>
	</div>


	<div id="recuperar">
		<h4> Recuperar contraseña</h4>
        <label id="icon" for="emailrecup"><i class="icon-envelope"></i></label>
		<asp:TextBox ID="emailrecup" runat="server" placeholder="Email"></asp:TextBox>
		<asp:Button ID="Button2" runat="server" class="button" Text="Recuperar" OnClick="Button2_Click"/>
	</div>
</div>

</asp:Content>
