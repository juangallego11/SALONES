using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SALONES.Models.Request
{
    public class ClienteRequest
    {
        public string identificacion { get; set; }
        public string nombreCompleto { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public int idDepartamento { get; set; }
        public int idCiudad { get; set; }
        public int edad { get; set; }
    }
}