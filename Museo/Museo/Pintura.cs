using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo
{
    public class Pintura : Obra
    {
        public Pintura(int id, string nombre, Museo museo, Estilo estilo):base(id, nombre, museo, estilo) {

        }       
    }
}
