<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormRegistrodePiezasDetalle.aspx.vb" Inherits="TpPaginaVentasPC.FormRegistrodePiezasDetalle"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
        <asp:GridView ID="GridView1" runat="server" Width="784px">
        </asp:GridView>
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Estado de la compra"></asp:Label>
                    <br />
                    <asp:DropDownList ID="ddlEstado" runat="server">
                        <asp:ListItem Value="---">Seleccionar</asp:ListItem>
                        <asp:ListItem>Completado</asp:ListItem>
                        <asp:ListItem>Completado Con Faltantes</asp:ListItem>
                        <asp:ListItem>Cancelado</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="ddlEstado" ErrorMessage="Seleccione el estado de la compra" 
                        ForeColor="Red" Operator="NotEqual" ValueToCompare="---" 
                        ValidationGroup="g">*</asp:CompareValidator>
                </td>
                <td class="style6" align="right">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="100px" 
                        ValidationGroup="g" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="100px" 
                        PostBackUrl="~/FormRegistrodePiezas.aspx" />
                </td>
            </tr>
            <tr>
                <td colspan ="2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" ValidationGroup="g" />
                </td>
            </tr>
        </table>
    
    </div>
    </asp:Content>
