<<<<<<< HEAD
﻿using Dominio;
using System;
using System.Collections.Generic;
=======
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;
using Dominio;
using static System.Net.Mime.MediaTypeNames;

>>>>>>> 0beaf22a30fa32c64bd5512068f612c8d9824410

namespace Negocio
{
    public class CarritoNegocio
    {
<<<<<<< HEAD
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
=======
        public int cantidad { get; set; }
        public decimal total { get; set; }

        public List<Articulo> listaCarrito = new List<Articulo>();
        public void Agregar(Articulo seleccionado, int cantidadSelec) {

            listaCarrito.Add(seleccionado); 
            cantidad = cantidadSelec;
            total += (seleccionado.Precio * cantidadSelec);

        } 

        //public List<Articulo> Listar(List listaCarrito)
        //{
           

        //}

        //public void Agregar(Articulo Nuevo)
        //{

            

        //}

        
        //public void Mostrar(Articulo articulo)
        //{
            

        //}

        //public int BuscarId(Articulo articulo)
        //{
        //    bool articuloYaEnCarrito = ListaSeleccionada.Any(a => a.Id == seleccionado.Id);

        //    if (!articuloYaEnCarrito)
        //    {
        //        ListaSeleccionada.Add(seleccionado);
        //    }

        //}

        //public void Eliminar(int id)
        //{
            

        //}

>>>>>>> 0beaf22a30fa32c64bd5512068f612c8d9824410
    }
}
