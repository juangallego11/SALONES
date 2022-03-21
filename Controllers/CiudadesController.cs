using SALONES.Models.Response;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SALONES.Controllers
{
    public class CiudadesController : ApiController
    {
        [HttpGet]
        public IHttpActionResult ObtenerCiudadesxDepartamento(int id)
        {
            using (Models.DBSALONENTITY db = new Models.DBSALONENTITY())
            {
                var ciudades = new List<CiudadesResponse>();
                var ciudadesList = db.ciudades.Where(ciudad => ciudad.departamento_id == id);
                foreach (var ciudad in ciudadesList)
                {
                    ciudades.Add(new CiudadesResponse()
                    {
                        id_ciudad = ciudad.id_ciudad,
                        ciudad = ciudad.ciudad,
                        estado = ciudad.estado
                    });
                }

                return Ok(ciudades);

            }
        }
    }
}
