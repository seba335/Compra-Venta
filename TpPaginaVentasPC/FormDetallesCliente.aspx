<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FormDetallesCliente.aspx.vb" Inherits="TpPaginaVentasPC.FormDetallesCliente" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style1
        {
            width: 81px;
        }
        #Select1
        {
            width: 114px;
        }
        #Text4
        {
            width: 96px;
        }
        #Text5
        {
            width: 36px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 100%; height: 400px;">
            <tr>
                <td align="center" colspan="10">
                    <asp:Label ID="Label1" runat="server" Text="Detalles del cliente"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    Nombre:</td>
                <td class="style1" colspan="9">
                    <input id="Text8" type="text" /></td>
            </tr>
            <tr>
                <td>
                    Apellido:</td>
                <td class="style1" colspan="9">
                    <input id="Text7" type="text" /></td>
            </tr>
            <tr>
                <td>
                    Telefono:</td>
                <td class="style1" colspan="9">
                    <input id="Text6" type="text" /></td>
            </tr>
            <tr>
                <td>
                    E-Mail</td>
                <td class="style1" colspan="9">
                    <input id="Text1" type="text" /></td>
            </tr>
            <tr>
                <td>
                    Localidad:</td>
                <td class="style1">
                    <select id="Select1" name="D1">
                        <option></option>
                    </select></td>
                <td>
                    Calle:</td>
                <td>
                    <input id="Text2" type="text" /></td>
                <td>
                    Numero:</td>
                <td>
                    <input id="Text3" type="text" /></td>
                <td>
                    Departamento:</td>
                <td>
                    <input id="Text4" type="text" /></td>
                <td>
                    Piso:</td>
                <td>
                    <input id="Text5" type="text" /></td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style1">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <input id="Button1" type="button" value="Aceptar" /></td>
                <td>
                    &nbsp;</td>
                <td>
                    <input id="Button2" type="button" value="Cancelar" /></td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
