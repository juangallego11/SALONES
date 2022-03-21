using SALONES.Models.Request;
using SALONES.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SALONES
{
    public partial class Solicitudes : System.Web.UI.Page
    {
        public List<ClienteResponse> clienteResponses;
        public List<MotivoResponse> motivoResponses;
        public List<EstadoResponse> estadoResponses;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                this.Obtener_Clientes();
                this.Obtener_Motivos();
                this.Obtener_Estados();
            }
            
        }

        public async void Obtener_Clientes()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string url = "https://localhost:44346/api/Clientes/ObtenerTodosLosCLientes";
                using (HttpResponseMessage respuesta = await httpClient.GetAsync(url))
                {
                    this.clienteResponses = await respuesta.Content.ReadAsAsync<List<ClienteResponse>>();
                    cmbCliente.DataSource = this.clienteResponses;
                    cmbCliente.DataTextField = "nombreCompleto";
                    cmbCliente.DataValueField = "idCliente";
                    cmbCliente.DataBind();
                }
            }
        }

        public async void Obtener_Motivos()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string url = "https://localhost:44346/api/Motivo/ObtenerMotivos";
                using (HttpResponseMessage respuesta = await httpClient.GetAsync(url))
                {
                    this.motivoResponses = await respuesta.Content.ReadAsAsync<List<MotivoResponse>>();
                    cmbMotivo.DataSource = this.motivoResponses;
                    cmbMotivo.DataTextField = "descripcion";
                    cmbMotivo.DataValueField = "idMotivo";
                    cmbMotivo.DataBind();
                }
            }
        }

        public async void Obtener_Estados()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string url = "https://localhost:44346/api/Estado/ObtenerEstados";
                using (HttpResponseMessage respuesta = await httpClient.GetAsync(url))
                {
                    this.estadoResponses = await respuesta.Content.ReadAsAsync<List<EstadoResponse>>();
                    cmbEstado.DataSource = this.estadoResponses;
                    cmbEstado.DataTextField = "descripcion";
                    cmbEstado.DataValueField = "idEstado";
                    cmbEstado.DataBind();
                }
            }
        }

        protected async void BtnRegistrar_AgregarSolicitud(object sender, EventArgs e)
        {
            SolicitudesRequest solicitud = new SolicitudesRequest
            {
                idCliente = int.Parse(cmbCliente.Items[cmbCliente.SelectedIndex].Value),
                fechaEvento = Convert.ToDateTime(txtFecha.Value),
                cantidadPersonas = int.Parse(txtCantidad.Value),
                idMotivo = int.Parse(cmbMotivo.Items[cmbMotivo.SelectedIndex].Value),
                idEstado = int.Parse(cmbEstado.Items[cmbEstado.SelectedIndex].Value),
                observaciones = txtObservaciones.Value
            };

            using (HttpClient httpClient = new HttpClient())
            {
                string url = "https://localhost:44346/api/Solicitudes";
                using (HttpResponseMessage respuesta = await httpClient.PostAsJsonAsync(url, solicitud))
                {
                    Limpiar_Campos();
                }
            }

        }

        public void Limpiar_Campos()
        {
            cmbCliente.SelectedIndex = 0;
            txtFecha.Value = "";
            txtCantidad.Value = "";
            cmbMotivo.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            txtObservaciones.Value = "";
        }
    }
}