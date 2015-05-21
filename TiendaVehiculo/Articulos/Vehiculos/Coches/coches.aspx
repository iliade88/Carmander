<%@ Page Title="" Language="C#" MasterPageFile="~/Articulos/Vehiculos/vehiculosM.master" AutoEventWireup="true" CodeBehind="coches.aspx.cs" Inherits="TiendaVehiculo.Articulos.Vehiculos.Coches.coches" %>
<asp:Content ID="Content1" ContentPlaceHolderID="foldermedio" runat="server">
    <h2 style="margin-bottom: 6px">Listado de Coches Carmander</h2>
        
   <div id="cuadricula">
            
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Horizontal" Height="347px" Width="843px">
                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="descripcion" HeaderText="descripcion" SortExpression="descripcion" />
                    <asp:BoundField DataField="pvp" HeaderText="pvp" SortExpression="pvp" />
                    <asp:CheckBoxField DataField="disponible" HeaderText="disponible" SortExpression="disponible" />
                    <asp:ButtonField CommandName="Cancel" HeaderText="Detalle" ShowHeader="True" Text="Ver" ButtonType="Button" />
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

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [nombre], [descripcion], [pvp], [url_imagen], [disponible] FROM [VEHICULO] WHERE ([tipo] = @tipo)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="COCHE" Name="tipo" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>

        </div>

  
    <p style="margin-bottom: 6px">&nbsp;</p>
    <p style="margin-bottom: 6px">&nbsp;</p>
</asp:Content>
