<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormListadeReservas.aspx.vb" Inherits="TpPaginaVentasPC.FormListadeReservas"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width:100%; height: 183px;">
            <tr>
                <td align="center">
                    <asp:GridView ID="GridView1" runat="server" Height="107px" Width="483px" 
                        DataKeyNames ="numero de reserva" AutoGenerateColumns="False" 
                        DataSourceID="SqlDataSource1" BackColor="White" BorderColor="White" 
                        BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" 
                        GridLines="None"> 
                        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                        <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                        <SelectedRowStyle BackColor ="#9471DE" Font-Bold="True" ForeColor="White" /> 
                        <Columns>
                            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                            <asp:BoundField DataField="numero de reserva" HeaderText="numero de reserva" 
                                InsertVisible="False" ReadOnly="True" SortExpression="numero de reserva" />
                            <asp:BoundField DataField="numero de cliente" HeaderText="numero de cliente" 
                                SortExpression="numero de cliente" />
                            <asp:BoundField DataField="Nombre del cliente" HeaderText="Nombre del cliente" 
                                SortExpression="Nombre del cliente" ReadOnly="True" />
                            <asp:BoundField DataField="modelo" HeaderText="modelo" 
                                SortExpression="modelo" />
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha" 
                                SortExpression="Fecha" />
                            <asp:BoundField DataField="Estado" HeaderText="Estado" 
                                SortExpression="Estado" />
                        </Columns>
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#594B9C" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#33276A" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
                        SelectCommand="TraerReservas" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="DropDownList1" ErrorMessage="Seleccione un estado" 
                        ForeColor="Red" Operator="NotEqual" ValueToCompare="Seleccione" 
                        ValidationGroup="g">*</asp:CompareValidator>
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="132px" 
                        ValidationGroup="g" />
                    <asp:Button ID="BtnCancelar" runat="server" Height="26px" 
                        PostBackUrl="~/FormEmpVentPrincipal.aspx" Text="Cancelar" Width="122px" />
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ValidationGroup="g" />
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>
