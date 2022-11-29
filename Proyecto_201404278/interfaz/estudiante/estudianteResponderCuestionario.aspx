<%@ Page Title="" Language="C#" MasterPageFile="~/interfaz/estudiante/estudiante.Master" AutoEventWireup="true" CodeBehind="estudianteResponderCuestionario.aspx.cs" Inherits="Proyecto_201404278.interfaz.estudianteResponderCuestionario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <br/>
    <br />.
    <br />

    
    <div class="container col-md-7 col-lg-offset-2">
        
        <div>
            <label for="usr">RESPONDER CUESTIONARIO</label>
        </div>
        <br />
        <br />

        <div>
            <label for="usr">Ingrese codigo de Curso:</label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtCodigoCurso" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
            <asp:Button ID="bttBuscar" runat="server" Text="BUSCAR" OnClick="bttBuscar_Click" />
        </div>
        <br />
        <div>
            <asp:Label ID="Label1" runat="server" Text="PREGUNTA 1"></asp:Label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtpregunta1" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <asp:Label ID="Label2" runat="server" Text="PREGUNTA 2"></asp:Label>  
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtpregunta2" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />
        
        <div>
             <asp:Label ID="Label3" runat="server" Text="PREGUNTA 3"></asp:Label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtpregunta3" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
            <asp:Label ID="Label4" runat="server" Text="PREGUNTA 4"></asp:Label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtpregunta4" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <div>
             <asp:Label ID="Label5" runat="server" Text="PREGUNTA 5"></asp:Label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="txtpregunta5" runat="server" Style="margin-left: 101px" Width="400px"></asp:TextBox>
        </div>
        <br />

        <asp:Button ID="bttCrear" OnClick="bttRegistrar_Click" runat="server" Style="margin-left: 133px" Text="REGISTRAR"/>

    </div>

</asp:Content>
