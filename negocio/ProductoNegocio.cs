using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ProductoNegocio
    {
       
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select P.IdProducto, P.Codigo, P.NombreProducto, T.Nombre AS Tipo, P.Stock, P.ImagenUrl, E.NombreStockProducto AS EstadoStockProducto FROM Producto AS P, Tipo AS T, EstadoStock AS E WHERE P.IdTipo = T.IdTipo AND P.IdEstadoStock = E.IdStockProducto AND P.Estado =" + 1);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.IdProducto = (int)datos.Lector["IdProducto"];
                    aux.tipo = new Tipo((string)datos.Lector["Tipo"]);
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.NombreProducto = (string)datos.Lector["NombreProducto"];
                    aux.Stock = (int)datos.Lector["Stock"];
                    aux.imagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.estadostock = new EstadoStock((string)datos.Lector["EstadoStockProducto"]);

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

        public bool ListarPorCodigo(string codigo)
        {
            bool bandera = false;
            int comparacion = 1;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Codigo From Producto");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    comparacion = string.Compare((string)datos.Lector["Codigo"], codigo);
                    if (comparacion == 0)
                    {
                        bandera = true;
                    }
                }
                return bandera;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
                datos = null;
            }
        }

        public bool ListarPorEstado(string codigo)
        {
            bool bandera = false;
            int comparacion = 1;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Codigo, Estado From Producto Where Estado = 0");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    comparacion = string.Compare((string)datos.Lector["Codigo"], codigo);

                    if (comparacion == 0)
                    {
                            bandera = true;
                    }      
                    
                }
                return bandera;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
                datos = null;
            }
        }

        public void Agregar(Producto nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('" + nuevo.Codigo + "', '" + nuevo.NombreProducto + "', '" + nuevo.tipo.IdTipo + "','" + nuevo.Stock + "', '" + nuevo.imagenUrl + "', '" + nuevo.estadostock.IdEstadoStockProducto + "')";
                datos.setearConsulta("insert into Producto (Codigo, NombreProducto, IdTipo, Stock, ImagenUrl, IdEstadoStock ) " + valores);

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

        public void modificar(Producto modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Producto set Codigo = @codigo, NombreProducto = @nombre, IdTipo = @idTipo, Stock = @stock, IdEstadoStock = @idestadostock WHERE IdProducto = @id");
                
                datos.setearParametro("@codigo", modificar.Codigo);
                datos.setearParametro("@nombre", modificar.NombreProducto);
                datos.setearParametro("@idTipo", modificar.tipo.IdTipo);
                datos.setearParametro("@stock", modificar.Stock);
                datos.setearParametro("@idestadostock", modificar.estadostock.IdEstadoStockProducto);   
                datos.setearParametro("@id", modificar.IdProducto);
                datos.ejectutarAccion();

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

        public void modificarProductoExistente(Producto modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Producto set Codigo = @codigo, NombreProducto = @nombre, IdTipo = @idTipo, Stock = @stock, IdEstadoStock = @idestadostock, Estado = @estado WHERE Codigo = @codigo");

                datos.setearParametro("@codigo", modificar.Codigo);
                datos.setearParametro("@nombre", modificar.NombreProducto);
                datos.setearParametro("@idTipo", modificar.tipo.IdTipo);
                datos.setearParametro("@stock", modificar.Stock);
                datos.setearParametro("@idestadostock", modificar.estadostock.IdEstadoStockProducto);
                datos.setearParametro("@estado", modificar.Estado);
                datos.ejectutarAccion();

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

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Producto Set Estado = " + 0 + " where IdProducto = " + id);
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
                datos = null;
            }
        }
    }
}
