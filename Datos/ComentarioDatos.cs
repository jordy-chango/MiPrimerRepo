using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Datos
{
    public class ComentarioDatos
    {
        public void Agregar(Comentario c)
        {
            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Comentario (Texto, IdEmprendimiento) VALUES (@t, @id)", cn);

                cmd.Parameters.AddWithValue("@t", c.Texto);
                cmd.Parameters.AddWithValue("@id", c.IdEmprendimiento);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Comentario> ListarPorEmprendimiento(int id)
        {
            List<Comentario> lista = new List<Comentario>();

            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Comentario WHERE IdEmprendimiento=@id", cn);

                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Comentario
                    {
                        Id = (int)dr["Id"],
                        Texto = dr["Texto"].ToString(),
                        IdEmprendimiento = (int)dr["IdEmprendimiento"]
                    });
                }
            }
            return lista;
        }
    }
}
