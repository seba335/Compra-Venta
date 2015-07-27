<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormAdminArmado.aspx.vb" Inherits="TpPaginaVentasPC.FormAdminArmado"
theme="Skin1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
            width: 361px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="style3">
                <asp:Label ID="Label2" runat="server" Text="Cantidad de Pcs a armar:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblCantidaddePcs" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="Label5" runat="server" 
                    Text="Cantidad de pc para las cuales hay piezas para su armado:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblCantidadPosible" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="Label3" runat="server" 
                    Text="Cantidad de empleados de armado disponibles:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblCantidaddeEmpleados" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="Label4" runat="server" 
                    Text="Cantidad de pcs a ser asignada por empleado:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlCantidaddePcs" runat="server">
                    <asp:ListItem Value="---">Seleccionar</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                </asp:DropDownList>
                <asp:CompareValidator ID="CompareValidator1" runat="server"  ControlToValidate ="ddlCantidaddePcs"
                    ErrorMessage="Seleccione la cantidad de pcs a asignar" ForeColor="Red" 
                    Operator="NotEqual" ValueToCompare="---" ValidationGroup="g">*</asp:CompareValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td  colspan ="2" align="center" >
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
                <asp:Button ID="btnCancelar" runat="server" 
                    PostBackUrl="~/FormAdminPrncipal.aspx" Text="Cancelar" />
            </td>
        </tr>
    </table>
</asp:Content>
