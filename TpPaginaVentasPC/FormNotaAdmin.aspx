<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FormNotaAdmin.aspx.vb" Inherits="TpPaginaVentasPC.FormNotaAdmin" %>

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
        #Button2
        {
            width: 134px;
            margin-bottom: 0px;
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
                <td align="center" colspan="2">
                    <asp:Label ID="Label2" runat="server" Text="Piezas"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Detalle</td>
                <td class="style1">
                    Cantidad a comprar</td>
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
                    <asp:Label ID="Label1" runat="server" 
                        Text="Nota indicar periodo en el cual no se podrá obtener las piezas y detallar la razon de la falta de disponibilidad"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    <asp:TextBox ID="TextBox1" runat="server" Height="162px" Width="1190px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style6" align="center">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="110px" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="109px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
