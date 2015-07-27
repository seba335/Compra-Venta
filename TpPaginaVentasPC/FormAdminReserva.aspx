<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FormAdminReserva.aspx.vb" Inherits="TpPaginaVentasPC.FormAdminReserva" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        .style14
        {
            width: 77px;
            height: 41px;
        }
        #Select2
        {
            width: 119px;
        }
        #Button2
        {
            width: 88px;
        }
        .style12
        {
            width: 175px;
            height: 25px;
        }
        .style17
        {
            height: 25px;
            width: 77px;
        }
        .style35
        {
            width: 122px;
            height: 25px;
        }
        .style31
        {
            height: 25px;
            width: 183px;
        }
        .style5
        {
            height: 25px;
        }
        .style7
        {
            height: 25px;
            width: 99px;
        }
        .style20
        {
            width: 175px;
            height: 30px;
        }
        .style21
        {
            width: 77px;
            height: 30px;
        }
        .style36
        {
            width: 122px;
            height: 30px;
        }
        .style32
        {
            height: 30px;
            width: 183px;
        }
        .style22
        {
            height: 30px;
        }
        .style27
        {
            height: 30px;
            width: 99px;
        }
        .style13
        {
            width: 175px;
            height: 58px;
        }
        .style16
        {
            width: 77px;
            height: 58px;
        }
        .style37
        {
            width: 122px;
            height: 58px;
        }
        .style33
        {
            height: 58px;
            width: 183px;
        }
        .style30
        {
            height: 58px;
        }
        .style28
        {
            width: 99px;
            height: 58px;
        }
        #Button3
        {
            width: 97px;
        }
        .style24
        {
            width: 175px;
            height: 32px;
        }
        .style25
        {
            width: 77px;
            height: 32px;
        }
        .style38
        {
            width: 122px;
            height: 32px;
        }
        .style34
        {
            height: 32px;
            width: 183px;
        }
        .style26
        {
            height: 32px;
        }
        .style29
        {
            height: 32px;
            width: 99px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:82%; height: 253px;">
            <tr>
                <td align="center" colspan="7">
                    <asp:Label ID="Label1" runat="server" Text="Reservas"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style14" colspan="1">
                    <asp:DropDownList ID="ddlCriteriodeBusqueda" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
                </td>
                <td class="style14">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
                </td>
            </tr>
            <tr>
                <td class="style12">
                    Numero de reserva</td>
                <td class="style17">
                    Fecha</td>
                <td class="style17">
                    Legajo empleado</td>
                <td class="style35">
                    Numero del cliente</td>
                <td class="style31">
                    Nombre y apellido del cliente</td>
                <td class="style5">
                    Estado</td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style20">
                </td>
                <td class="style21">
                </td>
                <td class="style21">
                </td>
                <td class="style36">
                </td>
                <td class="style32">
                </td>
                <td class="style22">
                    &nbsp;</td>
                <td class="style27">
                    <input id="Button1" type="button" value="Ver detalle" /></td>
            </tr>
            <tr>
                <td class="style13">
                </td>
                <td class="style16">
                </td>
                <td class="style16">
                </td>
                <td class="style37">
                </td>
                <td class="style33">
                </td>
                <td class="style30">
                </td>
                <td class="style28">
                    <input id="Button3" type="button" value="Ver detalle" /></td>
            </tr>
            <tr>
                <td class="style24">
                    &nbsp;</td>
                <td class="style25">
                </td>
                <td class="style25">
                </td>
                <td class="style38">
                </td>
                <td class="style34">
                </td>
                <td class="style26">
                </td>
                <td class="style29">
                </td>
            </tr>
            <tr>
                <td class="style24">
                    &nbsp;</td>
                <td class="style25">
                    &nbsp;</td>
                <td class="style25">
                    &nbsp;</td>
                <td class="style38">
                    &nbsp;</td>
                <td class="style34">
                    &nbsp;</td>
                <td class="style26">
                    &nbsp;</td>
                <td class="style29">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
