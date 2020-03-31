using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Cancion
    {
        public String nombre;

        public String album;

        public String artista;

        public String genero;

        

        public Cancion(String Genero, String Artista, String Album, String Nombre)
        {
            this.genero = Genero;

            this.artista = Artista;

            this.album = Album;

            this.nombre = Nombre;   
        }


        public String Informacion()
        {
            String info;

            info = "genero: " + genero + ", artista: " + artista + ", album: " + album + ", nombre: " + nombre;

            return info;
        }

    }
}
