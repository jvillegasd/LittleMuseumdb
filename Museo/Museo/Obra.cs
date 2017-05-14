using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo
{
    public class Obra
    {
        int id;
        public String nombre;
        Museo museo;
        public Estilo estilo;

        public Obra(int id, string nombre, Museo museo, Estilo estilo)
        {
            this.id = id;
            this.nombre = nombre;
            this.museo = museo;
            this.estilo = estilo;
        }
    }
}
