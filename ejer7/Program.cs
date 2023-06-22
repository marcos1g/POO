using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ej007
{









    //7) Vamos a realizar una clase llamada Raíces, donde representaremos los valores de una ecuación de 2º grado.
    //Tendremos los 3 coeficientes como atributos, llamémosles a, b y c.
    //Hay que insertar estos 3 valores para construir el objeto.
    //Las operaciones que se podrán hacer son las siguientes:
    //obtenerRaices(): imprime las 2 posibles soluciones
    //obtenerRaiz(): imprime una única raíz, que será cuando solo tenga una solución posible.
    //getDiscriminante(): devuelve el valor del discriminante (double), el discriminante tiene la siguiente fórmula, (b^2)-4* a* c
    //tieneRaices() : devuelve un booleano indicando si tiene dos soluciones, para que esto ocurra, el discriminante debe ser mayor o igual que 0.
    //tieneRaiz() : devuelve un booleano indicando si tiene una única solución, para que esto ocurra, el discriminante debe ser igual que 0.
    //calcular() : mostrará por consola las posibles soluciones que tiene nuestra ecuación, en caso de no existir solución, mostrarlo también.
    //Fórmula ecuación 2º grado: (-b±√((b^2)-(4* a* c)))/(2* a)
    //Solo varía el signo delante de -b


    public class Raices
    {
        double a;
        double b;
        double c;
        double discriminante;
        bool raiz;
        bool raices;
        public Raices(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.discriminante = Discriminante();
            this.raiz = TieneRaiz(discriminante);
            this.raices = TieneRaices(discriminante);
        }
        public double Discriminante()
        {
            double discriminante;
            discriminante = (b * b) - (4 * (a) * (c));
            return discriminante;
        }
        public bool TieneRaices(double discrimante)
        {
            if (discrimante > 0) { return true; }
            return false;
        }
        public bool TieneRaiz(double discrimante)
        {
            if (discrimante == 0) { return true; }
            return false;
        }
        public string ObtenerRaiz()
        {

            double cuadraticap;
            double cuadratican;
            cuadraticap = (((-1) * (b)) + (Math.Sqrt(discriminante))) / (2 * a);
            cuadratican = (((-1) * (b)) - (Math.Sqrt(discriminante))) / (2 * a);
            if (cuadratican == cuadraticap)
            {
                return "la raiz es" + cuadratican;
            }
            return "Las raices son " + cuadraticap + " y  " + cuadratican;
        }
        public string Calcular()
        {
            if (TieneRaices(this.discriminante))
            {
                return ObtenerRaiz();
            }
            if (TieneRaiz(this.discriminante))
            {
                return ObtenerRaiz();
            }
            return "Tiene raices complejas";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Raices> raices = new List<Raices>();
            raices.Add(new Raices(-12.5, -35, -45));
            Console.WriteLine(raices[0].Calcular());
            Console.ReadKey();
        }
    }
}
