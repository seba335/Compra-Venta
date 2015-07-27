<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormAdminLocalidades.aspx.vb" Inherits="TpPaginaVentasPC.FormAdminLocalidades" Theme ="Skin1"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width: 100%;">
            <tr>
                <td align="left">
                    <asp:Label ID="Label1" runat="server" Text="Localidades"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="left">
                    <asp:Button ID="btnLocalidad" runat="server" Text="Agregar localidad" 
                        PostBackUrl="~/FormAdminAltaLocalidad.aspx" />
                </td>
            </tr>
            </table>
        <asp:GridView ID="GridView1" runat="server" Width="699px" 
            AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                    SortExpression="Nombre" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" 
                    SortExpression="Descripcion" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString2 %>" 
            SelectCommand="TraerLocalidades" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        <table style="width: 100%;">
            <tr>
                <td align="center" class="style2">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" 
                        PostBackUrl="~/FormAdminPrncipal.aspx" />
                </td>
            </tr>
        </table>
    
    </div>
    </asp:Content>
