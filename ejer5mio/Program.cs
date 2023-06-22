using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*5) Crearemos una clase llamada Serie con las siguientes características:
Sus atributos son título, número de temporadas, entregado, genero y creador.
Por defecto, el número de temporadas es de 3 temporadas y entregado false. El resto de atributos serán valores por defecto según el tipo del atributo.
Los constructores que se implementarán serán:
Un constructor por defecto.
Un constructor con título y creador. El resto por defecto.
Un constructor con todos los atributos, excepto de entregado.
Los métodos que se implementara serán:
Métodos de todos los atributos, excepto de entregado.
Métodos set de todos los atributos, excepto de entregado.
Crearemos una clase Videojuego con las siguientes características:
Sus atributos son titulo, horas estimadas, entregado, genero y compañia.
Por defecto, las horas estimadas serán de 10 horas y entregado false. El resto de atributos serán valores por defecto según el tipo del atributo.
Los constructores que se implementarán serán:
Un constructor por defecto.
Un constructor con el título y horas estimadas. El resto por defecto.
Un constructor con todos los atributos, excepto de entregado.
Los métodos que se implementara serán:
Métodos get de todos los atributos, excepto de entregado.
Métodos set de todos los atributos, excepto de entregado.
Como vemos, en principio, las clases anteriores no son padre-hija, pero si tienen en común, por eso vamos a hacer una interfaz llamada Entregable con los siguientes métodos:
entregar(): cambia el atributo prestado a true.
devolver(): cambia el atributo prestado a false.
isEntregado(): devuelve el estado del atributo prestado.
Método compareTo (Object a), compara las horas estimadas en los videojuegos y en las series el número de temporadas. Como parámetro que tenga un objeto, no es necesario que implementen la interfaz Comparable. Recuerda el uso de los casting de objetos.
Implementa los anteriores métodos en las clases Videojuego y Serie. Ahora crea una aplicación ejecutable y realiza lo siguiente:
Crea dos arrays, uno de Series y otro de Videojuegos, de 5 posiciones cada uno.
Crea un objeto en cada posición del array, con los valores que desees, puedes usar distintos constructores.
Entrega algunos Videojuegos y Series con el método entregar().
Cuenta cuantos Series y Videojuegos hay entregados. Al contarlos, devuelvelos.
Por último, indica que el Videojuego tiene más horas estimadas y la serie con mas temporadas. Muestran en pantalla con toda su información*/


namespace ejer5
{
    interface Entregable
    {
        void entregar();
        void devolver();

        bool isEntregado();


    }
    class Serie
    {
        string titulo = "";
        int nrotemporadas = 3;
       public bool entregado = false;
        string genero = "";
        string creador = "";

        public Serie() { }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;

        }
        public Serie(string titulo, int nrotemporadas, string genero, string creador)
        {
            this.titulo = titulo;
            this.nrotemporadas = nrotemporadas;
            this.genero = genero;
            this.creador = creador;


        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public int Nrotemporadas
        {

            get { return nrotemporadas; }
            set { nrotemporadas = value; }
        }
        public string Creador
        {
            get { return creador; }
            set { creador = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public void entregar()
        {
            this.entregado = true;
        }
        public void devolver()
        {
            this.entregado = false;
        }

        public bool isEntregado()
        {
            return this.entregado;
        }



    }

    class Videojuegos : Entregable
    {
        string titulo = "";
        int hrsestimadas = 10;
       public bool entregado = false;
        string genero = "";
        string compañia = "";
        public Videojuegos() { }

        public Videojuegos(string titulo, string compañia)
        {
            this.titulo = titulo;
            this.compañia = compañia;

        }
        public Videojuegos(string titulo, int hrsestimadas, string genero, string compañia)
        {
            this.titulo = titulo;
            this.hrsestimadas = hrsestimadas;
            this.genero = genero;
            this.compañia = compañia;


        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public int Hrsestimadas
        {

            get { return hrsestimadas; }
            set { hrsestimadas = value; }
        }
        public string Compañia
        {
            get { return compañia; }
            set { compañia = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public void entregar()
        {
            this.entregado = true;
        }
        public void devolver()
        {
            this.entregado = false;
        }

        public bool isEntregado()
        {
            return this.entregado;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Serie> lista = new List<Serie>(5);
            lista.Add(new Serie());
            lista.Add(new Serie("Spectro", "Judini"));
            lista.Add(new Serie("TedLaso", 5, "entretenimineto", "Judini"));
            lista.Add(new Serie("RYP", "Judinijr"));
            lista.Add(new Serie("Mad", 7, "comedya", "MAD"));

            List<Videojuegos> lista2 = new List<Videojuegos>(5);
            lista2.Add(new Videojuegos());
            lista2.Add(new Videojuegos("COD", "CODMunyti"));
            lista2.Add(new Videojuegos("Minecraft", 8, "supervivencia", "Launcher"));
            lista2.Add(new Videojuegos("GOW", "Niidea"));
            lista2.Add(new Videojuegos("ARK", 10, "supervivencia", "Niidea2"));
            int a = 0;
            int b = 0;
            int series2 = 0;
            int videojuegos2=0;

                lista[0].entregar();
                lista[3].entregar();
                lista[4].entregar();
            

                lista2[0].entregar();
                lista2[3].entregar();
                lista2[4].entregar();
            
            
            foreach (Serie s in lista) {
                if (s.entregado==true) {
                    series2++;
                
                }
            
            
            }
            foreach (Videojuegos x in lista2)
            {
                if (x.entregado == true)
                {
                    videojuegos2++;

                }


            }
            int max1 = 0;
            var count = lista.Count();
            for (int e=0;e < count;e++) {
                if (lista[e].Nrotemporadas>count) {
                    max1 = lista[e].Nrotemporadas;      
                }
            
            
            }
            int max2 = 0;
            var count2 = lista2.Count();
            for (int q = 0; q < count2; q++)
            {
                if (lista2[q].Hrsestimadas > count2)
                {
                    max2 = lista2[q].Hrsestimadas;
                }


            }
            Console.WriteLine("Series entregadas="+series2);
            foreach (Serie f in lista) {
                if (f.Nrotemporadas==max1) {
                    Console.WriteLine("Serie con mayor cantidad de temporadas: ");
                    Console.WriteLine("- Título: " + f.Titulo);
                    Console.WriteLine("- Temporadas: " + f.Nrotemporadas);
                    Console.WriteLine("- Género: " + f.Genero);
                    Console.WriteLine("- Autor: " + f.Creador);
                   

                }
            
            }
            Console.WriteLine("Videojuegos entregados="+ videojuegos2);

            foreach (Videojuegos g in lista2)
            {
                if (g.Hrsestimadas == max2)
                {
                    Console.WriteLine("Videojuego con mayor cantidad de temporadas: ");
                    Console.WriteLine("- Título: " + g.Titulo);
                    Console.WriteLine("- Temporadas: " + g.Hrsestimadas);
                    Console.WriteLine("- Género: " + g.Genero);
                    Console.WriteLine("- Autor: " + g.Compañia);
                    Console.ReadKey();

                }

            }



        }
    }
}

