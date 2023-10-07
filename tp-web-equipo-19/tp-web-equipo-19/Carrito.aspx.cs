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
            //user = Session["Id"].ToString() != null ? Session["Id"].ToString() : "";

            if (Request.QueryString["Id"]!= null) 
            {
                int id = int.Parse(Request.QueryString["Id"].ToString());

                List<Articulo> ListaArticulos;
                ArticuloNegocio articulo = new ArticuloNegocio();
                ListaArticulos = articulo.Listar();
                Articulo seleccionado = ListaArticulos.Find(x => x.Id == id);

                // Filtrar la lista para obtener solo el artículo seleccionado
                List<Articulo> ListaSeleccionada = Session["Carrito"] as List<Articulo>; // Usa "Carrito" en lugar de "Listaseleccionada"

                if (ListaSeleccionada == null)
                {
                    ListaSeleccionada = new List<Articulo>();
                    Session["Carrito"] = ListaSeleccionada;
                }

                // Agrega el artículo seleccionado a la lista del carrito
                ListaSeleccionada.Add(seleccionado);

                // Enlazar el Repeater con la lista filtrada
                RepeaterCarrito.DataSource = ListaSeleccionada;
                RepeaterCarrito.DataBind();
            }
        }
    }
}