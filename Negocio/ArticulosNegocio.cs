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

        public void agregar(Articulos nuevoArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string codigo = nuevoArticulo.Codigo;
                string nombre = nuevoArticulo.Nombre;
                string descripcion = nuevoArticulo.Descripcion;
                int idMarca = Convert.ToInt32(getIdMarca(nuevoArticulo.Marca));
                int idCategoria = Convert.ToInt32(getIdCategoria(nuevoArticulo.Categoria));
                string urlImagen = nuevoArticulo.ImagenUrl;
                decimal precio = nuevoArticulo.Precio;

                string values = "values('" + codigo+ "', '" + nombre + "', '" + descripcion + "', " + idMarca + ", "
                                    + idCategoria + ", '" + urlImagen + "', " + precio + ")";
                string consulta = "insert into articulos (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) " + values;
                datos.setearConsulta(consulta);
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
        
        private int getIdMarca(Marcas marca)
        {
            switch(marca.Descripcion)
            {
                case "Samsung":
                    return 1;
                case "Apple":
                    return 2;
                case "Sony":
                    return 3;
                case "Huawei":
                    return 4;
                case "Motorola":
                    return 5;
                default:
                    return 1;
            }
        }

        private int getIdCategoria(Categorias categoria)
        {
            switch (categoria.Descripcion)
            {
                case "Celulares":
                    return 1;
                case "Televisores":
                    return 2;
                case "Media":
                    return 3;
                case "Audio":
                    return 4;
                default:
                    return 1;
            }
        }
    }
}


