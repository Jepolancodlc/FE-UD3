using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A= 1, B = 2, C = 3, D = 4;
			int B2 = B;
            Console.WriteLine("------------Valores iniciales");
            Console.WriteLine("Valor de A = "+A);
            Console.WriteLine("Valor de B = "+B);
            Console.WriteLine("Valor de C = "+C);
            Console.WriteLine("Valor de D = "+D);
            
            B = C;C = A;
            A = D; D = B2;

            Console.WriteLine("------------Valores finales");
            Console.WriteLine("Valor de A = "+A);
            Console.WriteLine("Valor de B = "+B);
            Console.WriteLine("Valor de C = "+C);
            Console.WriteLine("Valor de D = "+D);




        }
    }
}
