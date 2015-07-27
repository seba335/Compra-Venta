<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FormDetalleReserva.aspx.vb" Inherits="TpPaginaVentasPC.FormDetalleReserva" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">



        .style31
        {
            height: 34px;
            width: 77px;
        }
        .style20
        {
            width: 171px;
            height: 36px;
        }
        .style33
        {
            width: 77px;
            height: 36px;
        }
        .style50
        {
            width: 171px;
            height: 32px;
        }
        .style44
        {
            width: 131px;
            height: 32px;
        }
        #Select3
        {
            width: 157px;
        }
        .style49
        {
            width: 171px;
            height: 58px;
        }
        .style16
        {
            width: 77px;
            height: 58px;
        }
        #Button3
        {
            width: 135px;
        }
        .style13
        {
            width: 175px;
            height: 58px;
        }
        .style41
        {
            width: 191px;
            height: 32px;
        }
        .style26
        {
            height: 32px;
        }
        .style43
        {
            width: 13px;
            height: 32px;
        }
        .style39
        {
            width: 58px;
            height: 32px;
        }
        .style40
        {
            width: 61px;
        }
        .style45
        {
            width: 98px;
        }
        .style24
        {
            width: 175px;
            height: 32px;
        }
        #Button4
        {
            width: 154px;
        }
        #Button2
        {
            width: 88px;
        }
        .style51
        {
            width: 171px;
            height: 34px;
        }
        .style52
        {
            height: 28px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%; height: 253px; margin-bottom: 2px;">
            <tr>
                <td align="center" colspan="8" class="style52">
                    <asp:Label ID="Label1" runat="server" Text="Reserva"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style51">
                    <asp:Label ID="Label2" runat="server" Text="Numero de reserva"></asp:Label>
                </td>
                <td class="style31" colspan="7">
                </td>
            </tr>
            <tr>
                <td class="style20">
                    <asp:Label ID="Label3" runat="server" Text="Fecha"></asp:Label>
                </td>
                <td class="style33" colspan="7">
                </td>
            </tr>
            <tr>
                <td class="style50">
                    <asp:Label ID="Label4" runat="server" Text="Estado"></asp:Label>
                </td>
                <td class="style44" colspan="7">
                    <asp:DropDownList ID="ddlEstado" runat="server" Height="20px" Width="176px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style49">
                    <asp:Label ID="Label5" runat="server" Text="Legajo empleado"></asp:Label>
                </td>
                <td class="style16" colspan="7">
                </td>
            </tr>
            <tr>
                <td class="style49">
                    <asp:Label ID="Label6" runat="server" Text="Monto de pago por reserva"></asp:Label>
                </td>
                <td class="style16" colspan="7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style49">
                    <asp:Label ID="Label7" runat="server" Text="Monto total a pagar"></asp:Label>
                </td>
                <td class="style16" colspan="7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style49" colspan="8" align="center">
                    <asp:Button ID="btnModeloReservado" runat="server" Text="Modelo reservado" />
                </td>
            </tr>
            <tr>
                <td align="center" class="style13" colspan="8">
                    <asp:Label ID="Label8" runat="server" Text="Datos del cliente"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style50">
                    <asp:Label ID="Label9" runat="server" Text="Numero de cliente"></asp:Label>
                </td>
                <td class="style44">
                </td>
                <td class="style41" colspan="2">
                    <asp:Label ID="Label15" runat="server" Text="Nombre y apellido"></asp:Label>
                </td>
                <td class="style26" colspan="4">
                </td>
            </tr>
            <tr>
                <td class="style50">
                    <asp:Label ID="Label10" runat="server" Text="Telefono"></asp:Label>
                </td>
                <td class="style44" colspan="7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style50">
                    <asp:Label ID="Label11" runat="server" Text="Localidad"></asp:Label>
                </td>
                <td class="style44">
                    &nbsp;</td>
                <td class="style43">
                    <asp:Label ID="Label12" runat="server" Text="Calle"></asp:Label>
                </td>
                <td class="style43">
                    &nbsp;</td>
                <td class="style39">
                    <asp:Label ID="Label13" runat="server" Text="Numero"></asp:Label>
                </td>
                <td class="style40">
                </td>
                <td class="style45">
                    <asp:Label ID="Label14" runat="server" Text="Departamento"></asp:Label>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td align="center" class="style24" colspan="8">
                    <asp:Button ID="btnPagosRealizados" runat="server" Text="Pagos realizados" />
                </td>
            </tr>
            <tr>
                <td align="center"  colspan="8">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
