using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Playlist
    {
        public String nombrePlaylist;

        public List<Cancion> listaPlaylist = new List<Cancion>();

        public List<Espotifai> espotifaiPlaylist = new List<Espotifai>();

        public Playlist(String nombre, Cancion cancion)
        {

          this.nombrePlaylist = nombre;

        }

        public void InformacionPlaylist()
        {

            Console.WriteLine(nombrePlaylist);

        }
    }
}
