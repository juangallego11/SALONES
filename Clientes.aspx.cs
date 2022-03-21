using SALONES.Models.Request;
using SALONES.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace SALONES
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<DepartamentosResponse> departamentosResposes;
        public List<CiudadesResponse> ciudadesResposes;
        public List<EdadResponse> edades = new List<EdadResponse>();
        public List<ClienteResponse> clienteResponses;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Obtener_Clientes();
            if (!IsPostBack)
            {
                ClientScriptManager cs = Page.ClientScript;
                this.cmbDepartamento.Attributes.Add("onchange", cs.GetPostBackEventReference(this.cmbDepartamento, this.cmbDepartamento.ID));
                this.ObtenerEdades();
                this.ObtenerDepartamentos();
                

            }
        }

        protected async void btnRegistrar_obtenerValores(object sender, EventArgs e)
        {
            ClienteRequest client = new ClienteRequest
            {
                identificacion = txtIdentificacion.Value,
                nombreCompleto = txtNombre.Value,
                telefono = txtTelefono.Value,
                correo = txtCorreo.Value,
                idDepartamento = int.Parse(cmbDepartamento.Items[cmbDepartamento.SelectedIndex].Value),
                idCiudad = int.Parse(cmbCiudad.Items[cmbCiudad.SelectedIndex].Value),
                edad = int.Parse(cmbEdad.Items[cmbEdad.SelectedIndex].Value)
            };
            
            using (HttpClient httpClient = new HttpClient())
            {
                string url = "https://localhost:44346/api/Clientes/AgregarCliente";
                using (HttpResponseMessage respuesta = await httpClient.PostAsJsonAsync(url, client))
                {
                    Limpiar_Campos();
                    Obtener_Clientes();
                   
                }
            }

        }

        public async void ObtenerDepartamentos()
        {
            using(HttpClient httpClient = new HttpClient())
            {
                string url = "https://localhost:44346/api/Departamentos/ObtenerDepartamentos";
                using(HttpResponseMessage respuesta = await httpClient.GetAsync(url))
                {
                    this.departamentosResposes = await respuesta.Content.ReadAsAsync<List<DepartamentosResponse>>();
                    cmbDepartamento.DataSource = this.departamentosResposes;
                    cmbDepartamento.DataTextField = "departamento";
                    cmbDepartamento.DataValueField = "id_departamento";
                    
                    cmbDepartamento.DataBind();

                    CmbDepartamento_ServerChange(null, null);
                }
            }        
        }

  
        protected async void CmbDepartamento_ServerChange(object sender, EventArgs e)
        {
            string valueSelect = cmbDepartamento.Items[cmbDepartamento.SelectedIndex].Value;
            using (HttpClient httpClient = new HttpClient())
            {
                string url = "https://localhost:44346/api/Ciudades/ObtenerCiudadesxDepartamento/" + valueSelect;
                using (HttpResponseMessage respuesta = await httpClient.GetAsync(url))
                {
                    this.ciudadesResposes = await respuesta.Content.ReadAsAsync<List<CiudadesResponse>>();
                    cmbCiudad.DataSource = this.ciudadesResposes;
                    cmbCiudad.DataTextField = "ciudad";
                    cmbCiudad.DataValueField = "id_ciudad";

                    cmbCiudad.DataBind();
                }
            }
        }

        public async void Obtener_Clientes()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string url = "https://localhost:44346/api/Clientes/ObtenerTodosLosCLientes";
                using (HttpResponseMessage respuesta = await httpClient.GetAsync(url))
                {
                    this.clienteResponses = new List<ClienteResponse>();
                    this.clienteResponses = await respuesta.Content.ReadAsAsync<List<ClienteResponse>>();
                    //tablaClientes.Rows.Clear();
                    
                    foreach (ClienteResponse clienteResponse in this.clienteResponses)
                    {
                        HtmlTableRow tRow = new HtmlTableRow();
                        HtmlTableCell tb1 = new HtmlTableCell
                        {
                            InnerText = clienteResponse.identificacion,
                        };
                        HtmlTableCell tb2 = new HtmlTableCell
                        {
                            InnerText = clienteResponse.nombreCompleto,
                        };
                        HtmlTableCell tb3 = new HtmlTableCell
                        {
                            InnerText = clienteResponse.telefono,
                        };
                        HtmlTableCell tb4 = new HtmlTableCell
                        {
                            InnerText = clienteResponse.correo,
                        };
                        HtmlTableCell tb5 = new HtmlTableCell
                        {
                            InnerText = clienteResponse.departamento,
                        };
                        HtmlTableCell tb6 = new HtmlTableCell
                        {
                            InnerText = clienteResponse.ciudad,
                        };
                        HtmlTableCell tb7 = new HtmlTableCell
                        {
                            InnerText = clienteResponse.edad.ToString(),
                        };
                        tRow.Controls.Add(tb1);
                        tRow.Controls.Add(tb2);
                        tRow.Controls.Add(tb3);
                        tRow.Controls.Add(tb4);
                        tRow.Controls.Add(tb5);
                        tRow.Controls.Add(tb6);
                        tRow.Controls.Add(tb7);
                        tablaClientes.Rows.Add(tRow);
                    }
                   
                }
            }
        }

        public void ObtenerEdades()
        {
            for (int i = 18; i <= 100; i++) 
            {
                this.edades.Add(new EdadResponse()
                {
                    edad_value = i,
                });
            }
            cmbEdad.DataSource = this.edades;
            cmbEdad.DataTextField = "edad_value";
            cmbEdad.DataValueField = "edad_value";
            cmbEdad.DataBind();
            
        }

        public void Limpiar_Campos()
        {
            txtIdentificacion.Value = "";
            txtNombre.Value = "";
            txtCorreo.Value = "";
            txtTelefono.Value = "";
            cmbDepartamento.SelectedIndex = 0;
            cmbEdad.SelectedIndex = 0;
            CmbDepartamento_ServerChange(null, null);
        }

    }
}