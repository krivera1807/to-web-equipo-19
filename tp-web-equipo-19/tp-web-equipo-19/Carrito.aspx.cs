using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_web_equipo_19
{
    public partial class Carrito : System.Web.UI.Page
    {
        public string user { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Id"] != null)
            {
                int id = (int)Session["Id"];

                List<Articulo> ListaArticulos;
                ArticuloNegocio articulo = new ArticuloNegocio();
                ListaArticulos = articulo.Listar();
               

                Articulo seleccionado = ListaArticulos.Find(x => x.Id == id);

                // Verificar si la instancia de CarritoNegocio ya existe en la sesión
                CarritoNegocio miCarritoNegocio = Session["Carrito"] as CarritoNegocio;

                if (miCarritoNegocio == null)
                {
                    miCarritoNegocio = new CarritoNegocio();
                }

                List<Articulo> ListaSeleccionada = miCarritoNegocio.listaCarrito;

                bool articuloYaEnCarrito = ListaSeleccionada.Any(a => a.Id == seleccionado.Id);

                if (!articuloYaEnCarrito)
                {
                    miCarritoNegocio.Agregar(seleccionado, 1);
                }

                // Actualiza la instancia de CarritoNegocio en la sesión
                Session["Carrito"] = miCarritoNegocio;

                RepeaterCarrito.DataSource = ListaSeleccionada;
                RepeaterCarrito.DataBind();
            }
        }
    }
}
