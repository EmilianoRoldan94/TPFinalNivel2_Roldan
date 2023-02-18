using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using items;

namespace business
{
    public class articuloNegocio
    {

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.ImagenUrl, C.Descripcion Categoria, M.Descripcion Marca, A.Precio, A.IdMarca, A.IdCategoria From ARTICULOS A, CATEGORIAS C, MARCAS M Where M.Id = A.IdMarca And C.Id = A.IdCategoria";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.CodigoArticulo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Categoria = new MarcaCat();
                    aux.Categoria.Id = (int)lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    aux.Marca= new MarcaCat();
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Precio = (decimal)lector["Precio"];

                    if (!(lector["ImagenUrl"] is DBNull))
                    {
                        aux.UrlImagen = (string)lector["ImagenUrl"];
                    }
                    

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void Agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio)values(@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@ImagenUrl,@Precio)");
                datos.setearParametro("@Codigo", nuevo.CodigoArticulo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@ImagenUrl", nuevo.UrlImagen);
                datos.setearParametro("@Precio", nuevo.Precio);

                datos.ejecutarAccion();
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
        public void modificar(Articulo modificado)
        {
            AccesoDatos data = new AccesoDatos();
            try
            {
                data.setearConsulta("Update ARTICULOS set Codigo = @Codigo,Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio Where Id = @Id");
                data.setearParametro("@Codigo", modificado.CodigoArticulo);
                data.setearParametro("@Nombre", modificado.Nombre);
                data.setearParametro("@Descripcion", modificado.Descripcion);
                data.setearParametro("@IdMarca", modificado.Marca.Id);
                data.setearParametro("@IdCategoria", modificado.Categoria.Id);
                data.setearParametro("@ImagenUrl", modificado.UrlImagen);
                data.setearParametro("@Precio", modificado.Precio);
                data.setearParametro("@Id", modificado.Id);

                data.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.cerrarConexion();
            }
        }
        public void eliminar(int Id) 
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("DELETE From ARTICULOS where id = @id");
                datos.setearParametro("@id", Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
