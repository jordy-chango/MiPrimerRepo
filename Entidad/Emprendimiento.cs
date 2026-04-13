using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Emprendimiento
    {
        private static int contador = 1;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Facultad { get; set; }
        public string Rubro { get; set; }
        public string Descripcion { get; set; }
        public byte[] Foto { get; set; }
       

        public Emprendimiento()
        {
            Id = contador++;
        }
    }


}
