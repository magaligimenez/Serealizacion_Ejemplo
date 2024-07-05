using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serealizacion_Ej
{
    public interface ISerealizable
    {
        void Serializar(string path);
        void Deserealizar(string path);
    }
}
