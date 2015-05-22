<%@ Page Title="" Language="C#" MasterPageFile="~/OtrasVistas/Centro ayuda/CentroAyuda.master" AutoEventWireup="true" CodeBehind="CentroAyuda.aspx.cs" Inherits="TiendaVehiculo.OtrasVistas.Centro_ayuda.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="foldermedio" runat="server">
        <h2>Envíanos tu consulta</h2>
    
    <div class="contact">
            <form id="contact_form" action="#" method="POST" enctype="multipart/form-data">
	        <div class="row">
		        <label for="name">Nombre completo:<br />
                <input id="Text1" type="text" /></label><br 
		        <input id="name" class="input" name="name" type="text" value="" size="30" /><br />
	        </div


	        <div class="row">
		        <label for="email">Email:</label><br />
		        <input id="email" class="input" name="email" type="text" value="" size="30" /><br />
	        </div>
	        <div class="row">
		        ¿Por qué quieres trabajar con nosotros<label for="message">?:</label><br />
		        <textarea id="message" class="input" name="message" rows="7" cols="30"></textarea><br />
	        </div>
	        <input id="submit_button" type="submit" value="Enviar email" />
      </asp:Content>