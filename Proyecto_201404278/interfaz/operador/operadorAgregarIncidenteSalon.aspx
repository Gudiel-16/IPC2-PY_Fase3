<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/operador/operador.Master" AutoEventWireup="true" CodeBehind="operadorAgregarIncidenteSalon.aspx.cs" Inherits="Proyecto_201404278.interfaz.operadorAgregarIncidenteSalon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">AGREGAR INCIDENTE DE SALON</h2>
    <br />

    <div class="row">
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Tipo:</label>
            </div>
            <div class="form-group">
                <select class="form-control" id="rolTipo" runat="server">
                    <option>Salon</option>
                </select>
            </div>
        </div>
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
                <label for="pwd">Resuelto:</label>
            </div>
            <div class="form-group">
                <select class="form-control" id="rolResuelto" runat="server">
                    <option>Si</option>
                    <option>No</option>
                </select>
            </div>
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <div class="form-group">
                <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                <br />
                <asp:TextBox ID="txtFecha" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
        </div>

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
                    <label for="pwd">Carnet Instructor:</label>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtCarnetInstructor" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
                </div>
            </div>
        </div>

    </div>

    <div class="row">
        <div class="col-md-4">
            <div class="form-group">
                <label for="pwd">Codigo Salon:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtCodigoSalon" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <div class="form-group">
                    <label for="pwd">Carnet De Quien Registra:</label>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtQuienRegistra" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="form-group">                
                <div class="form-group">
                    <asp:Button ID="bttAgregar" runat="server" Text="REGISTRAR" OnClick="bttAgregar_Click" />
                  </div>
            </div>
        </div>
    </div>

</asp:Content>
