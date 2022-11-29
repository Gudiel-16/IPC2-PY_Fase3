<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/operador/operador.Master" AutoEventWireup="true" CodeBehind="operadorEliminarInsumo.aspx.cs" Inherits="Proyecto_201404278.interfaz.operadorEliminarInsumo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <br />
    <br />
    .
    <br />
    <h2 style="text-align:center">ELIMINAR INSUMO</h2>
     <br />
   
   
    <br />

    <div class="row" id="aa2">
        
        <div class="col-md-4 col-md-offset-1">
           <div class="form-group">
                <label for="pwd">Ingrese codigo de insumo a eliminar:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtCodigo" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
        </div>        
        <div class="col-md-4">
            <asp:Button ID="bttEliminar" OnClick="btteliminar_Click" runat="server" Style="margin-left: 10px" Text="ELIMINAR"/>
    </div>

</asp:Content>
