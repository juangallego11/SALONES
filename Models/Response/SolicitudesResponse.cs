using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SALONES.Models.Response
{
    public class SolicitudesResponse
    {
        public string nombreCompleto { get; set; }
        public string identificacion { get; set; }
        public string telefono { get; set; }
        public string ciudad { get; set; }
        public System.DateTime fechaEvento { get; set; }
        public int cantidadPersonas { get; set; }
        public string motivo { get; set; }
    }
}