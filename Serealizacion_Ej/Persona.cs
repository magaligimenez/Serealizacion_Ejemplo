using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serealizacion_Ej
{

    [Serializable]

    public class Persona
    {
        string nombre;
        int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        public Persona() { }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public override string ToString()
        {
            return $"{this.edad} --- {this.nombre}";
        }

    }
}
