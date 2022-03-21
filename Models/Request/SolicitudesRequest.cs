using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SALONES.Models.Request
{
    public class SolicitudesRequest
    {
        public int idCliente { get; set; }
        public System.DateTime fechaEvento { get; set; }
        public int cantidadPersonas { get; set; }
        public int idMotivo { get; set; }
        public string observaciones { get; set; }
        public int idEstado { get; set; }
    }
}