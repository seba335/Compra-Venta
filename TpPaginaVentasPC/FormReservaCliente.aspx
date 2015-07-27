<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormReservaCliente.aspx.vb" Inherits="TpPaginaVentasPC.FormReservaCliente"
theme="Skin1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" Width="767px" 
        AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Modelo" HeaderText="Modelo" 
                SortExpression="Modelo" />
            <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
            <asp:BoundField DataField="Monto restante a pagar para concluir la reserva" 
                HeaderText="Monto restante a pagar para concluir la reserva" ReadOnly="True" 
                SortExpression="Monto restante a pagar para concluir la reserva" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
        SelectCommand="TraerReservaPorIdMostrar" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:SessionParameter Name="IdReserva" SessionField="ReservaSelec" 
                Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <table style="width:100%;">
        <tr>
            <td align ="center" >
                <asp:Button ID="Button1" runat="server" Text="Pagar monto restante" 
                    Width="177px" />   
                <asp:Button ID="Button2" runat="server" Text="Cancelar" Width="175px" 
                    PostBackUrl="~/FormClientePrincipalF.aspx" />
            </td>
        </tr>
    </table>
</asp:Content>
