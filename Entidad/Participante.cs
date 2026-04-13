using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Participante
    {
        private static int contador = 1;

        public int Id { get; set; }
        public int IdEmprendimiento { get; set; }
        public string Nombres { get; set; }
        public string Cargo { get; set; }
        public byte[] Foto { get; set; }

        public Participante()
        {
            Id = contador++;
        }
    }

}
