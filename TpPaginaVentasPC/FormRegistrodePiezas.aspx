<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormRegistrodePiezas.aspx.vb" Inherits="TpPaginaVentasPC.FormRegistrodePiezas"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="style10" colspan="6">
                    <asp:Label ID="Label1" runat="server" Text="Busqueda por proveedor"></asp:Label>
                    <br />
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
                    <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
                </td>
            </tr>
            
        </table>
        <asp:GridView ID="GridView1" runat="server" Width="779px">
            <Columns>
                <asp:CommandField ButtonType="Button" SelectText="Ver detalles" 
                    ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <table style="width:100%;">
            <tr>
                <td class="style6" align="center">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="77px" 
                        PostBackUrl="~/FormCompras.aspx" />
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>
