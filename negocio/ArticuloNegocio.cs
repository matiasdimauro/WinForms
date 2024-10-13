using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using static System.Net.Mime.MediaTypeNames;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select a.Id AS 'ID de Articulo', Codigo, Nombre, a.Descripcion, IdMarca, IdCategoria, Precio,(select top 1 ImagenUrl from IMAGENES where IdArticulo = a.Id ) AS 'UrlImagen' From ARTICULOS a");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo a = new Articulo();
                    a.Id = (int)datos.Lector["ID de Articulo"];
                    a.Codigo = (string)datos.Lector["Codigo"];
                    a.Nombre = (string)datos.Lector["Nombre"];
                    a.Descripcion = (string)datos.Lector["Descripcion"];
                    a.Precio = (decimal)datos.Lector["Precio"];
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        a.UrlImagen = (string)datos.Lector["UrlImagen"];

                    lista.Add(a);
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

        public List<Articulo> ListarDetalle(int id)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT a.Id AS 'ID de Articulo', Codigo, Nombre, m.Descripcion AS 'Marca', c.Descripcion AS 'Categoria', a.Descripcion AS 'Descripcion', IdMarca, IdCategoria, Precio, c.Id AS 'ID Categoria',  ImagenUrl,  m.Id AS 'ID Marca' FROM ARTICULOS a JOIN CATEGORIAS c ON a.IdCategoria = c.Id JOIN MARCAS m ON a.IdMarca = m.Id  JOIN IMAGENES i ON a.Id = i.IdArticulo WHERE a.Id = @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Marca = new Marca();
                    aux.Categoria = new Categoria();
                    aux.Id = (int)datos.Lector["ID de Articulo"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Marca.Nombre = (string)datos.Lector["Marca"];
                    aux.Categoria.DescripcionCategoria = (string)datos.Lector["Categoria"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Categoria.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"].ToString();


                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }

            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
