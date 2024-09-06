using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq  // Define un espacio de nombres llamado IntroduccionLinq, que agrupa clases relacionadas y ayuda a evitar conflictos de nombres.
{
    internal class Medico : Empleado  // Declara una clase interna llamada Medico que hereda de la clase Empleado.
    {
        public string nombre { get; set; }  // Define una propiedad pública llamada 'nombre' de tipo string, con métodos de acceso 'get' y 'set'.
    }
}
