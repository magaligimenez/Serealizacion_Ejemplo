using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serealizacion_Ej
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("magui", 19);
            Persona p2 = new Persona("hola", 15);

            p1.ToString();

            List<Persona> list = new List<Persona>();

            list.Add(p1);
            list.Add(p2);

            Soporte soporte = new Soporte();

            soporte.Serializar("persona.xml");

            Soporte g2 = new Soporte();
            g2.Deserealizar("persona.xml");

            foreach (Persona tr in g2.listaPersonas)
            {
                tr.ToString();
            }

        }
    }
}
