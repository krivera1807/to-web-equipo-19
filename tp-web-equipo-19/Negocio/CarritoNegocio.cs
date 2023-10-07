using Dominio;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class CarritoNegocio
    {
        public List<Carrito> listacarrito { get; set; } = new List<Carrito>();

        public void Agregar(Articulo seleccionado, int cantidadselec)
        {
            Carrito carritoItem = new Carrito
            {
                Articulo = seleccionado,
                cantidad = cantidadselec,
                total = seleccionado.Precio * cantidadselec
            };

            listacarrito.Add(carritoItem);
        }

        public List<Carrito> ListarCarrito()
        {
            return listacarrito;
        }

        public decimal CalcularTotalCarrito()
        {
            decimal total = 0;
            foreach (var item in listacarrito)
            {
                total += item.total;
            }
            return total;
        }
    }
}
