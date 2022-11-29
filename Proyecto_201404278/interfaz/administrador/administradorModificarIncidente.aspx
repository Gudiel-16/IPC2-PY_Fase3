<%@ Page Title="" StylesheetTheme="administrador" Language="C#" MasterPageFile="~/interfaz/administrador/administrador.Master" AutoEventWireup="true" CodeBehind="administradorModificarIncidente.aspx.cs" Inherits="Proyecto_201404278.interfaz.administradorModificarIncidente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
        <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">MODIFICAR INCIDENTE</h2>
    <br />

    <div class="row" id="aa2">
        <div class="col-md-5">
             <label for="pwd">Ingrese Codigo de Incidente y seleccione para buscar:</label>
        </div>
        <br />
        <br />
      
        <div class="col-md-4">
           <div class="form-group">
                <label for="pwd">Codigo:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtCodigobuscar" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>               
            </div>
        </div>
         <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Tipo de Usuario:</label>
            </div>
            <div class="form-group">
                <select class="form-control" id="rolUsuario" runat="server">
                    <option>Instructor</option>
                    <option>Estudiante</option>
                </select>
            </div>
        </div>
          <div class="col-md-4">
            <div class="form-group" >
                <div class="form-group">
                <label for="pwd">Tipo de Incidente:</label>
            </div>
                    <select class="form-control" id="rolTipo" runat="server">
                        <option>Insumo</option>
                        <option>Salon</option>
                    </select>
                </div>
        </div>      
    </div>

  <div class="row text-center">
            <div class="form-group">
                <div class="form-group">
                     <asp:Button ID="bttBuscar" runat="server" Style="margin-left: 10px" Text="BUSCAR" OnClick="bttBuscar_Click"/>
                </div>
            </div>
        </div>

    <div class="row">
       <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Descripcion:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtDescripcion" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Muestra si esta resuelto, segun incidente que busco:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtResuelto" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="pwd">Si desea modificar seleccione Si esta Resuelto:</label>
            </div>
            <div class="form-group">
                <select class="form-control" id="rolResuelto" runat="server">
                    <option>Si</option>
                    <option>No</option>
                </select>
            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Fecha:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtFecha" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
        </div>
    </div>
 

    <div class="row">
         <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Hora:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtHora" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <div class="form-group">
                    <label for="pwd">Carnet de Usuario:</label>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtcarnetUsuario" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Codigo Insumo o Salon:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtCodigoInsumoSalon" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
        </div>
        </div>

        <div class="row text-center">
            <div class="form-group">
                <div class="form-group">
                    <asp:Button ID="bttModificar" runat="server" Text="MODIFICAR" OnClick="bttModificar_Click" />
                </div>
            </div>
        </div>


</asp:Content>
