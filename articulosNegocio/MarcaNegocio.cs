using items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business
{
    public class MarcaNegocio
    {
        public List<MarcaCat> Listar()
        {
            List<MarcaCat> lista = new List<MarcaCat>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion From MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    MarcaCat aux = new MarcaCat();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

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
    }
}
