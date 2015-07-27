<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MaestraFaltantes.master" CodeBehind="FormArmadoFaltantes.aspx.vb" Inherits="TpPaginaVentasPC.FormArmadoFaltantes"
theme="Skin1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="master" runat="server">
    <asp:GridView ID="GridView1" runat="server" Width="392px" BackColor="White" 
        BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" 
        CellSpacing="1" GridLines="None">
        <Columns>
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
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
    <table style="width:100%;">
        <tr>
            <td style="width: 132px">
                <asp:DropDownList ID="ddlCantidadFaltante" runat="server">
                </asp:DropDownList>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToValidate="ddlCantidadFaltante" 
                    ErrorMessage="Seleccione la cantidad de piezas faltantes" ForeColor="Red" 
                    Operator="NotEqual" ValidationGroup="g" ValueToCompare="Seleccione">*</asp:CompareValidator>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Agregar faltante" Width="119px" 
                    ValidationGroup="g" />
            </td>
        </tr>
        <tr>
            <td style="width: 132px; height: 51px;">
            </td>
            <td style="height: 51px">
            </td>
        </tr>
        <tr>
            <td colspan ="2" align ="right" >
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="99px" />   
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
               </td>
        </tr>
        <tr>
            <td colspan ="2" align ="center" >
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                    ValidationGroup="g" />
               </td>
        </tr>
    </table>
</asp:Content>
