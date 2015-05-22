<%@ Page Title="" Language="C#" MasterPageFile="~/usuario/cliente/clientedefault.master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TiendaVehiculo.usuario.cliente.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="medio" runat="server">
    
    <!-- Formulario de Login de Usuario -->
            
             <h2>
             Iniciar sesión
            </h2>
            <p>
                Especifique su nombre de usuario y contraseña.
            <asp:HyperLink ID="RegisterHyperLink" runat="server" EnableViewState="false">Registrarse</asp:HyperLink> si no tiene una cuenta.
            </p>
        
        <table>
           
            <tr>
                <td>
                    Introduce tu DNI: 
                </td>
                <td>
                    <asp:TextBox ID="TextBoxLoginID" runat="server"></asp:TextBox>
                </td>
                <td>
                    
                </td>
            </tr>
            <tr>
                <td>
                    Introduce tu contraseña: 
                </td>
                <td>
                    <asp:TextBox ID="TextBoxPassID" TextMode="Password" runat="server"></asp:TextBox>
                </td>
                <td>
                    
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="ButtonLoginID" runat="server" Text="Inicia sessió" OnClick="ButtonLogin_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="LabelErrorLoginID" runat="server" Visible="false" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    

</asp:Content>
