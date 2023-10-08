using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_web_equipo_19
{
    public partial class Carrito : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                MostrarCarrito();
            }

            if (Session["Id"] != null)
            {
                int id = (int)Session["Id"];

                CarritoNegocio miCarritoNegocio = Session["Carrito"] as CarritoNegocio;

                if (miCarritoNegocio == null)
                {
                    miCarritoNegocio = new CarritoNegocio();
                }

                bool articuloYaEnCarrito = miCarritoNegocio.listacarrito.Any(item => item.Articulo.Id == id);

                if (!articuloYaEnCarrito)
                {
                    List<Articulo> ListaArticulos;
                    ArticuloNegocio articulo = new ArticuloNegocio();
                    ListaArticulos = articulo.Listar();

                    Articulo seleccionado = ListaArticulos.Find(x => x.Id == id);

                    if (seleccionado != null)
                    {
                        miCarritoNegocio.Agregar(seleccionado, 1);
                    }
                }

                // Calcular el total del carrito

                decimal totalCarrito = miCarritoNegocio.CalcularTotalCarrito();

                // Mostrar el total en el Label
                lblTotalCarrito.Text = totalCarrito.ToString("C"); // Formatear el total como moneda (por ejemplo, $100.00)

                Session["Carrito"] = miCarritoNegocio;
                RepeaterCarrito.DataSource = miCarritoNegocio.listacarrito;
                RepeaterCarrito.DataBind();
            }
        }



        protected void MostrarCarrito()
        {
            CarritoNegocio miCarritoNegocio = Session["Carrito"] as CarritoNegocio;

            if (miCarritoNegocio != null)
            {
                RepeaterCarrito.DataSource = miCarritoNegocio.listacarrito;
                RepeaterCarrito.DataBind();
            }
        }

    }
}
