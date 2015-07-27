<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormAltaTarjeta.aspx.vb" Inherits="TpPaginaVentasPC.FormAltaTarjeta"
theme="Skin1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
            width: 274px;
        }
        .style4
        {
            width: 270px;
        }
        .style5
        {
            width: 269px;
        }
        .style6
        {
            width: 265px;
        }
        .style7
        {
            width: 216px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table style="width:100%; height: 127px;">
            <tr>
                <td align="center" colspan="3">
                    <asp:Label ID="Label3" runat="server" Text="Metodo de pago"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" class="style6">
                    <asp:Label ID="Label4" runat="server" Text="Tipo de tarjeta"></asp:Label>
                    <br />
                    <asp:DropDownList ID="ddlTipoTarjeta" runat="server">
                        <asp:ListItem Value="---">Seleccionar</asp:ListItem>
                        <asp:ListItem>Visa</asp:ListItem>
                        <asp:ListItem>Master Card</asp:ListItem>
                        <asp:ListItem>American</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="ddlTipoTarjeta" ErrorMessage="Seleccione el tipo de pago" 
                        ForeColor="Red" Operator="NotEqual" ValidationGroup="g" ValueToCompare="---">*</asp:CompareValidator>
                </td>
                <td class="style7">
                    <asp:Label ID="Label7" runat="server" Text="Numero de tarjeta"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtNumero" ErrorMessage="ingrese numero de tarjeta" 
                        ForeColor="Red" ValidationGroup="g">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator7" runat="server" 
                        ControlToValidate="txtNumero" ErrorMessage="el numero de la tarjeta  en numeros!" 
                        ForeColor="Red" Operator="DataTypeCheck" Type="Double" ValidationGroup="g">*</asp:CompareValidator>
                    <asp:RangeValidator ID="telrangevalidator" runat="server" BackColor="White" 
                        ControlToValidate="txtNumero" Display="Dynamic" 
                        ErrorMessage="el numero de tarjeta tiene que tener 16 numeros" ForeColor="Red" 
                        MinimumValue="1111111111111111" MaximumValue="9999999999999999" Text="*" Type="Double" 
                        ValidationGroup="g" ></asp:RangeValidator>
                </td>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Codigo de seguridad"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtCodigo" runat="server" Width="47px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ErrorMessage="ingrese el codigo de seguridad" ForeColor="Red" 
                        ValidationGroup="g" ControlToValidate="txtCodigo">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="center" class="style6">
                    <asp:Label ID="Label5" runat="server" Text="Nombre"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtNombre" ErrorMessage="ingrese nombre" ForeColor="Red" 
                        ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
                <td class="style7">
                    <asp:Label ID="Label6" runat="server" Text="Apellido"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtApellido" ErrorMessage="ingrese apellido" ForeColor="Red" 
                        ValidationGroup="g">*</asp:RequiredFieldValidator>
                    <br />
                   
                    
                </td>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Fecha de caducidad"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtFecha" runat="server" TextMode="Date" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtFecha" ErrorMessage="ingrese la fecha" ForeColor="Red" 
                        ValidationGroup="g">*</asp:RequiredFieldValidator>
                   
                    
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txtFecha" ErrorMessage="la fecha en el formato AAAA-MM-DD" 
                        ForeColor="Red" ValidationExpression="^[0-9]{4}-[0-1][0-9]-[0-3][0-9]$" 
                        ValidationGroup="g">*</asp:RegularExpressionValidator>
                   
                    
                </td>
            </tr>
            <tr>
                <td align="center" class="style6">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="center" class="style4">
                    &nbsp;</td>
                <td class="style7">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" 
                        ValidationGroup="g" Height="26px" Width="85px" />
                </td>
                <td class="style3">
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Height="25px" 
                        Width="87px" />
                </td>
            </tr>
        </table>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ValidationGroup="g" />
</asp:Content>
