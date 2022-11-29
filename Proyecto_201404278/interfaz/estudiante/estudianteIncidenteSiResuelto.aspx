<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/estudiante/estudiante.Master" AutoEventWireup="true" CodeBehind="estudianteIncidenteSiResuelto.aspx.cs" Inherits="Proyecto_201404278.interfaz.estudianteIncidenteSiResuelto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">INCIDENTES RESUELTOS</h2>
    <br />
    <br />

     <asp:GridView ID="gvestudianteInsumo" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" HorizontalAlign="Center">
         <AlternatingRowStyle BackColor="#CCCCCC" />
         <FooterStyle BackColor="#CCCCCC" />
         <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
         <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
         <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
         <SortedAscendingCellStyle BackColor="#F1F1F1" />
         <SortedAscendingHeaderStyle BackColor="#808080" />
         <SortedDescendingCellStyle BackColor="#CAC9C9" />
         <SortedDescendingHeaderStyle BackColor="#383838" />
     </asp:GridView>
     <br />

</asp:Content>
