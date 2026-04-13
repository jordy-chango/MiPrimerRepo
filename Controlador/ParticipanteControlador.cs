using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ParticipanteControlador
    {
        private ParticipanteDatos repo = new ParticipanteDatos();

        public void Agregar(int idEmp, string nombres, string cargo, Image foto)
        {
            Participante p = new Participante()
            {
                IdEmprendimiento = idEmp,
                Nombres = nombres,
                Cargo = cargo,
                Foto = foto != null ? UtilImagen.ImagenABytes(foto) : null
            };

            repo.Agregar(p);
        }

        public List<Participante> Listar(int idEmp)
        {
            return repo.ListarPorEmprendimiento(idEmp);
        }
    }
}
