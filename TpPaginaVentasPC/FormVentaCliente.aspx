<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FormVentaCliente.aspx.vb" Inherits="TpPaginaVentasPC.FormVentaCliente" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        #Select1
        {
            width: 135px;
        }
        .style1
        {
            width: 253px;
        }
        .style5
        {
            width: 400px;
        }
        .style4
        {
            width: 585px;
        }
        .style3
        {
            width: 848px;
        }
        .style2
        {
            width: 728px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td align="center" colspan="7">
                    <asp:Label ID="Label1" runat="server" Text="Seleccionar cliente a vender"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="left">
                    &nbsp;</td>
                <td align="left" colspan="6">
                    &nbsp;<asp:DropDownList 
                        ID="ddlCriteriodeBusqueda" runat="server">
                    </asp:DropDownList>
                    <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style1">
                    Numero de cliente</td>
                <td class="style5">
                    Nombre</td>
                <td class="style4">
                    Apellido</td>
                <td class="style3">
                    Telefono</td>
                <td class="style2">
                    Correo Electronico</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="center" class="style1">
                    <input id="Radio1" name="R1" type="radio" value="V1" /></td>
                <td class="style1">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <input id="Button1" type="button" value="Modificar" /></td>
            </tr>
            <tr>
                <td align="center" class="style1">
                    <input id="Radio2" name="R2" type="radio" value="V1" /></td>
                <td class="style1">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <input id="Button2" type="button" value="Modificar" /></td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td align="center">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="74px" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
