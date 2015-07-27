<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FormClientePrincipal.aspx.vb" Inherits="TpPaginaVentasPC.FormClientePrincipal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style6
        {
            height: 23px;
            width: 384px;
        }
        .style12
        {
            height: 23px;
            width: 131px;
        }
        .style5
        {
            height: 23px;
        }
        .style7
        {
            width: 160px;
        }
        #Button2
        {
            width: 169px;
            margin-left: 0px;
        }
        .style8
        {
            height: 84px;
            width: 108px;
        }
        .style16
        {
            height: 84px;
            width: 819px;
        }
        .style1
        {
            height: 84px;
        }
        .style9
        {
            height: 41px;
            width: 108px;
        }
        .style17
        {
            height: 41px;
            width: 819px;
        }
        .style4
        {
            height: 41px;
        }
        .style11
        {
            height: 61px;
            width: 108px;
        }
        .style18
        {
            height: 61px;
            width: 819px;
        }
        .style3
        {
            height: 61px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 100%; height: 49px;">
            <tr>
                <td align="right" bgcolor="Yellow" class="style6">
                    <img align="left" alt="" 
                        src="../Imagenes/logo%20pc%20planet%20verde.JPG" 
                        style="height: 65px; width: 87px; margin-top: 2px;" />:</td>
                <td bgcolor="Yellow" class="style12">
                    <asp:Label ID="Label1" runat="server" Text="Cuenta:"></asp:Label>
                    <asp:Label ID="Label2" runat="server" Text="Loguearse"></asp:Label>
                </td>
                <td bgcolor="Yellow" class="style5">
                    <asp:Label ID="Label3" runat="server" Text="Registrarse"></asp:Label>
                </td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="style7">
                    <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
                </td>
                <td align="right">
                    <asp:Button ID="btnListadeCompras" runat="server" Text="Lista de compras" />
                </td>
            </tr>
        </table>
        <table style="width: 100%; height: 626px;">
            <tr>
                <td class="style8">
                    &nbsp;</td>
                <td class="style16">
                    Modelo</td>
                <td align="center" class="style1">
                    Costo</td>
                <td align="center" class="style1">
                    Stock</td>
            </tr>
            <tr>
                <td class="style9">
                    <img alt="" dir="rtl" src="../Imagenes/pc-cpu-dell.jpg" 
                        style="height: 65px; width: 87px; margin-top: 2px;" /></td>
                <td class="style17">
                    Pc Cpu Dell Core 2 Duo E6300</td>
                <td align="center" class="style4">
                    1800</td>
                <td align="center" class="style4">
                    9</td>
            </tr>
            <tr>
                <td class="style11">
                    <img alt="" dir="rtl" 
                        src="../Imagenes/pc-cpu-intel-i5.jpg" 
                        style="height: 65px; width: 87px; margin-top: 2px;" /></td>
                <td class="style18">
                    Pc Cpu Intel I5 3ra Generación 3d Ivy Bridge</td>
                <td align="center" class="style3">
                    2200</td>
                <td align="center" class="style3">
                    15</td>
            </tr>
            <tr>
                <td class="style11">
                    <img alt="" src="../Imagenes/pc-ultra.jpg" 
                        style="height: 65px; width: 87px; margin-top: 2px;" /></td>
                <td class="style18">
                    Pc Ultra Mini Itx Fusion</td>
                <td align="center" class="style3">
                    2350</td>
                <td align="center" class="style3">
                    7</td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style18">
                </td>
                <td class="style3">
                </td>
                <td class="style3">
                </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style18">
                </td>
                <td class="style3">
                </td>
                <td class="style3">
                </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style18">
                </td>
                <td class="style3">
                </td>
                <td class="style3">
                </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style18">
                </td>
                <td class="style3">
                </td>
                <td class="style3">
                </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style18">
                </td>
                <td class="style3">
                </td>
                <td class="style3">
                </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style18">
                </td>
                <td class="style3">
                </td>
                <td class="style3">
                </td>
            </tr>
            <tr>
                <td class="style11">
                    &nbsp;</td>
                <td class="style18">
                </td>
                <td class="style3">
                </td>
                <td class="style3">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
