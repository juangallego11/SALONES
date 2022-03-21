using SALONES.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SALONES.Controllers
{
    public class DepartamentosController : ApiController
    {
        [HttpGet]
        public IHttpActionResult ObtenerDepartamentos()
        {
            using (Models.DBSALONENTITY db = new Models.DBSALONENTITY())
            {
                var departamentos = new List<DepartamentosResponse>();
                var departamentosList = db.departamentos.ToList();

                foreach (var dep in departamentosList)
                {
                    departamentos.Add(new DepartamentosResponse()
                    {
                        id_departamento = dep.id_departamento,
                        departamento = dep.departamento
                    });
                }
          

                return Ok(departamentos);
            }
        }
    }
}
