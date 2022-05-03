using Clase_3_MVC.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3_MVC.Servicios
{
    public interface IEquipoService
    {
        public List<Equipo> Listar();

        public List<Equipo> Agregar(Equipo equipo);
    }
}
