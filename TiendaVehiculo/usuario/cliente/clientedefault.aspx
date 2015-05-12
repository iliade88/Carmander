<%@ Page Title="" Language="C#" MasterPageFile="~/usuario/cliente/clientedefault.master" AutoEventWireup="true" CodeBehind="clientedefault.aspx.cs" Inherits="TiendaVehiculo.usuario.cliente.clientedefault1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="top" runat="server">
     <div id="identicar">
                    <a href="clientedefault.aspx">
                    <asp:Menu ID="Menu1" runat="server">
                        <Items>
                            <asp:MenuItem Text="Usuario" Value="Usuario">
                                <asp:MenuItem Text="Datos usuario" Value="Datos usuario"></asp:MenuItem>
                                <asp:MenuItem Text="Pedidos" Value="Pedidos"></asp:MenuItem>
                                <asp:MenuItem Text="Cerrar sesion" Value="Cerrar sesion"></asp:MenuItem>
                            </asp:MenuItem>
                        </Items>
                    </asp:Menu>
                    </a>
                </div>
                <div id="carrito">
                    <h3><a href="http://www.google.es">Carrrito 🏀</a></h3>
                </div>
                <div id="buscador">
                    <asp:TextBox ID="TextBox1" placeholder="Busca en la tienda" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="🔎"/>
                </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="medio" runat="server">
     <div id="ofertas">
            <div id="captioned-gallery">
	            <figure class="slider">
		            <figure>
			            <img src="imagenes\coche1.jpg">
			            <figcaption>Coche 1, OFERTON!</figcaption>
		            </figure>
		            <figure>
			            <img src="imagenes\coche2.jpg" alt>
			            <figcaption>Coche 2, SUPEROFERTA!</figcaption>
		            </figure>
                    <figure>
			            <img src="imagenes\coche1.jpg">
			            <figcaption>Coche 3, OFERTON!</figcaption>
		            </figure>
		            <figure>
			            <img src="imagenes\coche2.jpg" alt>
			            <figcaption>Coche 4, SUPEROFERTA!</figcaption>
		            </figure>
                    <figure>
			            <img src="imagenes\coche1.jpg">
			            <figcaption>Coche 1, OFERTON!</figcaption>
		            </figure>
	            </figure>
            </div>
        </div>
        
        <div id="cuadricula">
            <div class="oferta1">
                 <div class="imgoferta"><img src="imagenes/coche1.jpg" /></div>
                 <div class="descripoferta"><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris semper eros et ullamcorper lobortis. Mauris neque sem, egestas. </p></div>
             </div>
             <div class="oferta2">
                  <div class="imgoferta"><img src="imagenes/coche2.jpg" /></div>
                 <div class="descripoferta"><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris semper eros et ullamcorper lobortis. Mauris neque sem, egestas. </p></div>
             </div>
        </div>

</asp:Content>
