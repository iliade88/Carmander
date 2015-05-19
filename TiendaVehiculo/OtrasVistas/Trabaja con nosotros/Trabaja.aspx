<%@ Page Title="" Language="C#" MasterPageFile="~/OtrasVistas/Trabaja con nosotros/Trabaja.master" AutoEventWireup="true" CodeBehind="Trabaja.aspx.cs" Inherits="TiendaVehiculo.OtrasVistas.Trabaja_con_nosotros.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="foldermedio" runat="server">
        <h2>Trabaja con nosotros</h2
    
    <div class="contact">
            <form id="contact_form" action="#" method="POST" enctype="multipart/form-data">
	        <div class="row">
		        Nombre completo<label for="name">:</label><br />
		        <input id="name" class="input" name="name" type="text" value="" size="30" /><br />
	        </div>
	        <div class="row">
		        Email<label for="email">:</label><br />
		        <input id="email" class="input" name="email" type="text" value="" size="30" /><br />
	        </div>
	        <div class="row">
		        <label for="message">¿Por qué quieres trabajar con nosotros?</label><br />
		        <textarea id="message" class="input" name="message" rows="7" cols="30"></textarea><br />
	        </div>
	        <div class="row">
		        Adjunta tu currículum:<br />
&nbsp;<asp:FileUpload ID="FileUpload1" runat="server" Height="22px" Width="234px" />
	        </div>
	            <br />
                <br />
	        <input id="submit_button" type="submit" value="Enviar solicitud" />
      </div>
</form>	
    
</asp:Content>