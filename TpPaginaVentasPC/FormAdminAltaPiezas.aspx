<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormAdminAltaPiezas.aspx.vb" Inherits="TpPaginaVentasPC.FormAdminAltaPiezas"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .style2
        {
            width: 79px;
        }
        .style3
        {
            height: 23px;
            width: 79px;
        }
        .style1
        {
            height: 23px;
        }
        #Select1
        {
            width: 126px;
        }
        .style4
        {
            width: 302px;
            height: 30px;
        }
        .style5
        {
            width: 302px;
            height: 149px;
        }
        .style6
        {
            height: 43px;
        }
        .style7
        {
            width: 302px;
            height: 43px;
        }
        .style8
        {
            width: 302px;
            height: 54px;
        }
        .style9
        {
            height: 54px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 362px; height: 274px;">
    
        <table style="width:100%; height: 243px;" border="1">
            <tr>
                <td align="center" class="style4" colspan="2">
                    <asp:Label ID="Label3" runat="server" Text="Nueva pieza"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    <asp:Label ID="Label1" runat="server" Text="Descripción:"></asp:Label>
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtDescripcion" Display="Dynamic" 
                        ErrorMessage="Debe poner una decripcion de la pieza" ForeColor="Red" 
                        ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style8">
                    Costo:</td>
                <td class="style9">
                    <asp:TextBox ID="txtCosto" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtCosto" Display="Dynamic" 
                        ErrorMessage="Debe ingresar un costo a la pieza " 
                        ForeColor="Red" ValidationGroup="g">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="txtCosto" Display="Dynamic" 
                        ErrorMessage="El costo debe ser un dato numerico" ForeColor="Red" 
                        Operator="DataTypeCheck" Type="Double" ValidationGroup="g">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label2" runat="server" Text="Tipo:"></asp:Label>
                </td>
                <td class="style1">
                    <asp:DropDownList ID="ddlTipo" runat="server">
                        <asp:ListItem Value="---">Seleccione</asp:ListItem>
                        <asp:ListItem>Procesador</asp:ListItem>
                        <asp:ListItem>Memoria</asp:ListItem>
                        <asp:ListItem>Disco</asp:ListItem>
                        <asp:ListItem Value="PlacaDeVideo">Placa De Video</asp:ListItem>
                        <asp:ListItem>Fuente</asp:ListItem>
                        <asp:ListItem>Gabinete</asp:ListItem>
                        <asp:ListItem>Mother</asp:ListItem>
                        <asp:ListItem>Lectora</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" 
                        ControlToValidate="ddlTipo" Display="Dynamic" ErrorMessage="seleccione un  tipo" 
                        ForeColor="#FF3300" ValueToCompare="---" Operator="NotEqual" 
                        ValidationGroup="g">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" 
                        style="height: 26px" ValidationGroup="g" />
                </td>
                <td class="style1">
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
                        PostBackUrl="~/FormAdminPiezas.aspx" />
                </td>
            </tr>
            <tr>
                <td  colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" ValidationGroup="g" />
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>
