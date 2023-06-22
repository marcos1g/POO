using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3) Haz una clase llamada Password que siga las siguientes condiciones:
Que tenga los atributos longitud y contraseña . Por defecto, la longitud sera de 8.
Los constructores serán los siguiente:
Un constructor por defecto.
Un constructor con la longitud que nosotros le pasemos. Generará una contraseña aleatoria con esa longitud.
Los métodos que implementa serán:
esFuerte(): devuelve un booleano si es fuerte o no, para que sea fuerte debe tener mas de 2 mayúsculas, mas de 1 minúscula y mas de 5 números.
generarPassword():  genera la contraseña del objeto con la longitud que tenga.
Método get para contraseña y longitud.
Método set para longitud.
Ahora, crea una clase clase ejecutable:
Crea un array de Passwords con el tamaño que tu le indiques por teclado.
Crea un bucle que cree un objeto para cada posición del array.
Indica también por teclado la longitud de los Passwords (antes de bucle).
Crea otro array de booleanos donde se almacene si el password del array de Password es o no fuerte (usa el bucle anterior).
Al final, muestra la contraseña y si es o no fuerte (usa el bucle anterior). Usa este simple formato:
contraseña1 valor_booleano1
contraseña2 valor_bololeano2*/

namespace ejer3
{

    class Pasword
    {
        int longitud;
        string contraseña;
        Random random = new Random();
        public Pasword()
        {

        }
        public Pasword(int longi)
        {
            this.longitud = longi;

        }

        public Pasword(string contraseña)
        {
            this.contraseña = contraseña;
        }

        public Pasword(int longitud, string contraseña) 
        {
            this.contraseña = contraseña;
            this.longitud = longitud; 
        }

        public bool esFuerte(bool uno)
        {
            int mayusculas = 0;
            int minusculas = 0;
            int numeros = 0;
            bool dos;


            foreach (char c in contraseña)
            {
                if (char.IsUpper(c))
                    mayusculas++;
                else if (char.IsLower(c))
                    minusculas++;
                else if (char.IsDigit(c))
                    numeros++;
            }
            if (mayusculas > 2 && minusculas > 1 && numeros > 5)
            {
                dos = true;
            }
            else
            {
                dos = false;
            }
            return dos;

        }
        public string generarPassword(int cantidad2)
        {
            this.longitud = cantidad2;
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            contraseña = "";

            for (int i = 0; i < longitud; i++)
            {
                contraseña += caracteres[random.Next(0, caracteres.Length - 1)];
            }
            return contraseña;
        }
        public string Contraseña
        {
            get { return contraseña; }
        }

        public int Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantas contraseñas desea crear");
            int cantidad = Convert.ToInt16(Console.ReadLine());
            Console.Write("Cual quiere que sea la longitud de las contraseñas");
            int cantidad2 = Convert.ToInt16(Console.ReadLine());
            List<Pasword> lista = new List<Pasword>(cantidad);
            bool[] arr = new bool[cantidad];
            bool a = true;
            Pasword contra = new Pasword();
            for (int i = 0; i < cantidad; i++)
            {
                lista.Add(new Pasword(contra.generarPassword(cantidad2)));
                arr[i] = lista[i].esFuerte(a);
            }
            Console.WriteLine("Contraseñas generadas");
            for (int b = 0; cantidad > b; b++)
            {
                Console.WriteLine(lista[b].Contraseña);
                Console.WriteLine(arr[b]);


            }
            Console.ReadKey();



        }
    }
}
