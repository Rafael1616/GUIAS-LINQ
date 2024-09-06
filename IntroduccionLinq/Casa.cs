using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq  // Define un espacio de nombres llamado IntroduccionLinq, que agrupa clases relacionadas y ayuda a evitar conflictos de nombres.
{
    internal class Casa  // Declara una clase interna llamada Casa, que solo es accesible dentro del mismo ensamblado.
    {
        public int Id { get; set; }  // Define una propiedad pública llamada 'Id' de tipo int, con métodos de acceso 'get' y 'set'.
        public string Direccion { get; set; }  // Define una propiedad pública llamada 'Direccion' de tipo string, con métodos de acceso 'get' y 'set'.
        public string Ciudad { get; set; }  // Define una propiedad pública llamada 'Ciudad' de tipo string, con métodos de acceso 'get' y 'set'.
        public int numeroHabitaciones { get; set; }  // Define una propiedad pública llamada 'numeroHabitaciones' de tipo int, con métodos de acceso 'get' y 'set'.
        public string dameDatosCasa()  // Declara un método público llamado 'dameDatosCasa' que devuelve un string.
        {
            return $"Direcion es {Direccion} en la ciudad de {Ciudad} con numero de habitaciones {numeroHabitaciones}";  // Retorna una cadena formateada que incluye la dirección, ciudad y número de habitaciones de la casa.
        }
    }
}
