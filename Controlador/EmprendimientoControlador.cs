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
    public class EmprendimientoControlador
    {
        private EmprendimientoDatos repo = new EmprendimientoDatos();

        public void Agregar(string nombre, string facultad, string rubro, string descripcion, Image foto)
        {
            Emprendimiento emp = new Emprendimiento()
            {
                Nombre = nombre,
                Facultad = facultad,
                Rubro = rubro,
                Descripcion = descripcion,
                Foto = UtilImagen.ImagenABytes(foto)
            };

            repo.Agregar(emp);
        }
        public List<Emprendimiento> Listar()
        {
            return repo.Listar();
        }

        public List<Emprendimiento> BuscarPorNombre(string nombre)
        {
            return repo.BuscarPorNombre(nombre);
        }

        public Emprendimiento Buscar(int id)
        {
            return repo.Buscar(id);
        }

    }
}

