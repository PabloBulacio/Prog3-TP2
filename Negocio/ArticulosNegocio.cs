using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ArticulosNegocio
    {
       public List <Articulos> Listar()
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearConsulta("select Codigo, Nombre, M.Descripcion as Marca, C.Descripcion as Categoria, Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdCategoria=C.Id and A.IdMarca=M.Id");
                datos.ejecutarLectura();

              
                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Marca"];
                    aux.ImagenUrl = (string)datos.Lector["Categoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);

                }


                return lista;
            }
            catch (Exception ex )
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}


