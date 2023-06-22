using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{


    class Persona
    {
        public string nombre;
        public int edad;
        public int dni;
        public string sexo;
        public int peso;
        public double altura;
        public Persona()
        {
        }
        public Persona(string name, int edad, string sexo)
        {
            this.nombre = name;
            this.edad = edad;
            this.sexo = sexo;
            this.altura = 0;
            this.peso = 0;



        }
        public Persona(string name, int edad, string sexo, int Peso, double Altura)
        {
            this.nombre = name;
            this.edad = edad;
            this.sexo = sexo;

            this.altura = Altura;
            this.peso = Peso;

        }
        public int calcularIMC(int pes, double altu)
        {
            int vuelve = 0;
            double pesideal = pes / (altu * altu);
            if (pesideal < 20)
            {
                vuelve = -1;

            }
            else if (pesideal >= 20 && pesideal <= 25)
            {
                vuelve = 0;
            }
            else if (pesideal > 25)
            {
                vuelve = 1;
            }
            return vuelve;

        }
        public bool Esmayordedad(int edad, bool a)
        {
            a = true;
            if (edad >= 18)
            {
                a = true;
            }
            else if (edad < 18)
            {
                a = false;
            }
            return a;

        }

        public string ComprobarSexo(string sexo)
        {
            string a = "hombre";
            string b = "mujer";
            if (sexo == a)
            {
                this.sexo = sexo;
            }
            else if (sexo == b)
            {
                this.sexo = sexo;
            }
            else
            {
                this.sexo = "H";
            }
            return this.sexo;

        }
        public int GenerarDNI()
        {
            Random r = new Random();
            int z = r.Next(10000000, 100000000);
            return z;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            Console.Write("Ingrese su nombre");
            string nom = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su peso en kg");
            int peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su altura");
            double altu = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese su sexo");
            string sexo = Console.ReadLine();
            List<Persona> lista = new List<Persona>();
            lista.Add(new Persona(nom, edad, sexo, peso, altu));
            lista.Add(new Persona(nom, edad, sexo));

            foreach (Persona persona in lista)
            {
                Console.WriteLine(persona.nombre);
                bool b = persona.Esmayordedad(persona.edad, a = true);
                if (b == true)
                {
                    Console.WriteLine("La persona es mayor");
                }
                else if (b == false)
                {
                    Console.WriteLine("La persona es menor");
                }
                Console.WriteLine(persona.ComprobarSexo(persona.sexo));

                Console.WriteLine(persona.peso);
                Console.WriteLine(persona.altura);
                int c = persona.calcularIMC(persona.peso, persona.altura);
                if (c == -1)
                {
                    Console.WriteLine("Peso  ideal");
                }
                else if (c == 0)
                {
                    Console.WriteLine("debajo de el peso ideal");
                }
                else if (c == 1)
                {
                    Console.WriteLine("Tenes sobrepeso");
                }
                Console.WriteLine(persona.GenerarDNI());

            }
            Console.ReadKey();






        }
    }
}

