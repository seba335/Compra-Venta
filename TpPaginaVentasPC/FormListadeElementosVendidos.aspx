<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FormListadeElementosVendidos.aspx.vb" Inherits="TpPaginaVentasPC.FormListadeElementosVendidos" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style6
        {
            width: 1452px;
        }
        .style5
        {
            width: 1335px;
        }
        .style4
        {
            width: 1325px;
        }
        .style3
        {
            width: 863px;
        }
        #Button8
        {
            width: 96px;
        }
        
        .style2
        {
            height: 22px;
            width: 95px;
        }
        .style1
        {
            height: 22px;
        }
        #Button7
        {
            width: 244px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 100%; height: 330px;">
            <tr>
                <td class="style6">
                    Modelo</td>
                <td class="style5">
                    Costo</td>
                <td class="style4">
                    Cantidad</td>
                <td class="style3">
                    Costo por cantidad</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style6">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    <input id="Button1" type="button" value="Ver detalle" /></td>
            </tr>
            <tr>
                <td class="style6">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    <input id="Button8" type="button" value="Ver detalle" /></td>
            </tr>
            <tr>
                <td class="style6">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style6">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style6">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style6">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <table style="width:100%; height: 113px;">
            <tr>
                <td class="style2">
                    <asp:Label ID="Label1" runat="server" Text="Costo total:"></asp:Label>
                </td>
                <td class="style1">
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="130px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
