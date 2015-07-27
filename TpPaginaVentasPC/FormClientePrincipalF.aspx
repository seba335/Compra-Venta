<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/NestedMasterPage1.master" CodeBehind="FormClientePrincipalF.aspx.vb" Inherits="TpPaginaVentasPC.FormClientePrincipalF" %>
<%@ MasterType VirtualPath="~/Logueo.Master"  %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID ="head" runat="server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="master" runat="server">
    <table style="width:100%;" bgcolor="#9999FF">
            <tr>
                <td class="style7" style="height: 30px">
                    <asp:Button ID="btnReserva" runat="server" Text="Ver reserva" Visible="False" />
                </td>
            </tr>
            <tr>
                <td class="style7">
                    <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
                </td>
            </tr>
        </table>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="Id" DataSourceID="SqlDataSource1" Width="300px" 
    Height="50px" BackColor="White" BorderColor="White" BorderStyle="Ridge" 
        BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" >
        <Columns>
            <asp:BoundField DataField="Id" Visible="False" />
            <asp:ImageField DataImageUrlField="Imagen">
            </asp:ImageField>
            <asp:BoundField DataField="Nombre" HeaderText="Modelo" 
                SortExpression="Nombre" />
            <asp:BoundField DataField="StockCapacidad" HeaderText="Stock" 
                SortExpression="StockCapacidad" />
            <asp:BoundField DataField="Costo" HeaderText="Precio" SortExpression="Costo" />
            <asp:CommandField ButtonType="Button" SelectText="Ver detalle" 
                ShowSelectButton="True" />
        </Columns>
        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#594B9C" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#33276A" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$  ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
        SelectCommand="SELECT * FROM [Modelos] WHERE ([Activo] = @Activo)">
        <SelectParameters>
            <asp:Parameter DefaultValue="True" Name="Activo" Type="Boolean" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
        SelectCommand="SELECT * FROM [Modelos] WHERE ([Nombre] LIKE '%' + @Nombre + '%')">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtBuscar" Name="Nombre" PropertyName="Text" 
                Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
