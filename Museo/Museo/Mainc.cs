using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo
{
    class Mainc
    {
        static void Main(string[] args)
        {
            Museo museoRoma = new Museo("Roma", 1234);
            museoRoma.ejecutarejecicio(museoRoma);
        }
    }
}
