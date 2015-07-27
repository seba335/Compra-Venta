<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormAdminPiezas.aspx.vb" Inherits="TpPaginaVentasPC.FormAdminPiezas" 
theme="Skin1"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .style1
        {
            height: 23px;
        }
        .style4
        {
            width: 2441px;
        }
        .style8
        {
            width: 5390px;
        }
        .style7
        {
            width: 5140px;
        }
        .style6
        {
            width: 5638px;
        }
        .style2
        {
            width: 742px;
        }
        #Button3
        {
            width: 94px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td align="center" class="style1">
                    <asp:Label ID="Label2" runat="server" Text="Piezas"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" class="style1">
                    <asp:Label ID="Label1" runat="server" Text="Busqueda por descripción"></asp:Label>
                    <br />
                    <asp:Button ID="btnTodo" runat="server" style="margin-left: 0px" Text="Todo" 
                        Width="46px" />
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
                    <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
                </td>
            </tr>
            </table>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="Id" DataSourceID="SqlDataSource1" Width="811px" 
            BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" 
            CellPadding="3" CellSpacing="1" GridLines="None">
            <Columns>
                <asp:BoundField DataField="Tipo" HeaderText="Tipo" SortExpression="Tipo" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" 
                    SortExpression="Descripcion" />
                <asp:BoundField DataField="Costo" HeaderText="Precio" SortExpression="Costo" />
                <asp:BoundField DataField="Stock" HeaderText="Stock" SortExpression="Stock" />
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
            SelectCommand="SELECT * FROM [Piezas]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
            SelectCommand="SELECT * FROM [Piezas] WHERE ([Descripcion] LIKE '%' + @Descripcion + '%')">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtBuscar" Name="Descripcion" 
                    PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <table style="width:100%;">
            <tr>
                <td>
                    &nbsp;</td>
                <td align="center">
                    <asp:Button ID="btnNuevaPieza" runat="server" Text="Nueva pieza" 
                        PostBackUrl="~/FormAdminAltaPiezas.aspx" />
                    <asp:Button ID="btnSalir" runat="server" Text="Salir" Width="100px" 
                        PostBackUrl="~/FormAdminPrncipal.aspx" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
</asp:Content>
