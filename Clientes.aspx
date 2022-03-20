<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="SALONES.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Registro de clientes</h1>
    <div style="display: flex; gap: 20px 20px; flex-wrap: wrap">
        <div class="mb-3">
            <label for="txtIdentificacion" class="form-label">Identificación</label>
            <input type="text" class="form-control" style="width: 230px;" runat="server" id="txtIdentificacion" aria-describedby="emailHelp">
        </div>
        <div class="mb-3">
            <label for="txtNombre" class="form-label">Nombre completo</label>
            <input type="text" class="form-control" style="width: 230px;" runat="server" id="txtNombre">
        </div>
        <div class="mb-3">
            <label for="txtTelefono" class="form-label">Telefono</label>
            <input type="text" class="form-control" style="width: 230px;" runat="server" id="txtTelefono">
        </div>
        <div class="mb-3">
            <label for="txtCorreo" class="form-label">Correo</label>
            <input type="email" class="form-control" style="width: 230px;" runat="server" id="txtCorreo">
        </div>
        <div class="mb-3">
            <label for="cmbDepartamento" class="form-label">Departamento</label>
            <select runat="server" aria-label="Default select example" id="cmbDepartamento" style="display: block; width: 230px; padding: .375rem 2.25rem .375rem .75rem;
                           font-weight: 400; line-height: 1.5; color: #212529; background-color: #fff;
                           background-repeat: no-repeat;
                           background-position: right .75rem center;
                           background-size: 16px 12px;
                           border: 1px solid #ced4da;
                           border-radius: 4px;
                           transition: border-color .15s ease-in-out,box-shadow .15s ease-in-out;
                           height: 34px;">
              <option selected>Seleccione el departamento</option>
              <option value="1">One</option>
              <option value="2">Two</option>
              <option value="3">Three</option>
            </select>
        </div>

        <div class="mb-3">
            <label for="cmbCiudad" class="form-label">Ciudad</label>
            <select runat="server" aria-label="Default select example" id="cmbCiudad" style="display: block; width: 230px; padding: .375rem 2.25rem .375rem .75rem;
                           font-weight: 400; line-height: 1.5; color: #212529; background-color: #fff;
                           background-repeat: no-repeat;
                           background-position: right .75rem center;
                           background-size: 16px 12px;
                           border: 1px solid #ced4da;
                           border-radius: 4px;
                           transition: border-color .15s ease-in-out,box-shadow .15s ease-in-out;
                           height: 34px;">
              <option selected>Seleccione la ciudad</option>
              <option value="1">One</option>
              <option value="2">Two</option>
              <option value="3">Three</option>
            </select>
        </div>

        <div class="mb-3">
            <label for="cmbEdad" class="form-label">Edad</label>
            <select runat="server" aria-label="Default select example" id="cmbEdad" style="display: block; width: 230px; padding: .375rem 2.25rem .375rem .75rem;
                           font-weight: 400; line-height: 1.5; color: #212529; background-color: #fff;
                           background-repeat: no-repeat;
                           background-position: right .75rem center;
                           background-size: 16px 12px;
                           border: 1px solid #ced4da;
                           border-radius: 4px;
                           transition: border-color .15s ease-in-out,box-shadow .15s ease-in-out;
                           height: 34px;">
              <option selected>Seleccione la edad</option>
              <option value="1">1</option>
              <option value="2">2</option>
              <option value="3">3</option>
            </select>
        </div>

        <div>
            <br />
            <button runat="server" style="height: 34px; margin-top: 5px;" type="submit" class="btn btn-primary">Registrar</button>
        </div>
    </div>

    <br />

    <h1>Listado de clientes</h1>
    <br />
    <table class="table">
      <thead>
        <tr>
            <th scope="col">Identificación</th>
            <th scope="col">Nombre completo</th>
            <th scope="col">Telefono</th>
            <th scope="col">Correo</th>
            <th scope="col">Departamento</th>
            <th scope="col">Ciudad</th>
            <th scope="col">Edad</th>
        </tr>
      </thead>
      <tbody>

        <tr>
          
        </tr>
  
      </tbody>
    </table>
    
    
</asp:Content>
