using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca marca { get; set; }
        public Imagen imagen { get; set; }
        public Categoria categoria { get; set; }

        private decimal precio;
        public decimal Precio
        {
            get { return precio; }
            set { precio = Math.Round(value, 2); }
        }


    }
}
