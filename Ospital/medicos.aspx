<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="medicos.aspx.cs" Inherits="Ospital.medicos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="estilos.css" rel="stylesheet" />
    <title>Hospital | Medicos</title>
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
                    <h2 class="fw-bolder text-info">Registrar Medico</h2>
                    <div class="row row-cols-1 g-5 mt-1">
                        <div class="col">
                            <asp:Label ID="lblIdMedico" CssClass="form-label" runat="server" Text="ID Medico:"></asp:Label>
                            <asp:TextBox ID="txtIdMedico" CssClass="form-control" runat="server" type="number"></asp:TextBox>
                              <asp:Label ID="lblIdent" CssClass="form-label" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="col">
                            <asp:Label ID="lblNombre" CssClass="form-label" runat="server" Text="Nombre:"></asp:Label>
                        <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox></div>
                        <div class="col">
                            <asp:Label ID="lblEspecialidad" CssClass="form-label" runat="server" Text="Especialidad:"></asp:Label>
                            <asp:TextBox ID="txtEspecialidad" CssClass="form-control" runat="server"></asp:TextBox></div>
                        <div class="col">
                            <asp:Label ID="lblTelefono" CssClass="form-label" runat="server" Text="Telefono:"></asp:Label>
                            <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server" type="number"></asp:TextBox>
                        </div>
                        <div class="col d-flex">
                            <asp:Button ID="btLimpiarMedico" runat="server" Cssclass="btn btn-outline-info me-2 text-white fw-bold" Text="Limpiar" OnClick="btLimpiarMedico_Click" />
                            <asp:Button ID="btConsultarMedico" runat="server" Cssclass="btn btn-outline-info me-2 text-white fw-bold" Text="Consultar" OnClick="btConsultarMedico_Click" />

                            <asp:Button ID="btIngresarMedico" runat="server" Cssclass="btn btn-outline-info text-white fw-bold" Text="Registrar Medico" OnClick="btIngresarMedico_Click" />
                        </div>
                          <asp:Label ID="lblLast" CssClass="form-label" runat="server" Text=""></asp:Label>
                    </div>
                </form>
            </div>
        </div>
    </div>
<script src="Scripts/bootstrap.min.js"></script>

</body>
</html>
