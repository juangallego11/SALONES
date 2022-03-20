using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SALONES
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.obtenerValores();
        }

        public void obtenerValores()
        {
            string identificacion = txtIdentificacion.Value;
            string nombreCompleto = txtNombre.Value;
            string telefono = txtTelefono.Value;
            string correo = txtCorreo.Value;
            
       
        }
    }
}