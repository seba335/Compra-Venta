<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FormAdminNotas.aspx.vb" Inherits="TpPaginaVentasPC.FormAdminNotas" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style3
        {
            width: 493px;
        }
        .style2
        {
            width: 759px;
        }
        .style1
        {
            width: 644px;
        }
        #Button3
        {
            width: 114px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 99%; height: 242px;">
            <tr>
                <td class="style3">
                    Vista</td>
                <td class="style2">
                    Fecha</td>
                <td class="style1">
                    Empleado</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    <input id="Checkbox1" type="checkbox" /></td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style1">
                    &nbsp;</td>
                <td>
                    <input id="Button1" type="button" value="Ver nota" /></td>
            </tr>
            <tr>
                <td class="style3">
                    <input id="Checkbox2" type="checkbox" /></td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style1">
                    &nbsp;</td>
                <td>
                    <input id="Button2" type="button" value="Ver nota" /></td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td align="center">
                    <asp:Button ID="btnVolver" runat="server" Text="Volver" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
