using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            //   • Incrementar N en 77.
            // • Decrementarla en 3.
            //   • Duplicar su valor

            Console.WriteLine("El valor inicial de N es = {0}, El incremento en 77 da {1}, El decremento en 3 es igual a {2}," +
             "Al duplicar su valor da {3}", n, n += 77, n-=3, n *= 2);

        }
    }
}
