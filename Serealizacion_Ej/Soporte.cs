using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serealizacion_Ej
{
    public class Soporte : ISerealizable
    {
        public List<Persona> listaPersonas;

        public Soporte()
        {

        }
        public Soporte(List<Persona> listaPersonas)
        {
            this.listaPersonas = listaPersonas;
        }

        public void Deserealizar(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    XmlSerializer des = new XmlSerializer(typeof(List<Persona>));
                    this.listaPersonas = (List<Persona>)des.Deserialize(sr);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Serializar(string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Persona>));
                    ser.Serialize(sw, this.listaPersonas);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
