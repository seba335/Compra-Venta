<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormLogueo.aspx.vb" Inherits="TpPaginaVentasPC.FormLogueo"
 Theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
            width: 127px;
        }
        .style4
        {
            width: 127px;
            height: 67px;
        }
        .style5
        {
            width: 532px;
            height: 154px;
        }
        .style6
        {
            width: 532px;
            height: 67px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div >
    
        <table style="width: 100%; height: 474px;" bgcolor="#9999FF">
            <tr>
                <td class="style1" align="center" colspan="2">
                    <asp:Label ID="lbError" runat="server" 
                        Text="*Error ha ingresado un usuario y/o contraseña incorrecta" ForeColor="Red" 
                        Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtUsuario" ErrorMessage="Debe ingresar un usuario" 
                        ForeColor="Red" ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtContraseña" ErrorMessage="Ingrese contraseña" 
                        ForeColor="Red" ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" Width="84px" 
                        ValidationGroup="g" BackColor="#6666FF" />
                    </td>
                <td>
                    <asp:Button ID="btnSalir" runat="server" Text="Salir" Width="84px" 
                        PostBackUrl="~/FormClientePrincipalF.aspx" />
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2" bgcolor="#9999FF">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="center" colspan="2" bgcolor="#9999FF">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" ValidationGroup="g" />
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2" bgcolor="#9999FF">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
</asp:Content>