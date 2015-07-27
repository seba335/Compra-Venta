<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormAdminAltaZona.aspx.vb" Inherits="TpPaginaVentasPC.FormAdminAltaZona"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .style10
        {
            width: 175px;
            height: 23px;
        }
        .style11
        {
            width: 175px;
        }
        .style12
        {
            height: 32px;
        }
        .style13
        {
            height: 32px;
            width: 175px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 560px; height: 269px">
    








        <table style="width: 45%; height: 100px;" border="1">
            <tr>
                <td align="left" class="style11">
                    <asp:Label ID="Label1" runat="server" Text="Nueva zona"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style10">
                    <asp:Label ID="Label3" runat="server" Text="Descripción"></asp:Label>
                    <asp:TextBox ID="txtDescripcion" runat="server" Height="22px" Width="68px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtDescripcion" ErrorMessage="ingrese descripcion" 
                        ForeColor="Red" ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style11">
                    <asp:Label ID="Label4" runat="server" Text="Costo"></asp:Label>
                    <asp:TextBox ID="txtCosto" runat="server" Height="20px" Width="102px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtCosto" ErrorMessage="costo" ForeColor="Red" 
                        ValidationGroup="g">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator7" runat="server" 
                        ControlToValidate="txtCosto" ErrorMessage="el costo en numeros!" 
                        ForeColor="Red" Operator="DataTypeCheck" Type="Double" ValidationGroup="g">*</asp:CompareValidator>
                </td>
            </tr>
        </table>
        <table style="width: 37%;" border="1">
            <tr>
                <td align="left" class="style13">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" ValidationGroup="g" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
                        PostBackUrl="~/FormAdminPrncipal.aspx" />
                </td>
            </tr>
        </table>
    
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            HeaderText="lista de errores" ValidationGroup="g" Height="79px" 
            Width="339px" />
    
    </div>
</asp:Content>
