<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormEnvio.aspx.vb" Inherits="TpPaginaVentasPC.FormEnvio"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style5
        {
            width: 4953px;
        }
        .style6
        {
            width: 4952px;
        }
        .style7
        {
            width: 4950px;
        }
        .style12
        {
            width: 302px;
            height: 160px;
        }
        .style17
        {
            width: 1923px;
            height: 48px;
        }
        .style18
        {
            height: 76px;
        }
        .style19
        {
            height: 48px;
        }
        .style21
        {
            width: 302px;
            height: 44px;
        }
        .style22
        {
            width: 1923px;
            height: 44px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table align="center" style="width: 99%; height: 337px;">
            <tr>
                <td align="center" class="style6">
                    <span>
                    <asp:Label ID="Label1" runat="server" Text="Envio"></asp:Label>
                    </span>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp;<asp:Label ID="Label12" runat="server" 
                        Text="Los envios seran entregados en el transcurso de las siguientes 2 semanas a la compra"></asp:Label>
                    <table 
                        style="width: 100%;">
                        <tr>
                            <td class="style21">
                                <asp:RadioButton ID="rbConEnvio" runat="server" GroupName="g" />
                            </td>
                            <td class="style22">
                                <asp:Label ID="Label10" runat="server" Text="Prefiero que me envien el pedido"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style19">
                                <asp:RadioButton ID="rbSinEnvio" runat="server"  GroupName="g" Checked="True" />
                            </td>
                            <td class="style17">
                                <asp:Label ID="Label11" runat="server" Text="Prefiero retirarlo yo mismo"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" class="style18" colspan="2">
                                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="149px" />
                                <asp:Button ID="btnVolveraLaTienda" runat="server" Text="Volver a la tienda" 
                                    PostBackUrl="~/FormClientePrincipalF.aspx" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>
