using System;
using System.Collections.Generic;
using System.Text;


namespace Lab2
{
    class Espotifai
    {
        public List<List<String>> listaCanciones = new List<List<String>>();

        public List<List<String>> listaAlmacenarPlaylist = new List<List<String>>();

        public  List<String> listaInformacion = new List<String>();

        private int largoListaCanciones;

        private int activador = 1;

        public Espotifai()
        {
            //
        }

        public List<String> ListaCancion(Cancion cancion)
        {
            List<String> listaCancion = new List<String>();

            listaCancion.Add(cancion.genero);

            listaCancion.Add(cancion.artista);

            listaCancion.Add(cancion.album);

            listaCancion.Add(cancion.nombre);

            return listaCancion;
        }

        public bool AgregarCancion(Cancion cancion)
        {
            ListaCancion(cancion);

            String informacion;

            foreach (var i in listaCanciones)
            
                    if (i[0] == ListaCancion(cancion)[0] && i[1] == ListaCancion(cancion)[1] && i[2] == ListaCancion(cancion)[2] && i[3] == ListaCancion(cancion)[3])
                            
                            return false;
                         
            listaCanciones.Add(ListaCancion(cancion));

            largoListaCanciones++;

            informacion = "genero: " + cancion.genero + ", artista: " + cancion.artista + ", album: " + cancion.album + ", nombre: " + cancion.nombre;

            listaInformacion.Add(informacion);
            
            return true;
        }

        public void VerCanciones()
        {
            foreach (var i in listaInformacion)
            {
                Console.WriteLine(i);
            }
        }

        public List<List<String>> CancionesPorCriterio(String criterio, String valor)
        {
            List<List<String>> listaMomentanea = new List<List<String>>();

            int contador = 0;

            if (criterio == "Genero")

                foreach (var i in listaCanciones)
                {
                    if (valor == i[0])

                        listaMomentanea.Add(listaCanciones[contador]);

                    contador++;
                }

            else if (criterio == "Artista")

                foreach (var i in listaCanciones)
                {
                    if (valor == i[1])

                        listaMomentanea.Add(listaCanciones[contador]);

                    contador++;
                }

            else if (criterio == "Album")

                foreach (var i in listaCanciones)
                {
                    if (valor == i[2])

                        listaMomentanea.Add(listaCanciones[contador]);

                    contador++;
                }

            else if (criterio == "Nombre")

                foreach (var i in listaCanciones)
                {
                    if (valor == i[3])

                        listaMomentanea.Add(listaCanciones[contador]);

                    contador++;
                }

            return listaMomentanea;
        }

        public bool GenerarPlaylist(String criterio, String valorCriterio, String nombrePlaylist)
        {
            List<String> listaMomentanea2 = new List<String>();

            int contador = 0;

            int ayuda = 0;

            if (criterio == "Genero")
            {
                foreach (var i in listaCanciones)
                {
                    if (valorCriterio == i[0])
                    {
                        listaMomentanea2.Add("genero: " + listaCanciones[contador][0] + ", artista: " + listaCanciones[contador][1] + ", album: " + listaCanciones[contador][2] + ", nombre: " + listaCanciones[contador][3]);

                        ayuda++;
                    }

                    contador++;
                }

                if (activador != 1)
                {
                    if (ayuda == 0)
                    {

                        return false;

                    }
                }

            }

            else if (criterio == "Artista")
            {
                foreach (var i in listaCanciones)
                {
                    if (valorCriterio == i[1])
                    {
                        listaMomentanea2.Add("genero: " + listaCanciones[contador][0] + ", artista: " + listaCanciones[contador][1] + ", album: " + listaCanciones[contador][2] + ", nombre: " + listaCanciones[contador][3]);

                        ayuda++;
                    }

                    contador++;
                }

                if (activador != 1)
                {
                    if (ayuda == 0)
                    {

                        return false;

                    }
                }

            }

            else if (criterio == "Album")
            {
                foreach (var i in listaCanciones)
                {
                    if (valorCriterio == i[2])
                    {
                        listaMomentanea2.Add("genero: " + listaCanciones[contador][0] + ", artista: " + listaCanciones[contador][1] + ", album: " + listaCanciones[contador][2] + ", nombre: " + listaCanciones[contador][3]);

                        ayuda++;
                    }

                    contador++;
                }

                if (activador != 1)
                {
                    if (ayuda == 0)
                    {

                        return false;

                    }
                }

            }

            else if (criterio == "Nombre")
            {
                foreach (var i in listaCanciones)
                {
                    if (valorCriterio == i[3])
                    {
                        listaMomentanea2.Add("genero: " + listaCanciones[contador][0] + ", artista: " + listaCanciones[contador][1] + ", album: " + listaCanciones[contador][2] + ", nombre: " + listaCanciones[contador][3]);

                        ayuda++;
                    }

                    contador++;
                }

                if (activador != 1)
                {
                    if (ayuda == 0)
                    {

                        return false;

                    }
                }

            }

            if (activador == 1)
            {

                listaMomentanea2.Add(nombrePlaylist);

                listaAlmacenarPlaylist.Add(listaMomentanea2);

                activador--;

                return true;
            }

            else if (activador == 0)
            {
                foreach (var i in listaAlmacenarPlaylist)

                    if (i[i.Count - 1] == nombrePlaylist)

                        return false;
            }

            else
            {
                listaMomentanea2.Add(nombrePlaylist);

                listaAlmacenarPlaylist.Add(listaMomentanea2);
            }

            return true;
        }

        public void VerMisPlaylists() 
        {
            List<String> listaMomentaneaInformacion = new List<String>();

            int contador = 0;

            foreach (var i in listaAlmacenarPlaylist)
            {
                Console.WriteLine($"Nombre Playlist: {i[i.Count-1]}\n");

                Console.WriteLine(i[contador]);

                contador++;
            }

            if (activador == 1)

                Console.WriteLine("\nNo tiene Playlist disponibles");

        }
    }
}
