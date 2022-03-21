<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Solicitudes.aspx.cs" Inherits="SALONES.Solicitudes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Registro de solicitudes de salones</h1>
    <br />
    <div style="display: flex; gap: 20px 20px; flex-wrap: wrap">
        <div class="mb-3">
            <label for="cmbCliente" class="form-label">Cliente que realiza la reserva</label>
            <select runat="server" aria-label="Default select example" id="cmbCliente" style="display: block; width: 230px; padding: .375rem 2.25rem .375rem .75rem;
                           font-weight: 400; line-height: 1.5; color: #212529; background-color: #fff;
                           background-repeat: no-repeat;
                           background-position: right .75rem center;
                           background-size: 16px 12px;
                           border: 1px solid #ced4da;
                           border-radius: 4px;
                           transition: border-color .15s ease-in-out,box-shadow .15s ease-in-out;
                           height: 34px;">
            </select>
        </div>

        <div class="mb-3">
            <label for="txtFecha" class="form-label">Fecha de evento</label>
            <input type="datetime-local" class="form-control" style="width: 230px;" runat="server" id="txtFecha">
        </div>

        <div class="mb-3">
            <label for="txtCantidad" class="form-label">Cantidad de personas</label>
            <input type="text" class="form-control" style="width: 230px;" runat="server" id="txtCantidad">
        </div>

        <div class="mb-3">
            <label for="cmbMotivo" class="form-label">Motivo</label>
            <select runat="server" aria-label="Default select example" id="cmbMotivo" style="display: block; width: 230px; padding: .375rem 2.25rem .375rem .75rem;
                           font-weight: 400; line-height: 1.5; color: #212529; background-color: #fff;
                           background-repeat: no-repeat;
                           background-position: right .75rem center;
                           background-size: 16px 12px;
                           border: 1px solid #ced4da;
                           border-radius: 4px;
                           transition: border-color .15s ease-in-out,box-shadow .15s ease-in-out;
                           height: 34px;">
            </select>
        </div>

         <div class="mb-3">
            <label for="cmbEstado" class="form-label">Estado</label>
            <select runat="server" aria-label="Default select example" id="cmbEstado" style="display: block; width: 230px; padding: .375rem 2.25rem .375rem .75rem;
                           font-weight: 400; line-height: 1.5; color: #212529; background-color: #fff;
                           background-repeat: no-repeat;
                           background-position: right .75rem center;
                           background-size: 16px 12px;
                           border: 1px solid #ced4da;
                           border-radius: 4px;
                           transition: border-color .15s ease-in-out,box-shadow .15s ease-in-out;
                           height: 34px;">
            </select>
        </div>

        <div class="mb-3">
            <label for="txtObservaciones" class="form-label">Observaciones</label>
            <input type="text" class="form-control" style="width: 500px;" runat="server" id="txtObservaciones">
        </div>

        <div>
            <br />
            <button id="btnRegistrar" runat="server" style="height: 34px; margin-top: 5px;" type="submit" class="btn btn-primary" onserverclick="BtnRegistrar_AgregarSolicitud">Registrar solicitud</button>
        </div>

    </div>
</asp:Content>
