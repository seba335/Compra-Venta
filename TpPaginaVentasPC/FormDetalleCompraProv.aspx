<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormDetalleCompraProv.aspx.vb" Inherits="TpPaginaVentasPC.FormDetalleCompraProv"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .style1
        {
            height: 23px;
        }
        .style4
        {
            width: 187px;
            height: 56px;
        }
        .style5
        {
            width: 499px;
            height: 56px;
        }
        #Select2
        {
            width: 159px;
        }
        .style6
        {
            height: 56px;
        }
        #Button1
        {
            margin-left: 0px;
        }
        #Button2
        {
            width: 134px;
            margin-bottom: 0px;
        }
        #Button3
        {
            width: 130px;
            margin-left: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td align="center">
                    <asp:Label ID="Label1" runat="server" Text="Lista de compras"></asp:Label>
                </td>
            </tr>
            </table>
        <asp:GridView ID="GridView1" runat="server" Width="815px" BackColor="White" 
            BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" 
            CellSpacing="1" GridLines="None">
        
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
        
        <SelectedRowStyle BackColor ="#9471DE" Font-Bold="True" ForeColor="White" /> 
        
            <Columns>
                <asp:CommandField ButtonType="Button" ShowSelectButton="True"  />

            <asp:TemplateField HeaderText="Costo">
            <ItemTemplate >
                <asp:TextBox ID="TextBox1" runat="server" 
                Text='<%# Eval("Costo") %>'></asp:TextBox>
            </ItemTemplate>
            </asp:TemplateField>
            </Columns>
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
        <table style="width:100%;">
            <tr>
                <td class="style4">
                    <asp:Label ID="Label2" runat="server" Text="Seleccione proveedor"></asp:Label>
                </td>
                <td class="style5">
                    <asp:DropDownList ID="ddlProveedores" runat="server" Height="19px" 
                        Width="166px" DataSourceID="SqlDataSource1" DataTextField="Apellido" 
                        DataValueField="Id">
                    </asp:DropDownList>
                    <asp:Button ID="btnNuevoProveedor" runat="server" Text="Nuevo proveedor" 
                        PostBackUrl="~/FormAltaProv.aspx" Height="26px" />
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
                        SelectCommand="SELECT * FROM [Proveedores]"></asp:SqlDataSource>
                </td>
                <td class="style6">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="132px" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="133px" 
                        PostBackUrl="~/FormListadeComprasaProv.aspx" />
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>
