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
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion as DescripcionArticulo, M.Descripcion as MarcaDescripcion, C.Descripcion as CategoriaDescripcion, Precio, M.Id as IdMarca, C.Id as IdCategoria, ImagenUrl from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdCategoria=C.Id and A.IdMarca=M.Id");
                datos.ejecutarLectura();

              
                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.IdArticulo = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["DescripcionArticulo"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Marca = new Marcas((string)datos.Lector["MarcaDescripcion"]);
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Categoria = new Categorias(datos.Lector["CategoriaDescripcion"].ToString());
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];

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
                Marcas idMarca = nuevoArticulo.Marca;
                Categorias idCategoria = nuevoArticulo.Categoria;
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

        public void Modificar(Articulos ArticuloAModificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, ImagenUrl = @imagenUrl, Precio = @precio where Id = @id");
                datos.setearParametro("@codigo", ArticuloAModificar.Codigo);
                datos.setearParametro("@nombre", ArticuloAModificar.Nombre);
                datos.setearParametro("@descripcion", ArticuloAModificar.Descripcion);
                datos.setearParametro("@idMarca", ArticuloAModificar.Marca.Id);
                datos.setearParametro("@idCategoria", ArticuloAModificar.Categoria.Id);
                datos.setearParametro("@imagenUrl", ArticuloAModificar.ImagenUrl);
                datos.setearParametro("@precio", ArticuloAModificar.Precio);
                datos.setearParametro("@id", ArticuloAModificar.IdArticulo);

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
    }
}


