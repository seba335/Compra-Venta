<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormAdminPrncipal.aspx.vb" Inherits="TpPaginaVentasPC.FormAdminPrncipal"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
            height: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table border=1 align="center" style="width: 26%; height: 415px;">
            <tr>
                <td align="center" class="style3">
                    <asp:Label ID="Label1" runat="server" Text="Administración"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="btnEmpleados" runat="server" Text="Empleados" Width="281px" 
                        PostBackUrl="~/FormAdminEmpleados.aspx" />
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="btnModelos" runat="server" Text="Modelos" Width="281px" 
                        PostBackUrl="~/FormAdminModelos.aspx" />
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="btnPiezas" runat="server" Text="Piezas" Width="282px" 
                        PostBackUrl="~/FormAdminPiezas.aspx" />
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="btnZonas" runat="server" Text="Zonas" Width="281px" 
                        PostBackUrl="~/FormAdminZonas.aspx" />
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="btnLocalidades" runat="server" 
                        PostBackUrl="~/FormAdminLocalidades.aspx" Text="Localidades" Width="278px" />
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="Button3" runat="server" PostBackUrl="~/FormAdminArmado.aspx" 
                        Text="Armado" Width="279px" />
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>
