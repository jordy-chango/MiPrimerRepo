using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class EmprendimientoDatos
    {
        public void Agregar(Emprendimiento e)
        {
            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Emprendimiento VALUES (@n,@f,@r,@d,@foto)", cn);

                cmd.Parameters.AddWithValue("@n", e.Nombre);
                cmd.Parameters.AddWithValue("@f", e.Facultad);
                cmd.Parameters.AddWithValue("@r", e.Rubro);
                cmd.Parameters.AddWithValue("@d", e.Descripcion);

                cmd.Parameters.Add("@foto", SqlDbType.VarBinary).Value =
             (object)e.Foto ?? DBNull.Value;


                cmd.ExecuteNonQuery();
            }
        }

        public Emprendimiento Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Emprendimiento> BuscarPorNombre(string nombre)
        {
            List<Emprendimiento> lista = new List<Emprendimiento>();

            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Emprendimiento WHERE Nombre LIKE @nombre", cn);

                cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Emprendimiento
                    {
                        Id = (int)dr["Id"],
                        Nombre = dr["Nombre"].ToString(),
                        Facultad = dr["Facultad"].ToString(),
                        Rubro = dr["Rubro"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        Foto = dr["Foto"] == DBNull.Value ? null : (byte[])dr["Foto"]
                    });
                }
            }

            return lista;
        }

        public List<Emprendimiento> Listar()
        {
            List<Emprendimiento> lista = new List<Emprendimiento>();

            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Emprendimiento", cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Emprendimiento
                    {
                        Id = (int)dr["Id"],
                        Nombre = dr["Nombre"].ToString(),
                        Facultad = dr["Facultad"].ToString(),
                        Rubro = dr["Rubro"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        Foto = dr["Foto"] == DBNull.Value ? null : (byte[])dr["Foto"]
                    });
                }
            }
            return lista;
        }
    }
}
