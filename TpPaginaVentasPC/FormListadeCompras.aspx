
<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormListadeCompras.aspx.vb" Inherits="TpPaginaVentasPC.FormListadeCompras" theme="Skin1" %>
<%@ MasterType VirtualPath="~/Logueo.Master"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
       
    <asp:GridView ID="GridView1" runat="server" Width="811px" BackColor="White" 
        BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" 
        CellSpacing="1" GridLines="None"  >
        <Columns>
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" 
                ShowHeader="True" >
        
            <ControlStyle BackColor="White" />
            <FooterStyle BackColor="White" />
            <HeaderStyle BackColor="#4A3C8C" />
            <ItemStyle BackColor="#DEDFDE" ForeColor="White" />
            </asp:CommandField>
        
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
    <asp:Button ID="Button1" runat="server" Text="Ver detalles" />
    <asp:Button ID="Button2"
        runat="server" Text="Eliminar" />
        <table style="width:100%; height: 113px;">
            <tr>
                <td class="style2">
                    Costo Total:<asp:Label 
                        ID="lblCosto" runat="server"></asp:Label>
                </td>
                <td class="style1">
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Button ID="Button9" runat="server" Text="Comprar" Width="291px" />
                </td>
                <td class="style1">
                    <asp:Button ID="Button10" runat="server" 
                        PostBackUrl="~/FormClientePrincipalF.aspx" Text="Volver a la tienda" 
                        Width="299px" />
                </td>
            </tr>
        </table>
    </asp:Content>
