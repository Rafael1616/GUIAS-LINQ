using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq  // Define un espacio de nombres llamado IntroduccionLinq, que agrupa clases relacionadas y ayuda a evitar conflictos de nombres.
{
    internal class Habitante  // Declara una clase interna llamada Habitante, que solo es accesible dentro del mismo ensamblado.
    {
        public int IdHabitante { get; set; }  // Define una propiedad pública llamada 'IdHabitante' de tipo int, con métodos de acceso 'get' y 'set'.
        public string Nombre { get; set; }  // Define una propiedad pública llamada 'Nombre' de tipo string, con métodos de acceso 'get' y 'set'.
        public int Edad { get; set; }  // Define una propiedad pública llamada 'Edad' de tipo int, con métodos de acceso 'get' y 'set'.
        public int IdCasa { get; set; }  // Define una propiedad pública llamada 'IdCasa' de tipo int, con métodos de acceso 'get' y 'set'.

        public string datosHabitante()  // Declara un método público llamado 'datosHabitante' que devuelve un string.
        {
            return $"Soy {Nombre} con edad de {Edad} años vividos en {IdCasa}";  // Retorna una cadena formateada que incluye el nombre, edad e ID de casa del habitante.
        }
    }
}
