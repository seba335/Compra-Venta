<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormAdminAltaLocalidad.aspx.vb" Inherits="TpPaginaVentasPC.FormAdminAltaLocalidad"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .style1
        {
            width: 78px;
            height: 26px;
        }
        .style2
        {
            height: 26px;
            }
        .style3
        {
            width: 22px;
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width:46%; height: 236px;" border="1">
            <tr>
                <td align="center" colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Agregar localidad"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator 
                        ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" 
                        ErrorMessage="ingrese nombre" ForeColor="Red" ValidationGroup="g">*</asp:RequiredFieldValidator>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    Zona&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="ddZonas" runat="server" Height="16px" Width="83px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" ValidationGroup="g" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
                        PostBackUrl="~/FormAdminLocalidades.aspx" />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        HeaderText="Lista de errores" ValidationGroup="g" Width="540px" />
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>