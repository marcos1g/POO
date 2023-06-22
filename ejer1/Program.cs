using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    class cuenta
    {
        public string titular;
        public int cantidad;
        public cuenta(string tit, int cant)
        {

            this.cantidad = cant;

        }
        public int suma(int canti)
        {
            cantidad += canti;
            return cantidad;



        }
        public int retirar(int canti2)
        {
            if (canti2 < cantidad)
            {
                cantidad -= canti2;
            }
            else if (canti2 > cantidad || canti2 == cantidad)
            {
                cantidad = 0;
            }
            return cantidad;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            cuenta cu = new cuenta("marcos", 100);
            ConsoleKeyInfo tecla;

            while (true)
            {
                Console.Clear();
                Console.Write("Presione 1 si quiere ingresar cantidad a la cuenta\n");
                Console.Write("Presione 2 si quiere retirar un monto de la cuenta\n");
                tecla = Console.ReadKey();
                Console.Clear();
                if (tecla.Key == ConsoleKey.D1)
                {


                    Console.Write("ingresar una cantidad a la cuenta ");
                    int canti = Convert.ToInt32(Console.ReadLine());
                    if (canti < 0)
                    {
                        Console.Write("Ingrese un numero positivo");
                        Console.ReadKey();

                    }
                    else
                    {
                        int pe = cu.suma(canti);
                        Console.Write("La cantidad total es de " + pe + "\n");




                        Console.Write("para volver al inicio presione caulquier tecla");

                        Console.ReadKey();
                    }



                }
                else if (tecla.Key == ConsoleKey.D2)
                {
                    Console.Write("Retirar una cantidad de la cuenta");
                    int canti2 = Convert.ToInt32(Console.ReadLine());
                    int pe2 = cu.retirar(canti2);
                    Console.Write("La cantidad total es de " + pe2 + "\n");
                    Console.Write("para volver al inicio presione caulquier tecla");
                    Console.ReadKey();




                }
            }

        }
    }
}