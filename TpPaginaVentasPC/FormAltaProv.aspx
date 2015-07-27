<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormAltaProv.aspx.vb" Inherits="TpPaginaVentasPC.FormAltaProv"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .style2
        {
            width: 117px;
            height: 39px;
        }
        .style4
        {
            width: 40px;
        }
        .style3
        {
            height: 23px;
            width: 40px;
        }
        .style1
        {
            height: 23px;
            width: 44px;
        }
        #Select1
        {
            width: 195px;
        }
        .style7
        {
            height: 40px;
        }
        .style9
        {
            width: 302px;
            height: 34px;
        }
        .style11
        {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width:24%; margin-left: 1px;" align="left" border="1">
            <tr>
                <td class="style9" colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Nuevo proveedor"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="Ingrese Nombre"
                        ForeColor="Red" ControlToValidate="TxtNombre" ValidationGroup="g"
                        >*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label3" runat="server" Text="Apellido:"></asp:Label>
                </td>
                <td class="style11">
                    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ErrorMessage="Ingrese Apellido"
                        ForeColor="Red" ControlToValidate="txtApellido" ValidationGroup="g"
                        >*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label4" runat="server" Text="Localidad:"></asp:Label>
                </td>
                <td class="style11">
                    <asp:DropDownList ID="ddlLocalidad" runat="server" 
                        DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Id">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
                        SelectCommand="SELECT * FROM [Localidad]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label5" runat="server" Text="Telefono:"></asp:Label>
                </td>
                <td class="style11">
                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ErrorMessage="Ingrese Telefono"
                        ForeColor="Red" ControlToValidate="txtTelefono" ValidationGroup="g"
                        >*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="telrangevalidator" runat="server" BackColor="White" 
                        ControlToValidate="txtTelefono" Display="Dynamic" 
                        ErrorMessage="el telefono tiene que tener minimo 8 numeros" ForeColor="Red" 
                        MinimumValue="10000000" MaximumValue="999999999999" Text="*" Type="Double" 
                        ValidationGroup="g" ></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label6" runat="server" Text="E-Mail:"></asp:Label>
                </td>
                <td class="style11">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ErrorMessage="Ingrese email"
                        ForeColor="Red" ControlToValidate="txtEmail" ValidationGroup="g"
                        >*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ErrorMessage="ingrese el email con formato correcto" ForeColor="Red" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        ValidationGroup="g" ControlToValidate="txtEmail">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="left" class="style7" colspan="2">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" ValidationGroup="g" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
                        PostBackUrl="~/FormDetalleCompraProv.aspx" />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        HeaderText="Lista de errores" ValidationGroup="g" Width="191px" />
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>
