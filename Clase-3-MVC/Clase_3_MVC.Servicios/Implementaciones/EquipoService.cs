using Clase_3_MVC.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3_MVC.Servicios.Implementaciones
{
    public class EquipoService : IEquipoService
    {
        private static List<Equipo> _equipos = new List<Equipo>()
        {
            new Equipo() { Id =1,  Nombre = "River", Pais = "Arg" },
            new Equipo() { Id =2,  Nombre = "Boke", Pais = "Arg" },
        };

        public List<Equipo> Agregar(Equipo equipo)
        {
            throw new NotImplementedException();
        }

        public List<Equipo> Listar()
        {
            return _equipos;
        }
    }
}
