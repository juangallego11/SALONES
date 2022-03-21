using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace SALONES
{
    public partial class ConsultaSolicitudes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConsultar_SolicitudesXFecha(object sender, EventArgs e)
        {
            var StartDate = Convert.ToDateTime(txtFechaInicio.Value);
            var EndDate = Convert.ToDateTime(txtFechaFinal.Value);

            using (Models.DBSALONENTITY db = new Models.DBSALONENTITY())
            {
                var solicitudesList = db.SolicitudesXFecha(StartDate, EndDate);
                foreach(var sol in solicitudesList)
                {
                    HtmlTableRow tRow = new HtmlTableRow();
                    HtmlTableCell tb1 = new HtmlTableCell
                    {
                        InnerText = sol.nombre_completo
                    };
                    HtmlTableCell tb2 = new HtmlTableCell
                    {
                        InnerText = sol.identificacion
                    };
                    HtmlTableCell tb3 = new HtmlTableCell
                    {
                        InnerText = sol.telefono
                    };
                    HtmlTableCell tb4 = new HtmlTableCell
                    {
                        InnerText = sol.ciudad
                    };
                    HtmlTableCell tb5 = new HtmlTableCell
                    {
                        InnerText = sol.fecha_evento.ToString()
                    };
                    HtmlTableCell tb6 = new HtmlTableCell
                    {
                        InnerText = sol.cant_personas.ToString()
                    };
                    HtmlTableCell tb7 = new HtmlTableCell
                    {
                        InnerText = sol.motivo
                    };
                    HtmlTableCell tb8 = new HtmlTableCell();
                
                    LinkButton LinkButton = new LinkButton
                    {
                        Text = "Eliminar",
                        ID = "lbbEliminar"

                    };
                    LinkButton.Attributes.Add("runat", "server");
                    LinkButton.Attributes.Add("href", "#");


                    tb8.Controls.Add(LinkButton);



                    tRow.Controls.Add(tb1);
                    tRow.Controls.Add(tb2);
                    tRow.Controls.Add(tb3);
                    tRow.Controls.Add(tb4);
                    tRow.Controls.Add(tb5);
                    tRow.Controls.Add(tb6);
                    tRow.Controls.Add(tb7);
                    tRow.Controls.Add(tb8);
                    tablaSol.Rows.Add(tRow);
                }
                
            }
        }

        protected void BtnEliminar_Prueba(object sender, EventArgs e)
        {
            Console.WriteLine("hola");


        }
    }
}