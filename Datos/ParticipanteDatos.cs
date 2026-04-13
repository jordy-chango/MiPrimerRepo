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
    public class ParticipanteDatos
    {
        public void Agregar(Participante p)
        {
            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Participante (Nombres, Cargo, Foto, IdEmprendimiento) " +
                    "VALUES (@n,@c,@f,@id)", cn);

                cmd.Parameters.AddWithValue("@n", p.Nombres);
                cmd.Parameters.AddWithValue("@c", p.Cargo);
                cmd.Parameters.AddWithValue("@id", p.IdEmprendimiento);

                cmd.Parameters.Add("@f", SqlDbType.VarBinary).Value =
            (object)p.Foto ?? DBNull.Value;

                cmd.ExecuteNonQuery();
            }
        }

        public List<Participante> ListarPorEmprendimiento(int idEmp)
        {
            List<Participante> lista = new List<Participante>();

            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Participante WHERE IdEmprendimiento=@id", cn);

                cmd.Parameters.AddWithValue("@id", idEmp);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Participante
                    {
                        Id = (int)dr["Id"],
                        Nombres = dr["Nombres"].ToString(),
                        Cargo = dr["Cargo"].ToString(),
                        Foto = dr["Foto"] == DBNull.Value ? null : (byte[])dr["Foto"],
                        IdEmprendimiento = (int)dr["IdEmprendimiento"]
                    });
                }
            }
            return lista;
        }
    }
}