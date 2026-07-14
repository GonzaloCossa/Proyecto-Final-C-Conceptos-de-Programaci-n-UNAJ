namespace Proyecto_Final_C16_Cossa_Gonzalo_Agustin
{
    public class Funciones
    {
        /* Método: forzarCarga
         * Encargado de realizar una precarga de datos en las primeras 
         * 5 posiciones del arreglo para agilizar las pruebas del proyecto.
         */
        public void forzarCarga(Jugador[] jugadores, ref int indice)
        {
            jugadores[0].nombre = "Lionel";
            jugadores[0].apellido = "Messi";
            jugadores[0].dni = 31549551;
            jugadores[0].numCamiseta = 10;
            jugadores[0].posicion = "Delantero";
            jugadores[0].partidosJugados = 20;
            jugadores[0].cantGoles = 25;

            jugadores[1].nombre = "Rodrigo";
            jugadores[1].apellido = "De Paul";
            jugadores[1].dni = 34519189;
            jugadores[1].numCamiseta = 7;
            jugadores[1].posicion = "Mediocampista";
            jugadores[1].partidosJugados = 18;
            jugadores[1].cantGoles = 3;

            jugadores[2].nombre = "Cristian";
            jugadores[2].apellido = "Romero";
            jugadores[2].dni = 38541841;
            jugadores[2].numCamiseta = 13;
            jugadores[2].posicion = "Defensor";
            jugadores[2].partidosJugados = 15;
            jugadores[2].cantGoles = 0;

            jugadores[3].nombre = "Emiliano";
            jugadores[3].apellido = "Martinez";
            jugadores[3].dni = 33598418;
            jugadores[3].numCamiseta = 23;
            jugadores[3].posicion = "Arquero";
            jugadores[3].partidosJugados = 19;
            jugadores[3].cantGoles = 0;

            jugadores[4].nombre = "Julian";
            jugadores[4].apellido = "Alvarez";
            jugadores[4].dni = 39541187;
            jugadores[4].numCamiseta = 9;
            jugadores[4].posicion = "Delantero";
            jugadores[4].partidosJugados = 12;
            jugadores[4].cantGoles = 6;

            // Se actualiza el tamaño lógico del arreglo
            indice += 5;
        }

        /* Método: mostrarMenu
         * Muestra en la consola una interfaz con el listado 
         * de opciones disponibles para la operación del sistema
         */
        public void mostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("¡Bienvenido al Gestor de Jugadores!\n");
            Console.WriteLine("1. Cargar datos de un jugador\n" +
                "2. Calcular y mostrar el promedio de goles por jugador\n" +
                "3. Mostrar jugadores sin goles\n" +
                "4. Mostrar jugadores destacados\n" +
                "5. Mostrar jugadores con rendimiento medio\n" +
                "6. Buscar jugador por número de camiseta\n" +
                "7. Salir del programa\n");
            Console.Write("Elija una opción: ");    
        }

        /* Método: cargarJugador
         * Encargada de recibir los datos ingresados por el usuario de un nuevo jugador,
         * luego la agrega al arreglo validando rangos y evita duplicaciones en los ingresos.
         */  
        public void cargarJugador(Jugador[] jugadores, ref int indice)
        {
            string datoIngresado;
            int numIngresado;
            bool datoInvalido;

            Console.Clear();
            Console.WriteLine("Menú de Carga de nuevo Jugador");

            // Validación de ingreso del nombre
            do
            {
                datoInvalido = false;
                Console.Write("\nIngrese el nombre del jugador: ");
                datoIngresado = Console.ReadLine();

                if(datoIngresado == "" || datoIngresado == null)
                {
                    Console.WriteLine("\nError, ingrese un nombre valido.");
                    datoInvalido = true;
                }

            }
            while (datoInvalido == true);

            jugadores[indice].nombre = datoIngresado;

            // Validación de ingreso del apellido
            do
            {
                datoInvalido = false;
                Console.Write("\nIngrese el apellido del jugador: ");
                datoIngresado = Console.ReadLine();

                if (datoIngresado == "" || datoIngresado == null)
                {
                    Console.WriteLine("\nError, ingrese un apellido valido.");
                    datoInvalido = true;
                }

            }
            while (datoInvalido == true);

            jugadores[indice].apellido = datoIngresado;

            // Validación de ingreso del DNI
            do
            {
                datoInvalido = false;
                Console.Write("\nIngrese el DNI del jugador: ");

                numIngresado = Convert.ToInt32(Console.ReadLine());

                if(numIngresado <= 0)
                {
                    Console.WriteLine("\nError, el DNI debe ser mayor a 0.");
                    datoInvalido = true;
                }

                // Se recorre el arreglo para evitar duplicaciones de DNI en el ingreso
                for(int i = 0; i < indice; i++)
                {
                    if (jugadores[i].dni == numIngresado)
                    {
                        Console.WriteLine($"\nError, el DNI {numIngresado} ya se encuentra registrado.");
                        datoInvalido = true;
                        break;
                    }
                }
            }
            while (datoInvalido == true);

            jugadores[indice].dni = numIngresado;

            // Validación del número de camiseta
            do
            {
                Console.Write("\nIngrese el número de camiseta del jugador: ");
                numIngresado = Convert.ToInt32(Console.ReadLine());

                datoInvalido = false;

                // Validamos que el camiseta sea mayor al número 0
                if (numIngresado <= 0)
                {
                    Console.WriteLine("\nError, el número de camiseta debe ser mayor a 0.");
                    datoInvalido = true;
                }
                else
                {
                    // Buscamos evitar la duplicación de números de camisetas en el arreglo
                    for (int i = 0; i < indice; i++)
                    {
                        if (jugadores[i].numCamiseta == numIngresado)
                        {
                            Console.WriteLine($"\nError, La camiseta número {numIngresado} ya pertenece a {jugadores[i].nombre} {jugadores[i].apellido}.");
                            datoInvalido = true;
                            break;
                        }
                    }
                }

            } while (datoInvalido == true);

            jugadores[indice].numCamiseta = numIngresado;

            // Validación de la posición del jugador
            do
            {
                datoInvalido = false;
                Console.Write("\nIngrese la posición del jugador: ");
                datoIngresado = Console.ReadLine();

                if (datoIngresado == null || datoIngresado == "")
                {
                    Console.WriteLine("\nError, debe ingresar una posición valida.");
                    datoInvalido = true;
                }
            } 
            while (datoInvalido == true);
            
            jugadores[indice].posicion = datoIngresado;

            // Validación de la cantidad de partidos jugados
            do
            {
                datoInvalido = false; 
                Console.Write("\nIngrese la cantidad de partidos jugados del jugador: ");
                numIngresado = Convert.ToInt32(Console.ReadLine());

                if (numIngresado < 0)
                {
                    Console.WriteLine("\nError, debe ingresar una cantidad de partidos valida.");
                    datoInvalido = true;
                }
            }
            while (datoInvalido == true);

            jugadores[indice].partidosJugados = numIngresado;

            // Validación de la cantidad de goles convertidos
            do
            {
                datoInvalido = false;
                Console.Write("\nIngrese la cantidad de goles convertidos del jugador: ");
                numIngresado = Convert.ToInt32(Console.ReadLine());

                // Validamos que el usuario ingrese un número valido de goles
                if (numIngresado < 0)
                {
                    Console.WriteLine("\nError, debe ingresar una cantidad de goles valida.");
                    datoInvalido = true;
                } 
                // En caso de que el jugador que ingresa no tenga ningún partido jugado, no puede tener goles anotados
                else if(numIngresado > 0 && jugadores[indice].partidosJugados == 0)
                {
                    Console.WriteLine("\nError, si no jugó ningún partido no puede tener goles a favor.");
                    datoInvalido = true;
                }
            }
            while (datoInvalido == true);
 
            jugadores[indice].cantGoles = numIngresado;

            Console.Write("\nJugador cargado correctamente, pulse cualquier tecla para continuar...");
            Console.ReadKey();

            // Una vez agregado el jugador, aumentamos el tamaño lógico del arreglo
            indice++;
        }

        /* Método: mostrarPromPorJugador
         * Recorre el arreglo de jugadores y calcula individualmente
         * su promedio de goles por partido, luego lo muestra en 
         * consola en formato de columnas
         */
        public void mostrarPromPorJugador(Jugador[] jugadores, int indice)
        {
            Console.Clear();
            Console.WriteLine("Lista de Promedios de Goles por Jugador:\n");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("| Nombre                 | Goles   | Partidos | Promedio Goles |");
            Console.WriteLine("----------------------------------------------------------------");

            for (int i = 0; i < indice; i++)
            {
                if (jugadores[i].dni > 0 && jugadores[i].nombre != null)
                {
                    string nombreCompleto = jugadores[i].nombre + " " + jugadores[i].apellido;
                    float promedioGoles = 0;

                    // Evitamos la división por 0
                    if (jugadores[i].partidosJugados > 0)
                    {
                        promedioGoles = (float)jugadores[i].cantGoles / jugadores[i].partidosJugados;
                    }

                    Console.WriteLine($"| {nombreCompleto,-22} | {jugadores[i].cantGoles,-7} | {jugadores[i].partidosJugados,-8} | {promedioGoles,-14:F2} |");
                    Console.WriteLine("----------------------------------------------------------------");
                }
            }

            Console.Write("\nPulse cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        /* Método: mostrarJugadoresSinGoles
         * Filtro encargado de mostrar por consola en formato de consolas,
         * exclusivamente a los jugadores que no aportaron goles al equipo
         */
        public void mostrarJugadoresSinGoles(Jugador[] jugadores, int indice)
        {
            Console.Clear();
            Console.WriteLine("Lista de Jugadores sin Goles:\n");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("| Nombre                 | Goles   | Partidos |");
            Console.WriteLine("-----------------------------------------------");

            for (int i = 0; i < indice; i++)
            {
                // Filtro esclusivo para jugadores en el arreglo son campos completos y cantidad de goles igual a 0
                if (jugadores[i].dni > 0 && jugadores[i].nombre != null && jugadores[i].cantGoles == 0)
                {
                    string nombreCompleto = jugadores[i].nombre + " " + jugadores[i].apellido;

                    Console.WriteLine($"| {nombreCompleto,-22} | {jugadores[i].cantGoles,-7} | {jugadores[i].partidosJugados,-8} |");
                    Console.WriteLine("-----------------------------------------------");
                }
            }

            Console.Write("\nPulse cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        /* Método: mostrarJugadoresDestacados
         * Se encarga de buscar el máximo de goles anotados entre los jugadores,
         * muestra al jugador o jugadores en caso de empate con más goles en todo el equipo
         */
        public void mostrarJugadoresDestacados(Jugador[] jugadores, int indice)
        {
            Console.Clear();
            Console.WriteLine("Listado de Jugador/es Destacado/s (Máximo/s Goleador/es): ");

            int maxGoles = -1;

            // Recorremos el arreglo para encontrar el máximo de goles
            for (int i = 0; i < indice; i++)
            {
                if (jugadores[i].cantGoles > maxGoles)
                {
                    maxGoles = jugadores[i].cantGoles;
                }
            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("| Nombre                 | Goles   | Partidos |");
            Console.WriteLine("-----------------------------------------------");

            // Ahora recorremos el arreglo para imprimir por pantalla los jugadores considerados destacados
            for (int i = 0; i < indice; i++)
            {
                if (jugadores[i].cantGoles == maxGoles && maxGoles > 0)
                {
                    string nombreCompleto = jugadores[i].nombre + " " + jugadores[i].apellido;
                    Console.WriteLine($"| {nombreCompleto,-22} | {jugadores[i].cantGoles,-7} | {jugadores[i].partidosJugados,-8} |");
                    Console.WriteLine("-----------------------------------------------");
                }
            }

            Console.Write("\nPulse cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        /* Método: mostrarJugadoresRendMedio
         * Encargado de mostrar jugadores con rendimiento medio, crea una copia del arreglo
         * y realiza un ordenamiento de burbuja de mayor a menor, filtrando a los jugadores 
         *  que convirtieron goles pero no son máximos.
         */
        public void mostrarJugadoresRendMedio(Jugador[] jugadores, int indice)
        {
            Console.Clear();
            Console.WriteLine("Listado de Jugadores de Rendimiento Medio (Por debajo de los Máximos Goleadores): ");

            // Se crea un nuevo arreglo auxiliar con el tamaño del arreglo original para no alterar los datos reales
            Jugador[] auxJugadores = new Jugador[indice];

            for (int i = 0; i < indice; i++)
            {
                auxJugadores[i] = jugadores[i];
            }

            // Buscamos el máximo de goles en los jugadores para luego filtrar
            int maxGoles = -1;

            for (int i = 0; i < indice; i++)
            {
                if (jugadores[i].cantGoles > maxGoles)
                {
                    maxGoles = jugadores[i].cantGoles;
                }
            }

            // Buscamos ordenar los jugadores de la lista auxiliar con el filtro de cantidad de goles de Mayor a Menor
            for (int i = 0; i < indice; i++)
            {
                for (int j = 0; j < indice; j++)
                {
                    if (auxJugadores[i].cantGoles > auxJugadores[j].cantGoles)
                    {
                        Jugador aux = auxJugadores[i];
                        auxJugadores[i] = auxJugadores[j];
                        auxJugadores[j] = aux;
                    }
                }
            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("| Nombre                 | Goles   | Partidos |");
            Console.WriteLine("-----------------------------------------------");

            // Imprimimos por consola la nueva lista auxiliar
            for (int i = 0; i < indice; i++)
            {
                if (auxJugadores[i].cantGoles > 0 && auxJugadores[i].cantGoles < maxGoles)
                {
                    string nombreCompleto = auxJugadores[i].nombre + " " + auxJugadores[i].apellido;
                    Console.WriteLine($"| {nombreCompleto,-22} | {auxJugadores[i].cantGoles,-7} | {auxJugadores[i].partidosJugados,-8} |");
                    Console.WriteLine("-----------------------------------------------");
                }
            }

            Console.Write("\nPulse cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        /* Método: buscarPorNumero
         * Encargada de solicitar un número de camiseta al usuario y
         * realizar una busqueda entre los jugadores donde coincida
         * el número y lo muestra por pantalla
         */
        public void buscarPorNumero(Jugador[] jugadores, int indice)
        {
            int numero;
            bool encontrado = false;

            Console.Clear();
            Console.WriteLine("Buscador de Jugador por Camiseta: ");
            Console.Write("\nIngrese el número de la camiseta: ");
            numero = Convert.ToInt32(Console.ReadLine());

            // Rechazamos numeros invalidos
            while (numero < 1)
            {
                Console.Clear();
                Console.WriteLine("Buscador de Jugador por Camiseta: ");
                Console.Write("\nNúmero de camiseta invalido, reingrese otro número: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            // Buscamos la coincidencia en el arreglo
            for (int i = 0; i < indice; i++)
            {
                if (jugadores[i].numCamiseta == numero && jugadores[i].nombre != null)
                {
                    Console.WriteLine("\nJugador Encontrado: ");
                    Console.WriteLine($"\nNombre: {jugadores[i].nombre}" +
                        $"\nApellido: {jugadores[i].apellido}" +
                        $"\nDNI: {jugadores[i].dni}" +
                        $"\nNúmero de Camiseta: {jugadores[i].numCamiseta}" +
                        $"\nPosición: {jugadores[i].posicion}" +
                        $"\nPartidos Jugados: {jugadores[i].partidosJugados}" +
                        $"\nGoles Anotados: {jugadores[i].cantGoles}");
                    encontrado = true;
                    break;
                }
            }

            // En caso de no encontrar el jugador con ese número, lo informamos
            if (encontrado == false)
            {
                Console.WriteLine($"\nNo se encontró ningún jugador registrado con la camiseta número {numero}.");
            }

            Console.Write("\nPulse cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}