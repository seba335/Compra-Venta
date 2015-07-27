<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormDetalles.aspx.vb" Inherits="TpPaginaVentasPC.FormDetalles"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
            width: 687px;
        }
        .style5
        {
            width: 670px;
        }
        .style8
        {
            width: 993px;
            height: 49px;
        }
        .style9
        {
            width: 97px;
            height: 49px;
        }
        .style12
        {
            width: 224px;
            height: 161px;
        }
        .style13
        {
            width: 993px;
            height: 53px;
        }
        .style15
        {
            width: 97px;
            height: 53px;
        }
        .style16
        {
            width: 993px;
            height: 51px;
        }
        .style17
        {
            width: 97px;
            height: 51px;
        }
        .style32
        {
            width: 993px;
            height: 68px;
        }
        .style34
        {
            width: 97px;
            height: 68px;
        }
        .style38
        {
            width: 993px;
            height: 58px;
        }
        .style40
        {
            width: 97px;
            height: 58px;
        }
        .style41
        {
            width: 12px;
            height: 58px;
        }
        .style42
        {
            width: 12px;
            height: 68px;
        }
        .style45
        {
            width: 12px;
            height: 51px;
        }
        .style46
        {
            width: 12px;
            height: 53px;
        }
        .style47
        {
            width: 12px;
            height: 49px;
        }
        .style48
        {
            width: 993px;
            height: 55px;
        }
        .style49
        {
            width: 97px;
            height: 55px;
        }
        .style50
        {
            width: 12px;
            height: 55px;
        }
        .style51
        {
            width: 993px;
            height: 50px;
        }
        .style52
        {
            width: 97px;
            height: 50px;
        }
        .style53
        {
            width: 12px;
            height: 50px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width: 48%; height: 364px;">
            <tr>
                <td class="style38" height="6">
                    Modelo:<asp:Label ID="lblNombre" runat="server"></asp:Label>
                </td>
                <td class="style40">
                    &nbsp;</td>
                <td class="style41">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style32">
                    Procesador:<asp:Label ID="lblProcesador" runat="server"></asp:Label>
                </td>
                <td class="style34">
                    Placa de Video:<asp:Label ID="lblPlacadeVideo" runat="server"></asp:Label>
                    </td>
                <td class="style42">
                    </td>
            </tr>
            <tr>
                <td class="style51">
                    Disco:<asp:Label ID="lblDisco" runat="server"></asp:Label>
                </td>
                <td class="style52">
                    Cantidad de discos:<asp:Label ID="lblCantidadDisco" runat="server"></asp:Label>
                </td>
                <td class="style53">
                    </td>
            </tr>
            <tr>
                <td class="style48">
                    Fuente:<asp:Label ID="lblFuente" runat="server"></asp:Label>
                </td>
                <td class="style49">
                    Mother:<asp:Label ID="lblMother" runat="server"></asp:Label>
                    </td>
                <td class="style50">
                    </td>
            </tr>
            <tr>
                <td class="style16">
                    Memoria:<asp:Label ID="lblMemoria" runat="server"></asp:Label>
                </td>
                <td class="style17">
                    Cantidad de memorias:<asp:Label ID="lblCantidadMemoria" runat="server"></asp:Label>
                </td>
                <td class="style45">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style13">
                    Gabinete:<asp:Label ID="lblGabinete" runat="server"></asp:Label>
                </td>
                <td class="style15">
                    Lectora:<asp:Label ID="lblLectora" runat="server"></asp:Label>
                    </td>
                <td class="style46">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8">
                    Precio:<asp:Label ID="lblPrecio" runat="server"></asp:Label>
                </td>
                <td class="style9">
                    Cantidad:</td>
                <td class="style47">
                    <asp:DropDownList ID="ddlCantidad" runat="server">
                        <asp:ListItem Value="---">Seleccione</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="ddlCantidad" Display="Dynamic" 
                        ErrorMessage="Seleccione la cantidad deseada a comprar" ForeColor="Red" 
                        Operator="NotEqual" ValidationGroup="g" ValueToCompare="---">*</asp:CompareValidator>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" 
                        ControlToValidate="ddlCantidad" Display="Dynamic" 
                        ErrorMessage="Solo se permite reservar una computadora" ForeColor="Red" 
                        Type="Integer" ValidationGroup="r" ValueToCompare="1">*</asp:CompareValidator>
                    </td>
            </tr>
            </table>
        <table style="width:100%;">
            <tr>
                <td class="style3">
                    <asp:Button ID="btnAgregaraLaListadeCompras" runat="server" 
                        Text="Agregar a la lista de compras" Width="212px" ValidationGroup="g" 
                        Height="26px" />
                    <asp:Button ID="btnReservar" runat="server" Text="Reservar" Width="251px" 
                        ValidationGroup="r" Visible="False" />
                    <asp:Button ID="btnVolveraLaTienda" runat="server" Text="Volver a la tienda" 
                        Width="180px" PostBackUrl="~/FormClientePrincipalF.aspx" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" ValidationGroup="g" />
                    <asp:ValidationSummary ID="ValidationSummary2" runat="server" 
                        ValidationGroup="r" ShowMessageBox="True" />
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>
