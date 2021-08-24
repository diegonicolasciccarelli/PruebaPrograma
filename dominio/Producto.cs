using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string NombreProducto { get; set; }
        public Tipo tipo { get; set; }
        public int Stock { get; set; }
        public string imagenUrl { get; set; }
        public EstadoStock estadostock { get; set; }
        public int Estado { get; set; }

        public Producto(int id)
        {
            IdProducto = id;
        }

        public Producto()
        {

        }
    }
}

