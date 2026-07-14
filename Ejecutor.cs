using System;

namespace Proyecto_Final_C16_Cossa_Gonzalo_Agustin
{
    public class Ejecutor
    {
        /* Método: ejecutarPrograma
         * Encargado de crear e inicializar el arreglo de jugadores del equipo deportivo,
         * carga diversos jugadores a modo de agilizar la prueba del programa. Muestra el
         * menú de opciones y le pide una opción al usuario para continuar con la lógica del programa.
         */
        public void ejecutarPrograma()
        {
            Funciones funciones = new Funciones();
            Jugador[] jugadores = new Jugador[30];
            int indice = 0;
            int opcion;

            // Carga forzada de jugadores al arreglo para agilizar pruebas.
            funciones.forzarCarga(jugadores, ref indice);

            // do-while principal donde se muestra el menú con las difentes opciones esperando una respuesta del usuario
            do
            {
                funciones.mostrarMenu();
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    // Cargar Datos de un Jugador
                    case 1:
                        if(indice < 30)
                        {
                            funciones.cargarJugador(jugadores, ref indice);
                            break;
                        }
                        else
                        {
                            Console.Write("\nNo se pueden cargar más jugadores, la lista está llena, toque cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                        }
                    // Calcular y Mostrar el promedio de Goles por Jugador
                    case 2:
                        if(indice > 0)
                        {
                            funciones.mostrarPromPorJugador(jugadores, indice);
                            break;
                        }
                        else
                        {
                            Console.Write("\nNo se encuentran jugadores cargados en el equipo, toque cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                        }
                    // Mostrar Jugadores Sin Goles
                    case 3:
                        if (indice > 0)
                        {
                            funciones.mostrarJugadoresSinGoles(jugadores, indice);
                            break;
                        }
                        else
                        {
                            Console.Write("\nNo se encuentran jugadores cargados en el equipo, toque cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                        }
                    // Mostrar Jugadores Destacados (Máximo goleador)
                    case 4:
                        if (indice > 0)
                        {
                            funciones.mostrarJugadoresDestacados(jugadores, indice);
                            break;
                        }
                        else
                        {
                            Console.Write("\nNo se encuentran jugadores cargados en el equipo, toque cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                        }
                    // Mostrar Jugadores con Rendimiento Medio (Jugadores con aporte de goles pero que no son el máximo goleador)
                    case 5:
                        if (indice > 0)
                        {
                            funciones.mostrarJugadoresRendMedio(jugadores, indice);
                            break;
                        }
                        else
                        {
                            Console.Write("\nNo se encuentran jugadores cargados en el equipo, toque cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                        }
                    // Buscar Jugador por Número de Camiseta
                    case 6:
                        if (indice > 0)
                        {
                            funciones.buscarPorNumero(jugadores, indice);
                            break;
                        }
                        else
                        {
                            Console.Write("\nNo se encuentran jugadores cargados en el equipo, toque cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                        } 
                    // Salir del Programa
                    case 7:
                        Console.Write("\nSaliendo del programa, toque cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    // En caso de que el usuario ingrese una opción no valida
                    default:
                        Console.Write("\nError, opción invalida, toque cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    }
            } while (opcion != 7);
        }
    }
}