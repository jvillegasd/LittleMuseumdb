using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo
{
    public class Estilo
    {
        int id;
        public string nombre;
        public Artista artista;

        public Estilo(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}
