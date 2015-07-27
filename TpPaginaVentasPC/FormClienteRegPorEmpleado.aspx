<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormClienteRegPorEmpleado.aspx.vb" Inherits="TpPaginaVentasPC.FormClienteRegPorEmpleado" theme="Skin1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style5
        {
            width: 50px;
        }
        .style6
        {
            width: 49px;
        }
        .style7
        {
            width: 48px;
        }
        .style9
        {
            width: 20px;
        }
        .style10
        {
            width: 23px;
            height: 162px;
        }
        .style11
        {
            width: 41px;
        }
        .style12
        {
            width: 7px;
        }
        .style13
        {
            width: 5px;
        }
        .style14
        {
            width: 47px;
        }
        .style15
        {
            width: 2px;
        }
        .style16
        {
            width: 43px;
        }
        .style17
        {
            width: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width: 57%; height: 445px;">
            <tr>
                <td  colspan="12" >
                    <h3 style="height: 29px">
                        <asp:Label ID="Label1" runat="server" Text="Registro cliente"></asp:Label>
                    &nbsp;</h3>
                </td>
            </tr>
            <tr>
                <td class="style11">
                    <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                </td>
                <td class="style7" colspan="11">
                    <asp:TextBox ID="txtNombre" runat="server" Width="103px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ErrorMessage="Ingrese un nombre" ForeColor="Red" 
                        ControlToValidate="txtNombre" ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style11">
                    <asp:Label ID="Label3" runat="server" Text="Apellido:"></asp:Label>
                </td>
                <td  colspan="11">
                    <asp:TextBox ID="txtApellido" runat="server" Width="104px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ErrorMessage="Ingrese un apellido" ForeColor="Red" 
                        ControlToValidate="txtApellido" ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style11">
                    <asp:Label ID="Label4" runat="server" Text="Contraseña:"></asp:Label>
                </td>
                <td class="style9">
                    <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" 
                        Width="107px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ErrorMessage="ingrese contraseña" ForeColor="Red" 
                        ControlToValidate="txtContraseña" ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
                <td  colspan="10">
                    <asp:Label ID="Label12" runat="server" Text="reingrese contraseña"></asp:Label>

                    <asp:TextBox ID="txtContraseña2" runat="server" TextMode="Password" 
                        Width="90px" Height="21px"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="txtContraseña2" ControlToValidate="txtContraseña" 
                        Display="Dynamic" ErrorMessage="CompareValidator" ForeColor="Red" 
                        ValidationGroup="g">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style11">
                    <asp:Label ID="Label5" runat="server" Text="Telefono:"></asp:Label>
                </td>
                <td  colspan="11">
                    <asp:TextBox ID="txtTelefono" runat="server" Width="106px"></asp:TextBox>
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
                <td class="style11">
                    <asp:Label ID="Label6" runat="server" Text="Correo electronico:"></asp:Label>
                </td>
                <td  colspan="11">
                    <asp:TextBox ID="txtCorreo" runat="server" Width="105px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ErrorMessage="ingrese un email" ForeColor="Red" 
                        ControlToValidate="txtCorreo" ValidationGroup="g">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ErrorMessage="RegularExpressionValidator" ForeColor="Red" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        ValidationGroup="g" ControlToValidate="txtCorreo">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style11">
                    <asp:Label ID="Label7" runat="server" Text="Localidad:"></asp:Label>
                </td>
                <td class="style9">
                    <asp:DropDownList ID="ddlLocalidad" runat="server" Height="16px" Width="149px" 
                        DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Id">
                        <asp:ListItem Value="---">Seleccione</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" 
                        ControlToValidate="ddlLocalidad" Display="Dynamic" 
                        ErrorMessage="Seleccione una localidad" ForeColor="Red" Operator="NotEqual" 
                        ValidationGroup="g" ValueToCompare="---">*</asp:CompareValidator>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
                        SelectCommand="SELECT * FROM [Localidad]"></asp:SqlDataSource>
                </td>
                <td class="style10">
                    <asp:Label ID="Label8" runat="server" Text="Calle:"></asp:Label>
                </td>
                <td class="style7"   >
                    <asp:TextBox ID="txtCalle" runat="server" Width="40px" 
                        style="margin-left: 0px" Height="22px"></asp:TextBox>
                </td>
                <td class="style15">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ErrorMessage="ingrese calle" ForeColor="Red" 
                        ControlToValidate="txtCalle" ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
                <td class="style16">
                    <asp:Label ID="Label9" runat="server" Text="Numero:"></asp:Label>
                </td>
                <td class="style17">
                    <asp:TextBox ID="txtNumero" runat="server" Width="43px" Height="23px"></asp:TextBox>
                </td>
                <td class="style15">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ErrorMessage="Ingrese numero de calle" ForeColor="Red" 
                        ControlToValidate="txtNumero" ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
                <td class="style14">
                    <asp:Label ID="Label10" runat="server" Text="Departamento:"></asp:Label>
                </td>
                <td class="style12">
                    <asp:TextBox ID="txtDepartamento" runat="server" Height="21px" Width="38px"></asp:TextBox>
                </td>
                <td class="style6">
                    <asp:Label ID="Label11" runat="server" Text="Piso:"></asp:Label>
                </td>
                <td class="style12">
                    <asp:TextBox ID="txtPiso" runat="server" Width="33px" Height="22px"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator9" runat="server" 
                        ControlToValidate="txtPiso" ErrorMessage="el piso en numeros!" 
                        ForeColor="Red" Operator="DataTypeCheck" Type="Integer" 
                        ValidationGroup="g">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style13" colspan="12" align="center">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" ValidationGroup="g" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                </td>
            </tr>
            <tr>
                <td class="style13" colspan="12" align="center">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" HeaderText="Lista de errores" ValidationGroup="g" 
                        Width="400px" />
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>
