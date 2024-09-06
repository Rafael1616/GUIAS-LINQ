namespace IntroduccionLinq  // Declara un espacio de nombres llamado 'IntroduccionLinq', que se utiliza para organizar el código y evitar conflictos de nombres.
{
    using IntroduccionLinq;  // Importa el espacio de nombres 'IntroduccionLinq' para que se puedan utilizar sus clases y métodos en este archivo. (Nota: Esta línea puede ser redundante si está en el mismo espacio de nombres)
    internal class Program  // Declara una clase interna llamada 'Program'. La palabra clave 'internal' significa que esta clase solo es accesible dentro del mismo ensamblado.
    {
        static void Main(string[] args)  // Declara el método 'Main', que es el punto de entrada de la aplicación. 'static' significa que este método pertenece a la clase 'Program' y no a una instancia de la clase. 'string[] args' permite recibir argumentos desde la línea de comandos.
        {
            /*
            #region Introduccion
            // Inicia una región de código llamada 'Introduccion', que permite agrupar y colapsar secciones de código en el editor.

            string[] palabras;  // Declara un arreglo de cadenas llamado 'palabras'.
            palabras = new string[] { "gato", "perro", "lagarto", "tortuga", "cocodrilo", "serpiente", "123456789" };  // Inicializa el arreglo 'palabras' con una lista de cadenas que representan diferentes animales y un número.
            Console.WriteLine("Mas de 5 letras");  // Imprime un mensaje en la consola indicando que se mostrarán palabras con más de 5 letras.

            List<string> resultado = new List<string>();  // Crea una nueva lista de cadenas llamada 'resultado' para almacenar las palabras que cumplen con la condición.

            foreach (string str in palabras)  // Inicia un bucle que itera sobre cada cadena 'str' en el arreglo 'palabras'.
            {
                if (str.Length > 5)  // Comprueba si la longitud de la cadena 'str' es mayor a 5.
                {
                    resultado.Add(str);  // Si la condición es verdadera, agrega la cadena 'str' a la lista 'resultado'.
                }
            }
            foreach (var r in resultado)  // Inicia un bucle que itera sobre cada elemento 'r' en la lista 'resultado'.
                Console.WriteLine(r);  // Imprime en la consola cada cadena 'r' que se encuentra en la lista 'resultado'.
            #endregion
            // Finaliza la región de código 'Introduccion'.
            */

            /*
            #region utilizando Linq
            // Inicia una región de código llamada 'utilizando Linq', que permite agrupar y colapsar secciones de código en el editor.

            Console.WriteLine("-----------------------------------------------------");  // Imprime una línea de separación en la consola para mejorar la legibilidad.
            IEnumerable<string> list = from r in palabras where r.Length > 8 select r;  // Crea una variable 'list' que almacena una colección de cadenas utilizando una consulta LINQ, filtrando aquellas con longitud mayor a 8.
            foreach (var listado in list)  // Inicia un bucle que itera sobre cada elemento 'listado' en la colección 'list'.
                Console.WriteLine(listado);  // Imprime en la consola cada cadena 'listado' que se encuentra en la colección 'list'.
            Console.WriteLine("-----------------------------------------------------");  // Imprime otra línea de separación en la consola para mejorar la legibilidad.
            #endregion
            // Finaliza la región de código 'utilizando Linq'.
            */

            #region ListaModelos
            // Inicia una región de código llamada 'ListaModelos', que permite agrupar y colapsar secciones de código en el editor.

            List<Casa> ListaCasas = new List<Casa>();  // Declara una lista de objetos 'Casa' llamada 'ListaCasas' e inicializa una nueva instancia de la lista.
            List<Habitante> ListaHabitantes = new List<Habitante>();  // Declara una lista de objetos 'Habitante' llamada 'ListaHabitantes' e inicializa una nueva instancia de la lista.
            #endregion
            // Finaliza la región de código 'ListaModelos'.

            #region listaCasa
            // Inicia una región de código llamada 'listaCasa'.

            ListaCasas.Add(new Casa  // Agrega un nuevo objeto 'Casa' a la lista 'ListaCasas'.
            {
                Id = 1,  // Establece el Id de la casa como 1.
                Direccion = "3 av Norte ArcanCity",  // Establece la dirección de la casa.
                Ciudad = "Gothan City",  // Establece la ciudad donde se encuentra la casa.
                numeroHabitaciones = 20,  // Establece el número de habitaciones de la casa.
            });

            ListaCasas.Add(new Casa  // Agrega otro nuevo objeto 'Casa' a la lista 'ListaCasas'.
            {
                Id = 2,  // Establece el Id de la casa como 2.
                Direccion = "6 av Sur SmollVille",  // Establece la dirección de la casa.
                Ciudad = "Metropolis",  // Establece la ciudad donde se encuentra la casa.
                numeroHabitaciones = 5,  // Establece el número de habitaciones de la casa.
            });

            ListaCasas.Add(new Casa  // Agrega otro nuevo objeto 'Casa' a la lista 'ListaCasas'.
            {
                Id = 3,  // Establece el Id de la casa como 3.
                Direccion = "Forest Hills, Queens, NY 11375",  // Establece la dirección de la casa.
                Ciudad = "New York"  // Establece la ciudad donde se encuentra la casa.
            });
            #endregion
            // Finaliza la región de código 'listaCasa'.

            #region ListaHabitante
            // Inicia una región de código llamada 'ListaHabitante'.
            ListaHabitantes.Add(new Habitante  // Agrega un nuevo objeto 'Habitante' a la lista 'ListaHabitantes'.
            {
                IdHabitante = 1,  // Establece el Id del habitante como 1.
                Nombre = "Bruno Diaz",  // Establece el nombre del habitante.
                Edad = 36,  // Establece la edad del habitante.
                IdCasa = 1  // Establece el Id de la casa asociada al habitante.
            });
            ListaHabitantes.Add(new Habitante  // Agrega otro nuevo objeto 'Habitante' a la lista 'ListaHabitantes'.
            {
                IdHabitante = 2,  // Establece el Id del habitante como 2.
                Nombre = "Clark Kent.",  // Establece el nombre del habitante.
                Edad = 40,  // Establece la edad del habitante.
                IdCasa = 2  // Establece el Id de la casa asociada al habitante.
            });
            ListaHabitantes.Add(new Habitante  // Agrega otro nuevo objeto 'Habitante' a la lista 'ListaHabitantes'.
            {
                IdHabitante = 3,  // Establece el Id del habitante como 3.
                Nombre = "Peter Parker",  // Establece el nombre del habitante.
                Edad = 25,  // Establece la edad del habitante.
                IdCasa = 3  // Establece el Id de la casa asociada al habitante.
            });
            ListaHabitantes.Add(new Habitante  // Agrega otro nuevo objeto 'Habitante' a la lista 'ListaHabitantes'.
            {
                IdHabitante = 4,  // Establece el Id del habitante como 4.
                Nombre = "Tia Mey",  // Establece el nombre del habitante.
                Edad = 85,  // Establece la edad del habitante.
                IdCasa = 3  // Establece el Id de la casa asociada al habitante.
            });
            ListaHabitantes.Add(new Habitante  // Agrega otro nuevo objeto 'Habitante' a la lista 'ListaHabitantes'.
            {
                IdHabitante = 5,  // Establece el Id del habitante como 5.
                Nombre = "Luise Lain",  // Establece el nombre del habitante.
                Edad = 40,  // Establece la edad del habitante.
                IdCasa = 2  // Establece el Id de la casa asociada al habitante.
            });
            ListaHabitantes.Add(new Habitante  // Agrega otro nuevo objeto 'Habitante' a la lista 'ListaHabitantes'.
            {
                IdHabitante = 6,  // Establece el Id del habitante como 6.
                Nombre = "Selina Kyle",  // Establece el nombre del habitante.
                Edad = 30,  // Establece la edad del habitante.
                IdCasa = 1  // Establece el Id de la casa asociada al habitante.
            });
            ListaHabitantes.Add(new Habitante  // Agrega otro nuevo objeto 'Habitante' a la lista 'ListaHabitantes'.
            {
                IdHabitante = 7,  // Establece el Id del habitante como 7.
                Nombre = "Alfred",  // Establece el nombre del habitante.
                Edad = 65,  // Establece la edad del habitante.
                IdCasa = 1  // Establece el Id de la casa asociada al habitante.
            });
            ListaHabitantes.Add(new Habitante  // Agrega otro nuevo objeto 'Habitante' a la lista 'ListaHabitantes'.
            {
                IdHabitante = 8,  // Establece el Id del habitante como 8.
                Nombre = "Nathan Drake",  // Establece el nombre del habitante.
                Edad = 36,  // Establece la edad del habitante.
                IdCasa = 1  // Establece el Id de la casa asociada al habitante.
            });
            #endregion
            // Finaliza la región de código 'ListaHabitante'.

            /*
            #region SentenciasLinQ
            // Inicia una región de código llamada 'SentenciasLinQ', que permite agrupar y colapsar secciones de código en el editor.

            IEnumerable<Habitante> ListaEdad = from ObjetoProvicional  // Crea una variable 'ListaEdad' que almacena una colección de 'Habitante' utilizando una consulta LINQ.
                                               in ListaHabitantes  // Itera sobre cada 'Habitante' en 'ListaHabitantes'.
                                               where ObjetoProvicional.Edad > 40  // Filtra los habitantes cuya edad es mayor a 40.
                                               select ObjetoProvicional;  // Selecciona los habitantes que cumplen con la condición anterior.

            foreach (Habitante objetoProcicional2 in ListaEdad)  // Inicia un bucle que itera sobre cada 'Habitante' en 'ListaEdad'.
            {
                Console.WriteLine(objetoProcicional2.datosHabitante());  // Imprime en la consola los datos del habitante actual utilizando el método 'datosHabitante'.
            }

            IEnumerable<Habitante> listaCasaGothan = from objetoTemporalHabitante in ListaHabitantes  // Crea una variable 'listaCasaGothan' que almacena una colección de 'Habitante' utilizando una consulta LINQ.
                                                     join objetoTemporalCasa in ListaCasas  // Realiza un join entre 'ListaHabitantes' y 'ListaCasas'.
                                                     on objetoTemporalHabitante.IdHabitante equals objetoTemporalCasa.Id  // Establece la condición de unión entre los habitantes y las casas.
                                                     where objetoTemporalCasa.Ciudad == "Gothan City"  // Filtra las casas que están en "Gothan City".
                                                     select objetoTemporalHabitante;  // Selecciona los habitantes que cumplen con la condición anterior.
            Console.WriteLine("----------------------------------------------------------------------------------------------");  // Imprime una línea de separación en la consola para mejorar la legibilidad.
            foreach (Habitante h in listaCasaGothan)  // Inicia un bucle que itera sobre cada 'Habitante' en 'listaCasaGothan'.
            {
                Console.WriteLine(h.datosHabitante());  // Imprime en la consola los datos del habitante actual utilizando el método 'datosHabitante'.
            }

            #endregion
            // Finaliza la región de código 'SentenciasLinQ'.
            */

            /*
            #region Last
            // Inicia una región de código llamada 'Last', que permite agrupar y colapsar secciones de código en el editor.

            Casa ultimaCasa = ListaCasas.Last(temp => temp.Id > 1);  // Crea una variable 'ultimaCasa' que obtiene el último elemento de 'ListaCasas' cuyo Id es mayor a 1.
            Console.WriteLine(ultimaCasa.dameDatosCasa());  // Imprime en la consola los datos de la última casa utilizando el método 'dameDatosCasa'.
            Console.WriteLine("_____________________________________________________");  // Imprime una línea de separación en la consola para mejorar la legibilidad.
            var h1 = (from objHabitante in ListaHabitantes where objHabitante.Edad > 60 select objHabitante)  // Crea una variable 'h1' que obtiene el último habitante cuya edad es mayor a 60, utilizando una consulta LINQ.
                .LastOrDefault();  // Utiliza 'LastOrDefault' para devolver el último elemento o null si no hay resultados.
            if (h1 == null)  // Comprueba si 'h1' es null.
            {
                Console.WriteLine("Algo fallo");  // Imprime un mensaje indicando que algo falló si 'h1' es null.
                return;  // Sale del método actual si no se encuentra un habitante.
            }
            Console.WriteLine(h1.datosHabitante());  // Imprime en la consola los datos del habitante obtenido utilizando el método 'datosHabitante'.
            #endregion
            // Finaliza la región de código 'Last'.
            */

            /*
            #region FirsthAndFirsthOrDefault  // Inicia una región de código llamada 'FirsthAndFirsthOrDefault', que permite agrupar y colapsar secciones de código en el editor.
            Console.WriteLine("----------------------------------------------------------------------------------------------");  // Imprime una línea de separación en la consola para mejorar la legibilidad.
            var primeraCasa = ListaCasas.First(); //esto no es linQ es  una fucnin de los Ienumarable  // Crea una variable 'primeraCasa' que obtiene el primer elemento de la lista 'ListaCasas'. Esto no es LINQ, es una función de los IEnumerable.
            Console.WriteLine(primeraCasa.dameDatosCasa());  // Imprime en la consola los datos de la primera casa utilizando el método 'dameDatosCasa'.

            //aplicando una restriccion sin restricion lambda
            Habitante personaEdad = (from variableTemporalHabitante in ListaHabitantes where variableTemporalHabitante.Edad > 25 select variableTemporalHabitante).First();  // Crea una variable 'personaEdad' que obtiene el primer habitante cuya edad es mayor a 25, utilizando una consulta LINQ.
            Console.WriteLine(personaEdad.datosHabitante());  // Imprime en la consola los datos del habitante obtenido utilizando el método 'datosHabitante'.
            Console.WriteLine("---------------------------Lo mismo pero con lambdas---------------------------------------------------------");  // Imprime una línea de separación y un mensaje indicando que se usará una expresión lambda.
            var Habitante1 = ListaHabitantes.First(objectTemp => objectTemp.Edad >25);  // Crea una variable 'Habitante1' que obtiene el primer habitante cuya edad es mayor a 25, utilizando una expresión lambda.
            Console.WriteLine(Habitante1.datosHabitante());  // Imprime en la consola los datos del habitante obtenido utilizando el método 'datosHabitante'. 

            // Si no tenemos el elemento que buscamos entoences la sonsulta devolvera una exepcion esto detendra el codigo en su totalidad

            //Casa EdadError = (from vCasaTemp in ListaCasas where vCasaTemp.Id >10 select vCasaTemp).First() ;  // Esta línea está comentada; intenta obtener la primera casa con un Id mayor a 10, lanzando una excepción si no hay resultados.
            //Console.WriteLine(EdadError.dameDatosCasa());  // Esta línea está comentada; imprimiría los datos de 'EdadError' si la línea anterior no lanzara una excepción.

            Casa CasaConFirsthOrDedault = ListaCasas.FirstOrDefault(vCasa => vCasa.Id > 200);  // Crea una variable 'CasaConFirsthOrDedault' que obtiene la primera casa con un Id mayor a 200, o null si no existe.
            if (CasaConFirsthOrDedault == null ) {  // Comprueba si 'CasaConFirsthOrDedault' es null.
                Console.WriteLine("No existe !No hay!");  // Imprime un mensaje indicando que no existe la casa.
                return;  // Sale del método actual si no se encuentra la casa.
            }
            Console.WriteLine("existe !Si existe!");  // Imprime un mensaje indicando que la casa existe.

            #endregion
            // Finaliza la región de código 'FirsthAndFirsthOrDefault'.
            */

            /*
            #region ElementAt
            // Inicia una región de código llamada 'ElementAt', que permite agrupar y colapsar secciones de código en el editor.

            var terceraCasa = ListaCasas.ElementAt(2);  // Crea una variable 'terceraCasa' que obtiene el elemento en la posición 2 (tercera casa) de la lista 'ListaCasas'.
            Console.WriteLine($"La tercera casa es {terceraCasa.dameDatosCasa()}");  // Imprime en la consola los datos de la tercera casa utilizando el método 'dameDatosCasa'.

            var casaError = ListaCasas.ElementAtOrDefault(3);  // Crea una variable 'casaError' que intenta obtener el elemento en la posición 3 (cuarta casa) de 'ListaCasas', o devuelve null si no existe.
            if ( casaError != null) { Console.WriteLine($"La tercera casa es {casaError.dameDatosCasa()}"); }  // Si 'casaError' no es null, imprime los datos de la casa.

            var segundoHabitante = (from objetoTem in ListaHabitantes select objetoTem).ElementAtOrDefault(2);  // Crea una variable 'segundoHabitante' que obtiene el tercer elemento (índice 2) de la lista de habitantes, o null si no existe.
            Console.WriteLine($" segundo habitante es : {segundoHabitante.datosHabitante()}");  // Imprime en la consola los datos del segundo habitante utilizando el método 'datosHabitante'.
            #endregion
            // Finaliza la región de código 'ElementAt'.
            
            #region single
            // Inicia una región de código llamada 'single'.

            try {  // Inicia un bloque try para manejar excepciones.
                var habitantes = ListaHabitantes.Single(variableTem => variableTem.Edad > 40 && variableTem.Edad <70);  // Crea una variable 'habitantes' que obtiene el único habitante cuya edad está entre 40 y 70 años.
                // Creando esta consulta pero con LinQ
                var habitante2 = (from obtem in ListaHabitantes where obtem.Edad >70 select obtem).SingleOrDefault() ;  // Crea una variable 'habitante2' que obtiene el único habitante cuya edad es mayor a 70, o null si no existe.

                Console.WriteLine($"habitante con menos de 20 años {habitantes.datosHabitante()}");  // Imprime en la consola los datos del habitante con menos de 20 años.
                if ( habitante2 != null ) Console.WriteLine($"habitante con mas de 70 años {habitante2.datosHabitante()}");  // Si 'habitante2' no es null, imprime los datos del habitante con más de 70 años.
            }
            catch (Exception) {  // Captura cualquier excepción que ocurra en el bloque try.
                Console.WriteLine($"Ocurrio el error");  // Imprime un mensaje de error en la consola si ocurre una excepción.
            }
            #endregion 
            // Finaliza la región de código 'single'.
            */

            /*
            #region typeOf
            // Inicia una región de código llamada 'typeOf', que permite agrupar y colapsar secciones de código en el editor.

            var listaEmpleados = new List<Empleado>() {  // Crea una nueva lista de objetos de tipo 'Empleado'.
            new Medico(){ nombre= "Jorge Casa" },  // Agrega un nuevo objeto 'Medico' a la lista con el nombre "Jorge Casa".
            new Enfermero(){ nombre = "Raul Blanco"}  // Agrega un nuevo objeto 'Enfermero' a la lista con el nombre "Raul Blanco".
            };

            var medico = listaEmpleados.OfType<Medico>();  // Crea una variable 'medico' que contiene solo los elementos de tipo 'Medico' de la lista 'listaEmpleados'.
            Console.WriteLine(medico.Single().nombre);  // Imprime en la consola el nombre del único 'Medico' en la variable 'medico'.

            #endregion
            // Finaliza la región de código 'typeOf'.
            */

            #region OrderBy
            // Inicia una región de código llamada 'OrderBy', que permite agrupar y colapsar secciones de código en el editor.

            var edadA = ListaHabitantes.OrderBy(x => x.Edad);  // Crea una variable 'edadA' que contiene la lista de habitantes ordenada por 'Edad' en orden ascendente.
            var edadAC = from vt in ListaHabitantes orderby vt.Edad select vt;  // Crea una consulta LINQ que ordena 'ListaHabitantes' por 'Edad' en orden ascendente y la almacena en 'edadAC'.
            foreach (var edad in edadAC)  // Inicia un bucle que itera sobre cada habitante en 'edadAC'.
            {
                Console.WriteLine(edad.datosHabitante());  // Imprime en la consola los datos del habitante actual utilizando el método 'datosHabitante'.
            }
            #endregion
            // Finaliza la región de código 'OrderBy'.

            #region OrderBYDescending()  
            //Inicia una región de código llamada 'OrderBYDescending', que permite agrupar y colapsar secciones de código en el editor.

            /* var listaEdad = ListaHabitantes.OrderByDescending(x => x.Edad);  // Crea una variable 'listaEdad' que contiene la lista de habitantes ordenada por 'Edad' en orden descendente.
            foreach (Habitante h in listaEdad) {   // Inicia un bucle que itera sobre cada habitante en 'listaEdad'.
                Console.WriteLine(h.datosHabitante());  // Imprime en la consola los datos del habitante actual utilizando el método 'datosHabitante'.
            }
            Console.WriteLine("-------------------------------------------");  // Imprime una línea de separación en la consola.
            var ListaEdad2 = from h in ListaHabitantes orderby h.Edad descending select h;  // Crea una consulta LINQ que ordena 'ListaHabitantes' por 'Edad' en orden descendente y la almacena en 'ListaEdad2'.
            foreach (Habitante h in ListaEdad2)  // Inicia un bucle que itera sobre cada habitante en 'ListaEdad2'.
            {
                Console.WriteLine(h.datosHabitante());  // Imprime en la consola los datos del habitante actual utilizando el método 'datosHabitante'.
            }
            */
            #endregion  // Finaliza la región de código 'OrderBYDescending'.

            var habitantes3 = ListaHabitantes.OrderBy(x => x.Edad).ThenBy(x => x.Nombre);  // Crea una variable 'habitantes3' que contiene la lista de habitantes ordenada primero por 'Edad' y luego por 'Nombre'.

            foreach (var h in habitantes3)  // Inicia un bucle que itera sobre cada habitante en 'habitantes3'.
            {
                Console.WriteLine(h.datosHabitante());  // Imprime en la consola los datos del habitante actual utilizando el método 'datosHabitante'.
            }

            var lista4 = from h in ListaHabitantes orderby h.Edad, h.Nombre ascending select h;  // Crea una consulta LINQ que ordena 'ListaHabitantes' por 'Edad' y 'Nombre' en orden ascendente y la almacena en 'lista4'.

            foreach (var h in lista4)  // Inicia un bucle que itera sobre cada habitante en 'lista4'.
            {
                Console.WriteLine(h.datosHabitante());  // Imprime en la consola los datos del habitante actual utilizando el método 'datosHabitante'.
            }


            var habitantes4 = ListaHabitantes.OrderBy(x => x.Edad).ThenByDescending(x => x.Nombre);  // Crea una variable 'habitantes4' que contiene la lista de habitantes ordenada por 'Edad' y luego por 'Nombre' en orden descendente.

            foreach (var h in habitantes4)  // Inicia un bucle que itera sobre cada habitante en 'habitantes4'.
            {
                Console.WriteLine(h.datosHabitante());  // Imprime en la consola los datos del habitante actual utilizando el método 'datosHabitante'.
            }

            var lista5 = from h in ListaHabitantes orderby h.Edad, h.Nombre descending select h;  // Crea una consulta LINQ que ordena 'ListaHabitantes' por 'Edad' y 'Nombre' en orden descendente y la almacena en 'lista5'.

            foreach (var h in lista5) // Inicia un bucle que itera sobre cada habitante en 'lista4' (esto parece un error, debería ser 'lista5').
            {
                Console.WriteLine(h.datosHabitante());  // Imprime en la consola los datos del habitante actual utilizando el método 'datosHabitante'.
            }
        }
    }
}