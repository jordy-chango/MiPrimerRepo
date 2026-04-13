using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Premiado
    {
        private static int contador = 1;

        public int Id { get; set; }
        public string Categoria { get; set; }
        public string Puesto { get; set; }
        public int IdEmprendimiento { get; set; }

        public Premiado()
        {
            Id = contador++;
        }
    }
}
