<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormDetalleVenta.aspx.vb" Inherits="TpPaginaVentasPC.FormDetalleVenta"
theme="Skin1" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
            width: 124px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table style="width: 100%;">
            <tr>
                <td align ="center" >
                    &nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Detalle de Venta"></asp:Label>
                </td>
            </tr>
            </table>
        <asp:GridView ID="GridView1" runat="server" Width="825px" 
            DataSourceID="SqlDataSource1">
        </asp:GridView>

        <table style="width:100%; height: 253px; margin-bottom: 2px;">
            <tr>
                <td class="style3">
                    <asp:Label ID="Label20" runat="server" Text="Estado de la venta: "></asp:Label>
                </td>
                <td class="style16">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Pedido</asp:ListItem>
                        <asp:ListItem>Retirado</asp:ListItem>
                        <asp:ListItem>Cancelado</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label6" runat="server" Text="Monto de pago:"></asp:Label>
                </td>
                <td class="style16">
                    <asp:Label ID="lblMonto" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" class="style24" colspan="2">
                    <asp:Label ID="lblEnvio" runat="server" Text="Datos de envio" Visible="False"></asp:Label>
                </td>
            </tr>
            </table>
        <asp:GridView ID="GridView2" runat="server" Width="821px" 
            AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:BoundField DataField="Calle" HeaderText="Calle" SortExpression="Calle" />
                <asp:BoundField DataField="Numero" HeaderText="Numero" 
                    SortExpression="Numero" />
                <asp:BoundField DataField="Piso" HeaderText="Piso" SortExpression="Piso" />
                <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                    SortExpression="Departamento" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" 
                    SortExpression="Telefono" />
                <asp:BoundField DataField="Localidad" HeaderText="Localidad" 
                    SortExpression="Localidad" />
            </Columns>
        </asp:GridView>
        <table style="width: 100%;">
            <tr>
                <td align ="center" >
                    <asp:Label ID="Label21" runat="server" Text="Pagos"></asp:Label>
                    &nbsp;
                </td>
            </tr>
            </table>
        <asp:GridView ID="GridView3" runat="server" Width="815px" 
            AutoGenerateColumns="False" DataSourceID="SqlDataSource3">
            <Columns>
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                <asp:BoundField DataField="Monto" HeaderText="Monto" SortExpression="Monto" />
                <asp:BoundField DataField="Tipo" HeaderText="Tipo" SortExpression="Tipo" />
            </Columns>
        </asp:GridView>
        <table style="width: 100%;">
            <tr>
                <td align ="center" >
                    <asp:Button ID="Button1" runat="server" Text="Aceptar" />
                    &nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Cancelar" 
                        PostBackUrl="~/FormVentas.aspx" />
                </td>
            </tr>
            </table>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
            SelectCommand="TraetModeloVentasConIdVenta" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter Name="IdVenta" SessionField="VentaSeleccionada" 
                    Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
            SelectCommand="TraerEnvioPorVenta" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter Name="IdVenta" SessionField="VentaSeleccionada" 
                    Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
            ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
            SelectCommand="TraerPagosPorVenta" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter Name="IdVenta" SessionField="VentaSeleccionada" 
                    Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
</asp:Content>
