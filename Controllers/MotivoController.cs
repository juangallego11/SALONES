using SALONES.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SALONES.Controllers
{
    public class MotivoController : ApiController
    {
        [HttpGet]
        public IHttpActionResult ObtenerMotivos()
        {
            using (Models.DBSALONENTITY db = new Models.DBSALONENTITY())
            {
                var motivos = new List<MotivoResponse>();
                var motivosList = db.motivo.ToList();

                foreach (var motivo in motivosList)
                {
                    motivos.Add(new MotivoResponse()
                    {
                        idMotivo = motivo.id_motivo,
                        descripcion = motivo.descripcion
                    });
                }

                return Ok(motivos);
            }
        }
    }
}
