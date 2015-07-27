<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FormPedidoporFaltante.aspx.vb" Inherits="TpPaginaVentasPC.FormPedidoporFaltante" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        .style5
        {
            width: 136px;
            height: 32px;
        }
        .style6
        {
            width: 411px;
            height: 32px;
        }
        
        .style1
        {
            width: 136px;
        }
        .style2
        {
            width: 411px;
        }
        .style4
        {
            width: 69px;
        }
        #Select2
        {
            width: 36px;
        }
        #Select1
        {
            width: 39px;
        }
        #Button1
        {
            width: 177px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td align="center">
                    <asp:Label ID="Label1" runat="server" Text="Indicar pieza/s dañada/s"></asp:Label>
                </td>
            </tr>
        </table>
        <table style="width: 100%; height: 364px;">
            <tr>
                <td class="style5">
                    <asp:Label ID="Label2" runat="server" Text="Modelo:"></asp:Label>
                </td>
                <td class="style6" colspan="3">
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:CheckBox ID="CheckBox10" runat="server" Text="Procesador" />
                </td>
                <td class="style2" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:CheckBox ID="CheckBox11" runat="server" Text="Placa de video" />
                </td>
                <td class="style2" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:CheckBox ID="CheckBox12" runat="server" Text="Disco" />
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="Label3" runat="server" Text="Cantidad:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCantidadDisco" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:CheckBox ID="CheckBox13" runat="server" Text="Fuente" />
                </td>
                <td class="style2" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:CheckBox ID="CheckBox14" runat="server" Text="Mother" />
                </td>
                <td class="style2" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:CheckBox ID="CheckBox15" runat="server" Text="Memoria" />
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="Label4" runat="server" Text="Cantidad:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCantidadMemoria" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:CheckBox ID="CheckBox16" runat="server" Text="Gabinete" />
                </td>
                <td class="style2" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:CheckBox ID="CheckBox17" runat="server" Text="Lectora" />
                </td>
                <td class="style2" colspan="3">
                    &nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td align="center">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="137px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
