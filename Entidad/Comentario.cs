using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Comentario
    {
        private static int contador = 1;

        public int Id { get; set; }
        public int IdEmprendimiento { get; set; }
        public string Texto { get; set; }

        public Comentario()
        {
            Id = contador++;
        }
    }
}
