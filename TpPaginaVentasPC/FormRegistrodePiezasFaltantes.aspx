<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormRegistrodePiezasFaltantes.aspx.vb" Inherits="TpPaginaVentasPC.FormRegistrodePiezasFaltantes" 
theme="Skin1"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
            width: 107px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td align="center" colspan="3">
                    <asp:Label ID="Label1" runat="server" Text="Piezas"></asp:Label>
                </td>
            </tr>
            
        </table>
        <asp:GridView ID="GridView1" runat="server" Width="784px" SelectedRowStyle-BackColor = "Aquamarine" >
            <Columns>
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <table style="width:100%;">
            <tr>
                <td class="style3">
                    <asp:Label ID="Label2" runat="server" Text="Cantidad faltante"></asp:Label>
                    <br />
                    <asp:DropDownList ID="ddlCantidadFaltante" runat="server">
                        
                    </asp:DropDownList>
                </td>
                <td class="style3">
                    <asp:Button ID="btnFaltante" runat="server" Text="Agregar Faltante" />
                </td>
                <td class="style6" align="right">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="100px" 
                        ValidationGroup="g" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="100px" 
                        PostBackUrl="~/FormRegistrodePiezas.aspx" />
                </td>
            </tr>
            <tr>
                <td align ="center"  colspan ="3">
                    <asp:Label ID="Label3" runat="server" Text="Faltantes"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan ="3">
                    <asp:GridView ID="GridViewFaltante" runat="server" Width="780px">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </asp:Content>
