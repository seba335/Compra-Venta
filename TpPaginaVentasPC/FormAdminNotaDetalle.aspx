<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FormAdminNotaDetalle.aspx.vb" Inherits="TpPaginaVentasPC.FormAdminNotaDetalle" %>

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
            height: 56px;
        }
        #Text1
        {
            height: 259px;
            width: 1191px;
        }
        #Button3
        {
            width: 130px;
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Pieza"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="Label3" runat="server" Text="Detalle"></asp:Label>
                </td>
                <td class="style1">
                    <asp:Label ID="Label4" runat="server" Text="Cantidad faltante de compra"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="style6">
                    <asp:Label ID="Label1" runat="server" Text="Nota"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    <asp:TextBox ID="txtNota" runat="server" Height="154px" Width="1195px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style6" align="center">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
