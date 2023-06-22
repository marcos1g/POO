using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer6
{
    /*6) Crear una clase Libro que contenga los siguientes atributos:
– ISBN
– Título
– Autor
– Número de páginas
Crear sus respectivos métodos get y set correspondientes para cada atributo. Crear el método que muestre la información relativa al libro con el siguiente formato:
«El libro con ISBN creado por el autor tiene páginas»
En el fichero main, crear 2 objetos Libro (los valores que se quieran) y mostrarlos por pantalla.
Por último, indicar cuál de los 2 tiene más páginas.
*/

    public class Libro {
        int ISBN;
        string titulo;
        string autor;
        public int nropaginas;
        public Libro(int ISBN,string tiulo,string autor,int nropaginas) { 
        this.ISBN = ISBN;
            this.titulo = tiulo;
            this.autor = autor;
            this.nropaginas = nropaginas;
        
        }

       public  int isbn
        {
            get { return ISBN; }
            set { ISBN = value; }

        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }

        }
       public  string Autor {
            get { return autor; }
            set { autor = value; }

        }
        public int Nropaginas {
            get { return nropaginas; }
            set { nropaginas = value; }

        }
        public string Mostrar(){

            return "El libro con ISBN "+this.ISBN+ " creado por el autor "+this.autor+" tiene "+this.nropaginas+ " paginas\n";


}


    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Libro> lista = new List<Libro>();
            lista.Add(new Libro(16731, "Don Quijote", "Miguel de Cervantes", 100));
            lista.Add(new Libro(12346, "LOS 7 locos", "Roberto Arlt", 249));
            foreach (Libro f in lista) {
                Console.Write(f.Mostrar());

            
            
            }
           
            int max = 0;
            foreach (Libro t in lista) {
                if (t.nropaginas > max) {
                    max = t.nropaginas;
                
                }
            
            }
            foreach (Libro q in lista) {
                if (q.nropaginas == max) {
                    Console.WriteLine("El libro con mas paginas es "+q.Titulo+" con "+q.Nropaginas+" paginas");
                    Console.ReadKey();
                }
            
            } ;
            
        }
    }
}
