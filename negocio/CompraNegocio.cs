using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using negocio;

namespace negocio
{
    public class CompraNegocio
    {
        
        public List<Compra> Listar()
        {
            List<Compra> lista = new List<Compra>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT IdCompra, Fecha FROM Compra ");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Compra aux = new Compra();
                    aux.IdCompra = (int)datos.Lector["IdCompra"];
                    aux.Fecha = (string)datos.Lector["Fecha"];


                    lista.Add(aux);
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            

        }
        public void AgregarCompra(Compra nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('" + nuevo.Fecha + "')";
                datos.setearConsulta("insert into Compra (Fecha) " + valores);
                datos.ejectutarAccion();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public int NumeroCompra()
        {
            int ultimonumero = 0;
            AccesoDatos datos = new AccesoDatos();

            datos.setearConsulta("select MAX(IdCompra) AS MAXIMO from Compra");
            datos.ejecutarLectura();
            while (datos.Lector.Read())
            {
                ultimonumero = (int)datos.Lector["MAXIMO"];
            }
            return ultimonumero;
        }

    }
}
