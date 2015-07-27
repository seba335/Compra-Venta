<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormCompras.aspx.vb" Inherits="TpPaginaVentasPC.FormCompras" 
theme="Skin1"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width:100%; ">
            <tr>
                <td align="center">
                    <asp:Label ID="Label1" runat="server" Text="Compras"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="btnListadeCompras" runat="server" Text="Lista de compras" 
                        Width="276px" PostBackUrl="~/FormListadeComprasaProv.aspx" />
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="btnRegistrodeLlegada" runat="server" 
                        Text="Registro de llegada de compras" 
                        PostBackUrl="~/FormRegistrodePiezas.aspx" Width="288px" />
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>
