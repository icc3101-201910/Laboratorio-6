using System;

namespace laboratorio06
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al gestionador de tus series!");

            Gestionador miGestionador = new Gestionador();
            miGestionador.CargarSeries();

            while (true) {
                Console.WriteLine("Opciones disponibles:");
                Console.WriteLine("[1] Agregar serie");
                Console.WriteLine("[2] Mostrar series");
                Console.WriteLine("[3] Guardar series");
                Console.WriteLine("[4] Editar estado de serie");
                Console.WriteLine("[5] Cerrar programa");

                string opcion = Console.ReadLine();

                if (opcion == "1") {
                    Console.WriteLine("Nombre de la serie:");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("Temporada de la serie:");
                    string temporada = Console.ReadLine();

                    Console.WriteLine("Año de la temporada:");
                    int anio = int.Parse(Console.ReadLine());

                    Console.WriteLine("Estado:");
                    string estado = Console.ReadLine();

                    Serie miSerie = new Serie(nombre, temporada, anio, estado);
                    miGestionador.AgregarSerie(miSerie);

                } else if (opcion == "2") {
                    miGestionador.MostrarSeries();
                } else if (opcion == "3") {
                    miGestionador.GuardarSeries();
                } else if (opcion == "4") {
                    Console.WriteLine("Elige la serie a editar (ingresa su posición):");
                    miGestionador.MostrarSeries();

                    int posicion = int.Parse(Console.ReadLine());

                    Console.WriteLine("¿Cuál es el nuevo estado?");
                    string nuevoEstado = Console.ReadLine();

                    Serie porEditar = miGestionador.GetSerie(posicion);
                    porEditar.SetEstado(nuevoEstado);

                } else {
                    Console.WriteLine("Nos vemos!");
                    break;
                }
            }


        }
    }
}
