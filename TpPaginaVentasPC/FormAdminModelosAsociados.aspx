<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FormAdminModelosAsociados.aspx.vb" Inherits="TpPaginaVentasPC.FormAdminModelosAsociados" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        .style2
        {
            width: 203px;
            height: 46px;
        }
        .style3
        {
            height: 46px;
        }
        .style1
        {
            width: 203px;
        }
        #Select2
        {
            width: 49px;
        }
        #Select1
        {
            width: 47px;
        }
        #Button1
        {
            width: 118px;
        }
        #Select3
        {
            width: 51px;
        }
        #Select4
        {
            width: 45px;
        }
        #Button2
        {
            width: 119px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 100%; height: 169px;">
            <tr>
                <td class="style2">
                    Nombre</td>
                <td class="style2">
                    Stock</td>
                <td class="style2">
                    Stock sin armar</td>
                <td class="style2">
                    Precio a la venta</td>
                <td class="style3">
                    Mínimo</td>
                <td class="style3">
                    Máximo</td>
                <td class="style3">
                    Activo</td>
                <td class="style3">
                </td>
                <td class="style3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style1">
                    &nbsp;</td>
                <td class="style1">
                    &nbsp;</td>
                <td class="style1">
                    <input id="Text1" type="text" /></td>
                <td>
                    <select id="Select2" name="D2">
                        <option></option>
                    </select></td>
                <td>
                    <select id="Select1" name="D1">
                        <option></option>
                    </select></td>
                <td>
                    <input id="Checkbox1" checked="checked" type="checkbox" /></td>
                <td>
                    <input id="Button1" type="button" value="Cambiar estado" /></td>
                <td>
                    <input id="Button6" type="button" value="Ver detalle" /></td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style1">
                    &nbsp;</td>
                <td class="style1">
                    &nbsp;</td>
                <td class="style1">
                    <input id="Text2" type="text" /></td>
                <td>
                    <select id="Select3" name="D3">
                        <option></option>
                    </select></td>
                <td>
                    <select id="Select4" name="D4">
                        <option></option>
                    </select></td>
                <td>
                    <input id="Checkbox2" checked="checked" type="checkbox" /></td>
                <td>
                    <input id="Button2" type="button" value="Cambiar estado" /></td>
                <td>
                    <input id="Button7" type="button" value="Ver detalle" /></td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td>
                    &nbsp;</td>
                <td align="center">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
