<%@ Page Title="" Language="C#" MasterPageFile="~/OtrasVistas/Contacta/Cantactamaster.master" AutoEventWireup="true" CodeBehind="contacta.aspx.cs" Inherits="TiendaVehiculo.OtrasVistas.Contacta.contacta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="foldermedio" runat="server">
        <h2>Formulario de Contacto</h2>
    
    <div class="contact">
            <form id="contact_form" action="#" method="POST" enctype="multipart/form-data">
	        <div class="row">
		        <label for="name">Tu nombre:</label><br />
		        <input id="name" class="input" name="name" type="text" value="" size="30" /><br />
	        </div>
	        <div class="row">
		        <label for="email">Tu email:</label><br />
		        <input id="email" class="input" name="email" type="text" value="" size="30" /><br />
	        </div>
	        <div class="row">
		        <label for="message">Tu mensaje:</label><br />
		        <textarea id="message" class="input" name="message" rows="7" cols="30"></textarea><br />
	        </div>
	        <input id="submit_button" type="submit" value="Enviar email" />
      </div>
</form>	
</asp:Content>
