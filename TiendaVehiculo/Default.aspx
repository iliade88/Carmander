﻿<%@ Page  Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TiendaVehiculo.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="foldermedio" runat="server">
    
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

 

 
    