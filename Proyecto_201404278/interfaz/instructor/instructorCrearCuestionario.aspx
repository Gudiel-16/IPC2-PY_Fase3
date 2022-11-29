<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/instructor/instructor.Master" AutoEventWireup="true" CodeBehind="instructorCrearCuestionario.aspx.cs" Inherits="Proyecto_201404278.interfaz.instructorCrearCuestionario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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

        <div>
            <label for="pwd">Codigo de Curso:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtcodigocurso" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <asp:Button ID="bttCrear" OnClick="bttRegistrar_Click" runat="server" Style="margin-left: 133px" Text="REGISTRAR"/>

    </div>

</asp:Content>
