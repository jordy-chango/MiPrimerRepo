using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class PremiadoControlador
    {
        private PremiadoDatos repo = new PremiadoDatos();

        public void Agregar(string categoria, string puesto, int idEmp)
        {
            Premiado p = new Premiado()
            {
                Categoria = categoria,
                Puesto = puesto,
                IdEmprendimiento = idEmp
            };

            repo.Agregar(p);
        }

        public List<Premiado> Listar()
        {
            return repo.Listar();
        }
    }
}
