using System;
using System.Collections.Generic;
using System.Text; 

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Espotifai listaCancion = new Espotifai();

            String variable;

            String s1 = null;

            Console.WriteLine("Bienvenido a Espotifai!");

            while (true)
            {
                Console.WriteLine("Presiona {n} para ingresar");

                variable = Console.ReadLine();

                if (variable == "n")

                    break;

                else

                    continue;
            }

            while (s1 != "3")
            {

                Console.WriteLine("\nElige un opcion ingresando 1, 2 o 3\n" +
                  "\n[1] Ver todas las canciones." +
                  "\n[2] Agregar una cancion." +
                  "\n[3] Salir del programa." +
                  "\n[4] Ver canciones por criterio." +
                  "\n[5] Crear Playlist" +
                  "\n[6] Ver mis Playlist");

                s1 = Console.ReadLine();

                switch (s1)
                {
                    case "1":

                        Console.WriteLine("\nOpcion Ver canciones\n");

                        listaCancion.VerCanciones();

                        break;

                    case "2":

                        String genero, artista, album, nombre;

                        Console.WriteLine("\nOpcion Agregar cancion\n");

                        Console.WriteLine("Ingrese Genero");

                        genero = Console.ReadLine();

                        Console.WriteLine("Ingrese Artista");

                        artista = Console.ReadLine();

                        Console.WriteLine("Ingrese Album");

                        album = Console.ReadLine();

                        Console.WriteLine("Ingrese Nombre");

                        nombre = Console.ReadLine();

                        Cancion cancion = new Cancion(genero, artista, album, nombre);

                        Console.WriteLine("\n");

                        Console.WriteLine(cancion.Informacion());

                        Console.WriteLine(listaCancion.AgregarCancion(cancion));

                        break;


                    case "3":

                        Console.WriteLine("\nOpcion Salir\n");

                        break;


                    case "4":

                        String criterio, valor;

                        List<List<String>> listaCriterioValor = new List<List<String>>();

                        Console.WriteLine("\nIngrese Criterio:");

                        criterio = Console.ReadLine();

                        if (criterio != "Genero" && criterio != "Artista" && criterio != "Album" && criterio != "Nombre")
                        {
                            Console.WriteLine("\nError en el criterio de busqueda");

                            break;
                        }

                        Console.WriteLine("\nIngrese Valor:");

                        valor = Console.ReadLine();

                        listaCriterioValor = listaCancion.CancionesPorCriterio(criterio, valor);

                        foreach (var i in listaCriterioValor)

                                Console.WriteLine("genero: " + i[0] + ", artista: " + i[1] + ", album: " + i[2] + ", nombre: " + i[3]);

                        break;

                    case "5":

                        String criterioPlaylist, valorCriterio, nombrePlaylist;

                        Console.WriteLine("\nIngrese Criterio:");

                        criterioPlaylist = Console.ReadLine();

                        if (criterioPlaylist != "Genero" && criterioPlaylist != "Artista" && criterioPlaylist != "Album" && criterioPlaylist != "Nombre")
                        {
                            Console.WriteLine("\nError en el criterio de busqueda");

                            break;
                        }

                        Console.WriteLine("\nIngrese Valor:");

                        valorCriterio = Console.ReadLine();

                        Console.WriteLine("\nIngrese Nombre Playlist:");

                        nombrePlaylist = Console.ReadLine();

                        Console.WriteLine(listaCancion.GenerarPlaylist(criterioPlaylist, valorCriterio, nombrePlaylist));

                        break;

                    case "6":

                        Console.WriteLine("\nSus Playlist son:\n");

                        listaCancion.VerMisPlaylists();

                        break;
                }
            }

        }
    

        //static void IncrementoUno()
        //{
            //String genero, artista, album, nombre;

            //Console.WriteLine("Ingrese Genero");

            //genero = Console.ReadLine();

            //Console.WriteLine("Ingrese Artista");

            //artista = Console.ReadLine();

            //Console.WriteLine("Ingrese Album");

            //album = Console.ReadLine();

            //Console.WriteLine("Ingrese Nombre");

            //nombre = Console.ReadLine();

            //Cancion cancion = new Cancion(genero, artista, album, nombre);

            //Console.WriteLine(cancion.Informacion());

            //Espotifai listaCancion = new Espotifai();

            //Console.WriteLine(listaCancion.AgregarCancion(cancion));

            //listaCancion.VerCanciones();

        //}
        static void IncrementoDos()
        {
                //
        }
    }
}
