using System;
using System.Threading;

namespace Proyecto2_Album
{
    class Program
    {
        static Album album;
        static void marcarEstampa(string codigo)
        {
            int i = album.buscarEstampa(codigo);
            if(i >= 0)
            {
                album.estampas[i].marcar();
            }
            else
            {
                Console.WriteLine("Estampa no encontrada");
            }
        }
        static void Main(string[] args)
        {
                string estampa;
                string opcion;
                int menu;
                Console.WriteLine(" _______  _______  _______           _______  _______ _________ _______ \r\n(  ____ )(  ____ )(  ___  )|\\     /|(  ____ \\(  ____ \\\\__   __/(  ___  )\r\n| (    )|| (    )|| (   ) |( \\   / )| (    \\/| (    \\/   ) (   | (   ) |\r\n| (____)|| (____)|| |   | | \\ (_) / | (__    | |         | |   | |   | |\r\n|  _____)|     __)| |   | |  \\   /  |  __)   | |         | |   | |   | |\r\n| (      | (\\ (   | |   | |   ) (   | (      | |         | |   | |   | |\r\n| )      | ) \\ \\__| (___) |   | |   | (____/\\| (____/\\   | |   | (___) |\r\n|/       |/   \\__/(_______)   \\_/   (_______/(_______/   )_(   (_______)\r\n                                                                        \r\n _        _______    _______ \r\n( (    /|(  ___  )  / ___   )\r\n|  \\  ( || (   ) |  \\/   )  |\r\n|   \\ | || |   | |      /   )\r\n| (\\ \\) || |   | |    _/   / \r\n| | \\   || |   | |   /   _/  \r\n| )  \\  || (___) |  (   (__/\\\r\n|/    )_)(_______)  \\_______/");
                Console.WriteLine("Presione enter para ingresar al proyecto");
                Console.ReadKey();
                Console.Clear();
                do
                {
                    Console.WriteLine("Ingrese sus estampas");
                    Console.WriteLine("Ingrese las estampas con el formato siguiente: BRA17");
                    estampa = Console.ReadLine();

                    marcarEstampa(estampa);
                    Console.WriteLine("Desea ingresar otra estampa? (Ingrese s/n)");
                    opcion = Console.ReadLine();
                }
                while (opcion.ToLower() == "s");
                Console.Clear();
                album = new Album();
                Console.WriteLine("PROYECTO NO.2");
                Console.WriteLine("Album mundial");
                Console.WriteLine("Bienvenido al menu inicial, ingrese la opcion que desea");
                Console.WriteLine("1. Ver estampas faltantes");
                Console.WriteLine("2. Ver estampas repetidas");
                Console.WriteLine("3. Ver nuestras estampas");
                Console.WriteLine("4. Salir");

                menu = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {
                    case 1:
                        album.mostrarFaltantes();
                        Console.ReadKey();
                        return;
                    case 2:
                        album.mostrarRepetidas();
                        Console.ReadKey();
                        return;
                    case 3:
                        album.mostrarMarcadas();
                        Console.ReadKey();
                        return;
                    case 4:
                        Console.ReadKey();
                        break;
                        default:
                        Console.WriteLine("Ingrese una opción válida");
                        return;
                }

        }
    }
}
