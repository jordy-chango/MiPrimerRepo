using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Evento
    {
        private static int contador = 1;
        
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Ubicacion { get; set; }
        public int IdEmprendimiento { get; set; }
        public int Orden { get; set; }

        public Evento()
        {
            Id = contador++;
        }
    }
}
