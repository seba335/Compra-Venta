<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormListadeComprasaProv.aspx.vb" Inherits="TpPaginaVentasPC.FormListadeComprasaProv"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td align="center">
                    <asp:Label ID="Label1" runat="server" Text="Piezas a comprar"></asp:Label>
                </td>
            </tr>
            </table>

        <asp:GridView ID="GridView1" runat="server" Width="965px" BackColor="White" 
            BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" 
            CellSpacing="1" GridLines="None">
            <Columns>
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <SelectedRowStyle BackColor ="#9471DE" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
                </asp:GridView>
        <table style="width:100%;">
            <tr>

                <td align="center" class="style4">
                    <asp:DropDownList ID="ddlCantidad" runat="server">
                    </asp:DropDownList>
                    <asp:Button ID="btnAgregarALaCompra" runat="server" 
                        Text="Agregar a la compra" />
                    <asp:Button ID="btnSalir" runat="server" Text="Salir" Width="143px" 
                        PostBackUrl="~/FormCompras.aspx" />
                </td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
</asp:Content>
