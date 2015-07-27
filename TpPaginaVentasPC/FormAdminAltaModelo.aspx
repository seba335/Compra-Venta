<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormAdminAltaModelo.aspx.vb" Inherits="TpPaginaVentasPC.FormAdminAltaModelo"
theme="Skin1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">


        .style5
        {
            width: 107px;
            height: 30px;
        }
        .style6
        {
            width: 125px;
            height: 30px;
        }
        #Text2
        {
            width: 459px;
        }
        .style7
        {
            width: 90px;
            height: 30px;
        }
        #Text1
        {
            width: 454px;
        }
        #Text3
        {
            width: 452px;
        }
        #Text4
        {
            width: 449px;
        }
        #Select4
        {
            width: 45px;
        }
        #Text5
        {
            width: 455px;
        }
        #Text6
        {
            width: 444px;
        }
        #Text7
        {
            width: 453px;
        }
        #Select5
        {
            width: 45px;
        }
        #Text8
        {
            width: 450px;
        }
        #Text9
        {
            width: 448px;
        }
        #Text10
        {
            width: 449px;
        }
        #Select3
        {
            width: 47px;
        }
        #Select3
        {
            width: 51px;
        }
        #Select1
        {
            width: 47px;
        }
        #Select2
        {
            width: 49px;
        }
        .style11
        {
            width: 107px;
            height: 52px;
        }
        .style12
        {
            width: 125px;
            height: 52px;
        }
        .style13
        {
            width: 90px;
            height: 52px;
        }
        .style32
        {
            height: 30px;
        }
        .style33
        {
            height: 52px;
        }
        .style36
        {
            width: 107px;
            height: 75px;
        }
        .style37
        {
            width: 125px;
            height: 75px;
        }
        .style38
        {
            height: 75px;
        }
        .style39
        {
            width: 90px;
            height: 75px;
        }
        .style41
        {
            width: 107px;
            height: 44px;
        }
        .style42
        {
            width: 125px;
            height: 44px;
        }
        .style43
        {
            height: 44px;
        }
        .style44
        {
            width: 90px;
            height: 44px;
        }
        .style46
        {
            width: 107px;
            height: 32px;
        }
        .style47
        {
            width: 125px;
            height: 32px;
        }
        .style48
        {
            height: 32px;
        }
        .style49
        {
            width: 90px;
            height: 32px;
        }
        .style61
        {
            width: 107px;
            height: 35px;
        }
        .style62
        {
            width: 125px;
            height: 35px;
        }
        .style63
        {
            height: 35px;
        }
        .style64
        {
            width: 90px;
            height: 35px;
        }
        .style66
        {
            width: 107px;
            height: 49px;
        }
        .style67
        {
            width: 125px;
            height: 49px;
        }
        .style68
        {
            height: 49px;
        }
        .style69
        {
            width: 90px;
            height: 49px;
        }
        .style81
        {
            width: 107px;
            height: 50px;
        }
        .style82
        {
            width: 125px;
            height: 50px;
        }
        .style83
        {
            height: 50px;
        }
        .style84
        {
            width: 90px;
            height: 50px;
        }
        .style87
        {
            width: 107px;
            height: 47px;
        }
        .style88
        {
            width: 125px;
            height: 47px;
        }
        .style89
        {
            height: 47px;
        }
        .style90
        {
            width: 90px;
            height: 47px;
        }
        .style91
        {
            width: 107px;
            height: 27px;
        }
        .style92
        {
            width: 125px;
            height: 27px;
        }
        .style93
        {
            height: 27px;
        }
        .style94
        {
            width: 90px;
            height: 27px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <table style="width: 93%; height: 868px;">
            <tr>
                <td class="style61">
                    </td>
                <td align="left" class="style62">
                    <asp:Label ID="Label1" runat="server" Text="Nuevo modelo"></asp:Label>
                </td>
                <td class="style63">
                    </td>
                <td class="style64">
                    </td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="Label2" runat="server" Text="Modelo:"></asp:Label>
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtModelo" runat="server" Width="180px" Height="22px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtModelo" Display="Dynamic" 
                        ErrorMessage="Ingrese nombre del modelo" ForeColor="Red" ValidationGroup="g">*</asp:RequiredFieldValidator>
                </td>
                <td class="style32">
                    <asp:Label ID="Label3" runat="server" Text="Procesador:"></asp:Label>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
                        SelectCommand="SELECT * FROM [Piezas] WHERE ([Tipo] = @Tipo)">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="Procesador" Name="Tipo" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
                <td class="style7">
                    <asp:DropDownList ID="ddlProcesador" runat="server" 
                        DataSourceID="SqlDataSource1" DataTextField="Descripcion" 
                        DataValueField="Id">
                        <asp:ListItem Value="---">Seleccione</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator7" runat="server" 
                        ControlToValidate="ddlProcesador" Display="Dynamic" 
                        ErrorMessage="Seleccione un procesador" ForeColor="Red" Operator="NotEqual" 
                        ValidationGroup="g" ValueToCompare="---">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style36">
                    <asp:Label ID="Label4" runat="server" Text="Placa de video:"></asp:Label>
                </td>
                <td class="style37">
                    <asp:DropDownList ID="ddlPlacadeVideo" runat="server" 
                        DataSourceID="SqlDataSource2" DataTextField="Descripcion" 
                        DataValueField="Id">
                        <asp:ListItem Value="---">Seleccione</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator8" runat="server" 
                        ControlToValidate="ddlPlacadeVideo" Display="Dynamic" 
                        ErrorMessage="Seleccione una placa de video" ForeColor="Red" 
                        Operator="NotEqual" ValidationGroup="g" ValueToCompare="---">*</asp:CompareValidator>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
                        SelectCommand="SELECT * FROM [Piezas] WHERE ([Tipo] = @Tipo)">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="PlacaDeVideo" Name="Tipo" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
                <td class="style38">
                    <asp:Label ID="Label5" runat="server" Text="Disco:"></asp:Label>
                </td>
                <td class="style39">
                    <asp:DropDownList ID="ddlDisco" runat="server" 
                        DataSourceID="SqlDataSource3" DataTextField="Descripcion" 
                        DataValueField="Id">
                        <asp:ListItem Value="---">Seleccione</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator9" runat="server" 
                        ControlToValidate="ddlDisco" Display="Dynamic" 
                        ErrorMessage="Seleccione un disco" ForeColor="Red" Operator="NotEqual" 
                        ValidationGroup="g" ValueToCompare="---">*</asp:CompareValidator>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
                        SelectCommand="SELECT * FROM [Piezas] WHERE ([Tipo] = @Tipo)">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="Disco" Name="Tipo" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="style91">
                </td>
                <td class="style92">
                </td>
                <td class="style93">
                    <asp:Label ID="Label14" runat="server" Text="Cantidad de discos"></asp:Label>
                    <asp:DropDownList ID="ddlDiscoCantidad" runat="server">
                        <asp:ListItem Value="---">Seleccione</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" 
                        ControlToValidate="ddlDiscoCantidad" Display="Dynamic" 
                        ErrorMessage="Seleccione cantidad de discos" ForeColor="Red" 
                        Operator="NotEqual" ValidationGroup="g" ValueToCompare="---">*</asp:CompareValidator>
                </td>
                <td class="style94">
                </td>
            </tr>
            <tr>
                <td class="style36">
                    <asp:Label ID="Label6" runat="server" Text="Fuente:"></asp:Label>
                </td>
                <td class="style37">
                    <asp:DropDownList ID="ddlFuente" runat="server" 
                        DataSourceID="SqlDataSource4" DataTextField="Descripcion" 
                        DataValueField="Id">
                        <asp:ListItem Value="---">Seleccione</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator10" runat="server" 
                        ControlToValidate="ddlFuente" Display="Dynamic" 
                        ErrorMessage="Seleccione una fuente" ForeColor="Red" Operator="NotEqual" 
                        ValidationGroup="g" ValueToCompare="---">*</asp:CompareValidator>
                    <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
                        SelectCommand="SELECT * FROM [Piezas] WHERE ([Tipo] = @Tipo)">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="Fuente" Name="Tipo" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
                <td class="style38">
                    <asp:Label ID="Label7" runat="server" Text="Mother:"></asp:Label>
                    <asp:SqlDataSource ID="SqlDataSource5" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
                        SelectCommand="SELECT * FROM [Piezas] WHERE ([Tipo] = @Tipo)">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="Mother" Name="Tipo" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
                <td class="style39">
                    <asp:DropDownList ID="ddlMother" runat="server" 
                        DataSourceID="SqlDataSource5" DataTextField="Descripcion" 
                        DataValueField="Id">
                        <asp:ListItem Value="---">Seleccione</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator11" runat="server" 
                        ControlToValidate="ddlMother" Display="Dynamic" 
                        ErrorMessage="Seleccione un mother" ForeColor="Red" Operator="NotEqual" 
                        ValidationGroup="g" ValueToCompare="---">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style11">
                    <asp:Label ID="Label8" runat="server" Text="Memoria:"></asp:Label>
                </td>
                <td class="style12">
                    <asp:DropDownList ID="ddlMemoria" runat="server" 
                        DataSourceID="SqlDataSource6" DataTextField="Descripcion" 
                        DataValueField="Id">
                        <asp:ListItem Value="---">Seleccione</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator12" runat="server" 
                        ControlToValidate="ddlMemoria" Display="Dynamic" 
                        ErrorMessage="Seleccione una memoria" ForeColor="Red" Operator="NotEqual" 
                        ValidationGroup="g" ValueToCompare="---">*</asp:CompareValidator>
                    <asp:SqlDataSource ID="SqlDataSource6" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
                        SelectCommand="SELECT * FROM [Piezas] WHERE ([Tipo] = @Tipo)">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="Memoria" Name="Tipo" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
                <td class="style33">
                    <asp:Label ID="Label15" runat="server" Text="Cantidad de memorias:"></asp:Label>
                    <asp:DropDownList ID="ddlMemoriaCantidad" runat="server">
                        <asp:ListItem Value="---">Seleccione</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator3" runat="server" 
                        ControlToValidate="ddlMemoriaCantidad" Display="Dynamic" 
                        ErrorMessage="Seleccione cantidad de memorias" ForeColor="Red" 
                        Operator="NotEqual" ValidationGroup="g" ValueToCompare="---">*</asp:CompareValidator>
                </td>
                <td class="style13">
                </td>
            </tr>
            <tr>
                <td class="style81">
                    <asp:Label ID="Label10" runat="server" Text="Lectora:"></asp:Label>
                </td>
                <td class="style82">
                    <asp:DropDownList ID="ddlLectora" runat="server" 
                        DataSourceID="SqlDataSource8" DataTextField="Descripcion" 
                        DataValueField="Id">
                        <asp:ListItem Value="---">Seleccione</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator14" runat="server" 
                        ControlToValidate="ddlLectora" Display="Dynamic" 
                        ErrorMessage="Seleccione una lectora" ForeColor="Red" Operator="NotEqual" 
                        ValidationGroup="g" ValueToCompare="---">*</asp:CompareValidator>
                    <asp:SqlDataSource ID="SqlDataSource8" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
                        SelectCommand="SELECT * FROM [Piezas] WHERE ([Tipo] = @Tipo)">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="Lectora" Name="Tipo" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
                <td class="style83">
                    <asp:Label ID="Label9" runat="server" Text="Gabinete:"></asp:Label>
                    <asp:SqlDataSource ID="SqlDataSource7" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:CompraVentaComputadorasConnectionString %>" 
                        SelectCommand="SELECT * FROM [Piezas] WHERE ([Tipo] = @Tipo)">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="Gabinete" Name="Tipo" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
                <td class="style84">
                    <asp:DropDownList ID="ddlGabinete" runat="server" 
                        DataSourceID="SqlDataSource7" DataTextField="Descripcion" 
                        DataValueField="Id">
                        <asp:ListItem Value="---">Seleccione</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator13" runat="server" 
                        ControlToValidate="ddlGabinete" Display="Dynamic" 
                        ErrorMessage="Seleccione un gabinete" ForeColor="Red" Operator="NotEqual" 
                        ValidationGroup="g" ValueToCompare="---">*</asp:CompareValidator>
                    </td>
            </tr>
            <tr>
                <td class="style46">
                    <asp:Label ID="Label11" runat="server" Text="Precio:"></asp:Label>
                </td>
                <td class="style47">
                    <asp:TextBox ID="txtPrecio" runat="server" Width="176px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtPrecio" Display="Dynamic" 
                        ErrorMessage="Debe ingresar un precio" ForeColor="Red" ValidationGroup="g">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="txtPrecio" Display="Dynamic" 
                        ErrorMessage="El precio debe ser numerico" ForeColor="Red" 
                        Operator="DataTypeCheck" Type="Double" ValidationGroup="g">*</asp:CompareValidator>
                </td>
                <td class="style48">
                    </td>
                <td class="style49">
                    </td>
            </tr>
            <tr>
                <td class="style66">
                    <asp:Label ID="Label12" runat="server" Text="Minimo:"></asp:Label>
                </td>
                <td class="style67">
                    <asp:DropDownList ID="ddlMinimo" runat="server">
                        <asp:ListItem Value="---">Seleccione</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator4" runat="server" 
                        ControlToValidate="ddlMinimo" Display="Dynamic" 
                        ErrorMessage="Seleccione un minimo" ForeColor="Red" Operator="NotEqual" 
                        ValidationGroup="g" ValueToCompare="---">*</asp:CompareValidator>
                    <asp:CompareValidator ID="CompareValidator6" runat="server" 
                        ControlToCompare="ddlMaximo" ControlToValidate="ddlMinimo" Display="Dynamic" 
                        ErrorMessage="El minimo no puede ser ni igual ni mayor al maximo" 
                        ForeColor="Red" Operator="LessThan" Type="Integer" ValidationGroup="g">*</asp:CompareValidator>
                </td>
                <td class="style68">
                    <asp:Label ID="Label13" runat="server" Text="Maximo:"></asp:Label>
                    <asp:DropDownList ID="ddlMaximo" runat="server">
                        <asp:ListItem Value="---">Seleccione</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator5" runat="server" 
                        ControlToValidate="ddlMaximo" Display="Dynamic" 
                        ErrorMessage="Seleccione un maximo" ForeColor="Red" Operator="NotEqual" 
                        ValidationGroup="g" ValueToCompare="---">*</asp:CompareValidator>
                </td>
                <td class="style69">
                    </td>
            </tr>
            <tr>
                <td class="style41">
                    <asp:Label ID="Label16" runat="server" Text="Imagen"></asp:Label>
                </td>
                <td class="style42">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
                <td class="style43">
                    <asp:Button ID="btnVerFoto" runat="server" Text="Cargar imagen" Width="115px" />
                    <asp:CustomValidator ID="CustomValidator1" runat="server" Display="Dynamic" 
                        ErrorMessage="Debe añadir una imagen al modelo" ForeColor="Red" 
                        ClientValidationFunction="valFoto" ValidationGroup="g" >*</asp:CustomValidator>
                </td>
                <td class="style44">
                    <asp:Image ID="Image1" runat="server" Height="116px" Width="121px" />
                </td>
                <td class="style43">
                    </td>
            </tr>
            <tr>
                <td class="style87">
                    &nbsp;</td>
                <td align="center" class="style88">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" ValidationGroup="g" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
                        PostBackUrl="~/FormAdminModelos.aspx" />
                </td>
                <td class="style89">
                    &nbsp;</td>
                <td class="style90">
                    </td>
            </tr>
            <tr>
                <td class="style87">
                    &nbsp;</td>
                <td align="center" class="style88">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ValidationGroup="g" Height="45px" ShowMessageBox="True" Width="398px" />
                </td>
                <td class="style90">
                    &nbsp;</td>
            </tr>
            <tr>
                <td  colspan ="5">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
</asp:Content>
