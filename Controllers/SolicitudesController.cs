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
    public class SolicitudesController : ApiController
    {
        [HttpPost]
        public IHttpActionResult CrearSolicitud(SolicitudesRequest solicitudRequest)
        {
            using (Models.DBSALONENTITY db = new Models.DBSALONENTITY())
            {
                var solicitud = new Models.solicitudes
                {
                    id_cliente = solicitudRequest.idCliente,
                    fecha_evento = solicitudRequest.fechaEvento,
                    cant_personas = solicitudRequest.cantidadPersonas,
                    id_motivo = solicitudRequest.idMotivo,
                    id_estado = solicitudRequest.idEstado,
                    observaciones = solicitudRequest.observaciones
                };

                solicitud = db.solicitudes.Add(solicitud);

                db.SaveChanges();

                return Ok(Json(solicitud));

            }
        }
 
        
    }

    
}
