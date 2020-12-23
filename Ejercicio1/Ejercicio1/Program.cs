using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //hecho de esta forma mas "compleja", para testear diferentes formas de programar

            int x = 15, n = 10;
            Console.WriteLine("El total de la suma es: {0}", x+n);
            Console.WriteLine("El total de la rests es: {0}", x - n);
            Console.WriteLine("El total de la multiplicacion es: {0}", x * n);
            Console.WriteLine("El total de la division es: {0}", x / n);
            Console.WriteLine("El total del modulo es: {0}", x % n);
        }
    }
}
