<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormAdminModEmpleado.aspx.vb" Inherits="TpPaginaVentasPC.FormAdminModEmpleado"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style4
        {
            width: 302px;
            height: 160px;
        }
        .style5
        {
            height: 157px;
        }
        .style7
        {
            height: 44px;
        }
        .style9
        {
            width: 302px;
            height: 44px;
        }
        .style10
        {
            width: 484px;
            height: 53px;
        }
        .style12
        {
            height: 43px;
        }
        .style13
        {
            width: 302px;
            height: 53px;
        }
        .style14
        {
            height: 53px;
        }
        .style15
        {
            width: 362px;
            height: 44px;
        }
        .style16
        {
            width: 362px;
            height: 53px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr align ="center" >
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Modificar Empleado"></asp:Label>
                </td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="style7">
                    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                </td>
                <td class="style7">
                    <asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label>
                </td>
                <td class="style7">
                    <asp:Label ID="Label7" runat="server" Text="Localidad"></asp:Label>
                </td>
                <td class="style7">
                    <asp:Label ID="Label9" runat="server" Text="Calle"></asp:Label>
                </td>
                <td class="style7">
                    <asp:Label ID="Label10" runat="server" Text="Numero"></asp:Label>
                </td>
                <td class="style7">
                    <asp:Label ID="Label11" runat="server" Text="Piso"></asp:Label>
                </td>
                <td class="style7">
                    <asp:Label ID="Label12" runat="server" Text="Departamento"></asp:Label>
                </td>
                <td class="style7">
                    <asp:Label ID="Label13" runat="server" Text="Estado civil"></asp:Label>
                </td>
                <td class="style15">
                    <asp:Label ID="Label14" runat="server" Text="Telefono"></asp:Label>
                </td>
                <td class="style9">
                    <asp:Label ID="Label15" runat="server" Text="Tipo"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style10">
                    <asp:TextBox ID="TxtNombre" runat="server" Height="24px" Width="81px"></asp:TextBox>
                </td>
                <td class="style10">
                    <asp:TextBox ID="TxtApellido" runat="server" Height="23px" Width="75px"></asp:TextBox>
                </td>
                <td class="style10">
                    <asp:DropDownList ID="ddlLocalidad" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="style10">
                    <asp:TextBox ID="txtCalle" runat="server" Width="93px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                     ErrorMessage="ingrese calle"
                     ForeColor="Red" ControlToValidate="txtCalle" ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
                <td class="style10">
                    <asp:TextBox ID="txtNumero" runat="server" Width="51px"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                     ErrorMessage="ingrese numero"
                     ForeColor="Red" ControlToValidate="txtNumero" ValidationGroup="g">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator9" runat="server" 
                        ControlToValidate="txtNumero" ErrorMessage="el numero de calle en numeros!" 
                        ForeColor="Red" Operator="DataTypeCheck" Type="Double" ValidationGroup="g">*</asp:CompareValidator>
                </td>
                <td class="style13">
                    <asp:TextBox ID="txtPiso" runat="server" style="margin-left: 14px" Width="27px"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator8" runat="server" 
                        ControlToValidate="txtPiso" ErrorMessage="el piso en numeros!" 
                        ForeColor="Red" Operator="DataTypeCheck" Type="Integer" 
                        ValidationGroup="g">*</asp:CompareValidator>
                </td>
                <td class="style10">
                    <asp:TextBox ID="txtDepartamento" runat="server" Width="74px"></asp:TextBox>
                </td>
                <td class="style10">
                    <asp:DropDownList ID="ddlEstadoCivil" runat="server">
                    <asp:ListItem Value="---">Seleccionar</asp:ListItem>
                        <asp:ListItem>Casado</asp:ListItem>
                        <asp:ListItem>Soltero</asp:ListItem>
                        <asp:ListItem>Divorciado</asp:ListItem>
                        <asp:ListItem>Viudo</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style16">
                    <asp:TextBox ID="txtTelefono" runat="server" Width="69px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server"
                     ErrorMessage="ingrese telefono"
                     ForeColor="Red" ControlToValidate="txtTelefono" ValidationGroup="g">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="telrangevalidator" runat="server" BackColor="White" 
                        ControlToValidate="txtTelefono" Display="Dynamic" 
                        ErrorMessage="el telefono tiene que tener minimo 8 numeros" ForeColor="Red" 
                        MinimumValue="10000000" MaximumValue="999999999999" Text="*" Type="Double" 
                        ValidationGroup="g" ></asp:RangeValidator>
                    <asp:CompareValidator ID="CompareValidator7" runat="server" 
                        ControlToValidate="txtTelefono" ErrorMessage="el telefono en numeros!" 
                        ForeColor="Red" Operator="DataTypeCheck" Type="Double" ValidationGroup="g">*</asp:CompareValidator>
                </td>
                <td class="style14">
                    <asp:DropDownList ID="ddlTipo" runat="server">
                    <asp:ListItem Value="---">Seleccionar</asp:ListItem>
                        <asp:ListItem>Administrador</asp:ListItem>
                        <asp:ListItem>Compras</asp:ListItem>
                        <asp:ListItem>Ventas</asp:ListItem>
                        <asp:ListItem>Armado</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="style4">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" ValidationGroup="g" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
                        PostBackUrl="~/FormAdminEmpleados.aspx" />
                    &nbsp;&nbsp;
                    <asp:Button ID="BtnBaja" runat="server" Height="26px" Text="Dar de baja" 
                        Visible="False" Width="89px" />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        HeaderText="lista de errores" ValidationGroup="g" />
                </td>
                <td class="style4">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
</asp:Content>
