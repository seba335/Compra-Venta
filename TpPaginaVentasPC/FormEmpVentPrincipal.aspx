<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormEmpVentPrincipal.aspx.vb" Inherits="TpPaginaVentasPC.FormEmpVentPrincipal"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
            height: 55px;
            width: 289px;
        }
        .style5
        {
            width: 256px;
        }
        .style9
        {
            width: 289px;
            height: 102px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 242px; width: 194px; margin-left: 519px">
    
        <table style="width: 180%; height: 366px;" border="1">
            <tr>
                <td align="center" class="style3">
                    <asp:Label ID="Label1" runat="server" Text="Venta principal"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" class="style9">
                    <asp:Button ID="btnRealizarVenta" runat="server" Text="Realizar venta" 
                        Width="202px" PostBackUrl="~/FormClientePrincipalF.aspx" Height="46px" />
                </td>
            </tr>
            <tr>
                <td align="center" class="style9">
                    <asp:Button ID="btnRegistrodeVentas" runat="server" Text="Registro de ventas" 
                        Width="205px" PostBackUrl="~/FormVentas.aspx" Height="42px" />
                </td>
            </tr>
            <tr>
                <td align="center" class="style9">
                    <asp:Button ID="BtnReservas" runat="server" Height="42px" 
                        PostBackUrl="~/FormListadeReservas.aspx" Text="Reservas" Width="205px" />
                </td>
            </tr>
            </table>
    
    </div>
</asp:Content>
