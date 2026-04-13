using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class PremiadoDatos
    {
        public void Agregar(Premiado p)
        {
            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Premiado (Categoria, Puesto, IdEmprendimiento) " +
                    "VALUES (@c,@p,@id)", cn);

                cmd.Parameters.AddWithValue("@c", p.Categoria);
                cmd.Parameters.AddWithValue("@p", p.Puesto);
                cmd.Parameters.AddWithValue("@id", p.IdEmprendimiento);

                cmd.ExecuteNonQuery();
            }
        }
        public List<Premiado> Listar()
        {
            List<Premiado> lista = new List<Premiado>();

            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Premiado", cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Premiado
                    {
                        Id = (int)dr["Id"],
                        Categoria = dr["Categoria"].ToString(),
                        Puesto = dr["Puesto"].ToString(),
                        IdEmprendimiento = (int)dr["IdEmprendimiento"]
                    });
                }
            }
            return lista;
        }
    }
}
