
<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormClienteMod.aspx.vb" Inherits="TpPaginaVentasPC.FormClienteMod" theme="Skin1" %>
<%@ MasterType VirtualPath="~/Logueo.Master"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
            height: 57px;
        }
        .style4
        {
            width: 688px;
            height: 57px;
        }
        .style5
        {
            width: 126px;
        }
        .style6
        {
            width: 162px;
        }
        .style7
        {
            width: 159px;
        }
        .style8
        {
            height: 30px;
        }
        .style9
        {
            width: 532px;
            height: 30px;
        }
        .style11
        {
            width: 224px;
        }
        .style12
        {
            width: 171px;
        }
        .style13
        {
            width: 259px;
        }
        .style14
        {
            width: 228px;
        }
        .style15
        {
            width: 93px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    
        <table style="width: 75%; height: 400px;">
            <tr>
                <td align="center" colspan="6">
                    <asp:Label ID="Label1" runat="server" Text="Modificar información"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                </td>
                <td class="style4" colspan="5">
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                        ErrorMessage="Ingrese nombre" ForeColor="Red" 
                        ControlToValidate="txtNombre" ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Apellido:"></asp:Label>
                </td>
                <td class="style1" colspan="5">
                    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                        ErrorMessage="Ingrese apellido" ForeColor="Red" 
                        ControlToValidate="txtApellido" ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Telefono:"></asp:Label>
                </td>
                <td class="style1" colspan="5">
                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ErrorMessage="ingrese telefono" ForeColor="Red"
                         ControlToValidate="txtTelefono" ValidationGroup="g">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator10" runat="server" 
                        ControlToValidate="txtNumero" ErrorMessage="el telefono en numeros!" 
                        ForeColor="Red" Operator="DataTypeCheck" Type="Integer" 
                        ValidationGroup="g">*</asp:CompareValidator>
                    <asp:RangeValidator ID="telrangevalidator" runat="server" BackColor="White" 
                        ControlToValidate="txtTelefono" Display="Dynamic" 
                        ErrorMessage="el telefono tiene que tener minimo 8 numeros" ForeColor="Red" 
                        MinimumValue="10000000" MaximumValue="999999999999" Text="*" Type="Double" 
                        ValidationGroup="g" ></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="style8">
                    <asp:Label ID="Label5" runat="server" Text="E-Mail:"></asp:Label>
                </td>
                <td class="style9" colspan="5">
                    <asp:Label ID="lblEmail" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Localidad:"></asp:Label>
                </td>
                <td class="style15">
                    <asp:DropDownList ID="ddlLocalidad" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="style11">
                    <asp:Label ID="Label7" runat="server" Text="Calle:"></asp:Label>
                    <asp:TextBox ID="txtCalle" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ErrorMessage="ingrese calle" ForeColor="Red" 
                        ControlToValidate="txtCalle" ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
                <td class="style13">
                    <asp:Label ID="Label8" runat="server" Text="Numero:"></asp:Label>
                    <asp:TextBox ID="txtNumero" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator8" runat="server" 
                        ControlToValidate="txtNumero" ErrorMessage="el numero de calle en numeros!" 
                        ForeColor="Red" Operator="DataTypeCheck" Type="Integer" 
                        ValidationGroup="g">*</asp:CompareValidator>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ErrorMessage="Ingrese numero de calle" ForeColor="Red" 
                        ControlToValidate="txtNumero" ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
                <td class="style6">
                    <asp:Label ID="Label9" runat="server" Text="Departamento:"></asp:Label>
                    <asp:TextBox ID="txtDepartamento" runat="server" Height="19px" Width="59px"></asp:TextBox>
                </td>
                <td class="style14">
                    <asp:Label ID="Label10" runat="server" Text="Piso:"></asp:Label>
                    <asp:TextBox ID="txtPiso" runat="server" Height="21px" Width="35px"></asp:TextBox>

                    <asp:CompareValidator ID="CompareValidator9" runat="server" 
                        ControlToValidate="txtPiso" ErrorMessage="el piso en numeros!" 
                        ForeColor="Red" Operator="DataTypeCheck" Type="Integer" 
                        ValidationGroup="g">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style15">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" ValidationGroup="g" 
                        style="height: 26px" />
                </td>
                <td class="style11">
                    &nbsp;</td>
                <td class="style13">
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
                        PostBackUrl="~/FormClientePrincipalF.aspx" />
                </td>
                <td class="style7">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="83px" 
                        Width="853px" ValidationGroup="g" />
                </td>
            </tr>
        </table>
    
 
</asp:Content>

    
 
