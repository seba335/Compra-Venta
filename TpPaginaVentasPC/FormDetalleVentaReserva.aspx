<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormDetalleVentaReserva.aspx.vb" Inherits="TpPaginaVentasPC.FormDetalleVentaReserva"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
            width: 183px;
        }
        .style5
        {
            width: 180px;
        }
        .style6
        {
            width: 98px;
        }
        .style7
        {
            width: 127px;
        }
        .style8
        {
            width: 137px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
   <table style="width: 100%; height: 364px;">
            <tr>
                <td class="style6">
                    Modelo:</td>
                <td class="style7">
                    <asp:Label ID="lblNombre" runat="server"></asp:Label>
                </td>
                <td class="style8">
                    </td>
            </tr>
            <tr>
                <td class="style6">
                    Procesador:</td>
                <td class="style7">
                    <asp:Label ID="lblProcesador" runat="server"></asp:Label>
                </td>
                <td class="style8">
                    </td>
            </tr>
            <tr>
                <td class="style6">
                    Placa de Video:</td>
                <td class="style7">
                    <asp:Label ID="lblPlacadeVideo" runat="server"></asp:Label>
                </td>
                <td class="style8">
                    </td>
            </tr>
            <tr>
                <td class="style6">
                    Disco:</td>
                <td class="style7">
                    <asp:Label ID="lblDisco" runat="server"></asp:Label>
                </td>
                <td class="style8">
                    Cantidad de disco:</td>
                <td class="style25">
                    <asp:Label ID="lblCantidadDisco" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    Fuente:</td>
                <td class="style7">
                    <asp:Label ID="lblFuente" runat="server"></asp:Label>
                </td>
                <td class="style8">
                    </td>
            </tr>
            <tr>
                <td class="style6">
                    Mother:</td>
                <td class="style7">
                    <asp:Label ID="lblMother" runat="server"></asp:Label>
                </td>
                <td class="style8">
                    </td>
            </tr>
            <tr>
                <td class="style6">
                    Memoria:</td>
                <td class="style7">
                    <asp:Label ID="lblMemoria" runat="server"></asp:Label>
                </td>
                <td class="style8">
                    Cantidad de memoria</td>
                <td class="style18">
                    <asp:Label ID="lblCantidadMemoria" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    Gabinete:</td>
                <td class="style7">
                    <asp:Label ID="lblGabinete" runat="server"></asp:Label>
                </td>
                <td class="style8">
                    </td>
            </tr>
            <tr>
                <td class="style6">
                    Lectora:</td>
                <td class="style7">
                    <asp:Label ID="lblLectora" runat="server"></asp:Label>
                </td>
                <td class="style8">
                    </td>
            </tr>
            <tr>
                <td class="style6">
                    Precio:</td>
                <td class="style7">
                    <asp:Label ID="lblPrecio" runat="server"></asp:Label>
                </td>
                <td class="style8">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td align ="center">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="251px" 
                        ValidationGroup="r" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td  colspan ="4">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
</asp:Content>