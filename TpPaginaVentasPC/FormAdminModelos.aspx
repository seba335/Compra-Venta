<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormAdminModelos.aspx.vb" Inherits="TpPaginaVentasPC.FormAdminModelos"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width: 100%; height: 185px; margin-top: 0px;">
            <tr>
                <td  colspan ="2" align ="center" >
                    <asp:Label ID="Label1" runat="server" Text="Modelos"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnNuevoModelo" runat="server" Text="Nuevo modelo" 
                        PostBackUrl="~/FormAdminAltaModelo.aspx" />
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Busqueda por nombre"></asp:Label>
                    <br />
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
&nbsp;<asp:TextBox ID="txtBusqueda" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="Id" DataSourceID="SqlDataSource1" Width="814px" 
            BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" 
            CellPadding="3" CellSpacing="1" GridLines="None">
            <Columns>
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                <asp:CheckBoxField DataField="Activo" HeaderText="Activo" 
                    SortExpression="Activo" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                    SortExpression="Nombre" />
                <asp:BoundField DataField="StockCapacidad" HeaderText="Stock" 
                    SortExpression="StockCapacidad" />
                <asp:BoundField DataField="Costo" HeaderText="Precio" SortExpression="Costo" />
                <asp:ImageField DataImageUrlField="Imagen">
                </asp:ImageField>
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
            ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
            SelectCommand="SELECT * FROM [Modelos] ORDER BY [Activo] DESC, [Nombre]">
        </asp:SqlDataSource>


        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
            SelectCommand="SELECT * FROM [Modelos] WHERE ([Nombre] LIKE '%' + @Nombre + '%')">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtBusqueda" Name="Nombre" PropertyName="Text" 
                    Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>


        <asp:Button ID="BtnDetalles" runat="server" Text="Ver Detalles" />
        <asp:Button ID="BtnModificar" runat="server" Text="Modificar Modelo" />


        <table style="width:100%;">
            <tr>
                <td>
                    &nbsp;</td>
                <td align="center">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" 
                        PostBackUrl="~/FormAdminPrncipal.aspx" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
 </asp:Content>
