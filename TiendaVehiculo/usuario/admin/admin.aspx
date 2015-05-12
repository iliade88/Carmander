<%@ Page Title="" Language="C#" MasterPageFile="~/usuario/admin/admin.master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="TiendaVehiculo.usuario.admin.admin1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="arriba" runat="server">
                 
                 <div id="barraarriba">
                     <div id="Div1">
                         <ul>
                             <li><a href=""> Administrador Cliente </a></li>
                             <li><a href="/usuario/cliente/login.aspx">Identificarse </a></li>
                             <li><a href="/usuario/cliente/Registro.aspx">Registrarse </a></li>
                             <li><a href="/usuario/cliente/carrito.aspx">Carrito </a></li>
                             <li><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="Ir" /></li>
                             
                             

                         </ul>
                     </div>
                 </div>

                 <div id="top">
                     <div id="icono">
                         <h1><a href="/Default.aspx">
                             <img src="/imagenes/logo.png" style="width: 17%; height: auto; margin-left: 0.1%; margin-top:3%";/></a></h1>
                     </div>
                    </div>
                 <div id="barra">
                     <div id="secciones">
                         <ul>
                             <li><a href="/Articulos/Vehiculos/Coches/coches.aspx">Coches </a></li>
                             <li><a href="/Articulos/Vehiculos/Motos/motos.aspx">Motos </a></li>
                             <li><a href="/Articulos/Vehiculos/Caravanas/caravanas.aspx">Caravanas </a></li>
                             <li><a href="/Articulos/Vehiculos/Furgonetas/furgonetas.aspx">Furgonetas </a></li>
                             <li><a href="/Articulos/Vehiculos/Camiones/camiones.aspx">Camiones </a></li>
                             <li><a href="/Articulos/Accesorios/accesorios.aspx">Accesorios </a></li>
                         </ul>
                     </div>
                     <div id="buscar">
                     </div>
                 </div>

            
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="medio" runat="server">

    <h1> Administrar Productos </h1>

</asp:Content>
