<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormAdminZonas.aspx.vb" Inherits="TpPaginaVentasPC.FormAdminZonas"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .style7
        {
            height: 30px;
        }
        #Button6
        {
            width: 197px;
        }
        </style>
    <script language="javascript" type="text/javascript">
// <![CDATA[

        function Button7_onclick() {

        }

// ]]>
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width: 39%;">
            <tr>
                <td align="left" colspan="4">
                    <asp:Label ID="Label1" runat="server" Text="Zonas"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="left" class="style7" colspan="4">
                    <asp:Button ID="btnAgregarZona" runat="server" Text="Agregar zona" 
                        Height="26px" Width="123px" />
                </td>
            </tr>
            
            </table>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="Id" DataSourceID="SqlDataSource1" Width="320px" 
            BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" 
            CellPadding="3" CellSpacing="1" GridLines="None">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                    ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" 
                    SortExpression="Descripcion" />
                <asp:BoundField DataField="Costo" HeaderText="Costo" SortExpression="Costo" />
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
            SelectCommand="SELECT * FROM [Zonas]"></asp:SqlDataSource>
        <table style="width: 39%;">
            <tr>
                <td align="center">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" 
                        PostBackUrl="~/FormAdminPrncipal.aspx" style="margin-bottom: 0px" />
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>
