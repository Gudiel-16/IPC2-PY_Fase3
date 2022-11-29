<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/instructor/instructor.Master" AutoEventWireup="true" CodeBehind="instructorModificarCuestionario.aspx.cs" Inherits="Proyecto_201404278.interfaz.instructorModificarCuestionario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        
        <br />
    <br />
    .
    <br />
    <h2 style="text-align: center">MODIFICAR O ELIMINAR CUESTIONARIO</h2>
    <br />

    <div class="row col-md-offset-2" id="aa2">
        <div class="col-md-5">
             <label for="pwd">Ingrese Codigo de Curso para buscar:</label>
            
        </div>
        <br />
        <br />
      
        <div class="col-md-4">
           <div class="form-group">
                <label for="pwd">Codigo:</label>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtCodigobuscar" runat="server" Style="margin-left: 0px" Width="450px"></asp:TextBox> 
                <asp:Button ID="bttBuscar" runat="server" Text="BUSCAR" OnClick="bttBuscar_Click" />              
            </div>
        </div>        
    </div>

     <br/>
    <br />.
    <br />

    
    <div class="container col-md-6 col-lg-offset-2">
        
        <div>
            <label for="usr">CREAR CUESTIONARIO</label>
        </div>
        <br />
        <br />

        <div>
            <label for="usr">PREGUNTA 1:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtpregunta1" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">PREGUNTA 2:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtpregunta2" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />
        
        <div>
            <label for="pwd">PREGUNTA 3:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtpregunta3" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">PREGUNTA 4:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtpregunta4" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <label for="pwd">PREGUNTA 5:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtpregunta5" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <br />

        <asp:Button ID="bttmodificar" runat="server" Style="margin-left: 133px" Text="MODIFICAR" OnClick="bttmodificar_Click"/>
        <br />
        <asp:Button ID="btteliminar" runat="server" Style="margin-left: 133px" Text="ELIMINAR" OnClick="btteliminar_Click"/>

    </div>

</asp:Content>
