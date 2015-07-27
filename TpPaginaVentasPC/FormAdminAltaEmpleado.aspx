<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormAdminAltaEmpleado.aspx.vb" Inherits="TpPaginaVentasPC.FormAdminAltaEmpleado"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style5
        {
            height: 153px;
        }
        .style12
        {
            width: 688px;
            height: 156px;
        }
        .style35
        {
            width: 732px;
        height: 21px;
    }
        .style63
        {
            height: 20px;
            width: 289px;
        }
        .style64
        {
            height: 20px;
            width: 167px;
        }
        .style65
        {
            width: 231px;
            height: 20px;
        }
        .style66
        {
            height: 20px;
            width: 378px;
        }
        .style67
        {
            height: 20px;
            width: 67px;
        }
        .style68
        {
            width: 308px;
            height: 20px;
        }
        .style71
        {
            height: 21px;
            width: 289px;
        }
        .style72
        {
            height: 21px;
            width: 167px;
        }
        .style73
        {
            width: 231px;
            height: 21px;
        }
        .style74
        {
            height: 21px;
            width: 378px;
        }
    .style75
    {
        height: 19px;
        width: 67px;
    }
    .style76
    {
        width: 308px;
        height: 19px;
    }
    .style77
    {
        height: 21px;
        width: 67px;
    }
    .style78
    {
        width: 308px;
        height: 21px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 152px; width: 772px;">
    
        <table  style="width:100%; height: 31px;">
            <tr>
                <td class="style35" bgcolor="#9999FF">
                    <asp:Label ID="Label1" runat="server" Text="Empleado Nuevo"></asp:Label>
                </td>
            </tr>
        </table>
        <table  border="1" style="width:94%; height: 253px;" bgcolor="#9999FF">
            <tr>
                <td class="style67">
                    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox ID="txtNombre" runat="server" Width="71px" Height="20px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                     ErrorMessage="ingrese nombre"
                     ForeColor="Red" ControlToValidate="txtNombre" ValidationGroup="g">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator3" runat="server" 
                        ControlToValidate="txtNombre" ErrorMessage="el nombre en letras!" 
                        ForeColor="Red" Operator="DataTypeCheck" ValidationGroup="g">*</asp:CompareValidator>
                </td>
                <td class="style68">
                    <asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label>
                    <asp:TextBox ID="txtApellido" runat="server" Width="85px" Height="20px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                     ErrorMessage="ingrese apellido"
                     ForeColor="Red" ControlToValidate="txtApellido" ValidationGroup="g">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator4" runat="server" 
                        ControlToValidate="txtApellido" ErrorMessage="el apellido en letras!" 
                        ForeColor="Red" Operator="DataTypeCheck" ValidationGroup="g">*</asp:CompareValidator>
                </td>
                <td class="style63">
                    <asp:Label ID="Label4" runat="server" Text="Usuario"></asp:Label>
                    <asp:TextBox ID="txtUsuario" runat="server" Width="80px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                     ErrorMessage="ingrese usuario"
                     ForeColor="Red" ControlToValidate="txtUsuario" ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
                <td class="style64">
                    <asp:Label ID="Label5" runat="server" Text="Contraseña"></asp:Label>
                    <asp:TextBox ID="txtContraseña" runat="server" Height="20px" Width="57px"></asp:TextBox>
                                              <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                     ErrorMessage="ingrese contraseña"
                     ForeColor="Red" ControlToValidate="txtContraseña" ValidationGroup="g">*</asp:RequiredFieldValidator>
  
                </td>
                <td class="style65">
                    <asp:Label ID="Label13" runat="server" Text="Estado civil"></asp:Label>
                    <asp:DropDownList ID="ddlEstadoCivil" runat="server">
                        <asp:ListItem Value="---">Seleccionar</asp:ListItem>
                        <asp:ListItem>Casado</asp:ListItem>
                        <asp:ListItem>Soltero</asp:ListItem>
                        <asp:ListItem>Divorciado</asp:ListItem>
                        <asp:ListItem>Viudo</asp:ListItem>
                     
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="ddlEstadoCivil" Display="Dynamic" 
                        ErrorMessage="Seleccione un estado civil" ForeColor="Red" Operator="NotEqual" 
                        ValidationGroup="g" ValueToCompare="---">*</asp:CompareValidator>
                </td>
                <td class="style66">
                    <asp:Label ID="Label15" runat="server" Text="Tipo"></asp:Label>
                    <asp:DropDownList ID="ddlTipo" runat="server">
                        <asp:ListItem Value="---">Seleccionar</asp:ListItem>
                        <asp:ListItem>Administrador</asp:ListItem>
                        <asp:ListItem>Compras</asp:ListItem>
                        <asp:ListItem>Ventas</asp:ListItem>
                        <asp:ListItem>Armado</asp:ListItem>
                        
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" 
                        ControlToValidate="ddlTipo" Display="Dynamic" 
                        ErrorMessage="Seleccione un tipo de empleado" ForeColor="Red" 
                        Operator="NotEqual" ValidationGroup="g" ValueToCompare="---">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style77">
                    <asp:Label ID="Label7" runat="server" Text="Localidad"></asp:Label>
                    <asp:DropDownList ID="ddlLocalidad" runat="server" Height="16px" Width="88px">

                    
                    </asp:DropDownList>
                </td>
                <td class="style78">
                    <asp:Label ID="Label9" runat="server" Text="Calle"></asp:Label>
                    <asp:TextBox ID="txtCalle" runat="server" Width="80px" Height="20px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                     ErrorMessage="ingrese calle"
                     ForeColor="Red" ControlToValidate="txtCalle" ValidationGroup="g">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator5" runat="server" 
                        ControlToValidate="txtApellido" ErrorMessage="la calle en letras!" 
                        ForeColor="Red" Operator="DataTypeCheck" ValidationGroup="g">*</asp:CompareValidator>
                </td>
                
                <td class="style71">
                    <asp:Label ID="Label10" runat="server" Text="Numero"></asp:Label>
                    <asp:TextBox ID="txtNumero" runat="server" Width="24px" Height="20px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                     ErrorMessage="ingrese numero"
                     ForeColor="Red" ControlToValidate="txtNumero" ValidationGroup="g">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator8" runat="server" 
                        ControlToValidate="txtNumero" ErrorMessage="el numero de calle en numeros!" 
                        ForeColor="Red" Operator="DataTypeCheck" Type="Integer" 
                        ValidationGroup="g">*</asp:CompareValidator>
                </td>
                <td class="style72">
                    <asp:Label ID="Label11" runat="server" Text="Piso"></asp:Label>
  
                    <asp:TextBox ID="txtPiso" runat="server" Width="18px" Height="20px"></asp:TextBox>
  
                    <asp:CompareValidator ID="CompareValidator6" runat="server" 
                        ControlToValidate="txtPiso" ErrorMessage="el piso es numero" ForeColor="Red" 
                        Operator="DataTypeCheck" Type="Integer" ValidationGroup="g">*</asp:CompareValidator>
  
                </td>
                <td class="style73" >
                    <asp:Label ID="Label12" runat="server" Text="Departamento"></asp:Label>
                    <asp:TextBox ID="txtDepartamento" runat="server" Height="21px" Width="23px"></asp:TextBox>
                </td>
                <td class="style74">
                    <asp:Label ID="Label14" runat="server" Text="Telefono"></asp:Label>
                    <asp:TextBox ID="txtTelefono" runat="server" style="margin-left: 0px; margin-top: 0px;" 
                        Width="80px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server"
                     ErrorMessage="ingrese telefono"
                     ForeColor="Red" ControlToValidate="txtTelefono" ValidationGroup="g">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator7" runat="server" 
                        ControlToValidate="txtTelefono" ErrorMessage="el telefono en numeros!" 
                        ForeColor="Red" Operator="DataTypeCheck" Type="Integer" ValidationGroup="g">*</asp:CompareValidator>
                    <asp:RangeValidator ID="telrangevalidator" runat="server" BackColor="White" 
                        ControlToValidate="txtTelefono" Display="Dynamic" 
                        ErrorMessage="el telefono tiene que tener minimo 8 numeros" ForeColor="Red" 
                        MinimumValue="10000000" MaximumValue="999999999999" Text="*" Type="Double" 
                        ValidationGroup="g" ></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="style75">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" ValidationGroup="g" 
                        Height="29px" Width="83px" />
                </td>
                <td class="style76" colspan="5">
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
                        PostBackUrl="~/FormAdminEmpleados.aspx" Height="33px" Width="90px" />
                </td>
                
            </tr>
            </table>
    
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            HeaderText="Lista de errores" ValidationGroup="g" Width="695px" 
            Height="58px" />
    
    </div>
</asp:Content>
