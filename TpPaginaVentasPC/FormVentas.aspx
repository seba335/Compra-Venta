<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormVentas.aspx.vb" Inherits="TpPaginaVentasPC.FormVentas" 
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width:100%; height: 475px;">
            <tr>
                <td align="center" bgcolor="#9999FF">
                    <asp:GridView ID="GridView1" runat="server" Height="129px" Width="776px" 
                        DataKeyNames ="Numero de venta" BackColor="White" BorderColor="White" 
                        BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" 
                        GridLines="None">
                        <Columns>
                            <asp:CommandField ButtonType="Button" SelectText="Detalles" 
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
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="116px" 
                        PostBackUrl="~/FormEmpVentPrincipal.aspx" />
                </td>
            </tr>
        </table>
    
    </div>
  </asp:Content>