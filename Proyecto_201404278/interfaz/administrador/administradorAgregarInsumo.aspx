<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/administrador/administrador.Master" AutoEventWireup="true" CodeBehind="administradorAgregarInsumo.aspx.cs" Inherits="Proyecto_201404278.interfaz.administradorAgregarInsumo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <br />
    <br />
    .
    <br />
    <h2 style="text-align:center">AGREGAR INSUMO</h2>
     <br />
   
   
    <br />

    <div class="row" id="aa2">
        
        <div class="col-md-4 col-md-offset-1">
           <div class="form-group">
                <label for="pwd">Nombre o Descripcion:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtNombre" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
        </div>        
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Estado:</label>
            </div>
            <div class="form-group">
                <select class="form-control" id="rolEstado" runat="server">
                    <option>Disponible</option>
                    <option>Prestamo</option> 
                    <option>Incidente</option>             
                </select>
                <br />
                <asp:Button ID="bttAgregar" OnClick="bttbuscar_Click" runat="server" Style="margin-left: 10px" Text="AGREGAR"/>
            </div>
        </div>
    </div>

</asp:Content>
