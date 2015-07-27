<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormReserva.aspx.vb" Inherits="TpPaginaVentasPC.FormReserva"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width: 100%; height: 50px; margin-bottom: 0px;">
            <tr>
                <td class="style2">
                    <asp:Label ID="Label1" runat="server" Text="Modelo:"></asp:Label>
                    <asp:Label ID="lblModelo" runat="server"></asp:Label>
                </td>
                <td >
                    <asp:Label ID="Label2" runat="server" Text="Costo de reserva:"></asp:Label>
                    <asp:Label ID="lblCostoReserva" runat="server"></asp:Label>
                </td>
                <td >
                    <asp:Label ID="Label3" runat="server" Text="Costo total:"></asp:Label>
                    <asp:Label ID="lblCostoTotal" runat="server"></asp:Label>
                </td>
            </tr>
            </table>
    <table style="width:100%;">
        <tr>
            <td  align ="center" >
                    <asp:Button ID="btnReservar" runat="server" Text="Reservar" Width="148px" />
                    <asp:Button ID="btnVolveraLaTienda" runat="server" Text="Volver a la tienda" 
                        Width="150px" PostBackUrl="~/FormClientePrincipalF.aspx" />
                </td>
        </tr>
    </table>
    </div>
</asp:Content>