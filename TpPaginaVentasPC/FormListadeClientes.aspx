<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormListadeClientes.aspx.vb" Inherits="TpPaginaVentasPC.FormListadeClientes"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td align="center" colspan="6">
                    <asp:Label ID="Label1" runat="server" Text="Clientes"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="left" colspan="6">
                    &nbsp;<asp:TextBox ID="txtBusqueda" runat="server" Height="22px"></asp:TextBox>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
                    <asp:Button ID="btnNuevoCliente" runat="server" 
                        PostBackUrl="~/FormClienteRegPorEmpleado.aspx" Text="Nuevo cliente" />
                </td>
            </tr>
            
        </table>
        <asp:GridView ID="GridView1" runat="server" Width="755px" 
            AutoGenerateColumns="False" DataKeyNames="Numero de cliente" 
            DataSourceID="SqlDataSource1" SelectedRowStyle-BackColor="Aquamarine" 
            BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" 
            CellPadding="3" CellSpacing="1" GridLines="None">
            <Columns>
                <asp:CommandField ButtonType="Button" 
                    ShowSelectButton="True" />
                <asp:BoundField DataField="Numero de cliente" HeaderText="Numero de cliente" 
                    SortExpression="Numero de cliente" />
                <asp:BoundField DataField="Nombre y Apellido" HeaderText="Nombre y Apellido" 
                    ReadOnly="True" SortExpression="Nombre y Apellido" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" 
                    SortExpression="Telefono" />
                <asp:BoundField DataField="Calle" HeaderText="Calle" SortExpression="Calle" />
                <asp:BoundField DataField="Numero" HeaderText="Numero" 
                    SortExpression="Numero" />
                <asp:BoundField DataField="Piso" HeaderText="Piso" SortExpression="Piso" />
                <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                    SortExpression="Departamento" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Localidad" HeaderText="Localidad" 
                    SortExpression="Localidad" />
            </Columns>
        
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />

<SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White"></SelectedRowStyle>
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" SelectCommand="SELECT Clientes.NumeroCliente as 'Numero de cliente',Clientes.Nombre+' '+Clientes.Apellido as 'Nombre y Apellido',Clientes.Telefono,
	Clientes.Calle,Clientes.Numero,Clientes.Piso,
	Clientes.Departamento,Clientes.Email,Localidad.Nombre as 'Localidad'
	from Clientes,Localidad
	where  Clientes.IdLocalidad = Localidad.Id"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
            SelectCommand="BuscarClientePorNombre" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtBusqueda" Name="NombreCliente" 
                    PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <table style="width:100%;">

            <tr>
                <td align="center">
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" Width="113px" />
                </td>
            </tr>

            <tr>
                <td align="center">
                    <asp:Button ID="btnVenta" runat="server" style="margin-bottom: 0px" 
                        Text="Realizar venta" />
                    <asp:Button ID="btnAceptar" runat="server" Text="Cancelar" 
                        PostBackUrl="~/FormClientePrincipalF.aspx" Width="116px" />
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>
