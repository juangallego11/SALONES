<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaSolicitudes.aspx.cs" Inherits="SALONES.ConsultaSolicitudes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Consulta de solicitudes</h1>
    <br />
    <div style="display: flex; gap: 20px 20px; flex-wrap: wrap">
        <div class="mb-3">
            <label for="txtFechaInicio" class="form-label">Fecha de inicio</label>
            <input type="date" class="form-control" style="width: 230px;" runat="server" id="txtFechaInicio">
        </div>

        <div class="mb-3">
            <label for="txtFechaFinal" class="form-label">Fecha final</label>
            <input type="date" class="form-control" style="width: 230px;" runat="server" id="txtFechaFinal">
        </div>

        <div>
            <br />
            <button id="btnConsultar" runat="server" style="height: 34px; margin-top: 5px;" type="submit" class="btn btn-primary" onserverclick="BtnConsultar_SolicitudesXFecha" >Consultar</button>
        </div>
    </div>

    <div>
        <br />
        <h2>Resultado búsqueda</h2>
        <br />
        <table class="table" id="tablaSol" runat="server">
          <thead>
            <tr>
                <th scope="col">Nombre cliente</th>
                <th scope="col">Identificación</th>
                <th scope="col">Teléfono</th>
                <th scope="col">Ciudad</th>
                <th scope="col">Fecha evento</th>
                <th scope="col">Cantidad de personas</th>
                <th scope="col">Motivo</th>
                <th scope="col">Acciones</th>
            </tr>
          </thead>
          <tbody>
          </tbody>
        </table>
    </div>
</asp:Content>
