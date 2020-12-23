using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 9, y = 10;
            double n = 4.65, m = 2.5;
            //• El valor de cada variable.
            Console.WriteLine("El valor de x es = " + x);
            Console.WriteLine("El valor de y es = " + y);
            Console.WriteLine("El valor de n es = " + n);
            Console.WriteLine("El valor de m es = " + m);

            //• La suma X + Y
            Console.WriteLine("La suma de x + y es = {0}", x + y);

            //• La diferencia X – Y
            Console.WriteLine("La diferencia de x - y es = {0}", x - y);

            //• El producto X* Y
            Console.WriteLine("El producto X* Y es = {0}", x * y);

            //• El cociente X / Y
            Console.WriteLine("El cociente X / Y es = {0}", x / y);

            //• El resto X % Y
            Console.WriteLine("El resto X % Y es = {0}", x % y);

            //• La suma N + M
            Console.WriteLine("La suma de n + m es = {0}", n + m);

            //• La diferencia N – M
            Console.WriteLine("La diferencia de n - m es = {0}", n - m);

            //• El producto N* M
            Console.WriteLine("El producto de n * m es = {0}", n * m);

            //• El cociente N / M
            Console.WriteLine("El cociente de n / m es = {0}", n / m);

            //• El resto N % M
            Console.WriteLine("El resto de n % m es = {0}", n % m);

            //• La suma X + N
            Console.WriteLine("La suma de x + n es = {0}", n + x);

            //• El cociente Y / M
            Console.WriteLine("EL cociente de y + m es = {0}", y / m);

            //• El resto Y % M
            Console.WriteLine("El rest de y + m es = {0}", y % m);

            //• El doble de cada variable
            Console.WriteLine("El valor del doble de x es = " + (x * 2));
            Console.WriteLine("El valor del doble de y es = " + (y * 2));
            Console.WriteLine("El valor del doblede n es = {0}", n * 2);
            Console.WriteLine("El valor del doblede m es = {0}", m * 2);

            //• La suma de todas las variables
            Console.WriteLine("La suma de todas las variables es = {0}", n + m + y + x);
            //• El producto de todas las variables
            Console.WriteLine("El producto de todas las variables es = {0}", n*m * y * x);
        }
    }
}
