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
    public class EventoDatos
    {
        public void Agregar(Evento e)
        {
            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                string sql = @"INSERT INTO Evento
               (Fecha, Hora, Ubicacion, Orden, IdEmprendimiento)
               VALUES (@f, @h, @u, @o, @i)";

                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.Add("@f", SqlDbType.Date).Value = e.Fecha;
                cmd.Parameters.Add("@h", SqlDbType.NVarChar).Value = e.Hora;
                cmd.Parameters.Add("@u", SqlDbType.NVarChar).Value = e.Ubicacion;
                cmd.Parameters.Add("@o", SqlDbType.Int).Value = e.Orden;
                cmd.Parameters.Add("@i", SqlDbType.Int).Value = e.IdEmprendimiento;
                
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Evento> FiltrarPorFecha(DateTime fecha)
        {

            List<Evento> lista = new List<Evento>();

            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Evento WHERE Fecha = @fecha", cn);

                cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha.Date;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Evento
                    {
                        Id = (int)dr["Id"],
                        Fecha = (DateTime)dr["Fecha"],
                        Hora = dr["Hora"].ToString(),
                        Ubicacion = dr["Ubicacion"].ToString(),
                        Orden = (int)dr["Orden"],
                        IdEmprendimiento = (int)dr["IdEmprendimiento"]
                    });
                }
            }
            return lista;
        }

        public List<Evento> Listar()
        {
            List<Evento> lista = new List<Evento>();

            using (SqlConnection cn = ConexionBD.ObtenerConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Evento", cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Evento
                    {
                        Id = (int)dr["Id"],
                        Fecha = (DateTime)dr["Fecha"],
                        Hora = dr["Hora"].ToString(),
                        Ubicacion = dr["Ubicacion"].ToString(),
                        Orden= dr["Orden"] == DBNull.Value ? 0 : (int)dr["Orden"],
                        IdEmprendimiento = (int)dr["IdEmprendimiento"]
                    });
                }
            }
            return lista;
        }

    }
}
