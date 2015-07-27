<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FormRegistroPagos.aspx.vb" Inherits="TpPaginaVentasPC.FormRegistroPagos" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style1
        {
            height: 23px;
        }
        .style6
        {
            height: 22px;
            width: 238px;
        }
        .style2
        {
            height: 22px;
        }
        .style4
        {
            height: 22px;
            width: 199px;
        }
        .style7
        {
            width: 238px;
        }
        .style5
        {
            width: 199px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td align="center" class="style1" colspan="4">
                    <asp:Label ID="Label1" runat="server" Text="Pagos registrados"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    Numero de Pago</td>
                <td class="style2">
                    Monto</td>
                <td class="style4">
                    Fecha</td>
                <td class="style2">
                    Tipo</td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td>
                    &nbsp;</td>
                <td align="center">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
