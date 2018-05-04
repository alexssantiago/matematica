using System;

namespace Fibonacci
{
    class Program
    {
        static int Fibonacci(int n)
        {
            int Fn = 0;
            int[] F = new int[n+1];
            //Por definição, temos que:
            F[0] = F[1] = 1;
            //Calculando F(2) em diante...
            for (int i = 2; i < F.Length; i++)
            {
                F[i] = F[i - 1] + F[i - 2];
                Fn = F[i];
            }
            return Fn;
        }

        static void Main(string[] args)
        {
            int n;
            int Fn;
            Console.WriteLine("***Sequência de Fibonacci***\n");
            Console.Write("Informe o valor de 'n': ");
            n = int.Parse(Console.ReadLine());
            Fn = Fibonacci(n);
            Console.WriteLine("\nF({0}) = {1}.", n, Fn);
            Console.ReadKey();
        }
    }
}
//alexssantiago