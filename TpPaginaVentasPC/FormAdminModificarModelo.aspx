<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormAdminModificarModelo.aspx.vb" Inherits="TpPaginaVentasPC.FormAdminModificarModelo"
theme="Skin1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style4
        {
            width: 201px;
        }
        .style5
        {
            width: 271px;
        }
        .style7
        {
            width: 54px;
        }
        .style9
        {
            width: 54px;
            height: 47px;
        }
        .style10
        {
            width: 201px;
            height: 47px;
        }
        .style12
        {
            width: 78px;
        }
        .style13
        {
            width: 57px;
            height: 47px;
        }
        .style14
        {
            width: 57px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%; height: 159px;">
        <tr>
            <td class="style13">
                Nombre del modelo:<asp:Label ID="LblModeloNombre" runat="server"></asp:Label>
            </td>
            <td class="style9">
&nbsp;<asp:Button ID="BtnActivo" runat="server" Height="26px" Text="Modificar Activo" 
                    Width="111px" />
                <asp:CheckBox ID="ChboxActivo" runat="server" />
            </td>
            <td class="style10" width="150">
                Costo:<asp:TextBox ID="TxtCosto" runat="server" Height="21px" Width="70px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TxtCosto" ErrorMessage="Ingrese costo" ForeColor="Red" 
                    ValidationGroup="g">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style14">
                Minimo<asp:DropDownList ID="DdlMinimo" runat="server">
                </asp:DropDownList>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="DdlMaximo" ControlToValidate="DdlMinimo" Display="Dynamic" 
                    ErrorMessage="El minimo debe ser menor al maximo" ForeColor="Red" 
                    Operator="LessThan" Type="Integer" ValidationGroup="g">*</asp:CompareValidator>
            </td>
            <td class="style7">
                Maximo:<asp:DropDownList ID="DdlMaximo" runat="server">
                </asp:DropDownList>
            </td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style14">
                <asp:Button ID="BtnAceptar" runat="server" Height="25px" Text="Aceptar" 
                    ValidationGroup="g" Width="96px" />
            </td>
            <td class="style7">
                <asp:Button ID="BtnCancelar" runat="server" Height="25px" 
                    PostBackUrl="~/FormAdminModelos.aspx" Text="Cancelar" Width="94px" />
            </td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style14">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                    ValidationGroup="g" Width="230px" />
            </td>
            <td class="style7">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
