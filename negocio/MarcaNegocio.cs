using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datosMarca = new AccesoDatos();

            try
            {
                datosMarca.setearConsulta("Select Id, Descripcion from MARCAS");
                datosMarca.ejecutarLectura();

                while (datosMarca.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datosMarca.Lector["Id"];
                    aux.Nombre = (string)datosMarca.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            { datosMarca.cerrarConexion(); }
        }

        public void agregar(Marca nueva)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO MARCAS (DESCRIPCION) VALUES ('" + nueva.ToString() + "')");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally { datos.cerrarConexion(); }
        }
    }
}

