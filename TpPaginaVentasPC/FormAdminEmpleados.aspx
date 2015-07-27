<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormAdminEmpleados.aspx.vb" Inherits="TpPaginaVentasPC.FormAdminEmpleados"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Empleados"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button6" runat="server" Text="Nuevo empleado" 
                        PostBackUrl="~/FormAdminAltaEmpleado.aspx" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        
    
    </div>
    <asp:GridView ID="GridView1" runat="server" Width="716px" 
        AutoGenerateColumns="False" DataKeyNames="Legajo" 
        DataSourceID="SqlDataSource1" BackColor="White" BorderColor="White" 
        BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" 
        GridLines="None">
        <Columns>
            <asp:BoundField DataField="Legajo" HeaderText="Legajo" InsertVisible="False" 
                ReadOnly="True" SortExpression="Legajo" />
            <asp:BoundField DataField="Usuario" HeaderText="Usuario" 
                SortExpression="Usuario" />
            <asp:BoundField DataField="Telefono" HeaderText="Telefono" 
                SortExpression="Telefono" />
            <asp:BoundField DataField="Calle" HeaderText="Calle" 
                SortExpression="Calle" />
            <asp:BoundField DataField="Tipo" HeaderText="Tipo" SortExpression="Tipo" />
            <asp:BoundField DataField="Numero" HeaderText="Numero" 
                SortExpression="Numero" />
            <asp:CheckBoxField DataField="Activo" HeaderText="Activo" 
                SortExpression="Activo" />
            <asp:BoundField DataField="EstadoCivil" HeaderText="EstadoCivil" 
                SortExpression="EstadoCivil" />
            <asp:BoundField DataField="Apellido" HeaderText="Apellido" 
                SortExpression="Apellido" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                SortExpression="Nombre" />
            <asp:BoundField DataField="Departamento" HeaderText="Departamento" 
                SortExpression="Departamento" />
            <asp:BoundField DataField="Piso" HeaderText="Piso" 
                SortExpression="Piso" />
            <asp:CommandField ButtonType="Button" SelectText="Modificar" 
                ShowSelectButton="True" />
        </Columns>
        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#594B9C" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#33276A" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
        SelectCommand="SELECT [Legajo], [Usuario], [Telefono], [Calle], [Tipo], [Numero], [Activo], [EstadoCivil], [Apellido], [Nombre], [Departamento], [Piso] FROM [Empleados] ORDER BY [Activo] DESC, [Nombre]"></asp:SqlDataSource>
    <table style="width:100%;">
        <tr>
            <td align ="center" >
                <asp:Button ID="Button11" runat="server" PostBackUrl="~/FormAdminPrncipal.aspx" 
                    Text="Salir" Width="94px" />
            </td>
        </tr>
    </table>
</asp:Content>