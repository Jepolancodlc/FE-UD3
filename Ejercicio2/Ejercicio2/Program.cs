using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=10;
            double a=3.86;
            char c='c';

            //hecho de esta forma mas "compleja", para testear diferentes formas de programar
            Console.WriteLine("Variable N={0}, Variable A={1} Variable C={2}",n,a,c);
            Console.WriteLine("La suma de N+A es = {0}", n + a); 
            Console.WriteLine("La diferencia de N+A es = {0}", n - a);
            Console.WriteLine("Valor numerico del caracter {0} = {1}",c,char.GetNumericValue(c));
        }
    }
}
