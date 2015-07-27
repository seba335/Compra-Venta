<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Logueo.Master" CodeBehind="FormRegExitoso.aspx.vb" Inherits="TpPaginaVentasPC.FormRegExitoso"
theme="Skin1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 
  <table style="width: 100%;">
    <tr>
        <td>
         <h1>  <asp:Label ID="Label1" runat="server" Text="Su registro fue exitoso bienvenido a pc Planet ya esta listo para loguearse y disfrutar de la pagina lider en ventas"></asp:Label></h1>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td align ="center" >
            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" PostBackUrl="~/FormClientePrincipalF.aspx" />
            &nbsp;
        </td>
    </tr>
    </table>
</asp:Content>

