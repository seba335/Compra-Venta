<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormArmadoPrincipal.aspx.vb" Inherits="TpPaginaVentasPC.FormArmadoPrincipal"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width: 100%;">
            <tr>
                <td align ="right" >
                    <asp:Button ID="btnFaltantes" runat="server" 
                        Text="Terminar orden por faltantes" />
                    &nbsp;
                </td>
            </tr>
            </table>
        <asp:GridView ID="GridView1" runat="server" Width="773px" BackColor="White" 
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
        <table style="width: 99%;">
            <tr>
                <td align="center" >
                    <asp:Label ID="Label2" runat="server" 
                        Text="No se dispone de trabajo por el momento" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" >
                    <asp:DropDownList ID="DropDownList1" runat="server" Visible="False">
                    </asp:DropDownList>
                    <asp:Button ID="BtnDetalles" runat="server" Text="Detalles" Width="227px" 
                        Visible="False" />
                    <asp:Button ID="btnTerminado" runat="server" Text="Terminado" Width="194px" 
                        Visible="False" />
                </td>
            </tr>
            </table>
    
    </div>
 </asp:Content>