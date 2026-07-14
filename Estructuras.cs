namespace Proyecto_Final_C16_Cossa_Gonzalo_Agustin
{
    /* Estructura: Jugador
     * Define el tipo de dato personalizado para almacenar 
     * los datos de identificación y las estadísticas deportivas de cada jugador.
     */
    public struct Jugador
    {
        // Datos de identificación del Jugador
        public string nombre;
        public string apellido;
        public int dni;
        public int numCamiseta;
        public string posicion;

        // Datos para las estadísticas de rendimiento en el torneo
        public int partidosJugados;
        public int cantGoles;
    }
}
