using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SALONES.Models.Response
{
    public class ClienteResponse
    {
        public int idCliente { get; set; }
        public string identificacion { get; set; }
        public string nombreCompleto { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string departamento { get; set; }
        public string ciudad { get; set; }
        public int edad { get; set; }
    }
}