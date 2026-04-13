using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ComentarioControlador
    {
        private ComentarioDatos repo = new ComentarioDatos();

        public void Agregar(int idEmprendimiento, string texto)
        {
            Comentario c = new Comentario()
            {
                IdEmprendimiento = idEmprendimiento,
                Texto = texto
            };

            repo.Agregar(c);
        }

        public List<Comentario> ListarPorEmprendimiento(int id)
        {
            return repo.ListarPorEmprendimiento(id);
        }
    }
}
