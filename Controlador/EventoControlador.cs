using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class EventoControlador
    {
        private EventoDatos repo = new EventoDatos();

        public void Agregar(DateTime fecha, string hora, string ubicacion, int idEmp, int Orden )
        {
            Evento ev = new Evento()
            {
                Fecha = fecha,
                Hora = hora,
                Ubicacion = ubicacion,
                IdEmprendimiento = idEmp,
                Orden = Orden,
            };

            repo.Agregar(ev);
        }

        public List<Evento> Listar()
        {
            return repo.Listar();
        }

        public List<Evento> FiltrarPorFecha(DateTime fecha)
        {
            return repo.FiltrarPorFecha(fecha);
        }
    }
}
