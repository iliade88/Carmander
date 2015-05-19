<%@ Page  Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TiendaVehiculo.Default" %>

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
            
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="codigo" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Horizontal" Height="347px" Width="843px">
                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="pvp" HeaderText="pvp" SortExpression="pvp" />
                    <asp:BoundField DataField="descripcion" HeaderText="descripcion" SortExpression="descripcion" />
                    <asp:CheckBoxField DataField="disponible" HeaderText="disponible" SortExpression="disponible" />
                    <asp:ImageField DataImageUrlField="url_imagen">
                    </asp:ImageField>
                    <asp:HyperLinkField DataNavigateUrlFields="codigo" DataNavigateUrlFormatString="\Articulos\Vehiculos\vehiculos.aspx?id={0}" Text="Ver" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [url_imagen], [nombre], [pvp], [descripcion], [disponible], [codigo] FROM [VEHICULO]"></asp:SqlDataSource>

        </div>

  
</asp:Content>

 

 
    