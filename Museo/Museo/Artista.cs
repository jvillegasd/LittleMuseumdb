using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo
{
    public class Artista
    {
        public int id;
        public String nombre;
        public List<Estilo> estilos = new List<Estilo>();
        public List<Obra> obras = new List<Obra>();

        public Artista(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}
