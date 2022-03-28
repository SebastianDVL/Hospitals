<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pacientes.aspx.cs" Inherits="Ospital.pacientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="estilos.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <div class="container-fluid back">
        <div class="row h-100">
            
         <div class="col h-100 d-flex flex-column p-5 justify-content-between left">
            
              <img src="img/humberriver.png" class="img-fluid w-100 h-25"/>
             <h3 class="ms-4 fst-italic fw-light">The heart of your healthcare.<br />
                The Highest Quality Healthcare.<br />
                The Hospital of the Future, Today.<br />
                The hospital you trust to care for those you love.<br />
                 A century ago, we made a commitment. We’ve kept it.<br />
                    A family of hospitals for your family.<br />
                    A heritage in care. A reputation in excellence.<br />
                    A higher level of care.
             </h3>

           </div>
         <div class="col h-100 col-5 p-5 text-white side">
             <form class="mx-auto w-75" runat="server">
                    <h2 class="fw-bolder text-info">Registrar Paciente</h2>
                    <div class="row row-cols-1 g-5 mt-1">
                        <div class="col">
                            <asp:Label ID="lblPaciente" CssClass="form-label" runat="server" Text="ID Paciente:"></asp:Label>
                            <asp:TextBox ID="txtIdPaciente" CssClass="form-control" runat="server" type="number"></asp:TextBox>
                            <asp:Label ID="lblPac" CssClass="form-label" runat="server" Text=""></asp:Label>

                        </div>
                         <div class="col">
                            <asp:Label ID="lblTipo" CssClass="form-label" runat="server" Text="Tipo ID:"></asp:Label>
                            <asp:TextBox ID="txtTipo" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="col">
                            <asp:Label ID="lblNombrePaciente" CssClass="form-label" runat="server" Text="Nombre:"></asp:Label>
                            <asp:TextBox ID="txtNombrePaciente" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                         <div class="col">
                            <asp:Label ID="lblDir" CssClass="form-label" runat="server" Text="Direccion:"></asp:Label>
                            <asp:TextBox ID="txtDir" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
        
                        <div class="col">
                            <asp:Label ID="lblTelefono" CssClass="form-label" runat="server" Text="Telefono:"></asp:Label>
                            <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server" type="number"></asp:TextBox>
                        </div>
                         <div class="col">
                            <asp:Label ID="lblCelular" CssClass="form-label" runat="server" Text="Celular:"></asp:Label>
                            <asp:TextBox ID="txtCelular" CssClass="form-control" runat="server" type="number"></asp:TextBox>
                        </div>
                        <div class="col d-flex">
                            <asp:Button ID="btLimpiarPaciente" runat="server" Cssclass="btn btn-outline-info me-2 text-white fw-bold" Text="Limpiar" OnClick="btLimpiarPaciente_Click" />
                                                        <asp:Button ID="btConsultarPaciente" runat="server" Cssclass="btn btn-outline-info me-2 text-white fw-bold" Text="Consultar" OnClick="btConsultarPaciente_Click" />
                            <asp:Button ID="btIngresarPaciente" runat="server" Cssclass="btn btn-outline-info text-white fw-bold" Text="Registrar Paciente" OnClick="btIngresarPaciente_Click" />
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
<script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
