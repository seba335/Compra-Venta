<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormEnvioDetalles.aspx.vb" Inherits="TpPaginaVentasPC.FormEnvioDetalles"
theme="Skin1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
            height: 34px;
        }
        .style4
        {
            height: 40px;
        }
        .style5
        {
            height: 42px;
        }
        .style6
        {
            height: 43px;
        }
        .style7
        {
            height: 45px;
        }
        .style8
        {
            height: 50px;
        }
        .style9
        {
            width: 195px;
        }
        .style10
        {
            height: 50px;
            width: 195px;
        }
        .style11
        {
            height: 34px;
            width: 130px;
        }
        .style12
        {
            width: 193px;
        }
        .style13
        {
            height: 50px;
            width: 130px;
        }
        .style14
        {
            width: 130px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table align="center" style="width: 78%; height: 337px;">
            <tr>
                <td align="center" class="style6" colspan="5">
                    <span>
                    <asp:Label ID="Label1" runat="server" Text="Informacion de envio"></asp:Label>
                    </span>
                </td>
            </tr>
            <tr>
                <td align ="center"  colspan ="5">
                    <asp:Label ID="Label2" runat="server" Text="Dirección de envio"></asp:Label>
                </td>
               
            </tr>
            <tr>
                <td class="style14">
                    <asp:Label ID="Label3" runat="server" Text="Localidad"></asp:Label>
                    <br />
                    <asp:DropDownList ID="ddlLocalidad" runat="server" 
                        DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Id">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
                        SelectCommand="SELECT * FROM [Localidad]"></asp:SqlDataSource>
                </td>
                <td class="style10">
                    <asp:Label ID="Label4" runat="server" Text="Calle"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtCalle" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtCalle" ErrorMessage="ingrese calle" ForeColor="Red" 
                        ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
                <td class="style3">
                    <asp:Label ID="Label5" runat="server" Text="Numero"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtNumero" ErrorMessage="ingrese numero" ForeColor="Red" 
                        ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
                <td class="style4">
                    <asp:Label ID="Label6" runat="server" Text="Departamento"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtDepartamento" runat="server"></asp:TextBox>
                </td>
                <td class="style9">
                    <asp:Label ID="Label7" runat="server" Text="Piso"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtPiso" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator9" runat="server" 
                        ControlToValidate="txtPiso" ErrorMessage="el piso en numeros!" 
                        ForeColor="Red" Operator="DataTypeCheck" Type="Integer" 
                        ValidationGroup="g">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:Label ID="Label8" runat="server" Text="Telefono"></asp:Label>
                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ErrorMessage="ingrese telefono" ForeColor="Red" ValidationGroup="g" 
                        ControlToValidate="txtTelefono">*</asp:RequiredFieldValidator>
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
                <td class="style8" colspan="4" align="center">
                    <asp:Label ID="Label9" runat="server" Text="Costo de envio"></asp:Label>
                    <asp:Label ID="lblCostodeEnvio" runat="server"></asp:Label>
                    <asp:Button ID="Button1" runat="server" Text="Consultar costo de envio" 
                        Height="32px" Width="196px" />
                </td>
            </tr>
            <tr>
                <td class="style11" colspan="1">
                                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="133px" 
                                    ValidationGroup="g" Height="31px" />
                </td>
                <td colspan="4" class="style3">
                &nbsp;
                                <asp:Button ID="btnVolveraLaTienda" runat="server" Text="Cancelar" 
                                    PostBackUrl="~/FormEnvio.aspx" Width="133px" Height="31px" />
                </td>
            </tr>
            <tr>
                <td class="style7" colspan="5">
                    &nbsp;<asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ValidationGroup="g" />
                </td>
            </tr>
        </table>
    
    </div>


</asp:Content>
