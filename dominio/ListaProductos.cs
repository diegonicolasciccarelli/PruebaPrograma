using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class ListaProductos
    {
        public int IdListaProductos { get; set; }
     
        public int Cantidad { get; set; }
        public Producto ItemArt { get; set; }
        public int IdNumeroDeCompra { get; set; }
        public int IdNumeroDeVenta { get; set; }
        public ListaProductos(int id, Producto product, int cant, bool transaccion, int idproducto, int numerocompra)
        {
            IdListaProductos = id;
            ItemArt = product;
            Cantidad = cant;
            IdNumeroDeCompra = numerocompra;
        }
        public ListaProductos(int idcompra)
        {
            IdNumeroDeCompra = idcompra;
        }

        public ListaProductos() { }


    }
}
