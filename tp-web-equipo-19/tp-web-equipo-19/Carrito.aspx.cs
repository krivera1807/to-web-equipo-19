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
using static System.Net.Mime.MediaTypeNames;

namespace tp_web_equipo_19
{
    public partial class Carrito : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
   

            if (!IsPostBack)
            {
                MostrarCarrito();


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
                            Session["IdArticuloSeleccionado"] = seleccionado.Id;
                            
                        }

                    }
                    Session["Carrito"] = miCarritoNegocio;
                    RepeaterCarrito.DataSource = miCarritoNegocio.listacarrito;
                    RepeaterCarrito.DataBind();

                    // Calcular el total del carrito

                    decimal totalCarrito = miCarritoNegocio.CalcularTotalCarrito();

                    // Mostrar el total en el Label
                    lblTotalCarrito.Text = totalCarrito.ToString("C"); // Formatear el total como moneda (por ejemplo, $100.00)


                    //Se limpia sesión para que no cargue de nuevo el último ID
                    Session["Id"] = null;
                    


                }
            }
        }



        protected void MostrarCarrito()
        {
            CarritoNegocio miCarritoNegocio = Session["Carrito"] as CarritoNegocio;

            if (miCarritoNegocio != null)
            {
                RepeaterCarrito.DataSource = miCarritoNegocio.listacarrito;
                RepeaterCarrito.DataBind();
                decimal totalCarrito = miCarritoNegocio.CalcularTotalCarrito();
                lblTotalCarrito.Text = totalCarrito.ToString("C");
            }
        }

        

        private int ObtenerIndiceDelArticulo(int idArticulo)
        {
            CarritoNegocio miCarritoNegocio = Session["Carrito"] as CarritoNegocio;

            if (miCarritoNegocio != null)
            {
                for (int i = 0; i < miCarritoNegocio.listacarrito.Count; i++)
                {
                    if (miCarritoNegocio.listacarrito[i].Articulo.Id == idArticulo)
                    {
                        return i; // Encontramos el índice del artículo en el carrito
                    }
                }
            }

            return -1; // El artículo no está en el carrito
        }

        protected void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            // Obtener el TextBox que desencadenó el evento
            TextBox txtCantidad = (TextBox)sender;

            // Obtener el idArticulo almacenado en sesión
            int idArticuloSeleccionado = Convert.ToInt32(Session["IdArticuloSeleccionado"]);

            // Obtener miCarritoNegocio de la sesión
            CarritoNegocio miCarritoNegocio = Session["Carrito"] as CarritoNegocio;

            // Verificar si miCarritoNegocio es nulo
            if (miCarritoNegocio != null)
            {
                // Obtener el valor actualizado del TextBox
                int nuevaCantidad;
                if (int.TryParse(txtCantidad.Text, out nuevaCantidad))
                {
                    // Actualizar la cantidad en miCarritoNegocio.listacarrito
                    int indice = ObtenerIndiceDelArticulo(idArticuloSeleccionado);

                    if (indice >= 0 && indice < miCarritoNegocio.listacarrito.Count)
                    {
                        miCarritoNegocio.listacarrito[indice].cantidad = nuevaCantidad;
                    }
                  
                    decimal totalCarrito= miCarritoNegocio.CalcularTotalCarrito();
                    lblTotalCarrito.Text = totalCarrito.ToString("C"); // Formatear el total como moneda (por ejemplo, $100.00)
                    MostrarCarrito();
                }
            }
        }

        protected void EliminarProducto_Click(object sender, EventArgs e)
        {
            int indice = new int();
           
            CarritoNegocio miCarritoNegocio = Session["Carrito"] as CarritoNegocio;
            int idArticuloSeleccionado = Convert.ToInt32(Session["IdArticuloSeleccionado"]);

          
            foreach(var item  in miCarritoNegocio.listacarrito)
            {
                if(idArticuloSeleccionado == item.Articulo.Id)
                {
                    indice = miCarritoNegocio.listacarrito.IndexOf(item);
                }
            }
             miCarritoNegocio.listacarrito.RemoveAt(indice);

            

            decimal totalCarrito = miCarritoNegocio.CalcularTotalCarrito();
            //Session["Carrito"] = miCarritoNegocio.listacarrito;

            lblTotalCarrito.Text = totalCarrito.ToString("C"); // Formatear el total como moneda (por ejemplo, $100.00)
            MostrarCarrito();
     
        }
    }
}