<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormPagoCompletarReserva.aspx.vb" Inherits="TpPaginaVentasPC.FormPagoCompletarReserva"
theme="Skin1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
    
        <table style="width:100%; height: 318px;">
            <tr>
                <td align="center" colspan="3">
                    <asp:Label ID="Label1" runat="server" Text="Realizar pago"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    <asp:Label ID="Label2" runat="server" Text="Monto a pagar:"></asp:Label>
                &nbsp;<asp:Label ID="lblMontoAPagar" runat="server"></asp:Label>
                </td>
                <td colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="center" colspan="3">
                    <asp:Label ID="Label3" runat="server" Text="Metodo de pago"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" class="style6">
                    <asp:Label ID="Label4" runat="server" Text="Seleccione el metodo de pago"></asp:Label>
                    <br />
                    <asp:DropDownList ID="ddlTipoTarjeta" runat="server">
                        
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="ddlTipoTarjeta" ErrorMessage="Seleccione una tarjeta" 
                        ForeColor="Red" Operator="NotEqual" ValidationGroup="g" 
                        ValueToCompare="---">*</asp:CompareValidator>
                </td>
                <td>
                    
                    <asp:Button ID="Button1" runat="server" Text="Nueva tarjeta" />
                    <br />
                </td>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td align="center" class="style4">
                </td>
                <td class="style3">
                    <asp:Button ID="btnRealizarCompra" runat="server" Text="Concluir reserva" 
                        ValidationGroup="g" Height="26px" />
                </td>
                <td class="style3">
                    <asp:Button ID="btnVolveraLaTienda" runat="server" Text="Volver a la tienda" 
                        PostBackUrl="~/FormClientePrincipalF.aspx" />
                </td>
            </tr>
            <tr>
                <td align="center" class="style4" colspan="3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" ValidationGroup="g" />
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>
