<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="citas.aspx.cs" Inherits="Ospital.citas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="estilos.css" rel="stylesheet" />
    <title>Hospital | Citas</title>
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
                    <h2 class="fw-bolder text-info">Pedir Cita</h2>
                    <div class="row row-cols-1 g-5 mt-1">
                        <div class="col">
                            <asp:Label ID="lblCodigo" CssClass="form-label" runat="server" Text="Codigo Cita:"></asp:Label>
                            <asp:TextBox ID="txtCodigo" CssClass="form-control" runat="server"></asp:TextBox>
                            <asp:Label ID="lblMsg" CssClass="form-label" runat="server" Text=""></asp:Label>
              
                        </div>
                        <div class="col">
                            <asp:Label ID="lblIdPaciente" CssClass="form-label" runat="server" Text="ID Paciente: "></asp:Label>
                            <asp:TextBox ID="txtIdPaciente" CssClass="form-control" runat="server" type="number" Enabled ="false" ></asp:TextBox>
                            <asp:Label ID="lblMsgPaciente" CssClass="form-label text-danger" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="col">
                            <asp:Label ID="lblIdMedico" CssClass="form-label" runat="server" Text="ID Medico: "></asp:Label>
                            <asp:TextBox ID="txtIdMedico" CssClass="form-control" runat="server" type="number"  Enabled ="false"></asp:TextBox>
                             <asp:Label ID="lblMsgMedico" CssClass="form-label text-danger" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="col">
                            <asp:Label ID="lblValor" CssClass="form-label" runat="server" Text="Valor:"></asp:Label>
                            <asp:TextBox ID="txtValor" CssClass="form-control" runat="server" type="number"  Enabled ="false"></asp:TextBox>
                           
                        </div>
                         <div class="col">
                            <asp:Label ID="lblAcompañante" CssClass="form-label" runat="server" Text="Nombre Acompañante:"></asp:Label>
                            <asp:TextBox ID="txtAcompañante" CssClass="form-control" runat="server"  Enabled ="false"></asp:TextBox>
                        </div>
                        <div class="col">
                            <asp:Label ID="lblDiagnostico" CssClass="form-label" runat="server" Text="Diagnostico:"></asp:Label>
                            <asp:TextBox ID="txtDiagnostico" CssClass="form-control h-100" TextMode="MultiLine" runat="server"  Enabled ="false"></asp:TextBox></div>             
                        <div class="col d-flex">
                             <asp:TextBox runat="server" ID="txtDate" CssClass="form-control me-2"  Enabled ="false"/>
                             <asp:TextBox runat="server" ID="txtTime" CssClass="form-control" type="time"  Enabled ="false"/>
                        </div>
                        <div class="col d-flex">
                            <asp:Button ID="btLimpiarCita" runat="server" Cssclass="btn btn-outline-info me-2 text-white fw-bold" Text="Limpiar" OnClick="btLimpiarCita_Click" />
                            <asp:Button ID="btConsultarCita" runat="server" Cssclass="btn btn-outline-info me-2 text-white fw-bold" Text="Consultar" OnClick="btConsultarCita_Click" />
                            <asp:Button ID="btIngresarCita" runat="server" Cssclass="btn btn-outline-info text-white fw-bold" Text="Pedir Cita" OnClick="btIngresarCita_Click" />
                        </div>
                        <asp:Label ID="lblFinal" CssClass="form-label" runat="server" Text=""></asp:Label>
                    </div>
                </form>
            </div>
        </div>
    </div>
<script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
