<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormPago.aspx.vb" Inherits="TpPaginaVentasPC.FormPago" theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
            width: 621px;
            height: 69px;
        }
        .style4
        {
            width: 608px;
            height: 99px;
        }
        .style5
        {
            width: 683px;
        }
        .style6
        {
            width: 427px;
        }
        .style7
        {
            width: 427px;
            height: 69px;
        }
        .style8
        {
            height: 28px;
        }
        .style9
        {
            width: 621px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width:100%; height: 318px;" border="0">
            <tr>
                <td align="center" colspan="2" class="style8">
                    <asp:Label ID="Label1" runat="server" Text="REALIZAR PAGO"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style6" align="right">
                    <asp:Label ID="Label2" runat="server" Text="Monto a pagar:"></asp:Label>
                &nbsp;<asp:Label ID="lblMontoAPagar" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right" class="style6">
                    <asp:Label ID="Label4" runat="server" Text="Seleccione el metodo de pago"></asp:Label>
                    <br />
                    <asp:DropDownList ID="ddlTipoTarjeta" runat="server" Height="22px" 
                        style="margin-left: 0px" Width="220px">
                        
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="ddlTipoTarjeta" ErrorMessage="Seleccione una tarjeta" 
                        ForeColor="Red" Operator="NotEqual" ValidationGroup="g" 
                        ValueToCompare="---">*</asp:CompareValidator>
                </td>
                <td align="center" class="style9">
                    
                    <asp:Button ID="Button1" runat="server" Text="Nueva tarjeta" Height="36px" 
                        Width="140px" />
                    <br />
                </td>
            </tr>
            <tr>
                <td align="right" class="style7">
                    <asp:Button ID="btnRealizarCompra" runat="server" Text="Realizar compra" 
                        ValidationGroup="g" Height="37px" Width="163px" />
                </td>
                <td class="style3" align="center">
                    <asp:Button ID="btnVolveraLaTienda" runat="server" Text="Volver a la tienda" 
                        PostBackUrl="~/FormClientePrincipalF.aspx" Height="39px" Width="143px" />
                </td>
            </tr>
            <tr>
                <td align="center" class="style4" colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" ValidationGroup="g" />
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>
