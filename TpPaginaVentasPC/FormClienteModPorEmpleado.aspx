<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormClienteModPorEmpleado.aspx.vb" Inherits="TpPaginaVentasPC.FormClienteModPorEmpleado"
theme="Skin1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style4
        {
            width: 529px;
        }
        .style5
        {
            width: 528px;
        }
        .style8
        {
            height: 29px;
        }
        .style9
        {
            width: 80px;
            height: 29px;
        }
        .style12
        {
            width: 527px;
        }
        .style14
        {
            width: 80px;
        }
        .style15
        {
            width: 86px;
        }
        .style16
        {
            width: 86px;
            height: 29px;
        }
        .style19
        {
            width: 70px;
            height: 29px;
        }
        .style20
        {
            width: 70px;
        }
        .style27
        {
            width: 86px;
            height: 43px;
        }
        .style28
        {
            width: 80px;
            height: 43px;
        }
        .style29
        {
            width: 70px;
            height: 43px;
        }
        .style30
        {
            height: 43px;
        }
        .style31
        {
            width: 37px;
            height: 43px;
        }
        .style32
        {
            width: 37px;
        }
        .style33
        {
            width: 29px;
            height: 43px;
        }
        .style34
        {
            width: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    
        <table style="width: 94%; height: 400px;">
            <tr>
                <td align="center" colspan="9">
                    <asp:Label ID="Label1" runat="server" Text="Modificar información"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style15">
                    <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                </td>
                <td class="style4" colspan="8">
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                        ErrorMessage="Ingrese nombre" ForeColor="Red" 
                        ControlToValidate="txtNombre" ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style15">
                    <asp:Label ID="Label3" runat="server" Text="Apellido:"></asp:Label>
                </td>
                <td class="style1" colspan="8">
                    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                        ErrorMessage="Ingrese apellido" ForeColor="Red" 
                        ControlToValidate="txtApellido" ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style15">
                    <asp:Label ID="Label4" runat="server" Text="Telefono:"></asp:Label>
                </td>
                <td class="style1" colspan="8">
                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ErrorMessage="ingrese telefono" ForeColor="Red"
                         ControlToValidate="txtTelefono" ValidationGroup="g">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="telrangevalidator" runat="server" BackColor="White" 
                        ControlToValidate="txtTelefono" Display="Dynamic" 
                        ErrorMessage="el telefono tiene que tener minimo 8 numeros" ForeColor="Red" 
                        MinimumValue="10000000" MaximumValue="999999999999" Text="*" Type="Double" 
                        ValidationGroup="g" ></asp:RangeValidator>
                    <asp:CompareValidator ID="CompareValidator10" runat="server" 
                        ControlToValidate="txtTelefono" ErrorMessage="el telefono en numeros!" 
                        ForeColor="Red" Operator="DataTypeCheck" Type="Integer" 
                        ValidationGroup="g">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style15">
                    <asp:Label ID="Label5" runat="server" Text="E-Mail:"></asp:Label>
                </td>
                <td class="style1" colspan="8">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txtEmail" ErrorMessage="formato de email invalido" 
                        ForeColor="Red" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        ValidationGroup="g">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style16">
                    <asp:Label ID="Label11" runat="server" Text="Contraseña:"></asp:Label>
                </td>
                <td class="style9" colspan="1">
                    <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td colspan ="1" class="style19">
                    <asp:Label ID="Label12" runat="server" Text="Repetir Contraseña:"></asp:Label>
                    <asp:TextBox ID="txtContraseña2" runat="server" TextMode="Password" 
                        style="margin-left: 70px"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="txtContraseña" ControlToValidate="txtContraseña2" 
                        Display="Dynamic" ErrorMessage="Verifique que las contraseñas sean iguales" 
                        ForeColor="Red" ValidationGroup="g">*</asp:CompareValidator>
                </td>
                <td colspan ="6" class="style8">
                </td>
            </tr>
            <tr>
                <td class="style27">
                    <asp:Label ID="Label6" runat="server" Text="Localidad:"></asp:Label>
                </td>
                <td class="style28">
                 <asp:DropDownList ID="ddlLocalidad" runat="server" 
                        DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Id">
                    </asp:DropDownList>&nbsp;<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
                        SelectCommand="SELECT * FROM [Localidad]"></asp:SqlDataSource>
                </td>
                <td class="style29">
                    <asp:Label ID="Label7" runat="server" Text="Calle:"></asp:Label>
                    <asp:TextBox ID="txtCalle" runat="server" style="margin-left: 56px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ErrorMessage="ingrese calle" ForeColor="Red" 
                        ControlToValidate="txtCalle" ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
                <td class="style31">
                    <asp:Label ID="Label8" runat="server" Text="Numero:"></asp:Label>
                    <asp:TextBox ID="txtNumero" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td class="style30">
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ErrorMessage="Ingrese numero de calle" ForeColor="Red" 
                        ControlToValidate="txtNumero" ValidationGroup="g">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator8" runat="server" 
                        ControlToValidate="txtNumero" ErrorMessage="el numero de calle en numeros!" 
                        ForeColor="Red" Operator="DataTypeCheck" Type="Integer" ValidationGroup="g">*</asp:CompareValidator>
                </td>
                <td class="style33">
                    <asp:Label ID="Label9" runat="server" Text="Departamento:"></asp:Label>
                </td>
                <td class="style30">
                    <asp:TextBox ID="txtDepartamento" runat="server" Width="30px"></asp:TextBox>
                </td>
                <td class="style30">
                    <asp:Label ID="Label10" runat="server" Text="Piso:"></asp:Label>
                </td>
                <td class="style30">
                    <asp:TextBox ID="txtPiso" runat="server" Width="45px"></asp:TextBox>

                    <asp:CompareValidator ID="CompareValidator9" runat="server" 
                        ControlToValidate="txtPiso" ErrorMessage="el piso en numeros!" 
                        ForeColor="Red" Operator="DataTypeCheck" Type="Integer" 
                        ValidationGroup="g">*</asp:CompareValidator>

                </td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style20">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" ValidationGroup="g" />
                </td>
                <td class="style32">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style34">
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
                        PostBackUrl="~/FormListadeClientes.aspx" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="9">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="83px" 
                        Width="853px" ValidationGroup="g" />
                </td>
            </tr>
        </table>
    
 
</asp:Content>
