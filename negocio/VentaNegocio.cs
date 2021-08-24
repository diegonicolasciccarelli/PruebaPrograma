using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class VentaNegocio
    {
       
        public List<Venta> Listar()
        {
            List<Venta> lista = new List<Venta>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT IdVenta, Fecha FROM Venta");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Venta aux = new Venta();
                    aux.IdVenta = (int)datos.Lector["IdVenta"];
                    aux.Fecha = (string)datos.Lector["Fecha"];              
                    lista.Add(aux);
                }
                return lista;
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
        public void AgregarVenta(Venta nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('" + nuevo.Fecha + "')";
                datos.setearConsulta("insert into Venta (Fecha) " + valores);
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
        public int NumeroVenta()
        {
            int ultimonumero = 0;
            AccesoDatos datos = new AccesoDatos();

            datos.setearConsulta("select MAX(IdVenta) AS MAXIMO from Venta");
            datos.ejecutarLectura();
            while (datos.Lector.Read())
            {
                ultimonumero = (int)datos.Lector["MAXIMO"];
            }
            return ultimonumero;
        }
    }

        


        
 }
         



