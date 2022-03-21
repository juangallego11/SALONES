using SALONES.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SALONES.Controllers
{
    public class EstadoController : ApiController
    {
        [HttpGet]
        public IHttpActionResult ObtenerEstados()
        {
            using (Models.DBSALONENTITY db = new Models.DBSALONENTITY())
            {
                var estados = new List<EstadoResponse>();
                var estadosList = db.estado.ToList();
                foreach (var estado in estadosList)
                {
                    estados.Add(new EstadoResponse()
                    {
                        idEstado = estado.id_estado,
                        descripcion = estado.descripcion
                    });
                }

                return Ok(estados);
            }
        }
    }
}
