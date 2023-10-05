using System;
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


namespace Negocio
{
    public class CarritoNegocio
    {
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

    }
}
