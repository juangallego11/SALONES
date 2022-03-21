using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SALONES.Models.Response
{
    public class CiudadesResponse
    {
        public int id_ciudad { get; set; }
        public string ciudad { get; set; }
        public int estado { get; set; }
        public int departamento_id { get; set; }
    }
}