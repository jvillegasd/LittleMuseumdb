using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo
{
    public class Escultura : Obra
    {
        public Escultura(int id, string nombre, Museo museo, Estilo estilo):base(id, nombre, museo, estilo) {

        }
    }
}
