using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo
{
    public class Museo
    {
        int id;
        String nombre;
        List<Artista> artistas = new List<Artista>();
        List<Obra> obras = new List<Obra>();
        List<Estilo> estilos = new List<Estilo>();
  
        public void ejecutarejecicio(Museo museo)
        {
            Artista profeJimeno = new Artista(504, "Miguel Jimeno");
            Estilo jimenoEstilo = new Estilo(12312, "Estilo Davinci");
            Obra obra1 = new Obra(1, "Monalisa", museo, jimenoEstilo);
            Obra obra2 = new Obra(12, "Monalisa2", museo, jimenoEstilo);
            jimenoEstilo.artista = profeJimeno;
            profeJimeno.estilos.Add(jimenoEstilo);
            profeJimeno.obras.Add(obra1);
            artistas.Add(profeJimeno);
            obras.Add(obra1);
            estilos.Add(jimenoEstilo);
            escribir(museo);
        }

        public void escribir(Museo museo)
        {
            Console.WriteLine("Museo: {0}",museo.nombre);
            Console.WriteLine("Artistas disponibles");
            for (int i = 0; i < artistas.Count; i++)
            {
                Console.WriteLine(artistas.ElementAt(i).nombre);
                Console.WriteLine("Obras hechas:");
                for (int j = 0; j < artistas.ElementAt(i).obras.Count; j++)
                {
                    Console.WriteLine("{0}-{1}",artistas.ElementAt(i).obras.ElementAt(j).nombre, artistas.ElementAt(i).obras.ElementAt(j).estilo.nombre);
                }
            }
            Console.WriteLine("Estilos presentados en el museo:");
            for (int i = 0; i < estilos.Count; i++)
            {
                Console.WriteLine("{0}-{1}", estilos.ElementAt(i).nombre,estilos.ElementAt(i).artista.nombre);
            }
            Console.Read();
        }

        public Museo(String nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }
    }
    
}
