using SALONES.Models.Request;
using SALONES.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SALONES.Controllers
{
    public class ClientesController : ApiController
    {
       [HttpPost]
        public IHttpActionResult AgregarCliente(ClienteRequest clienteRequest)
        {
            using(Models.DBSALONENTITY db = new Models.DBSALONENTITY())
            {
                var cliente = new Models.clientes
                {
                    identificacion = clienteRequest.identificacion,
                    nombre_completo = clienteRequest.nombreCompleto,
                    telefono = clienteRequest.telefono,
                    correo = clienteRequest.correo,
                    id_departamento = clienteRequest.idDepartamento,
                    id_ciudad = clienteRequest.idCiudad,
                    edad = clienteRequest.edad
                };

                cliente = db.clientes.Add(cliente);

                db.SaveChanges();

                return Ok(Json(cliente));
            } 
        }

        [HttpGet]
        public IHttpActionResult ObtenerTodosLosCLientes()
        {
            using (Models.DBSALONENTITY db = new Models.DBSALONENTITY())
            {
                var clientesList = new List<ClienteResponse>();
                var clientes = db.view_clientes.ToList();
                foreach (var c in clientes)
                {
                    clientesList.Add(new ClienteResponse()
                    {
                        idCliente = c.id_cliente,
                        identificacion = c.identificacion,
                        nombreCompleto = c.nombre_completo,
                        telefono = c.telefono,
                        correo = c.correo,
                        departamento = c.departamento,
                        ciudad = c.ciudad,
                        edad=c.edad
                    });
                }

                if (clientesList.Count > 0)
                {
                    return Ok(clientesList);
                } else
                {
                    return NotFound();
                }
            }
        }
    }
}
